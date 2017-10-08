Public Class ChiTietHoaDon_DTO

    Private _MaChiTietHoaDon As String

    Public Property MaChiTietHoaDon As String
        Get
            Return _MaChiTietHoaDon
        End Get
        Set(value As String)
            _MaChiTietHoaDon = value
        End Set
    End Property

    Public Property MaHoaDonBanSach As String
        Get
            Return _MaHoaDonBanSach
        End Get
        Set(value As String)
            _MaHoaDonBanSach = value
        End Set
    End Property

    Public Property MaSach As String
        Get
            Return _MaSach
        End Get
        Set(value As String)
            _MaSach = value
        End Set
    End Property

    Public Property SoLuongBan As Integer
        Get
            Return _SoLuongBan
        End Get
        Set(value As Integer)
            _SoLuongBan = value
        End Set
    End Property

    Private _MaHoaDonBanSach As String
    Private _MaSach As String

    Private _SoLuongBan As Integer
    Public Sub New(MaHoaDonBanSach As String, MaSach As String, SoLuongBan As Integer)
        _MaHoaDonBanSach = MaHoaDonBanSach
        _MaSach = MaSach
        _SoLuongBan = SoLuongBan
    End Sub
End Class
