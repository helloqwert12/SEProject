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

        cbThang.SelectedIndex = 0
        txbNam.Text = Date.Today.Year
    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView(ByVal data As DataTable)

        Me.dgvBaoCaoDoanhSo.DataSource = data
        With Me.dgvBaoCaoDoanhSo
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Tháng"
            .Columns(2).HeaderText = "Số phiếu xuất"
            .Columns(3).HeaderText = "Tổng trị giá"
            .Columns(4).HeaderText = "Tỷ lệ"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub

    Private Sub btnThucHien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThucHien.ItemClick
        btnPDF.Enabled = True
        btnExcel.Enabled = True

        'Ghi du lieu vao Bang
        baocaodoanhsoDTO.MaBaoCaoDoanhSo = KetNoiDAL.TaoKhoaChinh("BAOCAODOANHSO", "MaBaoCaoDoanhSo", "D")
        baocaodoanhsoDTO.ThoiGian = KetNoiDAL.LayDuLieu("PHIEUXUAT", "Month(NgayLapPhieu)", "Year(NgayLapPhieu)", "Month(NgayLapPhieu) = " + cbThang.SelectedItem, "Year(NgayLapPhieu) = " + txbNam.Text).Rows(0)(0)
        Dim madaily As DataTable = KetNoiDAL.LayDuLieu("PHIEUXUAT", "DISTINCT MaDaiLy", "")

        For i = 0 To madaily.Rows.Count - 1
            'Kiem tra ma daily va thoi gian muon bao cao
            Dim str As String = "MaDaiLy = '" + madaily.Rows(i)(0) + "' And Month(NgayLapPhieu) = " + cbThang.SelectedItem + " and Year(NgayLapPhieu) = " + txbNam.Text
            baocaodoanhsoDTO.MaDaiLy = KetNoiDAL.LayDuLieu("PHIEUXUAT", "MaDaiLy", "Month(NgayLapPhieu) = " + cbThang.SelectedItem + " and Year(NgayLapPhieu) = " + txbNam.Text).Rows(0)(0)
            baocaodoanhsoDTO.SoPhieuXuat = KetNoiDAL.LayDuLieu("PHIEUXUAT", "MaPhieuXuat", str).Rows.Count
            baocaodoanhsoDTO.TongTriGia = 50000 'Tam thoi
            'baocaodoanhsoDTO.TongTriGia = KetNoiDAL.LayDuLieu("PHIEUXUAT", "DISTINCT TongTriGia", str).Rows(0)(0) Nay bi loi, khong hieu
        Next
        baocaodoanhsoDTO.TyLe = baocaodoanhsoDTO.TongTriGia / baocaodoanhsoDTO.SoPhieuXuat

        Dim success As Boolean = baocaodoanhsoDAL.ThemDuLieu(baocaodoanhsoDTO)
        If success Then
            Dim data As DataTable = KetNoiDAL.LayDuLieu("BAOCAODOANHSO join DAILY on BAOCAODOANHSO.MaDaiLy = DAILY.MaDaiLy join PHIEUXUAT on DAILY.MaDaiLy = PHIEUXUAT.MaDaily", "BAOCAODOANHSO.MaDaiLy", "ThoiGian", "SoPhieuXuat", "PHIEUXUAT.TongTriGia", "TyLe")
            LoadDataOnGridView(data)
        End If
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Báo cáo doanh số?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub dgvBaoCaoDoanhSo_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaoCaoDoanhSo.RowEnter
        'Binding du lieu len textbox
        txbMaDaiLy.DataBindings.Clear()
        txbMaDaiLy.DataBindings.Add("Text", dgvBaoCaoDoanhSo.DataSource, "MaDaiLy")
        txbThoiGian.DataBindings.Clear()
        txbThoiGian.DataBindings.Add("Text", dgvBaoCaoDoanhSo.DataSource, "ThoiGian")
        txbTongTriGia.DataBindings.Clear()
        txbTongTriGia.DataBindings.Add("Text", dgvBaoCaoDoanhSo.DataSource, "TongTriGia")
        txbSoPhieuXuat.DataBindings.Clear()
        txbSoPhieuXuat.DataBindings.Add("Text", dgvBaoCaoDoanhSo.DataSource, "SoPhieuXuat")
        txbTyLe.DataBindings.Clear()
        txbTyLe.DataBindings.Add("Text", dgvBaoCaoDoanhSo.DataSource, "TyLe")
    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Dim _export As Export = New Export()
        _export.ExportExcel(dgvBaoCaoDoanhSo)
    End Sub

    Private Sub btnPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPDF.ItemClick
        Dim _export As Export = New Export()
        _export.ExportPDF(dgvBaoCaoDoanhSo, "BÁO CÁO DOANH SỐ " + cbThang.SelectedIndex + "/" + txbNam.Text)
    End Sub
End Class