<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LapPhieuXuatHang
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnThemPhieuXuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoaPhieuXuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCapNhatPhieuXuat = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbMaMatHang = New System.Windows.Forms.TextBox()
        Me.cbMaDaiLy = New System.Windows.Forms.ComboBox()
        Me.txbTenMatHang = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cbDonViTinh = New System.Windows.Forms.ComboBox()
        Me.txbTenDaiLy = New System.Windows.Forms.TextBox()
        Me.txbDonGia = New System.Windows.Forms.TextBox()
        Me.txbSoLuong = New System.Windows.Forms.TextBox()
        Me.txbNgayLapPhieu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvTiepNhanDaiLy = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rtxbInfo = New System.Windows.Forms.RichTextBox()
        Me.fpnlNote = New DevExpress.Utils.FlyoutPanel()
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txbTenMatHang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpnlNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnThemPhieuXuat, Me.btnXoaPhieuXuat, Me.btnCapNhatPhieuXuat, Me.btnThoat})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(930, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnThemPhieuXuat
        '
        Me.btnThemPhieuXuat.Caption = "Thêm phiếu xuất"
        Me.btnThemPhieuXuat.Id = 1
        Me.btnThemPhieuXuat.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnThemPhieuXuat.Name = "btnThemPhieuXuat"
        '
        'btnXoaPhieuXuat
        '
        Me.btnXoaPhieuXuat.Caption = "Xóa phiếu xuất"
        Me.btnXoaPhieuXuat.Id = 2
        Me.btnXoaPhieuXuat.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.deleteIcon
        Me.btnXoaPhieuXuat.Name = "btnXoaPhieuXuat"
        '
        'btnCapNhatPhieuXuat
        '
        Me.btnCapNhatPhieuXuat.Caption = "Cập nhật phiếu xuất"
        Me.btnCapNhatPhieuXuat.Id = 3
        Me.btnCapNhatPhieuXuat.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.updateIcon
        Me.btnCapNhatPhieuXuat.Name = "btnCapNhatPhieuXuat"
        '
        'btnThoat
        '
        Me.btnThoat.Caption = "Thoát"
        Me.btnThoat.Id = 4
        Me.btnThoat.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.closeIcon
        Me.btnThoat.Name = "btnThoat"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Phiếu xuất hàng"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnThemPhieuXuat)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnXoaPhieuXuat)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCapNhatPhieuXuat)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnThoat)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 634)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(930, 31)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbMaMatHang)
        Me.Panel1.Controls.Add(Me.cbMaDaiLy)
        Me.Panel1.Controls.Add(Me.txbTenMatHang)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.cbDonViTinh)
        Me.Panel1.Controls.Add(Me.txbTenDaiLy)
        Me.Panel1.Controls.Add(Me.txbDonGia)
        Me.Panel1.Controls.Add(Me.txbSoLuong)
        Me.Panel1.Controls.Add(Me.txbNgayLapPhieu)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 154)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 207)
        Me.Panel1.TabIndex = 4
        '
        'txbMaMatHang
        '
        Me.txbMaMatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbMaMatHang.Location = New System.Drawing.Point(87, 131)
        Me.txbMaMatHang.Name = "txbMaMatHang"
        Me.txbMaMatHang.ReadOnly = True
        Me.txbMaMatHang.Size = New System.Drawing.Size(95, 21)
        Me.txbMaMatHang.TabIndex = 36
        '
        'cbMaDaiLy
        '
        Me.cbMaDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaDaiLy.FormattingEnabled = True
        Me.cbMaDaiLy.Location = New System.Drawing.Point(87, 54)
        Me.cbMaDaiLy.Name = "cbMaDaiLy"
        Me.cbMaDaiLy.Size = New System.Drawing.Size(249, 21)
        Me.cbMaDaiLy.TabIndex = 35
        '
        'txbTenMatHang
        '
        Me.txbTenMatHang.Location = New System.Drawing.Point(87, 168)
        Me.txbTenMatHang.Name = "txbTenMatHang"
        Me.txbTenMatHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txbTenMatHang.Properties.Mask.EditMask = "d"
        Me.txbTenMatHang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbTenMatHang.Size = New System.Drawing.Size(249, 20)
        Me.txbTenMatHang.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(50, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN PHIẾU XUẤT HÀNG"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.note_edit_icon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(40, 39)
        Me.Panel5.TabIndex = 32
        '
        'cbDonViTinh
        '
        Me.cbDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDonViTinh.FormattingEnabled = True
        Me.cbDonViTinh.Location = New System.Drawing.Point(257, 131)
        Me.cbDonViTinh.Name = "cbDonViTinh"
        Me.cbDonViTinh.Size = New System.Drawing.Size(79, 21)
        Me.cbDonViTinh.TabIndex = 31
        '
        'txbTenDaiLy
        '
        Me.txbTenDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbTenDaiLy.Location = New System.Drawing.Point(87, 94)
        Me.txbTenDaiLy.Name = "txbTenDaiLy"
        Me.txbTenDaiLy.ReadOnly = True
        Me.txbTenDaiLy.Size = New System.Drawing.Size(249, 21)
        Me.txbTenDaiLy.TabIndex = 28
        '
        'txbDonGia
        '
        Me.txbDonGia.Location = New System.Drawing.Point(443, 132)
        Me.txbDonGia.Multiline = True
        Me.txbDonGia.Name = "txbDonGia"
        Me.txbDonGia.Size = New System.Drawing.Size(201, 20)
        Me.txbDonGia.TabIndex = 26
        '
        'txbSoLuong
        '
        Me.txbSoLuong.Location = New System.Drawing.Point(443, 93)
        Me.txbSoLuong.Name = "txbSoLuong"
        Me.txbSoLuong.Size = New System.Drawing.Size(201, 21)
        Me.txbSoLuong.TabIndex = 25
        '
        'txbNgayLapPhieu
        '
        Me.txbNgayLapPhieu.Location = New System.Drawing.Point(443, 54)
        Me.txbNgayLapPhieu.Name = "txbNgayLapPhieu"
        Me.txbNgayLapPhieu.ReadOnly = True
        Me.txbNgayLapPhieu.Size = New System.Drawing.Size(201, 21)
        Me.txbNgayLapPhieu.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Đơn giá:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(355, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Số lượng:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Đơn vị tính:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ngày lập phiếu:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tên mặt hàng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mã mặt hàng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên đại lý:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã đại lý:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgvTiepNhanDaiLy)
        Me.Panel2.Location = New System.Drawing.Point(9, 365)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(664, 258)
        Me.Panel2.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(47, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "DANH SÁCH PHIẾU XUẤT HÀNG"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.Actions_view_calendar_list_icon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(39, 30)
        Me.Panel4.TabIndex = 1
        '
        'dgvTiepNhanDaiLy
        '
        Me.dgvTiepNhanDaiLy.AllowUserToAddRows = False
        Me.dgvTiepNhanDaiLy.AllowUserToDeleteRows = False
        Me.dgvTiepNhanDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiepNhanDaiLy.Location = New System.Drawing.Point(0, 33)
        Me.dgvTiepNhanDaiLy.Name = "dgvTiepNhanDaiLy"
        Me.dgvTiepNhanDaiLy.ReadOnly = True
        Me.dgvTiepNhanDaiLy.Size = New System.Drawing.Size(664, 224)
        Me.dgvTiepNhanDaiLy.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.rtxbInfo)
        Me.Panel3.Location = New System.Drawing.Point(693, 154)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(217, 207)
        Me.Panel3.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(36, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "THÔNG TIN"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.infoIcon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 22)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rtxbInfo
        '
        Me.rtxbInfo.Location = New System.Drawing.Point(0, 27)
        Me.rtxbInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtxbInfo.Name = "rtxbInfo"
        Me.rtxbInfo.ReadOnly = True
        Me.rtxbInfo.Size = New System.Drawing.Size(216, 162)
        Me.rtxbInfo.TabIndex = 0
        Me.rtxbInfo.Text = ""
        '
        'fpnlNote
        '
        Me.fpnlNote.Controls.Add(Me.lblThongbao)
        Me.fpnlNote.Controls.Add(Me.label)
        Me.fpnlNote.Location = New System.Drawing.Point(471, 55)
        Me.fpnlNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fpnlNote.Name = "fpnlNote"
        Me.fpnlNote.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpnlNote.OwnerControl = Me.Button1
        Me.fpnlNote.Size = New System.Drawing.Size(390, 72)
        Me.fpnlNote.TabIndex = 31
        '
        'lblThongbao
        '
        Me.lblThongbao.AutoSize = True
        Me.lblThongbao.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblThongbao.ForeColor = System.Drawing.Color.Red
        Me.lblThongbao.Location = New System.Drawing.Point(132, 26)
        Me.lblThongbao.Name = "lblThongbao"
        Me.lblThongbao.Size = New System.Drawing.Size(0, 13)
        Me.lblThongbao.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label.ForeColor = System.Drawing.Color.Red
        Me.label.Location = New System.Drawing.Point(20, 26)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(104, 17)
        Me.label.TabIndex = 0
        Me.label.Text = "THÔNG BÁO: "
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'LapPhieuXuatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 665)
        Me.Controls.Add(Me.fpnlNote)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "LapPhieuXuatHang"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "LẬP PHIẾU XUẤT HÀNG"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txbTenMatHang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpnlNote.ResumeLayout(False)
        Me.fpnlNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbTenMatHang As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbDonViTinh As ComboBox
    Friend WithEvents txbTenDaiLy As TextBox
    Friend WithEvents txbDonGia As TextBox
    Friend WithEvents txbSoLuong As TextBox
    Friend WithEvents txbNgayLapPhieu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvTiepNhanDaiLy As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents rtxbInfo As RichTextBox
    Friend WithEvents fpnlNote As DevExpress.Utils.FlyoutPanel
    Friend WithEvents lblThongbao As Label
    Friend WithEvents label As Label
    Friend WithEvents btnThemPhieuXuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnXoaPhieuXuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCapNhatPhieuXuat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txbMaMatHang As TextBox
    Friend WithEvents cbMaDaiLy As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
