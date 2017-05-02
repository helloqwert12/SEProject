Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class Test
    'Khai bao bien de truy xuat DB tu Database QLDL
    Private _DBAcess As KetNoiDAL

    'Dinh nghia thu tuc load du lieu tu bang Test theot tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        _DBAcess = New KetNoiDAL()
        _DBAcess.connet = New SqlClient.SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        '_DBAcess.connet = New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        _DBAcess.TaoKetNoi()
        _DBAcess.MoKetNoi()
        Dim dTable As DataTable = _DBAcess.LayDuLieu("PHIEUXUAT")
        Me.dgvTest.DataSource = dTable
        With Me.dgvTest
            .Columns(0).HeaderText = "MaPhieuXuat"
            .Columns(1).HeaderText = "MaDaily"
            .Columns(2).HeaderText = "NgayLapPhieu"
            .Columns(3).HeaderText = "TongTriGia"
        End With
        '_DBAcess.NgatKetNoi()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim phieuxuat As PhieuXuatDTO
        phieuxuat = New PhieuXuatDTO()

        '1 Mapping data from GUI Control
        phieuxuat.MaPhieuXuat = txbMaPhieuXuat.Text
        phieuxuat.MaDaiLy = txbMaDaiLy.Text
        phieuxuat.NgayLapPhieu = Date.Parse(txbNgapLapPhieu.Text)
        phieuxuat.TongTriGia = Long.Parse(txbTongTriGia.Text)

        '2 Business


        '3 Insert to DB
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.ThemDuLieu(phieuxuat)
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()


    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.XoaDuLieu("MaDaiLy", "DL09")
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim phieuxuatdal As PhieuXuatDAL
        phieuxuatdal = New PhieuXuatDAL()
        Dim success As Boolean
        success = phieuxuatdal.CapNhatDuLieu("MaDaiLy", "DL06", "TongTriGia", "111111")
        If success Then
            MessageBox.Show("THÀNH CMN CÔNG", "THÔNG CMN BÁO")
        Else
            MessageBox.Show("THẤT CMN BẠI", "THÔNG CMN BÁO")
        End If
        LoadDataOnGridView()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        'Hiện bảng Excel sau khi nhấn Export (chưa save)
        Dim ExcelApp As Object
        Dim Lig_cpt, Col_cpt As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelApp.workbooks.add()

        ExcelApp.visible = True

        Try
            'Change Properties of the Workbook
            ExcelApp.Columns.ColumnWidth = 20
            For Col_cpt = 0 To dgvTest.ColumnCount - 1
                ExcelApp.ActiveSheet.cells(1, Col_cpt + 1).value = dgvTest.Columns(Col_cpt).HeaderText
            Next
            For Lig_cpt = 0 To dgvTest.Rows.Count - 1
                For Col_cpt = 0 To dgvTest.ColumnCount - 1
                    If IsNumeric(dgvTest.Item(Col_cpt, Lig_cpt).Value) Then
                        ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = CDbl(dgvTest.Item(Col_cpt, Lig_cpt).Value)
                    Else
                        ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = dgvTest.Item(Col_cpt, Lig_cpt).Value
                    End If
                Next
            Next
        Catch ex As Exception
        End Try

        'Nhấn export => Save trước rồi mở file Excel thủ công
        'SaveFileDialog1.Title = "Save as Excel File"
        'SaveFileDialog1.FileName = ""
        'SaveFileDialog1.Filter = "Excel File 2007 (*.xlsx)|*.xlsx|Excel File 2003(*.xls)|*.xls"
        'If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
        '    Dim ExcelApp As Microsoft.Office.Interop.Excel.Application
        '    ExcelApp = New Microsoft.Office.Interop.Excel.Application()
        '    ExcelApp.Application.Workbooks.Add(Type.Missing)

        '    'Change Properties of the Workbook
        '    ExcelApp.Columns.ColumnWidth = 20
        '    'Store header part in Excel
        '    Try
        '        For Col_cpt = 0 To dgvTest.ColumnCount - 1
        '            ExcelApp.ActiveSheet.cells(1, Col_cpt + 1).value = dgvTest.Columns(Col_cpt).HeaderText
        '        Next
        '        For Lig_cpt = 0 To dgvTest.Rows.Count - 1
        '            For Col_cpt = 0 To dgvTest.ColumnCount - 1
        '                If IsNumeric(dgvTest.Item(Col_cpt, Lig_cpt).Value) Then
        '                    ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = CDbl(dgvTest.Item(Col_cpt, Lig_cpt).Value)
        '                Else
        '                    ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = dgvTest.Item(Col_cpt, Lig_cpt).Value
        '                End If
        '            Next
        '        Next
        '        MsgBox("Export Data thanh cong", MsgBoxStyle.Information)

        '        ExcelApp.ActiveWorkbook.SaveCopyAs(SaveFileDialog1.FileName.ToString())
        '        ExcelApp.ActiveWorkbook.Saved = True
        '        ExcelApp.Quit()
        '    Catch ex As Exception
        '        MsgBox("Export Data that bai", MsgBoxStyle.Critical)
        '    End Try
        'End If
    End Sub
End Class