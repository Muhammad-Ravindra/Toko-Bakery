Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Public Partial Class FrmNota
        Private Const QueryNota As String = "SELECT ps.id_pesanan AS No_Nota, ps.tgl_pesan AS Tanggal_Order, ps.tgl_kirim AS Tanggal_Kirim, pl.nama AS Nama_Pelanggan, pl.tipe AS Tipe_Pelanggan, pr.nama_produk AS Nama_Barang, dp.qty AS Jumlah, dp.harga_satuan AS Harga_Satuan, dp.subtotal AS Total_Per_Item, ps.total AS Total_Bayar, ps.dp AS Uang_Muka, ps.sisa AS Sisa_Tagihan, ps.status_pesanan AS Status FROM pesanan ps INNER JOIN pelanggan pl ON ps.id_pelanggan=pl.id_pelanggan INNER JOIN detail_pesanan dp ON ps.id_pesanan=dp.id_pesanan INNER JOIN produk pr ON dp.id_produk=pr.id_produk"

        Public Sub New()
            InitializeComponent()
            UiHelpers.ConfigureGrid(dgvNota)
            AddHandler btnCari.Click, Sub(sender, e) CariNota()
            AddHandler btnTampilkanSemua.Click, Sub(sender, e) MuatSemua()
            AddHandler Me.Load, Sub(sender, e) MuatSemua()
            AddHandler txtNoNota.KeyDown, AddressOf txtNoNota_KeyDown
        End Sub

        Private Sub txtNoNota_KeyDown(sender As Object, e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                CariNota()
            End If
        End Sub

        Private Sub MuatSemua()
            Try
                dgvNota.DataSource = Database.Query(QueryNota & " ORDER BY ps.id_pesanan DESC, dp.id_detail ASC")
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat nota transaksi")
            End Try
        End Sub

        Private Sub CariNota()
            If String.IsNullOrWhiteSpace(txtNoNota.Text) Then
                MuatSemua()
                Return
            End If
            Dim id As Integer
            If Not Integer.TryParse(txtNoNota.Text.Trim(), id) OrElse id <= 0 Then
                MessageBox.Show("No. nota harus berupa angka ID pesanan.")
                Return
            End If
            Try
                dgvNota.DataSource = Database.Query(QueryNota & " WHERE ps.id_pesanan=@id ORDER BY dp.id_detail ASC", New MySqlParameter("@id", id))
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal mencari nota")
            End Try
        End Sub

        Private Sub FrmNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace
