Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyDAL
    Public Class ThamSoDAL
        Public Function LayDuLieu() As DataTable
            Return KetNoiDAL.LayDuLieu("THAMSO")
        End Function
        Public Function ThemDuLieu(ThamSo As ThamSoDTO) As Boolean
            Dim success = KetNoiDAL.ThemDuLieu("THAMSO", ThamSo.SoLuongDLToiDa, ThamSo.ApDung)
            If success Then
                Return True
            End If
            Return False
        End Function
        'Xoa du lieu
        Public Function XoaDuLieu(ByVal tendieukien As String, ByVal giatridieukien As String) As Boolean
            If KetNoiDAL.XoaDuLieu("THAMSO", tendieukien, giatridieukien) Then
                Return True
            End If
            Return False
        End Function
    End Class
End Namespace

