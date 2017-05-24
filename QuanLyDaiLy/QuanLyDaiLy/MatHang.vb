Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class MatHang
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS

    Dim mathangDTO As MatHangDTO
    Dim mathangBUS As MatHangBUS
    Dim mathangDAL As MatHangDAL

    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        mathangDAL = New MatHangDAL()
        mathangBUS = New MatHangBUS()
        mathangDTO = New MatHangDTO()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("MATHANG", "MaMatHang", "TenMatHang", "SoLuongTon")

        Me.dgvDanhSachMatHang.DataSource = dTable
        With Me.dgvDanhSachMatHang
            .Columns(0).HeaderText = "Mã mặt hàng"
            .Columns(1).HeaderText = "Tên mặt hàng"
            .Columns(2).HeaderText = "Số lượng tồn"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMatHang.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaMatHang.Enabled = False
        btnCapNhatMatHang.Enabled = False
        txbMaMatHang.Text = KetNoiDAL.TaoKhoaChinh("MATHANG", "MaMatHang", "MH")

        txbTenMatHang.Enabled = True
        txbSoLuongTon.Enabled = True

        txbTenMatHang.Clear()
        txbSoLuongTon.Text = "0"

    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Mặt hàng?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fpnlNote.HidePopup()
        Timer1.Enabled = False
    End Sub

    'Hien thi thong bao tu flyout
    Private Sub HienThiThongBao(ByVal thongbao As String)
        label.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If (rslt = DialogResult.Yes) Then
            'Ket noi du lieu giua text box va DTO
            mathangDTO.MaMatHang = txbMaMatHang.Text
            mathangDTO.TenMatHang = txbTenMatHang.Text
            mathangDTO.SoLuongTon = txbSoLuongTon.Text

            'Kiem tra thong tin da duoc nhap day du
            If mathangBUS.IsEmpty(mathangDTO) Then
                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
            ElseIf Not mathangBUS.IsValid_SoLuongTon(mathangDTO) Then
                HienThiThongBao("Số lượng nhập vào không hợp lệ, vui lòng kiểm tra lại")
            Else
                If trangthai = STATUS.THEM Then
                    'Ghi xuong CSDL            
                    Dim success As Boolean = mathangDAL.ThemDuLieu(mathangDTO)
                    If success Then
                        HienThiThongBao("Thêm mặt hàng thành công")
                        txbTenMatHang.Enabled = False
                        txbSoLuongTon.Enabled = False
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Thêm mặt hàng thất bại, vui lòng kiểm tra lại")
                        txbTenMatHang.Enabled = False
                        txbSoLuongTon.Enabled = False
                    End If
                ElseIf trangthai = STATUS.SUA Then
                    mathangDAL.XoaDuLieu("MaMatHang", mathangDTO.MaMatHang)
                    Dim success As Boolean = mathangDAL.ThemDuLieu(mathangDTO)
                    If success Then
                        HienThiThongBao("Cập nhật mặt hàng thành công")
                        txbTenMatHang.Enabled = False
                        txbSoLuongTon.Enabled = False
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật mặt hàng thất bại, vui lòng kiểm tra lại")
                        txbTenMatHang.Enabled = False
                        txbSoLuongTon.Enabled = False
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub btnXoaMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaMatHang.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa mặt hàng", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim mamathang As String = dgvDanhSachMatHang.SelectedCells(0).OwningRow.Cells("MaMatHang").Value
            If mathangDAL.XoaDuLieu("MaMatHang", mamathang.ToString()) Then
                HienThiThongBao("Xóa mặt hàng thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa mặt hàng, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvDanhSachMatHang_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachMatHang.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaMatHang.DataBindings.Clear()
        txbMaMatHang.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "MaMatHang")
        txbTenMatHang.DataBindings.Clear()
        txbTenMatHang.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "TenMatHang")
        txbSoLuongTon.DataBindings.Clear()
        txbSoLuongTon.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "SoLuongTon")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatMatHang.Enabled = True
        btnXoaMatHang.Enabled = True

    End Sub

    Private Sub CapNhatThongTin()
        dgTongMatHang.Text = KetNoiDAL.LayDuLieu("MATHANG", "MaMatHang", "").Rows.Count
    End Sub

    Private Sub btnCapNhatMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatMatHang.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Bat Enabled de chinh sua
        txbTenMatHang.Enabled = True
        txbSoLuongTon.Enabled = True
    End Sub
End Class