<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloaisanpham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvloaisanpham = New System.Windows.Forms.ListView()
        Me.clmaloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txttenloaisanpham = New System.Windows.Forms.TextBox()
        Me.lblmota = New System.Windows.Forms.Label()
        Me.lbltensanpham = New System.Windows.Forms.Label()
        Me.lblmaloaisanpham = New System.Windows.Forms.Label()
        Me.txtmaloaisanpham = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvloaisanpham)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 233)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOẠI SẢN PHẨM"
        '
        'lsvloaisanpham
        '
        Me.lsvloaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmaloai, Me.clenloai, Me.clmota})
        Me.lsvloaisanpham.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvloaisanpham.FullRowSelect = True
        Me.lsvloaisanpham.GridLines = True
        Me.lsvloaisanpham.Location = New System.Drawing.Point(6, 21)
        Me.lsvloaisanpham.Name = "lsvloaisanpham"
        Me.lsvloaisanpham.Size = New System.Drawing.Size(566, 198)
        Me.lsvloaisanpham.TabIndex = 0
        Me.lsvloaisanpham.UseCompatibleStateImageBehavior = False
        Me.lsvloaisanpham.View = System.Windows.Forms.View.Details
        '
        'clmaloai
        '
        Me.clmaloai.Text = "Mã Loại"
        Me.clmaloai.Width = 113
        '
        'clenloai
        '
        Me.clenloai.Text = "Tên Loại"
        Me.clenloai.Width = 192
        '
        'clmota
        '
        Me.clmota.Text = "Mô Tả"
        Me.clmota.Width = 256
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtmaloaisanpham)
        Me.GroupBox2.Controls.Add(Me.lblmaloaisanpham)
        Me.GroupBox2.Controls.Add(Me.btnsua)
        Me.GroupBox2.Controls.Add(Me.btnxoa)
        Me.GroupBox2.Controls.Add(Me.btnthem)
        Me.GroupBox2.Controls.Add(Me.txtmota)
        Me.GroupBox2.Controls.Add(Me.txttenloaisanpham)
        Me.GroupBox2.Controls.Add(Me.lblmota)
        Me.GroupBox2.Controls.Add(Me.lbltensanpham)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(396, 116)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 6
        Me.btnsua.Text = "SỬA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(396, 74)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 5
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(396, 32)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 4
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmota.Location = New System.Drawing.Point(151, 88)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(175, 77)
        Me.txtmota.TabIndex = 3
        '
        'txttenloaisanpham
        '
        Me.txttenloaisanpham.Location = New System.Drawing.Point(151, 60)
        Me.txttenloaisanpham.Name = "txttenloaisanpham"
        Me.txttenloaisanpham.Size = New System.Drawing.Size(175, 22)
        Me.txttenloaisanpham.TabIndex = 2
        '
        'lblmota
        '
        Me.lblmota.AutoSize = True
        Me.lblmota.Location = New System.Drawing.Point(83, 90)
        Me.lblmota.Name = "lblmota"
        Me.lblmota.Size = New System.Drawing.Size(41, 15)
        Me.lblmota.TabIndex = 1
        Me.lblmota.Text = "Mô Tả"
        '
        'lbltensanpham
        '
        Me.lbltensanpham.AutoSize = True
        Me.lbltensanpham.Location = New System.Drawing.Point(38, 60)
        Me.lbltensanpham.Name = "lbltensanpham"
        Me.lbltensanpham.Size = New System.Drawing.Size(86, 15)
        Me.lbltensanpham.TabIndex = 0
        Me.lbltensanpham.Text = "Tên Sản Phẩm"
        '
        'lblmaloaisanpham
        '
        Me.lblmaloaisanpham.AutoSize = True
        Me.lblmaloaisanpham.Location = New System.Drawing.Point(15, 32)
        Me.lblmaloaisanpham.Name = "lblmaloaisanpham"
        Me.lblmaloaisanpham.Size = New System.Drawing.Size(109, 15)
        Me.lblmaloaisanpham.TabIndex = 7
        Me.lblmaloaisanpham.Text = "Mã Loại Sản Phẩm"
        '
        'txtmaloaisanpham
        '
        Me.txtmaloaisanpham.Location = New System.Drawing.Point(151, 32)
        Me.txtmaloaisanpham.Name = "txtmaloaisanpham"
        Me.txtmaloaisanpham.ReadOnly = True
        Me.txtmaloaisanpham.Size = New System.Drawing.Size(175, 22)
        Me.txtmaloaisanpham.TabIndex = 8
        '
        'frmloaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 435)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmloaisanpham"
        Me.Text = "LOẠI SẢN PHẨM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvloaisanpham As System.Windows.Forms.ListView
    Friend WithEvents clmaloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txttenloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblmota As System.Windows.Forms.Label
    Friend WithEvents lbltensanpham As System.Windows.Forms.Label
    Friend WithEvents txtmaloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblmaloaisanpham As System.Windows.Forms.Label

End Class
