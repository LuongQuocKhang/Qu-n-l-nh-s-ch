Imports BUS

Public Class fmHoaDonBanSach
    Private Sub fmHoaDonBanSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpk.Value = Date.Now
        KhachHang_BUS.Instance.loadCBMaKhacHang(cbMaKhachHang)
        txbMaHoaDon.Text = PrimaryKey.Instance.CreatePrimaryKey("HOA_DON_BAN_SACH", "HD", 1)
    End Sub

    Private Sub dtgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgv.CellClick
        HoaDonBanSach_BUS.Instance.CellClick(dtgv)
    End Sub

    Private Sub dtgv_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dtgv.DefaultValuesNeeded
        e.Row.Cells("SoLuongBan").Value = "0"
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub btnLaphoadon_Click(sender As Object, e As EventArgs) Handles btnLaphoadon.Click
        HoaDonBanSach_BUS.Instance.insertHoaDon(txbMaHoaDon.Text, cbMaKhachHang.Text, dtpk.Value, dtgv)
        Close()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        dtgv.Rows.Clear()
    End Sub
End Class