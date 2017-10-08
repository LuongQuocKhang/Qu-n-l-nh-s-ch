<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmdGetData = New System.Windows.Forms.Button()
        Me.cmdToExcel = New System.Windows.Forms.Button()
        Me.dgvwDatos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvwDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGetData
        '
        Me.cmdGetData.BackColor = System.Drawing.Color.White
        Me.cmdGetData.BackgroundImage = CType(resources.GetObject("cmdGetData.BackgroundImage"), System.Drawing.Image)
        Me.cmdGetData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGetData.ForeColor = System.Drawing.Color.White
        Me.cmdGetData.Location = New System.Drawing.Point(123, 12)
        Me.cmdGetData.Name = "cmdGetData"
        Me.cmdGetData.Size = New System.Drawing.Size(75, 72)
        Me.cmdGetData.TabIndex = 2
        Me.cmdGetData.Text = "Get Data"
        Me.cmdGetData.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdGetData.UseVisualStyleBackColor = False
        '
        'cmdToExcel
        '
        Me.cmdToExcel.BackgroundImage = CType(resources.GetObject("cmdToExcel.BackgroundImage"), System.Drawing.Image)
        Me.cmdToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdToExcel.ForeColor = System.Drawing.Color.White
        Me.cmdToExcel.Location = New System.Drawing.Point(218, 12)
        Me.cmdToExcel.Name = "cmdToExcel"
        Me.cmdToExcel.Size = New System.Drawing.Size(75, 72)
        Me.cmdToExcel.TabIndex = 0
        Me.cmdToExcel.Text = "To Excel"
        Me.cmdToExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdToExcel.UseVisualStyleBackColor = True
        '
        'dgvwDatos
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvwDatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvwDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvwDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvwDatos.BackgroundColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvwDatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Cyan
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvwDatos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvwDatos.Location = New System.Drawing.Point(12, 90)
        Me.dgvwDatos.Name = "dgvwDatos"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvwDatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvwDatos.Size = New System.Drawing.Size(377, 247)
        Me.dgvwDatos.TabIndex = 54
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 349)
        Me.Controls.Add(Me.dgvwDatos)
        Me.Controls.Add(Me.cmdGetData)
        Me.Controls.Add(Me.cmdToExcel)
        Me.Name = "Form1"
        Me.Text = "DataGridview To Excel"
        CType(Me.dgvwDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGetData As Button
    Friend WithEvents cmdToExcel As Button
    Friend WithEvents dgvwDatos As DataGridView
End Class
