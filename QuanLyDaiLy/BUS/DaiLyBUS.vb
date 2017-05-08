Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class DaiLyBUS
        'Lay so luong dai ly da dang ky cua quan
        Private Function SoDaiLyCuaQuan(ByVal DaiLy As DaiLyDTO, ByVal Quan As QuanDTO) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("DAILY", "MaDaiLy", "MaQuan= " + "'" + Quan.MaQuan + "'")
            Return data.Rows.Count
        End Function
        'Kiem tra QD1: So luong dai ly da dk khong vuot qua so dai ly toi da trong quan
        Public Function ThoaManDaiLyToiDa(ByVal DaiLy As DaiLyDTO, ByVal Quan As QuanDTO) As Boolean
            Dim slgDailyDk = SoDaiLyCuaQuan(DaiLy, Quan)
            Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            Dim soDailyToida As Integer = data.Rows(0)(0)
            If slgDailyDk < soDailyToida Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace

