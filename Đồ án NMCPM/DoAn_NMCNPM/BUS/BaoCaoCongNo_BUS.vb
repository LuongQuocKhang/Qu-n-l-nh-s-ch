Imports System.Windows.Forms
Imports DAL
Imports DTO

Public Class BaoCaoCongNo_BUS
    Private Shared _instance As BaoCaoCongNo_BUS
    ' Mô hình SingleTon (instance)
    Public Shared Property Instance As BaoCaoCongNo_BUS
        Get
            If _instance Is Nothing Then
                _instance = New BaoCaoCongNo_BUS
            End If
            Return _instance
        End Get
        Set(value As BaoCaoCongNo_BUS)
            _instance = value
        End Set
    End Property
    ' hám load dữ liệu vào gridview khi chọn tháng
    Public Sub LoadDulieu(data As DataGridView, thang As Integer, Nam As Integer)
        data.Rows.Clear()
        Dim dulieuKH As DataTable = BaoCaoCongNo_DAL.Instance.loadKhachHang(thang, Nam)

        For index = 0 To dulieuKH.Rows.Count - 1
            data.Rows.Add()
            data.Rows(index).Cells("STT").Value = index + 1
            data.Rows(index).Cells("MaKH").Value = dulieuKH.Rows(index).Item("MaKhachHang").ToString()
            data.Rows(index).Cells("HoVaTen").Value = dulieuKH.Rows(index).Item("HoVaTenKhachHang").ToString()
            data.Rows(index).Cells("NoDau").Value = dulieuKH.Rows(index).Item("NoDau").ToString()
            data.Rows(index).Cells("PhatSinhCongNo").Value = dulieuKH.Rows(index).Item("PhatSinhCongNo").ToString()
            data.Rows(index).Cells("NoCuoi").Value = dulieuKH.Rows(index).Item("NoCuoi").ToString()
        Next
    End Sub
End Class
