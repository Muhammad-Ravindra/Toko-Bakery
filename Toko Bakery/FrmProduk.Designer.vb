Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmProduk
        Inherits System.Windows.Forms.Form

        Private components As IContainer

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
            MyBase.Dispose(disposing)
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            lblJudulProduk = New Label()
            lblIdProduk = New Label()
            txtIdProduk = New TextBox()
            lblNamaProduk = New Label()
            txtNamaProduk = New TextBox()
            lblKategori = New Label()
            cmbKategori = New ComboBox()
            lblHargaJual = New Label()
            lblHpp = New Label()
            lblMasaSimpan = New Label()
            numMasaSimpan = New NumericUpDown()
            btnTambah = New Button()
            btnUbah = New Button()
            btnHapus = New Button()
            btnBersihkan = New Button()
            dgvProduk = New DataGridView()
            numHargaJual = New TextBox()
            numHpp = New TextBox()
            CType(numMasaSimpan, ISupportInitialize).BeginInit()
            CType(dgvProduk, ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' lblJudulProduk
            ' 
            lblJudulProduk.Font = New Font("Segoe UI", 21.0F, FontStyle.Bold)
            lblJudulProduk.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulProduk.Location = New Point(35, 22)
            lblJudulProduk.Margin = New Padding(4, 0, 4, 0)
            lblJudulProduk.Name = "lblJudulProduk"
            lblJudulProduk.Size = New Size(750, 52)
            lblJudulProduk.TabIndex = 0
            lblJudulProduk.Text = "Data Produk Roti dan Kue"
            lblJudulProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblIdProduk
            ' 
            lblIdProduk.Font = New Font("Segoe UI", 9.0F)
            lblIdProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblIdProduk.Location = New Point(38, 88)
            lblIdProduk.Margin = New Padding(4, 0, 4, 0)
            lblIdProduk.Name = "lblIdProduk"
            lblIdProduk.Size = New Size(200, 28)
            lblIdProduk.TabIndex = 1
            lblIdProduk.Text = "ID Produk"
            lblIdProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtIdProduk
            ' 
            txtIdProduk.Location = New Point(38, 118)
            txtIdProduk.Margin = New Padding(4)
            txtIdProduk.Name = "txtIdProduk"
            txtIdProduk.ReadOnly = True
            txtIdProduk.Size = New Size(199, 31)
            txtIdProduk.TabIndex = 2
            ' 
            ' lblNamaProduk
            ' 
            lblNamaProduk.Font = New Font("Segoe UI", 9.0F)
            lblNamaProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblNamaProduk.Location = New Point(262, 88)
            lblNamaProduk.Margin = New Padding(4, 0, 4, 0)
            lblNamaProduk.Name = "lblNamaProduk"
            lblNamaProduk.Size = New Size(325, 28)
            lblNamaProduk.TabIndex = 3
            lblNamaProduk.Text = "Nama Produk"
            lblNamaProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtNamaProduk
            ' 
            txtNamaProduk.Location = New Point(262, 118)
            txtNamaProduk.Margin = New Padding(4)
            txtNamaProduk.Name = "txtNamaProduk"
            txtNamaProduk.Size = New Size(324, 31)
            txtNamaProduk.TabIndex = 4
            ' 
            ' lblKategori
            ' 
            lblKategori.Font = New Font("Segoe UI", 9.0F)
            lblKategori.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblKategori.Location = New Point(612, 88)
            lblKategori.Margin = New Padding(4, 0, 4, 0)
            lblKategori.Name = "lblKategori"
            lblKategori.Size = New Size(262, 28)
            lblKategori.TabIndex = 5
            lblKategori.Text = "Kategori"
            lblKategori.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbKategori
            ' 
            cmbKategori.Items.AddRange(New Object() {"Roti", "Donat", "Kue", "Lainnya"})
            cmbKategori.Location = New Point(612, 118)
            cmbKategori.Margin = New Padding(4)
            cmbKategori.Name = "cmbKategori"
            cmbKategori.Size = New Size(262, 33)
            cmbKategori.TabIndex = 6
            ' 
            ' lblHargaJual
            ' 
            lblHargaJual.Font = New Font("Segoe UI", 9.0F)
            lblHargaJual.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHargaJual.Location = New Point(900, 88)
            lblHargaJual.Margin = New Padding(4, 0, 4, 0)
            lblHargaJual.Name = "lblHargaJual"
            lblHargaJual.Size = New Size(200, 28)
            lblHargaJual.TabIndex = 7
            lblHargaJual.Text = "Harga Jual (Rp)"
            lblHargaJual.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblHpp
            ' 
            lblHpp.Font = New Font("Segoe UI", 9.0F)
            lblHpp.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHpp.Location = New Point(1125, 88)
            lblHpp.Margin = New Padding(4, 0, 4, 0)
            lblHpp.Name = "lblHpp"
            lblHpp.Size = New Size(200, 28)
            lblHpp.TabIndex = 9
            lblHpp.Text = "HPP (Rp)"
            lblHpp.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblMasaSimpan
            ' 
            lblMasaSimpan.Font = New Font("Segoe UI", 9.0F)
            lblMasaSimpan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblMasaSimpan.Location = New Point(38, 175)
            lblMasaSimpan.Margin = New Padding(4, 0, 4, 0)
            lblMasaSimpan.Name = "lblMasaSimpan"
            lblMasaSimpan.Size = New Size(225, 28)
            lblMasaSimpan.TabIndex = 11
            lblMasaSimpan.Text = "Masa Simpan (jam)"
            lblMasaSimpan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numMasaSimpan
            ' 
            numMasaSimpan.Location = New Point(38, 205)
            numMasaSimpan.Margin = New Padding(4)
            numMasaSimpan.Maximum = New Decimal(New Integer() {87600, 0, 0, 65536})
            numMasaSimpan.Name = "numMasaSimpan"
            numMasaSimpan.Size = New Size(225, 31)
            numMasaSimpan.TabIndex = 12
            numMasaSimpan.ThousandsSeparator = True
            ' 
            ' btnTambah
            ' 
            btnTambah.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnTambah.Cursor = Cursors.Hand
            btnTambah.FlatStyle = FlatStyle.Flat
            btnTambah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnTambah.ForeColor = Color.White
            btnTambah.Location = New Point(312, 198)
            btnTambah.Margin = New Padding(4)
            btnTambah.Name = "btnTambah"
            btnTambah.Size = New Size(156, 48)
            btnTambah.TabIndex = 13
            btnTambah.Text = "Tambah"
            btnTambah.UseVisualStyleBackColor = False
            ' 
            ' btnUbah
            ' 
            btnUbah.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnUbah.Cursor = Cursors.Hand
            btnUbah.FlatStyle = FlatStyle.Flat
            btnUbah.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnUbah.Location = New Point(481, 198)
            btnUbah.Margin = New Padding(4)
            btnUbah.Name = "btnUbah"
            btnUbah.Size = New Size(156, 48)
            btnUbah.TabIndex = 14
            btnUbah.Text = "Ubah"
            btnUbah.UseVisualStyleBackColor = False
            ' 
            ' btnHapus
            ' 
            btnHapus.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnHapus.Cursor = Cursors.Hand
            btnHapus.FlatStyle = FlatStyle.Flat
            btnHapus.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnHapus.Location = New Point(650, 198)
            btnHapus.Margin = New Padding(4)
            btnHapus.Name = "btnHapus"
            btnHapus.Size = New Size(156, 48)
            btnHapus.TabIndex = 15
            btnHapus.Text = "Hapus"
            btnHapus.UseVisualStyleBackColor = False
            ' 
            ' btnBersihkan
            ' 
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(819, 198)
            btnBersihkan.Margin = New Padding(4)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(181, 48)
            btnBersihkan.TabIndex = 16
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            ' 
            ' dgvProduk
            ' 
            dgvProduk.AllowUserToAddRows = False
            dgvProduk.AllowUserToDeleteRows = False
            dgvProduk.AllowUserToResizeRows = False
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProduk.BackgroundColor = Color.White
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            DataGridViewCellStyle3.ForeColor = Color.White
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
            dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
            dgvProduk.ColumnHeadersHeight = 29
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = SystemColors.Window
            DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F)
            DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
            dgvProduk.DefaultCellStyle = DataGridViewCellStyle4
            dgvProduk.EnableHeadersVisualStyles = False
            dgvProduk.Location = New Point(38, 281)
            dgvProduk.Margin = New Padding(4)
            dgvProduk.MultiSelect = False
            dgvProduk.Name = "dgvProduk"
            dgvProduk.ReadOnly = True
            dgvProduk.RowHeadersVisible = False
            dgvProduk.RowHeadersWidth = 51
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProduk.Size = New Size(1300, 550)
            dgvProduk.TabIndex = 17
            ' 
            ' numHargaJual
            ' 
            numHargaJual.Location = New Point(900, 118)
            numHargaJual.Name = "numHargaJual"
            numHargaJual.Size = New Size(169, 31)
            numHargaJual.TabIndex = 0
            ' 
            ' numHpp
            ' 
            numHpp.Location = New Point(1125, 120)
            numHpp.Name = "numHpp"
            numHpp.Size = New Size(150, 31)
            numHpp.TabIndex = 18
            ' 
            ' FrmProduk
            ' 
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1400, 900)
            Controls.Add(numHpp)
            Controls.Add(numHargaJual)
            Controls.Add(lblJudulProduk)
            Controls.Add(lblIdProduk)
            Controls.Add(txtIdProduk)
            Controls.Add(lblNamaProduk)
            Controls.Add(txtNamaProduk)
            Controls.Add(lblKategori)
            Controls.Add(cmbKategori)
            Controls.Add(lblHargaJual)
            Controls.Add(lblHpp)
            Controls.Add(lblMasaSimpan)
            Controls.Add(numMasaSimpan)
            Controls.Add(btnTambah)
            Controls.Add(btnUbah)
            Controls.Add(btnHapus)
            Controls.Add(btnBersihkan)
            Controls.Add(dgvProduk)
            Font = New Font("Segoe UI", 9.0F)
            Margin = New Padding(4)
            Name = "FrmProduk"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Data Produk - Sistem Kasir Toko Roti"
            CType(numMasaSimpan, ISupportInitialize).EndInit()
            CType(dgvProduk, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulProduk As System.Windows.Forms.Label
        Friend WithEvents lblIdProduk As System.Windows.Forms.Label
        Friend WithEvents txtIdProduk As System.Windows.Forms.TextBox
        Friend WithEvents lblNamaProduk As System.Windows.Forms.Label
        Friend WithEvents txtNamaProduk As System.Windows.Forms.TextBox
        Friend WithEvents lblKategori As System.Windows.Forms.Label
        Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
        Friend WithEvents lblHargaJual As System.Windows.Forms.Label
        Friend WithEvents lblHpp As System.Windows.Forms.Label
        Friend WithEvents lblMasaSimpan As System.Windows.Forms.Label
        Friend WithEvents numMasaSimpan As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnTambah As System.Windows.Forms.Button
        Friend WithEvents btnUbah As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView
        Friend WithEvents numHargaJual As TextBox
        Friend WithEvents numHpp As TextBox
    End Class
End Namespace
