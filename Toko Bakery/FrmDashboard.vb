Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Partial Public Class FrmDashboard
        Private pnlIsi As Panel
        Private kartuPesanan, kartuPemasukan, kartuPiutang, kartuKirim As Panel
        Private chartPenjualan, chartProduk As Chart

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

        Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BuatDashboard()
            MuatData()
        End Sub

        Private Sub OpenChild(child As Form)
            Using child
                child.ShowDialog(Me)
            End Using
            MuatData() ' refresh setelah form anak ditutup
        End Sub

        ' ---------- MEMBUAT TAMPILAN ----------
        Private Sub BuatDashboard()
            pnlIsi = New Panel With {
                .Location = New Point(350, 200),
                .Size = New Size(Me.ClientSize.Width - 380, Me.ClientSize.Height - 230),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
            }
            Me.Controls.Add(pnlIsi)
            pnlIsi.BringToFront()

            Dim tlp As New TableLayoutPanel With {.Dock = DockStyle.Fill, .ColumnCount = 4, .RowCount = 2}
            For i = 1 To 4
                tlp.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25))
            Next
            tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 110))
            tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
            pnlIsi.Controls.Add(tlp)

            kartuPesanan = BuatKartu("Pesanan Hari Ini", Color.FromArgb(52, 152, 219))
            kartuPemasukan = BuatKartu("Pemasukan Hari Ini", Color.FromArgb(39, 174, 96))
            kartuPiutang = BuatKartu("Sisa Tagihan", Color.FromArgb(231, 76, 60))
            kartuKirim = BuatKartu("Pengiriman Hari Ini", Color.FromArgb(243, 156, 18))
            tlp.Controls.Add(kartuPesanan, 0, 0)
            tlp.Controls.Add(kartuPemasukan, 1, 0)
            tlp.Controls.Add(kartuPiutang, 2, 0)
            tlp.Controls.Add(kartuKirim, 3, 0)

            chartPenjualan = BuatChart("Penjualan 7 Hari Terakhir (Rp)", SeriesChartType.Column)
            chartProduk = BuatChart("5 Produk Terlaris (30 Hari)", SeriesChartType.Bar)
            tlp.Controls.Add(chartPenjualan, 0, 1)
            tlp.SetColumnSpan(chartPenjualan, 2)
            tlp.Controls.Add(chartProduk, 2, 1)
            tlp.SetColumnSpan(chartProduk, 2)
        End Sub

        Private Function BuatKartu(judul As String, warna As Color) As Panel
            Dim p As New Panel With {.Dock = DockStyle.Fill, .BackColor = warna, .Margin = New Padding(5)}
            Dim lblJ As New Label With {
                .Text = judul, .ForeColor = Color.White, .Font = New Font("Segoe UI", 10),
                .Dock = DockStyle.Top, .Height = 35, .Padding = New Padding(12, 10, 0, 0)
            }
            Dim lblV As New Label With {
                .Name = "val", .Text = "0", .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 18, FontStyle.Bold),
                .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft, .Padding = New Padding(12, 0, 0, 0)
            }
            p.Controls.Add(lblV)
            p.Controls.Add(lblJ)
            Return p
        End Function

        Private Function BuatChart(judul As String, tipe As SeriesChartType) As Chart
            Dim ch As New Chart With {.Dock = DockStyle.Fill, .BackColor = Color.White, .Margin = New Padding(5)}
            Dim area As New ChartArea("area")
            area.AxisX.MajorGrid.Enabled = False
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro
            ch.ChartAreas.Add(area)
            ch.Titles.Add(New Title(judul, Docking.Top, New Font("Segoe UI", 11, FontStyle.Bold), Color.FromArgb(30, 45, 70)))
            Dim s As New Series("data") With {.ChartType = tipe, .Color = Color.FromArgb(30, 45, 70), .IsValueShownAsLabel = True}
            ch.Series.Add(s)
            Return ch
        End Function

        ' ---------- MENGISI DATA ----------
        Private Sub MuatData()
            Try
                SetNilai(kartuPesanan, Scalar("SELECT COUNT(*) FROM pesanan WHERE tgl_pesan = CURDATE()").ToString() & " pesanan")
                SetNilai(kartuPemasukan, "Rp " & Format(CDec(Scalar("SELECT IFNULL(SUM(jumlah),0) FROM pembayaran WHERE tgl_bayar = CURDATE()")), "N0"))
                SetNilai(kartuPiutang, "Rp " & Format(CDec(Scalar("SELECT IFNULL(SUM(sisa),0) FROM pesanan WHERE sisa > 0")), "N0"))
                SetNilai(kartuKirim, Scalar("SELECT COUNT(*) FROM pesanan WHERE tgl_kirim = CURDATE()").ToString() & " pesanan")

                ' Grafik penjualan 7 hari (hari tanpa penjualan tetap tampil = 0)
                Dim dt As DataTable = Query("SELECT tgl_pesan AS tgl, SUM(total) AS jml FROM pesanan " &
                                            "WHERE tgl_pesan >= CURDATE() - INTERVAL 6 DAY GROUP BY tgl_pesan")
                Dim sPenjualan = chartPenjualan.Series(0)
                sPenjualan.Points.Clear()
                For i As Integer = 6 To 0 Step -1
                    Dim tgl As Date = Date.Today.AddDays(-i)
                    Dim total As Decimal = 0
                    For Each r As DataRow In dt.Rows
                        If CDate(r("tgl")).Date = tgl Then total = CDec(r("jml"))
                    Next
                    sPenjualan.Points.AddXY(tgl.ToString("dd/MM"), total)
                Next
                sPenjualan.LabelFormat = "N0"

                ' Grafik produk terlaris
                Dim dtProduk As DataTable = Query(
                    "SELECT p.nama_produk, SUM(d.qty) AS terjual FROM detail_pesanan d " &
                    "JOIN produk p ON p.id_produk = d.id_produk " &
                    "JOIN pesanan o ON o.id_pesanan = d.id_pesanan " &
                    "WHERE o.tgl_pesan >= CURDATE() - INTERVAL 30 DAY " &
                    "GROUP BY p.id_produk, p.nama_produk ORDER BY terjual DESC LIMIT 5")
                Dim sProduk = chartProduk.Series(0)
                sProduk.Points.Clear()
                For Each r As DataRow In dtProduk.Rows
                    sProduk.Points.AddXY(r("nama_produk").ToString(), CDbl(r("terjual")))
                Next
                chartProduk.ChartAreas(0).AxisX.IsReversed = True ' terlaris di atas
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data dashboard: " & ex.Message)
            End Try
        End Sub

        Private Sub SetNilai(kartu As Panel, teks As String)
            kartu.Controls("val").Text = teks
        End Sub

        ' ---------- HELPER DATABASE (sesuaikan dengan koneksimu) ----------
        Private Const ConnStr As String = "Server=localhost;Database=toko_roti_roti;Uid=root;Pwd=;"

        Private Function Query(sql As String) As DataTable
            Using conn As New MySqlConnection(ConnStr)
                Using da As New MySqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        End Function

        Private Function Scalar(sql As String) As Object
            Using conn As New MySqlConnection(ConnStr)
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        End Function

        Private Sub lblWelcome_Click(sender As Object, e As EventArgs) Handles lblWelcome.Click
        End Sub
    End Class
End Namespace