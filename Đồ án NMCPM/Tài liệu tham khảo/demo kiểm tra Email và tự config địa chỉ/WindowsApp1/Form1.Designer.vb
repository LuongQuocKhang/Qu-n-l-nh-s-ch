<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.txbDiaChi = New System.Windows.Forms.TextBox()
        Me.btnAuto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(84, 70)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(177, 22)
        Me.txbEmail.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Email"
        '
        'btnNhap
        '
        Me.btnNhap.Location = New System.Drawing.Point(28, 235)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(121, 55)
        Me.btnNhap.TabIndex = 2
        Me.btnNhap.Text = "Nhap"
        Me.btnNhap.UseVisualStyleBackColor = True
        '
        'txbDiaChi
        '
        Me.txbDiaChi.Location = New System.Drawing.Point(84, 113)
        Me.txbDiaChi.Name = "txbDiaChi"
        Me.txbDiaChi.Size = New System.Drawing.Size(194, 22)
        Me.txbDiaChi.TabIndex = 3
        '
        'btnAuto
        '
        Me.btnAuto.Location = New System.Drawing.Point(294, 97)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(121, 55)
        Me.btnAuto.TabIndex = 4
        Me.btnAuto.Text = "Autocomplete"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dia chi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 363)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.txbDiaChi)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbEmail)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNhap As Button
    Friend WithEvents txbDiaChi As TextBox
    Friend WithEvents btnAuto As Button
    Friend WithEvents Label2 As Label
End Class
