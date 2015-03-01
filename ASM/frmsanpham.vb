Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmsanpham
    Dim ketnoi As New SqlConnection("workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=sinhhn;pwd=abcd1234;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang")
    Public Property Value As String
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub laythongtinloaisanpham()
        ketnoi.Open()
        Dim truyvanlsp As New SqlCommand("select * from loaisanpham", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvanlsp)
        Dim dulieubanglsp As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanglsp)
        ketnoi.Close()
        lsvloaisanpham.Items.Clear()

        For Each cot As DataRow In dulieubanglsp.Rows
            lsvloaisanpham.Items.Add(cot("MaLsp").ToString())
            lsvloaisanpham.Items(i).SubItems.Add(cot("TenLsp").ToString())
            lsvloaisanpham.Items(i).SubItems.Add(cot("Mota").ToString())
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
            lsvsanpham.Items(i).SubItems.Add(cot("TenLsp").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("DongiaSP").ToString())
            lsvsanpham.Items(i).SubItems.Add(cot("Mota").ToString())
            i += 1
        Next
    End Sub

    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laythongtinloaisanpham()
        laythongtinsanpham()
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        Try


            Dim TENSANPHAM As String = txttensanpham.Text
            Dim motasp As String = txtmota.Text
            Dim dongia As String = txtdongia.Text
            Dim maloaisp As String = txtloaisanpham.Text

            Dim truyvan2 As String = "insert into SANPHAM (TenSp,MaLsp,DongiaSP,Mota) Values(N'" + TENSANPHAM + "','" + maloaisp + "','" + dongia + "',N'" + motasp + "')"
            thucthi(truyvan2)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            laythongtinsanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtloaisanpham.Text = ""
            txtdongia.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công, Vui Lòng Kiểm Tra Lại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub lsvsanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvsanpham.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvsanpham.SelectedItems
            txtmasanpham.Text = dsachsp.SubItems(0).Text
            txttensanpham.Text = dsachsp.SubItems(1).Text
            txtloaisanpham.Text = dsachsp.SubItems(2).Text
            txtdongia.Text = dsachsp.SubItems(3).Text
            txtmota.Text = dsachsp.SubItems(4).Text
        Next
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Try
            Dim masp As String = txtmasanpham.Text
            Dim TENSANPHAM As String = txttensanpham.Text
            Dim maloaisp As String = txtloaisanpham.Text
            Dim dongia As String = txtdongia.Text
            Dim motasp As String = txtmota.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update SanPham set TenSP = N'" + TENSANPHAM + "', MaLsp = '" + maloaisp + "', Dongiasp = '" + dongia + "', Mota = '" + motasp + "' where MaSp = '" + masp + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            laythongtinsanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtloaisanpham.Text = ""
            txtdongia.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Try

            Dim MASANPHAM As String = txtmasanpham.Text

            ketnoi.Open()
            Dim xoasp As New SqlCommand(" DELETE FROM SanPham WHERE MaSP = '" + MASANPHAM + "'", ketnoi)
            xoasp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            laythongtinsanpham()
            txtmasanpham.Text = ""
            txttensanpham.Text = ""
            txtmota.Text = ""
            txtloaisanpham.Text = ""
            txtdongia.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
