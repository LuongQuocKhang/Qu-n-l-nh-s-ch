Public Class HoaDonBanSach_DTO
    Private _MaHoaDonBanSach As String

    Public Property MaHoaDonBanSach As String
        Get
            Return _MaHoaDonBanSach
        End Get
        Set(value As String)
            _MaHoaDonBanSach = value
        End Set
    End Property

    Public Property MaKhachHang As String
        Get
            Return _MaKhachHang
        End Get
        Set(value As String)
            _MaKhachHang = value
        End Set
    End Property

    Public Property NgayLapHoaDon As Date
        Get
            Return _NgayLapHoaDon
        End Get
        Set(value As Date)
            _NgayLapHoaDon = value
        End Set
    End Property

    Private _MaKhachHang As String

    Private _NgayLapHoaDon As Date

    Public Sub New(MaHoaDonBanSach As String, MaKhachHang As String, NgayLapHoaDon As Date)
        _MaHoaDonBanSach = MaHoaDonBanSach
        _MaKhachHang = MaKhachHang
        _NgayLapHoaDon = NgayLapHoaDon
    End Sub
End Class
