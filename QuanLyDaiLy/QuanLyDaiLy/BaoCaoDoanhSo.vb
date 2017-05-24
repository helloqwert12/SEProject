Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class BaoCaoDoanhSo
    Dim baocaodoanhsoDTO As BaoCaoDoanhSoDTO
    Dim baocaodoanhsoDAL As BaoCaoDoanhSoDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()

        baocaodoanhsoDTO = New BaoCaoDoanhSoDTO()
        baocaodoanhsoDAL = New BaoCaoDoanhSoDAL()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("BAOCAODOANHSO join DAILY on BAOCAODOANHSO.MaDaiLy = DAILY.MaDaiLy", "BAOCAODOANHSO.MaDaiLy", "ThoiGian", "SoPhieuXuat", "TongTriGia", "TyLe")

        Me.dgvBaoCaoDoanhSo.DataSource = dTable
        With Me.dgvBaoCaoDoanhSo
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Tháng"
            .Columns(2).HeaderText = "Số phiếu xuất"
            .Columns(3).HeaderText = "Tổng trị giá"
            .Columns(4).HeaderText = "Tỷ lệ"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Báo cáo doanh số?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class