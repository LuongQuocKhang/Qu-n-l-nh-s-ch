Imports BUS

Public Class fmBaoCaoCongNo

    Private Sub fmBaoCaoCongNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbThang.SelectedIndex = 1
        txbNam.Text = DateTime.Now.Year.ToString()
        BaoCaoCongNo_BUS.Instance.LoadDulieu(dtgv, cbThang.SelectedIndex + 1, Convert.ToInt32(txbNam.Text))
    End Sub
    Private Sub cbThang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedValueChanged
        If txbNam.Text.Length = 0 Then
            txbNam.Text = "0"
        End If
        BaoCaoCongNo_BUS.Instance.LoadDulieu(dtgv, cbThang.SelectedIndex + 1, Convert.ToInt32(txbNam.Text))
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub btnLapBaoCao_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub txbNam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNam.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False And Char.Equals(e.KeyChar, Char.Parse(".")) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        GridToExcel.Instance.GridToExcel(dtgv)
    End Sub
End Class