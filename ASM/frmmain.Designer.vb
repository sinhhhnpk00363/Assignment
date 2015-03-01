<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SẢNPHẨMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOẠISẢNPHẨMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THOÁTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HÓAĐƠNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KHÁCHHÀNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HÓAĐƠNToolStripMenuItem, Me.CHITIẾTHÓAĐƠNToolStripMenuItem, Me.SẢNPHẨMToolStripMenuItem, Me.LOẠISẢNPHẨMToolStripMenuItem, Me.KHÁCHHÀNGToolStripMenuItem, Me.THOÁTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(623, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SẢNPHẨMToolStripMenuItem
        '
        Me.SẢNPHẨMToolStripMenuItem.Name = "SẢNPHẨMToolStripMenuItem"
        Me.SẢNPHẨMToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.SẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM"
        '
        'LOẠISẢNPHẨMToolStripMenuItem
        '
        Me.LOẠISẢNPHẨMToolStripMenuItem.Name = "LOẠISẢNPHẨMToolStripMenuItem"
        Me.LOẠISẢNPHẨMToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.LOẠISẢNPHẨMToolStripMenuItem.Text = "LOẠI SẢN PHẨM"
        '
        'THOÁTToolStripMenuItem
        '
        Me.THOÁTToolStripMenuItem.Name = "THOÁTToolStripMenuItem"
        Me.THOÁTToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.THOÁTToolStripMenuItem.Text = "THOÁT"
        '
        'HÓAĐƠNToolStripMenuItem
        '
        Me.HÓAĐƠNToolStripMenuItem.Name = "HÓAĐƠNToolStripMenuItem"
        Me.HÓAĐƠNToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.HÓAĐƠNToolStripMenuItem.Text = "HÓA ĐƠN"
        '
        'CHITIẾTHÓAĐƠNToolStripMenuItem
        '
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Name = "CHITIẾTHÓAĐƠNToolStripMenuItem"
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Size = New System.Drawing.Size(123, 20)
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Text = "CHI TIẾT HÓA ĐƠN"
        '
        'KHÁCHHÀNGToolStripMenuItem
        '
        Me.KHÁCHHÀNGToolStripMenuItem.Name = "KHÁCHHÀNGToolStripMenuItem"
        Me.KHÁCHHÀNGToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.KHÁCHHÀNGToolStripMenuItem.Text = "KHÁCH HÀNG"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 289)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmain"
        Me.Text = "QUẢN LÝ BÁN HÀNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SẢNPHẨMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOẠISẢNPHẨMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THOÁTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HÓAĐƠNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHITIẾTHÓAĐƠNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KHÁCHHÀNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
