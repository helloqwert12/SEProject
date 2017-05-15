Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyBUS
    Public Class PhieuXuatBUS
        Function IsValid_TongTriGia(ByVal PhieuXuat As PhieuXuatDTO) As Boolean
            If PhieuXuat.TongTriGia < 0 Then
                Return False
            Else
                Return True
            End If
        End Function
    End Class
End Namespace