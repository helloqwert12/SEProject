Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class DonViTinh
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS
    Private _DBAcess As KetNoiDAL
    Dim donvitinhDTO As DonViTinhDTO
    Dim donvitinhBUS As donvitinhBUS
    Dim donvitinhDAL As DonViTinhDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        donvitinhDAL = New DonViTinhDAL()
        donvitinhBUS = New donvitinhBUS()
        donvitinhDTO = New DonViTinhDTO()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("DONVITINH")

        Me.dgvDonViTinh.DataSource = dTable
        With Me.dgvDonViTinh
            .Columns(0).HeaderText = "Mã đơn vị tính"
            .Columns(1).HeaderText = "Tên đơn vị tính"
            .Columns(1).Width = 133
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemDonViTinh.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaDonViTinh.Enabled = False
        btnCapNhatDonViTinh.Enabled = False
        txbMaDonViTinh.Text = KetNoiDAL.TaoKhoaChinh("DONVITINH", "MaDonViTinh", "DV")

        txbTenDonViTinh.Enabled = True

        txbTenDonViTinh.Clear()

    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Đơn vị tính?", "XÁC NHẬN", MessageBoxButtons.YesNo)
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
            donvitinhDTO.MaDonViTinh = txbMaDonViTinh.Text
            donvitinhDTO.TenDonViTinh = txbTenDonViTinh.Text

            'Kiem tra thong tin da duoc nhap day du
            If donvitinhBUS.IsEmpty(donvitinhDTO) Then
                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
            Else
                If trangthai = STATUS.THEM Then
                    'Ghi xuong CSDL            
                    Dim success As Boolean = donvitinhDAL.ThemDuLieu(donvitinhDTO)
                    If success Then
                        HienThiThongBao("Thêm đơn vị tính thành công")
                        txbTenDonViTinh.Enabled = False
                        LoadDataOnGridView()
                    Else
                        txbTenDonViTinh.Enabled = False
                        HienThiThongBao("Thêm đơn vị tính thất bại, vui lòng kiểm tra lại")
                    End If
                ElseIf trangthai = STATUS.SUA Then
                    donvitinhDAL.XoaDuLieu("MaDonViTinh", donvitinhDTO.MaDonViTinh)
                    Dim success As Boolean = donvitinhDAL.ThemDuLieu(donvitinhDTO)
                    If success Then
                        HienThiThongBao("Cập nhật đơn vị tính thành công")
                        txbTenDonViTinh.Enabled = False
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật đơn vị tính thất bại, vui lòng kiểm tra lại")
                        txbTenDonViTinh.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnXoaDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaDonViTinh.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa loại đại lý", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim madonvitinh As String = dgvDonViTinh.SelectedCells(0).OwningRow.Cells("MaDonViTinh").Value
            If donvitinhDAL.XoaDuLieu("MaDonViTinh", madonvitinh.ToString()) Then
                HienThiThongBao("Xóa đơn vị tính thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa đơn vị tính, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvDonViTinh_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonViTinh.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaDonViTinh.DataBindings.Clear()
        txbMaDonViTinh.DataBindings.Add("Text", dgvDonViTinh.DataSource, "MaDonViTinh")
        txbTenDonViTinh.DataBindings.Clear()
        txbTenDonViTinh.DataBindings.Add("Text", dgvDonViTinh.DataSource, "TenDonViTinh")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatDonViTinh.Enabled = True
        btnXoaDonViTinh.Enabled = True
    End Sub
    Private Sub CapNhatThongTin()
        dgSoDonViTinh.Text = KetNoiDAL.LayDuLieu("DONVITINH", "MaDonViTinh", "").Rows.Count
    End Sub
    Private Sub btnCapNhatDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatDonViTinh.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Bat Enabled de chinh sua
        txbTenDonViTinh.Enabled = True
    End Sub
End Class