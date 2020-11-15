<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Panelsup = New System.Windows.Forms.Panel()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.LbUsu = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.panelLat = New System.Windows.Forms.Panel()
        Me.BtnCod = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnGastos = New System.Windows.Forms.Button()
        Me.BtnABono = New System.Windows.Forms.Button()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.BotonMenu = New System.Windows.Forms.PictureBox()
        Me.TmrMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.TmrOcultar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.Panelsup.SuspendLayout()
        Me.panelLat.SuspendLayout()
        CType(Me.BotonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panelsup
        '
        Me.Panelsup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panelsup.Controls.Add(Me.BtnMin)
        Me.Panelsup.Controls.Add(Me.BtnGuardar)
        Me.Panelsup.Controls.Add(Me.LbUsu)
        Me.Panelsup.Controls.Add(Me.BtnCerrar)
        Me.Panelsup.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelsup.Location = New System.Drawing.Point(0, 0)
        Me.Panelsup.Name = "Panelsup"
        Me.Panelsup.Size = New System.Drawing.Size(1024, 40)
        Me.Panelsup.TabIndex = 17
        '
        'BtnMin
        '
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), System.Drawing.Image)
        Me.BtnMin.Location = New System.Drawing.Point(936, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(41, 40)
        Me.BtnMin.TabIndex = 3
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.BorderSize = 0
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.White
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.Location = New System.Drawing.Point(252, 0)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(149, 40)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Respaldar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'LbUsu
        '
        Me.LbUsu.Dock = System.Windows.Forms.DockStyle.Left
        Me.LbUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LbUsu.Location = New System.Drawing.Point(0, 0)
        Me.LbUsu.Name = "LbUsu"
        Me.LbUsu.Size = New System.Drawing.Size(322, 40)
        Me.LbUsu.TabIndex = 1
        Me.LbUsu.Text = "Usuario"
        Me.LbUsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackgroundImage = CType(resources.GetObject("BtnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(983, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(41, 40)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'panelLat
        '
        Me.panelLat.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.panelLat.Controls.Add(Me.BtnCod)
        Me.panelLat.Controls.Add(Me.BtnCaja)
        Me.panelLat.Controls.Add(Me.BtnGastos)
        Me.panelLat.Controls.Add(Me.BtnABono)
        Me.panelLat.Controls.Add(Me.BtnReportes)
        Me.panelLat.Controls.Add(Me.BtnCliente)
        Me.panelLat.Controls.Add(Me.BtnUsuario)
        Me.panelLat.Controls.Add(Me.btnInventario)
        Me.panelLat.Controls.Add(Me.BtnVentas)
        Me.panelLat.Controls.Add(Me.BotonMenu)
        Me.panelLat.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLat.Location = New System.Drawing.Point(0, 40)
        Me.panelLat.Name = "panelLat"
        Me.panelLat.Size = New System.Drawing.Size(138, 728)
        Me.panelLat.TabIndex = 18
        '
        'BtnCod
        '
        Me.BtnCod.FlatAppearance.BorderSize = 0
        Me.BtnCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCod.ForeColor = System.Drawing.Color.White
        Me.BtnCod.Image = CType(resources.GetObject("BtnCod.Image"), System.Drawing.Image)
        Me.BtnCod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCod.Location = New System.Drawing.Point(0, 657)
        Me.BtnCod.Name = "BtnCod"
        Me.BtnCod.Size = New System.Drawing.Size(135, 59)
        Me.BtnCod.TabIndex = 9
        Me.BtnCod.Text = "Generador de codigos"
        Me.BtnCod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCod.UseVisualStyleBackColor = True
        '
        'BtnCaja
        '
        Me.BtnCaja.FlatAppearance.BorderSize = 0
        Me.BtnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaja.ForeColor = System.Drawing.Color.White
        Me.BtnCaja.Image = CType(resources.GetObject("BtnCaja.Image"), System.Drawing.Image)
        Me.BtnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCaja.Location = New System.Drawing.Point(3, 411)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(139, 45)
        Me.BtnCaja.TabIndex = 8
        Me.BtnCaja.Text = "     Corte de Caja"
        Me.BtnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCaja.UseVisualStyleBackColor = True
        Me.BtnCaja.Visible = False
        '
        'BtnGastos
        '
        Me.BtnGastos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGastos.FlatAppearance.BorderSize = 0
        Me.BtnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGastos.ForeColor = System.Drawing.Color.White
        Me.BtnGastos.Image = CType(resources.GetObject("BtnGastos.Image"), System.Drawing.Image)
        Me.BtnGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGastos.Location = New System.Drawing.Point(3, 156)
        Me.BtnGastos.Name = "BtnGastos"
        Me.BtnGastos.Size = New System.Drawing.Size(135, 38)
        Me.BtnGastos.TabIndex = 7
        Me.BtnGastos.Text = "Gastos"
        Me.BtnGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGastos.UseVisualStyleBackColor = True
        '
        'BtnABono
        '
        Me.BtnABono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnABono.FlatAppearance.BorderSize = 0
        Me.BtnABono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnABono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnABono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnABono.Image = CType(resources.GetObject("BtnABono.Image"), System.Drawing.Image)
        Me.BtnABono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnABono.Location = New System.Drawing.Point(-8, 105)
        Me.BtnABono.Name = "BtnABono"
        Me.BtnABono.Size = New System.Drawing.Size(148, 44)
        Me.BtnABono.TabIndex = 6
        Me.BtnABono.Text = "Abonos"
        Me.BtnABono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnABono.UseVisualStyleBackColor = True
        '
        'BtnReportes
        '
        Me.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnReportes.Image = CType(resources.GetObject("BtnReportes.Image"), System.Drawing.Image)
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(-6, 359)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(148, 23)
        Me.BtnReportes.TabIndex = 5
        Me.BtnReportes.Text = "Reportes"
        Me.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCliente.Image = CType(resources.GetObject("BtnCliente.Image"), System.Drawing.Image)
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(-5, 259)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(142, 23)
        Me.BtnCliente.TabIndex = 4
        Me.BtnCliente.Text = "Clientes"
        Me.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnUsuario
        '
        Me.BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuario.FlatAppearance.BorderSize = 0
        Me.BtnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnUsuario.Image = CType(resources.GetObject("BtnUsuario.Image"), System.Drawing.Image)
        Me.BtnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuario.Location = New System.Drawing.Point(-5, 307)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Size = New System.Drawing.Size(147, 23)
        Me.BtnUsuario.TabIndex = 3
        Me.BtnUsuario.Text = "    Usuarios"
        Me.BtnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUsuario.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventario.FlatAppearance.BorderSize = 0
        Me.btnInventario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventario.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInventario.Image = CType(resources.GetObject("btnInventario.Image"), System.Drawing.Image)
        Me.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventario.Location = New System.Drawing.Point(-8, 209)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(150, 32)
        Me.btnInventario.TabIndex = 2
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'BtnVentas
        '
        Me.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(-8, 70)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(145, 23)
        Me.BtnVentas.TabIndex = 1
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'BotonMenu
        '
        Me.BotonMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BotonMenu.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz
        Me.BotonMenu.Image = CType(resources.GetObject("BotonMenu.Image"), System.Drawing.Image)
        Me.BotonMenu.Location = New System.Drawing.Point(97, 6)
        Me.BotonMenu.Name = "BotonMenu"
        Me.BotonMenu.Size = New System.Drawing.Size(38, 35)
        Me.BotonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BotonMenu.TabIndex = 0
        Me.BotonMenu.TabStop = False
        '
        'TmrMostrar
        '
        Me.TmrMostrar.Interval = 12
        '
        'TmrOcultar
        '
        Me.TmrOcultar.Interval = 12
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.White
        Me.PanelCentral.BackgroundImage = CType(resources.GetObject("PanelCentral.BackgroundImage"), System.Drawing.Image)
        Me.PanelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.Location = New System.Drawing.Point(138, 40)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(886, 728)
        Me.PanelCentral.TabIndex = 19
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.panelLat)
        Me.Controls.Add(Me.Panelsup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panelsup.ResumeLayout(False)
        Me.panelLat.ResumeLayout(False)
        CType(Me.BotonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panelsup As Panel
    Friend WithEvents panelLat As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents TmrMostrar As Timer
    Friend WithEvents TmrOcultar As Timer
    Friend WithEvents BotonMenu As PictureBox
    Friend WithEvents BtnVentas As Button
    Friend WithEvents BtnCliente As Button
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents btnInventario As Button
    Friend WithEvents LbUsu As Label
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnABono As Button
    Friend WithEvents BtnGastos As Button
    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnCod As Button
End Class
