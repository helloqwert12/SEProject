Public Class Menu
    Dim frmDaily As TiepNhanDaiLy
    Dim frmMathang As MatHang
    Dim frmQuan As Quan
    Dim frmLoaidaily As LoaiDaiLy
    Dim frmDonvitinh As DonViTinh
    Dim frmQuydinh As ThayDoiQuyDinh
    Dim frmTracuu As TraCuuDaiLy
    Dim frmPhieuthu As LapPhieuThuTien
    Dim frmPhiexuat As LapPhieuXuatHang
    Dim frmBCDoanhso As BaoCaoDoanhSo
    Dim frmBCCongno As BaoCaoCongNo

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.IsMdiContainer = True
        rmMenu.ShowPopup(btnMenu.Location)
    End Sub

    Private Sub btnDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDaiLy.ItemClick
        rmMenu.HidePopup()
        If frmDaily Is Nothing Then
            frmDaily = New TiepNhanDaiLy()
            frmDaily.MdiParent = Me
            frmDaily.Show()
        Else
            frmDaily.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMatHang.ItemClick

        rmMenu.HidePopup()
        If frmMathang Is Nothing Then
            frmMathang = New MatHang()
            frmMathang.MdiParent = Me
            frmMathang.Show()
        Else
            frmMathang.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnQuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuan.ItemClick
        rmMenu.HidePopup()
        If frmQuan Is Nothing Then
            frmQuan = New Quan()
            frmQuan.MdiParent = Me
            frmQuan.Show()
        Else
            frmQuan.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnLoaiDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoaiDaiLy.ItemClick
        rmMenu.HidePopup()
        If frmLoaidaily Is Nothing Then
            frmLoaidaily = New LoaiDaiLy()
            frmLoaidaily.MdiParent = Me
            frmLoaidaily.Show()
        Else
            frmLoaidaily.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDonViTinh.ItemClick
        rmMenu.HidePopup()
        If frmDonvitinh Is Nothing Then
            frmDonvitinh = New DonViTinh()
            frmDonvitinh.MdiParent = Me
            frmDonvitinh.Show()
        Else
            frmDonvitinh.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnQuyDinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuyDinh.ItemClick
        rmMenu.HidePopup()
        If frmQuydinh Is Nothing Then
            frmQuydinh = New ThayDoiQuyDinh()
            frmQuydinh.MdiParent = Me
            frmQuydinh.Show()
        Else
            frmQuydinh.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnTraCuuDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTraCuuDaiLy.ItemClick
        rmMenu.HidePopup()
        If frmTracuu Is Nothing Then
            frmTracuu = New TraCuuDaiLy()
            frmTracuu.MdiParent = Me
            frmTracuu.Show()
        Else
            frmTracuu.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnLapPhieuThu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapPhieuThu.ItemClick
        rmMenu.HidePopup()
        If frmPhieuthu Is Nothing Then
            frmPhieuthu = New LapPhieuThuTien()
            frmPhieuthu.MdiParent = Me
            frmPhieuthu.Show()
        Else
            frmPhieuthu.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnLapPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapPhieuXuat.ItemClick
        rmMenu.HidePopup()
        If frmPhiexuat Is Nothing Then
            frmPhiexuat = New LapPhieuXuatHang()
            frmPhiexuat.MdiParent = Me
            frmPhiexuat.Show()
        Else
            frmPhiexuat.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnBaoCaoDoanhSo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaoCaoDoanhSo.ItemClick
        rmMenu.HidePopup()
        If frmBCDoanhso Is Nothing Then
            frmBCDoanhso = New BaoCaoDoanhSo()
            frmBCDoanhso.MdiParent = Me
            frmBCDoanhso.Show()
        Else
            frmBCDoanhso.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnBaoCaoCongNo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaoCaoCongNo.ItemClick
        rmMenu.HidePopup()
        If frmBCCongno Is Nothing Then
            frmBCCongno = New BaoCaoCongNo()
            frmBCCongno.MdiParent = Me
            frmBCCongno.Show()
        Else
            frmBCCongno.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim rslt As DialogResult = MessageBox.Show("XÁC NHẬN THÁC", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class