Namespace QuanLyDaiLyDTO
    Public Class DaiLyDTO
        Private strMadaily As String
        Private strTendaily As String
        Private strMaloaidaily As String
        Private strDienthoai As String
        Private strDiachi As String
        Private strMaquan As String
        Private dateNgaytiepnhan As Date
        Private strEmail As String
        Private longNodaily As Long
        Property MaDaiLy() As String
            Get
                Return strMadaily
            End Get
            Set(value As String)
                strMadaily = value
            End Set
        End Property
        Property TenDaiLy() As String
            Get
                Return strTendaily
            End Get
            Set(value As String)
                strTendaily = value
            End Set
        End Property
        Property MaLoaiDaiLy() As String
            Get
                Return strMaloaidaily
            End Get
            Set(value As String)
                strMaloaidaily = value
            End Set
        End Property
        Property DienThoai() As String
            Get
                Return strDiachi
            End Get
            Set(value As String)
                strDiachi = value
            End Set
        End Property

        Property DaiChi() As String
            Get
                Return strDiachi
            End Get
            Set(value As String)
                strDiachi = value
            End Set
        End Property
        Property MaQuan() As String
            Get
                Return strMaquan
            End Get
            Set(value As String)
                strMaquan = value
            End Set
        End Property
        Property NgayTiepNhan() As Date
            Get
                Return dateNgaytiepnhan
            End Get
            Set(value As Date)
                dateNgaytiepnhan = value
            End Set
        End Property
        Property Email() As String
            Get
                Return strEmail
            End Get
            Set(value As String)
                strEmail = value
            End Set
        End Property
        Property NoDaiLy() As Long
            Get
                Return longNodaily
            End Get
            Set(value As Long)
                longNodaily = value
            End Set
        End Property
    End Class
End Namespace

