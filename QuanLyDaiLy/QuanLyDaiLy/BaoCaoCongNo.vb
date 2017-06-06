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
        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("BAOCAOCONGNO join DAILY on BAOCAOCONGNO.MaDaiLy = DAILY.MaDaiLy", "DAILY.MaDaiLy", "TenDaiLy", "ThoiGian", "NoDau", "PhatSinh", "NoCuoi")
        Me.dgvBaoCaoCongNo.DataSource = dTable
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
    End Sub

    'Private Sub dgvBaoCaoCongNo_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaoCaoCongNo.RowEnter
    '    'Binding du lieu len textbox
    '    txbMaDaiLy.DataBindings.Clear()
    '    txbMaDaiLy.DataBindings.Add("Text", dgvBaoCaoCongNo.DataSource, "MaDaiLy")
    '    txbThoiGian.DataBindings.Clear()
    '    txbThoiGian.DataBindings.Add("Text", dgvBaoCaoCongNo.DataSource, "ThoiGian")
    '    txbNoDau.DataBindings.Clear()
    '    txbNoDau.DataBindings.Add("Text", dgvBaoCaoCongNo.DataSource, "NoDau")
    '    txbPhatSinh.DataBindings.Clear()
    '    txbPhatSinh.DataBindings.Add("Text", dgvBaoCaoCongNo.DataSource, "PhatSinh")
    '    txbNoCuoi.DataBindings.Clear()
    '    txbNoCuoi.DataBindings.Add("Text", dgvBaoCaoCongNo.DataSource, "NoCuoi")
    'End Sub

    Private Sub btnExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExcel.ItemClick
        Dim _export As Export = New Export()
        _export.ExportExcel(dgvBaoCaoCongNo)
    End Sub

    Private Sub btnPDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPDF.ItemClick
        Dim _export As Export = New Export()
        Export.ExportPDF(dgvBaoCaoCongNo, "BÁO CÁO CÔNG NỢ THÁNG   " + cbThang.Text + "/" + txbNam.Text)
    End Sub
End Class