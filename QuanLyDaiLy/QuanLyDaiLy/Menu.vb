Public Class Menu
    Public Sub New()
        InitializeComponent()
        If (IsMdiChild = True) Then
            MenuToolStripMenuItem.Enabled = False
        Else
            MenuToolStripMenuItem.Enabled = True
        End If
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.IsMdiContainer = True
        rmMenu.ShowPopup(btnMenu.Location)
    End Sub

    Private Sub btnDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDaiLy.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As TiepNhanDaiLy = New TiepNhanDaiLy()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnMatHang_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMatHang.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As MatHang = New MatHang()
        mdiChild.MdiParent = Me
        mdiChild.Visible = True
        mdiChild.Show()
    End Sub

    Private Sub btnQuan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuan.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As Quan = New Quan()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnLoaiDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoaiDaiLy.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As LoaiDaiLy = New LoaiDaiLy()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnDonViTinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDonViTinh.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As DonViTinh = New DonViTinh()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnQuyDinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuyDinh.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As ThayDoiQuyDinh = New ThayDoiQuyDinh()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnTraCuuDaiLy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTraCuuDaiLy.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As TraCuuDaiLy = New TraCuuDaiLy()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnLapPhieuThu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapPhieuThu.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As LapPhieuThuTien = New LapPhieuThuTien()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnLapPhieuXuat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapPhieuXuat.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As LapPhieuXuatHang = New LapPhieuXuatHang()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnBaoCaoDoanhSo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaoCaoDoanhSo.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As BaoCaoDoanhSo = New BaoCaoDoanhSo()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub btnBaoCaoCongNo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBaoCaoCongNo.ItemClick
        btnMenu.Hide()
        rmMenu.HidePopup()
        Dim mdiChild As BaoCaoCongNo = New BaoCaoCongNo()
        mdiChild.MdiParent = Me
        mdiChild.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        rmMenu.ShowPopup(btnMenu.Location)
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát chương trình Quản lí đại lý?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Me.Dispose()
            Application.Exit()
        End If
    End Sub
End Class