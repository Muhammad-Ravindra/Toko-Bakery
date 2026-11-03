Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Partial Public Class FrmProduk
        Public Sub New()
            InitializeComponent()
            UiHelpers.ConfigureGrid(dgvProduk)
            AddHandler btnTambah.Click, Sub(sender, e) Tambah()
            AddHandler btnUbah.Click, Sub(sender, e) Ubah()
            AddHandler btnHapus.Click, Sub(sender, e) Hapus()
            AddHandler btnBersihkan.Click, Sub(sender, e) Bersihkan()
            AddHandler dgvProduk.CellClick, Sub(sender, e) PilihBaris()
            AddHandler Me.Load, Sub(sender, e) MuatData()

            ' Replaced the hardcoded Enabled properties with the updater
            UpdateButtonState()
        End Sub

        ' --- NEW METHOD ADDED ---
        Private Sub UpdateButtonState()
            Dim isSelected As Boolean = Not String.IsNullOrWhiteSpace(txtIdProduk.Text)

            ' Disable Tambah if a row is selected
            btnTambah.Enabled = Not isSelected

            ' Enable Ubah and Hapus if a row is selected AND user is Owner
            btnUbah.Enabled = isSelected AndAlso AppSession.IsOwner
            btnHapus.Enabled = isSelected AndAlso AppSession.IsOwner
        End Sub
        ' -------------------------

        Private Sub MuatData()
            Try
                dgvProduk.DataSource = Database.Query("SELECT id_produk, nama_produk, kategori, harga_jual, hpp, masa_simpan_jam FROM produk ORDER BY id_produk DESC")
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat data produk")
            End Try
        End Sub

        Private Sub Tambah()
            If String.IsNullOrWhiteSpace(txtNamaProduk.Text) OrElse String.IsNullOrWhiteSpace(cmbKategori.Text) Then
                MessageBox.Show("Nama produk dan kategori wajib diisi.")
                Return
            End If
            Try
                Database.Execute("INSERT INTO produk (nama_produk, kategori, harga_jual, hpp, masa_simpan_jam) VALUES (@nama, @kategori, @harga, @hpp, @masa)",
                    New MySqlParameter("@nama", txtNamaProduk.Text.Trim()), New MySqlParameter("@kategori", cmbKategori.Text.Trim()),
                    New MySqlParameter("@harga", numHargaJual.Value), New MySqlParameter("@hpp", numHpp.Value),
                    New MySqlParameter("@masa", Decimal.ToInt32(numMasaSimpan.Value)))
                MuatData()
                Bersihkan()
                MessageBox.Show("Data produk berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menambah produk")
            End Try
        End Sub

        Private Sub Ubah()
            If Not AppSession.IsOwner Then Return
            Dim id As Integer
            If Not UiHelpers.IsNumericId(txtIdProduk.Text, id) Then
                MessageBox.Show("Pilih produk yang ingin diubah.")
                Return
            End If
            If String.IsNullOrWhiteSpace(txtNamaProduk.Text) OrElse String.IsNullOrWhiteSpace(cmbKategori.Text) Then
                MessageBox.Show("Nama produk dan kategori wajib diisi.")
                Return
            End If
            Try
                Database.Execute("UPDATE produk SET nama_produk=@nama, kategori=@kategori, harga_jual=@harga, hpp=@hpp, masa_simpan_jam=@masa WHERE id_produk=@id",
                    New MySqlParameter("@nama", txtNamaProduk.Text.Trim()), New MySqlParameter("@kategori", cmbKategori.Text.Trim()),
                    New MySqlParameter("@harga", numHargaJual.Value), New MySqlParameter("@hpp", numHpp.Value),
                    New MySqlParameter("@masa", Decimal.ToInt32(numMasaSimpan.Value)), New MySqlParameter("@id", id))
                MuatData()
                Bersihkan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal mengubah produk")
            End Try
        End Sub

        Private Sub Hapus()
            If Not AppSession.IsOwner Then Return
            Dim id As Integer
            If Not UiHelpers.IsNumericId(txtIdProduk.Text, id) Then
                MessageBox.Show("Pilih produk yang ingin dihapus.")
                Return
            End If
            If MessageBox.Show("Hapus produk terpilih? Penghapusan dapat ditolak jika produk sudah digunakan dalam detail pesanan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
            Try
                Database.Execute("DELETE FROM produk WHERE id_produk=@id", New MySqlParameter("@id", id))
                MuatData()
                Bersihkan() ' This naturally unselects the data and updates the buttons
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menghapus produk")
            End Try
        End Sub

        Private Sub PilihBaris()
            If dgvProduk.CurrentRow Is Nothing Then Return
            Dim row As DataGridViewRow = dgvProduk.CurrentRow
            txtIdProduk.Text = Convert.ToString(row.Cells("id_produk").Value)
            txtNamaProduk.Text = Convert.ToString(row.Cells("nama_produk").Value)
            cmbKategori.Text = Convert.ToString(row.Cells("kategori").Value)
            Dim harga As Decimal, hpp As Decimal, masa As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("harga_jual").Value), harga)
            Decimal.TryParse(Convert.ToString(row.Cells("hpp").Value), hpp)
            Decimal.TryParse(Convert.ToString(row.Cells("masa_simpan_jam").Value), masa)
            numHargaJual.Value = Math.Max(numHargaJual.Minimum, Math.Min(numHargaJual.Maximum, harga))
            numHpp.Value = Math.Max(numHpp.Minimum, Math.Min(numHpp.Maximum, hpp))
            numMasaSimpan.Value = Math.Max(numMasaSimpan.Minimum, Math.Min(numMasaSimpan.Maximum, masa))

            UpdateButtonState() ' <--- ADDED HERE
        End Sub

        Private Sub Bersihkan()
            txtIdProduk.Clear()
            txtNamaProduk.Clear()
            cmbKategori.SelectedIndex = -1
            cmbKategori.Text = String.Empty
            numHargaJual.Value = 0
            numHpp.Value = 0
            numMasaSimpan.Value = 0
            dgvProduk.ClearSelection()
            txtNamaProduk.Focus()

            UpdateButtonState() ' <--- ADDED HERE
        End Sub

        Private Sub FrmProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace