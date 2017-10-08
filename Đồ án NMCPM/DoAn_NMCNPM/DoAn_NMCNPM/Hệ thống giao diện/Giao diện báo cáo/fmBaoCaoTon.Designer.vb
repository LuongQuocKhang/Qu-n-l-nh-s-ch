<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmBaoCaoTon
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.dtgv = New MetroFramework.Controls.MetroGrid()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonDau = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhatSinh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TonCuoi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnThoat = New MetroFramework.Controls.MetroButton()
        Me.cbThang = New MetroFramework.Controls.MetroComboBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txbNam = New MetroFramework.Controls.MetroTextBox()
        Me.btnExcel = New MetroFramework.Controls.MetroButton()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label2.Location = New System.Drawing.Point(255, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dtgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.TenSach, Me.TonDau, Me.PhatSinh, Me.TonCuoi})
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
        Me.dtgv.Location = New System.Drawing.Point(3, 168)
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
        Me.dtgv.Size = New System.Drawing.Size(911, 289)
        Me.dtgv.TabIndex = 3
        Me.dtgv.UseCustomBackColor = True
        '
        'MaSach
        '
        Me.MaSach.HeaderText = "Mã sách"
        Me.MaSach.Name = "MaSach"
        Me.MaSach.ReadOnly = True
        '
        'TenSach
        '
        Me.TenSach.HeaderText = "Tên sách"
        Me.TenSach.Name = "TenSach"
        Me.TenSach.ReadOnly = True
        '
        'TonDau
        '
        Me.TonDau.HeaderText = "Tồn đầu"
        Me.TonDau.Name = "TonDau"
        Me.TonDau.ReadOnly = True
        '
        'PhatSinh
        '
        Me.PhatSinh.HeaderText = "Phát sinh"
        Me.PhatSinh.Name = "PhatSinh"
        Me.PhatSinh.ReadOnly = True
        '
        'TonCuoi
        '
        Me.TonCuoi.HeaderText = "Tồn cuối"
        Me.TonCuoi.Name = "TonCuoi"
        Me.TonCuoi.ReadOnly = True
        '
        'btnThoat
        '
        Me.btnThoat.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnThoat.Location = New System.Drawing.Point(755, 475)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(153, 54)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseCustomBackColor = True
        Me.btnThoat.UseSelectable = True
        '
        'cbThang
        '
        Me.cbThang.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.cbThang.FormatString = "N2"
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.ItemHeight = 29
        Me.cbThang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbThang.Location = New System.Drawing.Point(355, 115)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(88, 35)
        Me.cbThang.TabIndex = 2
        Me.cbThang.UseCustomBackColor = True
        Me.cbThang.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label3.Location = New System.Drawing.Point(449, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Năm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbNam
        '
        Me.txbNam.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txbNam.Lines = New String() {"0"}
        Me.txbNam.Location = New System.Drawing.Point(535, 115)
        Me.txbNam.MaxLength = 4
        Me.txbNam.Multiline = True
        Me.txbNam.Name = "txbNam"
        Me.txbNam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbNam.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbNam.SelectedText = ""
        Me.txbNam.Size = New System.Drawing.Size(85, 35)
        Me.txbNam.TabIndex = 6
        Me.txbNam.Text = "0"
        Me.txbNam.UseCustomBackColor = True
        Me.txbNam.UseSelectable = True
        '
        'btnExcel
        '
        Me.btnExcel.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnExcel.Location = New System.Drawing.Point(581, 475)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(157, 54)
        Me.btnExcel.TabIndex = 7
        Me.btnExcel.Text = "Xuất file Excel"
        Me.btnExcel.UseCustomBackColor = True
        Me.btnExcel.UseSelectable = True
        '
        'fmBaoCaoTon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 541)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.txbNam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.dtgv)
        Me.Controls.Add(Me.cbThang)
        Me.Controls.Add(Me.Label2)
        Me.Name = "fmBaoCaoTon"
        Me.Text = "Báo Cáo Tồn"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents TonDau As DataGridViewTextBoxColumn
    Friend WithEvents PhatSinh As DataGridViewTextBoxColumn
    Friend WithEvents TonCuoi As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtgv As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
    Friend WithEvents cbThang As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbNam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnExcel As MetroFramework.Controls.MetroButton
End Class
