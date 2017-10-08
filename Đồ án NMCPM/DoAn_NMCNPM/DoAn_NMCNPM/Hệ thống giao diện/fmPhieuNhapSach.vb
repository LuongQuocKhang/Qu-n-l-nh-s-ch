Imports BUS
Imports BUS.DoAn_NMCNPM
Imports DoAn_NMCNPM
Public Class fmPhieuNhapSach
    Private Sub fmPhieuNhapSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpk.Value = Date.Now
        txbMaPhieuNhap.Text = PrimaryKey.Instance.CreatePrimaryKey("PHIEU_NHAP", "PN", 1)
    End Sub

    Private Sub btnLapPhieu_Click(sender As Object, e As EventArgs) Handles btnLapPhieu.Click
        PhieuNhapSach_BUS.Instance.InsertPhieuNhap(txbMaPhieuNhap.Text, DateTime.Parse(dtpk.Value.ToString), dtgv_Phieunhap)
        Close()
    End Sub

    Private Sub dtgv_Phieunhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv_Phieunhap.CellClick

        If (dtgv_Phieunhap.SelectedCells(0).OwningRow.Cells(1).Value <> Nothing) Then
            PhieuNhapSach_BUS.Instance.CellClick(dtgv_Phieunhap)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub dtgv_Phieunhap_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dtgv_Phieunhap.DefaultValuesNeeded
        e.Row.Cells("SoLuongNhap").Value = "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        dtgv_Phieunhap.Rows.Clear()
    End Sub
End Class
