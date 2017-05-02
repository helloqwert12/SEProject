'Imports Microsoft.Office.Interop.Excel
'Imports System.Data.OleDb
'Namespace QuanLyDaiLyDAL
'    Public Class ExportExcel
'        Public Function Export(ByVal _table As DataTable)
'            'Hiện bảng Excel sau khi nhấn Export (chưa save)
'            Dim ExcelApp As Application
'            ExcelApp = New Application()
'            Dim Lig_cpt, Col_cpt As Integer
'            ExcelApp = CreateObject("Excel.Application")
'            ExcelApp.Workbooks.Add()

'            ExcelApp.Visible = True

'            Try
'                'Change Properties of the Workbook
'                ExcelApp.Columns.ColumnWidth = 20
'                For Col_cpt = 0 To dgvTest.ColumnCount - 1
'                    ExcelApp.ActiveSheet.cells(1, Col_cpt + 1).value = dgvTest.Columns(Col_cpt).HeaderText
'                Next
'                For Lig_cpt = 0 To dgvTest.Rows.Count - 1
'                    For Col_cpt = 0 To dgvTest.ColumnCount - 1
'                        If IsNumeric(dgvTest.Item(Col_cpt, Lig_cpt).Value) Then
'                            ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = CDbl(dgvTest.Item(Col_cpt, Lig_cpt).Value)
'                        Else
'                            ExcelApp.ActiveSheet.cells(Lig_cpt + 2, Col_cpt + 1).value = dgvTest.Item(Col_cpt, Lig_cpt).Value
'                        End If
'                    Next
'                Next
'            Catch ex As Exception
'            End Try
'        End Function
'    End Class
'End Namespace