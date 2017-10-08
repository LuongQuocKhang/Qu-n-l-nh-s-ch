Imports BUS
Imports DAL

Public Class fmTraCuuSach
    Private Data As DataTable
    Private Sub fmTraCuuSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraCuu_BUS.Instance.Load(dtgv_TraCuu)
        Data = TraCuu_DAL.Instance.Load()
    End Sub

    Private Sub txbMaSach_TextChanged(sender As Object, e As EventArgs) Handles txbMaSach.TextChanged
        Dim DV As New DataView(Data)
        DV.RowFilter = String.Format("MaSach LIKE '%{0}%'", txbMaSach.Text)
        dtgv_TraCuu.DataSource = DV
    End Sub

    Private Sub txbTenSach_TextChanged(sender As Object, e As EventArgs) Handles txbTenSach.TextChanged
        Dim DV As New DataView(Data)
        DV.RowFilter = String.Format("TenSach LIKE '%{0}%'", txbTenSach.Text)
        dtgv_TraCuu.DataSource = DV
    End Sub

    Private Sub txbTheloai_TextChanged(sender As Object, e As EventArgs) Handles txbTheloai.TextChanged
        Dim DV As New DataView(Data)
        DV.RowFilter = String.Format("TheLoai LIKE '%{0}%'", txbTheloai.Text)
        dtgv_TraCuu.DataSource = DV
    End Sub

    Private Sub txbtacgia_TextChanged(sender As Object, e As EventArgs) Handles txbtacgia.TextChanged
        Dim DV As New DataView(Data)
        DV.RowFilter = String.Format("TacGia LIKE '%{0}%'", txbtacgia.Text)
        dtgv_TraCuu.DataSource = DV
    End Sub

    Private Sub txbSLT_Tu_TextChanged(sender As Object, e As EventArgs) Handles txbSLT_Tu.TextChanged, txbSLT_Den.TextChanged
        Dim DV As New DataView(Data)
        If txbSLT_Tu.Text.Length > 0 And txbSLT_Den.Text.Length > 0 Then
            DV.RowFilter = String.Format("SoLuongTon >= '{0}' AND SoLuongTon <= '{1}'", txbSLT_Tu.Text, txbSLT_Den.Text)
        ElseIf txbSLT_Tu.Text.Length > 0 And txbSLT_Den.Text.Length = 0 Then
            DV.RowFilter = String.Format("SoLuongTon >= '{0}'", txbSLT_Tu.Text)
        ElseIf txbSLT_Tu.Text.Length = 0 And txbSLT_Den.Text.Length > 0 Then
            DV.RowFilter = String.Format("SoLuongTon <= '{0}'", txbSLT_Den.Text)
        End If
        dtgv_TraCuu.DataSource = DV
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub txbDongia_Tu_TextChanged(sender As Object, e As EventArgs) Handles txbDongia_Tu.TextChanged, txbDongia_Den.TextChanged
        Dim DV As New DataView(Data)
        If txbDongia_Tu.Text.Length > 0 And txbDongia_Den.Text.Length = 0 Then
            DV.RowFilter = String.Format("DonGia >= '{0}'", txbDongia_Tu.Text)
        ElseIf txbDongia_Tu.Text.Length > 0 And txbDongia_Den.Text.Length > 0 Then
            DV.RowFilter = String.Format("DonGia >= '{0}' AND DonGia <= '{1}'", txbDongia_Tu.Text, txbDongia_Den.Text)
        ElseIf txbDongia_Tu.Text.Length > 0 And txbDongia_Den.Text.Length = 0 Then
            DV.RowFilter = String.Format("DonGia <= '{0}'", txbDongia_Den.Text)
        End If
        dtgv_TraCuu.DataSource = DV
    End Sub
End Class