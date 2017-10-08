Public Class ChiTietPhieuNhap_DTO
    Private _MaChiTietPhieuNhap As String

    Public Property MaChiTietPhieuNhap As String
        Get
            Return _MaChiTietPhieuNhap
        End Get
        Set(value As String)
            _MaChiTietPhieuNhap = value
        End Set
    End Property

    Public Property MaPhieuNhap As String
        Get
            Return _MaPhieuNhap
        End Get
        Set(value As String)
            _MaPhieuNhap = value
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

    Public Property SoLuongNhap As Integer
        Get
            Return _SoLuongNhap
        End Get
        Set(value As Integer)
            _SoLuongNhap = value
        End Set
    End Property
    Private _MaPhieuNhap As String
    Private _MaSach As String
    Private _SoLuongNhap As Integer
    Public Sub New(MaPhieuNhap As String, MaSach As String, SoLuongNhap As Integer)
        _MaPhieuNhap = MaPhieuNhap
        _MaSach = MaSach
        _SoLuongNhap = SoLuongNhap
    End Sub
End Class
