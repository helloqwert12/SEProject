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

        cbThang.SelectedIndex = 0
        txbNam.Text = Date.Today.Year

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView(ByVal data As DataTable)
        'Dim dTable As DataTable = KetNoiDAL.LayDuLieu("BAOCAOCONGNO join DAILY on BAOCAOCONGNO.MaDaiLy = DAILY.MaDaiLy", "DAILY.MaDaiLy", "TenDaiLy", "ThoiGian", "NoDau", "PhatSinh", "NoCuoi")
        Me.dgvBaoCaoCongNo.DataSource = data
        With Me.dgvBaoCaoCongNo
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Tên đại lý"
            .Columns(2).HeaderText = "Thời gian"
            .Columns(3).HeaderText = "Nợ đầu"
            .Columns(4).HeaderText = "Phát sinh"
            .Columns(5).HeaderText = "Nợ cuối"
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
        btnPDF.Enabled = True
        btnExcel.Enabled = True

        If txbNam.Text > Date.Now.Year Then
            MessageBox.Show("Năm lập báo cáo lớn hơn năm hiện tại. Vui lòng kiểm tra lại", "THÔNG BÁO")
        Else
            Dim data As DataTable = KetNoiDAL.LayDuLieu("BAOCAOCONGNO, DAILY", True,
                                                        "BAOCAOCONGNO.MaDaiLy = DAILY.MaDaiLy and Month(ThoiGian) = " + cbThang.SelectedItem + " and Year(ThoiGian) = " + txbNam.Text,
                                                        "DAILY.MaDaiLy", "TenDaiLy", "ThoiGian", "NoDau", "PhatSinh", "NoCuoi")
            If data.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu thõa thời gian trên", "THÔNG BÁO")
            Else
                LoadDataOnGridView(data)
            End If
        End If
    End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Try
            Export.ExportExcel(dgvBaoCaoCongNo)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPDF.ItemClick
        Try
            Export.ExportPDF(dgvBaoCaoCongNo, "BÁO CÁO CÔNG NỢ THÁNG   " + cbThang.Text + "/" + txbNam.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class