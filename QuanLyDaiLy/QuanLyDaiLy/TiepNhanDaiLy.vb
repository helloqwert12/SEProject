Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports BUS.QuanLyDaiLyBUS
Public Class TiepNhanDaiLy
    Private _DBAcess As KetNoiDAL

    'Dinh nghia thu tuc load du lieu tu bang Test theot tung lop vao Gridview
    Private Sub LoadDataOnGridView()
        _DBAcess = New KetNoiDAL()
        '_DBAcess.connet = New SqlClient.SqlConnection("Data Source=(localdb)\MINHQUAN-s;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        '_DBAcess.connet = New SqlClient.SqlConnection("Data Source = GEFORCELIBRA \ SQLEXPRESS;Initial Catalog=QuanLyDaiLy;Integrated Security=True")
        _DBAcess.connet = New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=QuanLyDaiLy;Integrated Security=True")

        _DBAcess.TaoKetNoi()
        _DBAcess.MoKetNoi()
        Dim dTable As DataTable = _DBAcess.LayDuLieu("PHIEUXUAT")
        Me.gcTiepNhanDaiLy.DataSource = dTable
        With Me.gcTiepNhanDaiLy
            '.Columns(0).HeaderText = "MaPhieuXuat"
            '.Columns(1).HeaderText = "MaDaily"
            '.Columns(2).HeaderText = "NgayLapPhieu"
            '.Columns(3).HeaderText = "TongTriGia"
        End With
        '_DBAcess.NgatKetNoi()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub
End Class
