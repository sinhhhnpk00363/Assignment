Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmkhachhang
    Dim ketnoi As New SqlConnection("workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=sinhhn;pwd=abcd1234;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang")
    Public Property Value As String
    Private Sub frm_BanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieukhachhang()

    End Sub
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub loaddulieukhachhang()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from KhachHang", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangkhachhang As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangkhachhang)
        ketnoi.Close()
        lsvkhachhang.Items.Clear()

        For Each cot As DataRow In dulieubangkhachhang.Rows
            lsvkhachhang.Items.Add(cot("MaKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("TenKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("Diachi").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("SDT").ToString())
            i += 1
        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try


            Dim tenkh As String = txttenkh.Text
            Dim sdt As String = txtsdt.Text
            Dim diachi As String = txtdiachi.Text


            Dim truyvan1 As String = "insert into KhachHang (TenKH,Diachi,SDT) Values(N'" + tenkh + "',N'" + sdt + "',N'" + diachi + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieukhachhang()

            txttenkh.Text = ""
            txtsdt.Text = ""
            txtdiachi.Text = ""


        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            Dim makh As String = txtmakh.Text
            Dim tenkh As String = txttenkh.Text
            Dim sdt As String = txtsdt.Text
            Dim diachi As String = txtdiachi.Text


            ketnoi.Open()
            Dim sualsp As New SqlCommand("update KhachHang set TenKH = N'" + tenkh + "', SDT = '" + diachi + "', Diachi = '" + sdt + "' where MaKH = '" + makh + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieukhachhang()
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub lsvkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvkhachhang.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvkhachhang.SelectedItems
            txtmakh.Text = dsachsp.SubItems(0).Text
            txttenkh.Text = dsachsp.SubItems(1).Text
            txtsdt.Text = dsachsp.SubItems(2).Text
            txtdiachi.Text = dsachsp.SubItems(3).Text

        Next
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try

            Dim makh As String = txtmakh.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM KhachHang WHERE MaKH = '" + makh + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieukhachhang()

        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class