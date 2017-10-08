Imports System.Windows.Forms
Imports DAL
Imports DTO

Public Class PhieuThuTien_BUS
    Private Shared _instance As PhieuThuTien_BUS

    Public Shared Property Instance As PhieuThuTien_BUS
        Get
            If _instance Is Nothing Then
                _instance = New PhieuThuTien_BUS
            End If
            Return _instance
        End Get
        Set(value As PhieuThuTien_BUS)
            _instance = value
        End Set
    End Property

    Public Function loadSotienNo(_MaKhachHang As String) As String
        Return PhieuThuTien_DAL.Instance.SotTenNo(_MaKhachHang).ToString()
    End Function

    Public Sub SoTienNoMoi(_MaKhachHang As String)
        Dim _SoTienThu As Integer = loadSotienNo(_MaKhachHang)
    End Sub

    ' load thông tin khách hàng
    Public Sub loadKH(_MaKhachHang As String, HoTen As TextBox, DienThoai As TextBox, Email As TextBox, DiaChi As TextBox)
        Dim Data As DataTable = KhachHang_DAL.Instance.LoadKhachhang(_MaKhachHang)
        HoTen.Text = Data.Rows(0).Item("HoVaTenKhachHang").ToString
        DienThoai.Text = Data.Rows(0).Item("DienThoai").ToString
        Email.Text = Data.Rows(0).Item("Email").ToString
        DiaChi.Text = Data.Rows(0).Item("DiaChi").ToString
    End Sub

    ' thâm phiếu thu tiền
    Public Sub insertPhieuThu(_MaKhachHang As String, _NgayThuTien As Date, _TienNoTruocThu As Integer, _SoTienThu As Integer, _SoTienNoMoi As Integer,
                               HoVaTenKhachHang As String, DiaChi As String, Email As String, DienThoai As String)
        Dim _PhieuThu As New PhieuThuTien_DTO(_MaKhachHang, _NgayThuTien, _SoTienThu)
        If PhieuThuTien_DAL.Instance.InsertPhieuThu(_PhieuThu) > 0 Then
            MessageBox.Show("Lập phiếu thành công")
        Else
            MessageBox.Show("Lập phiếu thất bại")
        End If
        ' cập nhật số tiền nợ mới của khách hàng
        Dim BaoCao As New BaoCaoCongNo_DTO(_NgayThuTien, _MaKhachHang, _TienNoTruocThu, _SoTienThu, _SoTienNoMoi)
        BaoCaoCongNo_DAL.Instance.insertBaoCao(BaoCao)
        'KhachHang_DAL.Instance.UpdateTienNo_PhieuThu(_MaKhachHang, _SoTienNoMoi)
        Dim KhachHang As New KhachHang_DTO(_MaKhachHang, HoVaTenKhachHang, _SoTienNoMoi, DiaChi, Email, DienThoai)
        KhachHang_DAL.Instance.updateKH(KhachHang)
    End Sub

End Class
