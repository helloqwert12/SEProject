Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
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
        'Lay so luong mat hang toi da
        Public Function SoMatHang(ByVal MaMatHang As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("MATHANG", "MaMatHang")
            Return data.Rows.Count
        End Function
        'Lay so luong don vi tinh toi da
        Public Function SoDonViTinh(ByVal MaDonViTinh As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("DONVITINH", "MaDonViTinh")
            Return data.Rows.Count
        End Function
        ''Kiem tra QD2: So luong mat hang da dk khong vuot qua so mat hang toi da
        Public Function ThoaManMatHangToiDa(ByVal MaMatHang As String) As Boolean
            Dim slgMatHangDk = SoMatHang(MaMatHang)
            Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            Dim soMatHangToida As Integer = data.Rows(0)(3)
            If slgMatHangDk < soMatHangToida Then
                Return True
            Else
                Return False
            End If
        End Function
        'Kiem tra QD2: So luong don vi tinh da dk khong vuot qua so don vi tinh toi da
        Public Function ThoaManDonViTinhToiDa(ByVal MaDonViTinh As String) As Boolean
            Dim slgDonViTinhgDk = SoDonViTinh(MaDonViTinh)
            Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            Dim soDonViTinhToida As Integer = data.Rows(0)(4)
            If slgDonViTinhgDk < soDonViTinhToida Then
                Return True
            Else
                Return False
            End If
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