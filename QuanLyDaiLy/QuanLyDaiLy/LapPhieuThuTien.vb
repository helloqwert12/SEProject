Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class LapPhieuThuTien
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS
    Dim phieuthutienDTO As PhieuThuTienDTO
    Dim phieuthutienBUS As PhieuThuTienBUS
    Dim phieuthutienDAL As PhieuThuTienDAL
    Dim baocaocongnoDAL As BaoCaoCongNoDAL
    Dim baocaocongnoDTO As BaoCaoCongNoDTO
    Dim dailyDTO As DaiLyDTO
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        dailyDTO = New DaiLyDTO()
        phieuthutienDTO = New phieuthutienDTO()
        phieuthutienBUS = New phieuthutienBUS()
        phieuthutienDAL = New PhieuThuTienDAL()
        baocaocongnoDTO = New BaoCaoCongNoDTO()
        baocaocongnoDAL = New BaoCaoCongNoDAL()

        'Load du lieu tu bang DAILY
        Dim data As DataTable = KetNoiDAL.LayDuLieu("DAILY", "TenDaiLy", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbDaiLy.Items.Add(str)
        Next
        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("DAILY join PHIEUTHUTIEN on DAILY.MaDaiLy = PHIEUTHUTIEN.MaDaiLy", "MaPhieuThu", "DAILY.MaDaiLy", "SoTienThu", "NgayThuTien", "DienThoai", "DiaChi", "Email")
        Me.dgvPhieuThuTien.DataSource = dTable
        With Me.dgvPhieuThuTien
            .Columns(0).HeaderText = "Mã phiếu thu"
            .Columns(1).HeaderText = "Mã đại lý"
            .Columns(2).HeaderText = "Số tiền thu"
            .Columns(3).HeaderText = "Ngày thu tiền"
            .Columns(4).HeaderText = "Điện thoại"
            .Columns(5).HeaderText = "Địa chỉ"
            .Columns(6).HeaderText = "E-mail"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemPhieuThuTien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemPhieuThuTien.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaPhieuThuTien.Enabled = False
        btnCapNhatPhieuThuTien.Enabled = False
        txbMaPhieuThu.Text = KetNoiDAL.TaoKhoaChinh("PHIEUTHUTIEN", "MaPhieuThu", "PT")
        txbNgayThuTien.Text = Date.Now.ToShortDateString
        cbDaiLy.SelectedIndex = 0

        cbDaiLy.Enabled = True
        txbSoTienThu.Enabled = True

        txbSoTienThu.Text = "0"
    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Phiếu thu tiền?", "XÁC NHẬN", MessageBoxButtons.YesNo)
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
    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If (rslt = DialogResult.Yes) Then
            If trangthai = STATUS.THEM Then
                'Ket noi du lieu giua text box va DTO
                phieuthutienDTO.MaPhieuThu = txbMaPhieuThu.Text
                phieuthutienDTO.NgayThuTien = txbNgayThuTien.Text
                phieuthutienDTO.SoTienThu = txbSoTienThu.Text

                '  Xu ly ten dai ly
                Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbDaiLy.SelectedItem, "MaDaiLy")
                phieuthutienDTO.MaDaiLy = madaily

                Dim tempNoDaiLy = dailyDTO.NoDaiLy
                dailyDTO.NoDaiLy = txbSoTienNo.Text - txbSoTienThu.Text

                'Kiem tra thong tin da duoc nhap day du
                If phieuthutienBUS.IsEmpty(phieuthutienDTO) Then
                    'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                    HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
                Else
                    'Ghi xuong CSDL    
                    Dim success1 As Boolean = phieuthutienBUS.XuLiQuyDinh(phieuthutienDTO, dailyDTO.NoDaiLy)
                    If success1 Then
                        KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily, "NoDaiLy = " + dailyDTO.NoDaiLy.ToString())
                        Dim success2 As Boolean = phieuthutienDAL.ThemDuLieu(phieuthutienDTO)
                        If success2 Then
                            'Ket noi toi DTO cua BaoCaoCongNo
                            baocaocongnoDTO.MaDaiLy = madaily
                            baocaocongnoDTO.MaBaoCaoCongNo = KetNoiDAL.TaoKhoaChinh("BAOCAOCONGNO", "MaBaoCaoCongNo", "")
                            baocaocongnoDTO.Thang = KetNoiDAL.LayDuLieu("PHIEUTHUTIEN", "Month(NgayThuTien)", "MaDaiLy = '" + madaily + "'").Rows(0)(0)
                            baocaocongnoDTO.NoDau = tempNoDaiLy
                            baocaocongnoDTO.PhatSinh = txbSoTienThu.Text
                            baocaocongnoDTO.NoCuoi = dailyDTO.NoDaiLy
                            baocaocongnoDAL.ThemDuLieu(baocaocongnoDTO)

                            HienThiThongBao("Thêm phiếu thu tiền thành công")
                            LoadDataOnGridView()
                        Else
                            HienThiThongBao("Thêm phiếu thu tiền thất bại, vui lòng kiểm tra lại")
                        End If
                    Else
                        dailyDTO.NoDaiLy = tempNoDaiLy
                        HienThiThongBao("Vị phạm quy định số tiền nợ, vui lòng kiểm tra lại")
                    End If
                End If
                txbSoTienThu.Enabled = False
                cbDaiLy.Enabled = False
            ElseIf trangthai = STATUS.SUA Then
                '    Dim sotienthu As Long = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("SoTienThu").Value
                '    Dim madaily1 As String = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("MaDaiLy").Value
                '    phieuthutienDAL.CapNhatDuLieu("MaDaiLy", madaily1, "SoTienThu = " + txbSoTienThu.Text)
                '    dailyDTO.NoDaiLy = txbSoTienNo.Text - txbSoTienThu.Text + sotienthu
                '    Dim success1 As Boolean = phieuthutienBUS.XuLiQuyDinh(phieuthutienDTO, dailyDTO.NoDaiLy)
                '    If success1 Then
                '        Dim success2 As Boolean = KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily1, "NoDaiLy = " + dailyDTO.NoDaiLy.ToString())
                '        If success2 Then
                '            HienThiThongBao("Cập nhật phiếu thu tiền thành công")
                '            LoadDataOnGridView()
                '        Else
                '            HienThiThongBao("Cập nhật phiếu thu tiền thất bại, vui lòng kiểm tra lại")
                '        End If
                '    Else
                '        HienThiThongBao("Vị phạm quy định số tiền nợ, vui lòng kiểm tra lại")
                '    End If
                'End If
                'Số tiền nợ được phục hồi khi xóa phiếu thu
                Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbDaiLy.SelectedItem, "MaDaiLy")
                Dim sotienthu As Long = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("SoTienThu").Value
                Dim str As Long = txbSoTienNo.Text + sotienthu
                KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily, "NoDaiLy = " + str.ToString())
                Dim maphieuthu As String = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("MaPhieuThu").Value
                phieuthutienDAL.XoaDuLieu("MaPhieuThu", maphieuthu.ToString())
                dailyDTO.NoDaiLy = str - txbSoTienThu.Text
                Dim success1 As Boolean = phieuthutienBUS.XuLiQuyDinh(phieuthutienDTO, dailyDTO.NoDaiLy)
                If success1 Then

                    'Ket noi du lieu giua text box va DTO
                    phieuthutienDTO.MaPhieuThu = txbMaPhieuThu.Text
                    phieuthutienDTO.NgayThuTien = txbNgayThuTien.Text
                    phieuthutienDTO.SoTienThu = txbSoTienThu.Text
                    phieuthutienDTO.MaDaiLy = madaily

                    KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily, "NoDaiLy = " + dailyDTO.NoDaiLy.ToString())
                    Dim success2 As Boolean = phieuthutienDAL.ThemDuLieu(phieuthutienDTO)
                    If success2 Then
                        HienThiThongBao("Cập nhật phiếu thu tiền thành công")
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật phiếu thu tiền thất bại, vui lòng kiểm tra lại")
                    End If
                Else
                    HienThiThongBao("Vị phạm quy định số tiền nợ, vui lòng kiểm tra lại")
                End If
            End If
            txbSoTienThu.Enabled = False
            cbDaiLy.Enabled = False
        End If
    End Sub

    Private Sub btnXoaPhieuThuTien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaPhieuThuTien.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa phiếu thu tiền", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            'Số tiền nợ được phục hồi khi xóa phiếu thu
            Dim sotienthu As Long = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("SoTienThu").Value
            Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbDaiLy.SelectedItem, "MaDaiLy")
            Dim str As Long = txbSoTienNo.Text + sotienthu
            KetNoiDAL.CapNhatDuLieu("DAILY", "MaDaiLy", madaily, "NoDaiLy = " + str.ToString())

            Dim maphieuthu As String = dgvPhieuThuTien.SelectedCells(0).OwningRow.Cells("MaPhieuThu").Value
            If phieuthutienDAL.XoaDuLieu("MaPhieuThu", maphieuthu.ToString()) Then
                HienThiThongBao("Xóa phiếu thu tiền thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa phiếu thu tiền, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvPhieuThuTien_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuThuTien.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaPhieuThu.DataBindings.Clear()
        txbMaPhieuThu.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "MaPhieuThu")
        Dim madaily As String = dgvPhieuThuTien.Rows(e.RowIndex).Cells("MaDaiLy").Value
        cbDaiLy.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("DAILY", "MaDaiLy", madaily, "TenDaiLy")
        txbDienThoai.DataBindings.Clear()
        txbDienThoai.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "DienThoai")
        txbEmail.DataBindings.Clear()
        txbEmail.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "Email")
        txbDiaChi.DataBindings.Clear()
        txbDiaChi.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "DiaChi")
        txbNgayThuTien.DataBindings.Clear()
        txbNgayThuTien.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "NgayThuTien")
        txbSoTienThu.DataBindings.Clear()
        txbSoTienThu.DataBindings.Add("Text", dgvPhieuThuTien.DataSource, "SoTienThu")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatPhieuThuTien.Enabled = True
        btnXoaPhieuThuTien.Enabled = True
    End Sub

    Private Sub CapNhatThongTin()
        Dim count = 0
        Dim data As DataTable = KetNoiDAL.LayDuLieu("DAILY", "MaDaiLy", "")
        For i = 0 To data.Rows.Count - 1
            Dim nodaily As Long = KetNoiDAL.LayDuLieu("DAILY", "NoDaiLy", "MaDaiLy = '" + data.Rows(i)(0) + "'").Rows(0)(0)
            If (nodaily > 0) Then
                count += 1
            End If
        Next
        dgSoDaiLyConNo.Text = count
        lblDaiLy.Text = cbDaiLy.SelectedItem
        dgSoPhieuThuCuaDaiLy.Text = phieuthutienBUS.SoPhieuThuCuaDaiLy(KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbDaiLy.SelectedItem, "MaDaiLy"))
        dgTongPhieuThu.Text = phieuthutienDAL.LayDuLieu("MaPhieuThu", "").Rows.Count
        data = KetNoiDAL.LayDuLieu("THAMSO", "ApDung", "")
        If data.Rows(0)(0) = 0 Then
            dgApDung.Text = "KHONG"
        Else
            dgApDung.Text = "CO"
        End If
    End Sub

    Private Sub btnCapNhatPhieuThuTien_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatPhieuThuTien.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Tat read-only de chinh sua
        cbDaiLy.Enabled = True
        txbSoTienThu.Enabled = True
    End Sub

    Private Sub cbDaiLy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDaiLy.SelectedIndexChanged
        Dim madaily As String = KetNoiDAL.ChuyenTenThanhMa("DAILY", "TenDaiLy", cbDaiLy.SelectedItem, "MaDaiLy")
        Dim str As String

        Dim nodaily As DataTable = KetNoiDAL.LayDuLieu("DAILY", "NoDaiLy", "MaDaiLy = " + "'" + madaily + "'")
        str = nodaily.Rows(0)(0)
        txbSoTienNo.Text = str

        Dim dienthoai As DataTable = KetNoiDAL.LayDuLieu("DAILY", "DienThoai", "MaDaiLy = " + "'" + madaily + "'")
        str = dienthoai.Rows(0)(0)
        txbDienThoai.Text = str

        Dim email As DataTable = KetNoiDAL.LayDuLieu("DAILY", "email", "MaDaiLy = " + "'" + madaily + "'")
        str = email.Rows(0)(0)
        txbEmail.Text = str

        Dim diachi As DataTable = KetNoiDAL.LayDuLieu("DAILY", "DiaChi", "MaDaiLy = " + "'" + madaily + "'")
        str = diachi.Rows(0)(0)
        txbDiaChi.Text = str
    End Sub
End Class