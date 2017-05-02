
Imports System
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Namespace QuanLyDaiLyDAL
    Public Class KetNoiDAL
#Region "Khai bao Connection"
        Public Shared connet As SqlConnection
#End Region

#Region "Cac ham ket noi"
        'Khoi tao ket noi
        Public Shared Sub TaoKetNoi()
            connet = New SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        End Sub
        'Mo ket noi den CSDL
        Public Shared Function MoKetNoi() As Boolean
            Try
                connet.Open()
                Return True
            Catch ex As Exception
                MessageBox.Show("Kết nối đến CSDL không thành công, vui lòng thử lại", "THÔNG BÁO")
                Return False
            End Try
        End Function
        'Ngat ket noi voi CSDL
        Public Shared Function NgatKetNoi() As Boolean
            Try
                If (connet.State = ConnectionState.Open) Then
                    connet.Close()
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
        'Kiem tra xem ket noi co dang mo khong
        Public Shared Function DangMo() As Boolean
            If (connet.State = ConnectionState.Open) Then
                Return True
            End If
            Return False
        End Function
        'Lay du lieu tu mot bang
        Public Shared Function LayDuLieu(ByVal tenbang As String) As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                adapter = New SqlDataAdapter("SELECT * FROM " + tenbang, connet)
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function
        'Lay du lieu tu bang voi dieu kien cho truoc
        Public Shared Function LayDuLieu(ByVal tenbang As String,
                                         ByVal dieukien As String) As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                adapter = New SqlDataAdapter("SELECT * FROM " + tenbang + " WHERE " + dieukien, connet)
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function
        'Lay du lieu tu mot thuoc tinh voi dieu kien cho truoc (neu co)
        Public Shared Function LayDuLieu(ByVal tenbang As String,
                                         ByVal thuoctinh As String,
                                         Optional ByVal dieukien As String = "") As DataTable
            Dim dtTable As DataTable
            Dim adapter As SqlDataAdapter
            Dim dtSet As DataSet
            dtTable = New DataTable()
            dtSet = New DataSet()
            Try
                If (dieukien = "") Then
                    adapter = New SqlDataAdapter("SELECT" + thuoctinh + " FROM " + tenbang, connet)
                Else
                    adapter = New SqlDataAdapter("SELECT" + thuoctinh + " FROM " + tenbang + " WHERE " + dieukien, connet)
                End If
                adapter.Fill(dtSet)
                dtTable = dtSet.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Không tải được dữ liệu", "THÔNG BÁO")
            End Try
            Return dtTable
        End Function
        'Them du lieu vao bang
        Public Shared Function ThemDuLieu(ByVal tenbang As String,
                                          ByVal ParamArray gtthuoctinh As String()) As Boolean
            Dim str As String = ("INSERT INTO " + tenbang + " VALUES('")

            For Each i As String In gtthuoctinh
                str &= (i + "','")
            Next
            str = str.Remove(str.Length - 2, 2)
            str &= " )"

            Dim sqlCmd As SqlCommand
            sqlCmd = New SqlCommand(str, connet)
            Try
                sqlCmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        'Xoa du lieu tu bang voi dieu kien cho truoc
        Public Shared Function XoaDuLieu(ByVal tenbang As String,
                                         ByVal tendieukien As String,
                                         ByVal giatridieukien As String) As Boolean
            Dim str As String = ("DELETE FROM " + tenbang + " WHERE " + tendieukien + " = " + " '" + giatridieukien + "'")

            Dim sqlCmd As SqlCommand
            sqlCmd = New SqlCommand(str, connet)
            Try
                If sqlCmd.ExecuteNonQuery() = 0 Then
                    MessageBox.Show("Không tìm thấy dữ liệu cần xóa. Vui lòng kiểm tra lại", "THÔNG BÁO")
                End If
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        'Cap nhat du lieu moi voi dieu kien cho truoc
        'Chua test
        Public Shared Function CapNhatDuLieu(ByVal tenbang As String,
                                             ByVal tendieukien As String,
                                             ByVal giatridieukien As String,
                                             ByVal ParamArray thuoctinhvagt As String()) As Boolean
            Dim str As String = ("UPDATE " + tenbang + " SET ")
            For i = 0 To thuoctinhvagt.Length - 1
                If i Mod 2 = 0 Then
                    str &= (thuoctinhvagt(i) + "=")
                Else
                    str &= ("'" + thuoctinhvagt(i) + "',")
                End If
            Next
            str = str.Remove(str.Length - 1, 1)
            str &= ("WHERE " + tendieukien + " ='" + giatridieukien + "'")
            Dim sqlCmd As SqlCommand
            sqlCmd = New SqlCommand(str, connet)
            Try
                sqlCmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
#End Region

    End Class
End Namespace

