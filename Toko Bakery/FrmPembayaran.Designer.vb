Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmPembayaran
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
            lblJudulPembayaran = New Label()
            lblSeksiPesanan = New Label()
            lblPesanan = New Label()
            cmbPesanan = New ComboBox()
            lblPelanggan = New Label()
            txtPelanggan = New TextBox()
            lblTotal = New Label()
            txtTotal = New TextBox()
            lblSudahBayar = New Label()
            txtSudahBayar = New TextBox()
            lblSisaTagihan = New Label()
            txtSisaTagihan = New TextBox()
            lblSeksiBayar = New Label()
            lblTanggalBayar = New Label()
            dtpTanggalBayar = New DateTimePicker()
            lblJumlahBayar = New Label()
            numJumlahBayar = New NumericUpDown()
            lblMetode = New Label()
            cmbMetode = New ComboBox()
            lblJenisBayar = New Label()
            cmbJenisBayar = New ComboBox()
            btnBayar = New Button()
            btnBersihkan = New Button()
            lblRiwayat = New Label()
            dgvRiwayatBayar = New DataGridView()
            CType(numJumlahBayar, ISupportInitialize).BeginInit()
            CType(dgvRiwayatBayar, ISupportInitialize).BeginInit()
            SuspendLayout()
            '
            ' lblJudulPembayaran
            '
            lblJudulPembayaran.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulPembayaran.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulPembayaran.Location = New Point(28, 18)
            lblJudulPembayaran.Name = "lblJudulPembayaran"
            lblJudulPembayaran.Size = New Size(420, 42)
            lblJudulPembayaran.TabIndex = 0
            lblJudulPembayaran.Text = "Pembayaran Pesanan"
            lblJudulPembayaran.TextAlign = ContentAlignment.MiddleLeft
            '
            ' lblSeksiPesanan
            '
            lblSeksiPesanan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            lblSeksiPesanan.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            lblSeksiPesanan.Location = New Point(30, 75)
            lblSeksiPesanan.Name = "lblSeksiPesanan"
            lblSeksiPesanan.Size = New Size(420, 26)
            lblSeksiPesanan.TabIndex = 1
            lblSeksiPesanan.Text = "Data Pesanan"
            lblSeksiPesanan.TextAlign = ContentAlignment.MiddleLeft
            '
            ' lblPesanan
            '
            lblPesanan.Font = New Font("Segoe UI", 9F)
            lblPesanan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPesanan.Location = New Point(30, 105)
            lblPesanan.Name = "lblPesanan"
            lblPesanan.Size = New Size(420, 22)
            lblPesanan.TabIndex = 2
            lblPesanan.Text = "Pilih Pesanan"
            lblPesanan.TextAlign = ContentAlignment.MiddleLeft
            '
            ' cmbPesanan
            '
            cmbPesanan.DropDownStyle = ComboBoxStyle.DropDownList
            cmbPesanan.Location = New Point(30, 129)
            cmbPesanan.Name = "cmbPesanan"
            cmbPesanan.Size = New Size(420, 28)
            cmbPesanan.TabIndex = 3
            '
            ' lblPelanggan
            '
            lblPelanggan.Font = New Font("Segoe UI", 9F)
            lblPelanggan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPelanggan.Location = New Point(30, 170)
            lblPelanggan.Name = "lblPelanggan"
            lblPelanggan.Size = New Size(420, 22)
            lblPelanggan.TabIndex = 4
            lblPelanggan.Text = "Pelanggan"
            lblPelanggan.TextAlign = ContentAlignment.MiddleLeft
            '
            ' txtPelanggan
            '
            txtPelanggan.Location = New Point(30, 194)
            txtPelanggan.Name = "txtPelanggan"
            txtPelanggan.ReadOnly = True
            txtPelanggan.Size = New Size(420, 27)
            txtPelanggan.TabIndex = 5
            txtPelanggan.TabStop = False
            '
            ' lblTotal
            '
            lblTotal.Font = New Font("Segoe UI", 9F)
            lblTotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTotal.Location = New Point(30, 235)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New Size(200, 22)
            lblTotal.TabIndex = 6
            lblTotal.Text = "Total Pesanan (Rp)"
            lblTotal.TextAlign = ContentAlignment.MiddleLeft
            '
            ' txtTotal
            '
            txtTotal.Location = New Point(30, 259)
            txtTotal.Name = "txtTotal"
            txtTotal.ReadOnly = True
            txtTotal.Size = New Size(200, 27)
            txtTotal.TabIndex = 7
            txtTotal.TabStop = False
            txtTotal.TextAlign = HorizontalAlignment.Right
            '
            ' lblSudahBayar
            '
            lblSudahBayar.Font = New Font("Segoe UI", 9F)
            lblSudahBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSudahBayar.Location = New Point(250, 235)
            lblSudahBayar.Name = "lblSudahBayar"
            lblSudahBayar.Size = New Size(200, 22)
            lblSudahBayar.TabIndex = 8
            lblSudahBayar.Text = "Sudah Dibayar (Rp)"
            lblSudahBayar.TextAlign = ContentAlignment.MiddleLeft
            '
            ' txtSudahBayar
            '
            txtSudahBayar.Location = New Point(250, 259)
            txtSudahBayar.Name = "txtSudahBayar"
            txtSudahBayar.ReadOnly = True
            txtSudahBayar.Size = New Size(200, 27)
            txtSudahBayar.TabIndex = 9
            txtSudahBayar.TabStop = False
            txtSudahBayar.TextAlign = HorizontalAlignment.Right
            '
            ' lblSisaTagihan
            '
            lblSisaTagihan.Font = New Font("Segoe UI", 9F)
            lblSisaTagihan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSisaTagihan.Location = New Point(30, 300)
            lblSisaTagihan.Name = "lblSisaTagihan"
            lblSisaTagihan.Size = New Size(420, 22)
            lblSisaTagihan.TabIndex = 10
            lblSisaTagihan.Text = "Sisa Tagihan (Rp)"
            lblSisaTagihan.TextAlign = ContentAlignment.MiddleLeft
            '
            ' txtSisaTagihan
            '
            txtSisaTagihan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            txtSisaTagihan.Location = New Point(30, 324)
            txtSisaTagihan.Name = "txtSisaTagihan"
            txtSisaTagihan.ReadOnly = True
            txtSisaTagihan.Size = New Size(420, 27)
            txtSisaTagihan.TabIndex = 11
            txtSisaTagihan.TabStop = False
            txtSisaTagihan.TextAlign = HorizontalAlignment.Right
            '
            ' lblSeksiBayar
            '
            lblSeksiBayar.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            lblSeksiBayar.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            lblSeksiBayar.Location = New Point(30, 380)
            lblSeksiBayar.Name = "lblSeksiBayar"
            lblSeksiBayar.Size = New Size(420, 26)
            lblSeksiBayar.TabIndex = 12
            lblSeksiBayar.Text = "Input Pembayaran"
            lblSeksiBayar.TextAlign = ContentAlignment.MiddleLeft
            '
            ' lblTanggalBayar
            '
            lblTanggalBayar.Font = New Font("Segoe UI", 9F)
            lblTanggalBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalBayar.Location = New Point(30, 410)
            lblTanggalBayar.Name = "lblTanggalBayar"
            lblTanggalBayar.Size = New Size(200, 22)
            lblTanggalBayar.TabIndex = 13
            lblTanggalBayar.Text = "Tanggal Pembayaran"
            lblTanggalBayar.TextAlign = ContentAlignment.MiddleLeft
            '
            ' dtpTanggalBayar
            '
            dtpTanggalBayar.Format = DateTimePickerFormat.Short
            dtpTanggalBayar.Location = New Point(30, 434)
            dtpTanggalBayar.Name = "dtpTanggalBayar"
            dtpTanggalBayar.Size = New Size(200, 27)
            dtpTanggalBayar.TabIndex = 14
            '
            ' lblJumlahBayar
            '
            lblJumlahBayar.Font = New Font("Segoe UI", 9F)
            lblJumlahBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJumlahBayar.Location = New Point(250, 410)
            lblJumlahBayar.Name = "lblJumlahBayar"
            lblJumlahBayar.Size = New Size(200, 22)
            lblJumlahBayar.TabIndex = 15
            lblJumlahBayar.Text = "Jumlah Bayar (Rp)"
            lblJumlahBayar.TextAlign = ContentAlignment.MiddleLeft
            '
            ' numJumlahBayar
            '
            numJumlahBayar.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            numJumlahBayar.InterceptArrowKeys = False
            numJumlahBayar.Location = New Point(250, 434)
            numJumlahBayar.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            numJumlahBayar.Name = "numJumlahBayar"
            numJumlahBayar.Size = New Size(200, 27)
            numJumlahBayar.TabIndex = 16
            numJumlahBayar.TextAlign = HorizontalAlignment.Right
            numJumlahBayar.ThousandsSeparator = True
            '
            ' lblMetode
            '
            lblMetode.Font = New Font("Segoe UI", 9F)
            lblMetode.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblMetode.Location = New Point(30, 475)
            lblMetode.Name = "lblMetode"
            lblMetode.Size = New Size(200, 22)
            lblMetode.TabIndex = 17
            lblMetode.Text = "Metode Pembayaran"
            lblMetode.TextAlign = ContentAlignment.MiddleLeft
            '
            ' cmbMetode
            '
            cmbMetode.Items.AddRange(New Object() {"transfer", "cash"})
            cmbMetode.Location = New Point(30, 499)
            cmbMetode.Name = "cmbMetode"
            cmbMetode.Size = New Size(200, 28)
            cmbMetode.TabIndex = 18
            '
            ' lblJenisBayar
            '
            lblJenisBayar.Font = New Font("Segoe UI", 9F)
            lblJenisBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJenisBayar.Location = New Point(250, 475)
            lblJenisBayar.Name = "lblJenisBayar"
            lblJenisBayar.Size = New Size(200, 22)
            lblJenisBayar.TabIndex = 19
            lblJenisBayar.Text = "Jenis Pembayaran"
            lblJenisBayar.TextAlign = ContentAlignment.MiddleLeft
            '
            ' cmbJenisBayar
            '
            cmbJenisBayar.DropDownStyle = ComboBoxStyle.DropDownList
            cmbJenisBayar.Items.AddRange(New Object() {"DP", "LUNAS"})
            cmbJenisBayar.Location = New Point(250, 499)
            cmbJenisBayar.Name = "cmbJenisBayar"
            cmbJenisBayar.Size = New Size(200, 28)
            cmbJenisBayar.TabIndex = 20
            '
            ' btnBayar
            '
            btnBayar.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnBayar.Cursor = Cursors.Hand
            btnBayar.FlatStyle = FlatStyle.Flat
            btnBayar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnBayar.ForeColor = Color.White
            btnBayar.Location = New Point(30, 560)
            btnBayar.Name = "btnBayar"
            btnBayar.Size = New Size(200, 40)
            btnBayar.TabIndex = 21
            btnBayar.Text = "Simpan Pembayaran"
            btnBayar.UseVisualStyleBackColor = False
            '
            ' btnBersihkan
            '
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(250, 560)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(200, 40)
            btnBersihkan.TabIndex = 22
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            '
            ' lblRiwayat
            '
            lblRiwayat.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            lblRiwayat.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
            lblRiwayat.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            lblRiwayat.Location = New Point(490, 75)
            lblRiwayat.Name = "lblRiwayat"
            lblRiwayat.Size = New Size(600, 26)
            lblRiwayat.TabIndex = 23
            lblRiwayat.Text = "Riwayat Pembayaran"
            lblRiwayat.TextAlign = ContentAlignment.MiddleLeft
            '
            ' dgvRiwayatBayar
            '
            dgvRiwayatBayar.AllowUserToAddRows = False
            dgvRiwayatBayar.AllowUserToDeleteRows = False
            dgvRiwayatBayar.AllowUserToResizeRows = False
            dgvRiwayatBayar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvRiwayatBayar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvRiwayatBayar.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvRiwayatBayar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvRiwayatBayar.ColumnHeadersHeight = 29
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvRiwayatBayar.DefaultCellStyle = DataGridViewCellStyle2
            dgvRiwayatBayar.EnableHeadersVisualStyles = False
            dgvRiwayatBayar.Location = New Point(490, 105)
            dgvRiwayatBayar.MultiSelect = False
            dgvRiwayatBayar.Name = "dgvRiwayatBayar"
            dgvRiwayatBayar.ReadOnly = True
            dgvRiwayatBayar.RowHeadersVisible = False
            dgvRiwayatBayar.RowHeadersWidth = 51
            dgvRiwayatBayar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRiwayatBayar.Size = New Size(600, 625)
            dgvRiwayatBayar.TabIndex = 24
            dgvRiwayatBayar.TabStop = False
            '
            ' FrmPembayaran
            '
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1120, 760)
            Controls.Add(lblJudulPembayaran)
            Controls.Add(lblSeksiPesanan)
            Controls.Add(lblPesanan)
            Controls.Add(cmbPesanan)
            Controls.Add(lblPelanggan)
            Controls.Add(txtPelanggan)
            Controls.Add(lblTotal)
            Controls.Add(txtTotal)
            Controls.Add(lblSudahBayar)
            Controls.Add(txtSudahBayar)
            Controls.Add(lblSisaTagihan)
            Controls.Add(txtSisaTagihan)
            Controls.Add(lblSeksiBayar)
            Controls.Add(lblTanggalBayar)
            Controls.Add(dtpTanggalBayar)
            Controls.Add(lblJumlahBayar)
            Controls.Add(numJumlahBayar)
            Controls.Add(lblMetode)
            Controls.Add(cmbMetode)
            Controls.Add(lblJenisBayar)
            Controls.Add(cmbJenisBayar)
            Controls.Add(btnBayar)
            Controls.Add(btnBersihkan)
            Controls.Add(lblRiwayat)
            Controls.Add(dgvRiwayatBayar)
            Font = New Font("Segoe UI", 9F)
            Name = "FrmPembayaran"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Pembayaran - Sistem Kasir Toko Roti"
            CType(numJumlahBayar, ISupportInitialize).EndInit()
            CType(dgvRiwayatBayar, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulPembayaran As System.Windows.Forms.Label
        Friend WithEvents lblSeksiPesanan As System.Windows.Forms.Label
        Friend WithEvents lblPesanan As System.Windows.Forms.Label
        Friend WithEvents cmbPesanan As System.Windows.Forms.ComboBox
        Friend WithEvents lblPelanggan As System.Windows.Forms.Label
        Friend WithEvents txtPelanggan As System.Windows.Forms.TextBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblSudahBayar As System.Windows.Forms.Label
        Friend WithEvents txtSudahBayar As System.Windows.Forms.TextBox
        Friend WithEvents lblSisaTagihan As System.Windows.Forms.Label
        Friend WithEvents txtSisaTagihan As System.Windows.Forms.TextBox
        Friend WithEvents lblSeksiBayar As System.Windows.Forms.Label
        Friend WithEvents lblTanggalBayar As System.Windows.Forms.Label
        Friend WithEvents dtpTanggalBayar As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblJumlahBayar As System.Windows.Forms.Label
        Friend WithEvents numJumlahBayar As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblMetode As System.Windows.Forms.Label
        Friend WithEvents cmbMetode As System.Windows.Forms.ComboBox
        Friend WithEvents lblJenisBayar As System.Windows.Forms.Label
        Friend WithEvents cmbJenisBayar As System.Windows.Forms.ComboBox
        Friend WithEvents btnBayar As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents lblRiwayat As System.Windows.Forms.Label
        Friend WithEvents dgvRiwayatBayar As System.Windows.Forms.DataGridView
    End Class
End Namespace
