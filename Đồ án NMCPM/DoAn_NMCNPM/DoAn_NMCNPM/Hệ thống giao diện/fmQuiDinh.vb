Imports BUS.DoAn_NMCNPM
Imports BUS
Public Class fmQuiDinh
    Private Sub fmQuiDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QuiDinh_BUS.Instance.Load(txbSoLuongNhapToiThieu_Cu, txbSoLuongTonToiDa_Cu, txbSoTienNoToiDa_Cu, txbSoLuongTonToiThieu_Cu, cbApDungQuiDinh4)
        txbSoLuongNhapToiThieu_Moi.Text = txbSoLuongNhapToiThieu_Cu.Text
        txbSoLuongTonToiDa_Moi.Text = txbSoLuongTonToiDa_Cu.Text
        txbSoLuongTonToiThieu_Moi.Text = txbSoLuongTonToiThieu_Cu.Text
        txbSoTienNoToiDa_Moi.Text = txbSoTienNoToiDa_Cu.Text

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Close()
    End Sub

    Private Sub btnThayDoiQuiDinh_Click(sender As Object, e As EventArgs) Handles btnThayDoiQuiDinh.Click

        If txbSoLuongNhapToiThieu_Moi.Text.Length = 0 Then
            txbSoLuongNhapToiThieu_Moi.Text = txbSoLuongNhapToiThieu_Cu.Text
        ElseIf txbSoLuongTonToiDa_Moi.Text.Length = 0 Then
            txbSoLuongTonToiDa_Moi.Text = txbSoLuongTonToiDa_Cu.Text
        ElseIf txbSoLuongTonToiThieu_Moi.Text.Length = 0 Then
            txbSoLuongTonToiThieu_Moi.Text = txbSoLuongTonToiThieu_Cu.Text
        ElseIf txbSoTienNoToiDa_Moi.Text.Length = 0 Then
            txbSoTienNoToiDa_Moi.Text = txbSoTienNoToiDa_Cu.Text
        End If

        QuiDinh_BUS.Instance.ThayDoiQuiDInh(txbSoLuongNhapToiThieu_Moi.Text, txbSoLuongTonToiDa_Moi.Text, txbSoTienNoToiDa_Moi.Text, txbSoLuongTonToiThieu_Moi.Text, cbApDungQuiDinh4.Checked)
        Close()
    End Sub

    Private Sub btnQuiDInhSLNToiThieu_Click(sender As Object, e As EventArgs) Handles btnQuiDInhSLNToiThieu.Click
        MessageBox.Show("Số Lượng nhập ít nhất là " + txbSoLuongNhapToiThieu_Cu.Text)
    End Sub

    Private Sub btnQuiDinhSLTtoida_Click(sender As Object, e As EventArgs) Handles btnQuiDinhSLTtoida.Click
        MessageBox.Show("chỉ nhập đầu sách có số lượng tồn ít hơn " + txbSoLuongTonToiDa_Cu.Text)
    End Sub

    Private Sub btnQuiDinhSLTToithieusauban_Click(sender As Object, e As EventArgs) Handles btnQuiDinhSLTToithieusauban.Click
        MessageBox.Show("Đầu sách có số lượng tồn sau bán ít nhấ là " + txbSoLuongTonToiThieu_Cu.Text)
    End Sub

    Private Sub btnSoTienNoTD_Click(sender As Object, e As EventArgs) Handles btnSoTienNoTD.Click
        MessageBox.Show("Chỉ bán cho khách hàng nợ không quá " + txbSoTienNoToiDa_Cu.Text)
    End Sub

    Private Sub btnApDungQD4_Click(sender As Object, e As EventArgs) Handles btnApDungQD4.Click
        MessageBox.Show("Số tiền thu không vượt quá số tiền khách hàng đang nợ ")
    End Sub
End Class