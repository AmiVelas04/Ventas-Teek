<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Me.GbxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtSald = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCred = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNomCli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanInf = New System.Windows.Forms.Panel()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.PanCentral = New System.Windows.Forms.Panel()
        Me.DgvCli = New System.Windows.Forms.DataGridView()
        Me.GbxDatos.SuspendLayout()
        Me.PanInf.SuspendLayout()
        Me.PanCentral.SuspendLayout()
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxDatos
        '
        Me.GbxDatos.Controls.Add(Me.TxtCod)
        Me.GbxDatos.Controls.Add(Me.Label6)
        Me.GbxDatos.Controls.Add(Me.BtnGuardar)
        Me.GbxDatos.Controls.Add(Me.TxtSald)
        Me.GbxDatos.Controls.Add(Me.Label5)
        Me.GbxDatos.Controls.Add(Me.TxtCred)
        Me.GbxDatos.Controls.Add(Me.Label4)
        Me.GbxDatos.Controls.Add(Me.TxtNit)
        Me.GbxDatos.Controls.Add(Me.Label3)
        Me.GbxDatos.Controls.Add(Me.TxtDir)
        Me.GbxDatos.Controls.Add(Me.Label2)
        Me.GbxDatos.Controls.Add(Me.TxtNomCli)
        Me.GbxDatos.Controls.Add(Me.Label1)
        Me.GbxDatos.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbxDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDatos.ForeColor = System.Drawing.Color.White
        Me.GbxDatos.Location = New System.Drawing.Point(634, 0)
        Me.GbxDatos.Name = "GbxDatos"
        Me.GbxDatos.Size = New System.Drawing.Size(252, 728)
        Me.GbxDatos.TabIndex = 3
        Me.GbxDatos.TabStop = False
        Me.GbxDatos.Text = "Cliente"
        '
        'TxtCod
        '
        Me.TxtCod.Enabled = False
        Me.TxtCod.Location = New System.Drawing.Point(127, 31)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(100, 22)
        Me.TxtCod.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Codigo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Lime
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(3, 702)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(246, 23)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtSald
        '
        Me.TxtSald.Enabled = False
        Me.TxtSald.Location = New System.Drawing.Point(127, 274)
        Me.TxtSald.Name = "TxtSald"
        Me.TxtSald.Size = New System.Drawing.Size(100, 22)
        Me.TxtSald.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Saldo"
        '
        'TxtCred
        '
        Me.TxtCred.Enabled = False
        Me.TxtCred.Location = New System.Drawing.Point(127, 209)
        Me.TxtCred.Name = "TxtCred"
        Me.TxtCred.Size = New System.Drawing.Size(100, 22)
        Me.TxtCred.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Credito"
        '
        'TxtNit
        '
        Me.TxtNit.Enabled = False
        Me.TxtNit.Location = New System.Drawing.Point(127, 164)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(100, 22)
        Me.TxtNit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nit"
        '
        'TxtDir
        '
        Me.TxtDir.Enabled = False
        Me.TxtDir.Location = New System.Drawing.Point(127, 118)
        Me.TxtDir.Name = "TxtDir"
        Me.TxtDir.Size = New System.Drawing.Size(100, 22)
        Me.TxtDir.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Direccion"
        '
        'TxtNomCli
        '
        Me.TxtNomCli.Enabled = False
        Me.TxtNomCli.Location = New System.Drawing.Point(127, 75)
        Me.TxtNomCli.Name = "TxtNomCli"
        Me.TxtNomCli.Size = New System.Drawing.Size(100, 22)
        Me.TxtNomCli.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'PanInf
        '
        Me.PanInf.Controls.Add(Me.BtnBorrar)
        Me.PanInf.Controls.Add(Me.BtnEditar)
        Me.PanInf.Controls.Add(Me.BtnNuevo)
        Me.PanInf.Controls.Add(Me.BtnBuscar)
        Me.PanInf.Controls.Add(Me.TxtNom)
        Me.PanInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanInf.Location = New System.Drawing.Point(0, 655)
        Me.PanInf.Name = "PanInf"
        Me.PanInf.Size = New System.Drawing.Size(634, 73)
        Me.PanInf.TabIndex = 7
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBorrar.BackColor = System.Drawing.Color.Red
        Me.BtnBorrar.FlatAppearance.BorderSize = 0
        Me.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBorrar.Location = New System.Drawing.Point(4, 18)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 43)
        Me.BtnBorrar.TabIndex = 12
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Location = New System.Drawing.Point(85, 18)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 43)
        Me.BtnEditar.TabIndex = 11
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNuevo.BackColor = System.Drawing.Color.Teal
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(166, 18)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 43)
        Me.BtnNuevo.TabIndex = 13
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscar.Location = New System.Drawing.Point(351, 32)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 15
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtNom
        '
        Me.TxtNom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNom.Location = New System.Drawing.Point(432, 32)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(183, 20)
        Me.TxtNom.TabIndex = 14
        '
        'PanCentral
        '
        Me.PanCentral.Controls.Add(Me.DgvCli)
        Me.PanCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCentral.Location = New System.Drawing.Point(0, 0)
        Me.PanCentral.Name = "PanCentral"
        Me.PanCentral.Size = New System.Drawing.Size(634, 655)
        Me.PanCentral.TabIndex = 8
        '
        'DgvCli
        '
        Me.DgvCli.AllowUserToAddRows = False
        Me.DgvCli.AllowUserToDeleteRows = False
        Me.DgvCli.AllowUserToResizeColumns = False
        Me.DgvCli.AllowUserToResizeRows = False
        Me.DgvCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvCli.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvCli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DgvCli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DgvCli.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DgvCli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCli.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvCli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCli.EnableHeadersVisualStyles = False
        Me.DgvCli.Location = New System.Drawing.Point(0, 0)
        Me.DgvCli.Name = "DgvCli"
        Me.DgvCli.ReadOnly = True
        Me.DgvCli.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCli.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvCli.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvCli.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCli.Size = New System.Drawing.Size(634, 655)
        Me.DgvCli.TabIndex = 3
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(886, 728)
        Me.Controls.Add(Me.PanCentral)
        Me.Controls.Add(Me.PanInf)
        Me.Controls.Add(Me.GbxDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cliente"
        Me.Text = "cliente"
        Me.GbxDatos.ResumeLayout(False)
        Me.GbxDatos.PerformLayout()
        Me.PanInf.ResumeLayout(False)
        Me.PanInf.PerformLayout()
        Me.PanCentral.ResumeLayout(False)
        CType(Me.DgvCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbxDatos As GroupBox
    Friend WithEvents TxtSald As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCred As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDir As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNomCli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtCod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanInf As Panel
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents PanCentral As Panel
    Friend WithEvents DgvCli As DataGridView
End Class
