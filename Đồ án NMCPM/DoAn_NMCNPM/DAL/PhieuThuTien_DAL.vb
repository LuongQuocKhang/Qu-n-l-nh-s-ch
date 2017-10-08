Imports System.Data.SqlClient
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class PhieuThuTien_DAL
    Private Shared _instance As PhieuThuTien_DAL

    Public Shared Property Instance As PhieuThuTien_DAL
        Get
            If _instance Is Nothing Then
                _instance = New PhieuThuTien_DAL
            End If
            Return _instance
        End Get
        Set(value As PhieuThuTien_DAL)
            _instance = value
        End Set
    End Property

    Public Function SotTenNo(_MaKhachHang As String) As Integer
        Dim query As String = "select SoTienNoHienTai from KHACH_HANG where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_MaKhachHang}

        Return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, param))
    End Function

    Public Function InsertPhieuThu(_PhieuThu As PhieuThuTien_DTO) As Integer
        Dim _num As Integer = 0
        Using conn As New SqlConnection(DataProvider._linkToDB)
            Using cmd As New SqlCommand("SPPHIEU_THU_TIEN", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@MaKhachHang", _PhieuThu.MaKhachHang)
                cmd.Parameters.AddWithValue("@NgayThuTien", _PhieuThu.NgayThuTien)
                cmd.Parameters.AddWithValue("@SoTienThu", _PhieuThu.SoTienThu)
                conn.Open()

                _num = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return _num
    End Function
End Class
