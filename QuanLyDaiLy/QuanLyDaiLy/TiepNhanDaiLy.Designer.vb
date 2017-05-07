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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 706)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1016, 36)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 11
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1016, 168)
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
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 212)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(10, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 305)
        Me.Panel2.TabIndex = 3
        '
        'TiepNhanDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 742)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "TiepNhanDaiLy"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "TIẾP NHẬN ĐẠI LÝ"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
