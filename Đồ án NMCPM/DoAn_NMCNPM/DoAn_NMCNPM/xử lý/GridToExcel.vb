Imports DoAn_NMCNPM

Public Class GridToExcel
    Private Shared _instance As GridToExcel

    Public Shared Property Instance As GridToExcel
        Get
            If _instance Is Nothing Then
                _instance = New GridToExcel
            End If
            Return _instance
        End Get
        Set(value As GridToExcel)
            _instance = value
        End Set
    End Property

    Public Sub GridToExcel(ByVal dgvw As DataGridView)
        ' khởi tạo ừng dụng excel , trang trong excel
        Dim Appli As New Microsoft.Office.Interop.Excel.Application
        Dim Libro As Microsoft.Office.Interop.Excel.Workbook
        Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim Col As Integer = dgvw.ColumnCount
        Dim Row As Integer = dgvw.RowCount
        Libro = Appli.Workbooks.Add()
        Hoja = Appli.Worksheets.Add()

        ' thêm dữ liệu qua file excel
        For i As Integer = 1 To Col
            Hoja.Cells.Item(1, i) = dgvw.Columns(i - 1).Name.ToString
        Next

        For Fila As Integer = 0 To Row - 1
            For e As Integer = 0 To Col - 1
                Hoja.Cells.Item(Fila + 2, e + 1) = dgvw.Rows(Fila).Cells(e).Value
            Next
        Next
        Hoja.Rows.Item(1).Font.Bold = 1
        Hoja.Rows.Item(1).HorizontalAlignment = 3
        Hoja.Columns.AutoFit()

        Appli.Application.Visible = True  ' hiện ứng dụng excel sau khi thêm dữ liệu
        Appli.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized ' full màn hình

        ' giải phóng tài nguyên
        Hoja = Nothing
        Libro = Nothing
        Appli = Nothing
    End Sub
End Class
