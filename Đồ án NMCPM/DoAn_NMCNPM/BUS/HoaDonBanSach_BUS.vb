Imports System.Drawing
Imports System.Windows.Forms
Imports BUS
Imports BUS.DoAn_NMCNPM
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO
Imports DTO.DoAn_NMCNPM
Public Class HoaDonBanSach_BUS
    Private Shared _instance As HoaDonBanSach_BUS
    Public Shared Property Instance As HoaDonBanSach_BUS
        Get
            If (_instance Is Nothing) Then
                _instance = New HoaDonBanSach_BUS
            End If
            Return _instance
        End Get
        Set(value As HoaDonBanSach_BUS)
            _instance = value
        End Set
    End Property

    ' cập nhậ thông tin mỗi khi click vào 1 ô
    Public Sub CellClick(Data As DataGridView)
        For index = 0 To Data.Rows.Count - 2
            Dim Row As DataRow = HoaDonBanSach_DAL.Instance.loadDataRow(Data.Rows(index).Cells("MaSach").Value.ToString)
            'kiểm tra sách đã tồn tai chưa
            If Sach_DAL.Instance.Kiemtratontai(Data.Rows(index).Cells("MaSach").Value.ToString) = True Then
                Data.Rows(index).Cells("TenSach").Value = Row.Item("TenSach")
                Data.Rows(index).Cells("TheLoai").Value = Row.Item("TheLoai")
                Data.Rows(index).Cells("TacGia").Value = Row.Item("TacGia")
                Data.Rows(index).Cells("SoLuongTon").Value = Row.Item("SoLuongTon")
                Data.Rows(index).Cells("DonGia").Value = Row.Item("DonGia")
                Data.Rows(index).Cells("GhiChu").Value = "Đã tồn tại"
                Data.Rows(index).Cells("GhiChu").Style.BackColor = Color.Green
                If Data.Rows(index).Cells("SoLuongBan").Value Is Nothing Then
                    Data.Rows(index).Cells("SoLuongBan").Value = 0
                End If
                If Data.Rows(index).Cells("SoLuongBan").Value <= Data.Rows(index).Cells("SoLuongTon").Value Then
                    Data.Rows(index).Cells("SoLuongBan").Style.BackColor = Color.Green
                End If
                Dim _SoLuongTonSauBan = Data.Rows(index).Cells("SoLuongTon").Value - Data.Rows(index).Cells("SoLuongBan").Value
                If QuiDinh_DAL.Instance.KiemtraSoLuongBan(_SoLuongTonSauBan) = False Then
                    Data.Rows(index).Cells("SoLuongBan").Style.BackColor = Color.Red
                End If
                Data.Rows(index).Cells("TongTien").Value = Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value) * Convert.ToInt32(Data.Rows(index).Cells("SoLuongBan").Value)
            Else
                Data.Rows(index).Cells("TenSach").Value = Nothing
                Data.Rows(index).Cells("TheLoai").Value = Nothing
                Data.Rows(index).Cells("TacGia").Value = Nothing
                Data.Rows(index).Cells("SoLuongTon").Value = Nothing
                Data.Rows(index).Cells("DonGia").Value = Nothing
                Data.Rows(index).Cells("GhiChu").Value = "Chưa tồn tại"
                Data.Rows(index).Cells("GhiChu").Style.BackColor = Color.Red
            End If
            If Data.Rows(index).Cells("SoLuongBan").Value > Data.Rows(index).Cells("SoLuongTon").Value Then
                Data.Rows(index).Cells("SoLuongBan").Style.BackColor = Color.Red
            End If
        Next
    End Sub

    Public Sub insertHoaDon(_MaHoaDon As String, _MaKhachHang As String, _NgayLapHD As Date, Data As DataGridView)
        Dim _temp As Integer = 0 ' đếm số lượng sách đã thêm thành công
        Dim _QuyDinh As Integer = 0 ' đếm số lượng sai quy định
        Dim Tongtien As Integer = 0
        For index = 0 To Data.Rows.Count - 1
            If Data.Rows(index).Cells("MaSach").Value IsNot Nothing Then
                Dim _DonGIa As Integer = Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value)
                Dim _SoLuongBan As Integer = Integer.Parse(Data.Rows(index).Cells("SoLuongBan").Value.ToString)
                Tongtien += _DonGIa * _SoLuongBan
            End If
        Next
        ' kiểm tra khách hàng có tồn tại hay ko
        ' nếu ko tồn tại thì thêm mới
        If KhachHang_DAL.Instance.kiemtratontai(_MaKhachHang) = False Then
            Dim _KhachHang As New KhachHang_DTO(_MaKhachHang, "", Tongtien, "", "", "")
            KhachHang_DAL.Instance.insertKH(_KhachHang)
        Else
            KhachHang_DAL.Instance.UpdateTienNo(_MaKhachHang, Tongtien)
        End If
        Dim _HoaDon As New HoaDonBanSach_DTO(_MaHoaDon, _MaKhachHang, _NgayLapHD)
        HoaDonBanSach_DAL.Instance.insertHoaDon(_HoaDon)
        For index = 0 To Data.Rows.Count - 1
            If Data.Rows(index).Cells("MaSach").Value IsNot Nothing Then
                ' kiểm tra số tiền nợ của khách hàng
                Dim _SoTienNoHienTai As Integer = KhachHang_DAL.Instance.SoTienNoHienTai(_MaKhachHang)
                If QuiDinh_DAL.Instance.KiemtraSoTienNo(_SoTienNoHienTai) = False Then
                    _QuyDinh = _QuyDinh + 1
                End If

                ' lây thông tin sách
                Dim _MaSach As String = Data.Rows(index).Cells("MaSach").Value.ToString()
                Dim _TenSach As String = Data.Rows(index).Cells("TenSach").Value.ToString()
                Dim _TheLoai As String = Data.Rows(index).Cells("TheLoai").Value.ToString()
                Dim _TacGia As String = Data.Rows(index).Cells("TacGia").Value.ToString()
                Dim _SoLuongTon As Integer = Convert.ToInt32(Data.Rows(index).Cells("SoLuongTon").Value)
                Dim _DonGIa As Integer = Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value)
                Dim _SoLuongBan As Integer = Integer.Parse(Data.Rows(index).Cells("SoLuongBan").Value.ToString)
                ' kiểm tra điều kiện
                Dim _SoLuongTonSauBan = _SoLuongTon - _SoLuongBan
                If QuiDinh_DAL.Instance.KiemtraSoLuongBan(_SoLuongTonSauBan) = False Then
                    _QuyDinh = _QuyDinh + 1
                Else
                    If Sach_DAL.Instance.Kiemtratontai(_MaSach) = True And _QuyDinh = 0 Then
                        If Sach_DAL.Instance.UpdateSachBan(_SoLuongBan, _MaSach) = True Then
                            _temp = _temp + 1
                        End If
                    End If
                End If

                ' thêm chi tiết hóa đơn
                If _temp > 0 And _QuyDinh = 0 Then
                    ' thêm chi tiết hóa đơn
                    Dim _ChiTietHD As New ChiTietHoaDon_DTO(_MaHoaDon, _MaSach, _SoLuongBan)
                    ChiTietHoaDon_DAL.Instance.insertChithiet(_ChiTietHD)
                    Dim BaoCaoTon As New BaoCaoTon_DTO(_NgayLapHD, _MaSach, _SoLuongTon, _SoLuongBan, _SoLuongTon - _SoLuongBan)
                    BaoCaoTon_DAL.Instance.insertBaoCao(BaoCaoTon)
                End If
            End If
        Next

        If _temp > 0 And _QuyDinh = 0 Then
            MessageBox.Show("Lập hóa đơn thành công")
        Else
            MessageBox.Show("Lập hóa đơn không thành công")
        End If
    End Sub
End Class
