Imports System.Windows.Forms
Imports DAL.DoAn_NMCNPM
Imports DTO.DoAn_NMCNPM

Namespace DoAn_NMCNPM
    Public Class Sach_BUS
        Private Shared _instance
        Public Shared Property Instance As Sach_BUS
            Get
                If (_instance Is Nothing) Then
                    _instance = New Sach_BUS
                End If
                Return _instance
            End Get
            Set(value As Sach_BUS)
                _instance = value
            End Set
        End Property
        ' hàm load thông tin sách
        Public Sub Load(Data As DataGridView)
            Data.DataSource = Sach_DAL.Instance.Load()
        End Sub
        ' hàm thêm sách
        Public Sub Insert(Data As DataGridView)
            Dim Row As DataGridViewRow = Data.SelectedCells(0).OwningRow
            Dim _MaSach As String = Row.Cells("Mã sách").ToString()
            Dim _TenSach As String = Row.Cells("Tên sách").ToString()
            Dim _TheLoai As String = Row.Cells("Thể loại").ToString()
            Dim _TacGia As String = Row.Cells("Tác giả").ToString()
            Dim _SoLuongTon As Integer = Integer.Parse(Row.Cells("Số lượng tồn").ToString())
            Dim _DonGIa As Integer = Integer.Parse(Row.Cells("Đơn giá").ToString())

            Dim _PhieuNhap As New Sach_DTO(_MaSach, _TenSach, _TheLoai, _TacGia, _DonGIa, _SoLuongTon)

            If (Sach_DAL.Instance.Insert(_PhieuNhap) > 0) Then
                MessageBox.Show("Thêm thành công")
            Else
                MessageBox.Show("Thêm thất bại !!")
            End If
        End Sub
        ' Hàm xóa
        Public Sub Delete(Data As DataGridView)
            Dim _MaSach As String = Data.SelectedCells(0).OwningRow.Cells("Mã Sách").Value.ToString
            If (Sach_DAL.Instance.Delete(_MaSach) > 0) Then
                MessageBox.Show("Xóa thành công")
            Else
                MessageBox.Show("Xóa thất bại !!")
            End If
        End Sub

    End Class
End Namespace
