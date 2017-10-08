Imports System.Windows.Forms
Imports DAL

Public Class KhachHang_BUS
    Private Shared _instance As KhachHang_BUS
    Public Shared Property Instance As KhachHang_BUS
        Get
            If _instance Is Nothing Then
                _instance = New KhachHang_BUS
            End If
            Return _instance
        End Get
        Set(value As KhachHang_BUS)
            _instance = value
        End Set
    End Property

    Public Sub loadCBMaKhacHang(_MaKH As ComboBox)
        _MaKH.DataSource = KhachHang_DAL.Instance.LoadMaKhachHang()
    End Sub


    Public Function Kiemtratontai(_MaKhachHang As String) As Boolean
        If KhachHang_DAL.Instance.kiemtratontai(_MaKhachHang) = True Then
            Return True
        End If
        Return False
    End Function
End Class
