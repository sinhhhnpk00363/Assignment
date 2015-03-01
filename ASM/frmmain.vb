Public Class frmmain

    Private Sub SẢNPHẨMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SẢNPHẨMToolStripMenuItem.Click
        Dim sanpham = New frmsanpham()
        sanpham.MdiParent = Me
        sanpham.Show()


    End Sub

    Private Sub LOẠISẢNPHẨMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOẠISẢNPHẨMToolStripMenuItem.Click
        Dim loaisanpham = New frmloaisanpham()
        loaisanpham.MdiParent = Me
        loaisanpham.Show()
    End Sub

    Private Sub THOÁTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THOÁTToolStripMenuItem.Click
        If MsgBox("Bạn Chắc Chắn Sẽ Thoát Chương Trình ?", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub HÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HÓAĐƠNToolStripMenuItem.Click
        Dim loaisanpham = New frmhoadon()
        loaisanpham.MdiParent = Me
        loaisanpham.Show()
    End Sub

    Private Sub KHÁCHHÀNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KHÁCHHÀNGToolStripMenuItem.Click
        Dim loaisanpham = New frmkhachhang()
        loaisanpham.MdiParent = Me
        loaisanpham.Show()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CHITIẾTHÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHITIẾTHÓAĐƠNToolStripMenuItem.Click
        Dim loaisanpham = New frmchitiethd()
        loaisanpham.MdiParent = Me
        loaisanpham.Show()
    End Sub
End Class
