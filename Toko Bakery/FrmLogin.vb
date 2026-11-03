Imports System
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace TokoRotiVB
    Public Partial Class FrmLogin
        Public Sub New()
            InitializeComponent()
            AddHandler btnLogin.Click, AddressOf btnLogin_Click
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs)
            Login()
        End Sub

        Private Sub Login()
            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                MessageBox.Show("Username dan password wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Try
                Dim builder As New MySqlConnectionStringBuilder With {
                .Server = "localhost",
                .Database = "toko_roti_roti",
                .UserID = "root",
                .Password = "",
                .ConnectionTimeout = 6,
                .CharacterSet = "utf8mb4"
}
                Using connection As New MySqlConnection(builder.ConnectionString)
                    connection.Open()
                    Using command As New MySqlCommand("SELECT 1", connection)
                        command.ExecuteScalar()
                    End Using
                End Using
                AppSession.ConnectionString = builder.ConnectionString
                AppSession.Username = username
                txtPassword.Clear()
                Dim dashboard As New FrmDashboard()
                AddHandler dashboard.FormClosed, Sub(sender2, e2)
                                                     If Not IsDisposed Then
                                                         AppSession.Clear()
                                                         Show()
                                                         txtPassword.Clear()
                                                         txtUsername.Focus()
                                                     End If
                                                 End Sub
                Hide()
                dashboard.Show()
            Catch ex As MySqlException
                MessageBox.Show("Tidak dapat login ke MySQL. Periksa server, nama database, username, password, dan hak akses." & Environment.NewLine & Environment.NewLine & ex.Message, "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                UiHelpers.ShowError(ex, "Login gagal")
            End Try
        End Sub

        Private Sub btnKeluar_Click(sender As Object, e As EventArgs)
            Application.Exit()
        End Sub

        Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub lblInfoLogin_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        End Sub
    End Class
End Namespace
