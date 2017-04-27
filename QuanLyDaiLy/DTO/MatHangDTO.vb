Namespace QuanLyDaiLyDTO
    Public Class MatHangDTO
        Private strMamathang As String
        Private strTenmathang As String
        Private intSoluongton As Integer
        Property MaMatHang() As String
            Get
                Return strMamathang
            End Get
            Set(value As String)
                strMamathang = value
            End Set
        End Property
        Property TenMatHang() As String
            Get
                Return strTenmathang
            End Get
            Set(value As String)
                strTenmathang = value
            End Set
        End Property
        Property SoLuongTon() As Integer
            Get
                Return intSoluongton
            End Get
            Set(value As Integer)
                intSoluongton = value
            End Set
        End Property
    End Class
End Namespace

