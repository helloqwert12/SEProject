Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyDAL
    Public Class ThamSoDAL
        Public Function LayDuLieu() As DataTable
            Return KetNoiDAL.LayDuLieu("THAMSO")
        End Function
        Public Function CapNhatDuLieu(ByVal ThamSo As ThamSoDTO, ByVal soluongtoida As String) As Boolean
            If KetNoiDAL.CapNhatDuLieu("THAMSO", "SoLuongDLToiDa", ThamSo.SoLuongDLToiDa, "SoLuongDLToiDa", soluongtoida) Then
                Return True
            End If
            Return False
        End Function
    End Class
End Namespace

