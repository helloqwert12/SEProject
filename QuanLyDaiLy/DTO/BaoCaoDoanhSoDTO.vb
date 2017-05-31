Namespace QuanLyDaiLyDTO
    Public Class BaoCaoDoanhSoDTO
#Region "DECLARE"
        Private strMabaocaodoanhso As String
        Private strMadaily As String
        Private intThang As Integer
        Private floatTyle As Double
        Private intSophieuxuat As Integer
        Private longTongtrigia As Long
#End Region

#Region "METHOD"
        Property MaBaoCaoDoanhSo() As String
            Get
                Return strMabaocaodoanhso
            End Get
            Set(value As String)
                strMabaocaodoanhso = value
            End Set
        End Property
        Property MaDaiLy() As String
            Get
                Return strMadaily
            End Get
            Set(value As String)
                strMadaily = value
            End Set
        End Property
        Property Thang() As Integer
            Get
                Return intThang
            End Get
            Set(value As Integer)
                intThang = value
            End Set
        End Property
        Property SoPhieuXuat() As Integer
            Get
                Return intSophieuxuat
            End Get
            Set(value As Integer)
                intSophieuxuat = value
            End Set
        End Property
        Property TongTriGia() As Long
            Get
                Return longTongtrigia
            End Get
            Set(value As Long)
                longTongtrigia = value
            End Set
        End Property
        Property TyLe() As Double
            Get
                Return floatTyle
            End Get
            Set(value As Double)
                floatTyle = value
            End Set
        End Property
#End Region

    End Class
End Namespace