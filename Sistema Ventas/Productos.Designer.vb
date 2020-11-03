<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarCli = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCredito = New System.Windows.Forms.Label()
        Me.LblDir = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtMarc = New System.Windows.Forms.TextBox()
        Me.TxtDes = New System.Windows.Forms.TextBox()
        Me.TxtProd = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.BtnBuscaP = New System.Windows.Forms.Button()
        Me.ImgProd = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.RdbContado = New System.Windows.Forms.RadioButton()
        Me.RdbCredito = New System.Windows.Forms.RadioButton()
        Me.LblAntic = New System.Windows.Forms.Label()
        Me.TxtAntic = New System.Windows.Forms.TextBox()
        Me.BtnCobrar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBorrar.Location = New System.Drawing.Point(84, 1)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(83, 63)
        Me.BtnBorrar.TabIndex = 28
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Location = New System.Drawing.Point(0, 1)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(83, 63)
        Me.BtnLimpiar.TabIndex = 27
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscarCli)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.TxtNit)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(450, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 129)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'BtnBuscarCli
        '
        Me.BtnBuscarCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCli.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarCli.Location = New System.Drawing.Point(281, 16)
        Me.BtnBuscarCli.Name = "BtnBuscarCli"
        Me.BtnBuscarCli.Size = New System.Drawing.Size(75, 31)
        Me.BtnBuscarCli.TabIndex = 3
        Me.BtnBuscarCli.Text = "Buscar"
        Me.BtnBuscarCli.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblCredito)
        Me.Panel1.Controls.Add(Me.LblDir)
        Me.Panel1.Controls.Add(Me.LblNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(3, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 61)
        Me.Panel1.TabIndex = 2
        '
        'LblCredito
        '
        Me.LblCredito.AutoSize = True
        Me.LblCredito.Location = New System.Drawing.Point(221, 6)
        Me.LblCredito.Name = "LblCredito"
        Me.LblCredito.Size = New System.Drawing.Size(66, 16)
        Me.LblCredito.TabIndex = 2
        Me.LblCredito.Text = "Credito: "
        '
        'LblDir
        '
        Me.LblDir.AutoSize = True
        Me.LblDir.Location = New System.Drawing.Point(14, 37)
        Me.LblDir.Name = "LblDir"
        Me.LblDir.Size = New System.Drawing.Size(78, 16)
        Me.LblDir.TabIndex = 1
        Me.LblDir.Text = "Dirección:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(14, 6)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(67, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(52, 25)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(187, 22)
        Me.TxtNit.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtMarc)
        Me.GroupBox1.Controls.Add(Me.TxtDes)
        Me.GroupBox1.Controls.Add(Me.TxtProd)
        Me.GroupBox1.Controls.Add(Me.LblPrecio)
        Me.GroupBox1.Controls.Add(Me.LblMarca)
        Me.GroupBox1.Controls.Add(Me.LblDesc)
        Me.GroupBox1.Controls.Add(Me.LblProducto)
        Me.GroupBox1.Controls.Add(Me.BtnBuscaP)
        Me.GroupBox1.Controls.Add(Me.ImgProd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCod)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 159)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Location = New System.Drawing.Point(447, 57)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(129, 22)
        Me.TxtPrecio.TabIndex = 32
        '
        'TxtMarc
        '
        Me.TxtMarc.Enabled = False
        Me.TxtMarc.Location = New System.Drawing.Point(447, 24)
        Me.TxtMarc.Name = "TxtMarc"
        Me.TxtMarc.Size = New System.Drawing.Size(129, 22)
        Me.TxtMarc.TabIndex = 31
        '
        'TxtDes
        '
        Me.TxtDes.Location = New System.Drawing.Point(108, 93)
        Me.TxtDes.Multiline = True
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.ReadOnly = True
        Me.TxtDes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDes.Size = New System.Drawing.Size(468, 54)
        Me.TxtDes.TabIndex = 30
        '
        'TxtProd
        '
        Me.TxtProd.Enabled = False
        Me.TxtProd.Location = New System.Drawing.Point(107, 60)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.Size = New System.Drawing.Size(138, 22)
        Me.TxtProd.TabIndex = 29
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(357, 63)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(57, 16)
        Me.LblPrecio.TabIndex = 27
        Me.LblPrecio.Text = "Precio:"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(355, 26)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(55, 16)
        Me.LblMarca.TabIndex = 26
        Me.LblMarca.Text = "Marca:"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Location = New System.Drawing.Point(11, 102)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(91, 16)
        Me.LblDesc.TabIndex = 24
        Me.LblDesc.Text = "Descripción"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Location = New System.Drawing.Point(12, 63)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(74, 16)
        Me.LblProducto.TabIndex = 23
        Me.LblProducto.Text = "Producto:"
        '
        'BtnBuscaP
        '
        Me.BtnBuscaP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaP.Location = New System.Drawing.Point(252, 22)
        Me.BtnBuscaP.Name = "BtnBuscaP"
        Me.BtnBuscaP.Size = New System.Drawing.Size(82, 57)
        Me.BtnBuscaP.TabIndex = 19
        Me.BtnBuscaP.Text = "Ingresar"
        Me.BtnBuscaP.UseVisualStyleBackColor = False
        '
        'ImgProd
        '
        Me.ImgProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.ImgProd.Location = New System.Drawing.Point(780, 18)
        Me.ImgProd.Name = "ImgProd"
        Me.ImgProd.Size = New System.Drawing.Size(116, 138)
        Me.ImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgProd.TabIndex = 17
        Me.ImgProd.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código"
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(108, 23)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(138, 22)
        Me.TxtCod.TabIndex = 1
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Descripcion, Me.Marca, Me.Precio, Me.Cantidad, Me.Total, Me.Imagen, Me.Disponible})
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV1.EnableHeadersVisualStyles = False
        Me.DGV1.GridColor = System.Drawing.Color.Red
        Me.DGV1.Location = New System.Drawing.Point(0, 141)
        Me.DGV1.MultiSelect = False
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
        Me.DGV1.RowHeadersVisible = False
        Me.DGV1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGV1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV1.ShowCellToolTips = False
        Me.DGV1.Size = New System.Drawing.Size(899, 180)
        Me.DGV1.TabIndex = 23
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 60
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Marca
        '
        Me.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 70
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 60
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 75
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 65
        '
        'Imagen
        '
        Me.Imagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.ReadOnly = True
        Me.Imagen.Visible = False
        Me.Imagen.Width = 5
        '
        'Disponible
        '
        Me.Disponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Disponible.HeaderText = "Disponible"
        Me.Disponible.Name = "Disponible"
        Me.Disponible.ReadOnly = True
        Me.Disponible.Visible = False
        Me.Disponible.Width = 5
        '
        'LblTotal
        '
        Me.LblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTotal.Location = New System.Drawing.Point(88, 83)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(356, 54)
        Me.LblTotal.TabIndex = 29
        Me.LblTotal.Text = "Total:Q."
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RdbContado
        '
        Me.RdbContado.AutoSize = True
        Me.RdbContado.Checked = True
        Me.RdbContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbContado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdbContado.Location = New System.Drawing.Point(219, 28)
        Me.RdbContado.Name = "RdbContado"
        Me.RdbContado.Size = New System.Drawing.Size(84, 20)
        Me.RdbContado.TabIndex = 30
        Me.RdbContado.TabStop = True
        Me.RdbContado.Text = "Contado"
        Me.RdbContado.UseVisualStyleBackColor = True
        '
        'RdbCredito
        '
        Me.RdbCredito.AutoSize = True
        Me.RdbCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCredito.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdbCredito.Location = New System.Drawing.Point(219, 54)
        Me.RdbCredito.Name = "RdbCredito"
        Me.RdbCredito.Size = New System.Drawing.Size(76, 20)
        Me.RdbCredito.TabIndex = 31
        Me.RdbCredito.Text = "Credito"
        Me.RdbCredito.UseVisualStyleBackColor = True
        '
        'LblAntic
        '
        Me.LblAntic.AutoSize = True
        Me.LblAntic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAntic.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblAntic.Location = New System.Drawing.Point(311, 28)
        Me.LblAntic.Name = "LblAntic"
        Me.LblAntic.Size = New System.Drawing.Size(64, 16)
        Me.LblAntic.TabIndex = 32
        Me.LblAntic.Text = "Anticipo"
        '
        'TxtAntic
        '
        Me.TxtAntic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAntic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtAntic.Location = New System.Drawing.Point(314, 54)
        Me.TxtAntic.Name = "TxtAntic"
        Me.TxtAntic.Size = New System.Drawing.Size(130, 22)
        Me.TxtAntic.TabIndex = 33
        '
        'BtnCobrar
        '
        Me.BtnCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCobrar.FlatAppearance.BorderSize = 0
        Me.BtnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCobrar.Image = CType(resources.GetObject("BtnCobrar.Image"), System.Drawing.Image)
        Me.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCobrar.Location = New System.Drawing.Point(0, 63)
        Me.BtnCobrar.Name = "BtnCobrar"
        Me.BtnCobrar.Size = New System.Drawing.Size(86, 60)
        Me.BtnCobrar.TabIndex = 26
        Me.BtnCobrar.Text = "Cobrar"
        Me.BtnCobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnCobrar.UseVisualStyleBackColor = False
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 480)
        Me.Controls.Add(Me.TxtAntic)
        Me.Controls.Add(Me.LblAntic)
        Me.Controls.Add(Me.RdbCredito)
        Me.Controls.Add(Me.RdbContado)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BtnCobrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCobrar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ImgProd As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtnBuscarCli As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCredito As Label
    Friend WithEvents LblDir As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnBuscaP As Button
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents LblProducto As Label
    Friend WithEvents TxtDes As TextBox
    Friend WithEvents TxtProd As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtMarc As TextBox
    Friend WithEvents RdbContado As RadioButton
    Friend WithEvents RdbCredito As RadioButton
    Friend WithEvents LblAntic As Label
    Friend WithEvents TxtAntic As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewTextBoxColumn
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
    Public WithEvents TxtCod As TextBox
End Class
