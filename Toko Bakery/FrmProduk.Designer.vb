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
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            lblJudulProduk = New Label()
            lblSeksiInput = New Label()
            lblNamaProduk = New Label()
            txtNamaProduk = New TextBox()
            lblKategori = New Label()
            cmbKategori = New ComboBox()
            lblHargaJual = New Label()
            numHargaJual = New TextBox()
            lblHpp = New Label()
            numHpp = New TextBox()
            lblMasaSimpan = New Label()
            numMasaSimpan = New NumericUpDown()
            btnTambah = New Button()
            btnUbah = New Button()
            btnHapus = New Button()
            btnBersihkan = New Button()
            lblDaftarProduk = New Label()
            dgvProduk = New DataGridView()
            CType(numMasaSimpan, ISupportInitialize).BeginInit()
            CType(dgvProduk, ISupportInitialize).BeginInit()
            SuspendLayout()
            '
            ' lblJudulProduk
            '
            lblJudulProduk.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulProduk.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulProduk.Location = New Point(28, 18)
            lblJudulProduk.Name = "lblJudulProduk"
            lblJudulProduk.Size = New Size(520, 42)
            lblJudulProduk.TabIndex = 0
            lblJudulProduk.Text = "Data Produk Roti dan Kue"
            lblJudulProduk.TextAlign = ContentAlignment.MiddleLeft
            '
            ' lblSeksiInput
            '
            lblSeksiInput.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            lblSeksiInput.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            lblSeksiInput.Location = New Point(30, 75)
            lblSeksiInput.Name = "lblSeksiInput"
            lblSeksiInput.Size = New Size(520, 26)
            lblSeksiInput.TabIndex = 1
            lblSeksiInput.Text = "Input Produk"
            lblSeksiInput.TextAlign = ContentAlignment.MiddleLeft
            '
            ' lblNamaProduk
            '
            lblNamaProduk.Font = New Font("Segoe UI", 9F)
            lblNamaProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblNamaProduk.Location = New Point(30, 105)
            lblNamaProduk.Name = "lblNamaProduk"
            lblNamaProduk.Size = New Size(250, 22)
            lblNamaProduk.TabIndex = 2
            lblNamaProduk.Text = "Nama Produk"
            lblNamaProduk.TextAlign = ContentAlignment.MiddleLeft
            '
            ' txtNamaProduk
            '
            txtNamaProduk.Location = New Point(30, 129)
            txtNamaProduk.MaxLength = 100
            txtNamaProduk.Name = "txtNamaProduk"
            txtNamaProduk.Size = New Size(250, 27)
            txtNamaProduk.TabIndex = 3
            '
            ' lblKategori
            '
            lblKategori.Font = New Font("Segoe UI", 9F)
            lblKategori.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblKategori.Location = New Point(300, 105)
            lblKategori.Name = "lblKategori"
            lblKategori.Size = New Size(250, 22)
            lblKategori.TabIndex = 4
            lblKategori.Text = "Kategori"
            lblKategori.TextAlign = ContentAlignment.MiddleLeft
            '
            ' cmbKategori
            '
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
            cmbKategori.Items.AddRange(New Object() {"Kue", "Roti", "Jajan Basah", "Jajan Kering"})
            cmbKategori.Location = New Point(300, 128)
            cmbKategori.Name = "cmbKategori"
            cmbKategori.Size = New Size(250, 28)
            cmbKategori.TabIndex = 5
            '
            ' lblHargaJual
            '
            lblHargaJual.Font = New Font("Segoe UI", 9F)
            lblHargaJual.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHargaJual.Location = New Point(30, 170)
            lblHargaJual.Name = "lblHargaJual"
            lblHargaJual.Size = New Size(250, 22)
            lblHargaJual.TabIndex = 6
            lblHargaJual.Text = "Harga Jual (Rp)"
            lblHargaJual.TextAlign = ContentAlignment.MiddleLeft
            '
            ' numHargaJual
            '
            numHargaJual.Location = New Point(30, 194)
            numHargaJual.Name = "numHargaJual"
            numHargaJual.Size = New Size(250, 27)
            numHargaJual.TabIndex = 7
            numHargaJual.Text = "0"
            numHargaJual.TextAlign = HorizontalAlignment.Right
            '
            ' lblHpp
            '
            lblHpp.Font = New Font("Segoe UI", 9F)
            lblHpp.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHpp.Location = New Point(300, 170)
            lblHpp.Name = "lblHpp"
            lblHpp.Size = New Size(250, 22)
            lblHpp.TabIndex = 8
            lblHpp.Text = "HPP (Rp)"
            lblHpp.TextAlign = ContentAlignment.MiddleLeft
            '
            ' numHpp
            '
            numHpp.Location = New Point(300, 194)
            numHpp.Name = "numHpp"
            numHpp.Size = New Size(250, 27)
            numHpp.TabIndex = 9
            numHpp.Text = "0"
            numHpp.TextAlign = HorizontalAlignment.Right
            '
            ' lblMasaSimpan
            '
            lblMasaSimpan.Font = New Font("Segoe UI", 9F)
            lblMasaSimpan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblMasaSimpan.Location = New Point(30, 235)
            lblMasaSimpan.Name = "lblMasaSimpan"
            lblMasaSimpan.Size = New Size(250, 22)
            lblMasaSimpan.TabIndex = 10
            lblMasaSimpan.Text = "Masa Simpan (jam)"
            lblMasaSimpan.TextAlign = ContentAlignment.MiddleLeft
            '
            ' numMasaSimpan
            '
            numMasaSimpan.Location = New Point(30, 259)
            numMasaSimpan.Maximum = New Decimal(New Integer() {87600, 0, 0, 65536})
            numMasaSimpan.Name = "numMasaSimpan"
            numMasaSimpan.Size = New Size(250, 27)
            numMasaSimpan.TabIndex = 11
            numMasaSimpan.TextAlign = HorizontalAlignment.Right
            numMasaSimpan.ThousandsSeparator = True
            '
            ' btnTambah
            '
            btnTambah.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnTambah.Cursor = Cursors.Hand
            btnTambah.FlatStyle = FlatStyle.Flat
            btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnTambah.ForeColor = Color.White
            btnTambah.Location = New Point(30, 315)
            btnTambah.Name = "btnTambah"
            btnTambah.Size = New Size(124, 40)
            btnTambah.TabIndex = 12
            btnTambah.Text = "Tambah"
            btnTambah.UseVisualStyleBackColor = False
            '
            ' btnUbah
            '
            btnUbah.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnUbah.Cursor = Cursors.Hand
            btnUbah.Enabled = False
            btnUbah.FlatStyle = FlatStyle.Flat
            btnUbah.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnUbah.Location = New Point(162, 315)
            btnUbah.Name = "btnUbah"
            btnUbah.Size = New Size(124, 40)
            btnUbah.TabIndex = 13
            btnUbah.Text = "Ubah"
            btnUbah.UseVisualStyleBackColor = False
            '
            ' btnHapus
            '
            btnHapus.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnHapus.Cursor = Cursors.Hand
            btnHapus.Enabled = False
            btnHapus.FlatStyle = FlatStyle.Flat
            btnHapus.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnHapus.Location = New Point(294, 315)
            btnHapus.Name = "btnHapus"
            btnHapus.Size = New Size(124, 40)
            btnHapus.TabIndex = 14
            btnHapus.Text = "Hapus"
            btnHapus.UseVisualStyleBackColor = False
            '
            ' btnBersihkan
            '
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(426, 315)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(124, 40)
            btnBersihkan.TabIndex = 15
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            '
            ' lblDaftarProduk
            '
            lblDaftarProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            lblDaftarProduk.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            lblDaftarProduk.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            lblDaftarProduk.Location = New Point(580, 75)
            lblDaftarProduk.Name = "lblDaftarProduk"
            lblDaftarProduk.Size = New Size(510, 26)
            lblDaftarProduk.TabIndex = 16
            lblDaftarProduk.Text = "Daftar Produk"
            lblDaftarProduk.TextAlign = ContentAlignment.MiddleLeft
            '
            ' dgvProduk
            '
            dgvProduk.AllowUserToAddRows = False
            dgvProduk.AllowUserToDeleteRows = False
            dgvProduk.AllowUserToResizeRows = False
            dgvProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProduk.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvProduk.ColumnHeadersHeight = 29
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvProduk.DefaultCellStyle = DataGridViewCellStyle2
            dgvProduk.EnableHeadersVisualStyles = False
            dgvProduk.Location = New Point(580, 105)
            dgvProduk.MultiSelect = False
            dgvProduk.Name = "dgvProduk"
            dgvProduk.ReadOnly = True
            dgvProduk.RowHeadersVisible = False
            dgvProduk.RowHeadersWidth = 51
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProduk.Size = New Size(510, 585)
            dgvProduk.TabIndex = 17
            dgvProduk.TabStop = False
            '
            ' FrmProduk
            '
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1120, 720)
            Controls.Add(lblJudulProduk)
            Controls.Add(lblSeksiInput)
            Controls.Add(lblNamaProduk)
            Controls.Add(txtNamaProduk)
            Controls.Add(lblKategori)
            Controls.Add(cmbKategori)
            Controls.Add(lblHargaJual)
            Controls.Add(numHargaJual)
            Controls.Add(lblHpp)
            Controls.Add(numHpp)
            Controls.Add(lblMasaSimpan)
            Controls.Add(numMasaSimpan)
            Controls.Add(btnTambah)
            Controls.Add(btnUbah)
            Controls.Add(btnHapus)
            Controls.Add(btnBersihkan)
            Controls.Add(lblDaftarProduk)
            Controls.Add(dgvProduk)
            Font = New Font("Segoe UI", 9F)
            MinimumSize = New Size(900, 500)
            Name = "FrmProduk"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Data Produk - Sistem Kasir Toko Roti"
            CType(numMasaSimpan, ISupportInitialize).EndInit()
            CType(dgvProduk, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulProduk As System.Windows.Forms.Label
        Friend WithEvents lblSeksiInput As System.Windows.Forms.Label
        Friend WithEvents lblNamaProduk As System.Windows.Forms.Label
        Friend WithEvents txtNamaProduk As System.Windows.Forms.TextBox
        Friend WithEvents lblKategori As System.Windows.Forms.Label
        Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
        Friend WithEvents lblHargaJual As System.Windows.Forms.Label
        Friend WithEvents numHargaJual As System.Windows.Forms.TextBox
        Friend WithEvents lblHpp As System.Windows.Forms.Label
        Friend WithEvents numHpp As System.Windows.Forms.TextBox
        Friend WithEvents lblMasaSimpan As System.Windows.Forms.Label
        Friend WithEvents numMasaSimpan As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnTambah As System.Windows.Forms.Button
        Friend WithEvents btnUbah As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents lblDaftarProduk As System.Windows.Forms.Label
        Friend WithEvents dgvProduk As System.Windows.Forms.DataGridView
    End Class
End Namespace
