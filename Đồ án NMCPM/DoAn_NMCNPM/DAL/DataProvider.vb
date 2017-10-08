Imports System.Data.SqlClient
Imports System.Windows.Forms
Namespace DoAn_NMCNPM

    Public Class DataProvider
        Private Shared _instance As DataProvider
        ' chuỗi kết nối
        Shared startpath As String = Application.StartupPath + "\QLNhaSach.mdf"
        Public Shared _linkToDB As String = "Data Source=(LocalDB)\mssqllocaldb;AttachDbFilename= " + startpath + "; Integrated Security=True"
        Public Shared Property Instance As DataProvider
            Get
                If (_instance Is Nothing) Then
                    _instance = New DataProvider
                End If
                Return _instance
            End Get
            Set(value As DataProvider)
                _instance = value
            End Set
        End Property
        ' dùng để load thông tin table
        Public Function ExecuteQuery(query As String, Optional param() As Object = Nothing) As DataTable
            Dim table As New DataTable
            Using conn As New SqlConnection(_linkToDB)
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                If (param IsNot Nothing) Then
                    Dim Temp As String() = query.Split(" ")
                    Dim List As New List(Of String)
                    For Each item As String In Temp
                        If item <> String.Empty And Char.Equals(item(0), "@"c) Then
                            List.Add(item)
                        End If
                    Next
                    For index = 0 To param.Length - 1
                        cmd.Parameters.AddWithValue(List(index), param(index))
                    Next
                End If
                adapter.Fill(table)
                conn.Close()
            End Using
            Return table
        End Function
        ' xử lý insert | delete | update infomation
        Public Function ExecuteNonQuery(query As String, Optional param() As Object = Nothing) As Integer
            Dim table As New DataTable
            Dim Col As New Integer
            Using conn As New SqlConnection(_linkToDB)
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                If (param IsNot Nothing) Then
                    Dim Temp As String() = query.Split(" ")
                    Dim List As New List(Of String)
                    For Each item As String In Temp
                        If item <> String.Empty And Char.Equals(item(0), "@"c) Then
                            List.Add(item)
                        End If
                    Next
                    For index = 0 To param.Length - 1
                        cmd.Parameters.AddWithValue(List(index), param(index))
                    Next
                End If
                Col = cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            Return Col
        End Function
        ' hàm trả về 1 đối tượng dựa vào câu truy vấn ( vd : tìm MAX )
        Public Function ExecuteScalar(query As String, Optional param() As Object = Nothing) As Integer
            Dim table As New DataTable
            Dim _Object As New Object
            Using conn As New SqlConnection(_linkToDB)
                conn.Open()
                Dim cmd As New SqlCommand(query, conn)
                Dim adapter As New SqlDataAdapter(cmd)
                If (param IsNot Nothing) Then
                    Dim Temp As String() = query.Split(" ")
                    Dim List As New List(Of String)
                    For Each item As String In Temp
                        If item <> String.Empty And Char.Equals(item(0), "@"c) Then
                            List.Add(item)
                        End If
                    Next
                    For index = 0 To param.Length - 1
                        cmd.Parameters.AddWithValue(List(index), param(index))
                    Next
                End If
                _Object = cmd.ExecuteScalar()
                conn.Close()
            End Using
            Return _Object
        End Function
    End Class
End Namespace
