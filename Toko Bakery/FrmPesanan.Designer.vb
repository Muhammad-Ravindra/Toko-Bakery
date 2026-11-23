Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmPesanan
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
            lblJudulPesanan = New Label()
            grpInfoPesanan = New GroupBox()
            lblPelanggan = New Label()
            cmbPelanggan = New ComboBox()
            lblTanggalPesan = New Label()
            dtpTanggalPesan = New DateTimePicker()
            lblTanggalKirim = New Label()
            dtpTanggalKirim = New DateTimePicker()
            lblJamKirim = New Label()
            dtpJamKirim = New DateTimePicker()
            lblSumber = New Label()
            cmbSumber = New ComboBox()
            lblStatusPesanan = New Label()
            cmbStatusPesanan = New ComboBox()
            lblStatusBayar = New Label()
            cmbStatusBayar = New ComboBox()
            grpPilihProduk = New GroupBox()
            lblProduk = New Label()
            cmbProduk = New ComboBox()
            lblQty = New Label()
            numQty = New NumericUpDown()
            lblHarga = New Label()
            txtHarga = New TextBox()
            lblSubtotal = New Label()
            txtSubtotal = New TextBox()
            btnTambahItem = New Button()
            dgvDetailPesanan = New DataGridView()
            dgvDetailPesanan_id_produkColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_nama_produkColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_qtyColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_harga_satuanColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_subtotalColumn = New DataGridViewTextBoxColumn()
            grpPembayaran = New GroupBox()
            lblTotal = New Label()
            txtTotal = New TextBox()
            lblDP = New Label()
            numDP = New NumericUpDown()
            lblSisa = New Label()
            txtSisa = New TextBox()
            lblCatatan = New Label()
            txtCatatan = New TextBox()
            btnHapusItem = New Button()
            btnBersihkan = New Button()
            btnSimpan = New Button()
            grpInfoPesanan.SuspendLayout()
            grpPilihProduk.SuspendLayout()
            CType(numQty, ISupportInitialize).BeginInit()
            CType(dgvDetailPesanan, ISupportInitialize).BeginInit()
            grpPembayaran.SuspendLayout()
            CType(numDP, ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' lblJudulPesanan
            ' 
            lblJudulPesanan.Font = New Font("Segoe UI", 21.0F, FontStyle.Bold)
            lblJudulPesanan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulPesanan.Location = New Point(20, 15)
            lblJudulPesanan.Name = "lblJudulPesanan"
            lblJudulPesanan.Size = New Size(650, 40)
            lblJudulPesanan.TabIndex = 0
            lblJudulPesanan.Text = "Pembuatan Pesanan"
            lblJudulPesanan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' grpInfoPesanan
            ' 
            grpInfoPesanan.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            grpInfoPesanan.Controls.Add(lblPelanggan)
            grpInfoPesanan.Controls.Add(cmbPelanggan)
            grpInfoPesanan.Controls.Add(lblTanggalPesan)
            grpInfoPesanan.Controls.Add(dtpTanggalPesan)
            grpInfoPesanan.Controls.Add(lblTanggalKirim)
            grpInfoPesanan.Controls.Add(dtpTanggalKirim)
            grpInfoPesanan.Controls.Add(lblJamKirim)
            grpInfoPesanan.Controls.Add(dtpJamKirim)
            grpInfoPesanan.Controls.Add(lblSumber)
            grpInfoPesanan.Controls.Add(cmbSumber)
            grpInfoPesanan.Controls.Add(lblStatusPesanan)
            grpInfoPesanan.Controls.Add(cmbStatusPesanan)
            grpInfoPesanan.Controls.Add(lblStatusBayar)
            grpInfoPesanan.Controls.Add(cmbStatusBayar)
            grpInfoPesanan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            grpInfoPesanan.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            grpInfoPesanan.Location = New Point(20, 60)
            grpInfoPesanan.Name = "grpInfoPesanan"
            grpInfoPesanan.Size = New Size(1320, 100)
            grpInfoPesanan.TabIndex = 1
            grpInfoPesanan.TabStop = False
            grpInfoPesanan.Text = "Informasi Pesanan"
            ' 
            ' lblPelanggan
            ' 
            lblPelanggan.Font = New Font("Segoe UI", 9.0F)
            lblPelanggan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPelanggan.Location = New Point(15, 25)
            lblPelanggan.Name = "lblPelanggan"
            lblPelanggan.Size = New Size(200, 22)
            lblPelanggan.TabIndex = 0
            lblPelanggan.Text = "Pelanggan"
            ' 
            ' cmbPelanggan
            ' 
            cmbPelanggan.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbPelanggan.AutoCompleteSource = AutoCompleteSource.ListItems
            cmbPelanggan.Font = New Font("Segoe UI", 9.0F)
            cmbPelanggan.Location = New Point(15, 50)
            cmbPelanggan.Name = "cmbPelanggan"
            cmbPelanggan.Size = New Size(200, 28)
            cmbPelanggan.TabIndex = 1
            ' 
            ' lblTanggalPesan
            ' 
            lblTanggalPesan.Font = New Font("Segoe UI", 9.0F)
            lblTanggalPesan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalPesan.Location = New Point(230, 25)
            lblTanggalPesan.Name = "lblTanggalPesan"
            lblTanggalPesan.Size = New Size(120, 22)
            lblTanggalPesan.TabIndex = 2
            lblTanggalPesan.Text = "Tanggal Pesan"
            ' 
            ' dtpTanggalPesan
            ' 
            dtpTanggalPesan.Font = New Font("Segoe UI", 9.0F)
            dtpTanggalPesan.Format = DateTimePickerFormat.Short
            dtpTanggalPesan.Location = New Point(230, 50)
            dtpTanggalPesan.Name = "dtpTanggalPesan"
            dtpTanggalPesan.Size = New Size(120, 27)
            dtpTanggalPesan.TabIndex = 3
            ' 
            ' lblTanggalKirim
            ' 
            lblTanggalKirim.Font = New Font("Segoe UI", 9.0F)
            lblTanggalKirim.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalKirim.Location = New Point(365, 25)
            lblTanggalKirim.Name = "lblTanggalKirim"
            lblTanggalKirim.Size = New Size(120, 22)
            lblTanggalKirim.TabIndex = 4
            lblTanggalKirim.Text = "Tanggal Kirim"
            ' 
            ' dtpTanggalKirim
            ' 
            dtpTanggalKirim.Font = New Font("Segoe UI", 9.0F)
            dtpTanggalKirim.Format = DateTimePickerFormat.Short
            dtpTanggalKirim.Location = New Point(365, 50)
            dtpTanggalKirim.Name = "dtpTanggalKirim"
            dtpTanggalKirim.Size = New Size(120, 27)
            dtpTanggalKirim.TabIndex = 5
            ' 
            ' lblJamKirim
            ' 
            lblJamKirim.Font = New Font("Segoe UI", 9.0F)
            lblJamKirim.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJamKirim.Location = New Point(500, 25)
            lblJamKirim.Name = "lblJamKirim"
            lblJamKirim.Size = New Size(80, 22)
            lblJamKirim.TabIndex = 6
            lblJamKirim.Text = "Jam Kirim"
            ' 
            ' dtpJamKirim
            ' 
            dtpJamKirim.CustomFormat = "HH:mm"
            dtpJamKirim.Font = New Font("Segoe UI", 9.0F)
            dtpJamKirim.Format = DateTimePickerFormat.Custom
            dtpJamKirim.ImeMode = ImeMode.Off
            dtpJamKirim.Location = New Point(500, 50)
            dtpJamKirim.Name = "dtpJamKirim"
            dtpJamKirim.ShowUpDown = True
            dtpJamKirim.Size = New Size(80, 27)
            dtpJamKirim.TabIndex = 7
            ' 
            ' lblSumber
            ' 
            lblSumber.Font = New Font("Segoe UI", 9.0F)
            lblSumber.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSumber.Location = New Point(600, 25)
            lblSumber.Name = "lblSumber"
            lblSumber.Size = New Size(120, 22)
            lblSumber.TabIndex = 8
            lblSumber.Text = "Sumber Pesanan"
            ' 
            ' cmbSumber
            ' 
            cmbSumber.Font = New Font("Segoe UI", 9.0F)
            cmbSumber.Items.AddRange(New Object() {"WA", "Telepon", "Langsung", "Lainnya"})
            cmbSumber.Location = New Point(600, 50)
            cmbSumber.Name = "cmbSumber"
            cmbSumber.Size = New Size(120, 28)
            cmbSumber.TabIndex = 9
            ' 
            ' lblStatusPesanan
            ' 
            lblStatusPesanan.Font = New Font("Segoe UI", 9.0F)
            lblStatusPesanan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblStatusPesanan.Location = New Point(740, 25)
            lblStatusPesanan.Name = "lblStatusPesanan"
            lblStatusPesanan.Size = New Size(120, 22)
            lblStatusPesanan.TabIndex = 10
            lblStatusPesanan.Text = "Status Pesanan"
            ' 
            ' cmbStatusPesanan
            ' 
            cmbStatusPesanan.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatusPesanan.Font = New Font("Segoe UI", 9.0F)
            cmbStatusPesanan.Items.AddRange(New Object() {"BARU", "DIPROSES", "SELESAI"})
            cmbStatusPesanan.Location = New Point(740, 50)
            cmbStatusPesanan.Name = "cmbStatusPesanan"
            cmbStatusPesanan.Size = New Size(120, 28)
            cmbStatusPesanan.TabIndex = 11
            ' 
            ' lblStatusBayar
            ' 
            lblStatusBayar.Font = New Font("Segoe UI", 9.0F)
            lblStatusBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblStatusBayar.Location = New Point(880, 25)
            lblStatusBayar.Name = "lblStatusBayar"
            lblStatusBayar.Size = New Size(130, 22)
            lblStatusBayar.TabIndex = 12
            lblStatusBayar.Text = "Status Pembayaran"
            ' 
            ' cmbStatusBayar
            ' 
            cmbStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatusBayar.Enabled = False
            cmbStatusBayar.Font = New Font("Segoe UI", 9.0F)
            cmbStatusBayar.Items.AddRange(New Object() {"BELUM", "DP", "LUNAS"})
            cmbStatusBayar.Location = New Point(880, 50)
            cmbStatusBayar.Name = "cmbStatusBayar"
            cmbStatusBayar.Size = New Size(130, 28)
            cmbStatusBayar.TabIndex = 13
            ' 
            ' grpPilihProduk
            ' 
            grpPilihProduk.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
            grpPilihProduk.Controls.Add(lblProduk)
            grpPilihProduk.Controls.Add(cmbProduk)
            grpPilihProduk.Controls.Add(lblQty)
            grpPilihProduk.Controls.Add(numQty)
            grpPilihProduk.Controls.Add(lblHarga)
            grpPilihProduk.Controls.Add(txtHarga)
            grpPilihProduk.Controls.Add(lblSubtotal)
            grpPilihProduk.Controls.Add(txtSubtotal)
            grpPilihProduk.Controls.Add(btnTambahItem)
            grpPilihProduk.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            grpPilihProduk.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            grpPilihProduk.Location = New Point(20, 175)
            grpPilihProduk.Name = "grpPilihProduk"
            grpPilihProduk.Size = New Size(360, 200)
            grpPilihProduk.TabIndex = 2
            grpPilihProduk.TabStop = False
            grpPilihProduk.Text = "Pilih Produk"
            ' 
            ' lblProduk
            ' 
            lblProduk.Font = New Font("Segoe UI", 9.0F)
            lblProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblProduk.Location = New Point(15, 25)
            lblProduk.Name = "lblProduk"
            lblProduk.Size = New Size(330, 22)
            lblProduk.TabIndex = 0
            lblProduk.Text = "Nama Produk"
            ' 
            ' cmbProduk
            ' 
            cmbProduk.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            cmbProduk.AutoCompleteSource = AutoCompleteSource.ListItems
            cmbProduk.Font = New Font("Segoe UI", 9.0F)
            cmbProduk.Location = New Point(15, 50)
            cmbProduk.Name = "cmbProduk"
            cmbProduk.Size = New Size(330, 28)
            cmbProduk.TabIndex = 1
            ' 
            ' lblQty
            ' 
            lblQty.Font = New Font("Segoe UI", 9.0F)
            lblQty.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblQty.Location = New Point(15, 90)
            lblQty.Name = "lblQty"
            lblQty.Size = New Size(75, 22)
            lblQty.TabIndex = 2
            lblQty.Text = "Jumlah"
            ' 
            ' numQty
            ' 
            numQty.Font = New Font("Segoe UI", 9.0F)
            numQty.Location = New Point(15, 115)
            numQty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 65536})
            numQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            numQty.Name = "numQty"
            numQty.Size = New Size(75, 27)
            numQty.TabIndex = 3
            numQty.ThousandsSeparator = True
            numQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' lblHarga
            ' 
            lblHarga.Font = New Font("Segoe UI", 9.0F)
            lblHarga.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHarga.Location = New Point(105, 90)
            lblHarga.Name = "lblHarga"
            lblHarga.Size = New Size(110, 22)
            lblHarga.TabIndex = 4
            lblHarga.Text = "Harga (Rp)"
            ' 
            ' txtHarga
            ' 
            txtHarga.BackColor = SystemColors.Window
            txtHarga.BorderStyle = BorderStyle.FixedSingle
            txtHarga.Font = New Font("Segoe UI", 9.0F)
            txtHarga.Location = New Point(105, 115)
            txtHarga.Name = "txtHarga"
            txtHarga.ReadOnly = True
            txtHarga.Size = New Size(110, 27)
            txtHarga.TabIndex = 5
            ' 
            ' lblSubtotal
            ' 
            lblSubtotal.Font = New Font("Segoe UI", 9.0F)
            lblSubtotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSubtotal.Location = New Point(230, 90)
            lblSubtotal.Name = "lblSubtotal"
            lblSubtotal.Size = New Size(115, 22)
            lblSubtotal.TabIndex = 6
            lblSubtotal.Text = "Subtotal (Rp)"
            ' 
            ' txtSubtotal
            ' 
            txtSubtotal.BackColor = SystemColors.Window
            txtSubtotal.BorderStyle = BorderStyle.FixedSingle
            txtSubtotal.Font = New Font("Segoe UI", 9.0F)
            txtSubtotal.Location = New Point(230, 115)
            txtSubtotal.Name = "txtSubtotal"
            txtSubtotal.ReadOnly = True
            txtSubtotal.Size = New Size(115, 27)
            txtSubtotal.TabIndex = 7
            ' 
            ' btnTambahItem
            ' 
            btnTambahItem.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnTambahItem.Cursor = Cursors.Hand
            btnTambahItem.FlatStyle = FlatStyle.Flat
            btnTambahItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnTambahItem.ForeColor = Color.White
            btnTambahItem.Location = New Point(15, 155)
            btnTambahItem.Name = "btnTambahItem"
            btnTambahItem.Size = New Size(330, 35)
            btnTambahItem.TabIndex = 8
            btnTambahItem.Text = "+ Tambah Item ke Keranjang"
            btnTambahItem.UseVisualStyleBackColor = False
            ' 
            ' dgvDetailPesanan
            ' 
            dgvDetailPesanan.AllowUserToAddRows = False
            dgvDetailPesanan.AllowUserToDeleteRows = False
            dgvDetailPesanan.AllowUserToResizeRows = False
            dgvDetailPesanan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgvDetailPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvDetailPesanan.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvDetailPesanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvDetailPesanan.ColumnHeadersHeight = 29
            dgvDetailPesanan.Columns.AddRange(New DataGridViewColumn() {dgvDetailPesanan_id_produkColumn, dgvDetailPesanan_nama_produkColumn, dgvDetailPesanan_qtyColumn, dgvDetailPesanan_harga_satuanColumn, dgvDetailPesanan_subtotalColumn})
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvDetailPesanan.DefaultCellStyle = DataGridViewCellStyle2
            dgvDetailPesanan.EnableHeadersVisualStyles = False
            dgvDetailPesanan.Location = New Point(400, 175)
            dgvDetailPesanan.MultiSelect = False
            dgvDetailPesanan.Name = "dgvDetailPesanan"
            dgvDetailPesanan.ReadOnly = True
            dgvDetailPesanan.RowHeadersVisible = False
            dgvDetailPesanan.RowHeadersWidth = 51
            dgvDetailPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDetailPesanan.Size = New Size(940, 380)
            dgvDetailPesanan.TabIndex = 3
            ' 
            ' dgvDetailPesanan_id_produkColumn
            ' 
            dgvDetailPesanan_id_produkColumn.DataPropertyName = "id_produk"
            dgvDetailPesanan_id_produkColumn.HeaderText = "ID"
            dgvDetailPesanan_id_produkColumn.MinimumWidth = 6
            dgvDetailPesanan_id_produkColumn.Name = "dgvDetailPesanan_id_produkColumn"
            dgvDetailPesanan_id_produkColumn.ReadOnly = True
            dgvDetailPesanan_id_produkColumn.Visible = False
            ' 
            ' dgvDetailPesanan_nama_produkColumn
            ' 
            dgvDetailPesanan_nama_produkColumn.DataPropertyName = "nama_produk"
            dgvDetailPesanan_nama_produkColumn.HeaderText = "Nama Produk"
            dgvDetailPesanan_nama_produkColumn.MinimumWidth = 6
            dgvDetailPesanan_nama_produkColumn.Name = "dgvDetailPesanan_nama_produkColumn"
            dgvDetailPesanan_nama_produkColumn.ReadOnly = True
            ' 
            ' dgvDetailPesanan_qtyColumn
            ' 
            dgvDetailPesanan_qtyColumn.DataPropertyName = "qty"
            dgvDetailPesanan_qtyColumn.HeaderText = "Jumlah"
            dgvDetailPesanan_qtyColumn.MinimumWidth = 6
            dgvDetailPesanan_qtyColumn.Name = "dgvDetailPesanan_qtyColumn"
            dgvDetailPesanan_qtyColumn.ReadOnly = True
            ' 
            ' dgvDetailPesanan_harga_satuanColumn
            ' 
            dgvDetailPesanan_harga_satuanColumn.DataPropertyName = "harga_satuan"
            dgvDetailPesanan_harga_satuanColumn.HeaderText = "Harga Satuan"
            dgvDetailPesanan_harga_satuanColumn.MinimumWidth = 6
            dgvDetailPesanan_harga_satuanColumn.Name = "dgvDetailPesanan_harga_satuanColumn"
            dgvDetailPesanan_harga_satuanColumn.ReadOnly = True
            ' 
            ' dgvDetailPesanan_subtotalColumn
            ' 
            dgvDetailPesanan_subtotalColumn.DataPropertyName = "subtotal"
            dgvDetailPesanan_subtotalColumn.HeaderText = "Subtotal"
            dgvDetailPesanan_subtotalColumn.MinimumWidth = 6
            dgvDetailPesanan_subtotalColumn.Name = "dgvDetailPesanan_subtotalColumn"
            dgvDetailPesanan_subtotalColumn.ReadOnly = True
            ' 
            ' grpPembayaran
            ' 
            grpPembayaran.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            grpPembayaran.Controls.Add(lblTotal)
            grpPembayaran.Controls.Add(txtTotal)
            grpPembayaran.Controls.Add(lblDP)
            grpPembayaran.Controls.Add(numDP)
            grpPembayaran.Controls.Add(lblSisa)
            grpPembayaran.Controls.Add(txtSisa)
            grpPembayaran.Controls.Add(lblCatatan)
            grpPembayaran.Controls.Add(txtCatatan)
            grpPembayaran.Controls.Add(btnHapusItem)
            grpPembayaran.Controls.Add(btnBersihkan)
            grpPembayaran.Controls.Add(btnSimpan)
            grpPembayaran.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            grpPembayaran.ForeColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            grpPembayaran.Location = New Point(20, 570)
            grpPembayaran.Name = "grpPembayaran"
            grpPembayaran.Size = New Size(1320, 180)
            grpPembayaran.TabIndex = 4
            grpPembayaran.TabStop = False
            grpPembayaran.Text = "Pembayaran & Penyelesaian"
            ' 
            ' lblTotal
            ' 
            lblTotal.Font = New Font("Segoe UI", 9.0F)
            lblTotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTotal.Location = New Point(15, 25)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New Size(150, 22)
            lblTotal.TabIndex = 0
            lblTotal.Text = "Total Pesanan (Rp)"
            ' 
            ' txtTotal
            ' 
            txtTotal.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            txtTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            txtTotal.Location = New Point(15, 50)
            txtTotal.Name = "txtTotal"
            txtTotal.ReadOnly = True
            txtTotal.Size = New Size(150, 27)
            txtTotal.TabIndex = 1
            txtTotal.Text = "0"
            ' 
            ' lblDP
            ' 
            lblDP.Font = New Font("Segoe UI", 9.0F)
            lblDP.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblDP.Location = New Point(180, 25)
            lblDP.Name = "lblDP"
            lblDP.Size = New Size(150, 22)
            lblDP.TabIndex = 2
            lblDP.Text = "Uang Muka / DP (Rp)"
            ' 
            ' numDP
            ' 
            numDP.Font = New Font("Segoe UI", 9.0F)
            numDP.Location = New Point(180, 50)
            numDP.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
            numDP.Name = "numDP"
            numDP.Size = New Size(150, 27)
            numDP.TabIndex = 3
            numDP.ThousandsSeparator = True
            ' 
            ' lblSisa
            ' 
            lblSisa.Font = New Font("Segoe UI", 9.0F)
            lblSisa.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSisa.Location = New Point(345, 25)
            lblSisa.Name = "lblSisa"
            lblSisa.Size = New Size(150, 22)
            lblSisa.TabIndex = 4
            lblSisa.Text = "Sisa Tagihan (Rp)"
            ' 
            ' txtSisa
            ' 
            txtSisa.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            txtSisa.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            txtSisa.ForeColor = Color.Red
            txtSisa.Location = New Point(345, 50)
            txtSisa.Name = "txtSisa"
            txtSisa.ReadOnly = True
            txtSisa.Size = New Size(150, 27)
            txtSisa.TabIndex = 5
            txtSisa.Text = "0"
            ' 
            ' lblCatatan
            ' 
            lblCatatan.Font = New Font("Segoe UI", 9.0F)
            lblCatatan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblCatatan.Location = New Point(15, 85)
            lblCatatan.Name = "lblCatatan"
            lblCatatan.Size = New Size(480, 22)
            lblCatatan.TabIndex = 6
            lblCatatan.Text = "Catatan Pesanan"
            ' 
            ' txtCatatan
            ' 
            txtCatatan.Font = New Font("Segoe UI", 9.0F)
            txtCatatan.Location = New Point(15, 110)
            txtCatatan.Multiline = True
            txtCatatan.Name = "txtCatatan"
            txtCatatan.ScrollBars = ScrollBars.Vertical
            txtCatatan.Size = New Size(480, 55)
            txtCatatan.TabIndex = 7
            ' 
            ' btnHapusItem
            ' 
            btnHapusItem.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnHapusItem.Cursor = Cursors.Hand
            btnHapusItem.FlatStyle = FlatStyle.Flat
            btnHapusItem.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnHapusItem.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnHapusItem.Location = New Point(515, 105)
            btnHapusItem.Name = "btnHapusItem"
            btnHapusItem.Size = New Size(125, 40)
            btnHapusItem.TabIndex = 8
            btnHapusItem.Text = "Hapus Item"
            btnHapusItem.UseVisualStyleBackColor = False
            ' 
            ' btnBersihkan
            ' 
            btnBersihkan.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(1020, 105)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(140, 40)
            btnBersihkan.TabIndex = 9
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            ' 
            ' btnSimpan
            ' 
            btnSimpan.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            btnSimpan.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnSimpan.Cursor = Cursors.Hand
            btnSimpan.FlatStyle = FlatStyle.Flat
            btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnSimpan.ForeColor = Color.White
            btnSimpan.Location = New Point(1170, 105)
            btnSimpan.Name = "btnSimpan"
            btnSimpan.Size = New Size(135, 40)
            btnSimpan.TabIndex = 10
            btnSimpan.Text = "Simpan Pesanan"
            btnSimpan.UseVisualStyleBackColor = False
            ' 
            ' FrmPesanan
            ' 
            AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1360, 770)
            Controls.Add(grpPembayaran)
            Controls.Add(dgvDetailPesanan)
            Controls.Add(grpPilihProduk)
            Controls.Add(grpInfoPesanan)
            Controls.Add(lblJudulPesanan)
            Font = New Font("Segoe UI", 9.0F)
            MinimumSize = New Size(1200, 700)
            Name = "FrmPesanan"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Pemesanan - Sistem Kasir Toko Roti"
            grpInfoPesanan.ResumeLayout(False)
            grpPilihProduk.ResumeLayout(False)
            grpPilihProduk.PerformLayout()
            CType(numQty, ISupportInitialize).EndInit()
            CType(dgvDetailPesanan, ISupportInitialize).EndInit()
            grpPembayaran.ResumeLayout(False)
            grpPembayaran.PerformLayout()
            CType(numDP, ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        Friend WithEvents lblJudulPesanan As System.Windows.Forms.Label
        Friend WithEvents grpInfoPesanan As System.Windows.Forms.GroupBox
        Friend WithEvents lblPelanggan As System.Windows.Forms.Label
        Friend WithEvents cmbPelanggan As System.Windows.Forms.ComboBox
        Friend WithEvents lblTanggalPesan As System.Windows.Forms.Label
        Friend WithEvents dtpTanggalPesan As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTanggalKirim As System.Windows.Forms.Label
        Friend WithEvents dtpTanggalKirim As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblJamKirim As System.Windows.Forms.Label
        Friend WithEvents dtpJamKirim As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblSumber As System.Windows.Forms.Label
        Friend WithEvents cmbSumber As System.Windows.Forms.ComboBox
        Friend WithEvents lblStatusPesanan As System.Windows.Forms.Label
        Friend WithEvents cmbStatusPesanan As System.Windows.Forms.ComboBox
        Friend WithEvents lblStatusBayar As System.Windows.Forms.Label
        Friend WithEvents cmbStatusBayar As System.Windows.Forms.ComboBox
        Friend WithEvents grpPilihProduk As System.Windows.Forms.GroupBox
        Friend WithEvents lblProduk As System.Windows.Forms.Label
        Friend WithEvents cmbProduk As System.Windows.Forms.ComboBox
        Friend WithEvents lblQty As System.Windows.Forms.Label
        Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblHarga As System.Windows.Forms.Label
        Friend WithEvents txtHarga As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahItem As System.Windows.Forms.Button
        Friend WithEvents dgvDetailPesanan As System.Windows.Forms.DataGridView
        Friend WithEvents dgvDetailPesanan_id_produkColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_nama_produkColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_qtyColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_harga_satuanColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_subtotalColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents grpPembayaran As System.Windows.Forms.GroupBox
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblDP As System.Windows.Forms.Label
        Friend WithEvents numDP As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblSisa As System.Windows.Forms.Label
        Friend WithEvents txtSisa As System.Windows.Forms.TextBox
        Friend WithEvents lblCatatan As System.Windows.Forms.Label
        Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
        Friend WithEvents btnHapusItem As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
    End Class
End Namespace