<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tutorial))
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnTruoc = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSau = New DevExpress.XtraEditors.SimpleButton()
        Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
        Me.Imagelist = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 483)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(714, 36)
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(714, 61)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(125, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 230)
        Me.Panel1.TabIndex = 2
        '
        'btnTruoc
        '
        Me.btnTruoc.Location = New System.Drawing.Point(186, 365)
        Me.btnTruoc.Name = "btnTruoc"
        Me.btnTruoc.Size = New System.Drawing.Size(78, 39)
        Me.btnTruoc.TabIndex = 3
        Me.btnTruoc.Text = "Trước"
        '
        'btnSau
        '
        Me.btnSau.Location = New System.Drawing.Point(432, 365)
        Me.btnSau.Name = "btnSau"
        Me.btnSau.Size = New System.Drawing.Size(78, 39)
        Me.btnSau.TabIndex = 3
        Me.btnSau.Text = "Sau"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(311, 365)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 39)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        '
        'Imagelist
        '
        Me.Imagelist.ImageStream = CType(resources.GetObject("Imagelist.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Imagelist.TransparentColor = System.Drawing.Color.Transparent
        Me.Imagelist.Images.SetKeyName(0, "BaoCao.JPG")
        Me.Imagelist.Images.SetKeyName(1, "DonViTinh.JPG")
        Me.Imagelist.Images.SetKeyName(2, "LoaiDaiLy.JPG")
        Me.Imagelist.Images.SetKeyName(3, "MatHang.JPG")
        Me.Imagelist.Images.SetKeyName(4, "PhieuThu.JPG")
        Me.Imagelist.Images.SetKeyName(5, "PhieuXuat.JPG")
        Me.Imagelist.Images.SetKeyName(6, "Quan.JPG")
        Me.Imagelist.Images.SetKeyName(7, "ThayDoiQuyDinh.JPG")
        Me.Imagelist.Images.SetKeyName(8, "TiepNhanDaiLy.JPG")
        Me.Imagelist.Images.SetKeyName(9, "TraCuu.JPG")
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 519)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnSau)
        Me.Controls.Add(Me.btnTruoc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Tutorial"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Tutorial"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTruoc As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSau As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Imagelist As ImageList
End Class
