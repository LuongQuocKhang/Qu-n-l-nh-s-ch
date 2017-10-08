Public Class BaoCaoCongNo_DTO
    Private _MaBaoCaoCongNo As String

    Public Property MaBaoCaoCongNo As String
        Get
            Return _MaBaoCaoCongNo
        End Get
        Set(value As String)
            _MaBaoCaoCongNo = value
        End Set
    End Property

    Public Property Thang As Date
        Get
            Return _Thang
        End Get
        Set(value As Date)
            _Thang = value
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

    Public Property NoDau As Integer
        Get
            Return _NoDau
        End Get
        Set(value As Integer)
            _NoDau = value
        End Set
    End Property

    Public Property PhatSinhCongNo As Integer
        Get
            Return _PhatSinhCongNo
        End Get
        Set(value As Integer)
            _PhatSinhCongNo = value
        End Set
    End Property

    Public Property NoCuoi As Integer
        Get
            Return _NoCuoi
        End Get
        Set(value As Integer)
            _NoCuoi = value
        End Set
    End Property

    Private _Thang As Date

    Private _MaKhachHang As String

    Private _NoDau As Integer

    Private _PhatSinhCongNo As Integer

    Private _NoCuoi As Integer

    Public Sub New(Thang As Date, MaKhachHang As String, NoDau As Integer, PhatSinhCongNo As Integer, NoCuoi As Integer)
        _Thang = Thang
        _MaKhachHang = MaKhachHang
        _NoDau = NoDau
        _PhatSinhCongNo = PhatSinhCongNo
        _NoCuoi = NoCuoi
    End Sub
End Class
