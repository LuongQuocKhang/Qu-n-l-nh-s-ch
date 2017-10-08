Imports System.Data.SqlClient
Public Class Form1
    Private Sub cmdGetData_Click(sender As Object, e As EventArgs) Handles cmdGetData.Click
        'Conectamos a la base de datos
        Dim con As New SqlConnection("SERVER=192.168.1.15;uid=prueba;password=123456;database=ARTICULOS_DB")
        Dim sSQL As String = "SELECT *FROM TBL_ARTICULOS"
        Dim ds As New DataSet
        Dim da As SqlDataAdapter
        da = New SqlDataAdapter(sSQL, con)
        con.Open()
        da.Fill(ds) 'Poblamos el Data set
        dgvwDatos.DataSource = ds.Tables(0) 'Poblamos OrElse DataGridView
        con.Close() 'Cerramos la coenxion
    End Sub
    Public Sub GridToExcel(ByVal dgvw As DataGridView)
        Dim Appli As New Microsoft.Office.Interop.Excel.Application
        Dim Libro As Microsoft.Office.Interop.Excel.Workbook
        Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim Col As Integer = dgvw.ColumnCount
        Dim Row As Integer = dgvw.RowCount
        Libro = Appli.Workbooks.Add
        Hoja = Appli.Worksheets.Add()
        'Recorremos las columnas para agregar el nombre del encabezado.
        For i As Integer = 1 To Col
            Hoja.Cells.Item(1, i) = dgvw.Columns(i - 1).Name.ToString
        Next
        'Recorremos las filas para escribir.
        For Fila As Integer = 0 To Row - 1
            For e As Integer = 0 To Col - 1
                Hoja.Cells.Item(Fila + 2, e + 1) = dgvw.Rows(Fila).Cells(e).Value
            Next
        Next
        Hoja.Rows.Item(1).Font.Bold = 1 'Encabezado en negrita.
        Hoja.Rows.Item(1).HorizontalAlignment = 3 'Aliniamos al centro el enabezado.
        Hoja.Columns.AutoFit() 'Ajustamos  las columnas.
        Appli.Application.Visible = True 'Aplicación visible.
        Appli.Application.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized 'Excel Maximizado.
        Hoja = Nothing
        Libro = Nothing
        Appli = Nothing
    End Sub

    Private Sub cmdToExcel_Click(sender As Object, e As EventArgs) Handles cmdToExcel.Click
        GridToExcel(dgvwDatos)
    End Sub
End Class
