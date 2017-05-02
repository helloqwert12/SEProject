<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTest = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.txbMaDaiLy = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbTongTriGia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbNgapLapPhieu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTest
        '
        Me.dgvTest.AllowUserToAddRows = False
        Me.dgvTest.AllowUserToDeleteRows = False
        Me.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTest.Location = New System.Drawing.Point(16, 114)
        Me.dgvTest.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTest.MultiSelect = False
        Me.dgvTest.Name = "dgvTest"
        Me.dgvTest.ReadOnly = True
        Me.dgvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTest.Size = New System.Drawing.Size(671, 369)
        Me.dgvTest.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(740, 114)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mã phiếu xuất"
        '
        'txbMaPhieuXuat
        '
        Me.txbMaPhieuXuat.Location = New System.Drawing.Point(160, 11)
        Me.txbMaPhieuXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMaPhieuXuat.Name = "txbMaPhieuXuat"
        Me.txbMaPhieuXuat.Size = New System.Drawing.Size(132, 22)
        Me.txbMaPhieuXuat.TabIndex = 6
        '
        'txbMaDaiLy
        '
        Me.txbMaDaiLy.Location = New System.Drawing.Point(160, 65)
        Me.txbMaDaiLy.Margin = New System.Windows.Forms.Padding(4)
        Me.txbMaDaiLy.Name = "txbMaDaiLy"
        Me.txbMaDaiLy.Size = New System.Drawing.Size(132, 22)
        Me.txbMaDaiLy.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mã đại lý"
        '
        'txbTongTriGia
        '
        Me.txbTongTriGia.Location = New System.Drawing.Point(456, 65)
        Me.txbTongTriGia.Margin = New System.Windows.Forms.Padding(4)
        Me.txbTongTriGia.Name = "txbTongTriGia"
        Me.txbTongTriGia.Size = New System.Drawing.Size(132, 22)
        Me.txbTongTriGia.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(316, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tổng trị giá"
        '
        'txbNgapLapPhieu
        '
        Me.txbNgapLapPhieu.Location = New System.Drawing.Point(456, 10)
        Me.txbNgapLapPhieu.Margin = New System.Windows.Forms.Padding(4)
        Me.txbNgapLapPhieu.Name = "txbNgapLapPhieu"
        Me.txbNgapLapPhieu.Size = New System.Drawing.Size(132, 22)
        Me.txbNgapLapPhieu.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ngày lập phiếu"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(740, 175)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(100, 28)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(740, 241)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 498)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txbNgapLapPhieu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbTongTriGia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbMaDaiLy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbMaPhieuXuat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvTest)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Test"
        Me.Text = "Form2"
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTest As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txbMaPhieuXuat As TextBox
    Friend WithEvents txbMaDaiLy As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbTongTriGia As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbNgapLapPhieu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpdate As Button
End Class
