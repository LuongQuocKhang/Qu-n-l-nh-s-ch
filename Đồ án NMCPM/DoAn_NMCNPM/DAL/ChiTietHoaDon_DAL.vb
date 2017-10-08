Imports System.Data.SqlClient
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class ChiTietHoaDon_DAL
    Private Shared _instance As ChiTietHoaDon_DAL

    Public Shared Property Instance As ChiTietHoaDon_DAL
        Get
            If _instance Is Nothing Then
                _instance = New ChiTietHoaDon_DAL
            End If
            Return _instance
        End Get
        Set(value As ChiTietHoaDon_DAL)
            _instance = value
        End Set
    End Property
    ' thêm chi tiết hóa đon
    Public Sub insertChithiet(_ChiTiet As ChiTietHoaDon_DTO)
        Using conn As New SqlConnection(DataProvider._linkToDB)
            ' dùng procedure để thêm tự động mã chi tiết hóa đơn
            Using cmd As New SqlCommand("SPCHI_TIET_HOA_DON", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@MaHoaDonBanSach", _ChiTiet.MaHoaDonBanSach)
                cmd.Parameters.AddWithValue("@MaSach", _ChiTiet.MaSach)
                cmd.Parameters.AddWithValue("@SoLuongBan", _ChiTiet.SoLuongBan)

                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub
End Class
