<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudProd
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVprod = New System.Windows.Forms.DataGridView()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Grupo1 = New System.Windows.Forms.GroupBox()
        Me.BtnSubImagen = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtGan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPrecioV = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPrecioc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMarc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNomprod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DGVprod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grupo1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVprod
        '
        Me.DGVprod.AllowUserToAddRows = False
        Me.DGVprod.AllowUserToDeleteRows = False
        Me.DGVprod.AllowUserToResizeColumns = False
        Me.DGVprod.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DGVprod.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVprod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVprod.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DGVprod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DGVprod.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVprod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGVprod.EnableHeadersVisualStyles = False
        Me.DGVprod.GridColor = System.Drawing.Color.DarkRed
        Me.DGVprod.Location = New System.Drawing.Point(12, 43)
        Me.DGVprod.MultiSelect = False
        Me.DGVprod.Name = "DGVprod"
        Me.DGVprod.ReadOnly = True
        Me.DGVprod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVprod.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVprod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DGVprod.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVprod.Size = New System.Drawing.Size(533, 256)
        Me.DGVprod.TabIndex = 0
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(12, 13)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(193, 20)
        Me.TxtNombre.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.Green
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnBuscar.Location = New System.Drawing.Point(223, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 24)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Grupo1
        '
        Me.Grupo1.Controls.Add(Me.BtnSubImagen)
        Me.Grupo1.Controls.Add(Me.BtnGuardar)
        Me.Grupo1.Controls.Add(Me.Label7)
        Me.Grupo1.Controls.Add(Me.TxtGan)
        Me.Grupo1.Controls.Add(Me.Label8)
        Me.Grupo1.Controls.Add(Me.TxtPrecioV)
        Me.Grupo1.Controls.Add(Me.Label9)
        Me.Grupo1.Controls.Add(Me.TxtPrecioc)
        Me.Grupo1.Controls.Add(Me.Label4)
        Me.Grupo1.Controls.Add(Me.TxtCant)
        Me.Grupo1.Controls.Add(Me.Label5)
        Me.Grupo1.Controls.Add(Me.TxtMarc)
        Me.Grupo1.Controls.Add(Me.Label6)
        Me.Grupo1.Controls.Add(Me.TxtDesc)
        Me.Grupo1.Controls.Add(Me.Label3)
        Me.Grupo1.Controls.Add(Me.TxtNomprod)
        Me.Grupo1.Controls.Add(Me.Label2)
        Me.Grupo1.Controls.Add(Me.TxtCodigo)
        Me.Grupo1.Controls.Add(Me.Label1)
        Me.Grupo1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Grupo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grupo1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Grupo1.Location = New System.Drawing.Point(551, 0)
        Me.Grupo1.Name = "Grupo1"
        Me.Grupo1.Size = New System.Drawing.Size(268, 480)
        Me.Grupo1.TabIndex = 3
        Me.Grupo1.TabStop = False
        Me.Grupo1.Text = "Datos del producto"
        '
        'BtnSubImagen
        '
        Me.BtnSubImagen.FlatAppearance.BorderSize = 0
        Me.BtnSubImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSubImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.BtnSubImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubImagen.Location = New System.Drawing.Point(121, 393)
        Me.BtnSubImagen.Name = "BtnSubImagen"
        Me.BtnSubImagen.Size = New System.Drawing.Size(93, 38)
        Me.BtnSubImagen.TabIndex = 19
        Me.BtnSubImagen.Text = "Subir"
        Me.BtnSubImagen.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Green
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 454)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(262, 23)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Imagen"
        '
        'TxtGan
        '
        Me.TxtGan.Location = New System.Drawing.Point(131, 332)
        Me.TxtGan.Name = "TxtGan"
        Me.TxtGan.Size = New System.Drawing.Size(133, 22)
        Me.TxtGan.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ganancia"
        '
        'TxtPrecioV
        '
        Me.TxtPrecioV.Location = New System.Drawing.Point(131, 284)
        Me.TxtPrecioV.Name = "TxtPrecioV"
        Me.TxtPrecioV.Size = New System.Drawing.Size(133, 22)
        Me.TxtPrecioV.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Precio Venta"
        '
        'TxtPrecioc
        '
        Me.TxtPrecioc.Location = New System.Drawing.Point(131, 233)
        Me.TxtPrecioc.Name = "TxtPrecioc"
        Me.TxtPrecioc.Size = New System.Drawing.Size(133, 22)
        Me.TxtPrecioc.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio costo"
        '
        'TxtCant
        '
        Me.TxtCant.Location = New System.Drawing.Point(131, 189)
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(133, 22)
        Me.TxtCant.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad"
        '
        'TxtMarc
        '
        Me.TxtMarc.Location = New System.Drawing.Point(131, 145)
        Me.TxtMarc.Name = "TxtMarc"
        Me.TxtMarc.Size = New System.Drawing.Size(133, 22)
        Me.TxtMarc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Marca"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(131, 100)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(133, 22)
        Me.TxtDesc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'TxtNomprod
        '
        Me.TxtNomprod.Location = New System.Drawing.Point(131, 63)
        Me.TxtNomprod.Name = "TxtNomprod"
        Me.TxtNomprod.Size = New System.Drawing.Size(133, 22)
        Me.TxtNomprod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Location = New System.Drawing.Point(131, 27)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(133, 22)
        Me.TxtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.Orange
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEditar.Location = New System.Drawing.Point(3, 3)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 44)
        Me.BtnEditar.TabIndex = 4
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Maroon
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEliminar.Location = New System.Drawing.Point(109, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(105, 46)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "Borrar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEditar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnEliminar)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnNuevo)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 431)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(551, 49)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnNuevo.Location = New System.Drawing.Point(220, 3)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(98, 43)
        Me.BtnNuevo.TabIndex = 6
        Me.BtnNuevo.Text = "+ Producto"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'OFD1
        '
        Me.OFD1.FileName = "OpenFileDialog1"
        '
        'CrudProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(819, 480)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Grupo1)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.DGVprod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrudProd"
        Me.Text = "CrudProd"
        CType(Me.DGVprod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grupo1.ResumeLayout(False)
        Me.Grupo1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVprod As DataGridView
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Grupo1 As GroupBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtGan As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPrecioV As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPrecioc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCant As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMarc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNomprod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSubImagen As Button
    Friend WithEvents OFD1 As OpenFileDialog
End Class
