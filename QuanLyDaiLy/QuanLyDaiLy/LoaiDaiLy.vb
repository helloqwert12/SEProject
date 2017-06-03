Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class LoaiDaiLy
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS

    Dim loaidailyDTO As LoaiDaiLyDTO
    Dim loaidailyBUS As LoaiDaiLyBUS
    Dim loaidailyDAL As LoaiDaiLyDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        loaidailyDAL = New LoaiDaiLyDAL()
        loaidailyBUS = New LoaiDaiLyBUS()
        loaidailyDTO = New LoaiDaiLyDTO()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("LOAIDAILY")

        Me.dgvLoaiDaiLy.DataSource = dTable
        With Me.dgvLoaiDaiLy
            .Columns(0).HeaderText = "Mã loại đại lý"
            .Columns(1).HeaderText = "Tên loại đại lý"
            .Columns(2).HeaderText = "Tiền nợ tối đa"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemLoaiDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemLoaiDaiLy.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaLoaiDaiLy.Enabled = False
        btnCapNhatLoaiDaiLy.Enabled = False
        txbMaLoaiDaiLy.Text = KetNoiDAL.TaoKhoaChinh("LOAIDAILY", "MaLoaiDaiLy", "LDL")

        txbTenLoaiDaiLy.Enabled = True
        txbNoToiDa.Enabled = True

        txbTenLoaiDaiLy.Clear()
        txbNoToiDa.Text = "0"

    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Loại đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fpnlNote.HidePopup()
        Timer1.Enabled = False
    End Sub

    'Hien thi thong bao tu flyout
    Private Sub HienThiThongBao(ByVal thongbao As String)
        Label.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If (rslt = DialogResult.Yes) Then
            'Ket noi du lieu giua text box va DTO
            loaidailyDTO.MaLoaiDaiLy = txbMaLoaiDaiLy.Text
            loaidailyDTO.TenLoaiDaiLy = txbTenLoaiDaiLy.Text
            loaidailyDTO.NoToiDa = txbNoToiDa.Text

            'Kiem tra thong tin da duoc nhap day du
            If loaidailyBUS.IsEmpty(loaidailyDTO) Then
                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
            Else
                If trangthai = STATUS.THEM Then
                    'Ghi xuong CSDL            
                    Dim success As Boolean = loaidailyDAL.ThemDuLieu(loaidailyDTO)
                    If success Then
                        HienThiThongBao("Thêm loại đại lý thành công")
                        txbTenLoaiDaiLy.Enabled = False
                        txbNoToiDa.Enabled = False
                        LoadDataOnGridView()
                    Else
                        txbTenLoaiDaiLy.Enabled = False
                        txbNoToiDa.Enabled = False
                        HienThiThongBao("Thêm loại đại lý thất bại, vui lòng kiểm tra lại")
                    End If
                ElseIf trangthai = STATUS.SUA Then
                    loaidailyDAL.XoaDuLieu("MaLoaiDaiLy", loaidailyDTO.MaLoaiDaiLy)
                    Dim success As Boolean = loaidailyDAL.ThemDuLieu(loaidailyDTO)
                    If success Then
                        HienThiThongBao("Cập nhật loại đại lý thành công")
                        txbTenLoaiDaiLy.Enabled = False
                        txbNoToiDa.Enabled = False
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật loại đại lý thất bại, vui lòng kiểm tra lại")
                        txbTenLoaiDaiLy.Enabled = False
                        txbNoToiDa.Enabled = False
                    End If
                End If
            End If
            txbNoToiDa.Enabled = False
            txbTenLoaiDaiLy.Enabled = False
        End If
    End Sub

    Private Sub btnXoaLoaiDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaLoaiDaiLy.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa loại đại lý", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim maloaidaily As String = dgvLoaiDaiLy.SelectedCells(0).OwningRow.Cells("MaLoaiDaiLy").Value
            If loaidailyDAL.XoaDuLieu("MaLoaiDaiLy", maloaidaily.ToString()) Then
                HienThiThongBao("Xóa loại đại lý thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa loại đại lý, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvLoaiDaiLy_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiDaiLy.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaLoaiDaiLy.DataBindings.Clear()
        txbMaLoaiDaiLy.DataBindings.Add("Text", dgvLoaiDaiLy.DataSource, "MaLoaiDaiLy")
        txbTenLoaiDaiLy.DataBindings.Clear()
        txbTenLoaiDaiLy.DataBindings.Add("Text", dgvLoaiDaiLy.DataSource, "TenLoaiDaiLy")
        txbNoToiDa.DataBindings.Clear()
        txbNoToiDa.DataBindings.Add("Text", dgvLoaiDaiLy.DataSource, "NoToiDa")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatLoaiDaiLy.Enabled = True
        btnXoaLoaiDaiLy.Enabled = True
    End Sub
    Private Sub CapNhatThongTin()
        dgSoLoaiDaiLy.Text = KetNoiDAL.LayDuLieu("LOAIDAILY", "MaLoaiDaiLy", "").Rows.Count
    End Sub
    Private Sub btnCapNhatLoaiDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatLoaiDaiLy.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Bat Enabled de chinh sua
        txbTenLoaiDaiLy.Enabled = True
        txbNoToiDa.Enabled = True
    End Sub
End Class