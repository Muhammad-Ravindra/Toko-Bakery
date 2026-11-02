Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace TokoRotiVB
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmNota
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
            lblJudulNota = New Label()
            lblNoNota = New Label()
            txtNoNota = New TextBox()
            btnCari = New Button()
            btnTampilkanSemua = New Button()
            lblInfoNota = New Label()
            dgvNota = New DataGridView()
            CType(dgvNota, ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' lblJudulNota
            ' 
            lblJudulNota.Font = New Font("Segoe UI", 21F, FontStyle.Bold)
            lblJudulNota.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            lblJudulNota.Location = New Point(28, 18)
            lblJudulNota.Name = "lblJudulNota"
            lblJudulNota.Size = New Size(700, 42)
            lblJudulNota.TabIndex = 0
            lblJudulNota.Text = "Nota Transaksi"
            lblJudulNota.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' lblNoNota
            ' 
            lblNoNota.Font = New Font("Segoe UI", 9F)
            lblNoNota.ForeColor = Color.FromArgb(CByte(45), CByte(55), CByte(65))
            lblNoNota.Location = New Point(30, 78)
            lblNoNota.Name = "lblNoNota"
            lblNoNota.Size = New Size(170, 22)
            lblNoNota.TabIndex = 1
            lblNoNota.Text = "Nomor Nota / ID Pesanan"
            lblNoNota.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' txtNoNota
            ' 
            txtNoNota.Location = New Point(30, 102)
            txtNoNota.Name = "txtNoNota"
            txtNoNota.Size = New Size(220, 27)
            txtNoNota.TabIndex = 2
            ' 
            ' btnCari
            ' 
            btnCari.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            btnCari.Cursor = Cursors.Hand
            btnCari.FlatStyle = FlatStyle.Flat
            btnCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            btnCari.ForeColor = Color.White
            btnCari.Location = New Point(270, 98)
            btnCari.Name = "btnCari"
            btnCari.Size = New Size(125, 40)
            btnCari.TabIndex = 3
            btnCari.Text = "Cari Nota"
            btnCari.UseVisualStyleBackColor = False
            ' 
            ' btnTampilkanSemua
            ' 
            btnTampilkanSemua.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(246))
            btnTampilkanSemua.Cursor = Cursors.Hand
            btnTampilkanSemua.FlatStyle = FlatStyle.Flat
            btnTampilkanSemua.ForeColor = Color.FromArgb(CByte(31), CByte(47), CByte(70))
            btnTampilkanSemua.Location = New Point(405, 98)
            btnTampilkanSemua.Name = "btnTampilkanSemua"
            btnTampilkanSemua.Size = New Size(160, 40)
            btnTampilkanSemua.TabIndex = 4
            btnTampilkanSemua.Text = "Tampilkan Semua"
            btnTampilkanSemua.UseVisualStyleBackColor = False
            ' 
            ' lblInfoNota
            ' 
            lblInfoNota.Font = New Font("Segoe UI", 9F)
            lblInfoNota.ForeColor = Color.FromArgb(CByte(104), CByte(115), CByte(127))
            lblInfoNota.Location = New Point(590, 103)
            lblInfoNota.Name = "lblInfoNota"
            lblInfoNota.Size = New Size(540, 30)
            lblInfoNota.TabIndex = 5
            lblInfoNota.Text = "Nota menggabungkan data pesanan, pelanggan, detail pesanan, dan produk."
            lblInfoNota.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' dgvNota
            ' 
            dgvNota.AllowUserToAddRows = False
            dgvNota.AllowUserToDeleteRows = False
            dgvNota.AllowUserToResizeRows = False
            dgvNota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvNota.BackgroundColor = Color.White
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(43), CByte(94), CByte(142))
            DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = Color.White
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
            dgvNota.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            dgvNota.ColumnHeadersHeight = 29
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = SystemColors.Window
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
            DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(214), CByte(231), CByte(247))
            DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(40), CByte(49), CByte(59))
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
            dgvNota.DefaultCellStyle = DataGridViewCellStyle2
            dgvNota.EnableHeadersVisualStyles = False
            dgvNota.Location = New Point(30, 165)
            dgvNota.MultiSelect = False
            dgvNota.Name = "dgvNota"
            dgvNota.ReadOnly = True
            dgvNota.RowHeadersVisible = False
            dgvNota.RowHeadersWidth = 51
            dgvNota.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvNota.Size = New Size(1100, 500)
            dgvNota.TabIndex = 6
            ' 
            ' FrmNota
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
            ClientSize = New Size(1200, 760)
            Controls.Add(lblJudulNota)
            Controls.Add(lblInfoNota)
            Controls.Add(lblNoNota)
            Controls.Add(txtNoNota)
            Controls.Add(btnCari)
            Controls.Add(btnTampilkanSemua)
            Controls.Add(dgvNota)
            Font = New Font("Segoe UI", 9F)
            Name = "FrmNota"
            StartPosition = FormStartPosition.CenterScreen
            Text = "Nota Transaksi - Sistem Kasir Toko Roti"
            CType(dgvNota, ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        Friend WithEvents lblJudulNota As System.Windows.Forms.Label
        Friend WithEvents lblNoNota As System.Windows.Forms.Label
        Friend WithEvents txtNoNota As System.Windows.Forms.TextBox
        Friend WithEvents btnCari As System.Windows.Forms.Button
        Friend WithEvents btnTampilkanSemua As System.Windows.Forms.Button
        Friend WithEvents lblInfoNota As System.Windows.Forms.Label
        Friend WithEvents dgvNota As System.Windows.Forms.DataGridView
    End Class
End Namespace
