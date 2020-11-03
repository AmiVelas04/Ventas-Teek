<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCobro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBXPAGO = New System.Windows.Forms.GroupBox()
        Me.BtnPago = New System.Windows.Forms.Button()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvPagos = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atendio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Concepto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbxCliente = New System.Windows.Forms.GroupBox()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDirCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNomcli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.GbxCredito = New System.Windows.Forms.GroupBox()
        Me.TxtDeuda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtVende = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCompro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCodCredi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVCredito = New System.Windows.Forms.DataGridView()
        Me.GBXPAGO.SuspendLayout()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxCliente.SuspendLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxCredito.SuspendLayout()
        CType(Me.DGVCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBXPAGO
        '
        Me.GBXPAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GBXPAGO.Controls.Add(Me.BtnPago)
        Me.GBXPAGO.Controls.Add(Me.TxtPago)
        Me.GBXPAGO.Controls.Add(Me.Label11)
        Me.GBXPAGO.Controls.Add(Me.DgvPagos)
        Me.GBXPAGO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBXPAGO.ForeColor = System.Drawing.Color.White
        Me.GBXPAGO.Location = New System.Drawing.Point(0, 326)
        Me.GBXPAGO.Name = "GBXPAGO"
        Me.GBXPAGO.Size = New System.Drawing.Size(899, 154)
        Me.GBXPAGO.TabIndex = 0
        Me.GBXPAGO.TabStop = False
        Me.GBXPAGO.Text = "Pagos"
        '
        'BtnPago
        '
        Me.BtnPago.ForeColor = System.Drawing.Color.Black
        Me.BtnPago.Location = New System.Drawing.Point(247, 35)
        Me.BtnPago.Name = "BtnPago"
        Me.BtnPago.Size = New System.Drawing.Size(75, 23)
        Me.BtnPago.TabIndex = 3
        Me.BtnPago.Text = "Abonar"
        Me.BtnPago.UseVisualStyleBackColor = True
        Me.BtnPago.Visible = False
        '
        'TxtPago
        '
        Me.TxtPago.Location = New System.Drawing.Point(108, 35)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(89, 22)
        Me.TxtPago.TabIndex = 2
        Me.TxtPago.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Abono"
        Me.Label11.Visible = False
        '
        'DgvPagos
        '
        Me.DgvPagos.AllowUserToAddRows = False
        Me.DgvPagos.AllowUserToDeleteRows = False
        Me.DgvPagos.AllowUserToOrderColumns = True
        Me.DgvPagos.AllowUserToResizeColumns = False
        Me.DgvPagos.AllowUserToResizeRows = False
        Me.DgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DgvPagos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Atendio, Me.Monto, Me.Fecha, Me.Hora, Me.Concepto})
        Me.DgvPagos.EnableHeadersVisualStyles = False
        Me.DgvPagos.Location = New System.Drawing.Point(347, 21)
        Me.DgvPagos.Name = "DgvPagos"
        Me.DgvPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPagos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvPagos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPagos.Size = New System.Drawing.Size(540, 127)
        Me.DgvPagos.TabIndex = 0
        Me.DgvPagos.Visible = False
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.No.Width = 5
        '
        'Atendio
        '
        Me.Atendio.HeaderText = "Atendio"
        Me.Atendio.Name = "Atendio"
        Me.Atendio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Atendio.Width = 5
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Monto.Width = 5
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Fecha.Width = 5
        '
        'Hora
        '
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Hora.Width = 5
        '
        'Concepto
        '
        Me.Concepto.HeaderText = "Concepto"
        Me.Concepto.Name = "Concepto"
        Me.Concepto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Concepto.Width = 5
        '
        'GbxCliente
        '
        Me.GbxCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GbxCliente.Controls.Add(Me.TxtSaldo)
        Me.GbxCliente.Controls.Add(Me.Label4)
        Me.GbxCliente.Controls.Add(Me.TxtNit)
        Me.GbxCliente.Controls.Add(Me.Label3)
        Me.GbxCliente.Controls.Add(Me.TxtDirCli)
        Me.GbxCliente.Controls.Add(Me.Label2)
        Me.GbxCliente.Controls.Add(Me.TxtNomcli)
        Me.GbxCliente.Controls.Add(Me.Label1)
        Me.GbxCliente.Controls.Add(Me.BtnBuscar)
        Me.GbxCliente.Controls.Add(Me.DGVCliente)
        Me.GbxCliente.Controls.Add(Me.TxtNom)
        Me.GbxCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbxCliente.ForeColor = System.Drawing.Color.White
        Me.GbxCliente.Location = New System.Drawing.Point(0, 0)
        Me.GbxCliente.Name = "GbxCliente"
        Me.GbxCliente.Size = New System.Drawing.Size(899, 173)
        Me.GbxCliente.TabIndex = 1
        Me.GbxCliente.TabStop = False
        Me.GbxCliente.Text = "Cliente"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Location = New System.Drawing.Point(108, 142)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(76, 22)
        Me.TxtSaldo.TabIndex = 10
        Me.TxtSaldo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Saldo Q."
        Me.Label4.Visible = False
        '
        'TxtNit
        '
        Me.TxtNit.Enabled = False
        Me.TxtNit.Location = New System.Drawing.Point(108, 112)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(133, 22)
        Me.TxtNit.TabIndex = 8
        Me.TxtNit.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nit"
        Me.Label3.Visible = False
        '
        'TxtDirCli
        '
        Me.TxtDirCli.Enabled = False
        Me.TxtDirCli.Location = New System.Drawing.Point(108, 82)
        Me.TxtDirCli.Name = "TxtDirCli"
        Me.TxtDirCli.Size = New System.Drawing.Size(231, 22)
        Me.TxtDirCli.TabIndex = 6
        Me.TxtDirCli.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dirección"
        Me.Label2.Visible = False
        '
        'TxtNomcli
        '
        Me.TxtNomcli.Enabled = False
        Me.TxtNomcli.Location = New System.Drawing.Point(108, 53)
        Me.TxtNomcli.Name = "TxtNomcli"
        Me.TxtNomcli.Size = New System.Drawing.Size(231, 22)
        Me.TxtNomcli.TabIndex = 4
        Me.TxtNomcli.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        Me.Label1.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Black
        Me.BtnBuscar.Location = New System.Drawing.Point(244, 21)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DGVCliente
        '
        Me.DGVCliente.AllowUserToAddRows = False
        Me.DGVCliente.AllowUserToDeleteRows = False
        Me.DGVCliente.AllowUserToResizeRows = False
        Me.DGVCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGVCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DGVCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DGVCliente.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.EnableHeadersVisualStyles = False
        Me.DGVCliente.Location = New System.Drawing.Point(359, 23)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.ReadOnly = True
        Me.DGVCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVCliente.RowHeadersVisible = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCliente.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCliente.Size = New System.Drawing.Size(528, 138)
        Me.DGVCliente.TabIndex = 1
        Me.DGVCliente.Visible = False
        '
        'TxtNom
        '
        Me.TxtNom.Enabled = False
        Me.TxtNom.Location = New System.Drawing.Point(27, 22)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(200, 22)
        Me.TxtNom.TabIndex = 0
        '
        'GbxCredito
        '
        Me.GbxCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.GbxCredito.Controls.Add(Me.TxtDeuda)
        Me.GbxCredito.Controls.Add(Me.Label10)
        Me.GbxCredito.Controls.Add(Me.TxtTotal)
        Me.GbxCredito.Controls.Add(Me.Label9)
        Me.GbxCredito.Controls.Add(Me.TxtVende)
        Me.GbxCredito.Controls.Add(Me.Label7)
        Me.GbxCredito.Controls.Add(Me.TxtCompro)
        Me.GbxCredito.Controls.Add(Me.Label6)
        Me.GbxCredito.Controls.Add(Me.TxtCodCredi)
        Me.GbxCredito.Controls.Add(Me.Label5)
        Me.GbxCredito.Controls.Add(Me.DGVCredito)
        Me.GbxCredito.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbxCredito.ForeColor = System.Drawing.Color.White
        Me.GbxCredito.Location = New System.Drawing.Point(0, 170)
        Me.GbxCredito.Name = "GbxCredito"
        Me.GbxCredito.Size = New System.Drawing.Size(899, 156)
        Me.GbxCredito.TabIndex = 2
        Me.GbxCredito.TabStop = False
        Me.GbxCredito.Text = "Credito"
        '
        'TxtDeuda
        '
        Me.TxtDeuda.Enabled = False
        Me.TxtDeuda.Location = New System.Drawing.Point(311, 24)
        Me.TxtDeuda.Name = "TxtDeuda"
        Me.TxtDeuda.Size = New System.Drawing.Size(87, 22)
        Me.TxtDeuda.TabIndex = 12
        Me.TxtDeuda.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Adeudo"
        Me.Label10.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(159, 92)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(64, 22)
        Me.TxtTotal.TabIndex = 10
        Me.TxtTotal.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Valor del credito"
        Me.Label9.Visible = False
        '
        'TxtVende
        '
        Me.TxtVende.Enabled = False
        Me.TxtVende.Location = New System.Drawing.Point(159, 123)
        Me.TxtVende.Name = "TxtVende"
        Me.TxtVende.Size = New System.Drawing.Size(144, 22)
        Me.TxtVende.TabIndex = 6
        Me.TxtVende.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Vendedor"
        Me.Label7.Visible = False
        '
        'TxtCompro
        '
        Me.TxtCompro.Enabled = False
        Me.TxtCompro.Location = New System.Drawing.Point(159, 60)
        Me.TxtCompro.Name = "TxtCompro"
        Me.TxtCompro.Size = New System.Drawing.Size(64, 22)
        Me.TxtCompro.TabIndex = 4
        Me.TxtCompro.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Documento"
        Me.Label6.Visible = False
        '
        'TxtCodCredi
        '
        Me.TxtCodCredi.Enabled = False
        Me.TxtCodCredi.Location = New System.Drawing.Point(159, 24)
        Me.TxtCodCredi.Name = "TxtCodCredi"
        Me.TxtCodCredi.Size = New System.Drawing.Size(64, 22)
        Me.TxtCodCredi.TabIndex = 2
        Me.TxtCodCredi.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Código de credito"
        Me.Label5.Visible = False
        '
        'DGVCredito
        '
        Me.DGVCredito.AllowUserToAddRows = False
        Me.DGVCredito.AllowUserToDeleteRows = False
        Me.DGVCredito.AllowUserToResizeRows = False
        Me.DGVCredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVCredito.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DGVCredito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DGVCredito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVCredito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCredito.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCredito.EnableHeadersVisualStyles = False
        Me.DGVCredito.Location = New System.Drawing.Point(421, 21)
        Me.DGVCredito.Name = "DGVCredito"
        Me.DGVCredito.ReadOnly = True
        Me.DGVCredito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCredito.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVCredito.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DGVCredito.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCredito.Size = New System.Drawing.Size(466, 124)
        Me.DGVCredito.TabIndex = 0
        Me.DGVCredito.Visible = False
        '
        'FrmCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(899, 480)
        Me.Controls.Add(Me.GbxCredito)
        Me.Controls.Add(Me.GbxCliente)
        Me.Controls.Add(Me.GBXPAGO)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCobro"
        Me.Text = "Abonos"
        Me.GBXPAGO.ResumeLayout(False)
        Me.GBXPAGO.PerformLayout()
        CType(Me.DgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxCliente.ResumeLayout(False)
        Me.GbxCliente.PerformLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxCredito.ResumeLayout(False)
        Me.GbxCredito.PerformLayout()
        CType(Me.DGVCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBXPAGO As GroupBox
    Friend WithEvents GbxCliente As GroupBox
    Friend WithEvents GbxCredito As GroupBox
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDirCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNomcli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtVende As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCompro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCodCredi As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVCredito As DataGridView
    Friend WithEvents TxtDeuda As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvPagos As DataGridView
    Friend WithEvents BtnPago As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Atendio As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Concepto As DataGridViewTextBoxColumn
End Class
