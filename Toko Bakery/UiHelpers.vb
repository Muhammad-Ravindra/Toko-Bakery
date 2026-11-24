Imports System
Imports System.Windows.Forms

Namespace TokoRotiVB
    Friend NotInheritable Class UiHelpers
        Private Sub New()
        End Sub

        Public Shared Sub ConfigureGrid(grid As DataGridView)
            grid.ReadOnly = True
            grid.AllowUserToAddRows = False
            grid.AllowUserToDeleteRows = False
            grid.AllowUserToResizeRows = False
            grid.MultiSelect = False
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.RowHeadersVisible = False
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.BackgroundColor = Drawing.Color.White
            grid.BorderStyle = BorderStyle.FixedSingle
            grid.EnableHeadersVisualStyles = False
            grid.ColumnHeadersDefaultCellStyle.BackColor = Drawing.Color.FromArgb(43, 94, 142)
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Drawing.Color.White
            grid.ColumnHeadersDefaultCellStyle.Font = New Drawing.Font("Segoe UI", 9.0F, Drawing.FontStyle.Bold)
            grid.DefaultCellStyle.SelectionBackColor = Drawing.Color.FromArgb(214, 231, 247)
            grid.DefaultCellStyle.SelectionForeColor = Drawing.Color.FromArgb(40, 49, 59)

            ' Kolom ID (id_pelanggan, id_produk, id_bayar, ...) tidak ditampilkan ke pengguna,
            ' tapi nilainya tetap ada di sel sehingga kode masih bisa membacanya.
            SembunyikanKolomId(grid)
            AddHandler grid.DataBindingComplete, Sub(sender, e) SembunyikanKolomId(grid)
        End Sub

        Public Shared Sub SembunyikanKolomId(grid As DataGridView)
            For Each col As DataGridViewColumn In grid.Columns
                Dim nama As String = If(String.IsNullOrEmpty(col.DataPropertyName), col.Name, col.DataPropertyName)
                If nama.StartsWith("id_", StringComparison.OrdinalIgnoreCase) Then col.Visible = False
            Next
        End Sub

        Public Shared Sub ShowError(ex As Exception, Optional context As String = "Operasi gagal")
            MessageBox.Show(context & ":" & Environment.NewLine & ex.Message, "Sistem Kasir Toko Roti", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Public Shared Function IsNumericId(value As String, ByRef id As Integer) As Boolean
            Return Integer.TryParse(value, id) AndAlso id > 0
        End Function
    End Class
End Namespace
