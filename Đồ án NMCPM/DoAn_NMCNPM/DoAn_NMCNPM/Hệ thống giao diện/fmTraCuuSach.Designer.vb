<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmTraCuuSach
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
        Me.dtgv_TraCuu = New MetroFramework.Controls.MetroGrid()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txbMaSach = New System.Windows.Forms.TextBox()
        Me.txbTenSach = New System.Windows.Forms.TextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txbTheloai = New System.Windows.Forms.TextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.txbtacgia = New System.Windows.Forms.TextBox()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbSLT_Den = New System.Windows.Forms.TextBox()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.txbSLT_Tu = New System.Windows.Forms.TextBox()
        Me.Label5 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txbDongia_Den = New System.Windows.Forms.TextBox()
        Me.Label10 = New MetroFramework.Controls.MetroLabel()
        Me.txbDongia_Tu = New System.Windows.Forms.TextBox()
        Me.Label11 = New MetroFramework.Controls.MetroLabel()
        Me.btnThoat = New MetroFramework.Controls.MetroButton()
        CType(Me.dtgv_TraCuu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgv_TraCuu
        '
        Me.dtgv_TraCuu.AllowUserToResizeRows = False
        Me.dtgv_TraCuu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgv_TraCuu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgv_TraCuu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtgv_TraCuu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_TraCuu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_TraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgv_TraCuu.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgv_TraCuu.EnableHeadersVisualStyles = False
        Me.dtgv_TraCuu.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtgv_TraCuu.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgv_TraCuu.Location = New System.Drawing.Point(2, 396)
        Me.dtgv_TraCuu.Name = "dtgv_TraCuu"
        Me.dtgv_TraCuu.ReadOnly = True
        Me.dtgv_TraCuu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_TraCuu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_TraCuu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgv_TraCuu.RowTemplate.Height = 24
        Me.dtgv_TraCuu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgv_TraCuu.Size = New System.Drawing.Size(1022, 293)
        Me.dtgv_TraCuu.TabIndex = 6
        Me.dtgv_TraCuu.UseCustomBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Mã Sách"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbMaSach
        '
        Me.txbMaSach.Location = New System.Drawing.Point(149, 140)
        Me.txbMaSach.Multiline = True
        Me.txbMaSach.Name = "txbMaSach"
        Me.txbMaSach.Size = New System.Drawing.Size(217, 27)
        Me.txbMaSach.TabIndex = 8
        '
        'txbTenSach
        '
        Me.txbTenSach.Location = New System.Drawing.Point(149, 207)
        Me.txbTenSach.Multiline = True
        Me.txbTenSach.Name = "txbTenSach"
        Me.txbTenSach.Size = New System.Drawing.Size(217, 27)
        Me.txbTenSach.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tên Sách"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbTheloai
        '
        Me.txbTheloai.Location = New System.Drawing.Point(149, 274)
        Me.txbTheloai.Multiline = True
        Me.txbTheloai.Name = "txbTheloai"
        Me.txbTheloai.Size = New System.Drawing.Size(217, 27)
        Me.txbTheloai.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(39, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Thể loại"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbtacgia
        '
        Me.txbtacgia.Location = New System.Drawing.Point(149, 341)
        Me.txbtacgia.Multiline = True
        Me.txbtacgia.Name = "txbtacgia"
        Me.txbtacgia.Size = New System.Drawing.Size(217, 27)
        Me.txbtacgia.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(39, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 27)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tác giả"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbSLT_Den)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txbSLT_Tu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 76)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Số Lượng tồn"
        '
        'txbSLT_Den
        '
        Me.txbSLT_Den.Location = New System.Drawing.Point(367, 33)
        Me.txbSLT_Den.Multiline = True
        Me.txbSLT_Den.Name = "txbSLT_Den"
        Me.txbSLT_Den.Size = New System.Drawing.Size(125, 27)
        Me.txbSLT_Den.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(257, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Đến"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbSLT_Tu
        '
        Me.txbSLT_Tu.Location = New System.Drawing.Point(126, 33)
        Me.txbSLT_Tu.Multiline = True
        Me.txbSLT_Tu.Name = "txbSLT_Tu"
        Me.txbSLT_Tu.Size = New System.Drawing.Size(125, 27)
        Me.txbSLT_Tu.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 27)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Từ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txbDongia_Den)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txbDongia_Tu)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(384, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 76)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Đơn giá"
        '
        'txbDongia_Den
        '
        Me.txbDongia_Den.Location = New System.Drawing.Point(367, 31)
        Me.txbDongia_Den.Multiline = True
        Me.txbDongia_Den.Name = "txbDongia_Den"
        Me.txbDongia_Den.Size = New System.Drawing.Size(125, 27)
        Me.txbDongia_Den.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(257, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 27)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Đến"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txbDongia_Tu
        '
        Me.txbDongia_Tu.Location = New System.Drawing.Point(126, 33)
        Me.txbDongia_Tu.Multiline = True
        Me.txbDongia_Tu.Name = "txbDongia_Tu"
        Me.txbDongia_Tu.Size = New System.Drawing.Size(125, 27)
        Me.txbDongia_Tu.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 27)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Từ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThoat
        '
        Me.btnThoat.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnThoat.Location = New System.Drawing.Point(902, 706)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(111, 55)
        Me.btnThoat.TabIndex = 18
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseCustomBackColor = True
        Me.btnThoat.UseSelectable = True
        '
        'fmTraCuuSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1025, 773)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txbtacgia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbTheloai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbTenSach)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbMaSach)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgv_TraCuu)
        Me.Name = "fmTraCuuSach"
        Me.Text = "Tra Cứu Sách"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dtgv_TraCuu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbMaSach As TextBox
    Friend WithEvents txbTenSach As TextBox
    Friend WithEvents txbTheloai As TextBox
    Friend WithEvents txbtacgia As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txbSLT_Den As TextBox
    Friend WithEvents txbSLT_Tu As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txbDongia_Den As TextBox
    Friend WithEvents txbDongia_Tu As TextBox
    Friend WithEvents dtgv_TraCuu As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnThoat As MetroFramework.Controls.MetroButton
End Class
