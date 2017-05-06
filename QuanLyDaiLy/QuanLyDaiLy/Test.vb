Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class Test
    'Khai bao bien de truy xuat DB tu Database QLDL
    Private _DBAcess As KetNoiDAL

    'Dinh nghia thu tuc load du lieu tu bang Test theot tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        _DBAcess = New KetNoiDAL()
        '_DBAcess.connet = New SqlClient.SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        '_DBAcess.connet = New SqlClient.SqlConnection("Data Source = GEFORCELIBRA \ SQLEXPRESS;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        _DBAcess.connet = New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=QuanLyDaiLy;Integrated Security=True")

        _DBAcess.TaoKetNoi()
        _DBAcess.MoKetNoi()
        Dim dTable As DataTable = _DBAcess.LayDuLieu("PHIEUXUAT")
        Me.dgvTest.DataSource = dTable
        With Me.dgvTest
            .Columns(0).HeaderText = "MaPhieuXuat"
            .Columns(1).HeaderText = "MaDaily"
            .Columns(2).HeaderText = "NgayLapPhieu"
            .Columns(3).HeaderText = "TongTriGia"
        End With
        '_DBAcess.NgatKetNoi()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim phieuxuat As PhieuXuatDTO
        phieuxuat = New PhieuXuatDTO()

        '1 Mapping data from GUI Control
        phieuxuat.MaPhieuXuat = txbMaPhieuXuat.Text
        phieuxuat.MaDaiLy = txbMaDaiLy.Text
        phieuxuat.NgayLapPhieu = Date.Parse(txbNgapLapPhieu.Text)
        phieuxuat.TongTriGia = Long.Parse(txbTongTriGia.Text)

        '2 Business


        '3 Insert to DB
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.ThemDuLieu(phieuxuat)
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()


    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.XoaDuLieu("MaDaiLy", "DL09")
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.CapNhatDuLieu("MaDaiLy", "DL06", "TongTriGia", "111111")
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim _export As Export = New Export()
        _export.ExportExcel(dgvTest)
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Dim _export As Export = New Export()
        _export.ExportPDF(dgvTest, "Test")
    End Sub
End Class