<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnMenu = New DevExpress.XtraEditors.SimpleButton()
        Me.rmMenu = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.blLuuTru = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.blTraCuu = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.blTinhToan = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.blBaoBieu = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.btnDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMatHang = New DevExpress.XtraBars.BarButtonItem()
        Me.btnQuan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLoaiDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDonViTinh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnQuyDinh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTraCuuDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLapPhieuThu = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLapPhieuXuat = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBaoCaoDoanhSo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBaoCaoCongNo = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rmMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 397)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(769, 36)
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.blLuuTru, Me.blTraCuu, Me.blTinhToan, Me.blBaoBieu, Me.btnDaiLy, Me.btnMatHang, Me.btnQuan, Me.btnLoaiDaiLy, Me.btnDonViTinh, Me.btnQuyDinh, Me.btnTraCuuDaiLy, Me.btnLapPhieuThu, Me.btnLapPhieuXuat, Me.BarButtonItem1, Me.btnBaoCaoDoanhSo, Me.btnBaoCaoCongNo})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(769, 61)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnMenu
        '
        Me.btnMenu.Image = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnMenu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnMenu.Location = New System.Drawing.Point(298, 253)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(161, 116)
        Me.btnMenu.TabIndex = 2
        '
        'rmMenu
        '
        Me.rmMenu.InnerRadius = 0
        Me.rmMenu.ItemLinks.Add(Me.blLuuTru)
        Me.rmMenu.ItemLinks.Add(Me.blTraCuu)
        Me.rmMenu.ItemLinks.Add(Me.blTinhToan)
        Me.rmMenu.ItemLinks.Add(Me.blBaoBieu)
        Me.rmMenu.MenuColor = System.Drawing.Color.CornflowerBlue
        Me.rmMenu.Name = "rmMenu"
        Me.rmMenu.Ribbon = Me.RibbonControl
        '
        'blLuuTru
        '
        Me.blLuuTru.Caption = "LƯU TRỮ, CẬP NHẬT"
        Me.blLuuTru.Id = 1
        Me.blLuuTru.ImageUri.Uri = "CustomizeGrid"
        Me.blLuuTru.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDaiLy), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMatHang), New DevExpress.XtraBars.LinkPersistInfo(Me.btnQuan), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLoaiDaiLy), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDonViTinh), New DevExpress.XtraBars.LinkPersistInfo(Me.btnQuyDinh)})
        Me.blLuuTru.Name = "blLuuTru"
        '
        'blTraCuu
        '
        Me.blTraCuu.Caption = "TRA CỨU"
        Me.blTraCuu.Id = 2
        Me.blTraCuu.ImageUri.Uri = "Zoom"
        Me.blTraCuu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnTraCuuDaiLy)})
        Me.blTraCuu.Name = "blTraCuu"
        '
        'blTinhToan
        '
        Me.blTinhToan.Caption = "TÍNH TOÁN"
        Me.blTinhToan.Id = 3
        Me.blTinhToan.ImageUri.Uri = "Edit"
        Me.blTinhToan.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnLapPhieuThu), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLapPhieuXuat)})
        Me.blTinhToan.Name = "blTinhToan"
        '
        'blBaoBieu
        '
        Me.blBaoBieu.Caption = "BÁO BIỂU"
        Me.blBaoBieu.Id = 4
        Me.blBaoBieu.ImageUri.Uri = "InLineWithText"
        Me.blBaoBieu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBaoCaoDoanhSo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnBaoCaoCongNo)})
        Me.blBaoBieu.Name = "blBaoBieu"
        '
        'btnDaiLy
        '
        Me.btnDaiLy.Caption = "Đại Lý"
        Me.btnDaiLy.Id = 5
        Me.btnDaiLy.ImageUri.Uri = "Home"
        Me.btnDaiLy.Name = "btnDaiLy"
        '
        'btnMatHang
        '
        Me.btnMatHang.Caption = "Mặt Hàng"
        Me.btnMatHang.Id = 6
        Me.btnMatHang.ImageUri.Uri = "Find"
        Me.btnMatHang.Name = "btnMatHang"
        '
        'btnQuan
        '
        Me.btnQuan.Caption = "Quận"
        Me.btnQuan.Id = 7
        Me.btnQuan.ImageUri.Uri = "DayView"
        Me.btnQuan.Name = "btnQuan"
        '
        'btnLoaiDaiLy
        '
        Me.btnLoaiDaiLy.Caption = "Loại Đại Lý"
        Me.btnLoaiDaiLy.Id = 8
        Me.btnLoaiDaiLy.ImageUri.Uri = "ListNumbers"
        Me.btnLoaiDaiLy.Name = "btnLoaiDaiLy"
        '
        'btnDonViTinh
        '
        Me.btnDonViTinh.Caption = "Đơn Vị Tính"
        Me.btnDonViTinh.Id = 9
        Me.btnDonViTinh.ImageUri.Uri = "TimeLineView"
        Me.btnDonViTinh.Name = "btnDonViTinh"
        '
        'btnQuyDinh
        '
        Me.btnQuyDinh.Caption = "Thay Đổi Quy Định"
        Me.btnQuyDinh.Id = 10
        Me.btnQuyDinh.ImageUri.Uri = "Replace"
        Me.btnQuyDinh.Name = "btnQuyDinh"
        '
        'btnTraCuuDaiLy
        '
        Me.btnTraCuuDaiLy.Caption = "Tra Cứu Đại Lý"
        Me.btnTraCuuDaiLy.Id = 11
        Me.btnTraCuuDaiLy.ImageUri.Uri = "ZoomIn"
        Me.btnTraCuuDaiLy.Name = "btnTraCuuDaiLy"
        '
        'btnLapPhieuThu
        '
        Me.btnLapPhieuThu.Caption = "Lập Phiếu Thu Tiền"
        Me.btnLapPhieuThu.Id = 12
        Me.btnLapPhieuThu.ImageUri.Uri = "Currency"
        Me.btnLapPhieuThu.Name = "btnLapPhieuThu"
        '
        'btnLapPhieuXuat
        '
        Me.btnLapPhieuXuat.Caption = "Lập Phiếu Xuất Hàng"
        Me.btnLapPhieuXuat.Id = 13
        Me.btnLapPhieuXuat.ImageUri.Uri = "Forward"
        Me.btnLapPhieuXuat.Name = "btnLapPhieuXuat"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Enabled = False
        Me.BarButtonItem1.Id = 14
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnBaoCaoDoanhSo
        '
        Me.btnBaoCaoDoanhSo.Caption = "Báo Cáo Doanh Số"
        Me.btnBaoCaoDoanhSo.Id = 1
        Me.btnBaoCaoDoanhSo.ImageUri.Uri = "Summary"
        Me.btnBaoCaoDoanhSo.Name = "btnBaoCaoDoanhSo"
        '
        'btnBaoCaoCongNo
        '
        Me.btnBaoCaoCongNo.Caption = "Báo Cáo Công Nợ"
        Me.btnBaoCaoCongNo.Id = 2
        Me.btnBaoCaoCongNo.ImageUri.Uri = "StrikeoutDouble"
        Me.btnBaoCaoCongNo.Name = "btnBaoCaoCongNo"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 433)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Menu"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Menu"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rmMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents blLuuTru As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents btnDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMatHang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnQuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents blTraCuu As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents blTinhToan As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents blBaoBieu As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents btnMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rmMenu As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents btnLoaiDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDonViTinh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnQuyDinh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTraCuuDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLapPhieuThu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLapPhieuXuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBaoCaoDoanhSo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBaoCaoCongNo As DevExpress.XtraBars.BarButtonItem
End Class
