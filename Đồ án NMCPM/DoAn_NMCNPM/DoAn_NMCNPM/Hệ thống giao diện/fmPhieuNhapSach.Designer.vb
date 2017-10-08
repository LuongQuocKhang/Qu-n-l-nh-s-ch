<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmPhieuNhapSach
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.dtgv_Phieunhap = New MetroFramework.Controls.MetroGrid()
        Me.STT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongNhap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongTon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLapPhieu = New MetroFramework.Controls.MetroButton()
        Me.btnXoa = New MetroFramework.Controls.MetroButton()
        Me.btnThoat = New MetroFramework.Controls.MetroButton()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txbMaPhieuNhap = New MetroFramework.Controls.MetroTextBox()
        Me.dtpk = New System.Windows.Forms.DateTimePicker()
        CType(Me.dtgv_Phieunhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label1.Location = New System.Drawing.Point(381, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ngày nhập"
        '
        'dtgv_Phieunhap
        '
        Me.dtgv_Phieunhap.AllowUserToResizeRows = False
        Me.dtgv_Phieunhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgv_Phieunhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_Phieunhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dtgv_Phieunhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_Phieunhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_Phieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_Phieunhap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STT, Me.MaSach, Me.SoLuongNhap, Me.TenSach, Me.TheLoai, Me.TacGia, Me.SoLuongTon, Me.DonGia, Me.GhiChu})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_Phieunhap.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_Phieunhap.EnableHeadersVisualStyles = False
        Me.dtgv_Phieunhap.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtgv_Phieunhap.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_Phieunhap.Location = New System.Drawing.Point(0, 209)
        Me.dtgv_Phieunhap.Name = "dtgv_Phieunhap"
        Me.dtgv_Phieunhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_Phieunhap.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_Phieunhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgv_Phieunhap.RowTemplate.Height = 24
        Me.dtgv_Phieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgv_Phieunhap.Size = New System.Drawing.Size(1205, 322)
        Me.dtgv_Phieunhap.TabIndex = 2
        Me.dtgv_Phieunhap.UseCustomBackColor = True
        '
        'STT
        '
        Me.STT.HeaderText = "STT"
        Me.STT.Name = "STT"
        Me.STT.ReadOnly = True
        '
        'MaSach
        '
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        '
        'SoLuongNhap
        '
        Me.SoLuongNhap.HeaderText = "Số lượng nhập"
        Me.SoLuongNhap.Name = "SoLuongNhap"
        '
        'TenSach
        '
        Me.TenSach.HeaderText = "Tên sách"
        Me.TenSach.Name = "TenSach"
        '
        'TheLoai
        '
        Me.TheLoai.HeaderText = "Thể loại"
        Me.TheLoai.Name = "TheLoai"
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác giả"
        Me.TacGia.Name = "TacGia"
        '
        'SoLuongTon
        '
        Me.SoLuongTon.HeaderText = "Số lượng tồn"
        Me.SoLuongTon.Name = "SoLuongTon"
        Me.SoLuongTon.ReadOnly = True
        '
        'DonGia
        '
        Me.DonGia.HeaderText = "Đơn giá"
        Me.DonGia.Name = "DonGia"
        '
        'GhiChu
        '
        Me.GhiChu.HeaderText = "Ghi chú"
        Me.GhiChu.Name = "GhiChu"
        Me.GhiChu.ReadOnly = True
        '
        'btnLapPhieu
        '
        Me.btnLapPhieu.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnLapPhieu.Location = New System.Drawing.Point(815, 537)
        Me.btnLapPhieu.Name = "btnLapPhieu"
        Me.btnLapPhieu.Size = New System.Drawing.Size(126, 50)
        Me.btnLapPhieu.TabIndex = 3
        Me.btnLapPhieu.Text = "Lập phiếu"
        Me.btnLapPhieu.UseCustomBackColor = True
        Me.btnLapPhieu.UseSelectable = True
        '
        'btnXoa
        '
        Me.btnXoa.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnXoa.Location = New System.Drawing.Point(947, 537)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(126, 50)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseCustomBackColor = True
        Me.btnXoa.UseSelectable = True
        '
        'btnThoat
        '
        Me.btnThoat.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnThoat.Location = New System.Drawing.Point(1079, 537)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(126, 50)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseCustomBackColor = True
        Me.btnThoat.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label3.Location = New System.Drawing.Point(367, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Mã phiếu nhập"
        '
        'txbMaPhieuNhap
        '
        Me.txbMaPhieuNhap.Enabled = False
        Me.txbMaPhieuNhap.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txbMaPhieuNhap.Lines = New String(-1) {}
        Me.txbMaPhieuNhap.Location = New System.Drawing.Point(550, 96)
        Me.txbMaPhieuNhap.MaxLength = 6
        Me.txbMaPhieuNhap.Multiline = True
        Me.txbMaPhieuNhap.Name = "txbMaPhieuNhap"
        Me.txbMaPhieuNhap.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbMaPhieuNhap.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbMaPhieuNhap.SelectedText = ""
        Me.txbMaPhieuNhap.Size = New System.Drawing.Size(285, 36)
        Me.txbMaPhieuNhap.TabIndex = 9
        Me.txbMaPhieuNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txbMaPhieuNhap.UseCustomBackColor = True
        Me.txbMaPhieuNhap.UseSelectable = True
        '
        'dtpk
        '
        Me.dtpk.Location = New System.Drawing.Point(550, 158)
        Me.dtpk.Name = "dtpk"
        Me.dtpk.Size = New System.Drawing.Size(285, 22)
        Me.dtpk.TabIndex = 10
        Me.dtpk.Value = New Date(2017, 5, 6, 0, 0, 0, 0)
        '
        'fmPhieuNhapSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1210, 599)
        Me.Controls.Add(Me.dtpk)
        Me.Controls.Add(Me.txbMaPhieuNhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLapPhieu)
        Me.Controls.Add(Me.dtgv_Phieunhap)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmPhieuNhapSach"
        Me.Text = "Phiếu Nhập Sách"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dtgv_Phieunhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpk As DateTimePicker
    Friend WithEvents STT As DataGridViewTextBoxColumn
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongNhap As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongTon As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtgv_Phieunhap As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnLapPhieu As MetroFramework.Controls.MetroButton
    Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
    Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbMaPhieuNhap As MetroFramework.Controls.MetroTextBox
End Class
