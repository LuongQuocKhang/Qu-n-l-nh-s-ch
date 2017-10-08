Imports System.Data.SqlClient
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class BaoCaoTon_DAL
    Private Shared _instance As BaoCaoTon_DAL

    Public Shared Property Instance As BaoCaoTon_DAL
        Get
            If _instance Is Nothing Then
                _instance = New BaoCaoTon_DAL
            End If
            Return _instance
        End Get
        Set(value As BaoCaoTon_DAL)
            _instance = value
        End Set
    End Property
    Public Sub insertBaoCao(_BaoCao As BaoCaoTon_DTO)
        Using conn As New SqlConnection(DataProvider._linkToDB)
            Using cmd As New SqlCommand("SPBAOCAOTON", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Thang", _BaoCao.Thang)
                cmd.Parameters.AddWithValue("@MaSach", _BaoCao.MaSach)
                cmd.Parameters.AddWithValue("@TonDau", _BaoCao.SoLuongTonDau)
                cmd.Parameters.AddWithValue("@PhatSinhTon", _BaoCao.SoLuongPhatSinh)
                cmd.Parameters.AddWithValue("@TonCuoi", _BaoCao.SoLuongTonCuoi)

                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function loaddulieu(Thang As Integer, Nam As Integer) As DataTable
        Dim query As String = "select * from BAOCAOTON join Sach on sach.MaSach = BAOCAOTON.MaSach where month(Thang) = @Thang and year(Thang) = @Nam"
        Dim param() As Object = {Thang, Nam}

        Return DataProvider.Instance.ExecuteQuery(query, param)

    End Function
End Class
