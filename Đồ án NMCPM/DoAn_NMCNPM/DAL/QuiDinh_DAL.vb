Imports DAL.DoAn_NMCNPM
Imports DTO
Imports DTO.DoAn_NMCNPM

Public Class QuiDinh_DAL
    Private Shared _instance

    Public Shared Property Instance As QuiDinh_DAL
        Get
            If (_instance Is Nothing) Then
                _instance = New QuiDinh_DAL
            End If
            Return _instance
        End Get
        Set(value As QuiDinh_DAL)
            _instance = value
        End Set
    End Property

    Public Function Load() As QuiDinh_DTO
        Dim query As String = "Select * from THAM_SO"
        Dim Data As DataTable = DataProvider.Instance.ExecuteQuery(query)
        Dim _SoLuongNhapToiThieu As Integer = Data.Rows(0).Item("SoLuongNhapToiThieu")
        Dim _SoLuongTonDuocPhepNhap As Integer = Data.Rows(0).Item("SoLuongTonDuocPhepNhap")
        Dim _SoTienNoToiDa As Integer = Data.Rows(0).Item("SoTienNoToiDa")
        Dim _SoLuongTonToiThieuSauBan As Integer = Data.Rows(0).Item("SoLuongTonToiThieuSauBan")
        Dim _ApDungQuiDinh4 As Integer = Data.Rows(0).Item("ApDungQuiDinh4")
        Dim _QuiDinh As New QuiDinh_DTO(_SoLuongNhapToiThieu, _SoLuongTonDuocPhepNhap, _SoTienNoToiDa, _SoLuongTonToiThieuSauBan, _ApDungQuiDinh4)

        Return _QuiDinh
    End Function
    Public Function ThayDoiQuiDInh(_QuiDinh As QuiDinh_DTO) As Boolean
        Dim query As String = "update THAM_SO set SoLuongNhapToiThieu = @SoLuongNhapToiThieu , SoLuongTonDuocPhepNhap = @SoLuongTonDuocPhepNhap , SoTienNoToiDa = @SoTienNoToiDa , SoLuongTonToiThieuSauBan = @SoLuongTonToiThieuSauBan , ApDungQuiDinh4 = @ApDungQuiDinh4"
        Dim param() As Object = {_QuiDinh.SoLuongNhapToiThieu, _QuiDinh.SoLuongTonDuocPhepNhap, _QuiDinh.SoTienNoToiDa, _QuiDinh.SoLuongTonToiThieuSauBan, _QuiDinh.ApDungQuiDinh4}
        If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function KiemtraSoLuongNhap(_SoLuongNhap As Integer) As Boolean
        Dim query As String = "Select SoLuongNhapToiThieu from THAM_SO"
        Dim SoLuong As Integer = Integer.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())
        If _SoLuongNhap >= SoLuong Then
            Return True
        End If
        Return False
    End Function

    Public Function KiemtraSoLuongBan(_SoLuongTonMoi As Integer) As Boolean
        Dim query As String = "Select SoLuongTonToiThieuSauBan from THAM_SO"
        Dim SoLuong As Integer = Integer.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())
        If _SoLuongTonMoi > SoLuong Then
            Return True
        End If
        Return False
    End Function
    Public Function KiemtraSoLuongTon(_SoLuongTon As Integer) As Boolean
        Dim query As String = "Select SoLuongTonDuocPhepNhap from THAM_SO"
        Dim SoLuong As Integer = Integer.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())
        If _SoLuongTon <= SoLuong Then
            Return True
        End If
        Return False
    End Function

    Public Function KiemtraSoTienNo(_SoTienNo As Integer) As Boolean
        Dim query As String = "Select SoTienNoToiDa from THAM_SO"
        Dim TienNoToiDa As Integer = Integer.Parse(DataProvider.Instance.ExecuteScalar(query).ToString())
        If _SoTienNo <= TienNoToiDa Then
            Return True
        End If
        Return False
    End Function

    Public Function kiemtraQD4() As Boolean
        Dim query As String = "select ApDungQuiDinh4 from THAM_SO"
        ' biến lưu giá trị của qui định 4
        Dim Temp As Boolean = DataProvider.Instance.ExecuteScalar(query)
        ' kiểm tra có áp dụng QD 4 hay ko
        If Temp = True Then
            Return True
        End If
        Return False
    End Function
End Class
