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
            chkLoginOwner = New CheckBox()
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
            pnlLogin.Location = New Point(71, 66)
            pnlLogin.Margin = New Padding(4)
            pnlLogin.Name = "pnlLogin"
            pnlLogin.Size = New Size(532, 492)
            pnlLogin.TabIndex = 0
            ' 
            ' tlpLogin
            ' 
            tlpLogin.AutoSize = True
            tlpLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
            tlpLogin.ColumnCount = 3
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.0F))
            tlpLogin.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
            tlpLogin.Controls.Add(lblJudul, 0, 1)
            tlpLogin.Controls.Add(lblUsername, 1, 3)
            tlpLogin.Controls.Add(txtUsername, 1, 4)
            tlpLogin.Controls.Add(lblPassword, 1, 6)
            tlpLogin.Controls.Add(txtPassword, 1, 7)
            tlpLogin.Controls.Add(chkLoginOwner, 1, 8)
            tlpLogin.Controls.Add(btnLogin, 1, 9)
            tlpLogin.Dock = DockStyle.Fill
            tlpLogin.Location = New Point(0, 0)
            tlpLogin.Margin = New Padding(4)
            tlpLogin.Name = "tlpLogin"
            tlpLogin.RowCount = 11
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 31.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 56.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 75.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 34.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 28.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 34.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Absolute, 52.0F))
            tlpLogin.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            tlpLogin.Size = New Size(530, 490)
            tlpLogin.TabIndex = 1
            ' 
            ' lblJudul
            ' 
            tlpLogin.SetColumnSpan(lblJudul, 3)
            lblJudul.Dock = DockStyle.Fill
            lblJudul.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
            lblJudul.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudul.Location = New Point(4, 31)
            lblJudul.Margin = New Padding(4, 0, 4, 0)
            lblJudul.Name = "lblJudul"
            lblJudul.Size = New Size(522, 56)
            lblJudul.TabIndex = 1
            lblJudul.Text = "Sistem Kasir Toko Roti"
            lblJudul.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' lblUsername
            ' 
            lblUsername.Dock = DockStyle.Fill
            lblUsername.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblUsername.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblUsername.Location = New Point(57, 162)
            lblUsername.Margin = New Padding(4, 0, 4, 0)
            lblUsername.Name = "lblUsername"
            lblUsername.Size = New Size(416, 30)
            lblUsername.TabIndex = 2
            lblUsername.Text = "Username"
            lblUsername.TextAlign = ContentAlignment.BottomLeft
            ' 
            ' txtUsername
            ' 
            txtUsername.Dock = DockStyle.Fill
            txtUsername.Location = New Point(57, 196)
            txtUsername.Margin = New Padding(4)
            txtUsername.Name = "txtUsername"
            txtUsername.Size = New Size(416, 31)
            txtUsername.TabIndex = 3
            ' 
            ' lblPassword
            ' 
            lblPassword.Dock = DockStyle.Fill
            lblPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            lblPassword.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblPassword.Location = New Point(57, 254)
            lblPassword.Margin = New Padding(4, 0, 4, 0)
            lblPassword.Name = "lblPassword"
            lblPassword.Size = New Size(416, 30)
            lblPassword.TabIndex = 4
            lblPassword.Text = "Password"
            lblPassword.TextAlign = ContentAlignment.BottomLeft
            ' 
            ' txtPassword
            ' 
            txtPassword.Dock = DockStyle.Fill
            txtPassword.Location = New Point(57, 288)
            txtPassword.Margin = New Padding(4)
            txtPassword.Name = "txtPassword"
            txtPassword.Size = New Size(416, 31)
            txtPassword.TabIndex = 5
            txtPassword.UseSystemPasswordChar = True
            ' 
            ' chkLoginOwner
            ' 
            chkLoginOwner.Dock = DockStyle.Fill
            chkLoginOwner.Font = New Font("Segoe UI", 9.0F)
            chkLoginOwner.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            chkLoginOwner.Location = New Point(57, 322)
            chkLoginOwner.Margin = New Padding(4)
            chkLoginOwner.Name = "chkLoginOwner"
            chkLoginOwner.Size = New Size(416, 27)
            chkLoginOwner.TabIndex = 6
            chkLoginOwner.Text = "Login as owner"
            chkLoginOwner.UseVisualStyleBackColor = True
            ' 
            ' btnLogin
            ' 
            btnLogin.AutoSize = True
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
            btnLogin.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnLogin.Cursor = Cursors.Hand
            btnLogin.Dock = DockStyle.Fill
            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            btnLogin.ForeColor = Color.White
            btnLogin.Location = New Point(57, 357)
            btnLogin.Margin = New Padding(4)
            btnLogin.Name = "btnLogin"
            btnLogin.Size = New Size(416, 44)
            btnLogin.TabIndex = 7
            btnLogin.Text = "Masuk"
            btnLogin.UseVisualStyleBackColor = False
            ' 
            ' tlpMain
            ' 
            tlpMain.ColumnCount = 3
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.0F))
            tlpMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
            tlpMain.Controls.Add(pnlLogin, 1, 1)
            tlpMain.Dock = DockStyle.Fill
            tlpMain.Location = New Point(0, 0)
            tlpMain.Margin = New Padding(4)
            tlpMain.Name = "tlpMain"
            tlpMain.RowCount = 3
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 80.0F))
            tlpMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
            tlpMain.Size = New Size(675, 625)
            tlpMain.TabIndex = 0
            ' 
            ' FrmLogin
            ' 
            AcceptButton = btnLogin
            AutoScaleDimensions = New SizeF(10.0F, 25.0F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(675, 625)
            Controls.Add(tlpMain)
            Font = New Font("Segoe UI", 9.0F)
            Margin = New Padding(4)
            MinimumSize = New Size(670, 611)
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
        Friend WithEvents chkLoginOwner As System.Windows.Forms.CheckBox ' <--- ADDED DECLARATION
        Friend WithEvents btnLogin As System.Windows.Forms.Button
        Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents tlpLogin As System.Windows.Forms.TableLayoutPanel
    End Class
End Namespace