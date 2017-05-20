Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Namespace QuanLyDaiLyBUS
    Public Class LoaiDaiLyBUS
        Public Function IsValid_NoToiDa(LoaiDaiLy As LoaiDaiLyDTO) As Boolean
            If LoaiDaiLy.NoToiDa < 0 Then
                Return False
            Else
                Return True
            End If
        End Function
        'Kiem tra rong
        Public Function IsEmpty(ByVal LoaiDaiLy As LoaiDaiLyDTO) As Boolean
            If (LoaiDaiLy.MaLoaiDaiLy = String.Empty Or
                LoaiDaiLy.TenLoaiDaiLy = String.Empty) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace

