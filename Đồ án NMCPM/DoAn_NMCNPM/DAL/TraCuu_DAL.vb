Imports System.Windows.Forms
Imports DAL.DoAn_NMCNPM

Public Class TraCuu_DAL
    Private Shared _instance As TraCuu_DAL
    Public Shared Property Instance As TraCuu_DAL
        Get
            If (_instance Is Nothing) Then
                _instance = New TraCuu_DAL
            End If
            Return _instance
        End Get
        Set(value As TraCuu_DAL)
            _instance = value
        End Set
    End Property

    Public Function Load() As DataTable
        Dim query As String = " select SACH.MaSach , TenSach , TheLoai , TacGia , SoLuongTon , DonGia from sach"
        'join CHI_TIET_PHIEU_NHAP on CHI_TIET_PHIEU_NHAP.MaSach = SACH.MaSach join PHIEU_NHAP on PHIEU_NHAP.MaPhieuNhap = CHI_TIET_PHIEU_NHAP.MaPhieuNhap"
        Dim Data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        Return Data

    End Function

    Public Function TraCuuSoLuongTon(Tu As String, Den As String) As DataTable
        Dim query As String = "select*from sach where SoLuongTon between @Tu and @den "
        Dim param() As Object = {Tu, Den}

        Dim Data As DataTable = DataProvider.Instance.ExecuteQuery(query, param)

        Return Data
    End Function

End Class
