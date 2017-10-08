Public Class PhieuThuTien_DTO
    Private _MaPhieuThuTien As String

    Public Property MaPhieuThuTien As String
        Get
            Return _MaPhieuThuTien
        End Get
        Set(value As String)
            _MaPhieuThuTien = value
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

    Public Property NgayThuTien As Date
        Get
            Return _NgayThuTien
        End Get
        Set(value As Date)
            _NgayThuTien = value
        End Set
    End Property

    Public Property SoTienThu As Integer
        Get
            Return _SoTienThu
        End Get
        Set(value As Integer)
            _SoTienThu = value
        End Set
    End Property
    Private _MaKhachHang As String

    Private _NgayThuTien As Date

    Private _SoTienThu As Integer
    Public Sub New(MaKhachHang As String, NgayThuTien As Date, SoTienThu As Integer)
        _MaKhachHang = MaKhachHang
        _NgayThuTien = NgayThuTien
        _SoTienThu = SoTienThu
    End Sub

End Class
