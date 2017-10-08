Imports System.Drawing
Imports System.Windows.Forms
Imports DAL
Imports DTO

Public Class TraCuu_BUS
    Private Shared _instance As TraCuu_BUS
    Public Shared Property Instance As TraCuu_BUS
        Get
            If (_instance Is Nothing) Then
                _instance = New TraCuu_BUS
            End If
            Return _instance
        End Get
        Set(value As TraCuu_BUS)
            _instance = value
        End Set
    End Property
    Public Sub Load(Data As DataGridView)
        Dim _Data As DataTable = TraCuu_DAL.Instance.Load()
        Data.DataSource = _Data
    End Sub

    Public Sub TraCuuSoLuongTon(dtgv As DataGridView, Tu As String, Den As String)

        dtgv.DataSource = TraCuu_DAL.Instance.TraCuuSoLuongTon(Tu, Den)

    End Sub
End Class
