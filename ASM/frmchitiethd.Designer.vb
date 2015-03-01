<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchitiethd
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lsvcthd = New System.Windows.Forms.ListView()
        Me.lsvhoadon = New System.Windows.Forms.ListView()
        Me.lsvsanpham = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmacthd = New System.Windows.Forms.TextBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvcthd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 472)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chi Tiết Hóa Đơn"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsvhoadon)
        Me.GroupBox2.Location = New System.Drawing.Point(561, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 156)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Khách Hàng"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lsvsanpham)
        Me.GroupBox3.Location = New System.Drawing.Point(561, 174)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(385, 156)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sản Phẩm"
        '
        'lsvcthd
        '
        Me.lsvcthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvcthd.FullRowSelect = True
        Me.lsvcthd.GridLines = True
        Me.lsvcthd.Location = New System.Drawing.Point(7, 20)
        Me.lsvcthd.Name = "lsvcthd"
        Me.lsvcthd.Size = New System.Drawing.Size(530, 446)
        Me.lsvcthd.TabIndex = 0
        Me.lsvcthd.UseCompatibleStateImageBehavior = False
        Me.lsvcthd.View = System.Windows.Forms.View.Details
        '
        'lsvhoadon
        '
        Me.lsvhoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvhoadon.FullRowSelect = True
        Me.lsvhoadon.GridLines = True
        Me.lsvhoadon.Location = New System.Drawing.Point(7, 20)
        Me.lsvhoadon.Name = "lsvhoadon"
        Me.lsvhoadon.Size = New System.Drawing.Size(372, 130)
        Me.lsvhoadon.TabIndex = 0
        Me.lsvhoadon.UseCompatibleStateImageBehavior = False
        Me.lsvhoadon.View = System.Windows.Forms.View.Details
        '
        'lsvsanpham
        '
        Me.lsvsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lsvsanpham.FullRowSelect = True
        Me.lsvsanpham.GridLines = True
        Me.lsvsanpham.Location = New System.Drawing.Point(7, 20)
        Me.lsvsanpham.Name = "lsvsanpham"
        Me.lsvsanpham.Size = New System.Drawing.Size(372, 130)
        Me.lsvsanpham.TabIndex = 0
        Me.lsvsanpham.UseCompatibleStateImageBehavior = False
        Me.lsvsanpham.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã CTHD"
        Me.ColumnHeader1.Width = 98
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Hóa Đơn"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã Sản Phẩm"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Số Lượng"
        Me.ColumnHeader4.Width = 107
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Đơn Giá"
        Me.ColumnHeader5.Width = 115
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mã Hóa Đơn"
        Me.ColumnHeader6.Width = 115
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Khách Hàng"
        Me.ColumnHeader7.Width = 252
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Mã Sản Phẩm"
        Me.ColumnHeader8.Width = 152
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sản Phẩm"
        Me.ColumnHeader9.Width = 215
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(568, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sản Phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(568, 431)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Số Lượng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(568, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Đơn Giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Mã CTHD"
        '
        'txtmacthd
        '
        Me.txtmacthd.Location = New System.Drawing.Point(651, 341)
        Me.txtmacthd.Name = "txtmacthd"
        Me.txtmacthd.Size = New System.Drawing.Size(171, 20)
        Me.txtmacthd.TabIndex = 2
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(651, 374)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(171, 20)
        Me.txtmahoadon.TabIndex = 2
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(651, 401)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(171, 20)
        Me.txtmasp.TabIndex = 2
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(651, 428)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(171, 20)
        Me.txtsoluong.TabIndex = 2
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(651, 457)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(171, 20)
        Me.txtdongia.TabIndex = 2
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(849, 353)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(91, 28)
        Me.btnthem.TabIndex = 3
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(849, 398)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(91, 28)
        Me.btnsua.TabIndex = 3
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(849, 440)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(91, 28)
        Me.btnxoa.TabIndex = 3
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'frmchitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 496)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.txtmahoadon)
        Me.Controls.Add(Me.txtmacthd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmchitiethd"
        Me.Text = "Chi Tiết Hóa Đơn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvcthd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvhoadon As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvsanpham As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmacthd As System.Windows.Forms.TextBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
End Class
