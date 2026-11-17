Imports System
Imports System.Globalization
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Partial Public Class FrmProduk
        ' Explicit display culture so the separators shown in the UI
        ' match the ones we know how to parse back. (Indonesian: '.' thousands, ',' decimal)
        Private Shared ReadOnly IdCulture As CultureInfo = CultureInfo.GetCultureInfo("id-ID")

        Public Sub New()
            InitializeComponent()
            UiHelpers.ConfigureGrid(dgvProduk)
            AddHandler btnTambah.Click, Sub(sender, e) Tambah()
            AddHandler btnUbah.Click, Sub(sender, e) Ubah()
            AddHandler btnHapus.Click, Sub(sender, e) Hapus()
            AddHandler btnBersihkan.Click, Sub(sender, e) Bersihkan()
            AddHandler dgvProduk.CellClick, Sub(sender, e) PilihBaris()
            AddHandler Me.Load, Sub(sender, e) MuatData()

            AddHandler numHpp.KeyPress, AddressOf NumberOnly_KeyPress
            AddHandler numHargaJual.KeyPress, AddressOf NumberOnly_KeyPress
            AddHandler numHpp.Leave, AddressOf FormatNumber_Leave
            AddHandler numHargaJual.Leave, AddressOf FormatNumber_Leave

            UpdateButtonState()
        End Sub

        Private Sub UpdateButtonState()
            Dim isSelected As Boolean = Not String.IsNullOrWhiteSpace(txtIdProduk.Text)
            btnTambah.Enabled = Not isSelected
            btnUbah.Enabled = isSelected AndAlso AppSession.IsOwner
            btnHapus.Enabled = isSelected AndAlso AppSession.IsOwner
        End Sub

        Private Sub NumberOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End Sub

        ' Strips every non-digit char. Safe for integer-only money values:
        '   "90.000"  -> "90000"
        '   "90,000"  -> "90000"
        '   "8.000.00" -> "800000"  (garbage in -> garbage out, but never a silent 8)
        Private Shared Function ExtractDigits(text As String) As String
            If String.IsNullOrEmpty(text) Then Return String.Empty
            Dim sb As New StringBuilder(text.Length)
            For Each c As Char In text
                If Char.IsDigit(c) Then sb.Append(c)
            Next
            Return sb.ToString()
        End Function

        Private Function GetMoneyValue(txt As TextBox) As Decimal
            Dim digits As String = ExtractDigits(txt.Text)
            If digits.Length = 0 Then Return 0D
            Dim val As Decimal
            If Decimal.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, val) Then
                Return val
            End If
            Return 0D
        End Function

        Private Sub FormatNumber_Leave(sender As Object, e As EventArgs)
            Dim txt As TextBox = TryCast(sender, TextBox)
            If txt Is Nothing Then Return

            Dim digits As String = ExtractDigits(txt.Text)
            If digits.Length = 0 Then
                txt.Text = "0"
                Return
            End If

            Dim val As Decimal
            If Decimal.TryParse(digits, NumberStyles.None, CultureInfo.InvariantCulture, val) Then
                txt.Text = val.ToString("N0", IdCulture)     ' "90000" -> "90.000"
            End If
        End Sub

        Private Sub MuatData()
            Try
                dgvProduk.DataSource = Database.Query("SELECT id_produk, nama_produk, kategori, harga_jual, hpp, masa_simpan_jam FROM produk ORDER BY id_produk DESC")

                ' Force money columns to N0 (no decimals) under id-ID separators,
                ' so they can't render as "8.000.00" via a stray N2 or a mixed culture.
                For Each col As DataGridViewColumn In dgvProduk.Columns
                    If String.Equals(col.DataPropertyName, "harga_jual", StringComparison.OrdinalIgnoreCase) OrElse
                       String.Equals(col.DataPropertyName, "hpp", StringComparison.OrdinalIgnoreCase) Then
                        col.DefaultCellStyle.FormatProvider = IdCulture
                        col.DefaultCellStyle.Format = "N0"
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End If
                Next
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Gagal memuat data produk")
            End Try
        End Sub

        Private Sub Tambah()
            If String.IsNullOrWhiteSpace(txtNamaProduk.Text) OrElse String.IsNullOrWhiteSpace(cmbKategori.Text) Then
                MessageBox.Show("Nama produk dan kategori wajib diisi.")
                Return
            End If

            Dim hargaJual As Decimal = GetMoneyValue(numHargaJual)
            Dim hpp As Decimal = GetMoneyValue(numHpp)

            Try
                Database.Execute("INSERT INTO produk (nama_produk, kategori, harga_jual, hpp, masa_simpan_jam) VALUES (@nama, @kategori, @harga, @hpp, @masa)",
                    New MySqlParameter("@nama", txtNamaProduk.Text.Trim()),
                    New MySqlParameter("@kategori", cmbKategori.Text.Trim()),
                    New MySqlParameter("@harga", hargaJual),
                    New MySqlParameter("@hpp", hpp),
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

            Dim hargaJual As Decimal = GetMoneyValue(numHargaJual)
            Dim hpp As Decimal = GetMoneyValue(numHpp)

            Try
                Database.Execute("UPDATE produk SET nama_produk=@nama, kategori=@kategori, harga_jual=@harga, hpp=@hpp, masa_simpan_jam=@masa WHERE id_produk=@id",
                    New MySqlParameter("@nama", txtNamaProduk.Text.Trim()),
                    New MySqlParameter("@kategori", cmbKategori.Text.Trim()),
                    New MySqlParameter("@harga", hargaJual),
                    New MySqlParameter("@hpp", hpp),
                    New MySqlParameter("@masa", Decimal.ToInt32(numMasaSimpan.Value)),
                    New MySqlParameter("@id", id))
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
                Bersihkan()
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

            ' Read decimals straight from the cell — no string round-trip.
            Dim harga As Decimal = 0D, hpp As Decimal = 0D, masa As Decimal = 0D
            If row.Cells("harga_jual").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("harga_jual").Value) Then
                harga = Convert.ToDecimal(row.Cells("harga_jual").Value)
            End If
            If row.Cells("hpp").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("hpp").Value) Then
                hpp = Convert.ToDecimal(row.Cells("hpp").Value)
            End If
            If row.Cells("masa_simpan_jam").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("masa_simpan_jam").Value) Then
                masa = Convert.ToDecimal(row.Cells("masa_simpan_jam").Value)
            End If

            numHargaJual.Text = harga.ToString("N0", IdCulture)
            numHpp.Text = hpp.ToString("N0", IdCulture)

            numMasaSimpan.Value = Math.Max(numMasaSimpan.Minimum, Math.Min(numMasaSimpan.Maximum, masa))

            UpdateButtonState()
        End Sub

        Private Sub Bersihkan()
            txtIdProduk.Clear()
            txtNamaProduk.Clear()
            cmbKategori.SelectedIndex = -1
            cmbKategori.Text = String.Empty

            numHargaJual.Text = "0"
            numHpp.Text = "0"

            numMasaSimpan.Value = 0
            dgvProduk.ClearSelection()
            txtNamaProduk.Focus()

            UpdateButtonState()
        End Sub

        Private Sub FrmProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End Sub
    End Class
End Namespace