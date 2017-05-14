Imports DTO.QuanLyDaiLyDTO
Imports DAL.QuanLyDaiLyDAL
Imports Geocoding
Imports Geocoding.Google
Imports System.Collections.Generic
Namespace QuanLyDaiLyBUS
    Public Class DaiLyBUS
        'Kiem tra rong
        Public Function IsEmpty(ByVal DaiLy As DaiLyDTO) As Boolean
            If (DaiLy.MaDaiLy = String.Empty Or
                DaiLy.MaLoaiDaiLy = String.Empty Or
                DaiLy.MaQuan = String.Empty Or
                DaiLy.NgayTiepNhan.ToString() = String.Empty Or
                DaiLy.TenDaiLy = String.Empty Or
                DaiLy.DienThoai = String.Empty Or
                DaiLy.DiaChi = String.Empty) Then
                Return True
            Else
                Return False
            End If
        End Function

        'Lay so luong dai ly da dang ky cua quan
        Public Function SoDaiLyCuaQuan(ByVal MaQuan As String) As Integer
            Dim data As DataTable
            data = KetNoiDAL.LayDuLieu("DAILY", "MaDaiLy", "MaQuan= " + "'" + MaQuan + "'")
            Return data.Rows.Count
        End Function

        'Kiem tra QD1: So luong dai ly da dk khong vuot qua so dai ly toi da trong quan
        Public Function ThoaManDaiLyToiDa(ByVal MaQuan As String) As Boolean
            Dim slgDailyDk = SoDaiLyCuaQuan(MaQuan)
            Dim data As DataTable = KetNoiDAL.LayDuLieu("THAMSO")
            Dim soDailyToida As Integer = data.Rows(0)(0)
            If slgDailyDk < soDailyToida Then
                Return True
            Else
                Return False
            End If
        End Function
        'Kiem tra dinh dang Email
        Public Function CheckEmailValidExample(ByVal Daily As DaiLyDTO, ByVal str As String) As Boolean
            If (FormatChecking.CheckValid.IsValidEmail(str)) Then
                Return True
            Else
                Return False
            End If
        End Function
        'Auto complete Dia chi
        Public Function GeoCodingExample(ByVal Daily As DaiLyDTO, ByVal str As String) As String
            Dim geocoder As IGeocoder

            geocoder = New GoogleGeocoder("AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y")

            '"AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y") 'ApiKey = "AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y"
            Dim addresses As IEnumerable(Of Address) = geocoder.Geocode(str)
            Return addresses.First().FormattedAddress 'Formatted: 1600 Pennsylvania Ave SE, Washington, DC 20003, USA
            'MessageBox.Show("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude) 'Coordinates: 38.8791981, -76.9818437
        End Function
        'Kiem tra dinh dang Dien thoai
        Public Function CheckPhoneNumberValidExample(ByVal Daily As DaiLyDTO, ByVal str As String) As Boolean
            If (FormatChecking.CheckValid.IsValidPhoneNumber(str, FormatChecking.CountryCode.Vietnam)) Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace

