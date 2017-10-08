Public Class PhieuNhapSach_DTO
    Private _MaPhieuNhap As String

    Public Property MaPhieuNhap As String
        Get
            Return _MaPhieuNhap
        End Get
        Set(value As String)
            _MaPhieuNhap = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return _NgayNhap
        End Get
        Set(value As Date)
            _NgayNhap = value
        End Set
    End Property

    Private _NgayNhap As Date
    Public Sub New(MaPhieuNhap As String, NgayNhap As Date)
        _MaPhieuNhap = MaPhieuNhap
        _NgayNhap = NgayNhap
    End Sub

End Class
