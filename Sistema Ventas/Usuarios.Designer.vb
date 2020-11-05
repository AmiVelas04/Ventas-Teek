<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupUsuario = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RdbAdmin = New System.Windows.Forms.RadioButton()
        Me.RdbVendedor = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPass2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPass1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtUsu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanBot = New System.Windows.Forms.Panel()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PanCent = New System.Windows.Forms.Panel()
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.GroupUsuario.SuspendLayout()
        Me.PanBot.SuspendLayout()
        Me.PanCent.SuspendLayout()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupUsuario
        '
        Me.GroupUsuario.Controls.Add(Me.BtnGuardar)
        Me.GroupUsuario.Controls.Add(Me.RdbAdmin)
        Me.GroupUsuario.Controls.Add(Me.RdbVendedor)
        Me.GroupUsuario.Controls.Add(Me.Label5)
        Me.GroupUsuario.Controls.Add(Me.TxtPass2)
        Me.GroupUsuario.Controls.Add(Me.Label4)
        Me.GroupUsuario.Controls.Add(Me.TxtPass1)
        Me.GroupUsuario.Controls.Add(Me.Label3)
        Me.GroupUsuario.Controls.Add(Me.TxtUsu)
        Me.GroupUsuario.Controls.Add(Me.Label2)
        Me.GroupUsuario.Controls.Add(Me.TxtNombre)
        Me.GroupUsuario.Controls.Add(Me.Label1)
        Me.GroupUsuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupUsuario.Enabled = False
        Me.GroupUsuario.ForeColor = System.Drawing.Color.White
        Me.GroupUsuario.Location = New System.Drawing.Point(639, 0)
        Me.GroupUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupUsuario.Name = "GroupUsuario"
        Me.GroupUsuario.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupUsuario.Size = New System.Drawing.Size(260, 480)
        Me.GroupUsuario.TabIndex = 1
        Me.GroupUsuario.TabStop = False
        Me.GroupUsuario.Text = "Usuarios"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(4, 445)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(252, 31)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'RdbAdmin
        '
        Me.RdbAdmin.AutoSize = True
        Me.RdbAdmin.ForeColor = System.Drawing.Color.White
        Me.RdbAdmin.Location = New System.Drawing.Point(26, 357)
        Me.RdbAdmin.Name = "RdbAdmin"
        Me.RdbAdmin.Size = New System.Drawing.Size(122, 20)
        Me.RdbAdmin.TabIndex = 10
        Me.RdbAdmin.Text = "Administrador"
        Me.RdbAdmin.UseVisualStyleBackColor = True
        '
        'RdbVendedor
        '
        Me.RdbVendedor.AutoSize = True
        Me.RdbVendedor.Checked = True
        Me.RdbVendedor.ForeColor = System.Drawing.Color.White
        Me.RdbVendedor.Location = New System.Drawing.Point(26, 383)
        Me.RdbVendedor.Name = "RdbVendedor"
        Me.RdbVendedor.Size = New System.Drawing.Size(94, 20)
        Me.RdbVendedor.TabIndex = 9
        Me.RdbVendedor.TabStop = True
        Me.RdbVendedor.Text = "Vendedor"
        Me.RdbVendedor.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 317)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de usuario"
        '
        'TxtPass2
        '
        Me.TxtPass2.Location = New System.Drawing.Point(26, 268)
        Me.TxtPass2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPass2.Name = "TxtPass2"
        Me.TxtPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass2.Size = New System.Drawing.Size(198, 22)
        Me.TxtPass2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña(repetir)"
        '
        'TxtPass1
        '
        Me.TxtPass1.Location = New System.Drawing.Point(26, 198)
        Me.TxtPass1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPass1.Name = "TxtPass1"
        Me.TxtPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass1.Size = New System.Drawing.Size(198, 22)
        Me.TxtPass1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'TxtUsu
        '
        Me.TxtUsu.Location = New System.Drawing.Point(26, 126)
        Me.TxtUsu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsu.Name = "TxtUsu"
        Me.TxtUsu.Size = New System.Drawing.Size(198, 22)
        Me.TxtUsu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(26, 57)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(198, 22)
        Me.TxtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'PanBot
        '
        Me.PanBot.Controls.Add(Me.BtnBuscar)
        Me.PanBot.Controls.Add(Me.TxtNom)
        Me.PanBot.Controls.Add(Me.BtnEditar)
        Me.PanBot.Controls.Add(Me.BtnEliminar)
        Me.PanBot.Controls.Add(Me.BtnAgregar)
        Me.PanBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBot.Location = New System.Drawing.Point(0, 406)
        Me.PanBot.Name = "PanBot"
        Me.PanBot.Size = New System.Drawing.Size(639, 74)
        Me.PanBot.TabIndex = 6
        '
        'BtnEditar
        '
        Me.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEditar.BackColor = System.Drawing.Color.Orange
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Location = New System.Drawing.Point(7, 15)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 44)
        Me.BtnEditar.TabIndex = 3
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Location = New System.Drawing.Point(88, 15)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 43)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Borrar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAgregar.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Location = New System.Drawing.Point(169, 15)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 43)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Nuevo"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'PanCent
        '
        Me.PanCent.Controls.Add(Me.DGVUsuarios)
        Me.PanCent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCent.Location = New System.Drawing.Point(0, 0)
        Me.PanCent.Name = "PanCent"
        Me.PanCent.Size = New System.Drawing.Size(639, 406)
        Me.PanCent.TabIndex = 7
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.AllowUserToAddRows = False
        Me.DGVUsuarios.AllowUserToDeleteRows = False
        Me.DGVUsuarios.AllowUserToResizeColumns = False
        Me.DGVUsuarios.AllowUserToResizeRows = False
        Me.DGVUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DGVUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DGVUsuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DGVUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Usuario, Me.Contraseña, Me.Nivel})
        Me.DGVUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVUsuarios.EnableHeadersVisualStyles = False
        Me.DGVUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.DGVUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVUsuarios.MultiSelect = False
        Me.DGVUsuarios.Name = "DGVUsuarios"
        Me.DGVUsuarios.ReadOnly = True
        Me.DGVUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DGVUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUsuarios.Size = New System.Drawing.Size(639, 406)
        Me.DGVUsuarios.TabIndex = 4
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 86
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        Me.Usuario.Width = 85
        '
        'Contraseña
        '
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.ReadOnly = True
        Me.Contraseña.Width = 110
        '
        'Nivel
        '
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.Name = "Nivel"
        Me.Nivel.ReadOnly = True
        Me.Nivel.Width = 67
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Location = New System.Drawing.Point(523, 18)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(112, 28)
        Me.BtnBuscar.TabIndex = 7
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(279, 24)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(215, 22)
        Me.TxtNom.TabIndex = 6
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 480)
        Me.Controls.Add(Me.PanCent)
        Me.Controls.Add(Me.PanBot)
        Me.Controls.Add(Me.GroupUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GroupUsuario.ResumeLayout(False)
        Me.GroupUsuario.PerformLayout()
        Me.PanBot.ResumeLayout(False)
        Me.PanBot.PerformLayout()
        Me.PanCent.ResumeLayout(False)
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupUsuario As GroupBox
    Friend WithEvents RdbAdmin As RadioButton
    Friend WithEvents RdbVendedor As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPass2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPass1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtUsu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PanBot As Panel
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PanCent As Panel
    Friend WithEvents DGVUsuarios As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewTextBoxColumn
End Class
