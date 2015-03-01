Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmchitiethd
    Dim ketnoi As New SqlConnection("workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=sinhhn;pwd=abcd1234;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang")
    Public Property Value As String
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    
    Private Sub frmchitiethd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieuhoadon()
        laythongtinsanpham()
        loaddulieuchitiethoadon()
    End Sub
    Private Sub loaddulieuhoadon()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from HoaDon left join KhachHang on HoaDon.MaKH = KhachHang.MaKH", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubanghoadon As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanghoadon)
        ketnoi.Close()
        lsvhoadon.Items.Clear()

        For Each cot As DataRow In dulieubanghoadon.Rows
            lsvhoadon.Items.Add(cot("MaHD").ToString())
            lsvhoadon.Items(i).SubItems.Add(cot("TenKH").ToString())
            i += 1
        Next
    End Sub
    Private Sub laythongtinsanpham()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from SanPham left join LoaiSanPham on SanPham.MaLsp = LoaiSanPham.MaLsp", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        lsvsanpham.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            lsvsanpham.Items.Add(cot("MaSp").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("TenSp").ToString())
            
            i += 1
        Next
    End Sub
    Private Sub loaddulieuchitiethoadon()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from ChiTietHoaDon left join HoaDon on ChiTietHoaDon.MaHD = HoaDon.MaHD left join KhachHang on HoaDon.MaKH = KhachHang.MaKH left join SanPham on SanPham.MaSp = ChiTietHoaDon.MaSp", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        lsvcthd.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            lsvcthd.Items.Add(cot("MaCTHD").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("MaHD").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("MaSP").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("SoLuong").ToString())
            lsvcthd.Items(i).SubItems.Add(cot("DonGia").ToString())
           
            i += 1
        Next
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub lsvcthd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvcthd.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvcthd.SelectedItems
            txtmacthd.Text = dsachsp.SubItems(0).Text
            txtmahoadon.Text = dsachsp.SubItems(1).Text
            txtmasp.Text = dsachsp.SubItems(2).Text
            txtsoluong.Text = dsachsp.SubItems(3).Text
            txtdongia.Text = dsachsp.SubItems(4).Text
        Next
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try

            Dim macthd As String = txtmacthd.Text
            Dim mahd As String = txtmahoadon.Text
            Dim masp As String = txtmasp.Text
            Dim soluong As String = txtsoluong.Text
            Dim dongia As String = txtdongia.Text

            Dim truyvan1 As String = "insert into ChiTietHoaDon (MaHD,Masp,Soluong,DonGia) Values(N'" + mahd + "',N'" + masp + "',N'" + soluong + "',N'" + dongia + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieuchitiethoadon()


            txtmahoadon.Text = ""
            txtmasp.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try

            Dim macthd As String = txtmacthd.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM ChiTietHoaDon WHERE MaCTHD = '" + macthd + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuchitiethoadon()
            txtmacthd.Text = ""
            txtmahoadon.Text = ""
            txtmasp.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""

        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            Dim macthd As String = txtmacthd.Text
            Dim mahd As String = txtmahoadon.Text
            Dim masp As String = txtmasp.Text
            Dim soluong As String = txtsoluong.Text
            Dim dongia As String = txtdongia.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update ChiTietHoaDon set MaHD = '" + mahd + "', Masp = '" + masp + "', Soluong = '" + soluong + "', DonGia = '" + dongia + "' where MaCTHD = '" + macthd + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieuchitiethoadon()
            txtmacthd.Text = ""
            txtmahoadon.Text = ""
            txtmasp.Text = ""
            txtdongia.Text = ""
            txtsoluong.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class