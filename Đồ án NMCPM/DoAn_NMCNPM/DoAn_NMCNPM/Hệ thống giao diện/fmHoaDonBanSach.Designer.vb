<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmHoaDonBanSach
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
        Me.dtgv = New MetroFramework.Controls.MetroGrid()
        Me.MaSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongBan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TheLoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TacGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoLuongTon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DonGia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GhiChu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TongTien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txbMaHoaDon = New MetroFramework.Controls.MetroTextBox()
        Me.dtpk = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.btnThoat = New MetroFramework.Controls.MetroButton()
        Me.btnLaphoadon = New MetroFramework.Controls.MetroButton()
        Me.btnXoa = New MetroFramework.Controls.MetroButton()
        Me.cbMaKhachHang = New System.Windows.Forms.ComboBox()
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv
        '
        Me.dtgv.AllowUserToResizeRows = False
        Me.dtgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSach, Me.SoLuongBan, Me.TenSach, Me.TheLoai, Me.TacGia, Me.SoLuongTon, Me.DonGia, Me.GhiChu, Me.TongTien})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv.EnableHeadersVisualStyles = False
        Me.dtgv.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv.Location = New System.Drawing.Point(1, 239)
        Me.dtgv.Name = "dtgv"
        Me.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgv.RowTemplate.Height = 24
        Me.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgv.Size = New System.Drawing.Size(1275, 364)
        Me.dtgv.TabIndex = 1
        Me.dtgv.UseCustomBackColor = True
        '
        'MaSach
        '
        Me.MaSach.HeaderText = "Mã Sách"
        Me.MaSach.Name = "MaSach"
        '
        'SoLuongBan
        '
        Me.SoLuongBan.HeaderText = "Số Lượng Bán"
        Me.SoLuongBan.Name = "SoLuongBan"
        '
        'TenSach
        '
        Me.TenSach.HeaderText = "Tên Sách"
        Me.TenSach.Name = "TenSach"
        '
        'TheLoai
        '
        Me.TheLoai.HeaderText = "Thể Loại"
        Me.TheLoai.Name = "TheLoai"
        '
        'TacGia
        '
        Me.TacGia.HeaderText = "Tác Giả"
        Me.TacGia.Name = "TacGia"
        '
        'SoLuongTon
        '
        Me.SoLuongTon.HeaderText = "Số Lượng tồn"
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
        Me.GhiChu.HeaderText = "Ghi Chú"
        Me.GhiChu.Name = "GhiChu"
        '
        'TongTien
        '
        Me.TongTien.HeaderText = "Tổng tiền"
        Me.TongTien.Name = "TongTien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label2.Location = New System.Drawing.Point(369, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã khách hàng"
        Me.Label2.UseCustomBackColor = True
        '
        'txbMaHoaDon
        '
        Me.txbMaHoaDon.Enabled = False
        Me.txbMaHoaDon.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txbMaHoaDon.Lines = New String(-1) {}
        Me.txbMaHoaDon.Location = New System.Drawing.Point(568, 158)
        Me.txbMaHoaDon.MaxLength = 6
        Me.txbMaHoaDon.Name = "txbMaHoaDon"
        Me.txbMaHoaDon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txbMaHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txbMaHoaDon.SelectedText = ""
        Me.txbMaHoaDon.Size = New System.Drawing.Size(286, 28)
        Me.txbMaHoaDon.TabIndex = 4
        Me.txbMaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txbMaHoaDon.UseCustomBackColor = True
        Me.txbMaHoaDon.UseSelectable = True
        '
        'dtpk
        '
        Me.dtpk.Location = New System.Drawing.Point(568, 198)
        Me.dtpk.Name = "dtpk"
        Me.dtpk.Size = New System.Drawing.Size(286, 22)
        Me.dtpk.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label3.Location = New System.Drawing.Point(397, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 50)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mã hóa đơn" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.UseCustomBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Label4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.Label4.Location = New System.Drawing.Point(360, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ngày lập hóa đơn"
        Me.Label4.UseCustomBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnThoat.Location = New System.Drawing.Point(1151, 618)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(125, 48)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseCustomBackColor = True
        Me.btnThoat.UseSelectable = True
        '
        'btnLaphoadon
        '
        Me.btnLaphoadon.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnLaphoadon.Location = New System.Drawing.Point(815, 618)
        Me.btnLaphoadon.Name = "btnLaphoadon"
        Me.btnLaphoadon.Size = New System.Drawing.Size(151, 48)
        Me.btnLaphoadon.TabIndex = 13
        Me.btnLaphoadon.Text = "Lập hóa đơn"
        Me.btnLaphoadon.UseCustomBackColor = True
        Me.btnLaphoadon.UseSelectable = True
        '
        'btnXoa
        '
        Me.btnXoa.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnXoa.Location = New System.Drawing.Point(998, 618)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(127, 48)
        Me.btnXoa.TabIndex = 14
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseCustomBackColor = True
        Me.btnXoa.UseSelectable = True
        '
        'cbMaKhachHang
        '
        Me.cbMaKhachHang.FormattingEnabled = True
        Me.cbMaKhachHang.Location = New System.Drawing.Point(568, 120)
        Me.cbMaKhachHang.Name = "cbMaKhachHang"
        Me.cbMaKhachHang.Size = New System.Drawing.Size(286, 24)
        Me.cbMaKhachHang.TabIndex = 15
        '
        'fmHoaDonBanSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 682)
        Me.Controls.Add(Me.cbMaKhachHang)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnLaphoadon)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpk)
        Me.Controls.Add(Me.txbMaHoaDon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtgv)
        Me.Name = "fmHoaDonBanSach"
        Me.Text = "Hóa đơn bán sách"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dtgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpk As DateTimePicker
    Friend WithEvents MaSach As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongBan As DataGridViewTextBoxColumn
    Friend WithEvents TenSach As DataGridViewTextBoxColumn
    Friend WithEvents TheLoai As DataGridViewTextBoxColumn
    Friend WithEvents TacGia As DataGridViewTextBoxColumn
    Friend WithEvents SoLuongTon As DataGridViewTextBoxColumn
    Friend WithEvents DonGia As DataGridViewTextBoxColumn
    Friend WithEvents GhiChu As DataGridViewTextBoxColumn
    Friend WithEvents TongTien As DataGridViewTextBoxColumn
    Friend WithEvents dtgv As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txbMaHoaDon As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLaphoadon As MetroFramework.Controls.MetroButton
    Friend WithEvents btnXoa As MetroFramework.Controls.MetroButton
    Friend WithEvents cbMaKhachHang As ComboBox
End Class
