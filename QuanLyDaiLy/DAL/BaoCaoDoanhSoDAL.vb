﻿Imports DTO.QuanLyDaiLyDTO
Namespace QuanLyDaiLyDAL
    Public Class BaoCaoDoanhSoDAL
        'Lay du lieu trong bang
        Public Function LayDuLieu() As DataTable
            Return KetNoiDAL.LayDuLieu("BAOCAODOANHSO")
        End Function
        Public Function LayDuLieu(ByVal dieukien As String) As DataTable
            Return KetNoiDAL.LayDuLieu("BAOCAODOANHSO", dieukien)
        End Function
        Public Function LayDuLieu(ByVal thuoctinh As String, Optional ByVal dieukien As String = "") As DataTable
            Return KetNoiDAL.LayDuLieu("BAOCAODOANHSO", thuoctinh, dieukien)
        End Function
        'Public Function LayDuLieu(ByVal dieukien As String, ParamArray tenthuoctinh As String()) As DataTable
        '    Return KetNoiDAL.LayDuLieu("BAOCAODOANHSO", dieukien, tenthuoctinh)
        'End Function
        'Them du lieu vao bang
        Public Function ThemDuLieu(Baocaodoanhso As BaoCaoDoanhSoDTO) As Boolean
            Dim success = KetNoiDAL.ThemDuLieu("BAOCAODOANHSO", Baocaodoanhso.MaBaoCaoDoanhSo, Baocaodoanhso.MaDaiLy, Baocaodoanhso.SoPhieuXuat,
                                               Baocaodoanhso.ThoiGian, Baocaodoanhso.TongTriGia, Baocaodoanhso.TyLe)
            If success Then
                Return True
            End If
            Return False
        End Function
        'Xoa du lieu
        Public Function XoaDuLieu(ByVal tendieukien As String, ByVal giatridieukien As String) As Boolean
            If KetNoiDAL.XoaDuLieu("BAOCAODOANHSO", tendieukien, giatridieukien) Then
                Return True
            End If
            Return False
        End Function
        'Cap nhat du lieu
        Public Function CapNhatDuLieu(ByVal tendieukien As String,
                                             ByVal giatridieukien As String,
                                             ByVal ParamArray thuoctinhvagt As String()) As Boolean
            If KetNoiDAL.CapNhatDuLieu("BAOCAODOANHSO", tendieukien, giatridieukien, thuoctinhvagt) Then
                Return True
            End If
            Return False
        End Function
    End Class

End Namespace
