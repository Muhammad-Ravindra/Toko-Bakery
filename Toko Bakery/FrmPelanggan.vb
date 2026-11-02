Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Partial Public Class FrmPelanggan
        Public Sub New()
            InitializeComponent()
            UiHelpers.ConfigureGrid(dgvPelanggan)
            If cmbTipe.Items.Count > 0 Then cmbTipe.SelectedIndex = 0
            AddHandler btnTambah.Click, Sub(sender, e) Tambah()
            AddHandler btnUbah.Click, Sub(sender, e) Ubah()
            AddHandler btnHapus.Click, Sub(sender, e) Hapus()
            AddHandler btnBersihkan.Click, Sub(sender, e) Bersihkan()
            AddHandler dgvPelanggan.CellClick, Sub(sender, e) PilihBaris()
            AddHandler Me.Load, Sub(sender, e) MuatData()

            UpdateButtonState()
        End Sub

        Private Sub UpdateButtonState()
            Dim isSelected As Boolean = Not String.IsNullOrWhiteSpace(txtIdPelanggan.Text)

            btnTambah.Enabled = Not isSelected

            btnUbah.Enabled = isSelected AndAlso AppSession.IsOwner
            btnHapus.Enabled = isSelected AndAlso AppSession.IsOwner
        End Sub

        Private Sub MuatData()
            Try
                dgvPelanggan.DataSource = Database.Query("SELECT id_pelanggan, nama, tipe, kontak, termin_hari, alamat_pengiriman FROM pelanggan ORDER BY id_pelanggan DESC")
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat data pelanggan")
            End Try
        End Sub

        Private Sub Tambah()
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama pelanggan wajib diisi.")
                Return
            End If
            Try
                Database.Execute("INSERT INTO pelanggan (nama, tipe, kontak, termin_hari,alamat_pengiriman) VALUES (@nama, @tipe, @kontak, @termin, @alamat)",
                    New MySqlParameter("@nama", txtNama.Text.Trim()),
                    New MySqlParameter("@tipe", If(cmbTipe.SelectedItem Is Nothing, "individu", Convert.ToString(cmbTipe.SelectedItem))),
                    New MySqlParameter("@kontak", If(String.IsNullOrWhiteSpace(txtKontak.Text), CType(DBNull.Value, Object), txtKontak.Text.Trim())),
                    New MySqlParameter("@termin", Decimal.ToInt32(numTermin.Value)),
                    New MySqlParameter("@alamat", If(String.IsNullOrWhiteSpace(txtKontak.Text), CType(DBNull.Value, Object), txtAlamat.Text.Trim()))
                    )
                MuatData()
                Bersihkan()
                MessageBox.Show("Data pelanggan berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menambah pelanggan")
            End Try
        End Sub

        Private Sub Ubah()
            If Not AppSession.IsOwner Then Return
            Dim id As Integer
            If Not UiHelpers.IsNumericId(txtIdPelanggan.Text, id) Then
                MessageBox.Show("Pilih pelanggan yang ingin diubah.")
                Return
            End If
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama pelanggan wajib diisi.")
                Return
            End If
            Try
                Database.Execute("UPDATE pelanggan SET nama=@nama, tipe=@tipe, kontak=@kontak, termin_hari=@termin, alamat_pengiriman=@alamat WHERE id_pelanggan=@id",
                    New MySqlParameter("@nama", txtNama.Text.Trim()),
                    New MySqlParameter("@tipe", If(cmbTipe.SelectedItem Is Nothing, "individu", Convert.ToString(cmbTipe.SelectedItem))),
                    New MySqlParameter("@kontak", If(String.IsNullOrWhiteSpace(txtKontak.Text), CType(DBNull.Value, Object), txtKontak.Text.Trim())),
                    New MySqlParameter("@termin", Decimal.ToInt32(numTermin.Value)), New MySqlParameter("@id", id),
                    New MySqlParameter("@alamat", If(String.IsNullOrWhiteSpace(txtKontak.Text), CType(DBNull.Value, Object), txtAlamat.Text.Trim()))
                    )
                MuatData()
                Bersihkan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal mengubah pelanggan")
            End Try
        End Sub

        Private Sub Hapus()
            If Not AppSession.IsOwner Then Return
            Dim id As Integer
            If Not UiHelpers.IsNumericId(txtIdPelanggan.Text, id) Then
                MessageBox.Show("Pilih pelanggan yang ingin dihapus.")
                Return
            End If
            If MessageBox.Show("Hapus pelanggan terpilih? Penghapusan dapat ditolak jika masih memiliki pesanan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
            Try
                Database.Execute("DELETE FROM pelanggan WHERE id_pelanggan=@id", New MySqlParameter("@id", id))
                MuatData()
                Bersihkan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menghapus pelanggan")
            End Try
        End Sub

        Private Sub PilihBaris()
            If dgvPelanggan.CurrentRow Is Nothing Then Return
            Dim row As DataGridViewRow = dgvPelanggan.CurrentRow
            txtIdPelanggan.Text = Convert.ToString(row.Cells("id_pelanggan").Value)
            txtNama.Text = Convert.ToString(row.Cells("nama").Value)
            cmbTipe.SelectedItem = Convert.ToString(row.Cells("tipe").Value)
            txtKontak.Text = If(row.Cells("kontak").Value Is DBNull.Value, String.Empty, Convert.ToString(row.Cells("kontak").Value))
            txtAlamat.Text = If(row.Cells("alamat_pengiriman").Value Is DBNull.Value, String.Empty, Convert.ToString(row.Cells("alamat_pengiriman").Value))
            Dim termin As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("termin_hari").Value), termin)
            numTermin.Value = Math.Max(numTermin.Minimum, Math.Min(numTermin.Maximum, termin))

            UpdateButtonState()
        End Sub

        Private Sub Bersihkan()
            txtIdPelanggan.Clear()
            txtNama.Clear()
            txtKontak.Clear()
            txtAlamat.Clear()
            numTermin.Value = 0
            If cmbTipe.Items.Count > 0 Then cmbTipe.SelectedIndex = 0
            dgvPelanggan.ClearSelection()
            txtNama.Focus()

            UpdateButtonState()
        End Sub

        Private Sub FrmPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace