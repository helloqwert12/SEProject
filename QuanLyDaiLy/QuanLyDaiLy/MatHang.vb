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
    Private _DBAcess As KetNoiDAL
    Private KiemTraQD As Boolean
    Private CoLoi As Boolean = False
    Dim MatHangDTO As MatHangDTO
    Dim MatHangBUS As MatHangBUS
    Dim MatHangDAL As MatHangDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        MatHangDTO = New MatHangDTO()
        MatHangBUS = New MatHangBUS()
        MatHangDTO = New MatHangDTO()

        'Load du lieu tu bang QUAN
        Dim data As DataTable = KetNoiDAL.LayDuLieu("DONVITINH", "TenDonViTinh", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbDonViTinh.Items.Add(str)
        Next

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable1 As DataTable = KetNoiDAL.LayDuLieu("MATHANG join CHITIETPHIEUXUAT on MATHANG.MaMatHang = CHITIETPHIEUXUAT.MaMatHang join DONVITINH on DONVITINH.MaDonViTinh = CHITIETPHIEUXUAT.MaDonViTinh", "MATHANG.MaMatHang", "TenMatHang", "SoLuongTon", "TenDonViTinh", "DonGia")
        'Dim dTable2 As DataTable = KetNoiDAL.LayDuLieu("DONVITINH", "TenDonViTinh", "") '
        'Dim dTable3 As DataTable = KetNoiDAL.LayDuLieu("CHITIETPHIEUXUAT", "DonGia", "") '

        Me.dgvDanhSachMatHang.DataSource = dTable1
        With Me.dgvDanhSachMatHang
            .Columns(0).HeaderText = "Mã mặt hàng"
            .Columns(1).HeaderText = "Tên mặt hàng"
            .Columns(2).HeaderText = "Số lượng tồn"
            .Columns(3).HeaderText = "Đơn vị tính"
            .Columns(4).HeaderText = "Đơn giá"

        End With

        'Me.dgvDanhSachMatHang.DataSource = dTable2
        'With Me.dgvDanhSachMatHang
        '    .Columns(3).HeaderText = "Đơn vị tính"
        'End With

        'Me.dgvDanhSachMatHang.DataSource = dTable3
        'With Me.dgvDanhSachMatHang
        '    .Columns(4).HeaderText = "Đơn giá"
        'End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMatHang.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaMatHang.Enabled = False
        btnCapNhatMatHang.Enabled = False
        txbMaMatHang.Text = KetNoiDAL.TaoKhoaChinh("MATHANG", "MaMatHang", "MH")
        cbDonViTinh.SelectedIndex = 0

        txbTenMatHang.ReadOnly = False
        txbSoLuongTon.ReadOnly = False
        txbDonGia.ReadOnly = False

        txbTenMatHang.Clear()
        txbSoLuongTon.Text = ""
        txbDonGia.Text = ""

    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Tiếp nhận đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    'Hien thi thong bao tu flyout
    Private Sub HienThiThongBao(ByVal thongbao As String)
        label.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        'If Not KiemTraQD Then
        '    HienThiThongBao("Vi phạm quy định về số đại lý tối đa trong quận. Vui lòng kiểm tra lại")
        'End If

        ''Kiem tra Dia chi hop le
        'If txbDiaChi.Text <> String.Empty Then
        '    Try
        '        txbDiaChi.Text = DaiLyBUS.GeoCodingExample(DaiLyDTO, txbDiaChi.Text)
        '        DaiLyDTO.DiaChi = txbDiaChi.Text
        '    Catch ex As Exception
        '        CoLoi = True
        '        MessageBox.Show("Địa chỉ không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
        '    End Try
        'End If

        ''Kiem tra Email hop le
        'If (txbEmail.Text <> String.Empty) Then
        '    If Not (DaiLyBUS.CheckEmailValidExample(DaiLyDTO, txbEmail.Text) And txbEmail.Text <> String.Empty) Then
        '        CoLoi = True
        '        'HienThiThongBao("Email không hợp lệ. Vui lòng kiểm tra lại")
        '        MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
        '    End If
        'End If

        ''Kiem tra so dien thoai hop le
        'If txbDienThoai.Text <> String.Empty Then
        '    If Not DaiLyBUS.CheckPhoneNumberValidExample(DaiLyDTO, txbDienThoai.Text) Then
        '        CoLoi = True
        '        MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
        '        'HienThiThongBao("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại")
        '    End If
        'End If

        'If KiemTraQD And Not CoLoi Then
        '    Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        '    If (rslt = DialogResult.Yes) Then
        '        'Ket noi du lieu giua text box va DTO
        '        DaiLyDTO.MaDaiLy = txbMaDaiLy.Text
        '        DaiLyDTO.TenDaiLy = txbTenMatHang.Text
        '        DaiLyDTO.DienThoai = txbDienThoai.Text
        '        DaiLyDTO.NgayTiepNhan = txbNgayTiepNhan.Text
        '        DaiLyDTO.Email = txbEmail.Text
        '        DaiLyDTO.DiaChi = txbDiaChi.Text
        '        DaiLyDTO.NoDaiLy = 0

        '        '  Xu ly ten quan va ten loai dai ly
        '        Dim maquan As String = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = N'" + cbQuan.SelectedItem + "'").Rows(0)(0)
        '        DaiLyDTO.MaQuan = maquan

        '        Dim maloaidaily As String = KetNoiDAL.LayDuLieu("LOAIDAILY", "MaLoaiDaiLy", "TenLoaiDaiLy = N'" + cbTenLoaiDaiLy.SelectedItem + "'").Rows(0)(0)
        '        DaiLyDTO.MaLoaiDaiLy = maloaidaily

        '        'Kiem tra thong tin da duoc nhap day du
        '        If DaiLyBUS.IsEmpty(DaiLyDTO) Then
        '            'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
        '            HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
        '        Else
        '            If trangthai = STATUS.THEM Then
        '                'Ghi xuong CSDL            
        '                Dim success As Boolean = MatHangDAL.ThemDuLieu(MatHangDTO)
        '                If success Then
        '                    HienThiThongBao("Thêm mặt hàng thành công")
        '                    LoadDataOnGridView()
        '                Else
        '                    HienThiThongBao("Thêm mặt hàng thất bại, vui lòng kiểm tra lại")
        '                    CoLoi = False
        '                End If
        '            ElseIf trangthai = STATUS.SUA Then
        '                DaiLyDAL.XoaDuLieu("MaDaiLy", DaiLyDTO.MaDaiLy)
        '                Dim success As Boolean = DaiLyDAL.ThemDuLieu(DaiLyDTO)
        '                If success Then
        '                    HienThiThongBao("Cập nhật mặt hàng thành công")
        '                    LoadDataOnGridView()
        '                Else
        '                    HienThiThongBao("Cập nhật mặt hàng thất bại, vui lòng kiểm tra lại")
        '                    CoLoi = False
        '                End If
        '            End If

        '        End If
        '    End If
        'End If

    End Sub

    Private Sub btnXoaMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaMatHang.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa mặt hàng", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim mamathang As String = dgvDanhSachMatHang.SelectedCells(0).OwningRow.Cells("MaMatHang").Value
            If MatHangDAL.XoaDuLieu("MaMatHang", mamathang.ToString()) Then
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

        'Bat read-only cho textbox
        txbTenMatHang.ReadOnly = True
        txbSoLuongTon.ReadOnly = True
        txbDonGia.ReadOnly = True

        'Binding du lieu len textbox
        txbMaMatHang.DataBindings.Clear()
        txbMaMatHang.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "MaMatHang")
        txbTenMatHang.DataBindings.Clear()
        txbTenMatHang.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "TenMatHang")
        'Dim madonvitinh As String = dgvDanhSachMatHang.Rows(e.RowIndex).Cells("MaDonViTinh").Value
        'cbDonViTinh.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("DONVITINH", "MaDonViTinh", madonvitinh, "TenDonViTinh")
        txbSoLuongTon.DataBindings.Clear()
        txbSoLuongTon.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "SoLuongTon")
        txbDonGia.DataBindings.Clear()
        'txbDonGia.DataBindings.Add("Text", dgvDanhSachMatHang.DataSource, "DonGia")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatMatHang.Enabled = True
        btnXoaMatHang.Enabled = True

    End Sub

    Private Sub CapNhatThongTin()
        dgSoMatHangToiDa.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(3)
        dgTongMatHang.Text = KetNoiDAL.LayDuLieu("MATHANG", "MaMatHang", "").Rows.Count
    End Sub

    Private Sub btnCapNhatMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatMatHang.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Tat read-only de chinh sua
        btnXacNhan.Enabled = True
        btnXoaMatHang.Enabled = False
        btnCapNhatMatHang.Enabled = False
    End Sub
End Class