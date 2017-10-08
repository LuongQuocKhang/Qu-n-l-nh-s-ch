Imports BUS
Imports BUS.DoAn_NMCNPM
Imports Geocoding
Imports Geocoding.Google

Public Class fmPhieuThuTien
    Dim KTQD4 As Boolean = True
    Private Sub fmPhieuThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpk.Value = Date.Now
        KhachHang_BUS.Instance.loadCBMaKhacHang(cbMaKH)

        KTQD4 = QuiDinh_BUS.Instance.loadQD4()
    End Sub
    Private Sub cbMaKH_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMaKH.SelectedValueChanged
        txbSoTienNoMoi.Text = "0"
        If KhachHang_BUS.Instance.Kiemtratontai(cbMaKH.SelectedValue.ToString) = True Then
            txbSoTienNoHT.Text = PhieuThuTien_BUS.Instance.loadSotienNo(cbMaKH.SelectedValue.ToString())
            PhieuThuTien_BUS.Instance.loadKH(cbMaKH.SelectedValue.ToString, txbHoTen, txbDienthoai, txbEmail, txbDiaChi)
        End If

    End Sub

    Private Sub btnLapPhieu_Click(sender As Object, e As EventArgs) Handles btnLapPhieu.Click
        If KhachHang_BUS.Instance.Kiemtratontai(cbMaKH.SelectedValue.ToString) = True Then
            PhieuThuTien_BUS.Instance.insertPhieuThu(cbMaKH.SelectedValue.ToString, dtpk.Value, Integer.Parse(txbSoTienNoHT.Text), Integer.Parse(txbSoTienThu.Text), Integer.Parse(txbSoTienNoMoi.Text), txbHoTen.Text, txbDiaChi.Text, txbEmail.Text, txbDienthoai.Text)
            Close()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub txbDienthoai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbDienthoai.KeyPress
        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False And Char.Equals(e.KeyChar, Char.Parse(".")) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbSoTienThu_TextChanged(sender As Object, e As EventArgs) Handles txbSoTienThu.TextChanged
        If txbSoTienThu.Text.Length > 0 Then
            If Integer.Parse(txbSoTienThu.Text) > Integer.Parse(txbSoTienNoHT.Text) Then
                If KTQD4 = True Then
                    txbSoTienThu.Text = txbSoTienNoHT.Text
                End If
            End If

            txbSoTienNoMoi.Text = (Integer.Parse(txbSoTienNoHT.Text) - (Integer.Parse(txbSoTienThu.Text))).ToString()
        Else
            txbSoTienThu.Text = "0"
        End If

    End Sub

    Private Sub txbEmail_TextChanged(sender As Object, e As EventArgs) Handles txbEmail.TextChanged
        If (FormatChecking.CheckValid.IsValidEmail(txbEmail.Text)) = False Then
            txbEmail.BackColor = Color.Red
        Else
            txbEmail.BackColor = Color.White
        End If
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If txbDiaChi.Text.Length > 0 Then
            Dim geocoder As IGeocoder

            geocoder = New GoogleGeocoder("AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y")

            '"AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y") 'ApiKey = "AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y"
            Dim addresses As IEnumerable(Of Address) = geocoder.Geocode(txbDiaChi.Text)
            txbDiaChi.Text = addresses.First().FormattedAddress
        End If
    End Sub
End Class