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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxIngresos = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAbonos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAntic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCont = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbxEgresos = New System.Windows.Forms.GroupBox()
        Me.TxtGastos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalCaja = New System.Windows.Forms.TextBox()
        Me.BtnCorte = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GbxIngresos.SuspendLayout()
        Me.GbxEgresos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(277, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Corte de Caja"
        '
        'GbxIngresos
        '
        Me.GbxIngresos.Controls.Add(Me.TxtSaldo)
        Me.GbxIngresos.Controls.Add(Me.Label8)
        Me.GbxIngresos.Controls.Add(Me.TxtTotal)
        Me.GbxIngresos.Controls.Add(Me.Label5)
        Me.GbxIngresos.Controls.Add(Me.TxtAbonos)
        Me.GbxIngresos.Controls.Add(Me.Label4)
        Me.GbxIngresos.Controls.Add(Me.TxtAntic)
        Me.GbxIngresos.Controls.Add(Me.Label3)
        Me.GbxIngresos.Controls.Add(Me.TxtCont)
        Me.GbxIngresos.Controls.Add(Me.Label2)
        Me.GbxIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxIngresos.ForeColor = System.Drawing.Color.White
        Me.GbxIngresos.Location = New System.Drawing.Point(12, 48)
        Me.GbxIngresos.Name = "GbxIngresos"
        Me.GbxIngresos.Size = New System.Drawing.Size(311, 291)
        Me.GbxIngresos.TabIndex = 1
        Me.GbxIngresos.TabStop = False
        Me.GbxIngresos.Text = "Ingreos"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(172, 246)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(121, 22)
        Me.TxtTotal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Total"
        '
        'TxtAbonos
        '
        Me.TxtAbonos.Enabled = False
        Me.TxtAbonos.Location = New System.Drawing.Point(172, 197)
        Me.TxtAbonos.Name = "TxtAbonos"
        Me.TxtAbonos.Size = New System.Drawing.Size(121, 22)
        Me.TxtAbonos.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Abonos de Creditos"
        '
        'TxtAntic
        '
        Me.TxtAntic.Enabled = False
        Me.TxtAntic.Location = New System.Drawing.Point(172, 143)
        Me.TxtAntic.Name = "TxtAntic"
        Me.TxtAntic.Size = New System.Drawing.Size(121, 22)
        Me.TxtAntic.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Anticipos"
        '
        'TxtCont
        '
        Me.TxtCont.Enabled = False
        Me.TxtCont.Location = New System.Drawing.Point(172, 91)
        Me.TxtCont.Name = "TxtCont"
        Me.TxtCont.Size = New System.Drawing.Size(121, 22)
        Me.TxtCont.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ventas al Contado"
        '
        'GbxEgresos
        '
        Me.GbxEgresos.Controls.Add(Me.TxtGastos)
        Me.GbxEgresos.Controls.Add(Me.Label6)
        Me.GbxEgresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxEgresos.ForeColor = System.Drawing.Color.White
        Me.GbxEgresos.Location = New System.Drawing.Point(351, 48)
        Me.GbxEgresos.Name = "GbxEgresos"
        Me.GbxEgresos.Size = New System.Drawing.Size(321, 79)
        Me.GbxEgresos.TabIndex = 2
        Me.GbxEgresos.TabStop = False
        Me.GbxEgresos.Text = "Egresos"
        '
        'TxtGastos
        '
        Me.TxtGastos.Enabled = False
        Me.TxtGastos.Location = New System.Drawing.Point(173, 36)
        Me.TxtGastos.Name = "TxtGastos"
        Me.TxtGastos.Size = New System.Drawing.Size(121, 22)
        Me.TxtGastos.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Gastos"
        '
        'BtnIniciar
        '
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.White
        Me.BtnIniciar.Location = New System.Drawing.Point(58, 373)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(112, 48)
        Me.BtnIniciar.TabIndex = 3
        Me.BtnIniciar.Text = "Inicializar caja"
        Me.BtnIniciar.UseVisualStyleBackColor = True
        '
        'BtnAbrir
        '
        Me.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbrir.ForeColor = System.Drawing.Color.White
        Me.BtnAbrir.Location = New System.Drawing.Point(216, 373)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(107, 48)
        Me.BtnAbrir.TabIndex = 4
        Me.BtnAbrir.Text = "Abrir Caja"
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(373, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Total de caja"
        '
        'TxtTotalCaja
        '
        Me.TxtTotalCaja.Enabled = False
        Me.TxtTotalCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalCaja.ForeColor = System.Drawing.Color.Black
        Me.TxtTotalCaja.Location = New System.Drawing.Point(509, 181)
        Me.TxtTotalCaja.Name = "TxtTotalCaja"
        Me.TxtTotalCaja.Size = New System.Drawing.Size(147, 22)
        Me.TxtTotalCaja.TabIndex = 6
        '
        'BtnCorte
        '
        Me.BtnCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCorte.ForeColor = System.Drawing.Color.White
        Me.BtnCorte.Location = New System.Drawing.Point(366, 373)
        Me.BtnCorte.Name = "BtnCorte"
        Me.BtnCorte.Size = New System.Drawing.Size(107, 48)
        Me.BtnCorte.TabIndex = 7
        Me.BtnCorte.Text = "Corte Diario"
        Me.BtnCorte.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(524, 373)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(107, 48)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Enabled = False
        Me.TxtSaldo.Location = New System.Drawing.Point(172, 36)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(121, 22)
        Me.TxtSaldo.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Saldo Anterior"
        '
        'CorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(684, 475)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCorte)
        Me.Controls.Add(Me.TxtTotalCaja)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnAbrir)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.GbxEgresos)
        Me.Controls.Add(Me.GbxIngresos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CorteCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CorteCaja"
        Me.GbxIngresos.ResumeLayout(False)
        Me.GbxIngresos.PerformLayout()
        Me.GbxEgresos.ResumeLayout(False)
        Me.GbxEgresos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GbxIngresos As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtAbonos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAntic As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCont As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GbxEgresos As GroupBox
    Friend WithEvents TxtGastos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalCaja As TextBox
    Friend WithEvents BtnCorte As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents Label8 As Label
End Class
