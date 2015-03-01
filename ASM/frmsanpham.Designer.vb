<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsanpham
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtloaisanpham = New System.Windows.Forms.TextBox()
        Me.txttensanpham = New System.Windows.Forms.TextBox()
        Me.lblmota = New System.Windows.Forms.Label()
        Me.lbldongia = New System.Windows.Forms.Label()
        Me.lblloaisanpham = New System.Windows.Forms.Label()
        Me.lbltensanpham = New System.Windows.Forms.Label()
        Me.cltensanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clloaisanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cldongia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmota = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lsvloaisanpham = New System.Windows.Forms.ListView()
        Me.clmaloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cltenloai = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmotaloaisp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lsvsanpham = New System.Windows.Forms.ListView()
        Me.clmasanpham = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnsua)
        Me.GroupBox3.Controls.Add(Me.btnxoa)
        Me.GroupBox3.Controls.Add(Me.btnthem)
        Me.GroupBox3.Controls.Add(Me.txtmota)
        Me.GroupBox3.Controls.Add(Me.txtdongia)
        Me.GroupBox3.Controls.Add(Me.txtloaisanpham)
        Me.GroupBox3.Controls.Add(Me.txtmasanpham)
        Me.GroupBox3.Controls.Add(Me.txttensanpham)
        Me.GroupBox3.Controls.Add(Me.lblmota)
        Me.GroupBox3.Controls.Add(Me.lbldongia)
        Me.GroupBox3.Controls.Add(Me.lblloaisanpham)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lbltensanpham)
        Me.GroupBox3.Location = New System.Drawing.Point(479, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 238)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'btnsua
        '
        Me.btnsua.ForeColor = System.Drawing.Color.Black
        Me.btnsua.Location = New System.Drawing.Point(236, 205)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(65, 27)
        Me.btnsua.TabIndex = 10
        Me.btnsua.Text = "SỬA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.ForeColor = System.Drawing.Color.Black
        Me.btnxoa.Location = New System.Drawing.Point(151, 205)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(65, 27)
        Me.btnxoa.TabIndex = 9
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.ForeColor = System.Drawing.Color.Black
        Me.btnthem.Location = New System.Drawing.Point(66, 205)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(65, 27)
        Me.btnthem.TabIndex = 8
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'txtmota
        '
        Me.txtmota.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmota.Location = New System.Drawing.Point(128, 140)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(222, 49)
        Me.txtmota.TabIndex = 7
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(128, 112)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(222, 21)
        Me.txtdongia.TabIndex = 6
        '
        'txtloaisanpham
        '
        Me.txtloaisanpham.Location = New System.Drawing.Point(128, 78)
        Me.txtloaisanpham.Name = "txtloaisanpham"
        Me.txtloaisanpham.Size = New System.Drawing.Size(222, 21)
        Me.txtloaisanpham.TabIndex = 5
        '
        'txttensanpham
        '
        Me.txttensanpham.Location = New System.Drawing.Point(128, 46)
        Me.txttensanpham.Name = "txttensanpham"
        Me.txttensanpham.Size = New System.Drawing.Size(222, 21)
        Me.txttensanpham.TabIndex = 4
        '
        'lblmota
        '
        Me.lblmota.AutoSize = True
        Me.lblmota.Location = New System.Drawing.Point(23, 140)
        Me.lblmota.Name = "lblmota"
        Me.lblmota.Size = New System.Drawing.Size(41, 15)
        Me.lblmota.TabIndex = 3
        Me.lblmota.Text = "Mô Tả"
        '
        'lbldongia
        '
        Me.lbldongia.AutoSize = True
        Me.lbldongia.Location = New System.Drawing.Point(23, 112)
        Me.lbldongia.Name = "lbldongia"
        Me.lbldongia.Size = New System.Drawing.Size(52, 15)
        Me.lbldongia.TabIndex = 2
        Me.lbldongia.Text = "Đơn Giá"
        '
        'lblloaisanpham
        '
        Me.lblloaisanpham.AutoSize = True
        Me.lblloaisanpham.Location = New System.Drawing.Point(23, 74)
        Me.lblloaisanpham.Name = "lblloaisanpham"
        Me.lblloaisanpham.Size = New System.Drawing.Size(87, 15)
        Me.lblloaisanpham.TabIndex = 1
        Me.lblloaisanpham.Text = "Loại Sản Phẩm"
        '
        'lbltensanpham
        '
        Me.lbltensanpham.AutoSize = True
        Me.lbltensanpham.Location = New System.Drawing.Point(23, 46)
        Me.lbltensanpham.Name = "lbltensanpham"
        Me.lbltensanpham.Size = New System.Drawing.Size(85, 15)
        Me.lbltensanpham.TabIndex = 0
        Me.lbltensanpham.Text = "Tên Sản Phẩm"
        '
        'cltensanpham
        '
        Me.cltensanpham.Text = "Tên Sản Phẩm"
        Me.cltensanpham.Width = 92
        '
        'clloaisanpham
        '
        Me.clloaisanpham.Text = "Loại Sản Phẩm"
        Me.clloaisanpham.Width = 93
        '
        'cldongia
        '
        Me.cldongia.Text = "Đơn Giá"
        Me.cldongia.Width = 97
        '
        'clmota
        '
        Me.clmota.Text = "Mô Tả"
        Me.clmota.Width = 72
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsvloaisanpham)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(477, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(358, 267)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOẠI SẢN PHẨM"
        '
        'lsvloaisanpham
        '
        Me.lsvloaisanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmaloai, Me.cltenloai, Me.clmotaloaisp})
        Me.lsvloaisanpham.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvloaisanpham.FullRowSelect = True
        Me.lsvloaisanpham.GridLines = True
        Me.lsvloaisanpham.Location = New System.Drawing.Point(6, 17)
        Me.lsvloaisanpham.Name = "lsvloaisanpham"
        Me.lsvloaisanpham.Size = New System.Drawing.Size(350, 238)
        Me.lsvloaisanpham.TabIndex = 0
        Me.lsvloaisanpham.UseCompatibleStateImageBehavior = False
        Me.lsvloaisanpham.View = System.Windows.Forms.View.Details
        '
        'clmaloai
        '
        Me.clmaloai.Text = "Mã Loại"
        Me.clmaloai.Width = 77
        '
        'cltenloai
        '
        Me.cltenloai.Text = "Tên Loại"
        Me.cltenloai.Width = 73
        '
        'clmotaloaisp
        '
        Me.clmotaloaisp.Text = "Mô Tả"
        Me.clmotaloaisp.Width = 193
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvsanpham)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 512)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SẢN PHẨM"
        '
        'lsvsanpham
        '
        Me.lsvsanpham.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmasanpham, Me.cltensanpham, Me.clloaisanpham, Me.cldongia, Me.clmota})
        Me.lsvsanpham.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvsanpham.FullRowSelect = True
        Me.lsvsanpham.GridLines = True
        Me.lsvsanpham.Location = New System.Drawing.Point(6, 20)
        Me.lsvsanpham.Name = "lsvsanpham"
        Me.lsvsanpham.Size = New System.Drawing.Size(447, 481)
        Me.lsvsanpham.TabIndex = 0
        Me.lsvsanpham.UseCompatibleStateImageBehavior = False
        Me.lsvsanpham.View = System.Windows.Forms.View.Details
        '
        'clmasanpham
        '
        Me.clmasanpham.Text = "Mã Sản Phẩm"
        Me.clmasanpham.Width = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(128, 17)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.ReadOnly = True
        Me.txtmasanpham.Size = New System.Drawing.Size(222, 21)
        Me.txtmasanpham.TabIndex = 4
        '
        'frmsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 524)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmsanpham"
        Me.Text = "HÀNG HÓA"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents txttensanpham As System.Windows.Forms.TextBox
    Friend WithEvents lblmota As System.Windows.Forms.Label
    Friend WithEvents lbldongia As System.Windows.Forms.Label
    Friend WithEvents lblloaisanpham As System.Windows.Forms.Label
    Friend WithEvents lbltensanpham As System.Windows.Forms.Label
    Friend WithEvents cltensanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents clloaisanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents cldongia As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmota As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvloaisanpham As System.Windows.Forms.ListView
    Friend WithEvents clmaloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents cltenloai As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmotaloaisp As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lsvsanpham As System.Windows.Forms.ListView
    Friend WithEvents clmasanpham As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtmasanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
