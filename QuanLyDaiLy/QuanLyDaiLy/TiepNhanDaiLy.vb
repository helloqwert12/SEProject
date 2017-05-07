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
        Dim dTable As DataTable = _DBAcess.LayDuLieu("DAILY")
        Me.dgvTiepNhanDaiLy.DataSource = dTable
        With Me.dgvTiepNhanDaiLy
            .Columns(0).HeaderText = "Mã đại lý"
            .Columns(1).HeaderText = "Mã loại đại lý"
            .Columns(2).HeaderText = "Tên đại lý"
            .Columns(3).HeaderText = "Điện thoại"
            .Columns(4).HeaderText = "Địa chỉ"
            .Columns(5).HeaderText = "Mã quận"
            .Columns(6).HeaderText = "Ngày tiếp nhận"
            .Columns(7).HeaderText = "E-mail"
            .Columns(8).HeaderText = "Nợ đại lý"
        End With
        '_DBAcess.NgatKetNoi()
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub
End Class