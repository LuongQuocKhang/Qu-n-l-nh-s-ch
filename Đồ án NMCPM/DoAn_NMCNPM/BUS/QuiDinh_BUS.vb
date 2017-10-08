Imports System.Windows.Forms
Imports DAL
Imports DTO

Public Class QuiDinh_BUS
    Private Shared _instance As QuiDinh_BUS

    Public Shared Property Instance As QuiDinh_BUS
        Get
            If (_instance Is Nothing) Then
                _instance = New QuiDinh_BUS
            End If
            Return _instance
        End Get
        Set(value As QuiDinh_BUS)
            _instance = value
        End Set
    End Property

    Public Sub Load(ByRef SoLuongNhapToiThieu As MaskedTextBox, ByRef SoLuongTonDuocPhepNhap As MaskedTextBox,
                    ByRef SoTienNoToiDa As MaskedTextBox, ByRef SoLuongTonToiThieuSauBan As MaskedTextBox,
                    ApDungQuiDinh4 As CheckBox)
        Dim _QuiDinh As QuiDinh_DTO = QuiDinh_DAL.Instance.Load()
        SoLuongNhapToiThieu.Text = _QuiDinh.SoLuongNhapToiThieu
        SoLuongTonDuocPhepNhap.Text = _QuiDinh.SoLuongTonDuocPhepNhap
        SoTienNoToiDa.Text = _QuiDinh.SoTienNoToiDa
        SoLuongTonToiThieuSauBan.Text = _QuiDinh.SoLuongTonToiThieuSauBan

        If (_QuiDinh.ApDungQuiDinh4 = True) Then
            ApDungQuiDinh4.Checked = True
        Else
            ApDungQuiDinh4.Checked = False
        End If

    End Sub
    Public Sub ThayDoiQuiDInh(ByRef SoLuongNhapToiThieu As String, ByRef SoLuongTonDuocPhepNhap As String,
                    ByRef SoTienNoToiDa As String, ByRef SoLuongTonToiThieuSauBan As String,
                    ApDungQuiDinh4 As Boolean)
        Dim _QuiDInh As New QuiDinh_DTO(SoLuongNhapToiThieu, SoLuongTonDuocPhepNhap, SoTienNoToiDa, SoLuongTonToiThieuSauBan, ApDungQuiDinh4)
        If (QuiDinh_DAL.Instance.ThayDoiQuiDInh(_QuiDInh) = True) Then
            MessageBox.Show("Thay đổi qui định thành công !")
        Else
            MessageBox.Show("Thay đổi qui định không thành công!")
        End If
    End Sub

    Public Function loadQD4() As Boolean
        Dim _QuiDinh As QuiDinh_DTO = QuiDinh_DAL.Instance.Load()
        If (_QuiDinh.ApDungQuiDinh4 = True) Then
            Return True
        End If
        Return False
    End Function

End Class
