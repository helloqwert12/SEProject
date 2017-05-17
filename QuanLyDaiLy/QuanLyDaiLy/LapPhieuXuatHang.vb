Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class LapPhieuXuatHang
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS
    Private _DBAcess As KetNoiDAL
    Private KiemTraQD As Boolean
    Dim chitietphieuxuatDTO As ChiTietPhieuXuatDTO
    Dim chitietphieuxuatBUS As ChiTietPhieuXuatBUS
    Dim chitietphieuxuatDAL As ChiTietPhieuXuatDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        chitietphieuxuatDTO = New ChiTietPhieuXuatDTO()
        chitietphieuxuatBUS = New ChiTietPhieuXuatBUS()
        chitietphieuxuatDAL = New ChiTietPhieuXuatDAL()

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
    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("PHIEUXUAT")
        Me.dgvLapPhieuXuatHang.DataSource = dTable
        'With Me.dgvLapPhieuXuatHang
        '.Columns(0).HeaderText = "Mã đại lý"
        '.Columns(1).HeaderText = "Mã loại đại lý"
        '.Columns(2).HeaderText = "Tên đại lý"
        '.Columns(3).HeaderText = "Điện thoại"
        '.Columns(4).HeaderText = "Địa chỉ"
        '.Columns(5).HeaderText = "Mã quận"
        '.Columns(6).HeaderText = "Ngày tiếp nhận"
        '.Columns(7).HeaderText = "E-mail"
        '.Columns(8).HeaderText = "Nợ đại lý"
        'End With
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

        txbSoLuongXuat.ReadOnly = False

        txbSoLuongXuat.Text = ""
        'txbDonGia.Text = ""
    End Sub
    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        '    If Not KiemTraQD Then
        '        HienThiThongBao("Vi phạm quy định về số đại lý tối đa trong quận. Vui lòng kiểm tra lại")
        '    End If

        '    If KiemTraQD Then
        '        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thêm phiếu xuất?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        '        If (rslt = DialogResult.Yes) Then
        '            'Ket noi du lieu giua text box va DTO
        '            DaiLyDTO.MaDaiLy = txbMaDaiLy.Text
        '            DaiLyDTO.TenDaiLy = txbTenDaiLy.Text
        '            DaiLyDTO.DienThoai = txbDienThoai.Text
        '            DaiLyDTO.NgayTiepNhan = txbNgayTiepNhan.Text
        '            DaiLyDTO.Email = txbEmail.Text
        '            DaiLyDTO.DiaChi = txbDiaChi.Text
        '            DaiLyDTO.NoDaiLy = 0

        '            '  Xu ly ten quan va ten loai dai ly
        '            Dim maquan As String = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = '" + cbQuan.SelectedItem + "'").Rows(0)(0)
        '            DaiLyDTO.MaQuan = maquan

        '            Dim maloaidaily As String = KetNoiDAL.LayDuLieu("LOAIDAILY", "MaLoaiDaiLy", "TenLoaiDaiLy = '" + cbTenLoaiDaiLy.SelectedItem + "'").Rows(0)(0)
        '            DaiLyDTO.MaLoaiDaiLy = maloaidaily
        '            ChiTiet
        '            'Kiem tra thong tin da duoc nhap day du 
        '            If PhieuXuatBUS.IsEmpty(chitietphieuxuatDTO, MatHangDTO, PhieuXuatDTO) Then
        '                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
        '                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
        '            Else
        '                'Ghi xuong CSDL            
        '                Dim success As Boolean = DaiLyDAL.ThemDuLieu(DaiLyDTO)
        '                If success Then
        '                    HienThiThongBao("Thêm đại lý thành công")
        '                    LoadDataOnGridView()
        '                Else
        '                    HienThiThongBao("Thêm đại lý thất bại, vui lòng kiểm tra lại")
        '                End If
        '            End If
        '        End If
        '    End If
    End Sub
    Private Sub btnXoaPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaPhieuXuat.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa phiếu xuất", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim maphieuxuat As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaPhieuXuat").Value 'Con nhieu nghi van...........................
            If chitietphieuxuatDAL.XoaDuLieu("MaPhieuXuat", maphieuxuat.ToString()) Then
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

        'Bat read-only cho textbox
        txbDonGia.ReadOnly = True
        txbSoLuongXuat.ReadOnly = True
        txbSoLuongXuat.ReadOnly = True

        'Binding du lieu len textbox
        txbDonViTinh.DataBindings.Clear()
        txbDonViTinh.DataBindings.Add("Text", dgvLapPhieuXuatHang.DataSource, "TenDonViTinh")
        Dim tendaily As String = dgvLapPhieuXuatHang.Rows(e.RowIndex).Cells("TenDaiLy").Value
        cbTenDaiLy.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("DAILY", "MaDaiLy", tendaily, "TenDaiLy")
        Dim tenmathang As String = dgvLapPhieuXuatHang.Rows(e.RowIndex).Cells("MaDonViTinh").Value
        cbTenMatHang.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("MATHANG", "MaMatHang", tenmathang, "TenMatHang")
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
        'dgSoLuongTonCuaMatHang.Text = KetNoiDAL.LayDuLieu("MATHANG", "SoLuongTon", "") ---------------------------------
        'lblMatHang.Text = cbMatHang.SelectedItem
        dgSoLuongTonCuaMatHang.Text = chitietphieuxuatDAL.LayDuLieu("MaMatHang", "").Rows.Count
        dgTongPhieuXuat.Text = chitietphieuxuatDAL.LayDuLieu("MaPhieuXuat", "").Rows.Count
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
        'Tat read-only de chinh sua
        txbDonGia.ReadOnly = False
        txbSoLuongXuat.ReadOnly = False
        txbSoLuongXuat.ReadOnly = False
    End Sub
End Class