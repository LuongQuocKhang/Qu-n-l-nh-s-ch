<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmLapBaoCao
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTon = New MetroFramework.Controls.MetroButton()
        Me.btnNoCong = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnTon
        '
        Me.btnTon.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnTon.Location = New System.Drawing.Point(23, 75)
        Me.btnTon.Name = "btnTon"
        Me.btnTon.Size = New System.Drawing.Size(179, 81)
        Me.btnTon.TabIndex = 0
        Me.btnTon.Text = "Báo cáo tồn"
        Me.btnTon.UseCustomBackColor = True
        Me.btnTon.UseSelectable = True
        '
        'btnNoCong
        '
        Me.btnNoCong.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnNoCong.Location = New System.Drawing.Point(249, 75)
        Me.btnNoCong.Name = "btnNoCong"
        Me.btnNoCong.Size = New System.Drawing.Size(189, 81)
        Me.btnNoCong.TabIndex = 1
        Me.btnNoCong.Text = "Báo cáo công nợ"
        Me.btnNoCong.UseCustomBackColor = True
        Me.btnNoCong.UseSelectable = True
        '
        'fmLapBaoCao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(463, 181)
        Me.Controls.Add(Me.btnNoCong)
        Me.Controls.Add(Me.btnTon)
        Me.Name = "fmLapBaoCao"
        Me.Text = "Lập Báo Cáo"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTon As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNoCong As MetroFramework.Controls.MetroButton
End Class
