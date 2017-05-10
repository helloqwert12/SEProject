'Imports DTO.QuanLyDaiLyDTO
'Imports DAL.QuanLyDaiLyDAL
'Imports BUS.QuanLyDaiLyBUS
'Public Class LapPhieuXuatHang
'    Private _DBAcess As KetNoiDAL
'    Dim dailyDTO As DaiLyDTO
'    Dim dailyBUS As DaiLyBUS
'    Dim dailyDAL As DaiLyDAL
'    Public Sub New()
'        InitializeComponent()

'        KetNoiDAL.TaoKetNoi()
'        KetNoiDAL.MoKetNoi()
'        'Khoi tao DTO BUS DAL
'        dailyDTO = New DaiLyDTO()
'        dailyBUS = New DaiLyBUS()
'        dailyDAL = New DaiLyDAL()

'        'Load du lieu tu bang DAILY
'        Dim data As DataTable = KetNoiDAL.LayDuLieu("DAILY", "MaDaiLy", "")
'        For i = 0 To data.Rows.Count - 1
'            Dim str As String = data.Rows(i)(0)
'            cbMaDaiLy.Items.Add(str)
'        Next
'        cbMaDaiLy.SelectedIndex = 0

'        'Load du lieu tu bang DAILY
'        data = KetNoiDAL.LayDuLieu("DAILY", "TenDaiLy", "")
'        For i = 0 To data.Rows.Count - 1
'            Dim str As String = data.Rows(i)(0)
'            'txbTenDaiLy.
'            'txbTenDaiLy.Items.Add(str)
'        Next
'        cbDonViTinh.SelectedIndex = 0

'        'Load du lieu tu bang DONVITINH
'        data = KetNoiDAL.LayDuLieu("DONVITINH", "TenDonViTinh", "")
'        For i = 0 To data.Rows.Count - 1
'            Dim str As String = data.Rows(i)(0)
'            cbDonViTinh.Items.Add(str)
'        Next
'        cbDonViTinh.SelectedIndex = 0
'    End Sub
'    'Dinh nghia thu tuc load du lieu tu bang theo tung lop vao Gridview
'    Private Sub LoadDataOnGridView()
'        Dim dTable As DataTable = KetNoiDAL.LayDuLieu("DAILY")
'        Me.dgvTiepNhanDaiLy.DataSource = dTable
'        With Me.dgvTiepNhanDaiLy
'            .Columns(0).HeaderText = "Mã đại lý"
'            .Columns(1).HeaderText = "Mã loại đại lý"
'            .Columns(2).HeaderText = "Tên đại lý"
'            .Columns(3).HeaderText = "Điện thoại"
'            .Columns(4).HeaderText = "Địa chỉ"
'            .Columns(5).HeaderText = "Mã quận"
'            .Columns(6).HeaderText = "Ngày tiếp nhận"
'            .Columns(7).HeaderText = "E-mail"
'            .Columns(8).HeaderText = "Nợ đại lý"
'        End With
'        'KetNoiDAL.NgatKetNoi()
'    End Sub

'    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        LoadDataOnGridView()
'    End Sub

'    Private Sub btnThemDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemPhieuXuat.ItemClick
'        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thêm đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
'        If (rslt = DialogResult.Yes) Then
'            'Ket noi du lieu giua text box va DTO
'            'daily.MaDaiLy = 'GenerateKey cho ma dai ly
'            'dailyDTO.NgayTiepNhan = 'Cap nhat ngay hien hanh he thong
'            dailyDTO.TenDaiLy = txbTenDaiLy.Text
'            dailyDTO.DienThoai = txbTenMatHang.Text
'            dailyDTO.Email = txbSoLuong.Text
'            dailyDTO.DiaChi = txbDonGia.Text

'            'Kiem tra tinh hop le cua du lieu
'            If dailyBUS.IsEmpty(dailyDTO) Then
'                HienThiThongBao("Dữ liệu chưa được nhập đầy đủ. Vui lòng kiểm tra lại")
'            End If

'            'Ghi xuong CSDL            
'            Dim success As Boolean = dailyDAL.ThemDuLieu(dailyDTO)
'            If success Then
'                HienThiThongBao("Thêm phiếu xuất thành công")
'                LoadDataOnGridView()
'            Else
'                HienThiThongBao("Thêm phiếu xuất thất bại, vui lòng kiểm tra lại")
'            End If
'        End If
'    End Sub
'    'Kiem tra xem trong Quan nay da du so luong dai ly toi da hay chua
'    'Private Sub cbQuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuan.SelectedIndexChanged
'    '    Dim data As DataTable = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = " + "'" + cbQuan.SelectedItem + "'")
'    '    Dim maquan As String = data.Rows(0)(0)
'    '    If Not dailyBUS.ThoaManDaiLyToiDa(maquan) Then
'    '        HienThiThongBao("Quận đã đủ số lượng đại lý tối đa")
'    '    End If
'    'End Sub

'    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
'        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Lập phiếu xuất hàng?", "XÁC NHẬN", MessageBoxButtons.YesNo)
'        If rslt = DialogResult.Yes Then
'            Application.Exit()
'        End If
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        fpnlNote.HidePopup()
'        Timer1.Enabled = False
'    End Sub

'    'Hien thi thong bao tu flyout
'    Private Sub HienThiThongBao(ByVal thongbao As String)
'        label.Text = thongbao
'        fpnlNote.ShowPopup()
'        Timer1.Enabled = True
'        Timer1.Start()
'    End Sub
'End Class