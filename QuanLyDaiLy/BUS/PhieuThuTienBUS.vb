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
        'Kiem tra QD4: Ap dung so tien thu vuot qua so tien no
        Public Function ApDungQuyDinh(ByVal MaDaiLy As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("THAMSO", "ApDung", "")
            Return data.Rows.ToString()
        End Function
    End Class
End Namespace

