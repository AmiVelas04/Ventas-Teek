<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CorteCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CorteCaja))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSacarCaja = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEgr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIng = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.CboOpe = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgvOpera = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgvOpera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSacarCaja)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.BtnIngresar)
        Me.Panel1.Controls.Add(Me.TxtTotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtEgr)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtIng)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtDesc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtMonto)
        Me.Panel1.Controls.Add(Me.CboOpe)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1782, 341)
        Me.Panel1.TabIndex = 0
        '
        'BtnSacarCaja
        '
        Me.BtnSacarCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnSacarCaja.FlatAppearance.BorderSize = 0
        Me.BtnSacarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSacarCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSacarCaja.ForeColor = System.Drawing.Color.White
        Me.BtnSacarCaja.Image = CType(resources.GetObject("BtnSacarCaja.Image"), System.Drawing.Image)
        Me.BtnSacarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSacarCaja.Location = New System.Drawing.Point(1451, 156)
        Me.BtnSacarCaja.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSacarCaja.Name = "BtnSacarCaja"
        Me.BtnSacarCaja.Size = New System.Drawing.Size(309, 50)
        Me.BtnSacarCaja.TabIndex = 15
        Me.BtnSacarCaja.Text = "Abrir"
        Me.BtnSacarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSacarCaja.UseVisualStyleBackColor = False
        Me.BtnSacarCaja.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Image = CType(resources.GetObject("BtnBuscar.Image"), System.Drawing.Image)
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(1451, 13)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(309, 50)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.White
        Me.BtnIngresar.Image = CType(resources.GetObject("BtnIngresar.Image"), System.Drawing.Image)
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(1451, 77)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(309, 50)
        Me.BtnIngresar.TabIndex = 13
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(1019, 271)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(320, 49)
        Me.TxtTotal.TabIndex = 12
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(822, 274)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 42)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Total"
        '
        'TxtEgr
        '
        Me.TxtEgr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtEgr.Enabled = False
        Me.TxtEgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEgr.Location = New System.Drawing.Point(1019, 180)
        Me.TxtEgr.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEgr.Name = "TxtEgr"
        Me.TxtEgr.Size = New System.Drawing.Size(320, 49)
        Me.TxtEgr.TabIndex = 10
        Me.TxtEgr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(822, 183)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Egresos"
        '
        'TxtIng
        '
        Me.TxtIng.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtIng.Enabled = False
        Me.TxtIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIng.Location = New System.Drawing.Point(1019, 82)
        Me.TxtIng.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIng.Name = "TxtIng"
        Me.TxtIng.Size = New System.Drawing.Size(320, 49)
        Me.TxtIng.TabIndex = 8
        Me.TxtIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(816, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 42)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ingresos"
        '
        'TxtDesc
        '
        Me.TxtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(254, 274)
        Me.TxtDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(417, 49)
        Me.TxtDesc.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 277)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 42)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 205)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto"
        '
        'TxtMonto
        '
        Me.TxtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonto.Location = New System.Drawing.Point(254, 198)
        Me.TxtMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(188, 49)
        Me.TxtMonto.TabIndex = 3
        '
        'CboOpe
        '
        Me.CboOpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOpe.FormattingEnabled = True
        Me.CboOpe.Items.AddRange(New Object() {"Ingreso", "Egreso"})
        Me.CboOpe.Location = New System.Drawing.Point(254, 123)
        Me.CboOpe.Margin = New System.Windows.Forms.Padding(4)
        Me.CboOpe.Name = "CboOpe"
        Me.CboOpe.Size = New System.Drawing.Size(323, 50)
        Me.CboOpe.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operacion"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(20, 33)
        Me.DtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(667, 49)
        Me.DtpFecha.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DgvOpera)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 341)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1782, 699)
        Me.Panel2.TabIndex = 1
        '
        'DgvOpera
        '
        Me.DgvOpera.AllowUserToAddRows = False
        Me.DgvOpera.AllowUserToDeleteRows = False
        Me.DgvOpera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvOpera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvOpera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOpera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOpera.Location = New System.Drawing.Point(0, 0)
        Me.DgvOpera.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvOpera.Name = "DgvOpera"
        Me.DgvOpera.ReadOnly = True
        Me.DgvOpera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOpera.Size = New System.Drawing.Size(1782, 699)
        Me.DgvOpera.TabIndex = 0
        '
        'CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1782, 1040)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CorteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CorteCaja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgvOpera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents CboOpe As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DgvOpera As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEgr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIng As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSacarCaja As Button
End Class
