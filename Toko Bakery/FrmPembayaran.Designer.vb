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
            lblJudulPembayaran.Location = New Point(35, 22)
            lblJudulPembayaran.Margin = New Padding(4, 0, 4, 0)
            lblJudulPembayaran.Name = "lblJudulPembayaran"
            lblJudulPembayaran.Size = New Size(875, 52)
            lblJudulPembayaran.TabIndex = 0
            lblJudulPembayaran.Text = "Pembayaran Pesanan"
            lblJudulPembayaran.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblPesanan
            ' 
            lblPesanan.Font = New Font("Segoe UI", 9F)
            lblPesanan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPesanan.Location = New Point(38, 94)
            lblPesanan.Margin = New Padding(4, 0, 4, 0)
            lblPesanan.Name = "lblPesanan"
            lblPesanan.Size = New Size(388, 28)
            lblPesanan.TabIndex = 1
            lblPesanan.Text = "Pilih Pesanan"
            lblPesanan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbPesanan
            ' 
            cmbPesanan.DropDownStyle = ComboBoxStyle.DropDownList
            cmbPesanan.Location = New Point(38, 124)
            cmbPesanan.Margin = New Padding(4, 4, 4, 4)
            cmbPesanan.Name = "cmbPesanan"
            cmbPesanan.Size = New Size(386, 33)
            cmbPesanan.TabIndex = 2
            ' 
            ' lblPelanggan
            ' 
            lblPelanggan.Font = New Font("Segoe UI", 9F)
            lblPelanggan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPelanggan.Location = New Point(462, 94)
            lblPelanggan.Margin = New Padding(4, 0, 4, 0)
            lblPelanggan.Name = "lblPelanggan"
            lblPelanggan.Size = New Size(375, 28)
            lblPelanggan.TabIndex = 3
            lblPelanggan.Text = "Pelanggan"
            lblPelanggan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtPelanggan
            ' 
            txtPelanggan.Location = New Point(462, 124)
            txtPelanggan.Margin = New Padding(4, 4, 4, 4)
            txtPelanggan.Name = "txtPelanggan"
            txtPelanggan.ReadOnly = True
            txtPelanggan.Size = New Size(374, 31)
            txtPelanggan.TabIndex = 4
            ' 
            ' lblTotal
            ' 
            lblTotal.Font = New Font("Segoe UI", 9F)
            lblTotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTotal.Location = New Point(875, 94)
            lblTotal.Margin = New Padding(4, 0, 4, 0)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New Size(212, 28)
            lblTotal.TabIndex = 5
            lblTotal.Text = "Total Pesanan (Rp)"
            lblTotal.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtTotal
            ' 
            txtTotal.Location = New Point(875, 124)
            txtTotal.Margin = New Padding(4, 4, 4, 4)
            txtTotal.Name = "txtTotal"
            txtTotal.ReadOnly = True
            txtTotal.Size = New Size(212, 31)
            txtTotal.TabIndex = 6
            ' 
            ' lblSudahBayar
            ' 
            lblSudahBayar.Font = New Font("Segoe UI", 9F)
            lblSudahBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSudahBayar.Location = New Point(1112, 94)
            lblSudahBayar.Margin = New Padding(4, 0, 4, 0)
            lblSudahBayar.Name = "lblSudahBayar"
            lblSudahBayar.Size = New Size(225, 28)
            lblSudahBayar.TabIndex = 7
            lblSudahBayar.Text = "Sudah Dibayar (Rp)"
            lblSudahBayar.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtSudahBayar
            ' 
            txtSudahBayar.Location = New Point(1112, 124)
            txtSudahBayar.Margin = New Padding(4, 4, 4, 4)
            txtSudahBayar.Name = "txtSudahBayar"
            txtSudahBayar.ReadOnly = True
            txtSudahBayar.Size = New Size(224, 31)
            txtSudahBayar.TabIndex = 8
            ' 
            ' lblSisaTagihan
            ' 
            lblSisaTagihan.Font = New Font("Segoe UI", 9F)
            lblSisaTagihan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSisaTagihan.Location = New Point(38, 188)
            lblSisaTagihan.Margin = New Padding(4, 0, 4, 0)
            lblSisaTagihan.Name = "lblSisaTagihan"
            lblSisaTagihan.Size = New Size(250, 28)
            lblSisaTagihan.TabIndex = 9
            lblSisaTagihan.Text = "Sisa Tagihan (Rp)"
            lblSisaTagihan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtSisaTagihan
            ' 
            txtSisaTagihan.Location = New Point(38, 218)
            txtSisaTagihan.Margin = New Padding(4, 4, 4, 4)
            txtSisaTagihan.Name = "txtSisaTagihan"
            txtSisaTagihan.ReadOnly = True
            txtSisaTagihan.Size = New Size(249, 31)
            txtSisaTagihan.TabIndex = 10
            ' 
            ' lblTanggalBayar
            ' 
            lblTanggalBayar.Font = New Font("Segoe UI", 9F)
            lblTanggalBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalBayar.Location = New Point(325, 188)
            lblTanggalBayar.Margin = New Padding(4, 0, 4, 0)
            lblTanggalBayar.Name = "lblTanggalBayar"
            lblTanggalBayar.Size = New Size(238, 28)
            lblTanggalBayar.TabIndex = 11
            lblTanggalBayar.Text = "Tanggal Pembayaran"
            lblTanggalBayar.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dtpTanggalBayar
            ' 
            dtpTanggalBayar.Format = DateTimePickerFormat.Short
            dtpTanggalBayar.Location = New Point(325, 218)
            dtpTanggalBayar.Margin = New Padding(4, 4, 4, 4)
            dtpTanggalBayar.Name = "dtpTanggalBayar"
            dtpTanggalBayar.Size = New Size(236, 31)
            dtpTanggalBayar.TabIndex = 12
            ' 
            ' lblJumlahBayar
            ' 
            lblJumlahBayar.Font = New Font("Segoe UI", 9F)
            lblJumlahBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJumlahBayar.Location = New Point(600, 188)
            lblJumlahBayar.Margin = New Padding(4, 0, 4, 0)
            lblJumlahBayar.Name = "lblJumlahBayar"
            lblJumlahBayar.Size = New Size(238, 28)
            lblJumlahBayar.TabIndex = 13
            lblJumlahBayar.Text = "Jumlah Bayar (Rp)"
            lblJumlahBayar.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numJumlahBayar
            ' 
            numJumlahBayar.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            numJumlahBayar.InterceptArrowKeys = False
            numJumlahBayar.Location = New Point(600, 218)
            numJumlahBayar.Margin = New Padding(4, 4, 4, 4)
            numJumlahBayar.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            numJumlahBayar.Name = "numJumlahBayar"
            numJumlahBayar.Size = New Size(238, 31)
            numJumlahBayar.TabIndex = 14
            numJumlahBayar.ThousandsSeparator = True
            ' 
            ' lblMetode
            ' 
            lblMetode.Font = New Font("Segoe UI", 9F)
            lblMetode.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblMetode.Location = New Point(875, 188)
            lblMetode.Margin = New Padding(4, 0, 4, 0)
            lblMetode.Name = "lblMetode"
            lblMetode.Size = New Size(212, 28)
            lblMetode.TabIndex = 15
            lblMetode.Text = "Metode Pembayaran"
            lblMetode.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbMetode
            ' 
            cmbMetode.Items.AddRange(New Object() {"transfer", "cash"})
            cmbMetode.Location = New Point(875, 218)
            cmbMetode.Margin = New Padding(4, 4, 4, 4)
            cmbMetode.Name = "cmbMetode"
            cmbMetode.Size = New Size(212, 33)
            cmbMetode.TabIndex = 16
            ' 
            ' lblJenisBayar
            ' 
            lblJenisBayar.Font = New Font("Segoe UI", 9F)
            lblJenisBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJenisBayar.Location = New Point(1112, 188)
            lblJenisBayar.Margin = New Padding(4, 0, 4, 0)
            lblJenisBayar.Name = "lblJenisBayar"
            lblJenisBayar.Size = New Size(212, 28)
            lblJenisBayar.TabIndex = 17
            lblJenisBayar.Text = "Jenis Pembayaran"
            lblJenisBayar.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbJenisBayar
            ' 
            cmbJenisBayar.DropDownStyle = ComboBoxStyle.DropDownList
            cmbJenisBayar.Items.AddRange(New Object() {"DP", "LUNAS"})
            cmbJenisBayar.Location = New Point(1112, 218)
            cmbJenisBayar.Margin = New Padding(4, 4, 4, 4)
            cmbJenisBayar.Name = "cmbJenisBayar"
            cmbJenisBayar.Size = New Size(224, 33)
            cmbJenisBayar.TabIndex = 18
            ' 
            ' btnBayar
            ' 
            btnBayar.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnBayar.Cursor = Cursors.Hand
            btnBayar.FlatStyle = FlatStyle.Flat
            btnBayar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnBayar.ForeColor = Color.White
            btnBayar.Location = New Point(38, 288)
            btnBayar.Margin = New Padding(4, 4, 4, 4)
            btnBayar.Name = "btnBayar"
            btnBayar.Size = New Size(181, 50)
            btnBayar.TabIndex = 19
            btnBayar.Text = "Simpan Pembayaran"
            btnBayar.UseVisualStyleBackColor = False
            ' 
            ' btnBersihkan
            ' 
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(238, 288)
            btnBersihkan.Margin = New Padding(4, 4, 4, 4)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(181, 50)
            btnBersihkan.TabIndex = 20
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            ' 
            ' lblRiwayat
            ' 
            lblRiwayat.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
            lblRiwayat.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblRiwayat.Location = New Point(38, 375)
            lblRiwayat.Margin = New Padding(4, 0, 4, 0)
            lblRiwayat.Name = "lblRiwayat"
            lblRiwayat.Size = New Size(875, 35)
            lblRiwayat.TabIndex = 21
            lblRiwayat.Text = "Riwayat Pembayaran"
            lblRiwayat.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dgvRiwayatBayar
            ' 
            dgvRiwayatBayar.AllowUserToAddRows = False
            dgvRiwayatBayar.AllowUserToDeleteRows = False
            dgvRiwayatBayar.AllowUserToResizeRows = False
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
            dgvRiwayatBayar.Location = New Point(38, 419)
            dgvRiwayatBayar.Margin = New Padding(4, 4, 4, 4)
            dgvRiwayatBayar.MultiSelect = False
            dgvRiwayatBayar.Name = "dgvRiwayatBayar"
            dgvRiwayatBayar.ReadOnly = True
            dgvRiwayatBayar.RowHeadersVisible = False
            dgvRiwayatBayar.RowHeadersWidth = 51
            dgvRiwayatBayar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvRiwayatBayar.Size = New Size(1300, 425)
            dgvRiwayatBayar.TabIndex = 22
            ' 
            ' FrmPembayaran
            ' 
            AutoScaleDimensions = New SizeF(10F, 25F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1400, 950)
            Controls.Add(lblJudulPembayaran)
            Controls.Add(lblRiwayat)
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
            Controls.Add(dgvRiwayatBayar)
            Font = New Font("Segoe UI", 9F)
            Margin = New Padding(4, 4, 4, 4)
            Name = "FrmPembayaran"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Pembayaran - Sistem Kasir Toko Roti"
            CType(numJumlahBayar, ISupportInitialize).EndInit()
            CType(dgvRiwayatBayar, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulPembayaran As System.Windows.Forms.Label
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
