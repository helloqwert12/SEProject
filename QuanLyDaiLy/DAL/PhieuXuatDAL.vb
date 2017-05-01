Imports DTO.QuanLyDaiLyDTO
Imports System
Imports System.Data.SqlClient
Imports System.Data


Namespace QuanLyDaiLyDAL
    Public Class PhieuXuatDAL
        Public Function ThemDuLieu(ByVal PhieuXuat As PhieuXuatDTO) As Boolean
            If KetNoiDAL.ThemDuLieu("PHIEUXUAT", PhieuXuat.MaPhieuXuat, PhieuXuat.MaDaiLy, PhieuXuat.NgayLapPhieu, PhieuXuat.TongTriGia) Then
                Return True
            End If
            Return False
        End Function

        Public Function XoaDuLieu(ByVal tendieukien As String, ByVal giatridieukien As String) As Boolean
            If KetNoiDAL.XoaDuLieu("PHIEUXUAT", tendieukien, giatridieukien) Then
                Return True
            End If
            Return False
        End Function


    End Class

End Namespace
