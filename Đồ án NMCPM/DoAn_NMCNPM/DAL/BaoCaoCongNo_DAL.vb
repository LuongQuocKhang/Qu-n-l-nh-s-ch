Imports System.Data.SqlClient
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class BaoCaoCongNo_DAL
    Private Shared _instance As BaoCaoCongNo_DAL

    Public Shared Property Instance As BaoCaoCongNo_DAL
        Get
            If _instance Is Nothing Then
                _instance = New BaoCaoCongNo_DAL
            End If
            Return _instance
        End Get
        Set(value As BaoCaoCongNo_DAL)
            _instance = value
        End Set
    End Property

    Public Function loadKhachHang(Thang As Integer, Nam As Integer) As DataTable
        Dim query As String = "select KHACH_HANG.MaKhachHang , KHACH_HANG.HoVaTenKhachHang , NoDau , PhatSinhCongNo , NoCuoi from KHACH_HANG join BAOCAOCONGNO on KHACH_HANG.MaKhachHang = BAOCAOCONGNO.MaKhachHang where month(Thang) = @Thang and year(Thang) = @year"
        Dim param() As Object = {Thang, Nam}
        Return DataProvider.Instance.ExecuteQuery(query, param)
    End Function

    Public Sub insertBaoCao(_BaoCao As BaoCaoCongNo_DTO)
        Using conn As New SqlConnection(DataProvider._linkToDB)
            Using cmd As New SqlCommand("SPBAOCAOCONGNO", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Thang", _BaoCao.Thang)
                cmd.Parameters.AddWithValue("@MaKhachHang", _BaoCao.MaKhachHang)
                cmd.Parameters.AddWithValue("@NoDau", _BaoCao.NoDau)
                cmd.Parameters.AddWithValue("@PhatSinhCongNo", _BaoCao.PhatSinhCongNo)
                cmd.Parameters.AddWithValue("@NoCuoi", _BaoCao.NoCuoi)

                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
