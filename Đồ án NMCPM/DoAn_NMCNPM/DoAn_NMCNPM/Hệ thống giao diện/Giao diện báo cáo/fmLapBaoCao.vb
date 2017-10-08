Public Class fmLapBaoCao
    Private Sub btnTon_Click(sender As Object, e As EventArgs) Handles btnTon.Click
        Dim _BaoCaoTon As New fmBaoCaoTon
        _BaoCaoTon.ShowDialog()
    End Sub

    Private Sub btnNoCong_Click(sender As Object, e As EventArgs) Handles btnNoCong.Click
        Dim BaoCaoCongNo As New fmBaoCaoCongNo
        BaoCaoCongNo.ShowDialog()
    End Sub
End Class