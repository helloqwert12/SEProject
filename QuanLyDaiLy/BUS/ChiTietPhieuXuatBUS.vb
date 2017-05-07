Imports DTO.QuanLyDaiLyDTO
Public Class ChiTietPhieuXuatBUS
    Public Function IsValid_SoLuongXuat(CTPhieuXuat As ChiTietPhieuXuatDTO) As Boolean
        If CTPhieuXuat.SoLuongXuat < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function IsValid_DonGia(CTPhieXuat As ChiTietPhieuXuatDTO) As Boolean
        If CTPhieXuat.DonGia < 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function IsValid_ThanhTien(CTPhieXuat As ChiTietPhieuXuatDTO) As Boolean
        If CTPhieXuat.ThanhTien < 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
