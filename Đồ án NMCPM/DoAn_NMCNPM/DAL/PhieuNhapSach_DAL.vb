Imports System.Windows.Forms
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class PhieuNhapSach_DAL
    Private Shared _instance As PhieuNhapSach_DAL

    Public Shared Property Instance As PhieuNhapSach_DAL
        Get
            If (_instance Is Nothing) Then
                _instance = New PhieuNhapSach_DAL
            End If
            Return _instance
        End Get
        Set(value As PhieuNhapSach_DAL)
            _instance = value
        End Set
    End Property

    Public Function InsertPhieuNhap(_PhieuNhap As PhieuNhapSach_DTO) As Boolean
        Dim query As String = "insert into PHIEU_NHAP values ( @MaPhieuNhap , @NgayNhap )"
        Dim param() As Object = {_PhieuNhap.MaPhieuNhap, _PhieuNhap.NgayNhap}
        If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function loadDataRow(_MaSach As String) As DataRow
        Dim Data As DataRow = Nothing
        If Sach_DAL.Instance.Kiemtratontai(_MaSach) = True Then
            Dim query As String = "select TenSach , TheLoai , TacGia , SoLuongTon , DonGia from sach where MaSach = @MaSach"
            Dim param() As Object = {_MaSach}
            Data = DataProvider.Instance.ExecuteQuery(query, param).Rows(0)
        End If

        Return Data
    End Function

End Class
