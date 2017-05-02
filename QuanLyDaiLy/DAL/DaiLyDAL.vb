Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyDAL
    Public Class DaiLyDAL
        'Lay du lieu trong bang
        Public Function LayDuLieu(DaiLy As DaiLyDTO) As DataTable
            Return KetNoiDAL.LayDuLieu("DAILY")
        End Function
        Public Function LayDuLieu(DaiLy As DaiLyDTO, ByVal dieukien As String) As DataTable
            Return KetNoiDAL.LayDuLieu("DAILY", dieukien)
        End Function
        Public Function LayDuLieu(DaiLy As DaiLyDTO, ByVal thuoctinh As String, Optional ByVal dieukien As String = "") As DataTable
            Return KetNoiDAL.LayDuLieu("DAILY", thuoctinh, dieukien)
        End Function
        'Them du lieu vao bang
        Public Function ThemDuLieu(DaiLy As DaiLyDTO) As Boolean
            Dim success = KetNoiDAL.ThemDuLieu("DAILY", DaiLy.MaDaiLy, DaiLy.MaLoaiDaiLy,
                                 DaiLy.TenDaiLy, DaiLy.DienThoai, DaiLy.DiaChi,
                                 DaiLy.MaQuan, DaiLy.NgayTiepNhan, DaiLy.Email,
                                 DaiLy.NoDaiLy)
            If success Then
                Return True
            End If
            Return False
        End Function
        'Xoa du lieu
        Public Function XoaDuLieu(DaiLy As DaiLyDTO, ByVal tendieukien As String, ByVal giatridieukien As String) As Boolean
            If KetNoiDAL.XoaDuLieu("DAILY", tendieukien, giatridieukien) Then
                Return True
            End If
            Return False
        End Function
        'Cap nhat du lieu
        Public Function CapNhatDuLieu(ByVal tendieukien As String,
                                             ByVal giatridieukien As String,
                                             ByVal ParamArray thuoctinhvagt As String()) As Boolean
            If KetNoiDAL.CapNhatDuLieu("DAILY", tendieukien, giatridieukien, thuoctinhvagt) Then
                Return True
            End If
            Return False
        End Function
    End Class

End Namespace
