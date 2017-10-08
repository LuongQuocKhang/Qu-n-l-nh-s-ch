Imports BUS
Imports Microsoft.Office.Interop.Excel

Public Class fmBaoCaoTon
    Private Sub fmBaoCaoTon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbThang.SelectedIndex = DateTime.Now.Month - 1
        txbNam.Text = DateTime.Now.Year.ToString()
        BaoCaoTon_BUS.Instance.loaddulieu(dtgv, cbThang.SelectedIndex + 1, Convert.ToInt32(txbNam.Text))
    End Sub

    Private Sub cbThang_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbThang.SelectedValueChanged
        BaoCaoTon_BUS.Instance.loaddulieu(dtgv, cbThang.SelectedIndex + 1, Convert.ToInt32(txbNam.Text))
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub txbNam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNam.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False And Char.Equals(e.KeyChar, Char.Parse(".")) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNam_TextChanged(sender As Object, e As EventArgs) Handles txbNam.TextChanged
        If txbNam.Text.Length > 0 Then
            BaoCaoTon_BUS.Instance.loaddulieu(dtgv, cbThang.SelectedIndex + 1, Convert.ToInt32(txbNam.Text))
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        GridToExcel.Instance.GridToExcel(dtgv)
    End Sub
End Class