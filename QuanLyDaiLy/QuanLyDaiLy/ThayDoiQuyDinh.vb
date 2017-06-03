Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS

Public Class ThayDoiQuyDinh
    Dim thamsoDTO As ThamSoDTO
    Dim thamsoDAL As ThamSoDAL
    Dim thamsoBUS As ThamSoBUS
    Public Sub New()
        InitializeComponent()

        KetNoiDAL.TaoKetNoi()
        KetNoiDAL.MoKetNoi()

        thamsoDTO = New ThamSoDTO()
        thamsoDAL = New ThamSoDAL()
        thamsoBUS = New ThamSoBUS()
        'Load du lieu tu bang THAMSO
        txbHienTai.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(0)
        txbMoi.Text = txbHienTai.Text


    End Sub
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If Not (thamsoBUS.IsValid_SoLuongDLToiDa(txbMoi.Text)) Then
            MessageBox.Show("Số đại lý của mỗi quận hiện tại không thể nhỏ hơn 1", "Xác Nhận", MessageBoxButtons.OK)
        Else
            If (txbMoi.Text > thamsoBUS.KiemTraSoDaiLyToiDa()) Then
                KetNoiDAL.XoaDuLieu("THAMSO")
                If (cbApDung.Checked = True) Then
                    thamsoDTO.ApDung = 1
                Else
                    thamsoDTO.ApDung = 0
                End If
                thamsoDTO.SoLuongDLToiDa = txbMoi.Text
                Dim success As Boolean = thamsoDAL.ThemDuLieu(thamsoDTO)
                If success Then
                    MessageBox.Show("Cập nhật quy định thành công")
                    txbHienTai.Text = KetNoiDAL.LayDuLieu("THAMSO").Rows(0)(0)
                Else
                    MessageBox.Show("Cập nhật quy định thất bại, vui lòng kiểm tra lại")
                End If
            Else
                MessageBox.Show("Số đại lý của mỗi quận hiện tại không thể nhỏ hơn " + thamsoBUS.KiemTraSoDaiLyToiDa().ToString() + "", "Xác Nhận", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim rslt As DialogResult = MessageBox.Show("Xác nhận thoát Thay đổi quy định?", "XÁC NHẬN", MessageBoxButtons.YesNo)
        If rslt = DialogResult.Yes Then
            Dim menu As New Menu()
            Me.Dispose()
            'menu.rmMenu.ShowPopup(New Point())
            'menu.btnMenu.Show()
            'Application.Exit()
        End If
    End Sub
End Class