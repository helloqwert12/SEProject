Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class MatHangBUS
        Public Function IsValid_SoLuongTon(MatHang As MatHangDTO) As Boolean
            If MatHang.SoLuongTon <= 0 Then
                Return False
            Else
                Return True
            End If
        End Function
        'Kiem tra rong
        Public Function IsEmpty(ByVal MatHang As MatHangDTO) As Boolean
            If (MatHang.MaMatHang = String.Empty Or
                MatHang.TenMatHang = String.Empty) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace

