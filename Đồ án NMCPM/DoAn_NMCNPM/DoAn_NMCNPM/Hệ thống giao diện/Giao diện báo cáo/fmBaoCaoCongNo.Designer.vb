<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmBaoCaoCongNo
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnThoat = New MetroFramework.Controls.MetroButton()
        Me.dtgv = New MetroFramework.Controls.MetroGrid()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoVaTen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhatSinhCongNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoCuoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbThang = New MetroFramework.Controls.MetroComboBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txbNam = New MetroFramework.Controls.MetroTextBox()
        Me.btnExcel = New MetroFramework.Controls.MetroButton()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThoat
        '
        Me.btnThoat.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnThoat.Location = New System.Drawing.Point(789, 490)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(149, 54)
        Me.btnThoat.TabIndex = 11
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseCustomBackColor = True
        Me.btnThoat.UseSelectable = True
        '
        'dtgv
        '
        Me.dtgv.AllowUserToResizeRows = False
        Me.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaKH, Me.HoVaTen, Me.NoDau, Me.PhatSinhCongNo, Me.NoCuoi})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgv.EnableHeadersVisualStyles = False
        Me.dtgv.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv.Location = New System.Drawing.Point(27, 179)
        Me.dtgv.Name = "dtgv"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgv.RowTemplate.Height = 24
        Me.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgv.Size = New System.Drawing.Size(926, 289)
        Me.dtgv.TabIndex = 10
        Me.dtgv.UseCustomBackColor = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        '
        'MaKH
        '
        Me.MaKH.HeaderText = "Mã khách hàng"
        Me.MaKH.Name = "MaKH"
        Me.MaKH.ReadOnly = True
        '
        'HoVaTen
        '
        Me.HoVaTen.HeaderText = "Họ và tên khách hàng"
        Me.HoVaTen.Name = "HoVaTen"
        Me.HoVaTen.ReadOnly = True
        Me.HoVaTen.Width = 200
        '
        'NoDau
        '
        Me.NoDau.HeaderText = "Nợ đầu"
        Me.NoDau.Name = "NoDau"
        Me.NoDau.ReadOnly = True
        '
        'PhatSinhCongNo
        '
        Me.PhatSinhCongNo.HeaderText = "Phát sinh công nợ"
        Me.PhatSinhCongNo.Name = "PhatSinhCongNo"
        Me.PhatSinhCongNo.ReadOnly = True
        '
        'NoCuoi
        '
        Me.NoCuoi.HeaderText = "Nợ cuối"
        Me.NoCuoi.Name = "NoCuoi"
        Me.NoCuoi.ReadOnly = True
        '
        'cbThang
        '
        Me.cbThang.FormatString = "N2"
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.ItemHeight = 24
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(396, 123)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(94, 30)
        Me.cbThang.TabIndex = 9
        Me.cbThang.UseCustomBackColor = True
        Me.cbThang.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label2.Location = New System.Drawing.Point(296, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 35)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tháng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseCustomBackColor = True
        '
        'Label3
        '
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label3.Location = New System.Drawing.Point(528, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 35)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Năm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.UseCustomBackColor = True
        '
        'txbNam
        '
        Me.txbNam.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txbNam.Lines = New String() {"0"}
        Me.txbNam.Location = New System.Drawing.Point(628, 123)
        Me.txbNam.MaxLength = 32767
        Me.txbNam.Multiline = True
        Me.txbNam.Name = "txbNam"
        Me.txbNam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNam.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbNam.SelectedText = ""
        Me.txbNam.Size = New System.Drawing.Size(88, 35)
        Me.txbNam.TabIndex = 13
        Me.txbNam.Text = "0"
        Me.txbNam.UseCustomBackColor = True
        Me.txbNam.UseSelectable = True
        '
        'btnExcel
        '
        Me.btnExcel.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnExcel.Location = New System.Drawing.Point(617, 490)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(166, 54)
        Me.btnExcel.TabIndex = 14
        Me.btnExcel.Text = "Xuất file Excel"
        Me.btnExcel.UseCustomBackColor = True
        Me.btnExcel.UseSelectable = True
        '
        'fmBaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 554)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.txbNam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.dtgv)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label2)
        Me.Name = "fmBaoCaoCongNo"
        Me.Text = "Báo Cáo Công Nợ"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaKH As DataGridViewTextBoxColumn
    Friend WithEvents HoVaTen As DataGridViewTextBoxColumn
    Friend WithEvents NoDau As DataGridViewTextBoxColumn
    Friend WithEvents PhatSinhCongNo As DataGridViewTextBoxColumn
    Friend WithEvents NoCuoi As DataGridViewTextBoxColumn
    Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
    Friend WithEvents dtgv As MetroFramework.Controls.MetroGrid
    Friend WithEvents cbThang As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbNam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnExcel As MetroFramework.Controls.MetroButton
End Class
