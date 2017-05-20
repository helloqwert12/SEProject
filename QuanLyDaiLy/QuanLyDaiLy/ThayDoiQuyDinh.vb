Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class ThayDoiQuyDinh
    Dim ThamSoDTO As ThamSoDTO
    Dim ThamSoDAL As ThamSoDAL
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()

        ThamSoDTO = New ThamSoDTO()
        ThamSoDAL = New ThamSoDAL()
        'Load du lieu tu bang THAMSO
        txbHienTai.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(0)


    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        KetNoiDAL.XoaDuLieu("THAMSO")
        If (cbApDung.Checked = True) Then
            ThamSoDTO.ApDung = 1
        Else
            ThamSoDTO.ApDung = 0
        End If
        ThamSoDTO.SoLuongDLToiDa = txbMoi.Text
        Dim success As Boolean = ThamSoDAL.ThemDuLieu(ThamSoDTO)
        If success Then
            MessageBox.Show("Cập nhật quy định thành công")
            txbHienTai.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(0)
        Else
            MessageBox.Show("Cập nhật quy định thất bại, vui lòng kiểm tra lại")
        End If
    End Sub
End Class