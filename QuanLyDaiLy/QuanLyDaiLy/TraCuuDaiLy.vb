Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class TraCuuDaiLy
    Dim DaiLyDTO As DaiLyDTO
    Dim DaiLyBUS As DaiLyBUS
    Dim DaiLyDAL As DaiLyDAL

    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()
        'Khoi tao DTO BUS DAL
        DaiLyDTO = New DaiLyDTO()
        DaiLyBUS = New DaiLyBUS()
        DaiLyDAL = New DaiLyDAL()

        'Autocomplete cho Madaily
        Dim madaily As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(madaily, "DAILY", "MaDaiLy")

        With txbMaDaiLy
            .AutoCompleteCustomSource = madaily
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Autocomplete cho Tendaily
        Dim tendaily As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(tendaily, "DAILY", "TenDaiLy")

        With txbTenDaiLy
            .AutoCompleteCustomSource = tendaily
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Autocomplete cho Dienthoai
        Dim dienthoai As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(dienthoai, "DAILY", "DienThoai")

        With txbDienThoai
            .AutoCompleteCustomSource = dienthoai
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Autocomplete cho Ngaytiepnhan
        Dim ngaytiepnhan As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(ngaytiepnhan, "DAILY", "NgayTiepNhan")

        With txbNgayTiepNhan
            .AutoCompleteCustomSource = ngaytiepnhan
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Autocomplete cho Email
        Dim email As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(email, "DAILY", "Email")

        With txbEmail
            .AutoCompleteCustomSource = email
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Autocomplete cho Diachi
        Dim diachi As New AutoCompleteStringCollection()
        KetNoiDAL.LayDuLieuAutoComplete(diachi, "DAILY", "DiaChi")

        With txbDiaChi
            .AutoCompleteCustomSource = diachi
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

        'Load du lieu tu bang LOAIDAILY
        Dim data As DataTable = KetNoiDAL.LayDuLieu("LOAIDAILY", "TenLoaiDaiLy", "")
        For i = 0 To data.Rows.Count - 1
            Dim str As String = data.Rows(i)(0)
            cbTenLoaiDaiLy.Items.Add(str)
        Next

        txbTienNo.Text = 0
    End Sub

    Private Sub LoadDataOnGridView(ByVal data As DataTable)

        Me.dgvTiepNhanDaiLy.DataSource = data
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

    Private Sub btnTraCuu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTraCuu.ItemClick

        'Kiem tra Dia chi hop le
        If txbDiaChi.Text <> String.Empty Then
            Try
                txbDiaChi.Text = DaiLyBUS.GeoCodingExample(DaiLyDTO, txbDiaChi.Text)
                DaiLyDTO.DiaChi = txbDiaChi.Text
            Catch ex As Exception
                MessageBox.Show("Địa chỉ không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
            End Try
        End If

        'Kiem tra Email hop le
        If (txbEmail.Text <> String.Empty) Then
            If Not (DaiLyBUS.CheckEmailValidExample(DaiLyDTO, txbEmail.Text) And txbEmail.Text <> String.Empty) Then
                'HienThiThongBao("Email không hợp lệ. Vui lòng kiểm tra lại")
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
            End If
        End If

        'Kiem tra so dien thoai hop le
        If txbDienThoai.Text <> String.Empty Then
            If Not DaiLyBUS.CheckPhoneNumberValidExample(DaiLyDTO, txbDienThoai.Text) Then
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại", "XÁC NHẬN", MessageBoxButtons.OK)
                'HienThiThongBao("Số điện thoại không hợp lệ. Vui lòng kiểm tra lại")
            End If
        End If


        Dim rslt As DialogResult = MessageBox.Show("Xác nhận?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If (rslt = DialogResult.Yes) Then
            dgvTiepNhanDaiLy.DataSource = Nothing

            'Ket noi du lieu giua text box va DTO
            DaiLyDTO.MaDaiLy = txbMaDaiLy.Text
            DaiLyDTO.TenDaiLy = txbTenDaiLy.Text
            DaiLyDTO.DienThoai = txbDienThoai.Text
            If Not txbNgayTiepNhan.Text = "" Then
                DaiLyDTO.NgayTiepNhan = txbNgayTiepNhan.Text
            Else
                DaiLyDTO.NgayTiepNhan = Nothing
            End If

            DaiLyDTO.Email = txbEmail.Text
            DaiLyDTO.DiaChi = txbDiaChi.Text
            DaiLyDTO.NoDaiLy = txbTienNo.Text

            '  Xu ly ten quan va ten loai dai ly
            If Not cbQuan.SelectedItem Is Nothing Then
                Dim maquan As String = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "TenQuan = N'" + cbQuan.SelectedItem + "'").Rows(0)(0)
                DaiLyDTO.MaQuan = maquan
            End If

            If Not cbTenLoaiDaiLy.SelectedItem Is Nothing Then
                Dim maloaidaily As String = KetNoiDAL.LayDuLieu("LOAIDAILY", "MaLoaiDaiLy", "TenLoaiDaiLy = N'" + cbTenLoaiDaiLy.SelectedItem + "'").Rows(0)(0)
                DaiLyDTO.MaLoaiDaiLy = maloaidaily
            End If


            'Tra cuu
            Dim chuoiDk As String = String.Empty
            If Not DaiLyDTO.MaDaiLy = String.Empty Then
                chuoiDk += ("MaDaiLy = " + "'" + DaiLyDTO.MaDaiLy.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.TenDaiLy = String.Empty Then
                chuoiDk += ("TenDaiLy = " + "N'" + DaiLyDTO.TenDaiLy.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.DienThoai = String.Empty Then
                chuoiDk += ("DienThoai = " + "'" + DaiLyDTO.DienThoai.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.NgayTiepNhan = Date.MinValue Then
                chuoiDk += ("NgayTiepNhan = " + "'" + DaiLyDTO.NgayTiepNhan.ToShortDateString() + "'" + " and ")
            End If

            If Not DaiLyDTO.Email = String.Empty Then
                chuoiDk += ("Email = " + "'" + DaiLyDTO.Email.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.DiaChi = String.Empty Then
                chuoiDk += ("DiaChi = " + "N'" + DaiLyDTO.DiaChi.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.MaQuan Is Nothing Then
                chuoiDk += ("MaQuan = " + "'" + DaiLyDTO.MaQuan.ToString() + "'" + " and ")
            End If

            If Not DaiLyDTO.MaLoaiDaiLy Is Nothing Then
                chuoiDk += ("MaLoaiDaiLy = " + "'" + DaiLyDTO.MaLoaiDaiLy.ToString() + "'" + " and ")
            End If

            'Xu ly tien no
            If DaiLyDTO.NoDaiLy > 0 Then
                If cbSoSanh.SelectedIndex = 0 Then
                    chuoiDk += ("NoDaiLy = " + DaiLyDTO.NoDaiLy.ToString() + " and ")
                ElseIf cbSoSanh.SelectedIndex = 1 Then
                    chuoiDk += ("NoDaiLy > " + DaiLyDTO.NoDaiLy.ToString() + " and ")
                ElseIf cbSoSanh.SelectedIndex = 2 Then
                    chuoiDk += ("NoDaiLy < " + DaiLyDTO.NoDaiLy.ToString() + " and ")
                End If
            End If

            If DaiLyBUS.AllIsEmpty(DaiLyDTO) Then
                HienThiThongBao("Chưa nhập bất kỳ thông tin nào. Vui lòng kiểm tra lại")
            Else
                chuoiDk = chuoiDk.Remove(chuoiDk.Length - 4, 4)
                Dim data As DataTable = DaiLyDAL.LayDuLieu(chuoiDk)
                If (data.Rows.Count <= 0) Then
                    HienThiThongBao("Không tìm thấy kết quả nào")
                Else
                    LoadDataOnGridView(data)
                    HienThiThongBao("Có " + data.Rows.Count.ToString() + " kết quả được tìm thấy")
                End If
            End If

        End If
    End Sub

    Private Sub HienThiThongBao(ByVal thongbao As String)
        lblThongbao.Text = thongbao
        fpnlNote.ShowPopup()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub btsHienThiDayDu_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsHienThiDayDu.CheckedChanged
        If btsHienThiDayDu.Checked Then
            Dim data As DataTable = DaiLyDAL.LayDuLieu()
            HienThiThongBao("Có " + data.Rows.Count.ToString() + " kết quả được tìm thấy")
            LoadDataOnGridView(data)
        Else
            dgvTiepNhanDaiLy.DataSource = Nothing
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fpnlNote.HidePopup()
        Timer1.Enabled = False
    End Sub

    Private Sub btnXoaThongTin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoaThongTin.ItemClick
        txbMaDaiLy.Clear()
        txbTenDaiLy.Clear()
        txbDiaChi.Clear()
        txbDienThoai.Clear()
        txbEmail.Clear()
        txbNgayTiepNhan.Clear()
        txbTienNo.Text = 0
        cbQuan.SelectedIndex = -1
        cbTenLoaiDaiLy.SelectedIndex = -1
        cbSoSanh.SelectedIndex = -1
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Tra cứu đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class