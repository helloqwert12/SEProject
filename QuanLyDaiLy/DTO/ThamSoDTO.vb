Namespace QuanLyDaiLyDTO
    Public Class ThamSoDTO
#Region "DECLARE"
        Private intSoluongdltoida As Integer
#End Region

#Region "METHOD"
        Property SoLuongDLToiDa() As Integer
            Get
                Return intSoluongdltoida
            End Get
            Set(value As Integer)
                intSoluongdltoida = value
            End Set
        End Property
#End Region

    End Class
End Namespace

