<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GeneradorCod
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
        Me.PanSup = New System.Windows.Forms.Panel()
        Me.PcbCod = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NudEtiqueta = New System.Windows.Forms.NumericUpDown()
        Me.TxtTexto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnImp = New System.Windows.Forms.Button()
        Me.BtnGen = New System.Windows.Forms.Button()
        Me.TxtCodBarras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkEditar = New System.Windows.Forms.CheckBox()
        Me.PanSup.SuspendLayout()
        CType(Me.PcbCod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudEtiqueta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanSup
        '
        Me.PanSup.Controls.Add(Me.ChkEditar)
        Me.PanSup.Controls.Add(Me.PcbCod)
        Me.PanSup.Controls.Add(Me.Label3)
        Me.PanSup.Controls.Add(Me.NudEtiqueta)
        Me.PanSup.Controls.Add(Me.TxtTexto)
        Me.PanSup.Controls.Add(Me.Label2)
        Me.PanSup.Controls.Add(Me.BtnImp)
        Me.PanSup.Controls.Add(Me.BtnGen)
        Me.PanSup.Controls.Add(Me.TxtCodBarras)
        Me.PanSup.Controls.Add(Me.Label1)
        Me.PanSup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanSup.Location = New System.Drawing.Point(0, 0)
        Me.PanSup.Margin = New System.Windows.Forms.Padding(5)
        Me.PanSup.Name = "PanSup"
        Me.PanSup.Size = New System.Drawing.Size(656, 237)
        Me.PanSup.TabIndex = 0
        '
        'PcbCod
        '
        Me.PcbCod.Location = New System.Drawing.Point(445, 180)
        Me.PcbCod.Name = "PcbCod"
        Me.PcbCod.Size = New System.Drawing.Size(77, 78)
        Me.PcbCod.TabIndex = 8
        Me.PcbCod.TabStop = False
        Me.PcbCod.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad de etiquetas"
        '
        'NudEtiqueta
        '
        Me.NudEtiqueta.Location = New System.Drawing.Point(118, 203)
        Me.NudEtiqueta.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NudEtiqueta.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudEtiqueta.Name = "NudEtiqueta"
        Me.NudEtiqueta.Size = New System.Drawing.Size(58, 26)
        Me.NudEtiqueta.TabIndex = 6
        Me.NudEtiqueta.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TxtTexto
        '
        Me.TxtTexto.Location = New System.Drawing.Point(43, 131)
        Me.TxtTexto.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtTexto.Name = "TxtTexto"
        Me.TxtTexto.Size = New System.Drawing.Size(271, 26)
        Me.TxtTexto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Texto"
        '
        'BtnImp
        '
        Me.BtnImp.Location = New System.Drawing.Point(445, 106)
        Me.BtnImp.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnImp.Name = "BtnImp"
        Me.BtnImp.Size = New System.Drawing.Size(172, 60)
        Me.BtnImp.TabIndex = 3
        Me.BtnImp.Text = "Imprimir Codigo"
        Me.BtnImp.UseVisualStyleBackColor = True
        '
        'BtnGen
        '
        Me.BtnGen.Location = New System.Drawing.Point(445, 32)
        Me.BtnGen.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnGen.Name = "BtnGen"
        Me.BtnGen.Size = New System.Drawing.Size(172, 62)
        Me.BtnGen.TabIndex = 2
        Me.BtnGen.Text = "Generar Codigo Nuevo"
        Me.BtnGen.UseVisualStyleBackColor = True
        '
        'TxtCodBarras
        '
        Me.TxtCodBarras.Enabled = False
        Me.TxtCodBarras.Location = New System.Drawing.Point(43, 60)
        Me.TxtCodBarras.Margin = New System.Windows.Forms.Padding(5)
        Me.TxtCodBarras.Name = "TxtCodBarras"
        Me.TxtCodBarras.Size = New System.Drawing.Size(271, 26)
        Me.TxtCodBarras.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Barras"
        '
        'ChkEditar
        '
        Me.ChkEditar.AutoSize = True
        Me.ChkEditar.Location = New System.Drawing.Point(322, 62)
        Me.ChkEditar.Name = "ChkEditar"
        Me.ChkEditar.Size = New System.Drawing.Size(76, 24)
        Me.ChkEditar.TabIndex = 9
        Me.ChkEditar.Text = "Editar"
        Me.ChkEditar.UseVisualStyleBackColor = True
        '
        'GeneradorCod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 237)
        Me.Controls.Add(Me.PanSup)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "GeneradorCod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar código"
        Me.PanSup.ResumeLayout(False)
        Me.PanSup.PerformLayout()
        CType(Me.PcbCod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudEtiqueta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanSup As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTexto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnImp As Button
    Friend WithEvents BtnGen As Button
    Friend WithEvents TxtCodBarras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NudEtiqueta As NumericUpDown
    Friend WithEvents PcbCod As PictureBox
    Friend WithEvents ChkEditar As CheckBox
End Class
