Namespace QuanLyDaiLyDTO
    Public Class QuanDTO
        Private strMaquan As String
        Private strTenquan As String
        Property MaQuan() As String
            Get
                Return strMaquan
            End Get
            Set(value As String)
                strMaquan = value
            End Set
        End Property
        Property TenQuan() As String
            Get
                Return strTenquan
            End Get
            Set(value As String)
                strTenquan = value
            End Set
        End Property
    End Class
End Namespace

