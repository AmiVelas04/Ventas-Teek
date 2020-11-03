<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RdbContado = New System.Windows.Forms.RadioButton()
        Me.RdbCredito = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboDia = New System.Windows.Forms.ComboBox()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.CboAnio = New System.Windows.Forms.ComboBox()
        Me.BtnMos = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de comprobante"
        '
        'RdbContado
        '
        Me.RdbContado.AutoSize = True
        Me.RdbContado.Checked = True
        Me.RdbContado.Location = New System.Drawing.Point(29, 25)
        Me.RdbContado.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbContado.Name = "RdbContado"
        Me.RdbContado.Size = New System.Drawing.Size(84, 20)
        Me.RdbContado.TabIndex = 2
        Me.RdbContado.TabStop = True
        Me.RdbContado.Text = "Contado"
        Me.RdbContado.UseVisualStyleBackColor = True
        '
        'RdbCredito
        '
        Me.RdbCredito.AutoSize = True
        Me.RdbCredito.Location = New System.Drawing.Point(29, 54)
        Me.RdbCredito.Margin = New System.Windows.Forms.Padding(4)
        Me.RdbCredito.Name = "RdbCredito"
        Me.RdbCredito.Size = New System.Drawing.Size(76, 20)
        Me.RdbCredito.TabIndex = 3
        Me.RdbCredito.Text = "Credito"
        Me.RdbCredito.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Periodo"
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Items.AddRange(New Object() {"Dia", "Mes", "Año"})
        Me.CboPeriodo.Location = New System.Drawing.Point(174, 30)
        Me.CboPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(117, 24)
        Me.CboPeriodo.TabIndex = 5
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Black
        Me.BtnMostrar.Location = New System.Drawing.Point(975, 23)
        Me.BtnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(112, 28)
        Me.BtnMostrar.TabIndex = 6
        Me.BtnMostrar.Text = "Button1"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeColumns = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DGV1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV1.Location = New System.Drawing.Point(0, 79)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGV1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.Size = New System.Drawing.Size(899, 401)
        Me.DGV1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Día"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Año"
        '
        'CboDia
        '
        Me.CboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDia.Enabled = False
        Me.CboDia.FormattingEnabled = True
        Me.CboDia.Location = New System.Drawing.Point(416, 2)
        Me.CboDia.Name = "CboDia"
        Me.CboDia.Size = New System.Drawing.Size(57, 24)
        Me.CboDia.TabIndex = 11
        '
        'CboMes
        '
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.Enabled = False
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(416, 25)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(96, 24)
        Me.CboMes.TabIndex = 12
        '
        'CboAnio
        '
        Me.CboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnio.Enabled = False
        Me.CboAnio.FormattingEnabled = True
        Me.CboAnio.Location = New System.Drawing.Point(416, 49)
        Me.CboAnio.Name = "CboAnio"
        Me.CboAnio.Size = New System.Drawing.Size(57, 24)
        Me.CboAnio.TabIndex = 13
        '
        'BtnMos
        '
        Me.BtnMos.ForeColor = System.Drawing.Color.Black
        Me.BtnMos.Location = New System.Drawing.Point(577, 32)
        Me.BtnMos.Name = "BtnMos"
        Me.BtnMos.Size = New System.Drawing.Size(75, 23)
        Me.BtnMos.TabIndex = 14
        Me.BtnMos.Text = "Buscar"
        Me.BtnMos.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(679, 36)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(27, 20)
        Me.LblTotal.TabIndex = 15
        Me.LblTotal.Text = "Q."
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 480)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnMos)
        Me.Controls.Add(Me.CboAnio)
        Me.Controls.Add(Me.CboMes)
        Me.Controls.Add(Me.CboDia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BtnMostrar)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RdbCredito)
        Me.Controls.Add(Me.RdbContado)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents RdbContado As RadioButton
    Friend WithEvents RdbCredito As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents CboPeriodo As ComboBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboDia As ComboBox
    Friend WithEvents CboMes As ComboBox
    Friend WithEvents CboAnio As ComboBox
    Friend WithEvents BtnMos As Button
    Friend WithEvents LblTotal As Label
End Class
