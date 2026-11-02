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
            lblIdPesanan = New Label()
            txtIdPesanan = New TextBox()
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
            lblProduk = New Label()
            cmbProduk = New ComboBox()
            lblQty = New Label()
            numQty = New NumericUpDown()
            lblHarga = New Label()
            txtHarga = New TextBox()
            lblSubtotal = New Label()
            txtSubtotal = New TextBox()
            btnTambahItem = New Button()
            btnHapusItem = New Button()
            dgvDetailPesanan = New DataGridView()
            dgvDetailPesanan_id_produkColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_nama_produkColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_qtyColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_harga_satuanColumn = New DataGridViewTextBoxColumn()
            dgvDetailPesanan_subtotalColumn = New DataGridViewTextBoxColumn()
            lblTotal = New Label()
            txtTotal = New TextBox()
            lblDP = New Label()
            numDP = New NumericUpDown()
            lblSisa = New Label()
            txtSisa = New TextBox()
            lblCatatan = New Label()
            txtCatatan = New TextBox()
            btnSimpan = New Button()
            btnBersihkan = New Button()
            CType(numQty, ISupportInitialize).BeginInit()
            CType(dgvDetailPesanan, ISupportInitialize).BeginInit()
            CType(numDP, ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' lblJudulPesanan
            ' 
            lblJudulPesanan.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulPesanan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulPesanan.Location = New Point(25, 14)
            lblJudulPesanan.Name = "lblJudulPesanan"
            lblJudulPesanan.Size = New Size(650, 40)
            lblJudulPesanan.TabIndex = 0
            lblJudulPesanan.Text = "Pembuatan Pesanan"
            lblJudulPesanan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblIdPesanan
            ' 
            lblIdPesanan.Font = New Font("Segoe UI", 9F)
            lblIdPesanan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblIdPesanan.Location = New Point(30, 58)
            lblIdPesanan.Name = "lblIdPesanan"
            lblIdPesanan.Size = New Size(150, 22)
            lblIdPesanan.TabIndex = 1
            lblIdPesanan.Text = "ID Pesanan"
            lblIdPesanan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtIdPesanan
            ' 
            txtIdPesanan.Location = New Point(30, 82)
            txtIdPesanan.Name = "txtIdPesanan"
            txtIdPesanan.ReadOnly = True
            txtIdPesanan.Size = New Size(150, 27)
            txtIdPesanan.TabIndex = 2
            txtIdPesanan.Text = "(otomatis)"
            ' 
            ' lblPelanggan
            ' 
            lblPelanggan.Font = New Font("Segoe UI", 9F)
            lblPelanggan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPelanggan.Location = New Point(200, 58)
            lblPelanggan.Name = "lblPelanggan"
            lblPelanggan.Size = New Size(245, 22)
            lblPelanggan.TabIndex = 3
            lblPelanggan.Text = "Pelanggan"
            lblPelanggan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbPelanggan
            ' 
            cmbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
            cmbPelanggan.Location = New Point(200, 82)
            cmbPelanggan.Name = "cmbPelanggan"
            cmbPelanggan.Size = New Size(245, 28)
            cmbPelanggan.TabIndex = 4
            ' 
            ' lblTanggalPesan
            ' 
            lblTanggalPesan.Font = New Font("Segoe UI", 9F)
            lblTanggalPesan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalPesan.Location = New Point(465, 58)
            lblTanggalPesan.Name = "lblTanggalPesan"
            lblTanggalPesan.Size = New Size(175, 22)
            lblTanggalPesan.TabIndex = 5
            lblTanggalPesan.Text = "Tanggal Pesan"
            lblTanggalPesan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dtpTanggalPesan
            ' 
            dtpTanggalPesan.Format = DateTimePickerFormat.Short
            dtpTanggalPesan.Location = New Point(465, 82)
            dtpTanggalPesan.Name = "dtpTanggalPesan"
            dtpTanggalPesan.Size = New Size(175, 27)
            dtpTanggalPesan.TabIndex = 6
            ' 
            ' lblTanggalKirim
            ' 
            lblTanggalKirim.Font = New Font("Segoe UI", 9F)
            lblTanggalKirim.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTanggalKirim.Location = New Point(660, 58)
            lblTanggalKirim.Name = "lblTanggalKirim"
            lblTanggalKirim.Size = New Size(175, 22)
            lblTanggalKirim.TabIndex = 7
            lblTanggalKirim.Text = "Tanggal Kirim (opsional)"
            lblTanggalKirim.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dtpTanggalKirim
            ' 
            dtpTanggalKirim.Format = DateTimePickerFormat.Short
            dtpTanggalKirim.Location = New Point(660, 82)
            dtpTanggalKirim.Name = "dtpTanggalKirim"
            dtpTanggalKirim.ShowCheckBox = True
            dtpTanggalKirim.Size = New Size(175, 27)
            dtpTanggalKirim.TabIndex = 8
            ' 
            ' lblJamKirim
            ' 
            lblJamKirim.Font = New Font("Segoe UI", 9F)
            lblJamKirim.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblJamKirim.Location = New Point(855, 58)
            lblJamKirim.Name = "lblJamKirim"
            lblJamKirim.Size = New Size(130, 22)
            lblJamKirim.TabIndex = 9
            lblJamKirim.Text = "Jam Kirim"
            lblJamKirim.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dtpJamKirim
            ' 
            dtpJamKirim.CustomFormat = "HH:mm"
            dtpJamKirim.Format = DateTimePickerFormat.Custom
            dtpJamKirim.Location = New Point(855, 82)
            dtpJamKirim.Name = "dtpJamKirim"
            dtpJamKirim.ShowCheckBox = True
            dtpJamKirim.ShowUpDown = True
            dtpJamKirim.Size = New Size(130, 27)
            dtpJamKirim.TabIndex = 10
            ' 
            ' lblSumber
            ' 
            lblSumber.Font = New Font("Segoe UI", 9F)
            lblSumber.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSumber.Location = New Point(1005, 58)
            lblSumber.Name = "lblSumber"
            lblSumber.Size = New Size(150, 22)
            lblSumber.TabIndex = 11
            lblSumber.Text = "Sumber Pesanan"
            lblSumber.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbSumber
            ' 
            cmbSumber.Items.AddRange(New Object() {"WA", "Telepon", "Langsung", "Lainnya"})
            cmbSumber.Location = New Point(1005, 82)
            cmbSumber.Name = "cmbSumber"
            cmbSumber.Size = New Size(150, 28)
            cmbSumber.TabIndex = 12
            ' 
            ' lblStatusPesanan
            ' 
            lblStatusPesanan.Font = New Font("Segoe UI", 9F)
            lblStatusPesanan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblStatusPesanan.Location = New Point(30, 125)
            lblStatusPesanan.Name = "lblStatusPesanan"
            lblStatusPesanan.Size = New Size(170, 22)
            lblStatusPesanan.TabIndex = 13
            lblStatusPesanan.Text = "Status Pesanan"
            lblStatusPesanan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbStatusPesanan
            ' 
            cmbStatusPesanan.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatusPesanan.Items.AddRange(New Object() {"BARU", "DIPROSES", "SELESAI"})
            cmbStatusPesanan.Location = New Point(30, 149)
            cmbStatusPesanan.Name = "cmbStatusPesanan"
            cmbStatusPesanan.Size = New Size(170, 28)
            cmbStatusPesanan.TabIndex = 14
            ' 
            ' lblStatusBayar
            ' 
            lblStatusBayar.Font = New Font("Segoe UI", 9F)
            lblStatusBayar.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblStatusBayar.Location = New Point(220, 125)
            lblStatusBayar.Name = "lblStatusBayar"
            lblStatusBayar.Size = New Size(170, 22)
            lblStatusBayar.TabIndex = 15
            lblStatusBayar.Text = "Status Pembayaran (otomatis)"
            lblStatusBayar.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbStatusBayar
            ' 
            cmbStatusBayar.DropDownStyle = ComboBoxStyle.DropDownList
            cmbStatusBayar.Enabled = False
            cmbStatusBayar.Items.AddRange(New Object() {"BELUM", "DP", "LUNAS"})
            cmbStatusBayar.Location = New Point(220, 149)
            cmbStatusBayar.Name = "cmbStatusBayar"
            cmbStatusBayar.Size = New Size(170, 28)
            cmbStatusBayar.TabIndex = 16
            ' 
            ' lblProduk
            ' 
            lblProduk.Font = New Font("Segoe UI", 9F)
            lblProduk.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblProduk.Location = New Point(410, 125)
            lblProduk.Name = "lblProduk"
            lblProduk.Size = New Size(255, 22)
            lblProduk.TabIndex = 17
            lblProduk.Text = "Produk"
            lblProduk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' cmbProduk
            ' 
            cmbProduk.DropDownStyle = ComboBoxStyle.DropDownList
            cmbProduk.Location = New Point(410, 149)
            cmbProduk.Name = "cmbProduk"
            cmbProduk.Size = New Size(255, 28)
            cmbProduk.TabIndex = 18
            ' 
            ' lblQty
            ' 
            lblQty.Font = New Font("Segoe UI", 9F)
            lblQty.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblQty.Location = New Point(685, 125)
            lblQty.Name = "lblQty"
            lblQty.Size = New Size(75, 22)
            lblQty.TabIndex = 19
            lblQty.Text = "Jumlah"
            lblQty.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numQty
            ' 
            numQty.Location = New Point(685, 149)
            numQty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 65536})
            numQty.Minimum = New Decimal(New Integer() {10, 0, 0, 65536})
            numQty.Name = "numQty"
            numQty.Size = New Size(75, 27)
            numQty.TabIndex = 20
            numQty.ThousandsSeparator = True
            numQty.Value = New Decimal(New Integer() {10, 0, 0, 65536})
            ' 
            ' lblHarga
            ' 
            lblHarga.Font = New Font("Segoe UI", 9F)
            lblHarga.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblHarga.Location = New Point(780, 125)
            lblHarga.Name = "lblHarga"
            lblHarga.Size = New Size(150, 22)
            lblHarga.TabIndex = 21
            lblHarga.Text = "Harga Satuan (Rp)"
            lblHarga.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtHarga
            ' 
            txtHarga.Location = New Point(780, 149)
            txtHarga.Name = "txtHarga"
            txtHarga.ReadOnly = True
            txtHarga.Size = New Size(150, 27)
            txtHarga.TabIndex = 22
            ' 
            ' lblSubtotal
            ' 
            lblSubtotal.Font = New Font("Segoe UI", 9F)
            lblSubtotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSubtotal.Location = New Point(950, 125)
            lblSubtotal.Name = "lblSubtotal"
            lblSubtotal.Size = New Size(150, 22)
            lblSubtotal.TabIndex = 23
            lblSubtotal.Text = "Subtotal (Rp)"
            lblSubtotal.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtSubtotal
            ' 
            txtSubtotal.Location = New Point(950, 149)
            txtSubtotal.Name = "txtSubtotal"
            txtSubtotal.ReadOnly = True
            txtSubtotal.Size = New Size(150, 27)
            txtSubtotal.TabIndex = 24
            ' 
            ' btnTambahItem
            ' 
            btnTambahItem.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnTambahItem.Cursor = Cursors.Hand
            btnTambahItem.FlatStyle = FlatStyle.Flat
            btnTambahItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnTambahItem.ForeColor = Color.White
            btnTambahItem.Location = New Point(1120, 145)
            btnTambahItem.Name = "btnTambahItem"
            btnTambahItem.Size = New Size(115, 36)
            btnTambahItem.TabIndex = 25
            btnTambahItem.Text = "Tambah Item"
            btnTambahItem.UseVisualStyleBackColor = False
            ' 
            ' btnHapusItem
            ' 
            btnHapusItem.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnHapusItem.Cursor = Cursors.Hand
            btnHapusItem.FlatStyle = FlatStyle.Flat
            btnHapusItem.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnHapusItem.Location = New Point(1245, 145)
            btnHapusItem.Name = "btnHapusItem"
            btnHapusItem.Size = New Size(110, 36)
            btnHapusItem.TabIndex = 26
            btnHapusItem.Text = "Hapus Item"
            btnHapusItem.UseVisualStyleBackColor = False
            ' 
            ' dgvDetailPesanan
            ' 
            dgvDetailPesanan.AllowUserToAddRows = False
            dgvDetailPesanan.AllowUserToDeleteRows = False
            dgvDetailPesanan.AllowUserToResizeRows = False
            dgvDetailPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvDetailPesanan.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvDetailPesanan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvDetailPesanan.ColumnHeadersHeight = 29
            dgvDetailPesanan.Columns.AddRange(New DataGridViewColumn() {dgvDetailPesanan_id_produkColumn, dgvDetailPesanan_nama_produkColumn, dgvDetailPesanan_qtyColumn, dgvDetailPesanan_harga_satuanColumn, dgvDetailPesanan_subtotalColumn})
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvDetailPesanan.DefaultCellStyle = DataGridViewCellStyle2
            dgvDetailPesanan.EnableHeadersVisualStyles = False
            dgvDetailPesanan.Location = New Point(30, 200)
            dgvDetailPesanan.MultiSelect = False
            dgvDetailPesanan.Name = "dgvDetailPesanan"
            dgvDetailPesanan.ReadOnly = True
            dgvDetailPesanan.RowHeadersVisible = False
            dgvDetailPesanan.RowHeadersWidth = 51
            dgvDetailPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvDetailPesanan.Size = New Size(1325, 330)
            dgvDetailPesanan.TabIndex = 27
            ' 
            ' dgvDetailPesanan_id_produkColumn
            ' 
            dgvDetailPesanan_id_produkColumn.DataPropertyName = "id_produk"
            dgvDetailPesanan_id_produkColumn.HeaderText = "ID Produk"
            dgvDetailPesanan_id_produkColumn.MinimumWidth = 6
            dgvDetailPesanan_id_produkColumn.Name = "dgvDetailPesanan_id_produkColumn"
            dgvDetailPesanan_id_produkColumn.ReadOnly = True
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
            ' lblTotal
            ' 
            lblTotal.Font = New Font("Segoe UI", 9F)
            lblTotal.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblTotal.Location = New Point(30, 545)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New Size(190, 22)
            lblTotal.TabIndex = 28
            lblTotal.Text = "Total Pesanan (Rp)"
            lblTotal.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtTotal
            ' 
            txtTotal.Location = New Point(30, 569)
            txtTotal.Name = "txtTotal"
            txtTotal.ReadOnly = True
            txtTotal.Size = New Size(190, 27)
            txtTotal.TabIndex = 29
            txtTotal.Text = "0.00"
            ' 
            ' lblDP
            ' 
            lblDP.Font = New Font("Segoe UI", 9F)
            lblDP.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblDP.Location = New Point(255, 545)
            lblDP.Name = "lblDP"
            lblDP.Size = New Size(190, 22)
            lblDP.TabIndex = 30
            lblDP.Text = "Uang Muka / DP (Rp)"
            lblDP.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' numDP
            ' 
            numDP.DecimalPlaces = 2
            numDP.Location = New Point(255, 569)
            numDP.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            numDP.Name = "numDP"
            numDP.Size = New Size(190, 27)
            numDP.TabIndex = 31
            numDP.ThousandsSeparator = True
            ' 
            ' lblSisa
            ' 
            lblSisa.Font = New Font("Segoe UI", 9F)
            lblSisa.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblSisa.Location = New Point(480, 545)
            lblSisa.Name = "lblSisa"
            lblSisa.Size = New Size(190, 22)
            lblSisa.TabIndex = 32
            lblSisa.Text = "Sisa Tagihan (Rp)"
            lblSisa.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtSisa
            ' 
            txtSisa.Location = New Point(480, 569)
            txtSisa.Name = "txtSisa"
            txtSisa.ReadOnly = True
            txtSisa.Size = New Size(190, 27)
            txtSisa.TabIndex = 33
            txtSisa.Text = "0.00"
            ' 
            ' lblCatatan
            ' 
            lblCatatan.Font = New Font("Segoe UI", 9F)
            lblCatatan.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblCatatan.Location = New Point(30, 620)
            lblCatatan.Name = "lblCatatan"
            lblCatatan.Size = New Size(700, 22)
            lblCatatan.TabIndex = 34
            lblCatatan.Text = "Catatan Pesanan"
            lblCatatan.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtCatatan
            ' 
            txtCatatan.Location = New Point(30, 644)
            txtCatatan.Multiline = True
            txtCatatan.Name = "txtCatatan"
            txtCatatan.ScrollBars = ScrollBars.Vertical
            txtCatatan.Size = New Size(850, 70)
            txtCatatan.TabIndex = 35
            ' 
            ' btnSimpan
            ' 
            btnSimpan.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnSimpan.Cursor = Cursors.Hand
            btnSimpan.FlatStyle = FlatStyle.Flat
            btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnSimpan.ForeColor = Color.White
            btnSimpan.Location = New Point(1030, 660)
            btnSimpan.Name = "btnSimpan"
            btnSimpan.Size = New Size(145, 44)
            btnSimpan.TabIndex = 36
            btnSimpan.Text = "Simpan Pesanan"
            btnSimpan.UseVisualStyleBackColor = False
            ' 
            ' btnBersihkan
            ' 
            btnBersihkan.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnBersihkan.Cursor = Cursors.Hand
            btnBersihkan.FlatStyle = FlatStyle.Flat
            btnBersihkan.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnBersihkan.Location = New Point(1190, 660)
            btnBersihkan.Name = "btnBersihkan"
            btnBersihkan.Size = New Size(145, 44)
            btnBersihkan.TabIndex = 37
            btnBersihkan.Text = "Bersihkan"
            btnBersihkan.UseVisualStyleBackColor = False
            ' 
            ' FrmPesanan
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1380, 820)
            Controls.Add(lblJudulPesanan)
            Controls.Add(lblIdPesanan)
            Controls.Add(txtIdPesanan)
            Controls.Add(lblPelanggan)
            Controls.Add(cmbPelanggan)
            Controls.Add(lblTanggalPesan)
            Controls.Add(dtpTanggalPesan)
            Controls.Add(lblTanggalKirim)
            Controls.Add(dtpTanggalKirim)
            Controls.Add(lblJamKirim)
            Controls.Add(dtpJamKirim)
            Controls.Add(lblSumber)
            Controls.Add(cmbSumber)
            Controls.Add(lblStatusPesanan)
            Controls.Add(cmbStatusPesanan)
            Controls.Add(lblStatusBayar)
            Controls.Add(cmbStatusBayar)
            Controls.Add(lblProduk)
            Controls.Add(cmbProduk)
            Controls.Add(lblQty)
            Controls.Add(numQty)
            Controls.Add(lblHarga)
            Controls.Add(txtHarga)
            Controls.Add(lblSubtotal)
            Controls.Add(txtSubtotal)
            Controls.Add(btnTambahItem)
            Controls.Add(btnHapusItem)
            Controls.Add(dgvDetailPesanan)
            Controls.Add(lblTotal)
            Controls.Add(txtTotal)
            Controls.Add(lblDP)
            Controls.Add(numDP)
            Controls.Add(lblSisa)
            Controls.Add(txtSisa)
            Controls.Add(lblCatatan)
            Controls.Add(txtCatatan)
            Controls.Add(btnSimpan)
            Controls.Add(btnBersihkan)
            Font = New Font("Segoe UI", 9F)
            Name = "FrmPesanan"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Pemesanan - Sistem Kasir Toko Roti"
            CType(numQty, ISupportInitialize).EndInit()
            CType(dgvDetailPesanan, ISupportInitialize).EndInit()
            CType(numDP, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulPesanan As System.Windows.Forms.Label
        Friend WithEvents lblIdPesanan As System.Windows.Forms.Label
        Friend WithEvents txtIdPesanan As System.Windows.Forms.TextBox
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
        Friend WithEvents lblProduk As System.Windows.Forms.Label
        Friend WithEvents cmbProduk As System.Windows.Forms.ComboBox
        Friend WithEvents lblQty As System.Windows.Forms.Label
        Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblHarga As System.Windows.Forms.Label
        Friend WithEvents txtHarga As System.Windows.Forms.TextBox
        Friend WithEvents lblSubtotal As System.Windows.Forms.Label
        Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
        Friend WithEvents btnTambahItem As System.Windows.Forms.Button
        Friend WithEvents btnHapusItem As System.Windows.Forms.Button
        Friend WithEvents dgvDetailPesanan As System.Windows.Forms.DataGridView
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents txtTotal As System.Windows.Forms.TextBox
        Friend WithEvents lblDP As System.Windows.Forms.Label
        Friend WithEvents numDP As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblSisa As System.Windows.Forms.Label
        Friend WithEvents txtSisa As System.Windows.Forms.TextBox
        Friend WithEvents lblCatatan As System.Windows.Forms.Label
        Friend WithEvents txtCatatan As System.Windows.Forms.TextBox
        Friend WithEvents btnSimpan As System.Windows.Forms.Button
        Friend WithEvents btnBersihkan As System.Windows.Forms.Button
        Friend WithEvents dgvDetailPesanan_id_produkColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_nama_produkColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_qtyColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_harga_satuanColumn As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents dgvDetailPesanan_subtotalColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
