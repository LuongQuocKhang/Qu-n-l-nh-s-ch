Imports Geocoding
Imports Geocoding.Google
Imports System.Collections.Generic
Public Class Form1
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        CheckEmailValidExample()
    End Sub

    Public Sub CheckEmailValidExample()
        If (FormatChecking.CheckValid.IsValidEmail(txbEmail.Text)) Then
            MessageBox.Show("Valid")
        Else
            MessageBox.Show("InValid")
        End If

    End Sub

    Public Sub GeoCodingExample()
        Dim geocoder As IGeocoder

        geocoder = New GoogleGeocoder("AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y")

        '"AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y") 'ApiKey = "AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y"
        Dim addresses As IEnumerable(Of Address) = geocoder.Geocode("123 nguyen dinh chieu")
        MessageBox.Show("Formatted: " + addresses.First().FormattedAddress) 'Formatted: 1600 Pennsylvania Ave SE, Washington, DC 20003, USA
        MessageBox.Show("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude) 'Coordinates: 38.8791981, -76.9818437
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        Dim geocoder As IGeocoder

        geocoder = New GoogleGeocoder("AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y")

        '"AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y") 'ApiKey = "AIzaSyDACOr7cCwQXdN3RizokCbPzeqFcBH297Y"
        Dim addresses As IEnumerable(Of Address) = geocoder.Geocode(txbDiaChi.Text)
        MessageBox.Show("Formatted: " + addresses.First().FormattedAddress) 'Formatted: 1600 Pennsylvania Ave SE, Washington, DC 20003, USA
        MessageBox.Show("Coordinates: " + addresses.First().Coordinates.Latitude + ", " + addresses.First().Coordinates.Longitude) 'Coordinates: 38.8791981, -76.9818437

    End Sub
End Class
