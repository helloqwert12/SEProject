<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiepNhanDaiLy
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
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvTiepNhanDaiLy = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbMaLoaiDaiLy = New System.Windows.Forms.ComboBox()
        Me.cbQuan = New System.Windows.Forms.ComboBox()
        Me.txbMaDaiLy = New System.Windows.Forms.TextBox()
        Me.txbTenDaiLy = New System.Windows.Forms.TextBox()
        Me.txbDienThoai = New System.Windows.Forms.TextBox()
        Me.txbDiaChi = New System.Windows.Forms.TextBox()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbNgayTiepNhan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 572)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar.Size = New System.Drawing.Size(872, 31)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(872, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.ImageIndex = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Thêm đại lý"
        Me.BarButtonItem2.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Xóa đại lý"
        Me.BarButtonItem5.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.deleteIcon
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        Me.BarButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Cập nhật đại lý"
        Me.BarButtonItem6.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.updateIcon
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Thoát"
        Me.BarButtonItem7.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.closeIcon
        Me.BarButtonItem7.Id = 8
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "RibbonPageGroup4"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "RibbonPageGroup5"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Thêm đại lý"
        Me.BarButtonItem3.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Thêm đại lý"
        Me.BarButtonItem4.Glyph = Global.QuanLyDaiLy.My.Resources.Resources.Button_Add_icon
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvTiepNhanDaiLy)
        Me.Panel2.Location = New System.Drawing.Point(9, 321)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 248)
        Me.Panel2.TabIndex = 3
        '
        'dgvTiepNhanDaiLy
        '
        Me.dgvTiepNhanDaiLy.AllowUserToAddRows = False
        Me.dgvTiepNhanDaiLy.AllowUserToDeleteRows = False
        Me.dgvTiepNhanDaiLy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvTiepNhanDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiepNhanDaiLy.Location = New System.Drawing.Point(0, 0)
        Me.dgvTiepNhanDaiLy.Name = "dgvTiepNhanDaiLy"
        Me.dgvTiepNhanDaiLy.ReadOnly = True
        Me.dgvTiepNhanDaiLy.Size = New System.Drawing.Size(633, 248)
        Me.dgvTiepNhanDaiLy.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbMaLoaiDaiLy)
        Me.Panel1.Controls.Add(Me.cbQuan)
        Me.Panel1.Controls.Add(Me.txbMaDaiLy)
        Me.Panel1.Controls.Add(Me.txbTenDaiLy)
        Me.Panel1.Controls.Add(Me.txbDienThoai)
        Me.Panel1.Controls.Add(Me.txbDiaChi)
        Me.Panel1.Controls.Add(Me.txbEmail)
        Me.Panel1.Controls.Add(Me.txbNgayTiepNhan)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 147)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 166)
        Me.Panel1.TabIndex = 3
        '
        'cbMaLoaiDaiLy
        '
        Me.cbMaLoaiDaiLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaLoaiDaiLy.FormattingEnabled = True
        Me.cbMaLoaiDaiLy.Location = New System.Drawing.Point(402, 53)
        Me.cbMaLoaiDaiLy.Name = "cbMaLoaiDaiLy"
        Me.cbMaLoaiDaiLy.Size = New System.Drawing.Size(227, 21)
        Me.cbMaLoaiDaiLy.TabIndex = 31
        '
        'cbQuan
        '
        Me.cbQuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuan.FormattingEnabled = True
        Me.cbQuan.Location = New System.Drawing.Point(72, 91)
        Me.cbQuan.Name = "cbQuan"
        Me.cbQuan.Size = New System.Drawing.Size(214, 21)
        Me.cbQuan.TabIndex = 30
        '
        'txbMaDaiLy
        '
        Me.txbMaDaiLy.Location = New System.Drawing.Point(72, 17)
        Me.txbMaDaiLy.Name = "txbMaDaiLy"
        Me.txbMaDaiLy.ReadOnly = True
        Me.txbMaDaiLy.Size = New System.Drawing.Size(214, 21)
        Me.txbMaDaiLy.TabIndex = 29
        '
        'txbTenDaiLy
        '
        Me.txbTenDaiLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txbTenDaiLy.Location = New System.Drawing.Point(72, 53)
        Me.txbTenDaiLy.Name = "txbTenDaiLy"
        Me.txbTenDaiLy.Size = New System.Drawing.Size(214, 21)
        Me.txbTenDaiLy.TabIndex = 28
        '
        'txbDienThoai
        '
        Me.txbDienThoai.Location = New System.Drawing.Point(72, 127)
        Me.txbDienThoai.Name = "txbDienThoai"
        Me.txbDienThoai.Size = New System.Drawing.Size(214, 21)
        Me.txbDienThoai.TabIndex = 27
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(402, 127)
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(227, 21)
        Me.txbDiaChi.TabIndex = 26
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(402, 91)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(227, 21)
        Me.txbEmail.TabIndex = 25
        '
        'txbNgayTiepNhan
        '
        Me.txbNgayTiepNhan.Location = New System.Drawing.Point(402, 17)
        Me.txbNgayTiepNhan.Name = "txbNgayTiepNhan"
        Me.txbNgayTiepNhan.ReadOnly = True
        Me.txbNgayTiepNhan.Size = New System.Drawing.Size(227, 21)
        Me.txbNgayTiepNhan.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Địa chỉ:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(312, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "E-mail:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Mã loại đại lý:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ngày tiếp nhận:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quận:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên đại lý:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mã đại lý:"
        '
        'TiepNhanDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 603)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "TiepNhanDaiLy"
        Me.Ribbon = Me.RibbonControl1
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "TIẾP NHẬN ĐẠI LÝ"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbMaLoaiDaiLy As ComboBox
    Friend WithEvents cbQuan As ComboBox
    Friend WithEvents txbMaDaiLy As TextBox
    Friend WithEvents txbTenDaiLy As TextBox
    Friend WithEvents txbDienThoai As TextBox
    Friend WithEvents txbDiaChi As TextBox
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbNgayTiepNhan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvTiepNhanDaiLy As DataGridView
End Class
