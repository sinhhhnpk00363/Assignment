<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.lsvtthd = New System.Windows.Forms.ListView()
        Me.lsvkhachhang = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtngay = New System.Windows.Forms.TextBox()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lsvtthd
        '
        Me.lsvtthd.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvtthd.FullRowSelect = True
        Me.lsvtthd.GridLines = True
        Me.lsvtthd.Location = New System.Drawing.Point(10, 24)
        Me.lsvtthd.Name = "lsvtthd"
        Me.lsvtthd.Size = New System.Drawing.Size(646, 196)
        Me.lsvtthd.TabIndex = 0
        Me.lsvtthd.UseCompatibleStateImageBehavior = False
        Me.lsvtthd.View = System.Windows.Forms.View.Details
        '
        'lsvkhachhang
        '
        Me.lsvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lsvkhachhang.FullRowSelect = True
        Me.lsvkhachhang.GridLines = True
        Me.lsvkhachhang.Location = New System.Drawing.Point(16, 19)
        Me.lsvkhachhang.Name = "lsvkhachhang"
        Me.lsvkhachhang.Size = New System.Drawing.Size(340, 168)
        Me.lsvkhachhang.TabIndex = 1
        Me.lsvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvkhachhang.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lsvkhachhang)
        Me.GroupBox1.Location = New System.Drawing.Point(302, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 193)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Khách Hàng"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lsvtthd)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 226)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Hóa Đơn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ngày"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mô Tả"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(109, 9)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.ReadOnly = True
        Me.txtmahd.Size = New System.Drawing.Size(174, 20)
        Me.txtmahd.TabIndex = 5
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(109, 32)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(174, 20)
        Me.txtmakh.TabIndex = 5
        '
        'txtngay
        '
        Me.txtngay.Location = New System.Drawing.Point(109, 55)
        Me.txtngay.Name = "txtngay"
        Me.txtngay.Size = New System.Drawing.Size(174, 20)
        Me.txtngay.TabIndex = 5
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(109, 77)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(174, 62)
        Me.txtmota.TabIndex = 5
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(22, 160)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 6
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(199, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã Khách Hàng"
        Me.ColumnHeader1.Width = 112
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Khách Hàng"
        Me.ColumnHeader2.Width = 223
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mã Hóa Đơn"
        Me.ColumnHeader3.Width = 155
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mã Khách Hàng"
        Me.ColumnHeader4.Width = 155
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ngày"
        Me.ColumnHeader5.Width = 106
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Mô Tả"
        Me.ColumnHeader6.Width = 222
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 449)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtngay)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmhoadon"
        Me.Text = "HÓA ĐƠN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsvtthd As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtngay As System.Windows.Forms.TextBox
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
