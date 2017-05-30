Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class ThamSoBUS
        'Thay doi so dai ly toi ta cua quan khong duoc nho hon so dai ly nhieu nhat cua mot trong cac quan hien tai
        Public Function KiemTraSoDaiLyToiDa() As Integer
            Dim max As Integer = 0
            Dim count As Integer = 0
            Dim maquan As DataTable = KetNoiDAL.LayDuLieu("QUAN", "MaQuan", "")
            For i = 0 To maquan.Rows.Count - 1
                Dim data As DataTable = KetNoiDAL.LayDuLieu("DAILY", "MaQuan", "")
                For j = 0 To data.Rows.Count - 1
                    If maquan.Rows(i)(0) = data.Rows(j)(0) Then
                        count = count + 1
                    End If
                Next
                If (max < count) Then
                    max = count
                End If
                count = 0
            Next
            Return max
        End Function

        Public Function IsValid_SoLuongDLToiDa(ThamSo As ThamSoDTO) As Boolean
            If ThamSo.SoLuongDLToiDa <= 0 Then
                Return False
            Else
                Return True
            End If
        End Function
        '' Kiem tra QD4: Ap dung quy dinh so tien thu duoc vuot qua so tien dai ly dang no
        'Public Function KiemTraQuyDinh(ThamSo As ThamSoDTO) As Boolean
        '    If ThamSo.ApDung = 1 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'End Function
    End Class
End Namespace

