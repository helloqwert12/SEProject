Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class BaoCaoCongNo
    Dim baocaocongnoDTO As BaoCaoCongNoDTO
    Dim baocaocongnoDAL As BaoCaoCongNoDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()

        baocaocongnoDTO = New BaoCaoCongNoDTO()
        baocaocongnoDAL = New BaoCaoCongNoDAL()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("BAOCAOCONGNO join DAILY on BAOCAOCONGNO.MaDaiLy = DAILY.MaDaiLy", "DAILY.MaDaiLy", "ThoiGian", "NoDau", "PhatSinh", "NoCuoi")
        Me.dgvBaoCaoCongNo.DataSource = dTable
        With Me.dgvBaoCaoCongNo
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Tháng"
            .Columns(2).HeaderText = "Nợ đầu"
            .Columns(3).HeaderText = "Phát sinh"
            .Columns(4).HeaderText = "Nợ cuối"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Báo cáo công nợ?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnThucHien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThucHien.ItemClick

    End Sub
End Class