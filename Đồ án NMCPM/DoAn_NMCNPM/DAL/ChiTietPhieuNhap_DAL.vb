Imports System.Data.SqlClient
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class ChiTietPhieuNhap_DAL
    Private Shared _instance As ChiTietPhieuNhap_DAL

    Public Shared Property Instance As ChiTietPhieuNhap_DAL
        Get
            If _instance Is Nothing Then
                _instance = New ChiTietPhieuNhap_DAL
            End If
            Return _instance
        End Get
        Set(value As ChiTietPhieuNhap_DAL)
            _instance = value
        End Set
    End Property

    Public Sub insertChithiet(_ChiTiet As ChiTietPhieuNhap_DTO)
        Using conn As New SqlConnection(DataProvider._linkToDB)
            Using cmd As New SqlCommand("SPCHITIETPHIEUNHAP", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@MaPhieuNhap", _ChiTiet.MaPhieuNhap)
                cmd.Parameters.AddWithValue("@MaSach", _ChiTiet.MaSach)
                cmd.Parameters.AddWithValue("@SoLuongNhap", _ChiTiet.SoLuongNhap)
                conn.Open()

                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub
End Class
