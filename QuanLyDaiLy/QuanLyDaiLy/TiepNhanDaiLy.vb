Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class TiepNhanDaiLy
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS
    Private KiemTraQD As Boolean
    Private CoLoi As Boolean = False
    Dim dailyDTO As DaiLyDTO
    Dim dailyBUS As DaiLyBUS
    Dim dailyDAL As DaiLyDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        dailyDTO = New DaiLyDTO()
        dailyBUS = New DaiLyBUS()
        dailyDAL = New DaiLyDAL()

        'Load du lieu tu bang QUAN
        Dim data As DataTable = KetNoiDAL.LayDuLieu("QUAN", "TenQuan", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbQuan.Items.Add(str)
        Next

        'Load du lieu tu bang LOAIDAILY
        data = KetNoiDAL.LayDuLieu("LOAIDAILY", "TenLoaiDaiLy", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbTenLoaiDaiLy.Items.Add(str)
        Next

        LoadDataOnGridView()
    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("DAILY")
        Me.dgvTiepNhanDaiLy.DataSource = dTable
        With Me.dgvTiepNhanDaiLy
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Mã loại đại lý"
            .Columns(2).HeaderText = "Tên đại lý"
            .Columns(3).HeaderText = "Điện thoại"
            .Columns(4).HeaderText = "Địa chỉ"
            .Columns(5).HeaderText = "Mã quận"
            .Columns(6).HeaderText = "Ngày tiếp nhận"
            .Columns(7).HeaderText = "E-mail"
            .Columns(8).HeaderText = "Nợ đại lý"
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemDaiLy.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaDaiLy.Enabled = False
        btnCapNhatDaiLy.Enabled = False
        txbMaDaiLy.Text = KetNoiDAL.TaoKhoaChinh("DAILY", "MaDaiLy", "DL")
        txbNgayTiepNhan.Text = Date.Now.ToShortDateString
        cbQuan.SelectedIndex = 0
        cbTenLoaiDaiLy.SelectedIndex = 0

        txbTenDaiLy.Enabled = True
        txbDienThoai.Enabled = True
        txbEmail.Enabled = True
        txbDiaChi.Enabled = True
        cbQuan.Enabled = True
        cbTenLoaiDaiLy.Enabled = True

        txbTenDaiLy.Clear()
        txbEmail.Clear()
        txbDienThoai.Clear()
        txbDiaChi.Clear()
    End Sub
    'Kiem tra xem trong Quan nay da du so luong dai ly toi da hay chua
    Private Sub cbQuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuan.SelectedIndexChanged
        'Dim data As DataTable = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = " + "'" + cbQuan.SelectedItem + "'")
        Dim maquan As String = KetNoiDAL.ChuyenTenThanhMa("QUAN", "TenQuan", cbQuan.SelectedItem, "MaQuan") 'data.Rows(0)(0)
        If Not dailyBUS.ThoaManDaiLyToiDa(maquan) Then
            HienThiThongBao("Quận đã đủ số lượng đại lý tối đa")
            KiemTraQD = False
        Else
            KiemTraQD = True
        End If
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Tiếp nhận đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            'Dim menu As Menu = New Menu()
            'Me.Dispose()
            'menu.btnMenu.Show()
            Application.Exit()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fpnlNote.HidePopup()
        Timer1.Enabled = False
    End Sub

    'Hien thi thong bao tu flyout
    Private Sub HienThiThongBao(ByVal thongbao As String)
        lblThongbao.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btnXacNhan_Click(sender As Object, e As EventArgs) Handles btnXacNhan.Click
        If Not KiemTraQD Then
            HienThiThongBao("Vi phạm quy định về số đại lý tối đa trong quận. Vui lòng kiểm tra lại")
        End If

        'Kiem tra Dia chi hop le
        If txbDiaChi.Text <> String.Empty Then
            Try
                txbDiaChi.Text = dailyBUS.GeoCodingExample(dailyDTO, txbDiaChi.Text)
                dailyDTO.DiaChi = txbDiaChi.Text
            Catch ex As Exception
                CoLoi = True
                MessageBox.Show("Địa chỉ không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
            End Try
        End If

        'Kiem tra Email hop le
        If (txbEmail.Text <> String.Empty) Then
            If Not (dailyBUS.CheckEmailValidExample(dailyDTO, txbEmail.Text) And txbEmail.Text <> String.Empty) Then
                CoLoi = True
                'HienThiThongBao("Email không hợp lệ. Vui lòng kiểm tra lại")
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
            End If
        End If

        'Kiem tra so dien thoai hop le
        If txbDienThoai.Text <> String.Empty Then
            If Not dailyBUS.CheckPhoneNumberValidExample(dailyDTO, txbDienThoai.Text) Then
                CoLoi = True
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                'HienThiThongBao("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại")
            End If
        End If

        If KiemTraQD And Not CoLoi Then
            Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
            If (rslt = DialogResult.Yes) Then
                'Ket noi du lieu giua text box va DTO
                dailyDTO.MaDaiLy = txbMaDaiLy.Text
                dailyDTO.TenDaiLy = txbTenDaiLy.Text
                dailyDTO.DienThoai = txbDienThoai.Text
                dailyDTO.NgayTiepNhan = txbNgayTiepNhan.Text
                dailyDTO.Email = txbEmail.Text
                dailyDTO.DiaChi = txbDiaChi.Text
                dailyDTO.NoDaiLy = 0

                '  Xu ly ten quan va ten loai dai ly
                Dim maquan As String = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = N'" + cbQuan.SelectedItem + "'").Rows(0)(0)
                dailyDTO.MaQuan = maquan

                Dim maloaidaily As String = KetNoiDAL.LayDuLieu("LOAIDAILY", "MaLoaiDaiLy", "TenLoaiDaiLy = N'" + cbTenLoaiDaiLy.SelectedItem + "'").Rows(0)(0)
                dailyDTO.MaLoaiDaiLy = maloaidaily

                'Kiem tra thong tin da duoc nhap day du
                If dailyBUS.IsEmpty(dailyDTO) Then
                    'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                    HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
                Else
                    If trangthai = STATUS.THEM Then
                        'Ghi xuong CSDL            
                        Dim success As Boolean = dailyDAL.ThemDuLieu(dailyDTO)
                        If success Then
                            HienThiThongBao("Thêm đại lý thành công")
                            LoadDataOnGridView()
                        Else
                            HienThiThongBao("Thêm đại lý thất bại, vui lòng kiểm tra lại")
                            CoLoi = False
                        End If
                    ElseIf trangthai = STATUS.SUA Then
                        dailyDAL.XoaDuLieu("MaDaiLy", dailyDTO.MaDaiLy)
                        Dim success As Boolean = dailyDAL.ThemDuLieu(dailyDTO)
                        If success Then
                            HienThiThongBao("Cập nhật đại lý thành công")
                            LoadDataOnGridView()
                        Else
                            HienThiThongBao("Cập nhật đại lý thất bại, vui lòng kiểm tra lại")
                            CoLoi = False
                        End If
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub btnXoaDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaDaiLy.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa đại lý", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim madaily As String = dgvTiepNhanDaiLy.SelectedCells(0).OwningRow.Cells("MaDaiLy").Value
            If dailyDAL.XoaDuLieu("MaDaiLy", madaily.ToString()) Then
                HienThiThongBao("Xóa đại lý thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa đại lý, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvTiepNhanDaiLy_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTiepNhanDaiLy.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI
        'Bat read-only cho textbox
        txbTenDaiLy.Enabled = False
        txbDienThoai.Enabled = False
        txbEmail.Enabled = False
        txbDiaChi.Enabled = False
        cbQuan.Enabled = False
        cbTenLoaiDaiLy.Enabled = False

        'Binding du lieu len textbox
        txbMaDaiLy.DataBindings.Clear()
        txbMaDaiLy.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "MaDaiLy")
        txbTenDaiLy.DataBindings.Clear()
        txbTenDaiLy.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "TenDaiLy")
        Dim maquan As String = dgvTiepNhanDaiLy.Rows(e.RowIndex).Cells("MaQuan").Value
        cbQuan.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("QUAN", "MaQuan", maquan, "TenQuan")
        Dim maloaidaily As String = dgvTiepNhanDaiLy.Rows(e.RowIndex).Cells("MaLoaiDaiLy").Value
        cbTenLoaiDaiLy.SelectedItem = KetNoiDAL.ChuyenMaThanhTen("LOAIDAILY", "MaLoaiDaiLy", maloaidaily, "TenLoaiDaiLy")
        txbDienThoai.DataBindings.Clear()
        txbDienThoai.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "DienThoai")
        txbEmail.DataBindings.Clear()
        txbEmail.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "Email")
        txbDiaChi.DataBindings.Clear()
        txbDiaChi.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "DiaChi")
        txbNgayTiepNhan.DataBindings.Clear()
        txbNgayTiepNhan.DataBindings.Add("Text", dgvTiepNhanDaiLy.DataSource, "NgayTiepNhan")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatDaiLy.Enabled = True
        btnXoaDaiLy.Enabled = True
    End Sub

    Private Sub CapNhatThongTin()
        dgSoDaiLyToiDa.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(0)
        lblQuan.Text = cbQuan.SelectedItem
        dgSoDaiLyCuaQuan.Text = dailyBUS.SoDaiLyCuaQuan(KetNoiDAL.ChuyenTenThanhMa("QUAN", "TenQuan", cbQuan.SelectedItem, "MaQuan"))
        dgTongDaiLy.Text = dailyDAL.LayDuLieu("MaDaiLy", "").Rows.Count
    End Sub

    Private Sub btnCapNhatDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatDaiLy.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Tat read-only de chinh sua
        txbTenDaiLy.Enabled = True
        txbDienThoai.Enabled = True
        txbEmail.Enabled = True
        txbDiaChi.Enabled = True
        cbQuan.Enabled = True
        cbTenLoaiDaiLy.Enabled = True
    End Sub
End Class