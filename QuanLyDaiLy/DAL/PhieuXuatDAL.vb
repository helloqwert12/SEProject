Imports DTO.QuanLyDaiLyDTO
Imports System
Imports System.Data.SqlClient
Imports System.Data

Namespace QuanLyDaiLyDAL
    Public Class PhieuXuatDAL
        Public Function Insert(PhieuXuat As PhieuXuatHangDTO, CTPhieuXuat As ChiTietPhieuXuatDTO)
            'Luu xuong bang PHIEUXUAT
            Dim query As String = String.Empty
            query &= "INSERT INTO PHIEUXUAT(MaPhieuXuat, MaDaiLy, NgayLapPhieu, TongTriGia)"
            query &= "VALUES (@MaPhieuXuat, @MaDaiLy, @NgayLapPhieu, @TongTriGia)"

            Using conn As New SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
                Using comm As New SqlCommand()
                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@MaPhieuXuat", PhieuXuat.MaPhieuXuat)
                        .Parameters.AddWithValue("@MaDaiLy", PhieuXuat.MaDaiLy)
                        .Parameters.AddWithValue("@NgayLapPhieu", PhieuXuat.NgayLapPhieu)
                        .Parameters.AddWithValue("@TongTriGia", PhieuXuat.TongTriGia)

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

            'Luu xuong bang CT_PHIEUXUAT
            query = String.Empty
            query &= "INSERT INTO CHITIETPHIEUXUAT(MaChiTietPhieuXuat, MaPhieuXuat, MaMatHang, MaDonViTinh, SoLuongXuat, DonGia, ThanhTien)"
            query &= "VALUES (@MaChiTietPhieuXuat, @MaPhieuXuat, @MaMatHang, @MaDonViTinh, @SoLuongXuat, @DonGia, @ThanhTien)"

            Using conn As New SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
                Using comm As New SqlCommand()
                    With comm
                        .Connection = conn
                        .CommandType = CommandType.Text
                        .CommandText = query
                        .Parameters.AddWithValue("@MaChiTietPhieuXuat", CTPhieuXuat.MaCTPhieuXuat)
                        .Parameters.AddWithValue("@MaPhieuXuat", CTPhieuXuat.MaPhieuXuat)
                        .Parameters.AddWithValue("@MaMatHang", CTPhieuXuat.MaMatHang)
                        .Parameters.AddWithValue("@MaDonViTinh", CTPhieuXuat.MaDonViTinh)
                        .Parameters.AddWithValue("@SoLuongXuat", CTPhieuXuat.SoLuongXuat)
                        .Parameters.AddWithValue("@DonGia", CTPhieuXuat.DonGia)
                        .Parameters.AddWithValue("@ThanhTien", CTPhieuXuat.ThanhTien)

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
