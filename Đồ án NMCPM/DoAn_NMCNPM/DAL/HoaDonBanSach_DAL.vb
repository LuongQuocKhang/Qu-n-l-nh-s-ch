Imports System.Data.SqlClient
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class HoaDonBanSach_DAL
    Private Shared _instance As HoaDonBanSach_DAL

    Public Shared Property Instance As HoaDonBanSach_DAL
        Get
            If (_instance Is Nothing) Then
                _instance = New HoaDonBanSach_DAL
            End If
            Return _instance
        End Get
        Set(value As HoaDonBanSach_DAL)
            _instance = value
        End Set
    End Property

    Public Function loadDataRow(_MaSach As String) As DataRow
        Dim Data As DataRow = Nothing
        If Sach_DAL.Instance.Kiemtratontai(_MaSach) = True Then
            Dim query As String = "select TenSach , TheLoai , TacGia , SoLuongTon , DonGia from sach where MaSach = @MaSach"
            Dim param() As Object = {_MaSach}
            Data = DataProvider.Instance.ExecuteQuery(query, param).Rows(0)
        End If
        Return Data
    End Function

    Public Sub insertHoaDon(_HoaDon As HoaDonBanSach_DTO)
        Dim query As String = "insert into HOA_DON_BAN_SACH values ( @MaHoaDonBanSach , @MaKhachHang , @NgayLapHoaDon )"
        Dim param() As Object = {_HoaDon.MaHoaDonBanSach, _HoaDon.MaKhachHang, _HoaDon.NgayLapHoaDon}
        DataProvider.Instance.ExecuteNonQuery(query, param)
    End Sub
End Class