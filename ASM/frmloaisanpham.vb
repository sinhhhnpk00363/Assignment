Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
    Public Class frmloaisanpham
    Dim ketnoi As New SqlConnection("workstation id=QuanLyBanHang.mssql.somee.com;packet size=4096;user id=sinhhn;pwd=abcd1234;data source=QuanLyBanHang.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang")
    Public Property Value As String
        Private Sub thucthi(str As String)
            ketnoi.Open()
            Dim com As New SqlCommand(str, ketnoi)
            com.ExecuteNonQuery()
            ketnoi.Close()
        End Sub

        Private Sub frmloaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            laythongtinloaisanpham()
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

        Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
            Try


                Dim TENLOAISANPHAM As String = txttenloaisanpham.Text
                Dim MOTA As String = txtmota.Text

                Dim truyvan1 As String = "insert into LOAISANPHAM (TenLsp,Mota) Values(N'" + TENLOAISANPHAM + "',N'" + MOTA + "')"
                thucthi(truyvan1)

                MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                laythongtinloaisanpham()

                txttenloaisanpham.Text = ""
                txtmota.Text = ""

            Catch ex As Exception
                MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End Sub

        Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
            Try
                Dim maloaisanpham As String = txtmaloaisanpham.Text
                Dim tenloaisanpham As String = txttenloaisanpham.Text
                Dim motaloaisanpham As String = txtmota.Text
                ketnoi.Open()
                Dim sualsp As New SqlCommand("update LoaiSanPham set TenLsp = N'" + tenloaisanpham + "', Mota = '" + motaloaisanpham + "' where MaLsp = '" + maloaisanpham + "'", ketnoi)
                sualsp.ExecuteNonQuery()
                ketnoi.Close()
                MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                laythongtinloaisanpham()
            Catch ex As Exception
                MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End Sub

        Private Sub lsvloaisanpham_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvloaisanpham.SelectedIndexChanged
            For Each dsachlsp As ListViewItem In lsvloaisanpham.SelectedItems
                txtmaloaisanpham.Text = dsachlsp.SubItems(0).Text
                txttenloaisanpham.Text = dsachlsp.SubItems(1).Text
                txtmota.Text = dsachlsp.SubItems(2).Text

            Next

        End Sub

        Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
            Try

                Dim MALOAISANPHAM As String = txtmaloaisanpham.Text

                ketnoi.Open()
                Dim xoalsp As New SqlCommand(" DELETE FROM LoaiSanPham WHERE MaLsp = '" + MALOAISANPHAM + "'", ketnoi)
                xoalsp.ExecuteNonQuery()
                ketnoi.Close()
                MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                laythongtinloaisanpham()

            Catch ex As Exception
                MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        End Sub
    End Class
