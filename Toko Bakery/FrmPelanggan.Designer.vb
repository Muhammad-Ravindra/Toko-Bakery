Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmPelanggan
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
            lblJudulPelanggan = New Label()
            lblIdPelanggan = New Label()
            txtIdPelanggan = New TextBox()
            lblNama = New Label()
            txtNama = New TextBox()
            lblTipe = New Label()
            cmbTipe = New ComboBox()
            lblKontak = New Label()
            txtKontak = New TextBox()
            lblTermin = New Label()
            numTermin = New NumericUpDown()
            btnTambah = New Button()
            btnUbah = New Button()
            btnHapus = New Button()
            btnBersihkan = New Button()
            dgvPelanggan = New DataGridView()
            Label1 = New Label()
            txtAlamat = New TextBox()
            CType(numTermin, ISupportInitialize).BeginInit()
            CType(dgvPelanggan, ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' lblJudulPelanggan
            ' 
            lblJudulPelanggan.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulPelanggan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulPelanggan.Location = New Point(28, 9)
            lblJudulPelanggan.Name = "lblJudulPelanggan"
            lblJudulPelanggan.Size = New Size(600, 52)
            lblJudulPelanggan.TabIndex = 0
            lblJudulPelanggan.Text = "Data Pelanggan"
            lblJudulPelanggan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblIdPelanggan
            ' 
            lblIdPelanggan.Font = New Font("Segoe UI", 9F)
            lblIdPelanggan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblIdPelanggan.Location = New Point(30, 70)
            lblIdPelanggan.Name = "lblIdPelanggan"
            lblIdPelanggan.Size = New Size(160, 22)
            lblIdPelanggan.TabIndex = 1
            lblIdPelanggan.Text = "ID Pelanggan"
            lblIdPelanggan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtIdPelanggan
            ' 
            txtIdPelanggan.Location = New Point(30, 94)
            txtIdPelanggan.Name = "txtIdPelanggan"
            txtIdPelanggan.ReadOnly = True
            txtIdPelanggan.Size = New Size(160, 27)
            txtIdPelanggan.TabIndex = 2
            ' 
            ' lblNama
            ' 
            lblNama.Font = New Font("Segoe UI", 9F)
            lblNama.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblNama.Location = New Point(210, 70)
            lblNama.Name = "lblNama"
            lblNama.Size = New Size(230, 22)
            lblNama.TabIndex = 3
            lblNama.Text = "Nama Pelanggan"
            lblNama.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtNama
            ' 
            txtNama.Location = New Point(210, 94)
            txtNama.Name = "txtNama"
            txtNama.Size = New Size(230, 27)
            txtNama.TabIndex = 4
            ' 
            ' lblTipe
            ' 
            lblTipe.Font = New Font("Segoe UI", 9F)
            lblTipe.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTipe.Location = New Point(460, 70)
            lblTipe.Name = "lblTipe"
            lblTipe.Size = New Size(170, 22)
            lblTipe.TabIndex = 5
            lblTipe.Text = "Tipe Pelanggan"
            lblTipe.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbTipe
            ' 
            cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList
            cmbTipe.Items.AddRange(New Object() {"individu", "reseller"})
            cmbTipe.Location = New Point(460, 94)
            cmbTipe.Name = "cmbTipe"
            cmbTipe.Size = New Size(170, 28)
            cmbTipe.TabIndex = 6
            ' 
            ' lblKontak
            ' 
            lblKontak.Font = New Font("Segoe UI", 9F)
            lblKontak.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblKontak.Location = New Point(650, 70)
            lblKontak.Name = "lblKontak"
            lblKontak.Size = New Size(220, 22)
            lblKontak.TabIndex = 7
            lblKontak.Text = "Kontak"
            lblKontak.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtKontak
            ' 
            txtKontak.Location = New Point(650, 94)
            txtKontak.Name = "txtKontak"
            txtKontak.Size = New Size(220, 27)
            txtKontak.TabIndex = 8
            ' 
            ' lblTermin
            ' 
            lblTermin.Font = New Font("Segoe UI", 9F)
            lblTermin.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTermin.Location = New Point(890, 70)
            lblTermin.Name = "lblTermin"
            lblTermin.Size = New Size(180, 22)
            lblTermin.TabIndex = 9
            lblTermin.Text = "Termin (hari)"
            lblTermin.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numTermin
            ' 
            numTermin.Location = New Point(890, 94)
            numTermin.Maximum = New Decimal(New Integer() {36500, 0, 0, 65536})
            numTermin.Name = "numTermin"
            numTermin.Size = New Size(180, 27)
            numTermin.TabIndex = 10
            numTermin.ThousandsSeparator = True
            ' 
            ' btnTambah
            ' 
            btnTambah.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnTambah.Cursor = Cursors.Hand
            btnTambah.FlatStyle = FlatStyle.Flat
            btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnTambah.ForeColor = Color.White
            btnTambah.Location = New Point(29, 206)
            btnTambah.Name = "btnTambah"
            btnTambah.Size = New Size(125, 38)
            btnTambah.TabIndex = 11
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
            btnUbah.Location = New Point(164, 206)
            btnUbah.Name = "btnUbah"
            btnUbah.Size = New Size(125, 38)
            btnUbah.TabIndex = 12
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
            btnHapus.Location = New Point(299, 206)
            btnHapus.Name = "btnHapus"
            btnHapus.Size = New Size(125, 38)
            btnHapus.TabIndex = 13
            btnHapus.Text = "Hapus"
            btnHapus.UseVisualStyleBackColor = False
            ' 
            ' btnBersihkan
            ' 
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(434, 206)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(145, 38)
            btnBersihkan.TabIndex = 14
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            ' 
            ' dgvPelanggan
            ' 
            dgvPelanggan.AllowUserToAddRows = False
            dgvPelanggan.AllowUserToDeleteRows = False
            dgvPelanggan.AllowUserToResizeRows = False
            dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvPelanggan.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvPelanggan.ColumnHeadersHeight = 29
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvPelanggan.DefaultCellStyle = DataGridViewCellStyle2
            dgvPelanggan.EnableHeadersVisualStyles = False
            dgvPelanggan.Location = New Point(30, 260)
            dgvPelanggan.MultiSelect = False
            dgvPelanggan.Name = "dgvPelanggan"
            dgvPelanggan.ReadOnly = True
            dgvPelanggan.RowHeadersVisible = False
            dgvPelanggan.RowHeadersWidth = 51
            dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvPelanggan.Size = New Size(1040, 405)
            dgvPelanggan.TabIndex = 15
            ' 
            ' Label1
            ' 
            Label1.Font = New Font("Segoe UI", 9F)
            Label1.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            Label1.Location = New Point(30, 144)
            Label1.Name = "Label1"
            Label1.Size = New Size(230, 22)
            Label1.TabIndex = 16
            Label1.Text = "Alamat Pelanggan"
            Label1.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtAlamat
            ' 
            txtAlamat.Location = New Point(28, 169)
            txtAlamat.Name = "txtAlamat"
            txtAlamat.Size = New Size(549, 27)
            txtAlamat.TabIndex = 17
            ' 
            ' FrmPelanggan
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1120, 720)
            Controls.Add(txtAlamat)
            Controls.Add(Label1)
            Controls.Add(lblJudulPelanggan)
            Controls.Add(lblIdPelanggan)
            Controls.Add(txtIdPelanggan)
            Controls.Add(lblNama)
            Controls.Add(txtNama)
            Controls.Add(lblTipe)
            Controls.Add(cmbTipe)
            Controls.Add(lblKontak)
            Controls.Add(txtKontak)
            Controls.Add(lblTermin)
            Controls.Add(numTermin)
            Controls.Add(btnTambah)
            Controls.Add(btnUbah)
            Controls.Add(btnHapus)
            Controls.Add(btnBersihkan)
            Controls.Add(dgvPelanggan)
            Font = New Font("Segoe UI", 9F)
            Name = "FrmPelanggan"
            StartPosition = FormStartPosition.CenterScreen
            Text = "`"
            CType(numTermin, ISupportInitialize).EndInit()
            CType(dgvPelanggan, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulPelanggan As System.Windows.Forms.Label
        Friend WithEvents lblIdPelanggan As System.Windows.Forms.Label
        Friend WithEvents txtIdPelanggan As System.Windows.Forms.TextBox
        Friend WithEvents lblNama As System.Windows.Forms.Label
        Friend WithEvents txtNama As System.Windows.Forms.TextBox
        Friend WithEvents lblTipe As System.Windows.Forms.Label
        Friend WithEvents cmbTipe As System.Windows.Forms.ComboBox
        Friend WithEvents lblKontak As System.Windows.Forms.Label
        Friend WithEvents txtKontak As System.Windows.Forms.TextBox
        Friend WithEvents lblTermin As System.Windows.Forms.Label
        Friend WithEvents numTermin As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnTambah As System.Windows.Forms.Button
        Friend WithEvents btnUbah As System.Windows.Forms.Button
        Friend WithEvents btnHapus As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents dgvPelanggan As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As Label
        Friend WithEvents txtAlamat As TextBox
    End Class
End Namespace
