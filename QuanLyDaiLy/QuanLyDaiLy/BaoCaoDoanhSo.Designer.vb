﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaoCaoDoanhSo
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
        Dim SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.QuanLyDaiLy.LoadingSplashScreen), True, True)
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txbNam = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBaoCaoDoanhSo = New System.Windows.Forms.DataGridView()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager1
        '
        SplashScreenManager1.ClosingDelay = 100
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnThucHien, Me.btnExcel, Me.btnPDF, Me.btnThoat})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(679, 143)
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
        Me.btnExcel.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.excel_icon
        Me.btnExcel.Name = "btnExcel"
        '
        'btnPDF
        '
        Me.btnPDF.Caption = "Xuất file PDF"
        Me.btnPDF.Enabled = False
        Me.btnPDF.Id = 3
        Me.btnPDF.LargeGlyph = Global.QuanLyDaiLy.My.Resources.Resources.Apps_Pdf_icon
        Me.btnPDF.Name = "btnPDF"
        '
        'btnThoat
        '
        Me.btnThoat.Caption = "Thoát báo cáo"
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
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnExcel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPDF)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnThoat)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 401)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(679, 31)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txbNam)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbThang)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 143)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 51)
        Me.Panel1.TabIndex = 29
        '
        'txbNam
        '
        Me.txbNam.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txbNam.Location = New System.Drawing.Point(389, 22)
        Me.txbNam.MenuManager = Me.RibbonControl
        Me.txbNam.Name = "txbNam"
        Me.txbNam.Properties.Mask.EditMask = "d"
        Me.txbNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txbNam.Size = New System.Drawing.Size(100, 20)
        Me.txbNam.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Năm:"
        '
        'cbThang
        '
        Me.cbThang.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(255, 22)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(64, 21)
        Me.cbThang.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tháng:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvBaoCaoDoanhSo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 194)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 217)
        Me.Panel2.TabIndex = 30
        '
        'dgvBaoCaoDoanhSo
        '
        Me.dgvBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaoCaoDoanhSo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBaoCaoDoanhSo.Location = New System.Drawing.Point(0, 0)
        Me.dgvBaoCaoDoanhSo.Name = "dgvBaoCaoDoanhSo"
        Me.dgvBaoCaoDoanhSo.Size = New System.Drawing.Size(679, 217)
        Me.dgvBaoCaoDoanhSo.TabIndex = 23
        '
        'BaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 432)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txbNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvBaoCaoDoanhSo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txbNam As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvBaoCaoDoanhSo As DataGridView
End Class
