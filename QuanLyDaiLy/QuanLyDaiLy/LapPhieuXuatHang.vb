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
    Dim phieuxuatDTO As PhieuXuatDTO
    Dim phieuxuatBUS As PhieuXuatBUS
    Dim phieuxuatDAL As PhieuXuatDAL
    Dim chitietphieuxuatDTO As ChiTietPhieuXuatDTO
    Dim chitietphieuxuatBUS As ChiTietPhieuXuatBUS
    Dim chitietphieuxuatDAL As ChiTietPhieuXuatDAL
    Dim mathangDTO As MatHangDTO
    Dim mathangBUS As MatHangBUS
    Dim mathangDAL As MatHangDAL
    Dim dailyDTO As DaiLyDTO
    Dim loaidailyBUS As LoaiDaiLyBUS
    Dim temp As String = String.Empty
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
        dailyDTO = New DaiLyDTO()
        loaidailyBUS = New LoaiDaiLyBUS()

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
                                                     "PHIEUXUAT.MaPhieuXuat", "MaCTPhieuXuat", "MaDaiLy", "MaMatHang", "DonGia", "MaDonViTinh", "SoLuongXuat", "ThanhTien", "NgayLapPhieu")
        Me.dgvLapPhieuXuatHang.DataSource = dTable
        With Me.dgvLapPhieuXuatHang
            .Columns(0).HeaderText = "Mã phiếu xuất"
            .Columns(1).HeaderText = "Mã chi tiết phiếu xuất"
            .Columns(2).HeaderText = "Mã đại lý"
            .Columns(2).Width = 80
            .Columns(3).HeaderText = "Mã mặt hàng"
            .Columns(3).Width = 80
            .Columns(4).HeaderText = "Đơn giá"
            .Columns(5).HeaderText = "Mã Đơn vị tính"
            .Columns(5).Width = 110
            .Columns(6).HeaderText = "Số lượng xuất"
            .Columns(7).HeaderText = "Thành tiền"
            .Columns(8).HeaderText = "Ngày lập phiếu"
            .Columns(8).Width = 110
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemPhieuXuat.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaPhieuXuat.Enabled = False
        btnCapNhatPhieuXuat.Enabled = False
        txbMaPhieuXuat.Text = KetNoiDAL.TaoKhoaChinh("PHIEUXUAT", "MaPhieuXuat", "PX")
        temp = KetNoiDAL.TaoKhoaChinh("CHITIETPHIEUXUAT", "MaCTPhieuXuat", "CT")
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
            chitietphieuxuatDTO.MaCTPhieuXuat = temp
            chitietphieuxuatDTO.MaPhieuXuat = txbMaPhieuXuat.Text
            chitietphieuxuatDTO.MaMatHang = KetNoiDAL.ChuyenTenThanhMa("MATHANG", "TenMatHang", cbTenMatHang.Text, "MaMatHang")
            chitietphieuxuatDTO.MaDonViTinh = KetNoiDAL.ChuyenTenThanhMa("DONVITINH", "TenDonViTinh", cbDonViTinh.Text, "MaDonViTinh")
            chitietphieuxuatDTO.SoLuongXuat = txbSoLuongXuat.Text
            chitietphieuxuatDTO.DonGia = txbDonGia.Text
            chitietphieuxuatDTO.ThanhTien = txbDonGia.Text * txbSoLuongXuat.Text
            phieuxuatDTO.MaPhieuXuat = txbMaPhieuXuat.Text
            phieuxuatDTO.MaDaiLy = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbTenDaiLy.Text, "MaDaiLy")
            phieuxuatDTO.NgayLapPhieu = txbNgayLapPhieu.Text

            Dim tempTongTriGia As Long = txbTongTriGia.Text
            Dim tempTongTriGia2 As Long
            If (txbTongTriGia.Text = 0) Then
                phieuxuatDTO.TongTriGia = txbDonGia.Text * txbSoLuongXuat.Text
            Else
                phieuxuatDTO.TongTriGia += txbDonGia.Text * txbSoLuongXuat.Text
                tempTongTriGia2 = phieuxuatDTO.TongTriGia
            End If

            Dim data As DataTable = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "MaDaiLy = '" + phieuxuatDTO.MaDaiLy + "'")
            For i = 0 To data.Rows.Count - 1
                Dim str As String = data.Rows(i)(0)
                KetNoiDAL.CapNhatDuLieu("PHIEUXUAT", "MaPhieuXuat", str, "TongTriGia = " + tempTongTriGia2.ToString())
            Next
            'KetNoiDAL.CapNhatDuLieu("PHIEUXUAT", "MaDaiLy", phieuxuatDTO.MaDaiLy, phieuxuatDTO.TongTriGia = tempTongTriGia2)

            Dim tempSoLuongTon As Integer = txbSoLuongTon.Text
            KetNoiDAL.CapNhatDuLieu("MATHANG", "MaMatHang", chitietphieuxuatDTO.MaMatHang, "SoLuongTon = " + (txbSoLuongTon.Text - txbSoLuongXuat.Text).ToString())

            Dim tempNoDaiLy As Integer = txbNoDaiLy.Text
            Dim tam As Long = txbNoDaiLy.Text + chitietphieuxuatDTO.ThanhTien
            KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", phieuxuatDTO.MaDaiLy, "NoDaiLy = " + tam.ToString())

            'Kiem tra so luong ton co nho hon so luong xuat hay khong
            If mathangBUS.IsValid_SoLuongTon(mathangDTO) Then
                Dim maloaidaily As String = KetNoiDAL.LayDuLieu("DAILY", "MaLoaiDaiLy", "MaDaiLy = '" + phieuxuatDTO.MaDaiLy + "'").Rows(0)(0)
                'Kiem tra no dai ly co vuot qua no toi da cho phep hay khong
                If loaidailyBUS.KiemTraNoToiDa(maloaidaily, phieuxuatDTO.MaDaiLy) Then
                    'Kiem tra thong tin da duoc nhap day du
                    If chitietphieuxuatBUS.IsEmpty(chitietphieuxuatDTO, phieuxuatDTO) Then
                        'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                        HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
                    Else
                        If trangthai = STATUS.THEM Then
                            'Ghi xuong CSDL     

                            Dim success1 As Boolean = phieuxuatDAL.ThemDuLieu(phieuxuatDTO)
                            Dim success2 As Boolean = chitietphieuxuatDAL.ThemDuLieu(chitietphieuxuatDTO)
                            If success1 And success2 Then
                                HienThiThongBao("Thêm phiếu xuất thành công")
                                LoadDataOnGridView()
                            Else
                                HienThiThongBao("Thêm phiếu xuất thất bại, vui lòng kiểm tra lại")
                            End If
                        ElseIf trangthai = STATUS.SUA Then
                            chitietphieuxuatDAL.XoaDuLieu("MaPhieuXuat", chitietphieuxuatDTO.MaPhieuXuat)
                            phieuxuatDAL.XoaDuLieu("MaPhieuXuat", phieuxuatDTO.MaPhieuXuat)
                            Dim success1 As Boolean = phieuxuatDAL.ThemDuLieu(phieuxuatDTO)
                            Dim success2 As Boolean = chitietphieuxuatDAL.ThemDuLieu(chitietphieuxuatDTO)
                            If success1 And success2 Then
                                HienThiThongBao("Cập nhật phiếu xuất thành công")
                                LoadDataOnGridView()
                            Else
                                HienThiThongBao("Cập nhật phiếu xuất thất bại, vui lòng kiểm tra lại")
                            End If
                        End If
                    End If
                Else
                    HienThiThongBao("Nợ hiện tại không thể lớn hơn Nợ tối đa cho phép")
                    For i = 0 To data.Rows.Count - 1
                        Dim str As String = data.Rows(i)(0)
                        KetNoiDAL.CapNhatDuLieu("PHIEUXUAT", "MaPhieuXuat", str, "TongTriGia = " + tempTongTriGia.ToString())
                    Next
                    KetNoiDAL.CapNhatDuLieu("MATHANG", "MaMatHang", chitietphieuxuatDTO.MaMatHang, "SoLuongTon = " + tempSoLuongTon.ToString())
                    KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", phieuxuatDTO.MaDaiLy, "NoDaiLy = " + tempNoDaiLy.ToString())
                End If
            Else
                HienThiThongBao("Số lượng xuất không thể lớn hơn số lượng tồn của mặt hàng")
                For i = 0 To data.Rows.Count - 1
                    Dim str As String = data.Rows(i)(0)
                    KetNoiDAL.CapNhatDuLieu("PHIEUXUAT", "MaPhieuXuat", str, "TongTriGia = " + tempTongTriGia.ToString())
                Next
                KetNoiDAL.CapNhatDuLieu("MATHANG", "MaMatHang", chitietphieuxuatDTO.MaMatHang, "SoLuongTon = " + tempSoLuongTon.ToString())
                KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", phieuxuatDTO.MaDaiLy, "NoDaiLy = " + tempNoDaiLy.ToString())
            End If
            txbDonGia.Enabled = False
            txbSoLuongXuat.Enabled = False
            cbDonViTinh.Enabled = False
            cbTenDaiLy.Enabled = False
            cbTenMatHang.Enabled = False
        End If
    End Sub
    Private Sub btnXoaPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaPhieuXuat.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa phiếu xuất", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim madaily As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaDaiLy").Value
            Dim mamathang As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaMatHang").Value
            Dim mactphieuxuat As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaCTPhieuXuat").Value
            Dim maphieuxuat As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("MaPhieuXuat").Value
            Dim thanhtien As String = dgvLapPhieuXuatHang.SelectedCells(0).OwningRow.Cells("ThanhTien").Value

            'Số lượng tồn dc phục hồi nếu xóa phiếu xuất
            Dim str As String = Int16.Parse(txbSoLuongTon.Text) + Int16.Parse(txbSoLuongXuat.Text)
            KetNoiDAL.CapNhatDuLieu("MATHANG", "MaMatHang", mamathang, "SoLuongTon = " + str)

            'Tổng trị giá được phục hồi nếu xóa phiếu xuất
            Dim data As DataTable = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "MaDaiLy = '" + madaily + "'")
            For i = 0 To data.Rows.Count - 1
                Dim str1 As String = data.Rows(i)(0)
                KetNoiDAL.CapNhatDuLieu("PHIEUXUAT", "MaPhieuXuat", str1, "TongTriGia = TongTriGia -" + thanhtien)
            Next

            'Nợ đại lý được phục hồi nếu xóa phiếu xuất
            KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily, "NoDaiLy = NoDaiLy -" + thanhtien)

            If chitietphieuxuatDAL.XoaDuLieu("MaCTPhieuXuat", mactphieuxuat.ToString()) And phieuxuatDAL.XoaDuLieu("MaPhieuXuat", maphieuxuat.ToString()) Then
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
        lblDaiLy.Text = cbTenDaiLy.SelectedItem + ":    "
        Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbTenDaiLy.SelectedItem, "MaDaiLy")
        Dim maloaidaily As String = KetNoiDAL.LayDuLieu("DAILY", "MaLoaiDaiLy", "MaDaiLy = '" + madaily + "'").Rows(0)(0)
        dgSoPhieuXuatCuaDaiLy.Text = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "MaDaiLy = '" + madaily + "'").Rows.Count
        dgSoMatHang.Text = chitietphieuxuatDAL.LayDuLieu("MaMatHang", "").Rows.Count
        dgTongPhieuXuat.Text = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "").Rows.Count
    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Lập phiếu xuất hàng?", "XÁC NHẬN", MessageBoxButtons.YesNo)
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
        label.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnCapNhatPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatPhieuXuat.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Mo Enabled de chinh sua
        txbDonGia.Enabled = True
        txbSoLuongXuat.Enabled = True
        cbTenDaiLy.Enabled = True
        cbTenMatHang.Enabled = True
        cbDonViTinh.Enabled = True
    End Sub

    Private Sub cbTenDaiLy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTenDaiLy.SelectedIndexChanged
        Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbTenDaiLy.SelectedItem, "MaDaiLy")
        Dim str As String

        'Thông tin số phiếu xuất
        lblDaiLy.Text = cbTenDaiLy.SelectedItem + ":    "
        dgSoPhieuXuatCuaDaiLy.Text = phieuxuatDAL.LayDuLieu("MaPhieuXuat", "MaDaiLy = '" + madaily + "'").Rows.Count

        'Thông tin tổng trị giá
        Dim tongtrigia As DataTable = KetNoiDAL.LayDuLieu("PHIEUXUAT", "TongTriGia", "MaDaiLy = '" + madaily + "'")
        Try
            str = tongtrigia.Rows(0)(0)
            txbTongTriGia.Text = str
        Catch ex As Exception
            txbTongTriGia.Text = 0
        End Try

        'Thông tin Nợ hiện tại của đại lý
        Dim nodaily As DataTable = KetNoiDAL.LayDuLieu("DAILY", "NoDaiLy", "MaDaiLy = '" + madaily + "'")
        str = nodaily.Rows(0)(0)
        txbNoDaiLy.Text = str

        'Thông tin nợ tối đa của đại lý
        Dim maloaidaily As String = KetNoiDAL.LayDuLieu("DAILY", "MaLoaiDaiLy", "MaDaiLy = '" + madaily + "'").Rows(0)(0)
        txbNoToiDa.Text = KetNoiDAL.LayDuLieu("LOAIDAILY", "NoToiDa", "MaLoaiDaiLy = '" + maloaidaily + "'").Rows(0)(0)
    End Sub

    Private Sub cbTenMatHang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTenMatHang.SelectedIndexChanged
        Dim mamathang As String = KetNoiDAL.ChuyenTenThanhMa("MATHANG", "TenMatHang", cbTenMatHang.SelectedItem, "MaMatHang")
        Dim str As String

        Dim soluongton As DataTable = KetNoiDAL.LayDuLieu("MATHANG", "SoLuongTon", "MaMatHang = " + "'" + mamathang + "'")
        str = soluongton.Rows(0)(0)
        txbSoLuongTon.Text = str
    End Sub
End Class