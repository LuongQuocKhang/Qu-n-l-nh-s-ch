Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports DAL
Imports DTO

Public Class BaoCaoTon_BUS
    Private Shared _instance As BaoCaoTon_BUS

    Public Shared Property Instance As BaoCaoTon_BUS
        Get
            If _instance Is Nothing Then
                _instance = New BaoCaoTon_BUS
            End If
            Return _instance
        End Get
        Set(value As BaoCaoTon_BUS)
            _instance = value
        End Set
    End Property

    Public Sub loaddulieu(data As DataGridView, Thang As Integer, Nam As Integer)
        data.Rows.Clear()
        Dim BaoCao As DataTable = BaoCaoTon_DAL.Instance.loaddulieu(Thang, Nam)

        For index = 0 To BaoCao.Rows.Count - 1
            data.Rows.Add()

            data.Rows(index).Cells("MaSach").Value = BaoCao.Rows(index).Item("MaSach").ToString()
            data.Rows(index).Cells("TenSach").Value = BaoCao.Rows(index).Item("TenSach").ToString()
            data.Rows(index).Cells("TonDau").Value = BaoCao.Rows(index).Item("TonDau").ToString()
            data.Rows(index).Cells("PhatSinh").Value = BaoCao.Rows(index).Item("PhatSinhTon").ToString()
            data.Rows(index).Cells("TonCuoi").Value = BaoCao.Rows(index).Item("TonCuoi").ToString()
        Next

    End Sub
End Class
