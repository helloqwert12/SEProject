﻿Namespace QuanLyDaiLyDTO
    Public Class LoaiDaiLyDTO
        Private strMaloaidaily As String
        Private strTenloaidaily As String
        Private longNotoida As Long
        Property MaLoaiDaiLy() As String
            Get
                Return strMaloaidaily
            End Get
            Set(value As String)
                strMaloaidaily = value
            End Set
        End Property
        Property TenLoaiDaiLy() As String
            Get
                Return strTenloaidaily
            End Get
            Set(value As String)
                strTenloaidaily = value
            End Set
        End Property
        Property NoToiDa() As Long
            Get
                Return longNotoida
            End Get
            Set(value As Long)
                longNotoida = value
            End Set
        End Property
    End Class
End Namespace

