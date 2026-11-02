Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmLogin
        Inherits System.Windows.Forms.Form

        Private components As IContainer

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
            MyBase.Dispose(disposing)
        End Sub

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            pnlLogin = New Panel()
            tlpLogin = New TableLayoutPanel()
            lblJudul = New Label()
            lblUsername = New Label()
            txtUsername = New TextBox()
            lblPassword = New Label()
            txtPassword = New TextBox()
            btnLogin = New Button()
            tlpMain = New TableLayoutPanel()
            pnlLogin.SuspendLayout()
            tlpLogin.SuspendLayout()
            tlpMain.SuspendLayout()
            SuspendLayout()
            ' 
            ' pnlLogin
            ' 
            pnlLogin.BackColor = Color.White
            pnlLogin.BorderStyle = BorderStyle.FixedSingle
            pnlLogin.Controls.Add(tlpLogin)
            pnlLogin.Dock = DockStyle.Fill
            pnlLogin.Location = New Point(57, 53)
            pnlLogin.Name = "pnlLogin"
            pnlLogin.Size = New Size(426, 394)
            pnlLogin.TabIndex = 0
            ' 
            ' tlpLogin
            ' 
            tlpLogin.AutoSize = True
            tlpLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
            tlpLogin.ColumnCount = 3
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            tlpLogin.Controls.Add(lblJudul, 0, 1)
            tlpLogin.Controls.Add(lblUsername, 1, 3)
            tlpLogin.Controls.Add(txtUsername, 1, 4)
            tlpLogin.Controls.Add(lblPassword, 1, 6)
            tlpLogin.Controls.Add(txtPassword, 1, 7)
            tlpLogin.Controls.Add(btnLogin, 1, 9)
            tlpLogin.Dock = DockStyle.Fill
            tlpLogin.Location = New Point(0, 0)
            tlpLogin.Name = "tlpLogin"
            tlpLogin.RowCount = 11
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 25F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 45F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 60F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 24F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 22F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 24F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 28F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 42F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
            tlpLogin.Size = New Size(424, 392)
            tlpLogin.TabIndex = 1
            ' 
            ' lblJudul
            ' 
            tlpLogin.SetColumnSpan(lblJudul, 3)
            lblJudul.Dock = DockStyle.Fill
            lblJudul.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
            lblJudul.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudul.Location = New Point(3, 25)
            lblJudul.Name = "lblJudul"
            lblJudul.Size = New Size(418, 45)
            lblJudul.TabIndex = 1
            lblJudul.Text = "Sistem Kasir Toko Roti"
            lblJudul.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' lblUsername
            ' 
            lblUsername.Dock = DockStyle.Fill
            lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            lblUsername.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblUsername.Location = New Point(45, 130)
            lblUsername.Name = "lblUsername"
            lblUsername.Size = New Size(333, 24)
            lblUsername.TabIndex = 3
            lblUsername.Text = "Username"
            lblUsername.TextAlign = ContentAlignment.BottomLeft
            ' 
            ' txtUsername
            ' 
            txtUsername.Dock = DockStyle.Fill
            txtUsername.Location = New Point(45, 157)
            txtUsername.Name = "txtUsername"
            txtUsername.Size = New Size(333, 27)
            txtUsername.TabIndex = 4
            ' 
            ' lblPassword
            ' 
            lblPassword.Dock = DockStyle.Fill
            lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            lblPassword.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPassword.Location = New Point(45, 203)
            lblPassword.Name = "lblPassword"
            lblPassword.Size = New Size(333, 24)
            lblPassword.TabIndex = 5
            lblPassword.Text = "Password"
            lblPassword.TextAlign = ContentAlignment.BottomLeft
            ' 
            ' txtPassword
            ' 
            txtPassword.Dock = DockStyle.Fill
            txtPassword.Location = New Point(45, 230)
            txtPassword.Name = "txtPassword"
            txtPassword.Size = New Size(333, 27)
            txtPassword.TabIndex = 6
            txtPassword.UseSystemPasswordChar = True
            ' 
            ' btnLogin
            ' 
            btnLogin.AutoSize = True
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
            btnLogin.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnLogin.Cursor = Cursors.Hand
            btnLogin.Dock = DockStyle.Fill
            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnLogin.ForeColor = Color.White
            btnLogin.Location = New Point(45, 285)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Size(333, 36)
            btnLogin.TabIndex = 7
            btnLogin.Text = "Masuk"
            btnLogin.UseVisualStyleBackColor = False
            ' 
            ' tlpMain
            ' 
            tlpMain.ColumnCount = 3
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            tlpMain.Controls.Add(pnlLogin, 1, 1)
            tlpMain.Dock = DockStyle.Fill
            tlpMain.Location = New Point(0, 0)
            tlpMain.Name = "tlpMain"
            tlpMain.RowCount = 3
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
            tlpMain.Size = New Size(540, 500)
            tlpMain.TabIndex = 0
            ' 
            ' FrmLogin
            ' 
            AcceptButton = btnLogin
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(540, 500)
            Controls.Add(tlpMain)
            Font = New Font("Segoe UI", 9F)
            MinimumSize = New Size(540, 500)
            Name = "FrmLogin"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Login - Sistem Kasir Toko Roti"
            pnlLogin.ResumeLayout(False)
            pnlLogin.PerformLayout()
            tlpLogin.ResumeLayout(False)
            tlpLogin.PerformLayout()
            tlpMain.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Friend WithEvents pnlLogin As System.Windows.Forms.Panel
        Friend WithEvents lblJudul As System.Windows.Forms.Label
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnLogin As System.Windows.Forms.Button
        Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents tlpLogin As System.Windows.Forms.TableLayoutPanel
    End Class
End Namespace