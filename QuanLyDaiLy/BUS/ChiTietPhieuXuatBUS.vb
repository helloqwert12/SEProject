Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyBUS
    Public Class ChiTietPhieuXuatBUS
        'Kiem tra rong
        Public Function IsEmpty(ByVal ChiTietPhieuXuat As ChiTietPhieuXuatDTO, ByVal MatHang As MatHangDTO, ByVal PhieuXuat As PhieuXuatDTO) As Boolean
            If (ChiTietPhieuXuat.MaDonViTinh = String.Empty Or
                ChiTietPhieuXuat.MaMatHang = String.Empty Or
                ChiTietPhieuXuat.SoLuongXuat = String.Empty Or
                ChiTietPhieuXuat.DonGia = String.Empty Or
                PhieuXuat.MaPhieuXuat.ToString() = String.Empty Or
                PhieuXuat.MaDaiLy = String.Empty Or
                PhieuXuat.NgayLapPhieu = String.Empty Or
                MatHang.TenMatHang = String.Empty) Then
                Return True
            Else
                Return False
            End If
        End Function
        'Kiem tra QD2: So luong mat hang da dk khong vuot qua so mat hang toi da
        Public Function ThoaManMatHangToiDa(ByVal MaMatHang As String) As Boolean
            'Dim slgDailyDk = SoDaiLyCuaQuan(MaQuan)
            'Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            'Dim soDailyToida As Integer = data.Rows(0)(0)
            'If slgDailyDk < soDailyToida Then
            '    Return True
            'Else
            '    Return False
            'End If
        End Function
        'Kiem tra QD2: So luong don vi tinh da dk khong vuot qua so don vi tinh toi da
        Public Function ThoaManDonViTinhToiDa(ByVal MaDonViTinh As String) As Boolean
            'Dim slgDailyDk = SoDaiLyCuaQuan(MaQuan)
            'Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            'Dim soDailyToida As Integer = data.Rows(0)(0)
            'If slgDailyDk < soDailyToida Then
            '    Return True
            'Else
            '    Return False
            'End If
        End Function
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
End Namespace