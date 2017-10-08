Imports System.Drawing
Imports System.Windows.Forms
Imports BUS
Imports BUS.DoAn_NMCNPM
Imports DAL
Imports DAL.DoAn_NMCNPM
Imports DTO
Imports DTO.DoAn_NMCNPM

Public Class PhieuNhapSach_BUS
    Private Shared _instance As PhieuNhapSach_BUS

    Public Shared Property Instance As PhieuNhapSach_BUS
        Get
            If (_instance Is Nothing) Then
                _instance = New PhieuNhapSach_BUS
            End If
            Return _instance
        End Get
        Set(value As PhieuNhapSach_BUS)
            _instance = value
        End Set
    End Property

    Public Sub InsertPhieuNhap(_MaPhieuNhap As String, _NgayNhap As Date, Data As DataGridView)
        Dim _temp As Integer = 0
        Dim _QuiDinh As Integer = 0
        ' thêm phiếu nhập
        Dim _PhhieuNhap As New PhieuNhapSach_DTO(_MaPhieuNhap, _NgayNhap)
        PhieuNhapSach_DAL.Instance.InsertPhieuNhap(_PhhieuNhap)
        For index = 0 To Data.Rows.Count - 2
            If Data.Rows(index).Cells("MaSach").Value IsNot Nothing Then
                ' lấy thông tin sách
                Dim _MaSach As String = Data.Rows(index).Cells("MaSach").Value.ToString()
                Dim _TenSach As String = Data.Rows(index).Cells("TenSach").Value.ToString()
                Dim _TheLoai As String = Data.Rows(index).Cells("TheLoai").Value.ToString()
                Dim _TacGia As String = Data.Rows(index).Cells("TacGia").Value.ToString()
                Dim _SoLuongTon As Integer = Convert.ToInt32(Data.Rows(index).Cells("SoLuongTon").Value)
                Dim _DonGIa As Integer = Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value)
                Dim _SoLuongNhap As Integer = Integer.Parse(Data.Rows(index).Cells("SoLuongNhap").Value.ToString)
                If Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value) < 0 Then
                    Data.Rows(index).Cells("DonGia").Value = Data.Rows(index).Cells("DonGia").Value * (-1)
                End If
                'Neu trung thi update so luong ton
                If QuiDinh_DAL.Instance.KiemtraSoLuongNhap(Integer.Parse(Data.Rows(index).Cells("SoLuongNhap").Value.ToString())) = False Then
                    _QuiDinh = _QuiDinh + 1
                End If
                If QuiDinh_DAL.Instance.KiemtraSoLuongTon(Integer.Parse(Data.Rows(index).Cells("SoLuongTon").Value.ToString())) = False Then
                    _QuiDinh = _QuiDinh + 1
                End If
                If Sach_DAL.Instance.Kiemtratontai(_MaSach) = True And _QuiDinh = 0 Then
                    If Sach_DAL.Instance.UpdateSach(_SoLuongNhap, _MaSach) = True Then
                        _temp = _temp + 1
                    End If
                ElseIf Sach_DAL.Instance.Kiemtratontai(_MaSach) = False And _QuiDinh = 0 Then
                    Dim SoLuongTon_SachChuaCo = _SoLuongNhap ' số lượng tồn của sách chưa tồn tại
                    Dim Sach As New Sach_DTO(_MaSach, _TenSach, _TheLoai, _TacGia, SoLuongTon_SachChuaCo, _DonGIa)
                    ' thmê sách

                    If Sach_DAL.Instance.Insert(Sach) = True Then
                        _temp = _temp + 1
                        ' Nếu thêm sách được thì lưu vào báo cáo
                    End If
                End If

                ' them chi tiet phieu nhap
                If _temp > 0 And _QuiDinh = 0 Then
                    Dim _Chitiet As New ChiTietPhieuNhap_DTO(_MaPhieuNhap, _MaSach, _SoLuongNhap)
                    ChiTietPhieuNhap_DAL.Instance.insertChithiet(_Chitiet)
                    Dim BaoCaoTon As New BaoCaoTon_DTO(_NgayNhap, _MaSach, _SoLuongTon, _SoLuongNhap, _SoLuongTon + _SoLuongNhap)
                    BaoCaoTon_DAL.Instance.insertBaoCao(BaoCaoTon)
                End If
            End If
        Next

        If _temp > 0 And _QuiDinh = 0 Then
            MessageBox.Show("Lập phiếu thành công")
        Else
            MessageBox.Show("Lập phiếu không thành công . không thỏa số lượng nhập tối thiểu")
        End If
    End Sub

    Public Sub CellClick(Data As DataGridView)
        For index = 0 To Data.Rows.Count - 2
            Dim Row As DataRow = PhieuNhapSach_DAL.Instance.loadDataRow(Data.Rows(index).Cells("MaSach").Value.ToString)
            Data.Rows(index).Cells("STT").Value = index + 1
            'kiểm tra sách đã tồn tai chưa
            If Sach_DAL.Instance.Kiemtratontai(Data.Rows(index).Cells("MaSach").Value.ToString) = True Then
                Data.Rows(index).Cells("TenSach").Value = Row.Item("TenSach")
                Data.Rows(index).Cells("TheLoai").Value = Row.Item("TheLoai")
                Data.Rows(index).Cells("TacGia").Value = Row.Item("TacGia")
                Data.Rows(index).Cells("SoLuongTon").Value = Row.Item("SoLuongTon")
                Data.Rows(index).Cells("DonGia").Value = Row.Item("DonGia")
                Data.Rows(index).Cells("GhiChu").Value = "Đã tồn tại"
                Data.Rows(index).Cells("GhiChu").Style.BackColor = Color.Green
                If Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value) < 0 Then
                    Data.Rows(index).Cells("DonGia").Style.BackColor = Color.Red
                End If
                ' thay đổi màu của ô số lượng nhập
                ' Nếu <= qui định thì màu xanh , còn lại màu đỏ
                If Data.Rows(index).Cells("SoLuongNhap").Value Is Nothing Then
                    Data.Rows(index).Cells("SoLuongNhap").Value = 0
                End If

                If QuiDinh_DAL.Instance.KiemtraSoLuongNhap(Integer.Parse(Data.Rows(index).Cells("SoLuongNhap").Value.ToString())) Then
                        Data.Rows(index).Cells("SoLuongNhap").Style.BackColor = Color.Green
                    Else
                        Data.Rows(index).Cells("SoLuongNhap").Style.BackColor = Color.Red
                    End If
                    If QuiDinh_DAL.Instance.KiemtraSoLuongTon(Integer.Parse(Data.Rows(index).Cells("SoLuongTon").Value.ToString())) = True Then
                        Data.Rows(index).Cells("SoLuongTon").Style.BackColor = Color.Green
                    Else
                        Data.Rows(index).Cells("SoLuongTon").Style.BackColor = Color.Red
                    End If
                Else
                    ' cập nhật lại khi nhập mã sách chưa tồn tại vào dòng đã có dữ liệu
                    If Data.Rows(index).Cells("MaSach").Value Is Nothing Then
                    Data.Rows(index).Cells("TenSach").Value = ""
                    Data.Rows(index).Cells("TheLoai").Value = ""
                    Data.Rows(index).Cells("TacGia").Value = ""
                    Data.Rows(index).Cells("SoLuongTon").Value = ""
                    Data.Rows(index).Cells("DonGia").Value = "0"
                    ' kiểm tra số lượng nhập tối thiểu
                End If
                Data.Rows(index).Cells("GhiChu").Value = "Chưa tồn tại"
                Data.Rows(index).Cells("SoLuongTon").Value = "0"
                Data.Rows(index).Cells("GhiChu").Style.BackColor = Color.Red
                If Convert.ToInt32(Data.Rows(index).Cells("DonGia").Value) < 0 Then
                    Data.Rows(index).Cells("DonGia").Style.BackColor = Color.Red
                Else
                    Data.Rows(index).Cells("DonGia").Style.BackColor = Color.Green
                End If
                If QuiDinh_DAL.Instance.KiemtraSoLuongNhap(Integer.Parse(Data.Rows(index).Cells("SoLuongNhap").Value.ToString())) Then
                    Data.Rows(index).Cells("SoLuongNhap").Style.BackColor = Color.Green
                Else
                    Data.Rows(index).Cells("SoLuongNhap").Style.BackColor = Color.Red
                End If
            End If
        Next

    End Sub
End Class
