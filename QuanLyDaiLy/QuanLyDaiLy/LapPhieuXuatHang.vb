Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
'CON BUG ..........................................................................
Public Class LapPhieuXuatHang
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS
    Private KiemTraQD As Boolean
    Dim phieuxuatDTO As PhieuXuatDTO
    Dim phieuxuatBUS As PhieuXuatBUS
    Dim phieuxuatDAL As PhieuXuatDAL
    Dim chitietphieuxuatDTO As ChiTietPhieuXuatDTO
    Dim chitietphieuxuatBUS As ChiTietPhieuXuatBUS
    Dim chitietphieuxuatDAL As ChiTietPhieuXuatDAL
    Dim mathangDTO As MatHangDTO
    Dim mathangBUS As MatHangBUS
    Dim mathangDAL As MatHangDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        phieuxuatDTO = New PhieuXuatDTO()
        phieuxuatBUS = New PhieuXuatBUS()
        phieuxuatDAL = New PhieuXuatDAL()
        chitietphieuxuatDTO = New ChiTietPhieuXuatDTO()
        chitietphieuxuatBUS = New ChiTietPhieuXuatBUS()
        chitietphieuxuatDAL = New ChiTietPhieuXuatDAL()
        mathangDAL = New MatHangDAL()
        mathangBUS = New MatHangBUS()
        mathangDTO = New MatHangDTO()

        'Load du lieu tu bang DAILY
        Dim data As DataTable = KetNoiDAL.LayDuLieu("DAILY", "TenDaiLy", "")

        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbTenDaiLy.Items.Add(str)
        Next
        cbTenDaiLy.SelectedIndex = 0

        'Load du lieu tu bang MATHANG
        data = KetNoiDAL.LayDuLieu("MATHANG", "TenMatHang", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbTenMatHang.Items.Add(str)
        Next
        cbTenMatHang.SelectedIndex = 0

        'Load du lieu tu bang DONVITINH
        data = KetNoiDAL.LayDuLieu("DONVITINH", "TenDonViTinh", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbDonViTinh.Items.Add(str)
        Next
        cbDonViTinh.SelectedIndex = 0

        LoadDataOnGridView()
    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("PHIEUXUAT join CHITIETPHIEUXUAT on PHIEUXUAT.MaPhieuXuat = CHITIETPHIEUXUAT.MaPhieuXuat",
                                                      "PHIEUXUAT.MaPhieuXuat", "MaDaiLy", "MaMatHang", "DonGia", "MaDonViTinh", "SoLuongXuat", "ThanhTien", "NgayLapPhieu")
        Me.dgvLapPhieuXuatHang.DataSource = dTable
        With Me.dgvLapPhieuXuatHang
            .Columns(0).HeaderText = "Mã phiếu xuất"
            .Columns(1).HeaderText = "Mã đại lý"
            .Columns(1).Width = 60
            .Columns(2).HeaderText = "Mã mặt hàng"
            .Columns(2).Width = 70
            .Columns(3).HeaderText = "Đơn giá"
            .Columns(4).HeaderText = "Mã Đơn vị tính"
            .Columns(5).HeaderText = "Số lượng xuất"
            .Columns(6).HeaderText = "Thành tiền"
            .Columns(7).HeaderText = "Ngày lập phiếu"
        End With

        Dim dTable1 As DataTable = KetNoiDAL.LayDuLieu("PHIEUXUAT", "MaDaiLy", "TongTriGia", "NgayLapPhieu")
        Me.dgvTongTriGia.DataSource = dTable1
        With Me.dgvTongTriGia
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Tổng trị giá"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemPhieuXuat.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaPhieuXuat.Enabled = False
        btnCapNhatPhieuXuat.Enabled = False
        txbMaPhieuXuat.Text = KetNoiDAL.TaoKhoaChinh("PHIEUXUAT", "MaPhieuXuat", "PX")
        txbNgayLapPhieu.Text = Date.Now.ToShortDateString
        cbTenDaiLy.SelectedIndex = 0
        cbTenMatHang.SelectedIndex = 0

        'txbDonGia.Enabled = True
        txbSoLuongXuat.Enabled = True
        cbTenDaiLy.Enabled = True
        cbTenMatHang.Enabled = True
        txbDonGia.Enabled = True
        cbDonViTinh.Enabled = True
        txbDonGia.Text = "0"
        txbSoLuongXuat.Text = "0"
    End Sub
    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If (rslt = DialogResult.Yes) Then
            'Ket noi du lieu giua text box va DTO
            chitietphieuxuatDTO.MaCTPhieuXuat = KetNoiDAL.TaoKhoaChinh("CHITIETPHIEUXUAT", "MaCTPhieuXuat", "CT")
            chitietphieuxuatDTO.MaPhieuXuat = txbMaPhieuXuat.Text
            chitietphieuxuatDTO.MaMatHang = KetNoiDAL.ChuyenTenThanhMa("MATHANG", "TenMatHang", cbTenMatHang.Text, "MaMatHang")
            chitietphieuxuatDTO.MaDonViTinh = KetNoiDAL.ChuyenTenThanhMa("DONVITINH", "TenDonViTinh", cbDonViTinh.Text, "MaDonViTinh")
            chitietphieuxuatDTO.SoLuongXuat = txbSoLuongXuat.Text
            chitietphieuxuatDTO.DonGia = txbDonGia.Text
            chitietphieuxuatDTO.ThanhTien = chitietphieuxuatDTO.DonGia * chitietphieuxuatDTO.SoLuongXuat
            phieuxuatDTO.MaPhieuXuat = txbMaPhieuXuat.Text
            phieuxuatDTO.MaDaiLy = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbTenDaiLy.Text, "MaDaiLy")
            'phieuxuatDTO.TongTriGia = 
            phieuxuatDTO.NgayLapPhieu = txbNgayLapPhieu.Text

            'Kiem tra thong tin da duoc nhap day du
            If chitietphieuxuatBUS.IsEmpty(chitietphieuxuatDTO, phieuxuatDTO) Then
                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
            Else
                If trangthai = STATUS.THEM Then
                    'Ghi xuong CSDL            
                    Dim success1 As Boolean = chitietphieuxuatDAL.ThemDuLieu(chitietphieuxuatDTO)
                    Dim success2 As Boolean = phieuxuatDAL.ThemDuLieu(phieuxuatDTO)
                    If success1 And success2 Then
                        HienThiThongBao("Thêm phiếu xuất thành công")
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Thêm phiếu xuất thất bại, vui lòng kiểm tra lại")
                    End If
                ElseIf trangthai = STATUS.SUA Then
                    chitietphieuxuatDAL.XoaDuLieu("MaPhieuXuat", chitietphieuxuatDTO.MaPhieuXuat)
                    phieuxuatDAL.XoaDuLieu("MaPhieuXuat", phieuxuatDTO.MaPhieuXuat)
                    Dim success1 As Boolean = chitietphieuxuatDAL.ThemDuLieu(chitietphieuxuatDTO)
                    Dim success2 As Boolean = phieuxuatDAL.ThemDuLieu(phieuxuatDTO)
                    If success1 And success2 Then
                        HienThiThongBao("Cập nhật phiếu xuất thành công")
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật phiếu xuất thất bại, vui lòng kiểm tra lại")
                    End If
                End If

            End If
        End If
    End Sub
    Private Sub btnXoaPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaPhieuXuat.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa phiếu xuất", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim maphieuxuat As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaPhieuXuat").Value 'Con nhieu nghi van...........................
            If phieuxuatDAL.XoaDuLieu("MaPhieuXuat", maphieuxuat.ToString()) Then
                HienThiThongBao("Xóa phiếu xuất thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa phiếu xuất, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvLapPhieuXuatHang_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLapPhieuXuatHang.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaPhieuXuat.DataBindings.Clear()
        txbMaPhieuXuat.DataBindings.Add("Text", dgvLapPhieuXuatHang.DataSource, "MaPhieuXuat")
        Dim madaily As String = dgvLapPhieuXuatHang.Rows(e.RowIndex).Cells("MaDaiLy").Value
        cbTenDaiLy.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("DAILY", "MaDaiLy", madaily, "TenDaiLy")
        Dim mamathang As String = dgvLapPhieuXuatHang.Rows(e.RowIndex).Cells("MaMatHang").Value
        cbTenMatHang.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("MATHANG", "MaMatHang", mamathang, "TenMatHang")
        Dim madonvitinh As String = dgvLapPhieuXuatHang.Rows(e.RowIndex).Cells("MaDonViTinh").Value
        cbDonViTinh.Text = KetNoiDAL.ChuyenMaThanhTen("DONVITINH", "MaDonViTinh", madonvitinh, "TenDonViTinh")
        txbSoLuongXuat.DataBindings.Clear()
        txbSoLuongXuat.DataBindings.Add("Text", dgvLapPhieuXuatHang.DataSource, "SoLuongXuat")
        txbDonGia.DataBindings.Clear()
        txbDonGia.DataBindings.Add("Text", dgvLapPhieuXuatHang.DataSource, "DonGia")
        txbNgayLapPhieu.DataBindings.Clear()
        txbNgayLapPhieu.DataBindings.Add("Text", dgvLapPhieuXuatHang.DataSource, "NgayLapPhieu")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatPhieuXuat.Enabled = True
        btnXoaPhieuXuat.Enabled = True
    End Sub

    Private Sub CapNhatThongTin()
        'dgSoLuongTonCuaMatHang.Text = mathangDAL.LayDuLieu("SoLuongTon", "TenMatHang = " + cbTenMatHang.SelectedItem)
        'dgSoLuongTonCuaMatHang.Text = KetNoiDAL.LayDuLieu("MATHANG", "SoLuongTon", "MaMatHang = " + cbTenMatHang.SelectedItem).ToString()
        lblMatHang.Text = cbTenMatHang.SelectedItem + ": "
        dgSoMatHang.Text = chitietphieuxuatDAL.LayDuLieu("MaMatHang", "").Rows.Count
        dgTongPhieuXuat.Text = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "").Rows.Count
    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Lập phiếu xuất hàng?", "XÁC NHẬN", MessageBoxButtons.YesNo)
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

    Private Sub btnCapNhatPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatPhieuXuat.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Mo Enabled de chinh sua
        'txbDonGia.Enabled = True
        txbSoLuongXuat.Enabled = True
        cbTenDaiLy.Enabled = True
        cbTenMatHang.Enabled = True
    End Sub
End Class