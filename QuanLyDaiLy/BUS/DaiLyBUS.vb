Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class DaiLyBUS
        'Kiem tra rong
        Public Function IsEmpty(ByVal DaiLy As DaiLyDTO) As Boolean
            If (DaiLy.MaDaiLy = String.Empty Or
                DaiLy.MaLoaiDaiLy = String.Empty Or
                DaiLy.MaQuan = String.Empty Or
                DaiLy.NgayTiepNhan.ToString() = String.Empty Or
                DaiLy.TenDaiLy = String.Empty Or
                DaiLy.NoDaiLy.ToString() = String.Empty) Then
                Return True
            Else
                Return False
            End If

        End Function

        'Lay so luong dai ly da dang ky cua quan
        Public Function SoDaiLyCuaQuan(ByVal MaQuan As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("DAILY", "MaDaiLy", "MaQuan= " + "'" + MaQuan + "'")
            Return data.Rows.Count
        End Function

        'Kiem tra QD1: So luong dai ly da dk khong vuot qua so dai ly toi da trong quan
        Public Function ThoaManDaiLyToiDa(ByVal MaQuan As String) As Boolean
            Dim slgDailyDk = SoDaiLyCuaQuan(MaQuan)
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

