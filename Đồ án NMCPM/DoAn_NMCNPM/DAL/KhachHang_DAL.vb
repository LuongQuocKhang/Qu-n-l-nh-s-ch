Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO

Public Class KhachHang_DAL
    Private Shared _instance As KhachHang_DAL

    Public Shared Property Instance As KhachHang_DAL
        Get
            If _instance Is Nothing Then
                _instance = New KhachHang_DAL
            End If
            Return _instance
        End Get
        Set(value As KhachHang_DAL)
            _instance = value
        End Set
    End Property
    Public Sub insertKH(_KhachHang As KhachHang_DTO)
        Dim query As String = "insert into KHACH_HANG values ( @MaKhachHang , @HoTen , @SotienNo , @DiaChi , @Email , @DienThoai )"
        Dim param() As Object = {_KhachHang.MaKhachHang, _KhachHang.HoVaTenKhachHang, _KhachHang.SoTienNoHienTai, _KhachHang.DiaChi, _KhachHang.Email, _KhachHang.DienThoai}
        DataProvider.Instance.ExecuteNonQuery(query, param)
    End Sub
    ' fdbdf
    Public Sub updateKH(_KhachHang As KhachHang_DTO)
        Dim query As String = "update KHACH_HANG set HoVaTenKhachHang = @HoTen , SoTienNoHienTai = @SotienNo , DiaChi = @DiaChi , Email = @Email ,DienThoai = @DienThoai where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_KhachHang.HoVaTenKhachHang, _KhachHang.SoTienNoHienTai, _KhachHang.DiaChi, _KhachHang.Email, _KhachHang.DienThoai, _KhachHang.MaKhachHang}
        DataProvider.Instance.ExecuteNonQuery(query, param)
    End Sub
    Public Function LoadKhachhang(_MaKhachHang As String) As DataTable
        Dim query As String = "select * from KHACH_HANG where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_MaKhachHang}
        Return DataProvider.Instance.ExecuteQuery(query, param)
    End Function

    Public Function LoadMaKhachHang() As List(Of String)
        Dim list As New List(Of String)
        Dim query As String = "select MaKhachHang from KHACH_HANG"
        Dim Data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        For index = 0 To Data.Rows.Count - 1
            list.Add(Data.Rows(index).Item("MaKhachHang").ToString)
        Next
        Return list
    End Function

    Public Function kiemtratontai(_MaKhachHang As String) As Boolean
        Dim query As String = "select * from KHACH_HANG where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_MaKhachHang}
        If DataProvider.Instance.ExecuteQuery(query, param).Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function SoTienNoHienTai(_MaKhachHang) As Integer
        Dim query As String = "select SoTienNoHienTai from KHACH_HANG where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_MaKhachHang}
        Return Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, param))
    End Function

    Public Function UpdateTienNo(_MaKhachHang As String, _SoTienNoMoi As Integer) As Boolean
        Dim query As String = "update KHACH_HANG set SoTienNoHienTai = SoTienNoHienTai + @SoTienNoHienTai where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_SoTienNoMoi, _MaKhachHang}
        If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function UpdateTienNo_PhieuThu(_MaKhachHang As String, _SoTienNoMoi As Integer) As Boolean
        Dim query As String = "update KHACH_HANG set SoTienNoHienTai = @SoTienNoHienTai where MaKhachHang = @MaKhachHang"
        Dim param() As Object = {_SoTienNoMoi, _MaKhachHang}
        If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
            Return True
        End If
        Return False
    End Function


End Class
