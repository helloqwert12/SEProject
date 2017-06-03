Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class Quan
    Enum STATUS
        THEM
        XOA
        SUA
        HIENTHI
    End Enum

    Dim trangthai As STATUS

    Dim quanDTO As QuanDTO
    Dim quanBUS As QuanBUS
    Dim quanDAL As QuanDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        quanDAL = New QuanDAL()
        quanBUS = New QuanBUS()
        quanDTO = New QuanDTO()

        LoadDataOnGridView()

    End Sub
    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("QUAN")

        Me.dgvQuan.DataSource = dTable
        With Me.dgvQuan
            .Columns(0).HeaderText = "Mã quận"
            .Columns(1).HeaderText = "Tên quận"
            .Columns(1).Width = 115
        End With
        'KetNoiDAL.NgatKetNoi()
    End Sub
    Private Sub btnThemQuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemQuan.ItemClick
        trangthai = STATUS.THEM
        btnXacNhan.Enabled = True
        btnXoaQuan.Enabled = False
        btnCapNhatQuan.Enabled = False
        txbMaQuan.Text = KetNoiDAL.TaoKhoaChinh("QUAN", "MaQuan", "QU")

        txbTenQuan.Enabled = True

        txbTenQuan.Clear()

    End Sub
    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Quận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
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
            'Ket noi du lieu giua text box va DTO 
            quanDTO.MaQuan = txbMaQuan.Text
            quanDTO.TenQuan = txbTenQuan.Text

            'Kiem tra thong tin da duoc nhap day du
            If quanBUS.IsEmpty(quanDTO) Then
                'MessageBox.Show("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                HienThiThongBao("Chưa nhập đầy đủ thông tin, vui lòng kiểm tra lại")
            Else
                If trangthai = STATUS.THEM Then
                    'Ghi xuong CSDL            
                    Dim success As Boolean = quanDAL.ThemDuLieu(quanDTO)
                    If success Then
                        HienThiThongBao("Thêm quận thành công")
                        txbTenQuan.Enabled = False
                        LoadDataOnGridView()
                    Else
                        txbTenQuan.Enabled = False
                        HienThiThongBao("Thêm quận thất bại, vui lòng kiểm tra lại")
                    End If
                ElseIf trangthai = STATUS.SUA Then
                    quanDAL.XoaDuLieu("MaQuan", quanDTO.MaQuan)
                    Dim success As Boolean = quanDAL.ThemDuLieu(quanDTO)
                    If success Then
                        HienThiThongBao("Cập nhật quận thành công")
                        txbTenQuan.Enabled = False
                        LoadDataOnGridView()
                    Else
                        HienThiThongBao("Cập nhật quận thất bại, vui lòng kiểm tra lại")
                        txbTenQuan.Enabled = False
                    End If
                End If
            End If
            txbTenQuan.Enabled = False
        End If
    End Sub

    Private Sub btnXoaQuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaQuan.ItemClick
        trangthai = STATUS.XOA
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận xóa quận", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim maquan As String = dgvQuan.SelectedCells(0).OwningRow.Cells("MaQuan").Value
            If quanDAL.XoaDuLieu("MaQuan", maquan.ToString()) Then
                HienThiThongBao("Xóa quận thành công")
                LoadDataOnGridView()
            Else
                HienThiThongBao("Không thể xóa quận, vui lòng kiểm tra lại")
            End If
        End If
    End Sub
    Private Sub dgvQuan_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuan.RowEnter
        'Trang thai hien thi
        trangthai = STATUS.HIENTHI

        'Binding du lieu len textbox
        txbMaQuan.DataBindings.Clear()
        txbMaQuan.DataBindings.Add("Text", dgvQuan.DataSource, "MaQuan")
        txbTenQuan.DataBindings.Clear()
        txbTenQuan.DataBindings.Add("Text", dgvQuan.DataSource, "TenQuan")

        'Cap nhat cho khung Thong tin
        CapNhatThongTin()

        btnCapNhatQuan.Enabled = True
        btnXoaQuan.Enabled = True
    End Sub
    Private Sub CapNhatThongTin()
        dgSoQuan.Text = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "").Rows.Count
    End Sub
    Private Sub btnCapNhatQuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCapNhatQuan.ItemClick
        trangthai = STATUS.SUA

        btnXacNhan.Enabled = True
        'Bat Enabled de chinh sua
        txbTenQuan.Enabled = True
    End Sub
End Class