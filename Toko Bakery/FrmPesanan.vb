Imports System
Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Public Partial Class FrmPesanan
        Private ReadOnly _detailTable As New DataTable()
        Private bsPelanggan As New BindingSource()
        Private _updatingSummary As Boolean = False

        Public Sub New()
            InitializeComponent()
            cmbStatusBayar.Enabled = False
            UiHelpers.ConfigureGrid(dgvDetailPesanan)
            dgvDetailPesanan.AutoGenerateColumns = False
            _detailTable.Columns.Add("id_produk", GetType(Integer))
            _detailTable.Columns.Add("nama_produk", GetType(String))
            _detailTable.Columns.Add("qty", GetType(Integer))
            _detailTable.Columns.Add("harga_satuan", GetType(Decimal))
            _detailTable.Columns.Add("subtotal", GetType(Decimal))
            dgvDetailPesanan.DataSource = _detailTable
            AddHandler btnTambahItem.Click, Sub(sender, e) TambahItem()
            AddHandler btnHapusItem.Click, Sub(sender, e) HapusItem()
            AddHandler btnSimpan.Click, Sub(sender, e) SimpanPesanan()
            AddHandler btnBersihkan.Click, Sub(sender, e) Bersihkan()
            AddHandler cmbProduk.SelectedIndexChanged, Sub(sender, e) PerbaruiHargaProduk()
            AddHandler numQty.ValueChanged, Sub(sender, e) HitungSubtotalItem()
            AddHandler numDP.ValueChanged, Sub(sender, e) HitungRingkasan()
            AddHandler Me.Load, Sub(sender, e) MuatPilihan()
            AddHandler cmbPelanggan.TextUpdate, Sub(sender, e) FilterPelanggan()
            AddHandler cmbPelanggan.DropDownClosed, Sub(sender, e) ResetFilterPelanggan()
        End Sub

        Private Sub MuatPilihan()
            Try
                cmbPelanggan.DropDownStyle = ComboBoxStyle.DropDown ' Allows typing
                bsPelanggan.DataSource = Database.Query("SELECT id_pelanggan, CONCAT(id_pelanggan, ' - ', nama) AS pilihan FROM pelanggan ORDER BY nama")
                cmbPelanggan.DataSource = bsPelanggan
                cmbPelanggan.DisplayMember = "pilihan"
                cmbPelanggan.ValueMember = "id_pelanggan"

                cmbProduk.DataSource = Database.Query("SELECT id_produk, nama_produk, harga_jual, CONCAT(id_produk, ' - ', nama_produk) AS pilihan FROM produk ORDER BY nama_produk")
                cmbProduk.DisplayMember = "pilihan"
                cmbProduk.ValueMember = "id_produk"
                cmbSumber.Text = "WA"
                cmbStatusPesanan.SelectedItem = "BARU"
                cmbStatusBayar.SelectedItem = "BELUM"
                dtpTanggalPesan.Value = Date.Today
                PerbaruiHargaProduk()
                HitungRingkasan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat pilihan pelanggan/produk")
            End Try
        End Sub

        Private Function ProdukTerpilih() As DataRowView
            Return TryCast(cmbProduk.SelectedItem, DataRowView)
        End Function

        Private Sub PerbaruiHargaProduk()
            Dim row As DataRowView = ProdukTerpilih()
            If row Is Nothing Then
                txtHarga.Clear()
                txtSubtotal.Clear()
                Return
            End If
            Dim harga As Decimal = Convert.ToDecimal(row("harga_jual"))
            txtHarga.Text = harga.ToString("N2")
            HitungSubtotalItem()
        End Sub

        Private Sub HitungSubtotalItem()
            Dim row As DataRowView = ProdukTerpilih()
            If row Is Nothing Then
                txtSubtotal.Text = "0.00"
                Return
            End If
            txtSubtotal.Text = (Convert.ToDecimal(row("harga_jual")) * numQty.Value).ToString("N2")
        End Sub

        Private Sub TambahItem()
            Dim row As DataRowView = ProdukTerpilih()
            If row Is Nothing Then
                MessageBox.Show("Pilih produk terlebih dahulu.")
                Return
            End If
            Dim id As Integer = Convert.ToInt32(row("id_produk"))
            Dim nama As String = Convert.ToString(row("nama_produk"))
            Dim qty As Integer = Decimal.ToInt32(numQty.Value)
            Dim harga As Decimal = Convert.ToDecimal(row("harga_jual"))
            _detailTable.Rows.Add(id, nama, qty, harga, qty * harga)
            HitungRingkasan()
        End Sub

        Private Sub HapusItem()
            If dgvDetailPesanan.CurrentRow Is Nothing Then Return
            Dim view As DataRowView = TryCast(dgvDetailPesanan.CurrentRow.DataBoundItem, DataRowView)
            If view IsNot Nothing Then
                _detailTable.Rows.Remove(view.Row)
                HitungRingkasan()
            End If
        End Sub

        Private Function TotalPesanan() As Decimal
            Dim total As Decimal = 0D
            For Each row As DataRow In _detailTable.Rows
                total += Convert.ToDecimal(row("subtotal"))
            Next
            Return total
        End Function

        Private Sub HitungRingkasan()
            If _updatingSummary Then Return
            _updatingSummary = True
            Try
                Dim total As Decimal = TotalPesanan()
                If numDP.Value > total Then numDP.Value = total
                txtTotal.Text = total.ToString("N2")
                txtSisa.Text = Math.Max(total - numDP.Value, 0D).ToString("N2")
                If total > 0D AndAlso numDP.Value >= total Then
                    cmbStatusBayar.SelectedItem = "LUNAS"
                ElseIf numDP.Value > 0D Then
                    cmbStatusBayar.SelectedItem = "DP"
                Else
                    cmbStatusBayar.SelectedItem = "BELUM"
                End If
            Finally
                _updatingSummary = False
            End Try
        End Sub

        Private Sub SimpanPesanan()
            If cmbPelanggan.SelectedValue Is Nothing Then
                MessageBox.Show("Pilih pelanggan.")
                Return
            End If
            If _detailTable.Rows.Count = 0 Then
                MessageBox.Show("Tambahkan minimal satu item produk.")
                Return
            End If
            If String.IsNullOrWhiteSpace(cmbSumber.Text) Then
                MessageBox.Show("Sumber pesanan wajib diisi.")
                Return
            End If
            Dim total As Decimal = TotalPesanan()
            Dim dp As Decimal = numDP.Value
            If dp > total Then
                MessageBox.Show("DP tidak boleh melebihi total pesanan.")
                Return
            End If
            Try
                Using connection As MySqlConnection = Database.CreateConnection()
                    connection.Open()
                    Using transaction As MySqlTransaction = connection.BeginTransaction()
                        Try
                            Dim sql As String = "INSERT INTO pesanan (id_pelanggan, tgl_pesan, tgl_kirim, jam_kirim, sumber, total, dp, sisa, status_pesanan, status_bayar, catatan) VALUES (@pelanggan, @tgl_pesan, @tgl_kirim, @jam_kirim, @sumber, @total, @dp, @sisa, @status_pesanan, @status_bayar, @catatan)"
                            Using command As New MySqlCommand(sql, connection, transaction)
                                command.Parameters.AddWithValue("@pelanggan", Convert.ToInt32(cmbPelanggan.SelectedValue))
                                command.Parameters.AddWithValue("@tgl_pesan", dtpTanggalPesan.Value.Date)
                                command.Parameters.Add("@tgl_kirim", MySqlDbType.Date).Value = If(dtpTanggalKirim.Checked, CType(dtpTanggalKirim.Value.Date, Object), DBNull.Value)
                                command.Parameters.Add("@jam_kirim", MySqlDbType.Time).Value = If(dtpJamKirim.Checked, CType(dtpJamKirim.Value.TimeOfDay, Object), DBNull.Value)
                                command.Parameters.AddWithValue("@sumber", cmbSumber.Text.Trim())
                                command.Parameters.AddWithValue("@total", total)
                                command.Parameters.AddWithValue("@dp", dp)
                                command.Parameters.AddWithValue("@sisa", Math.Max(total - dp, 0D))
                                command.Parameters.AddWithValue("@status_pesanan", If(cmbStatusPesanan.SelectedItem Is Nothing, "BARU", Convert.ToString(cmbStatusPesanan.SelectedItem)))
                                Dim statusBayar As String = If(total > 0D AndAlso dp >= total, "LUNAS", If(dp > 0D, "DP", "BELUM"))
                                command.Parameters.AddWithValue("@status_bayar", statusBayar)
                                command.Parameters.Add("@catatan", MySqlDbType.Text).Value = If(String.IsNullOrWhiteSpace(txtCatatan.Text), CType(DBNull.Value, Object), txtCatatan.Text.Trim())
                                command.ExecuteNonQuery()
                            End Using
                            Dim idPesanan As Integer
                            Using idCommand As New MySqlCommand("SELECT LAST_INSERT_ID()", connection, transaction)
                                idPesanan = Convert.ToInt32(idCommand.ExecuteScalar())
                            End Using
                            For Each row As DataRow In _detailTable.Rows
                                Using itemCommand As New MySqlCommand("INSERT INTO detail_pesanan (id_pesanan, id_produk, qty, harga_satuan, subtotal, catatan) VALUES (@pesanan, @produk, @qty, @harga, @subtotal, NULL)", connection, transaction)
                                    itemCommand.Parameters.AddWithValue("@pesanan", idPesanan)
                                    itemCommand.Parameters.AddWithValue("@produk", Convert.ToInt32(row("id_produk")))
                                    itemCommand.Parameters.AddWithValue("@qty", Convert.ToInt32(row("qty")))
                                    itemCommand.Parameters.AddWithValue("@harga", Convert.ToDecimal(row("harga_satuan")))
                                    itemCommand.Parameters.AddWithValue("@subtotal", Convert.ToDecimal(row("subtotal")))
                                    itemCommand.ExecuteNonQuery()
                                End Using
                            Next
                            If dp > 0D Then
                                Dim jenisAwal As String = If(dp >= total, "LUNAS", "DP")
                                Using paymentCommand As New MySqlCommand("INSERT INTO pembayaran (id_pesanan, tgl_bayar, jumlah, jenis) VALUES (@pesanan, @tanggal, @jumlah, @jenis)", connection, transaction)
                                    paymentCommand.Parameters.AddWithValue("@pesanan", idPesanan)
                                    paymentCommand.Parameters.AddWithValue("@tanggal", dtpTanggalPesan.Value.Date)
                                    paymentCommand.Parameters.AddWithValue("@jumlah", dp)
                                    paymentCommand.Parameters.AddWithValue("@jenis", jenisAwal)
                                    paymentCommand.ExecuteNonQuery()
                                End Using
                            End If
                            transaction.Commit()
                            MessageBox.Show("Pesanan berhasil disimpan dengan ID " & idPesanan.ToString() & ".", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Bersihkan()
                        Catch
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menyimpan pesanan")
            End Try
        End Sub

        Private Sub Bersihkan()
            _detailTable.Clear()
            txtIdPesanan.Text = "(otomatis)"
            txtCatatan.Clear()
            numDP.Value = 0
            dtpTanggalPesan.Value = Date.Today
            dtpTanggalKirim.Checked = False
            dtpJamKirim.Checked = False
            cmbSumber.Text = "WA"
            cmbStatusPesanan.SelectedItem = "BARU"
            cmbStatusBayar.SelectedItem = "BELUM"
            bsPelanggan.Filter = ""
            If cmbPelanggan.Items.Count > 0 Then cmbPelanggan.SelectedIndex = 0
            If cmbProduk.Items.Count > 0 Then cmbProduk.SelectedIndex = 0
            numQty.Value = 1
            PerbaruiHargaProduk()
            HitungRingkasan()
        End Sub

        Private Sub dgvDetailPesanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetailPesanan.CellContentClick

        End Sub

        Private Sub FrmPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        ' --- ADDED THESE TWO METHODS ---
        Private Sub FilterPelanggan()
            Dim typedText As String = cmbPelanggan.Text

            If String.IsNullOrWhiteSpace(typedText) Then
                bsPelanggan.Filter = ""
            Else
                Dim safeText As String = typedText.Replace("'", "''")
                bsPelanggan.Filter = String.Format("pilihan LIKE '%{0}%'", safeText)
            End If

            ' Restore the text and cursor position
            cmbPelanggan.Text = typedText
            cmbPelanggan.SelectionStart = typedText.Length

            ' Keep the dropdown open
            cmbPelanggan.DroppedDown = True
        End Sub

        Private Sub ResetFilterPelanggan()
            ' Reset filter to show all items when the dropdown closes
            bsPelanggan.Filter = ""
            cmbPelanggan.Text = cmbPelanggan.Text
        End Sub
        ' -------------------------------

    End Class
End Namespace
