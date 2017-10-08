Public Class QuiDinh_DTO
    Private _SoLuongNhapToiThieu As Integer

    Public Property SoLuongNhapToiThieu As Integer
        Get
            Return _SoLuongNhapToiThieu
        End Get
        Set(value As Integer)
            _SoLuongNhapToiThieu = value
        End Set
    End Property

    Public Property SoLuongTonDuocPhepNhap As Integer
        Get
            Return _SoLuongTonDuocPhepNhap
        End Get
        Set(value As Integer)
            _SoLuongTonDuocPhepNhap = value
        End Set
    End Property

    Public Property SoTienNoToiDa As Integer
        Get
            Return _SoTienNoToiDa
        End Get
        Set(value As Integer)
            _SoTienNoToiDa = value
        End Set
    End Property

    Public Property SoLuongTonToiThieuSauBan As Integer
        Get
            Return _SoLuongTonToiThieuSauBan
        End Get
        Set(value As Integer)
            _SoLuongTonToiThieuSauBan = value
        End Set
    End Property

    Public Property ApDungQuiDinh4 As Boolean
        Get
            Return _ApDungQuiDinh4
        End Get
        Set(value As Boolean)
            _ApDungQuiDinh4 = value
        End Set
    End Property

    Private _SoLuongTonDuocPhepNhap As Integer
    Private _SoTienNoToiDa As Integer
    Private _SoLuongTonToiThieuSauBan As Integer
    Private _ApDungQuiDinh4 As Boolean

    Public Sub New(ByVal SoLuongNhapToiThieu As Integer, ByVal SoLuongTonDuocPhepNhap As Integer,
                   ByVal SoTienNoToiDa As Integer, ByVal SoLuongTonToiThieuSauBan As Integer, ByVal ApDungQuiDinh4 As Boolean)
        _SoLuongNhapToiThieu = SoLuongNhapToiThieu
        _SoLuongTonDuocPhepNhap = SoLuongTonDuocPhepNhap
        _SoTienNoToiDa = SoTienNoToiDa
        _SoLuongTonToiThieuSauBan = SoLuongTonToiThieuSauBan
        _ApDungQuiDinh4 = ApDungQuiDinh4
    End Sub
End Class
