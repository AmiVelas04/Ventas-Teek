<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpCodigoB
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Rpv1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EtiquetaClaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncProdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.EtiquetaClaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncProdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rpv1
        '
        Me.Rpv1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DetEtiqueta"
        ReportDataSource1.Value = Me.EtiquetaClaseBindingSource
        ReportDataSource2.Name = "Encabezado"
        ReportDataSource2.Value = Me.EncProdBindingSource
        Me.Rpv1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Rpv1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.Rpv1.LocalReport.ReportEmbeddedResource = "Sistema_Ventas.ImpCodigoB.rdlc"
        Me.Rpv1.Location = New System.Drawing.Point(0, 0)
        Me.Rpv1.Name = "Rpv1"
        Me.Rpv1.Size = New System.Drawing.Size(830, 343)
        Me.Rpv1.TabIndex = 0
        '
        'EtiquetaClaseBindingSource
        '
        Me.EtiquetaClaseBindingSource.DataSource = GetType(Sistema_Ventas.EtiquetaClase)
        '
        'EncProdBindingSource
        '
        Me.EncProdBindingSource.DataSource = GetType(Sistema_Ventas.EncProd)
        '
        'ImpCodigoB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 343)
        Me.Controls.Add(Me.Rpv1)
        Me.Name = "ImpCodigoB"
        Me.Text = "ImpCodigoB"
        CType(Me.EtiquetaClaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncProdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rpv1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EtiquetaClaseBindingSource As BindingSource
    Friend WithEvents EncProdBindingSource As BindingSource
End Class
