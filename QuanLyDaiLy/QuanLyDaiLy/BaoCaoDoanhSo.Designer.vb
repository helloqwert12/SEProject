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
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(572, 143)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 415)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(572, 31)
        '
        'dgvBaoCaoDoanhSo
        '
        Me.dgvBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoDoanhSo.Location = New System.Drawing.Point(12, 195)
        Me.dgvBaoCaoDoanhSo.Name = "dgvBaoCaoDoanhSo"
        Me.dgvBaoCaoDoanhSo.Size = New System.Drawing.Size(549, 208)
        Me.dgvBaoCaoDoanhSo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 158)
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
        Me.cbThang.Location = New System.Drawing.Point(204, 157)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(64, 21)
        Me.cbThang.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Năm:"
        '
        'txbNam
        '
        Me.txbNam.Location = New System.Drawing.Point(338, 157)
        Me.txbNam.MenuManager = Me.RibbonControl
        Me.txbNam.Name = "txbNam"
        Me.txbNam.Properties.Mask.EditMask = "d"
        Me.txbNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbNam.Size = New System.Drawing.Size(100, 20)
        Me.txbNam.TabIndex = 10
        '
        'BaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 446)
        Me.Controls.Add(Me.txbNam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBaoCaoDoanhSo)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "BaoCaoDoanhSo"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "BÁO CÁO DOANH SỐ"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
