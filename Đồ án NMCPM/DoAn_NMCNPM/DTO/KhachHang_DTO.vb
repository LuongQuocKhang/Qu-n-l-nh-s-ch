Public Class KhachHang_DTO
    Private _MaKhachHang As String

    Public Property MaKhachHang As String
        Get
            Return _MaKhachHang
        End Get
        Set(value As String)
            _MaKhachHang = value
        End Set
    End Property

    Public Property DienThoai As String
        Get
            Return _DienThoai
        End Get
        Set(value As String)
            _DienThoai = value
        End Set
    End Property

    Public Property DiaChi As String
        Get
            Return _DiaChi
        End Get
        Set(value As String)
            _DiaChi = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property SoTienNoHienTai As Integer
        Get
            Return _SoTienNoHienTai
        End Get
        Set(value As Integer)
            _SoTienNoHienTai = value
        End Set
    End Property

    Public Property HoVaTenKhachHang As String
        Get
            Return _HoVaTenKhachHang
        End Get
        Set(value As String)
            _HoVaTenKhachHang = value
        End Set
    End Property

    Private _DienThoai As String

    Private _DiaChi As String
    Private _Email As String

    Private _SoTienNoHienTai As Integer
    Private _HoVaTenKhachHang As String

    Public Sub New(MaKhachHang As String, HoVaTenKhachHang As String, SoTienNoHienTai As Integer, DiaChi As String, Email As String, DienThoai As String)
        _MaKhachHang = MaKhachHang
        _HoVaTenKhachHang = HoVaTenKhachHang
        _SoTienNoHienTai = SoTienNoHienTai
        _DienThoai = DienThoai
        _DiaChi = DiaChi
        _Email = Email
        _DienThoai = DienThoai
    End Sub
End Class
