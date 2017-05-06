<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TiepNhanDaiLy
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ComboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
        Me.gcTiepNhanDaiLy = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã đại lý:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên đại lý:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quận:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Điện thoại:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ngày tiếp nhận:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Loại đại lý:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "E-mail:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 14)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Địa chỉ:"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(29, 438)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(87, 25)
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Location = New System.Drawing.Point(134, 438)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(87, 25)
        Me.btnTimKiem.TabIndex = 11
        Me.btnTimKiem.Text = "Tìm kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(238, 438)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(87, 25)
        Me.btnXoa.TabIndex = 12
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(343, 438)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(87, 25)
        Me.btnCapNhat.TabIndex = 13
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(451, 438)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 25)
        Me.btnThoat.TabIndex = 14
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(138, 119)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(116, 20)
        Me.TextEdit1.TabIndex = 26
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(384, 198)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit2.TabIndex = 28
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(384, 157)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit3.TabIndex = 29
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(138, 195)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(116, 20)
        Me.TextEdit4.TabIndex = 30
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(384, 82)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(137, 20)
        Me.TextEdit5.TabIndex = 31
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(138, 83)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(116, 20)
        Me.TextEdit6.TabIndex = 32
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(384, 115)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(137, 20)
        Me.ComboBoxEdit1.TabIndex = 33
        '
        'ComboBoxEdit2
        '
        Me.ComboBoxEdit2.Location = New System.Drawing.Point(138, 157)
        Me.ComboBoxEdit2.Name = "ComboBoxEdit2"
        Me.ComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit2.Size = New System.Drawing.Size(116, 20)
        Me.ComboBoxEdit2.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(212, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(161, 25)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Tiếp Nhận Đại Lý"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.Name = "SqlDataSource1"
        '
        'gcTiepNhanDaiLy
        '
        Me.gcTiepNhanDaiLy.Location = New System.Drawing.Point(5, 23)
        Me.gcTiepNhanDaiLy.MainView = Me.GridView1
        Me.gcTiepNhanDaiLy.Name = "gcTiepNhanDaiLy"
        Me.gcTiepNhanDaiLy.Size = New System.Drawing.Size(531, 178)
        Me.gcTiepNhanDaiLy.TabIndex = 0
        Me.gcTiepNhanDaiLy.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcTiepNhanDaiLy
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gcTiepNhanDaiLy)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 226)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(541, 206)
        Me.GroupControl1.TabIndex = 36
        Me.GroupControl1.Text = "Hồ Sơ Đại Lý"
        '
        'TiepNhanDaiLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 476)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.ComboBoxEdit2)
        Me.Controls.Add(Me.ComboBoxEdit1)
        Me.Controls.Add(Me.TextEdit6)
        Me.Controls.Add(Me.TextEdit5)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "TiepNhanDaiLy"
        Me.Text = "Tiếp Nhân Đại Lý"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTiepNhanDaiLy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ComboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents gcTiepNhanDaiLy As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
