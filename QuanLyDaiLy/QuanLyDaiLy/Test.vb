Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class Test
    'Khai bao bien de truy xuat DB tu Database QLDL
    Private _DBAcess As New KetNoiDAL
    Private _DBAcess1 As New PhieuXuatDAL

    'Dinh nghia thu tuc load du lieu tu bang Test theot tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        _DBAcess.MoKetNoi()
        Dim dTable As DataTable = _DBAcess.LayDuLieu("dbo.PHIEUXUAT")
        Me.dgvTest.DataSource = dTable
        With Me.dgvTest
            .Columns(0).HeaderText = "MaPhieuXuat"
            .Columns(1).HeaderText = "MaDaily"
            .Columns(2).HeaderText = "NgayLapPhieu"
            .Columns(3).HeaderText = "TongTriGia"
        End With
        _DBAcess.NgatKetNoi()
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
        'Dim phieuxuatdal As PhieuXuatDAL
        'phieuxuatdal = New PhieuXuatDAL()
        'Dim result As Integer
        'result = phieuxuatdal.Insert(phieuxuat)
        'If (result = 0) Then
        '    MessageBox.Show("Them phieu xuat thanh cong.")
        'Else
        '    MessageBox.Show("Them phieu xuat that bai. Vui long kiem tra lai DB!!!")
        'End If
    End Sub
End Class