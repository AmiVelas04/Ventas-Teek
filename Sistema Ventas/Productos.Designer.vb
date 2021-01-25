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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanSup = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblT = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.GbxSalida = New System.Windows.Forms.GroupBox()
        Me.RdbCredito = New System.Windows.Forms.RadioButton()
        Me.RdbContado = New System.Windows.Forms.RadioButton()
        Me.TxtAntic = New System.Windows.Forms.TextBox()
        Me.LblEfect = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnCobrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CboCliente = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarCli = New System.Windows.Forms.Button()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblCredito = New System.Windows.Forms.Label()
        Me.LblDir = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PanBot = New System.Windows.Forms.Panel()
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
        Me.PanCent = New System.Windows.Forms.Panel()
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
        Me.PanSup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GbxSalida.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanBot.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanCent.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSup
        '
        Me.PanSup.Controls.Add(Me.Panel1)
        Me.PanSup.Controls.Add(Me.GroupBox2)
        Me.PanSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSup.Location = New System.Drawing.Point(0, 0)
        Me.PanSup.Name = "PanSup"
        Me.PanSup.Size = New System.Drawing.Size(1782, 175)
        Me.PanSup.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblT)
        Me.Panel1.Controls.Add(Me.LblCambio)
        Me.Panel1.Controls.Add(Me.GbxSalida)
        Me.Panel1.Controls.Add(Me.TxtAntic)
        Me.Panel1.Controls.Add(Me.LblEfect)
        Me.Panel1.Controls.Add(Me.LblTotal)
        Me.Panel1.Controls.Add(Me.BtnBorrar)
        Me.Panel1.Controls.Add(Me.BtnLimpiar)
        Me.Panel1.Controls.Add(Me.BtnCobrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 175)
        Me.Panel1.TabIndex = 35
        '
        'LblT
        '
        Me.LblT.AutoSize = True
        Me.LblT.Location = New System.Drawing.Point(1047, 77)
        Me.LblT.Name = "LblT"
        Me.LblT.Size = New System.Drawing.Size(13, 13)
        Me.LblT.TabIndex = 53
        Me.LblT.Text = "0"
        Me.LblT.Visible = False
        '
        'LblCambio
        '
        Me.LblCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblCambio.Location = New System.Drawing.Point(650, 122)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(337, 45)
        Me.LblCambio.TabIndex = 52
        Me.LblCambio.Text = "Cambio:"
        Me.LblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GbxSalida
        '
        Me.GbxSalida.Controls.Add(Me.RdbCredito)
        Me.GbxSalida.Controls.Add(Me.RdbContado)
        Me.GbxSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxSalida.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GbxSalida.Location = New System.Drawing.Point(416, 12)
        Me.GbxSalida.Name = "GbxSalida"
        Me.GbxSalida.Size = New System.Drawing.Size(203, 147)
        Me.GbxSalida.TabIndex = 51
        Me.GbxSalida.TabStop = False
        Me.GbxSalida.Text = "Tipo de venta"
        '
        'RdbCredito
        '
        Me.RdbCredito.AutoSize = True
        Me.RdbCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCredito.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdbCredito.Location = New System.Drawing.Point(16, 92)
        Me.RdbCredito.Name = "RdbCredito"
        Me.RdbCredito.Size = New System.Drawing.Size(106, 29)
        Me.RdbCredito.TabIndex = 50
        Me.RdbCredito.Text = "Credito"
        Me.RdbCredito.UseVisualStyleBackColor = True
        '
        'RdbContado
        '
        Me.RdbContado.AutoSize = True
        Me.RdbContado.Checked = True
        Me.RdbContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbContado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RdbContado.Location = New System.Drawing.Point(16, 39)
        Me.RdbContado.Name = "RdbContado"
        Me.RdbContado.Size = New System.Drawing.Size(118, 29)
        Me.RdbContado.TabIndex = 49
        Me.RdbContado.TabStop = True
        Me.RdbContado.Text = "Contado"
        Me.RdbContado.UseVisualStyleBackColor = True
        '
        'TxtAntic
        '
        Me.TxtAntic.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAntic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtAntic.Location = New System.Drawing.Point(654, 36)
        Me.TxtAntic.Name = "TxtAntic"
        Me.TxtAntic.Size = New System.Drawing.Size(198, 31)
        Me.TxtAntic.TabIndex = 50
        '
        'LblEfect
        '
        Me.LblEfect.AutoSize = True
        Me.LblEfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEfect.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblEfect.Location = New System.Drawing.Point(651, 12)
        Me.LblEfect.Name = "LblEfect"
        Me.LblEfect.Size = New System.Drawing.Size(74, 20)
        Me.LblEfect.TabIndex = 49
        Me.LblEfect.Text = "Efectivo"
        '
        'LblTotal
        '
        Me.LblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTotal.Location = New System.Drawing.Point(650, 77)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(337, 45)
        Me.LblTotal.TabIndex = 46
        Me.LblTotal.Text = "Total:Q."
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBorrar
        '
        Me.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBorrar.Image = CType(resources.GetObject("BtnBorrar.Image"), System.Drawing.Image)
        Me.BtnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBorrar.Location = New System.Drawing.Point(23, 77)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(174, 63)
        Me.BtnBorrar.TabIndex = 45
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(23, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(174, 63)
        Me.BtnLimpiar.TabIndex = 44
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnCobrar
        '
        Me.BtnCobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCobrar.FlatAppearance.BorderSize = 0
        Me.BtnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCobrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCobrar.Image = CType(resources.GetObject("BtnCobrar.Image"), System.Drawing.Image)
        Me.BtnCobrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCobrar.Location = New System.Drawing.Point(933, 3)
        Me.BtnCobrar.Name = "BtnCobrar"
        Me.BtnCobrar.Size = New System.Drawing.Size(207, 60)
        Me.BtnCobrar.TabIndex = 43
        Me.BtnCobrar.Text = "Cobrar"
        Me.BtnCobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnCobrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(1146, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 175)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CboCliente)
        Me.Panel2.Controls.Add(Me.BtnBuscarCli)
        Me.Panel2.Controls.Add(Me.TxtNit)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.LblCredito)
        Me.Panel2.Controls.Add(Me.LblDir)
        Me.Panel2.Controls.Add(Me.LblNombre)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 154)
        Me.Panel2.TabIndex = 2
        '
        'CboCliente
        '
        Me.CboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCliente.FormattingEnabled = True
        Me.CboCliente.Location = New System.Drawing.Point(13, 30)
        Me.CboCliente.Name = "CboCliente"
        Me.CboCliente.Size = New System.Drawing.Size(229, 32)
        Me.CboCliente.TabIndex = 7
        '
        'BtnBuscarCli
        '
        Me.BtnBuscarCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarCli.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarCli.Location = New System.Drawing.Point(490, 110)
        Me.BtnBuscarCli.Name = "BtnBuscarCli"
        Me.BtnBuscarCli.Size = New System.Drawing.Size(131, 31)
        Me.BtnBuscarCli.TabIndex = 6
        Me.BtnBuscarCli.Text = "Buscar"
        Me.BtnBuscarCli.UseVisualStyleBackColor = False
        '
        'TxtNit
        '
        Me.TxtNit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNit.Location = New System.Drawing.Point(13, 96)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(187, 29)
        Me.TxtNit.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nit"
        '
        'LblCredito
        '
        Me.LblCredito.AutoSize = True
        Me.LblCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCredito.Location = New System.Drawing.Point(281, 86)
        Me.LblCredito.Name = "LblCredito"
        Me.LblCredito.Size = New System.Drawing.Size(89, 24)
        Me.LblCredito.TabIndex = 2
        Me.LblCredito.Text = "Credito: "
        '
        'LblDir
        '
        Me.LblDir.AutoSize = True
        Me.LblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDir.Location = New System.Drawing.Point(281, 33)
        Me.LblDir.Name = "LblDir"
        Me.LblDir.Size = New System.Drawing.Size(105, 24)
        Me.LblDir.TabIndex = 1
        Me.LblDir.Text = "Dirección:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(14, 6)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(91, 24)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'PanBot
        '
        Me.PanBot.Controls.Add(Me.GroupBox1)
        Me.PanBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBot.Location = New System.Drawing.Point(0, 870)
        Me.PanBot.Name = "PanBot"
        Me.PanBot.Size = New System.Drawing.Size(1782, 170)
        Me.PanBot.TabIndex = 26
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1782, 170)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Enabled = False
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(931, 116)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(267, 29)
        Me.TxtPrecio.TabIndex = 32
        '
        'TxtMarc
        '
        Me.TxtMarc.Enabled = False
        Me.TxtMarc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarc.Location = New System.Drawing.Point(931, 56)
        Me.TxtMarc.Name = "TxtMarc"
        Me.TxtMarc.Size = New System.Drawing.Size(267, 29)
        Me.TxtMarc.TabIndex = 31
        '
        'TxtDes
        '
        Me.TxtDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDes.Location = New System.Drawing.Point(416, 69)
        Me.TxtDes.Multiline = True
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.ReadOnly = True
        Me.TxtDes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDes.Size = New System.Drawing.Size(468, 78)
        Me.TxtDes.TabIndex = 30
        '
        'TxtProd
        '
        Me.TxtProd.Enabled = False
        Me.TxtProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProd.Location = New System.Drawing.Point(12, 116)
        Me.TxtProd.Name = "TxtProd"
        Me.TxtProd.Size = New System.Drawing.Size(383, 29)
        Me.TxtProd.TabIndex = 29
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.Location = New System.Drawing.Point(929, 89)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(76, 24)
        Me.LblPrecio.TabIndex = 27
        Me.LblPrecio.Text = "Precio:"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(927, 26)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(73, 24)
        Me.LblMarca.TabIndex = 26
        Me.LblMarca.Text = "Marca:"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc.Location = New System.Drawing.Point(412, 37)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(121, 24)
        Me.LblDesc.TabIndex = 24
        Me.LblDesc.Text = "Descripción"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(12, 89)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(100, 24)
        Me.LblProducto.TabIndex = 23
        Me.LblProducto.Text = "Producto:"
        '
        'BtnBuscaP
        '
        Me.BtnBuscaP.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnBuscaP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscaP.Location = New System.Drawing.Point(1263, 69)
        Me.BtnBuscaP.Name = "BtnBuscaP"
        Me.BtnBuscaP.Size = New System.Drawing.Size(160, 57)
        Me.BtnBuscaP.TabIndex = 19
        Me.BtnBuscaP.Text = "Ingresar"
        Me.BtnBuscaP.UseVisualStyleBackColor = False
        '
        'ImgProd
        '
        Me.ImgProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.ImgProd.Location = New System.Drawing.Point(1532, 18)
        Me.ImgProd.Name = "ImgProd"
        Me.ImgProd.Size = New System.Drawing.Size(247, 149)
        Me.ImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgProd.TabIndex = 17
        Me.ImgProd.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código"
        '
        'TxtCod
        '
        Me.TxtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCod.Location = New System.Drawing.Point(12, 53)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(241, 29)
        Me.TxtCod.TabIndex = 1
        '
        'PanCent
        '
        Me.PanCent.Controls.Add(Me.DGV1)
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(0, 175)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(1782, 695)
        Me.PanCent.TabIndex = 27
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeColumns = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.EnableHeadersVisualStyles = False
        Me.DGV1.GridColor = System.Drawing.Color.Red
        Me.DGV1.Location = New System.Drawing.Point(0, 0)
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
        Me.DGV1.Size = New System.Drawing.Size(1782, 695)
        Me.DGV1.TabIndex = 24
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 200
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 260
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
        Me.Marca.Width = 120
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
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
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1782, 1040)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanBot)
        Me.Controls.Add(Me.PanSup)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Productos"
        Me.Text = "Productos"
        Me.PanSup.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbxSalida.ResumeLayout(False)
        Me.GbxSalida.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanBot.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImgProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanCent.ResumeLayout(False)
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSup As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblCredito As Label
    Friend WithEvents LblDir As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents PanBot As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtMarc As TextBox
    Friend WithEvents TxtDes As TextBox
    Friend WithEvents TxtProd As TextBox
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblMarca As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents LblProducto As Label
    Friend WithEvents BtnBuscaP As Button
    Friend WithEvents ImgProd As PictureBox
    Friend WithEvents Label1 As Label
    Public WithEvents TxtCod As TextBox
    Friend WithEvents PanCent As Panel
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents CboCliente As ComboBox
    Friend WithEvents BtnBuscarCli As Button
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtAntic As TextBox
    Friend WithEvents LblEfect As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnCobrar As Button
    Friend WithEvents LblCambio As Label
    Friend WithEvents GbxSalida As GroupBox
    Friend WithEvents RdbCredito As RadioButton
    Friend WithEvents RdbContado As RadioButton
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewTextBoxColumn
    Friend WithEvents Disponible As DataGridViewTextBoxColumn
    Friend WithEvents LblT As Label
End Class
