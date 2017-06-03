Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class PhieuThuTienBUS
        'Kiem tra rong
        Public Function IsEmpty(ByVal PhieuThuTien As PhieuThuTienDTO) As Boolean
            If (PhieuThuTien.MaPhieuThu.ToString() = String.Empty Or
                PhieuThuTien.MaDaiLy = String.Empty Or
                PhieuThuTien.NgayThuTien.ToString() = String.Empty Or
                PhieuThuTien.SoTienThu.ToString() = String.Empty) Then
                Return True
            Else
                Return False
            End If
        End Function
        'Lay so luong phieuthu da co cua daily
        Public Function SoPhieuThuCuaDaiLy(ByVal MaDaiLy As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("PHIEUTHUTIEN", "MaPhieuThu", "MaDaiLy= " + "'" + MaDaiLy + "'")
            Return data.Rows.Count
        End Function
        'Lay so tien no cua daily
        Public Function SoTienNoCuaDaiLy(ByVal MaDaiLy As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("PHIEUTHUTIEN", "MaPhieuThu", "MaDaiLy= " + "'" + MaDaiLy + "'")
            Return data.Rows.Count
        End Function
        'Kiem tra QD4: Ap dung so tien thu vuot qua so tien no
        Public Function LayGiaTriQuyDinh() As Integer
            Dim data As Integer = KetNoiDAL.LayDuLieu("THAMSO", "ApDung", "").Rows(0)(0)
            Return data
        End Function
        Public Function XuLiQuyDinh(ByVal PhieuThuTien As PhieuThuTienDTO, ByVal NoDaiLy As Long) As Boolean
            If LayGiaTriQuyDinh() = 0 Then
                Dim temp As Long = NoDaiLy
                If (NoDaiLy < 0) Then
                    Return False
                End If
                Return True
            Else
                Return True
            End If
        End Function
    End Class
End Namespace

