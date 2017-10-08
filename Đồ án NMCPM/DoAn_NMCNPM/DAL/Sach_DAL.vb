Imports DTO.DoAn_NMCNPM

Namespace DoAn_NMCNPM
    Public Class Sach_DAL
        Private Shared _instance

        Public Shared Property Instance As Sach_DAL
            Get
                If (_instance Is Nothing) Then
                    _instance = New Sach_DAL
                End If
                Return _instance
            End Get
            Set(value As Sach_DAL)
                _instance = value
            End Set
        End Property

        ' hàm dùng để load dữ liệu
        Public Function Load() As List(Of Sach_DTO)
            Dim List As New List(Of Sach_DTO)
            Dim query As String = "select * from sach"
            Dim Data As DataTable = DataProvider.Instance.ExecuteQuery(query)
            For Each item As DataRow In Data.Rows
                Dim _MaSach As String = item("Mã sách").ToString()
                Dim _TenSach As String = item("Tên sách").ToString()
                Dim _TheLoai As String = item("Thể loại").ToString()
                Dim _TacGia As String = item("Tác giả").ToString()
                Dim _SoLuongTon As Integer = Integer.Parse(item("Số lượng tồn").ToString())
                Dim _DonGIa As Integer = Integer.Parse(item("Đơn giá").ToString())

                Dim _PhieuNhap As New Sach_DTO(_MaSach, _TenSach, _TheLoai, _TacGia, _DonGIa, _SoLuongTon)
                List.Add(_PhieuNhap)
            Next

            Return List
        End Function
        'Hàm Thêm Sách
        Public Function Insert(Data As Sach_DTO) As Boolean
            Dim query As String = "insert into SACH values( @masach , @tensach , @theloai , @tacgia , @soluongton , @dongia )"
            Dim param() As Object = {Data.MaSach, Data.TenSach, Data.TheLoai, Data.TacGia, Data.SoLuongTon, Data.DonGia}

            If (DataProvider.Instance.ExecuteNonQuery(query, param) > 0) Then
                Return True
            End If
            Return False
        End Function
        ' hàm xóa sách
        Public Function Delete(_MaSach As String) As Boolean
            Dim query As String = "delete from SACH where MASACH = @MASACH"
            Dim param() As Object = {_MaSach}
            If (DataProvider.Instance.ExecuteNonQuery(query, param) > 0) Then
                Return True
            End If
            Return False
        End Function

        Public Function Kiemtratontai(_MaSach As String) As Boolean
            Dim query As String = "select * from sach where MaSach = @MaSach"
            Dim param() As Object = {_MaSach}
            If DataProvider.Instance.ExecuteQuery(query, param).Rows.Count > 0 Then
                Return True
            End If
            Return False
        End Function

        Public Function Loadtable() As DataTable
            Dim query As String = "select * from sach"
            Return DataProvider.Instance.ExecuteQuery(query)
        End Function

        Public Function UpdateSach(_SoLuong As Integer, _MaSach As String) As Boolean
            Dim query As String = "update SACH set SoLuongTon = SoLuongTon + @Soluong where MaSach = @MaSach"
            Dim param() As Object = {_SoLuong, _MaSach}
            If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
                Return True
            End If
            Return False
        End Function

        Public Function UpdateSachBan(_SoLuong As Integer, _MaSach As String) As Boolean
            Dim query As String = "update SACH set SoLuongTon = SoLuongTon - @Soluong where MaSach = @MaSach"
            Dim param() As Object = {_SoLuong, _MaSach}
            If DataProvider.Instance.ExecuteNonQuery(query, param) > 0 Then
                Return True
            End If
            Return False
        End Function
    End Class
End Namespace
