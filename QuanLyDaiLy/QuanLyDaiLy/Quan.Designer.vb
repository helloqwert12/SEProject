<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quan
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
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.QuanLyDaiLy.LoadingSplashScreen), True, True)
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnThemQuan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnXoaQuan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCapNhatQuan = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnXacNhan = New System.Windows.Forms.Button()
        Me.txbMaQuan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txbTenQuan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvQuan = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.dgSoQuan = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.fpnlNote = New DevExpress.Utils.FlyoutPanel()
        Me.lblThongbao = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.dgSoQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpnlNote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpnlNote.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 100
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnThemQuan, Me.btnXoaQuan, Me.btnCapNhatQuan, Me.btnThoat})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(988, 168)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnThemQuan
        '
        Me.btnThemQuan.Caption = "Thêm quận"
        Me.btnThemQuan.Id = 1
        Me.btnThemQuan.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.btnThemQuan.Name = "btnThemQuan"
        '
        'btnXoaQuan
        '
        Me.btnXoaQuan.Caption = "Xóa quận"
        Me.btnXoaQuan.Enabled = False
        Me.btnXoaQuan.Id = 2
        Me.btnXoaQuan.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.deleteIcon
        Me.btnXoaQuan.Name = "btnXoaQuan"
        '
        'btnCapNhatQuan
        '
        Me.btnCapNhatQuan.Caption = "Cập nhật quận"
        Me.btnCapNhatQuan.Enabled = False
        Me.btnCapNhatQuan.Id = 3
        Me.btnCapNhatQuan.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.updateIcon
        Me.btnCapNhatQuan.Name = "btnCapNhatQuan"
        '
        'btnThoat
        '
        Me.btnThoat.Caption = "Thoát trang"
        Me.btnThoat.Id = 4
        Me.btnThoat.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.closeIcon
        Me.btnThoat.Name = "btnThoat"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Quận"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnThemQuan)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnXoaQuan)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCapNhatQuan)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnThoat)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 455)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(988, 36)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnXacNhan)
        Me.Panel1.Controls.Add(Me.txbMaQuan)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.txbTenQuan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(14, 182)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 260)
        Me.Panel1.TabIndex = 8
        '
        'btnXacNhan
        '
        Me.btnXacNhan.Enabled = False
        Me.btnXacNhan.Image = Global.QuanLyDaiLy.My.Resources.Resources.Ok_icon
        Me.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXacNhan.Location = New System.Drawing.Point(188, 212)
        Me.btnXacNhan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXacNhan.Name = "btnXacNhan"
        Me.btnXacNhan.Size = New System.Drawing.Size(107, 46)
        Me.btnXacNhan.TabIndex = 37
        Me.btnXacNhan.Text = "Xác nhận"
        Me.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnXacNhan.UseVisualStyleBackColor = True
        '
        'txbMaQuan
        '
        Me.txbMaQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbMaQuan.Enabled = False
        Me.txbMaQuan.Location = New System.Drawing.Point(111, 65)
        Me.txbMaQuan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbMaQuan.Name = "txbMaQuan"
        Me.txbMaQuan.ReadOnly = True
        Me.txbMaQuan.Size = New System.Drawing.Size(184, 23)
        Me.txbMaQuan.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(58, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(164, 21)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN QUẬN"
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
        'txbTenQuan
        '
        Me.txbTenQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbTenQuan.Enabled = False
        Me.txbTenQuan.Location = New System.Drawing.Point(111, 130)
        Me.txbTenQuan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbTenQuan.Name = "txbTenQuan"
        Me.txbTenQuan.Size = New System.Drawing.Size(184, 23)
        Me.txbTenQuan.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tên quận:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mã quận:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.dgvQuan)
        Me.Panel2.Location = New System.Drawing.Point(328, 182)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 260)
        Me.Panel2.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(55, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 21)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "DANH SÁCH QUẬN"
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
        'dgvQuan
        '
        Me.dgvQuan.AllowUserToAddRows = False
        Me.dgvQuan.AllowUserToDeleteRows = False
        Me.dgvQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuan.Location = New System.Drawing.Point(0, 41)
        Me.dgvQuan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvQuan.Name = "dgvQuan"
        Me.dgvQuan.ReadOnly = True
        Me.dgvQuan.Size = New System.Drawing.Size(323, 217)
        Me.dgvQuan.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.GaugeControl1)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(660, 180)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 259)
        Me.Panel3.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label12.Location = New System.Drawing.Point(3, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Số quận hiện có:"
        '
        'GaugeControl1
        '
        Me.GaugeControl1.AutoLayout = False
        Me.GaugeControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.dgSoQuan})
        Me.GaugeControl1.Location = New System.Drawing.Point(168, 53)
        Me.GaugeControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(115, 59)
        Me.GaugeControl1.TabIndex = 18
        '
        'dgSoQuan
        '
        Me.dgSoQuan.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.dgSoQuan.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.dgSoQuan.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent1})
        Me.dgSoQuan.Bounds = New System.Drawing.Rectangle(8, 1, 95, 48)
        Me.dgSoQuan.DigitCount = 5
        Me.dgSoQuan.Name = "dgSoQuan"
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
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(531, 64)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(457, 12)
        Me.Button3.TabIndex = 49
        Me.Button3.UseVisualStyleBackColor = True
        '
        'fpnlNote
        '
        Me.fpnlNote.Controls.Add(Me.lblThongbao)
        Me.fpnlNote.Controls.Add(Me.label)
        Me.fpnlNote.Location = New System.Drawing.Point(542, 64)
        Me.fpnlNote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fpnlNote.Name = "fpnlNote"
        Me.fpnlNote.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpnlNote.OwnerControl = Me.Button3
        Me.fpnlNote.Size = New System.Drawing.Size(432, 89)
        Me.fpnlNote.TabIndex = 52
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
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Quan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 491)
        Me.Controls.Add(Me.fpnlNote)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Quan"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "QUẬN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvQuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgSoQuan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnThemQuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXoaQuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCapNhatQuan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents txbMaQuan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txbTenQuan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvQuan As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents dgSoQuan As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents fpnlNote As DevExpress.Utils.FlyoutPanel
    Friend WithEvents lblThongbao As Label
    Friend WithEvents label As Label
    Friend WithEvents Timer1 As Timer
End Class
