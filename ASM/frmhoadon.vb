Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmhoadon
    Dim ketnoi As New SqlConnection("workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=sinhhn;pwd=abcd1234;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang")
    Public Property Value As String
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub frmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieukhachhang()
        loaddulieuhoadon()
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
            
            i += 1
        Next
    End Sub
    Private Sub loaddulieuhoadon()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from HoaDon left join KhachHang on HoaDon.MaKH = KhachHang.MaKH", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubanghoadon As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanghoadon)
        ketnoi.Close()
        lsvtthd.Items.Clear()

        For Each cot As DataRow In dulieubanghoadon.Rows
            lsvtthd.Items.Add(cot("MaHD").ToString())
            lsvtthd.Items(i).SubItems.Add(cot("MaKH").ToString())
            lsvtthd.Items(i).SubItems.Add(cot("Ngaythang").ToString())
            lsvtthd.Items(i).SubItems.Add(cot("Mota").ToString())
            i += 1
        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try


            Dim mahoadon As String = txtmahd.Text
            Dim makh As String = txtmakh.Text
            Dim ngaylap As String = txtngay.Text
            Dim mota As String = txtmota.Text

            Dim truyvan1 As String = "insert into HOADON (MaKH,Ngaythang,Mota) Values(N'" + makh + "',N'" + ngaylap + "',N'" + mota + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuhoadon()

            txtmakh.Text = ""
            txtngay.Text = ""
            txtmota.Text = ""


        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub lsvtthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvtthd.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvtthd.SelectedItems
            txtmahd.Text = dsachsp.SubItems(0).Text
            txtmakh.Text = dsachsp.SubItems(1).Text
            txtngay.Text = dsachsp.SubItems(2).Text
            txtmota.Text = dsachsp.SubItems(3).Text

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            Dim mahd As String = txtmahd.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM HoaDon WHERE MaHD = '" + mahd + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuhoadon()
            txtmahd.Text = ""
            txtmakh.Text = ""
            txtngay.Text = ""
            txtmota.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim mahoadon As String = txtmahd.Text
            Dim makh As String = txtmakh.Text
            Dim ngaylap As String = txtngay.Text
            Dim mota As String = txtmota.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update HoaDon set MaKH = N'" + makh + "', Ngaythang = '" + ngaylap + "', Mota = N'" + mota + "' where MaHD = '" + mahoadon + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuhoadon()
            txtmahd.Text = ""
            txtmakh.Text = ""
            txtngay.Text = ""
            txtmota.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class