Imports DTO.QuanLyDaiLyDTO
Imports System
Imports System.Data.SqlClient
Imports System.Data
Namespace QuanLyDaiLyDAL
    Public Class DaiLyDAL
        Public Function Insert(DaiLy As DaiLyDTO) As Integer
            Dim query As String = String.Empty
            query &= "INSERT INTO DAILY(MaDaiLy, TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, MaQuan, NgayTiepNhan, Email, NoDaiLy)"
            query &= "VALUES (@MaDaiLy, @TenDaiLy, @MaLoaiDaiLy, @DienThoai, @DiaChi, @MaQuan, @NgayTiepNhan, @Email, @NoDaiLy)"

            Using conn As New SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
                Using comm As New SqlCommand()
                    Dim sa As SqlDataAdapter
                    sa = New SqlDataAdapter()

                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@MaDaiLy", DaiLy.MaDaiLy)
                        .Parameters.AddWithValue("@TenDaiLy", DaiLy.TenDaiLy)
                        .Parameters.AddWithValue("@MaLoaiDaiLy", DaiLy.MaLoaiDaiLy)
                        .Parameters.AddWithValue("@DienThoai", DaiLy.DienThoai)
                        .Parameters.AddWithValue("@DiaChi", DaiLy.DiaChi)
                        .Parameters.AddWithValue("@MaQuan", DaiLy.MaQuan)
                        .Parameters.AddWithValue("@NgayTiepNhan", DaiLy.NgayTiepNhan)
                        .Parameters.AddWithValue("@Email", DaiLy.Email)
                        .Parameters.AddWithValue("@NoDaiLy", DaiLy.NoDaiLy)

                    End With
                    Try
                        conn.Open()
                        comm.ExecuteNonQuery()
                    Catch
                        conn.Close()
                        Return 1 'that bai
                    End Try
                End Using
            End Using
            Return 0 'thanh cong
        End Function


    End Class

End Namespace
