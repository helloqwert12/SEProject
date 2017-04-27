Namespace QuanLyDaiLyDTO
    Public Class DonViTinhDTO
        Private strMadonvitinh As String
        Private strTendonvitinh As String
        Property MaDonViTinh() As String
            Get
                Return strMadonvitinh
            End Get
            Set(value As String)
                strMadonvitinh = value
            End Set
        End Property
        Property TenDonViTinh() As String
            Get
                Return strTendonvitinh
            End Get
            Set(value As String)
                strTendonvitinh = value
            End Set
        End Property
    End Class
End Namespace

