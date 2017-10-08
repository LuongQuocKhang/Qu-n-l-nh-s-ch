Public Class Main

    Private Sub btnPhieuNhap_Click(sender As Object, e As EventArgs) Handles btnPhieuNhap.Click
        Dim _fmPhieuNhap As New fmPhieuNhapSach
        _fmPhieuNhap.ShowDialog()
    End Sub

    Private Sub btnQuidinh_Click(sender As Object, e As EventArgs) Handles btnQuidinh.Click
        Dim _fmQuiDinh As New fmQuiDinh
        _fmQuiDinh.ShowDialog()
    End Sub

    Private Sub btnTracuu_Click(sender As Object, e As EventArgs) Handles btnTracuu.Click
        Dim _fmTraCuuSach As New fmTraCuuSach
        _fmTraCuuSach.ShowDialog()
    End Sub

    Private Sub btnHoadon_Click(sender As Object, e As EventArgs) Handles btnHoadon.Click
        Dim _fmHoaDonBanSach As New fmHoaDonBanSach
        _fmHoaDonBanSach.ShowDialog()
    End Sub

    Private Sub btnPhieuThuTien_Click(sender As Object, e As EventArgs) Handles btnPhieuThuTien.Click
        Dim _PhieuThuTien As New fmPhieuThuTien
        _PhieuThuTien.ShowDialog()
    End Sub

    Private Sub btnBaoCao_Click(sender As Object, e As EventArgs) Handles btnBaoCao.Click
        Dim _BaoCao As New fmLapBaoCao
        _BaoCao.ShowDialog()
    End Sub


End Class
