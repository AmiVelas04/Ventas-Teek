<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpReportes
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
        Me.Pan1 = New System.Windows.Forms.Panel()
        Me.Pan2 = New System.Windows.Forms.Panel()
        Me.BtnMProd = New System.Windows.Forms.Button()
        Me.Pan3 = New System.Windows.Forms.Panel()
        Me.BtnGan = New System.Windows.Forms.Button()
        Me.CboGAnio = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboGMes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboAnio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboDia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboCompro = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Pan1.SuspendLayout()
        Me.Pan2.SuspendLayout()
        Me.Pan3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pan1
        '
        Me.Pan1.Controls.Add(Me.GroupBox1)
        Me.Pan1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pan1.Location = New System.Drawing.Point(0, 0)
        Me.Pan1.Name = "Pan1"
        Me.Pan1.Size = New System.Drawing.Size(899, 267)
        Me.Pan1.TabIndex = 0
        '
        'Pan2
        '
        Me.Pan2.Controls.Add(Me.GroupBox2)
        Me.Pan2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pan2.Location = New System.Drawing.Point(0, 267)
        Me.Pan2.Name = "Pan2"
        Me.Pan2.Size = New System.Drawing.Size(443, 213)
        Me.Pan2.TabIndex = 1
        '
        'BtnMProd
        '
        Me.BtnMProd.BackColor = System.Drawing.Color.Green
        Me.BtnMProd.FlatAppearance.BorderSize = 0
        Me.BtnMProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMProd.ForeColor = System.Drawing.Color.White
        Me.BtnMProd.Location = New System.Drawing.Point(178, 92)
        Me.BtnMProd.Name = "BtnMProd"
        Me.BtnMProd.Size = New System.Drawing.Size(106, 62)
        Me.BtnMProd.TabIndex = 1
        Me.BtnMProd.Text = "Mostrar reporte"
        Me.BtnMProd.UseVisualStyleBackColor = False
        '
        'Pan3
        '
        Me.Pan3.Controls.Add(Me.GroupBox3)
        Me.Pan3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Pan3.Location = New System.Drawing.Point(449, 267)
        Me.Pan3.Name = "Pan3"
        Me.Pan3.Size = New System.Drawing.Size(450, 213)
        Me.Pan3.TabIndex = 2
        '
        'BtnGan
        '
        Me.BtnGan.BackColor = System.Drawing.Color.Green
        Me.BtnGan.FlatAppearance.BorderSize = 0
        Me.BtnGan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGan.ForeColor = System.Drawing.Color.White
        Me.BtnGan.Location = New System.Drawing.Point(170, 141)
        Me.BtnGan.Name = "BtnGan"
        Me.BtnGan.Size = New System.Drawing.Size(121, 51)
        Me.BtnGan.TabIndex = 5
        Me.BtnGan.Text = "Mostrar reporte"
        Me.BtnGan.UseVisualStyleBackColor = False
        '
        'CboGAnio
        '
        Me.CboGAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGAnio.ForeColor = System.Drawing.Color.Black
        Me.CboGAnio.FormattingEnabled = True
        Me.CboGAnio.Location = New System.Drawing.Point(170, 85)
        Me.CboGAnio.Name = "CboGAnio"
        Me.CboGAnio.Size = New System.Drawing.Size(121, 24)
        Me.CboGAnio.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(43, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Año"
        '
        'CboGMes
        '
        Me.CboGMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboGMes.ForeColor = System.Drawing.Color.Black
        Me.CboGMes.FormattingEnabled = True
        Me.CboGMes.Location = New System.Drawing.Point(170, 33)
        Me.CboGMes.Name = "CboGMes"
        Me.CboGMes.Size = New System.Drawing.Size(121, 24)
        Me.CboGMes.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(43, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Mes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.CboPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboDia)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CboCompro)
        Me.GroupBox1.Controls.Add(Me.CboMes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CboAnio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(899, 267)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte de Ventas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Periodo"
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPeriodo.ForeColor = System.Drawing.Color.Black
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(92, 96)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(121, 24)
        Me.CboPeriodo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(230, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Año"
        '
        'CboAnio
        '
        Me.CboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAnio.Enabled = False
        Me.CboAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAnio.ForeColor = System.Drawing.Color.Black
        Me.CboAnio.FormattingEnabled = True
        Me.CboAnio.Location = New System.Drawing.Point(309, 60)
        Me.CboAnio.Name = "CboAnio"
        Me.CboAnio.Size = New System.Drawing.Size(121, 24)
        Me.CboAnio.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(230, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Mes"
        '
        'CboMes
        '
        Me.CboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMes.Enabled = False
        Me.CboMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMes.ForeColor = System.Drawing.Color.Black
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Location = New System.Drawing.Point(309, 105)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(121, 24)
        Me.CboMes.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(230, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Dia"
        '
        'CboDia
        '
        Me.CboDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDia.Enabled = False
        Me.CboDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDia.ForeColor = System.Drawing.Color.Black
        Me.CboDia.FormattingEnabled = True
        Me.CboDia.Location = New System.Drawing.Point(309, 147)
        Me.CboDia.Name = "CboDia"
        Me.CboDia.Size = New System.Drawing.Size(121, 24)
        Me.CboDia.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(507, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Venta"
        '
        'CboCompro
        '
        Me.CboCompro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCompro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCompro.ForeColor = System.Drawing.Color.Black
        Me.CboCompro.FormattingEnabled = True
        Me.CboCompro.Location = New System.Drawing.Point(496, 111)
        Me.CboCompro.Name = "CboCompro"
        Me.CboCompro.Size = New System.Drawing.Size(121, 24)
        Me.CboCompro.TabIndex = 10
        '
        'BtnMostrar
        '
        Me.BtnMostrar.BackColor = System.Drawing.Color.Green
        Me.BtnMostrar.FlatAppearance.BorderSize = 0
        Me.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.ForeColor = System.Drawing.Color.White
        Me.BtnMostrar.Location = New System.Drawing.Point(673, 74)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(106, 55)
        Me.BtnMostrar.TabIndex = 11
        Me.BtnMostrar.Text = "Mostrar Reporte"
        Me.BtnMostrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnMProd)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 213)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Productos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnGan)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CboGAnio)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CboGMes)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 213)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ganacias"
        '
        'ImpReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(899, 480)
        Me.Controls.Add(Me.Pan3)
        Me.Controls.Add(Me.Pan2)
        Me.Controls.Add(Me.Pan1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImpReportes"
        Me.Text = "ImpReportes"
        Me.Pan1.ResumeLayout(False)
        Me.Pan2.ResumeLayout(False)
        Me.Pan3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pan1 As Panel
    Friend WithEvents Pan2 As Panel
    Friend WithEvents Pan3 As Panel
    Friend WithEvents BtnMProd As Button
    Friend WithEvents BtnGan As Button
    Friend WithEvents CboGAnio As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CboGMes As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents CboPeriodo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CboDia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CboCompro As ComboBox
    Friend WithEvents CboMes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboAnio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
