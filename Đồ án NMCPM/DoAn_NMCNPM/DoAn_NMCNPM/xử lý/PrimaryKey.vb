Imports DAL.DoAn_NMCNPM

Public Class PrimaryKey
    Private Shared Property _instance As PrimaryKey

    Public Shared Property Instance As PrimaryKey
        Get
            If _instance Is Nothing Then
                _instance = New PrimaryKey
            End If
            Return _instance
        End Get
        Set(value As PrimaryKey)
            _instance = value
        End Set
    End Property

    Public Function CreatePrimaryKey(ByVal tenbang As String, ByVal prefix As String, ByVal buocnhay As Integer) As String
        'Load du lieu khoa tu bang
        Dim query As String = ""
        If tenbang = "PHIEU_NHAP" Then
            query = "select MaPhieuNhap from PHIEU_NHAP"
        ElseIf tenbang = "HOA_DON_BAN_SACH" Then
            query = "select MaHoaDonBanSach from HOA_DON_BAN_SACH"
        End If

        Dim data As DataTable = DataProvider.Instance.ExecuteQuery(query)

        Dim khoa As String = String.Empty
        Dim lengthMax As Integer = 6
        'Tao khoa
        '  Neu chua co du lieu
        If data.Rows.Count = 0 Then
            If prefix.Length = 1 Then
                khoa = prefix + "00000"
            End If
            If prefix.Length = 2 Then
                khoa = prefix + "0000"
            End If
            If prefix.Length = 3 Then
                khoa = prefix + "000"
            End If
            If prefix.Length = 4 Then
                khoa = prefix + "00"
            End If
        End If
        '  Neu da co du lieu
        Dim sokhoa(data.Rows.Count) As Integer

        For i = 0 To data.Rows.Count - 1
            Dim str As String
            str = data.Rows(i)(0)
            str = str.Remove(0, prefix.Length) 'Loai bo prefix
            sokhoa(i) = Integer.Parse(str)
        Next
        ' Tim so lon nhat trong khoa
        Dim max As Integer = sokhoa(0)
        For Each i As Integer In sokhoa
            If max < i Then
                max = i
            End If
        Next
        Dim chisokhoaLenght As Integer
        chisokhoaLenght = (max + 1 + buocnhay).ToString().Length
        Dim strChuoiSo0 As String = ""
        For i = 0 To (lengthMax - chisokhoaLenght - prefix.Length - 1)
            strChuoiSo0 += "0"
        Next
        khoa = (prefix + strChuoiSo0 + (max + 1).ToString())
        Return khoa
    End Function
End Class
