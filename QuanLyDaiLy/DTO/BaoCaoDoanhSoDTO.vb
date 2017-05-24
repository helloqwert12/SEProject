Namespace QuanLyDaiLyDTO
    Public Class BaoCaoDoanhSoDTO
#Region "DECLARE"
        Private strMadaily As String
        Private floatTyle As Double
        Private dateThoigian As Date
        Private longTongtrigia As Long
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