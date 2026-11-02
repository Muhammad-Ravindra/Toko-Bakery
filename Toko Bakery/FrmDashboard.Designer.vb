Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmDashboard
        Inherits System.Windows.Forms.Form

        Private components As IContainer

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
            MyBase.Dispose(disposing)
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            pnlSidebar = New Panel()
            lblBrand = New Label()
            btnPelanggan = New Button()
            btnProduk = New Button()
            btnPesanan = New Button()
            btnPembayaran = New Button()
            btnNota = New Button()
            btnLogout = New Button()
            pnlKonten = New Panel()
            lblJudul = New Label()
            lblWelcome = New Label()
            lblPetunjuk = New Label()
            pnlSidebar.SuspendLayout()
            pnlKonten.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnlSidebar
            ' 
            pnlSidebar.BackColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            pnlSidebar.Controls.Add(lblBrand)
            pnlSidebar.Controls.Add(btnPelanggan)
            pnlSidebar.Controls.Add(btnProduk)
            pnlSidebar.Controls.Add(btnPesanan)
            pnlSidebar.Controls.Add(btnPembayaran)
            pnlSidebar.Controls.Add(btnNota)
            pnlSidebar.Controls.Add(btnLogout)
            pnlSidebar.Location = New Point(0, 0)
            pnlSidebar.Name = "pnlSidebar"
            pnlSidebar.Size = New Size(250, 760)
            pnlSidebar.TabIndex = 0
            ' 
            ' lblBrand
            ' 
            lblBrand.Font = New Font("Segoe UI", 19.0F, FontStyle.Bold)
            lblBrand.ForeColor = Color.White
            lblBrand.Location = New Point(22, 20)
            lblBrand.Name = "lblBrand"
            lblBrand.Size = New Size(206, 70)
            lblBrand.TabIndex = 1
            lblBrand.Text = "TOKO ROTI"
            lblBrand.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' btnPelanggan
            ' 
            btnPelanggan.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(89))
            btnPelanggan.Cursor = Cursors.Hand
            btnPelanggan.FlatStyle = FlatStyle.Flat
            btnPelanggan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnPelanggan.ForeColor = Color.White
            btnPelanggan.Location = New Point(20, 125)
            btnPelanggan.Name = "btnPelanggan"
            btnPelanggan.Size = New Size(210, 46)
            btnPelanggan.TabIndex = 2
            btnPelanggan.Text = "Data Pelanggan"
            btnPelanggan.UseVisualStyleBackColor = False
            ' 
            ' btnProduk
            ' 
            btnProduk.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(89))
            btnProduk.Cursor = Cursors.Hand
            btnProduk.FlatStyle = FlatStyle.Flat
            btnProduk.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnProduk.ForeColor = Color.White
            btnProduk.Location = New Point(20, 183)
            btnProduk.Name = "btnProduk"
            btnProduk.Size = New Size(210, 46)
            btnProduk.TabIndex = 3
            btnProduk.Text = "Data Produk"
            btnProduk.UseVisualStyleBackColor = False
            ' 
            ' btnPesanan
            ' 
            btnPesanan.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(89))
            btnPesanan.Cursor = Cursors.Hand
            btnPesanan.FlatStyle = FlatStyle.Flat
            btnPesanan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnPesanan.ForeColor = Color.White
            btnPesanan.Location = New Point(20, 241)
            btnPesanan.Name = "btnPesanan"
            btnPesanan.Size = New Size(210, 46)
            btnPesanan.TabIndex = 4
            btnPesanan.Text = "Pemesanan"
            btnPesanan.UseVisualStyleBackColor = False
            ' 
            ' btnPembayaran
            ' 
            btnPembayaran.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(89))
            btnPembayaran.Cursor = Cursors.Hand
            btnPembayaran.FlatStyle = FlatStyle.Flat
            btnPembayaran.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnPembayaran.ForeColor = Color.White
            btnPembayaran.Location = New Point(20, 299)
            btnPembayaran.Name = "btnPembayaran"
            btnPembayaran.Size = New Size(210, 46)
            btnPembayaran.TabIndex = 5
            btnPembayaran.Text = "Pembayaran"
            btnPembayaran.UseVisualStyleBackColor = False
            ' 
            ' btnNota
            ' 
            btnNota.BackColor = Color.FromArgb(CByte(49), CByte(66), CByte(89))
            btnNota.Cursor = Cursors.Hand
            btnNota.FlatStyle = FlatStyle.Flat
            btnNota.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnNota.ForeColor = Color.White
            btnNota.Location = New Point(20, 357)
            btnNota.Name = "btnNota"
            btnNota.Size = New Size(210, 46)
            btnNota.TabIndex = 6
            btnNota.Text = "Nota Transaksi"
            btnNota.UseVisualStyleBackColor = False
            ' 
            ' btnLogout
            ' 
            btnLogout.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnLogout.Cursor = Cursors.Hand
            btnLogout.FlatStyle = FlatStyle.Flat
            btnLogout.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnLogout.Location = New Point(20, 680)
            btnLogout.Name = "btnLogout"
            btnLogout.Size = New Size(210, 44)
            btnLogout.TabIndex = 7
            btnLogout.Text = "Keluar / Logout"
            btnLogout.UseVisualStyleBackColor = False
            ' 
            ' pnlKonten
            ' 
            pnlKonten.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            pnlKonten.Controls.Add(lblJudul)
            pnlKonten.Controls.Add(lblWelcome)
            pnlKonten.Controls.Add(lblPetunjuk)
            pnlKonten.Location = New Point(250, 0)
            pnlKonten.Name = "pnlKonten"
            pnlKonten.Size = New Size(930, 760)
            pnlKonten.TabIndex = 8
            ' 
            ' lblJudul
            ' 
            lblJudul.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
            lblJudul.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudul.Location = New Point(35, 35)
            lblJudul.Name = "lblJudul"
            lblJudul.Size = New Size(800, 48)
            lblJudul.TabIndex = 9
            lblJudul.Text = "Dashboard Sistem Kasir Toko Roti"
            lblJudul.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblWelcome
            ' 
            lblWelcome.Font = New Font("Segoe UI", 11.0F)
            lblWelcome.ForeColor = Color.FromArgb(CByte(80), CByte(91), CByte(103))
            lblWelcome.Location = New Point(35, 95)
            lblWelcome.Name = "lblWelcome"
            lblWelcome.Size = New Size(800, 35)
            lblWelcome.TabIndex = 10
            lblWelcome.Text = "Pengguna:"
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblPetunjuk
            ' 
            lblPetunjuk.Font = New Font("Segoe UI", 12.0F)
            lblPetunjuk.ForeColor = Color.FromArgb(CByte(80), CByte(91), CByte(103))
            lblPetunjuk.Location = New Point(35, 165)
            lblPetunjuk.Name = "lblPetunjuk"
            lblPetunjuk.Size = New Size(820, 95)
            lblPetunjuk.TabIndex = 11
            lblPetunjuk.Text = "Pilih menu di sisi kiri untuk mengelola data pelanggan, produk, pesanan, pembayaran, dan nota transaksi."
            lblPetunjuk.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' FrmDashboard
            ' 
            AutoScaleDimensions = New SizeF(8.0F, 20.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1180, 760)
            Controls.Add(pnlSidebar)
            Controls.Add(pnlKonten)
            Font = New Font("Segoe UI", 9.0F)
            Name = "FrmDashboard"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Dashboard - Sistem Kasir Toko Roti"
            pnlSidebar.ResumeLayout(False)
            pnlKonten.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents btnPelanggan As System.Windows.Forms.Button
        Friend WithEvents btnProduk As System.Windows.Forms.Button
        Friend WithEvents btnPesanan As System.Windows.Forms.Button
        Friend WithEvents btnPembayaran As System.Windows.Forms.Button
        Friend WithEvents btnNota As System.Windows.Forms.Button
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents pnlKonten As System.Windows.Forms.Panel
        Friend WithEvents lblJudul As System.Windows.Forms.Label
        Friend WithEvents lblWelcome As System.Windows.Forms.Label
        Friend WithEvents lblPetunjuk As System.Windows.Forms.Label
    End Class
End Namespace
