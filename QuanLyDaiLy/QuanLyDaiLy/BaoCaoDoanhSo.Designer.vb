<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoDoanhSo
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnThucHien = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPDF = New DevExpress.XtraBars.BarButtonItem()
        Me.btnThoat = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.dgvBaoCaoDoanhSo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbNam = New DevExpress.XtraEditors.TextEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txbTongTriGia = New System.Windows.Forms.TextBox()
        Me.txbMaDaiLy = New System.Windows.Forms.TextBox()
        Me.txbThoiGian = New System.Windows.Forms.TextBox()
        Me.txbTyLe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txbSoPhieuXuat = New System.Windows.Forms.TextBox()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnThucHien, Me.btnExcel, Me.btnPDF, Me.btnThoat})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(576, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnThucHien
        '
        Me.btnThucHien.Caption = "Thực hiện"
        Me.btnThucHien.Id = 1
        Me.btnThucHien.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.Ok_icon
        Me.btnThucHien.Name = "btnThucHien"
        '
        'btnExcel
        '
        Me.btnExcel.Caption = "Xuất file Excel"
        Me.btnExcel.Enabled = False
        Me.btnExcel.Id = 2
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPDF
        '
        Me.btnPDF.Caption = "Xuất file PDF"
        Me.btnPDF.Enabled = False
        Me.btnPDF.Id = 3
        Me.btnPDF.Name = "btnPDF"
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
        Me.RibbonPage1.Text = "Báo Cáo Doanh Số"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnThucHien)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnExcel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPDF)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 588)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(576, 31)
        '
        'dgvBaoCaoDoanhSo
        '
        Me.dgvBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoDoanhSo.Location = New System.Drawing.Point(12, 371)
        Me.dgvBaoCaoDoanhSo.Name = "dgvBaoCaoDoanhSo"
        Me.dgvBaoCaoDoanhSo.Size = New System.Drawing.Size(549, 208)
        Me.dgvBaoCaoDoanhSo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tháng:"
        '
        'cbThang
        '
        Me.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(219, 159)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(64, 21)
        Me.cbThang.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Năm:"
        '
        'txbNam
        '
        Me.txbNam.Location = New System.Drawing.Point(353, 159)
        Me.txbNam.MenuManager = Me.RibbonControl
        Me.txbNam.Name = "txbNam"
        Me.txbNam.Properties.Mask.EditMask = "d"
        Me.txbNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbNam.Size = New System.Drawing.Size(100, 20)
        Me.txbNam.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbSoPhieuXuat)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.txbTongTriGia)
        Me.Panel1.Controls.Add(Me.txbMaDaiLy)
        Me.Panel1.Controls.Add(Me.txbThoiGian)
        Me.Panel1.Controls.Add(Me.txbTyLe)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(12, 195)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 171)
        Me.Panel1.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(50, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(242, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "THÔNG TIN BÁO CÁO DOANH SỐ"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.QuanLyDaiLy.My.Resources.Resources.note_edit_icon
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(40, 33)
        Me.Panel5.TabIndex = 32
        '
        'txbTongTriGia
        '
        Me.txbTongTriGia.Enabled = False
        Me.txbTongTriGia.Location = New System.Drawing.Point(357, 57)
        Me.txbTongTriGia.Name = "txbTongTriGia"
        Me.txbTongTriGia.ReadOnly = True
        Me.txbTongTriGia.Size = New System.Drawing.Size(170, 21)
        Me.txbTongTriGia.TabIndex = 29
        '
        'txbMaDaiLy
        '
        Me.txbMaDaiLy.Enabled = False
        Me.txbMaDaiLy.Location = New System.Drawing.Point(74, 99)
        Me.txbMaDaiLy.Name = "txbMaDaiLy"
        Me.txbMaDaiLy.ReadOnly = True
        Me.txbMaDaiLy.Size = New System.Drawing.Size(177, 21)
        Me.txbMaDaiLy.TabIndex = 29
        '
        'txbThoiGian
        '
        Me.txbThoiGian.Enabled = False
        Me.txbThoiGian.Location = New System.Drawing.Point(74, 57)
        Me.txbThoiGian.Name = "txbThoiGian"
        Me.txbThoiGian.ReadOnly = True
        Me.txbThoiGian.Size = New System.Drawing.Size(177, 21)
        Me.txbThoiGian.TabIndex = 28
        '
        'txbTyLe
        '
        Me.txbTyLe.Enabled = False
        Me.txbTyLe.Location = New System.Drawing.Point(74, 144)
        Me.txbTyLe.Name = "txbTyLe"
        Me.txbTyLe.ReadOnly = True
        Me.txbTyLe.Size = New System.Drawing.Size(177, 21)
        Me.txbTyLe.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tỷ lệ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tổng trị giá:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Số phiếu xuất:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Thời gian:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Mã đại lý:"
        '
        'txbSoPhieuXuat
        '
        Me.txbSoPhieuXuat.Enabled = False
        Me.txbSoPhieuXuat.Location = New System.Drawing.Point(357, 99)
        Me.txbSoPhieuXuat.Name = "txbSoPhieuXuat"
        Me.txbSoPhieuXuat.ReadOnly = True
        Me.txbSoPhieuXuat.Size = New System.Drawing.Size(170, 21)
        Me.txbSoPhieuXuat.TabIndex = 36
        '
        'BaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 619)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txbNam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBaoCaoDoanhSo)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BaoCaoDoanhSo"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "BÁO CÁO DOANH SỐ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnThucHien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPDF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnThoat As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents dgvBaoCaoDoanhSo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbNam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbSoPhieuXuat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txbTongTriGia As TextBox
    Friend WithEvents txbMaDaiLy As TextBox
    Friend WithEvents txbThoiGian As TextBox
    Friend WithEvents txbTyLe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
