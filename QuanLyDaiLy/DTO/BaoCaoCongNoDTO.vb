Namespace QuanLyDaiLyDTO
    Public Class BaoCaoCongNoDTO
#Region "DECLARE"
        Private strMadaily As String
        Private dateThoigian As Date
        Private longNodau As Long
        Private longPhatsinh As Long
        Private longNocuoi As Long
#End Region

#Region "METHOD"
        Property MaDaiLy() As String
            Get
                Return strMadaily
            End Get
            Set(value As String)
                strMadaily = value
            End Set
        End Property
        Property ThoiGian() As Date
            Get
                Return dateThoigian
            End Get
            Set(value As Date)
                dateThoigian = value
            End Set
        End Property
        Property NoDau() As Long
            Get
                Return longNodau
            End Get
            Set(value As Long)
                longNodau = value
            End Set
        End Property
        Property PhatSinh() As Long
            Get
                Return longPhatsinh
            End Get
            Set(value As Long)
                longPhatsinh = value
            End Set
        End Property
        Property NoCuoi() As Long
            Get
                Return longNocuoi
            End Get
            Set(value As Long)
                longNocuoi = value
            End Set
        End Property
#End Region

    End Class
End Namespace

