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
            lblJudulProduk.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulProduk.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulProduk.Location = New Point(28, 18)
            lblJudulProduk.Name = "lblJudulProduk"
            lblJudulProduk.Size = New Size(600, 42)
            lblJudulProduk.TabIndex = 0
            lblJudulProduk.Text = "Data Produk Roti dan Kue"
            lblJudulProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblNamaProduk
            ' 
            lblNamaProduk.Font = New Font("Segoe UI", 9F)
            lblNamaProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblNamaProduk.Location = New Point(30, 86)
            lblNamaProduk.Name = "lblNamaProduk"
            lblNamaProduk.Size = New Size(260, 22)
            lblNamaProduk.TabIndex = 3
            lblNamaProduk.Text = "Nama Produk"
            lblNamaProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtNamaProduk
            ' 
            txtNamaProduk.Location = New Point(30, 110)
            txtNamaProduk.Name = "txtNamaProduk"
            txtNamaProduk.Size = New Size(260, 27)
            txtNamaProduk.TabIndex = 4
            ' 
            ' lblKategori
            ' 
            lblKategori.Font = New Font("Segoe UI", 9F)
            lblKategori.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblKategori.Location = New Point(299, 86)
            lblKategori.Name = "lblKategori"
            lblKategori.Size = New Size(210, 22)
            lblKategori.TabIndex = 5
            lblKategori.Text = "Kategori"
            lblKategori.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbKategori
            ' 
            cmbKategori.Items.AddRange(New Object() {"Roti", "Donat", "Kue", "Lainnya"})
            cmbKategori.Location = New Point(299, 111)
            cmbKategori.Name = "cmbKategori"
            cmbKategori.Size = New Size(254, 28)
            cmbKategori.TabIndex = 6
            ' 
            ' lblHargaJual
            ' 
            lblHargaJual.Font = New Font("Segoe UI", 9.0F)
            lblHargaJual.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHargaJual.Location = New Point(30, 155)
            lblHargaJual.Name = "lblHargaJual"
            lblHargaJual.Size = New Size(160, 22)
            lblHargaJual.TabIndex = 7
            lblHargaJual.Text = "Harga Jual (Rp)"
            lblHargaJual.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblHpp
            ' 
            lblHpp.Font = New Font("Segoe UI", 9.0F)
            lblHpp.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHpp.Location = New Point(299, 153)
            lblHpp.Name = "lblHpp"
            lblHpp.Size = New Size(121, 22)
            lblHpp.TabIndex = 9
            lblHpp.Text = "HPP (Rp)"
            lblHpp.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblMasaSimpan
            ' 
            lblMasaSimpan.Font = New Font("Segoe UI", 9.0F)
            lblMasaSimpan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblMasaSimpan.Location = New Point(30, 242)
            lblMasaSimpan.Name = "lblMasaSimpan"
            lblMasaSimpan.Size = New Size(180, 22)
            lblMasaSimpan.TabIndex = 11
            lblMasaSimpan.Text = "Masa Simpan (jam)"
            lblMasaSimpan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numMasaSimpan
            ' 
            numMasaSimpan.Location = New Point(30, 266)
            numMasaSimpan.Maximum = New Decimal(New Integer() {87600, 0, 0, 65536})
            numMasaSimpan.Name = "numMasaSimpan"
            numMasaSimpan.Size = New Size(180, 27)
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
            btnTambah.Location = New Point(28, 627)
            btnTambah.Name = "btnTambah"
            btnTambah.Size = New Size(125, 38)
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
            btnUbah.Location = New Point(159, 627)
            btnUbah.Name = "btnUbah"
            btnUbah.Size = New Size(125, 38)
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
            btnHapus.Location = New Point(384, 463)
            btnHapus.Name = "btnHapus"
            btnHapus.Size = New Size(125, 38)
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
            btnBersihkan.Location = New Point(364, 539)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(145, 38)
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
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvProduk.ColumnHeadersHeight = 29
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvProduk.DefaultCellStyle = DataGridViewCellStyle2
            dgvProduk.EnableHeadersVisualStyles = False
            dgvProduk.Location = New Point(580, 86)
            dgvProduk.MultiSelect = False
            dgvProduk.Name = "dgvProduk"
            dgvProduk.ReadOnly = True
            dgvProduk.RowHeadersVisible = False
            dgvProduk.RowHeadersWidth = 51
            dgvProduk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvProduk.Size = New Size(517, 579)
            dgvProduk.TabIndex = 17
            ' 
            ' numHargaJual
            ' 
            numHargaJual.Location = New Point(30, 179)
            numHargaJual.Margin = New Padding(2)
            numHargaJual.Name = "numHargaJual"
            numHargaJual.Size = New Size(254, 27)
            numHargaJual.TabIndex = 0
            ' 
            ' numHpp
            ' 
            numHpp.Location = New Point(299, 179)
            numHpp.Margin = New Padding(2)
            numHpp.Name = "numHpp"
            numHpp.Size = New Size(254, 27)
            numHpp.TabIndex = 18
            ' 
            ' FrmProduk
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1120, 720)
            Controls.Add(numHpp)
            Controls.Add(numHargaJual)
            Controls.Add(lblJudulProduk)
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
            Font = New Font("Segoe UI", 9F)
            Name = "FrmProduk"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Data Produk - Sistem Kasir Toko Roti"
            CType(numMasaSimpan, ISupportInitialize).EndInit()
            CType(dgvProduk, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulProduk As System.Windows.Forms.Label
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
