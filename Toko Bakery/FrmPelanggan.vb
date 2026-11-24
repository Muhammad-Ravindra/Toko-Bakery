Imports System
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Partial Public Class FrmPelanggan

        ' Pengganti txtIdPelanggan: menyimpan id pelanggan yang sedang dipilih.
        ' Nothing = belum ada baris yang dipilih.
        Private _selectedId As Integer? = Nothing

        Private Shared ReadOnly PolaEmail As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")

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
            AddHandler txtNoHp.KeyPress, AddressOf NoHp_KeyPress

            UpdateButtonState()
        End Sub

        Private ReadOnly Property HasSelection As Boolean
            Get
                Return _selectedId.HasValue
            End Get
        End Property

        Private Sub UpdateButtonState()
            Dim isSelected As Boolean = HasSelection

            btnTambah.Enabled = Not isSelected
            btnUbah.Enabled = isSelected AndAlso AppSession.IsOwner
            btnHapus.Enabled = isSelected AndAlso AppSession.IsOwner
        End Sub

        ' No. HP hanya boleh angka, spasi, tanda '-' dan '+'.
        Private Sub NoHp_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Char.IsControl(e.KeyChar) OrElse Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "-"c OrElse e.KeyChar = "+"c OrElse e.KeyChar = " "c Then Return
            e.Handled = True
        End Sub

        Private Sub MuatData()
            Try
                dgvPelanggan.DataSource = Database.Query("SELECT id_pelanggan, nama, tipe, termin_hari, alamat_pengiriman, email, no_hp FROM pelanggan WHERE is_deleted = 0 ORDER BY id_pelanggan DESC")
                dgvPelanggan.ClearSelection()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat data pelanggan")
            End Try
        End Sub

        ' Mengembalikan False (dan menampilkan pesan) jika isian tidak valid.
        Private Function ValidasiInput() As Boolean
            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                MessageBox.Show("Nama pelanggan wajib diisi.")
                Return False
            End If
            Dim email As String = txtEmail.Text.Trim()
            If email.Length > 0 AndAlso Not PolaEmail.IsMatch(email) Then
                MessageBox.Show("Format email tidak valid. Contoh: nama@gmail.com")
                txtEmail.Focus()
                Return False
            End If
            Dim hp As String = txtNoHp.Text.Trim()
            If hp.Length > 0 Then
                Dim jumlahAngka As Integer = Regex.Replace(hp, "\D", "").Length
                If jumlahAngka < 8 OrElse jumlahAngka > 15 Then
                    MessageBox.Show("No. HP harus berisi 8 sampai 15 angka.")
                    txtNoHp.Focus()
                    Return False
                End If
            End If
            Return True
        End Function

        ' Teks kosong disimpan sebagai NULL.
        Private Shared Function NilaiAtauNull(teks As String) As Object
            Return If(String.IsNullOrWhiteSpace(teks), CType(DBNull.Value, Object), teks.Trim())
        End Function

        ' Parameter yang sama untuk INSERT dan UPDATE.
        Private Function ParameterPelanggan() As List(Of MySqlParameter)
            Return New List(Of MySqlParameter) From {
                New MySqlParameter("@nama", txtNama.Text.Trim()),
                New MySqlParameter("@tipe", If(cmbTipe.SelectedItem Is Nothing, "individu", Convert.ToString(cmbTipe.SelectedItem))),
                New MySqlParameter("@termin", Decimal.ToInt32(numTermin.Value)),
                New MySqlParameter("@alamat", NilaiAtauNull(txtAlamat.Text)),
                New MySqlParameter("@email", NilaiAtauNull(txtEmail.Text)),
                New MySqlParameter("@hp", NilaiAtauNull(txtNoHp.Text))
            }
        End Function

        Private Sub Tambah()
            If Not ValidasiInput() Then Return
            Try
                Database.Execute("INSERT INTO pelanggan (nama, tipe, termin_hari, alamat_pengiriman, email, no_hp) VALUES (@nama, @tipe, @termin, @alamat, @email, @hp)",
                                 ParameterPelanggan().ToArray())
                MuatData()
                Bersihkan()
                MessageBox.Show("Data pelanggan berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menambah pelanggan")
            End Try
        End Sub

        Private Sub Ubah()
            If Not AppSession.IsOwner Then Return
            If Not HasSelection Then
                MessageBox.Show("Pilih pelanggan yang ingin diubah.")
                Return
            End If
            If Not ValidasiInput() Then Return
            Try
                Dim parameter = ParameterPelanggan()
                parameter.Add(New MySqlParameter("@id", _selectedId.Value))
                Database.Execute("UPDATE pelanggan SET nama=@nama, tipe=@tipe, termin_hari=@termin, alamat_pengiriman=@alamat, email=@email, no_hp=@hp WHERE id_pelanggan=@id",
                                 parameter.ToArray())
                MuatData()
                Bersihkan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal mengubah pelanggan")
            End Try
        End Sub

        Private Sub Hapus()
            If Not AppSession.IsOwner Then Return
            If Not HasSelection Then
                MessageBox.Show("Pilih pelanggan yang ingin dihapus.")
                Return
            End If
            If MessageBox.Show("Hapus pelanggan terpilih? Penghapusan dapat ditolak jika masih memiliki pesanan.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return
            Try
                Database.Execute("UPDATE pelanggan SET is_deleted = 1 WHERE id_pelanggan=@id", New MySqlParameter("@id", _selectedId.Value))
                MuatData()
                Bersihkan()
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal menghapus pelanggan")
            End Try
        End Sub

        Private Shared Function TeksSel(row As DataGridViewRow, kolom As String) As String
            Dim v As Object = row.Cells(kolom).Value
            Return If(v Is Nothing OrElse v Is DBNull.Value, String.Empty, Convert.ToString(v))
        End Function

        Private Sub PilihBaris()
            If dgvPelanggan.CurrentRow Is Nothing Then Return
            Dim row As DataGridViewRow = dgvPelanggan.CurrentRow

            Dim id As Integer
            If Not Integer.TryParse(Convert.ToString(row.Cells("id_pelanggan").Value), id) Then Return
            _selectedId = id

            txtNama.Text = TeksSel(row, "nama")
            cmbTipe.SelectedItem = TeksSel(row, "tipe")
            txtAlamat.Text = TeksSel(row, "alamat_pengiriman")
            txtEmail.Text = TeksSel(row, "email")
            txtNoHp.Text = TeksSel(row, "no_hp")

            Dim termin As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("termin_hari").Value), termin)
            numTermin.Value = Math.Max(numTermin.Minimum, Math.Min(numTermin.Maximum, termin))

            UpdateButtonState()
        End Sub

        Private Sub Bersihkan()
            _selectedId = Nothing
            txtNama.Clear()
            txtAlamat.Clear()
            txtEmail.Clear()
            txtNoHp.Clear()
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

        Private Sub Label3_Click(sender As Object, e As EventArgs)

        End Sub
    End Class
End Namespace
