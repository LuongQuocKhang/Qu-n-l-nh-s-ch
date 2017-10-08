<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnPhieuNhap = New MetroFramework.Controls.MetroButton()
        Me.btnHoadon = New MetroFramework.Controls.MetroButton()
        Me.btnPhieuThuTien = New MetroFramework.Controls.MetroButton()
        Me.btnBaoCao = New MetroFramework.Controls.MetroButton()
        Me.btnTracuu = New MetroFramework.Controls.MetroButton()
        Me.btnQuidinh = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnPhieuNhap
        '
        Me.btnPhieuNhap.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPhieuNhap.Location = New System.Drawing.Point(48, 163)
        Me.btnPhieuNhap.Name = "btnPhieuNhap"
        Me.btnPhieuNhap.Size = New System.Drawing.Size(205, 95)
        Me.btnPhieuNhap.TabIndex = 0
        Me.btnPhieuNhap.Text = "Phiếu Nhập Sách"
        Me.btnPhieuNhap.UseCustomBackColor = True
        Me.btnPhieuNhap.UseSelectable = True
        '
        'btnHoadon
        '
        Me.btnHoadon.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnHoadon.Location = New System.Drawing.Point(290, 163)
        Me.btnHoadon.Name = "btnHoadon"
        Me.btnHoadon.Size = New System.Drawing.Size(194, 95)
        Me.btnHoadon.TabIndex = 1
        Me.btnHoadon.Text = "Hóa đơn bán sách"
        Me.btnHoadon.UseCustomBackColor = True
        Me.btnHoadon.UseSelectable = True
        '
        'btnPhieuThuTien
        '
        Me.btnPhieuThuTien.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnPhieuThuTien.Location = New System.Drawing.Point(48, 292)
        Me.btnPhieuThuTien.Name = "btnPhieuThuTien"
        Me.btnPhieuThuTien.Size = New System.Drawing.Size(205, 95)
        Me.btnPhieuThuTien.TabIndex = 2
        Me.btnPhieuThuTien.Text = "Phiếu thu tiền"
        Me.btnPhieuThuTien.UseCustomBackColor = True
        Me.btnPhieuThuTien.UseSelectable = True
        '
        'btnBaoCao
        '
        Me.btnBaoCao.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnBaoCao.Location = New System.Drawing.Point(290, 292)
        Me.btnBaoCao.Name = "btnBaoCao"
        Me.btnBaoCao.Size = New System.Drawing.Size(194, 95)
        Me.btnBaoCao.TabIndex = 3
        Me.btnBaoCao.Text = "Lập Báo cáo"
        Me.btnBaoCao.UseCustomBackColor = True
        Me.btnBaoCao.UseSelectable = True
        '
        'btnTracuu
        '
        Me.btnTracuu.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnTracuu.Location = New System.Drawing.Point(519, 163)
        Me.btnTracuu.Name = "btnTracuu"
        Me.btnTracuu.Size = New System.Drawing.Size(200, 95)
        Me.btnTracuu.TabIndex = 4
        Me.btnTracuu.Text = "Tra cứu"
        Me.btnTracuu.UseCustomBackColor = True
        Me.btnTracuu.UseSelectable = True
        '
        'btnQuidinh
        '
        Me.btnQuidinh.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnQuidinh.Location = New System.Drawing.Point(519, 292)
        Me.btnQuidinh.Name = "btnQuidinh"
        Me.btnQuidinh.Size = New System.Drawing.Size(200, 95)
        Me.btnQuidinh.TabIndex = 5
        Me.btnQuidinh.Text = "Thay đổi qui định"
        Me.btnQuidinh.UseCustomBackColor = True
        Me.btnQuidinh.UseSelectable = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(789, 444)
        Me.Controls.Add(Me.btnQuidinh)
        Me.Controls.Add(Me.btnTracuu)
        Me.Controls.Add(Me.btnBaoCao)
        Me.Controls.Add(Me.btnPhieuThuTien)
        Me.Controls.Add(Me.btnHoadon)
        Me.Controls.Add(Me.btnPhieuNhap)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Phần mềm quản lý nhà sách"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPhieuNhap As MetroFramework.Controls.MetroButton
    Friend WithEvents btnHoadon As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPhieuThuTien As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBaoCao As MetroFramework.Controls.MetroButton
    Friend WithEvents btnTracuu As MetroFramework.Controls.MetroButton
    Friend WithEvents btnQuidinh As MetroFramework.Controls.MetroButton
End Class
