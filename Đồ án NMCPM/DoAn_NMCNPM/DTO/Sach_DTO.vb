Namespace DoAn_NMCNPM
    Public Class Sach_DTO
        Private _MaSach As String
        Public Property TenSach As String
            Get
                Return _TenSach
            End Get
            Set(value As String)
                _TenSach = value
            End Set
        End Property
        Private _TenSach As String
        Public Property TheLoai As String
            Get
                Return _TheLoai
            End Get
            Set(value As String)
                _TheLoai = value
            End Set
        End Property
        Private _TheLoai As String
        Public Property TacGia As String
            Get
                Return _TacGia
            End Get
            Set(value As String)
                _TacGia = value
            End Set
        End Property
        Private _TacGia As String
        Public Property SoLuongTon As Integer
            Get
                Return _SoLuongTon
            End Get
            Set(value As Integer)
                _SoLuongTon = value
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

        Public Property DonGia As Integer
            Get
                Return _DonGia
            End Get
            Set(value As Integer)
                _DonGia = value
            End Set
        End Property
        Private _SoLuongTon As Integer
        Private _DonGia As Integer
        Public Sub New(ByVal MaSach As String, ByVal TenSach As String, ByVal TheLoai As String, ByVal TacGia As String,
                        ByVal SoLuongTon As Integer, ByVal DonGia As Integer)
            _MaSach = MaSach
            _TenSach = TenSach
            _TheLoai = TheLoai
            _TacGia = TacGia
            _SoLuongTon = SoLuongTon
            _DonGia = DonGia
        End Sub
    End Class
End Namespace
