Imports Microsoft.Reporting.WinForms

Imports System.IO
Public Class DocPAgo
    Public pago As New List(Of DatosAbono)()
    Public numpago As Integer


    Private Sub DocPAgo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Abono", pago))
        Me.ReportViewer1.RefreshReport()
        Dim rutaA As String = Application.StartupPath & "\pago"
        'creacion de al factura en pdf
        Dim contenido As Byte() = ReportViewer1.LocalReport.Render("Pdf")
        If Directory.Exists(rutaA) Then

        Else
            My.Computer.FileSystem.CreateDirectory(rutaA)
            MessageBox.Show("Se crea directorios")
        End If
        Dim path As String = rutaA & "/pago" & numpago & ".pdf"
        'Dim pdfarch As New System.IO.FileStream(path, System.IO.FileMode.Create)
        'pdfarch.Write(contenido, 0, contenido.Length)
        'pdfarch.Close()
        Dim fs As FileStream = File.Create(path)
        fs.Write(contenido, 0, contenido.Length)
        fs.Close()
        'impresion de la factura desde el pdf
        Dim ruta As String
        ruta = Application.StartupPath
        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        psi.UseShellExecute = True
        psi.Verb = "print"
        psi.FileName = ruta & "\pago\pago" & numpago & ".pdf"
        psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal

        psi.ErrorDialog = True
        psi.Arguments = "/p"

        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        p.WaitForInputIdle()

        Me.Dispose()
    End Sub
End Class