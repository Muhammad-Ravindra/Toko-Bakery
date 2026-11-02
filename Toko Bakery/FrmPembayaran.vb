Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Public Partial Class FrmPembayaran
        Public Sub New()
            InitializeComponent()
            UiHelpers.ConfigureGrid(dgvRiwayatBayar)
            cmbJenisBayar.SelectedItem = "DP"
            cmbMetode.Text = "transfer"
            dtpTanggalBayar.Value = Date.Today
            AddHandler btnBayar.Click, Sub(sender, e) SimpanPembayaran()
            AddHandler btnBersihkan.Click, Sub(sender, e) Bersihkan()
            AddHandler cmbPesanan.SelectedIndexChanged, Sub(sender, e) MuatRingkasan()
            AddHandler Me.Load, Sub(sender, e) MuatPesanan()
        End Sub

        Private Function IdPesananTerpilih() As Integer?
            If cmbPesanan.SelectedValue Is Nothing Then Return Nothing
            Dim id As Integer
            If Integer.TryParse(Convert.ToString(cmbPesanan.SelectedValue), id) AndAlso id > 0 Then Return id
            Return Nothing
        End Function

        Private Sub MuatPesanan()
            Try
                Dim table = Database.Query("SELECT ps.id_pesanan, CONCAT('Pesanan #', ps.id_pesanan, ' - ', pl.nama) AS pilihan FROM pesanan ps INNER JOIN pelanggan pl ON pl.id_pelanggan=ps.id_pelanggan WHERE ps.sisa > 0 ORDER BY ps.id_pesanan DESC")
                cmbPesanan.DataSource = table
                cmbPesanan.DisplayMember = "pilihan"
                cmbPesanan.ValueMember = "id_pesanan"
                MuatRingkasan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat daftar pesanan")
            End Try
        End Sub

        Private Sub MuatRingkasan()
            Dim id As Integer? = IdPesananTerpilih()
            If Not id.HasValue Then
                txtPelanggan.Clear()
                txtTotal.Clear()
                txtSudahBayar.Clear()
                txtSisaTagihan.Clear()
                dgvRiwayatBayar.DataSource = Nothing
                Return
            End If
            Try
                Dim header = Database.Query("SELECT pl.nama, ps.total, ps.sisa FROM pesanan ps INNER JOIN pelanggan pl ON pl.id_pelanggan=ps.id_pelanggan WHERE ps.id_pesanan=@id", New MySqlParameter("@id", id.Value))
                If header.Rows.Count = 0 Then Return
                Dim row = header.Rows(0)
                txtPelanggan.Text = Convert.ToString(row("nama"))
                Dim total As Decimal = Convert.ToDecimal(row("total"))
                Dim sisa As Decimal = Convert.ToDecimal(row("sisa"))
                Dim sudahBayar As Decimal = Convert.ToDecimal(Database.Scalar("SELECT COALESCE(SUM(jumlah), 0) FROM pembayaran WHERE id_pesanan=@id", New MySqlParameter("@id", id.Value)))
                txtTotal.Text = total.ToString("N2")
                txtSudahBayar.Text = sudahBayar.ToString("N2")
                txtSisaTagihan.Text = sisa.ToString("N2")
                numJumlahBayar.Maximum = Math.Max(sisa, 0.01D)
                If numJumlahBayar.Value > numJumlahBayar.Maximum Then numJumlahBayar.Value = numJumlahBayar.Maximum
                dgvRiwayatBayar.DataSource = Database.Query("SELECT id_bayar, tgl_bayar, jumlah, metode, jenis FROM pembayaran WHERE id_pesanan=@id ORDER BY tgl_bayar DESC, id_bayar DESC", New MySqlParameter("@id", id.Value))
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat ringkasan pembayaran")
            End Try
        End Sub

        Private Sub SimpanPembayaran()
            Dim id As Integer? = IdPesananTerpilih()
            If Not id.HasValue Then
                MessageBox.Show("Tidak ada pesanan dengan sisa tagihan. Silakan pilih atau buat pesanan terlebih dahulu.")
                Return
            End If
            If numJumlahBayar.Value <= 0D Then
                MessageBox.Show("Jumlah pembayaran harus lebih dari nol.")
                Return
            End If
            If String.IsNullOrWhiteSpace(cmbMetode.Text) Then
                MessageBox.Show("Metode pembayaran wajib diisi.")
                Return
            End If
            Try
                Using connection = Database.CreateConnection()
                    connection.Open()
                    Using transaction = connection.BeginTransaction()
                        Try
                            Dim sisaSaatIni As Decimal
                            Using check As New MySqlCommand("SELECT total, sisa FROM pesanan WHERE id_pesanan=@id FOR UPDATE", connection, transaction)
                                check.Parameters.AddWithValue("@id", id.Value)
                                Using reader = check.ExecuteReader()
                                    If Not reader.Read() Then Throw New InvalidOperationException("Pesanan tidak ditemukan.")
                                    sisaSaatIni = reader.GetDecimal(reader.GetOrdinal("sisa"))
                                End Using
                            End Using
                            Dim jenis As String = If(cmbJenisBayar.SelectedItem Is Nothing, "DP", Convert.ToString(cmbJenisBayar.SelectedItem))
                            If numJumlahBayar.Value > sisaSaatIni Then Throw New InvalidOperationException("Jumlah pembayaran melebihi sisa tagihan.")
                            If jenis = "LUNAS" AndAlso numJumlahBayar.Value <> sisaSaatIni Then Throw New InvalidOperationException("Pembayaran berjenis LUNAS harus sama dengan sisa tagihan.")
                            If jenis = "DP" AndAlso numJumlahBayar.Value >= sisaSaatIni Then Throw New InvalidOperationException("Jika pembayaran menutup seluruh sisa tagihan, pilih jenis LUNAS.")
                            Using insert As New MySqlCommand("INSERT INTO pembayaran (id_pesanan, tgl_bayar, jumlah, metode, jenis) VALUES (@id, @tanggal, @jumlah, @metode, @jenis)", connection, transaction)
                                insert.Parameters.AddWithValue("@id", id.Value)
                                insert.Parameters.AddWithValue("@tanggal", dtpTanggalBayar.Value.Date)
                                insert.Parameters.AddWithValue("@jumlah", numJumlahBayar.Value)
                                insert.Parameters.AddWithValue("@metode", cmbMetode.Text.Trim())
                                insert.Parameters.AddWithValue("@jenis", jenis)
                                insert.ExecuteNonQuery()
                            End Using
                            Dim totalBayar As Decimal
                            Using sumCommand As New MySqlCommand("SELECT COALESCE(SUM(jumlah),0) FROM pembayaran WHERE id_pesanan=@id", connection, transaction)
                                sumCommand.Parameters.AddWithValue("@id", id.Value)
                                totalBayar = Convert.ToDecimal(sumCommand.ExecuteScalar())
                            End Using
                            Dim updateSql As String = "UPDATE pesanan SET sisa=GREATEST(total-@terbayar,0), dp=CASE WHEN @jenis='DP' THEN dp+@jumlah ELSE dp END, status_bayar=CASE WHEN @terbayar>=total THEN 'LUNAS' WHEN @terbayar>0 THEN 'DP' ELSE 'BELUM' END WHERE id_pesanan=@id"
                            Using updateCommand As New MySqlCommand(updateSql, connection, transaction)
                                updateCommand.Parameters.AddWithValue("@terbayar", totalBayar)
                                updateCommand.Parameters.AddWithValue("@jenis", jenis)
                                updateCommand.Parameters.AddWithValue("@jumlah", numJumlahBayar.Value)
                                updateCommand.Parameters.AddWithValue("@id", id.Value)
                                updateCommand.ExecuteNonQuery()
                            End Using
                            transaction.Commit()
                        Catch
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
                MessageBox.Show("Pembayaran berhasil dicatat.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MuatPesanan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menyimpan pembayaran")
            End Try
        End Sub

        Private Sub Bersihkan()
            dtpTanggalBayar.Value = Date.Today
            numJumlahBayar.Value = Math.Min(0.01D, numJumlahBayar.Maximum)
            cmbMetode.Text = "transfer"
            cmbJenisBayar.SelectedItem = "DP"
        End Sub

        Private Sub FrmPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
