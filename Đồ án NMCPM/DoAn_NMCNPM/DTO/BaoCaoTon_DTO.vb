Public Class BaoCaoTon_DTO
    Private _MaBaoCaoTon As String

    Public Property MaBaoCaoTon As String
        Get
            Return _MaBaoCaoTon
        End Get
        Set(value As String)
            _MaBaoCaoTon = value
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

    Public Property MaSach As String
        Get
            Return _MaSach
        End Get
        Set(value As String)
            _MaSach = value
        End Set
    End Property

    Public Property SoLuongTonDau As Integer
        Get
            Return _SoLuongTonDau
        End Get
        Set(value As Integer)
            _SoLuongTonDau = value
        End Set
    End Property

    Public Property SoLuongPhatSinh As Integer
        Get
            Return _SoLuongPhatSinh
        End Get
        Set(value As Integer)
            _SoLuongPhatSinh = value
        End Set
    End Property

    Public Property SoLuongTonCuoi As Integer
        Get
            Return _SoLuongTonCuoi
        End Get
        Set(value As Integer)
            _SoLuongTonCuoi = value
        End Set
    End Property

    Private _Thang As Date
    Private _MaSach As String
    Private _SoLuongTonDau As Integer
    Private _SoLuongPhatSinh As Integer
    Private _SoLuongTonCuoi As Integer

    Public Sub New(Thang As Date, MaSach As String, SoLuongTonDau As Integer, SoLuongPhatSinh As Integer, SoLuongTonCuoi As Integer)
        _Thang = Thang
        _MaSach = MaSach
        _SoLuongTonDau = SoLuongTonDau
        _SoLuongPhatSinh = SoLuongPhatSinh
        _SoLuongTonCuoi = SoLuongTonCuoi
    End Sub
End Class
