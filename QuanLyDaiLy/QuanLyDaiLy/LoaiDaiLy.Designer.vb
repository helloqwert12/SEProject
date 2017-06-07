<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoaiDaiLy
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.QuanLyDaiLy.LoadingSplashScreen), True, True)
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnThemLoaiDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoaLoaiDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCapNhatLoaiDaiLy = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbNoToiDa = New DevExpress.XtraEditors.TextEdit()
        Me.btnXacNhan = New System.Windows.Forms.Button()
        Me.txbMaLoaiDaiLy = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txbTenLoaiDaiLy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvLoaiDaiLy = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.dgSoLoaiDaiLy = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fpnlNote = New DevExpress.Utils.FlyoutPanel()
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txbNoToiDa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvLoaiDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgSoLoaiDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpnlNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnThemLoaiDaiLy, Me.btnXoaLoaiDaiLy, Me.btnCapNhatLoaiDaiLy, Me.btnThoat})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1179, 168)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnThemLoaiDaiLy
        '
        Me.btnThemLoaiDaiLy.Caption = "Thêm loại đại lý"
        Me.btnThemLoaiDaiLy.Id = 1
        Me.btnThemLoaiDaiLy.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnThemLoaiDaiLy.Name = "btnThemLoaiDaiLy"
        '
        'btnXoaLoaiDaiLy
        '
        Me.btnXoaLoaiDaiLy.Caption = "Xóa loại đại lý"
        Me.btnXoaLoaiDaiLy.Enabled = False
        Me.btnXoaLoaiDaiLy.Id = 2
        Me.btnXoaLoaiDaiLy.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.deleteIcon
        Me.btnXoaLoaiDaiLy.Name = "btnXoaLoaiDaiLy"
        '
        'btnCapNhatLoaiDaiLy
        '
        Me.btnCapNhatLoaiDaiLy.Caption = "Cập nhật loại đại lý"
        Me.btnCapNhatLoaiDaiLy.Enabled = False
        Me.btnCapNhatLoaiDaiLy.Id = 3
        Me.btnCapNhatLoaiDaiLy.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.updateIcon
        Me.btnCapNhatLoaiDaiLy.Name = "btnCapNhatLoaiDaiLy"
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
        Me.RibbonPage1.Text = "Loại Đại Lý"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnThemLoaiDaiLy)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnXoaLoaiDaiLy)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCapNhatLoaiDaiLy)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 455)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1179, 36)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbNoToiDa)
        Me.Panel1.Controls.Add(Me.btnXacNhan)
        Me.Panel1.Controls.Add(Me.txbMaLoaiDaiLy)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.txbTenLoaiDaiLy)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 182)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 260)
        Me.Panel1.TabIndex = 6
        '
        'txbNoToiDa
        '
        Me.txbNoToiDa.Enabled = False
        Me.txbNoToiDa.Location = New System.Drawing.Point(111, 162)
        Me.txbNoToiDa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbNoToiDa.MenuManager = Me.RibbonControl
        Me.txbNoToiDa.Name = "txbNoToiDa"
        Me.txbNoToiDa.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txbNoToiDa.Properties.Mask.EditMask = "f"
        Me.txbNoToiDa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbNoToiDa.Size = New System.Drawing.Size(261, 22)
        Me.txbNoToiDa.TabIndex = 40
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Enabled = False
        Me.btnXacNhan.Image = Global.QuanLyDaiLy.My.Resources.Resources.Ok_icon
        Me.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXacNhan.Location = New System.Drawing.Point(265, 212)
        Me.btnXacNhan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(107, 46)
        Me.btnXacNhan.TabIndex = 37
        Me.btnXacNhan.Text = "Xác nhận"
        Me.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXacNhan.UseVisualStyleBackColor = True
        '
        'txbMaLoaiDaiLy
        '
        Me.txbMaLoaiDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbMaLoaiDaiLy.Enabled = False
        Me.txbMaLoaiDaiLy.Location = New System.Drawing.Point(111, 65)
        Me.txbMaLoaiDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbMaLoaiDaiLy.Name = "txbMaLoaiDaiLy"
        Me.txbMaLoaiDaiLy.ReadOnly = True
        Me.txbMaLoaiDaiLy.Size = New System.Drawing.Size(261, 23)
        Me.txbMaLoaiDaiLy.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(58, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN LOẠI ĐẠI LÝ"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.note_edit_icon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(47, 48)
        Me.Panel5.TabIndex = 32
        '
        'txbTenLoaiDaiLy
        '
        Me.txbTenLoaiDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbTenLoaiDaiLy.Enabled = False
        Me.txbTenLoaiDaiLy.Location = New System.Drawing.Point(111, 113)
        Me.txbTenLoaiDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTenLoaiDaiLy.Name = "txbTenLoaiDaiLy"
        Me.txbTenLoaiDaiLy.Size = New System.Drawing.Size(261, 23)
        Me.txbTenLoaiDaiLy.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tiền nợ tối đa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tên loại đại lý:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mã loại đại lý:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgvLoaiDaiLy)
        Me.Panel2.Location = New System.Drawing.Point(414, 182)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 260)
        Me.Panel2.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(55, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(225, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "DANH SÁCH LOẠI ĐẠI LÝ"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.Actions_view_calendar_list_icon
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(2, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(45, 37)
        Me.Panel4.TabIndex = 1
        '
        'dgvLoaiDaiLy
        '
        Me.dgvLoaiDaiLy.AllowUserToAddRows = False
        Me.dgvLoaiDaiLy.AllowUserToDeleteRows = False
        Me.dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoaiDaiLy.Location = New System.Drawing.Point(0, 41)
        Me.dgvLoaiDaiLy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLoaiDaiLy.Name = "dgvLoaiDaiLy"
        Me.dgvLoaiDaiLy.ReadOnly = True
        Me.dgvLoaiDaiLy.Size = New System.Drawing.Size(435, 217)
        Me.dgvLoaiDaiLy.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.infoIcon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(2, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 27)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.GaugeControl1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(861, 182)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 259)
        Me.Panel3.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label12.Location = New System.Drawing.Point(3, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Số loại đại lý hiện có:"
        '
        'GaugeControl1
        '
        Me.GaugeControl1.AutoLayout = False
        Me.GaugeControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.dgSoLoaiDaiLy})
        Me.GaugeControl1.Location = New System.Drawing.Point(168, 53)
        Me.GaugeControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(115, 59)
        Me.GaugeControl1.TabIndex = 18
        '
        'dgSoLoaiDaiLy
        '
        Me.dgSoLoaiDaiLy.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.dgSoLoaiDaiLy.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.dgSoLoaiDaiLy.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.dgSoLoaiDaiLy.Bounds = New System.Drawing.Rectangle(6, 1, 95, 48)
        Me.dgSoLoaiDaiLy.DigitCount = 5
        Me.dgSoLoaiDaiLy.Name = "dgSoLoaiDaiLy"
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent7"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style8
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(44, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 21)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "THÔNG TIN"
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(530, 69)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(638, 12)
        Me.Button3.TabIndex = 47
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fpnlNote
        '
        Me.fpnlNote.Controls.Add(Me.lblThongbao)
        Me.fpnlNote.Controls.Add(Me.label)
        Me.fpnlNote.Location = New System.Drawing.Point(544, 69)
        Me.fpnlNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fpnlNote.Name = "fpnlNote"
        Me.fpnlNote.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpnlNote.OwnerControl = Me.Button3
        Me.fpnlNote.Size = New System.Drawing.Size(619, 89)
        Me.fpnlNote.TabIndex = 50
        '
        'lblThongbao
        '
        Me.lblThongbao.AutoSize = True
        Me.lblThongbao.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblThongbao.ForeColor = System.Drawing.Color.Red
        Me.lblThongbao.Location = New System.Drawing.Point(171, 34)
        Me.lblThongbao.Name = "lblThongbao"
        Me.lblThongbao.Size = New System.Drawing.Size(0, 17)
        Me.lblThongbao.TabIndex = 1
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.label.ForeColor = System.Drawing.Color.Red
        Me.label.Location = New System.Drawing.Point(23, 32)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(125, 21)
        Me.label.TabIndex = 0
        Me.label.Text = "THÔNG BÁO: "
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 100
        '
        'LoaiDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 491)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.fpnlNote)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "LoaiDaiLy"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "LOẠI ĐẠI LÝ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txbNoToiDa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvLoaiDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgSoLoaiDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpnlNote.ResumeLayout(False)
        Me.fpnlNote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnThemLoaiDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXoaLoaiDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCapNhatLoaiDaiLy As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbNoToiDa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents txbMaLoaiDaiLy As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txbTenLoaiDaiLy As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvLoaiDaiLy As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents dgSoLoaiDaiLy As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents fpnlNote As DevExpress.Utils.FlyoutPanel
    Friend WithEvents lblThongbao As Label
    Friend WithEvents label As Label
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
End Class
