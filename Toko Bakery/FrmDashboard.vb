Imports System
Imports System.Windows.Forms

Namespace TokoRotiVB
    Public Partial Class FrmDashboard
        Public Sub New()
            InitializeComponent()
            lblWelcome.Text = "Pengguna: " & AppSession.Username & If(AppSession.IsOwner, "  |  Owner", "  |  Kasir / Produksi")
            AddHandler btnPelanggan.Click, Sub(sender, e) OpenChild(New FrmPelanggan())
            AddHandler btnProduk.Click, Sub(sender, e) OpenChild(New FrmProduk())
            AddHandler btnPesanan.Click, Sub(sender, e) OpenChild(New FrmPesanan())
            AddHandler btnPembayaran.Click, Sub(sender, e) OpenChild(New FrmPembayaran())
            AddHandler btnNota.Click, Sub(sender, e) OpenChild(New FrmNota())
            AddHandler btnLogout.Click, Sub(sender, e) Close()
        End Sub

        Private Sub OpenChild(child As Form)
            Using child
                child.ShowDialog(Me)
            End Using
        End Sub

        Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click

        End Sub
    End Class
End Namespace
