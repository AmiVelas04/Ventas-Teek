Imports Microsoft.Reporting.WinForms
Imports System.Diagnostics
Imports System.IO

Public Class Factura
    Public encabezado As New List(Of EncFact)()
    Public Detalle As New List(Of DetFact)()
    Public factura As Integer
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        ReportViewer1.RefreshReport()
        'creacion de al factura en pdf
        Dim contenido As Byte() = ReportViewer1.LocalReport.Render("Pdf")
        Dim path As String = "./facturas/factura" & factura & ".pdf"
        Dim rutaA As String = Application.StartupPath & "\facturas"
        If Directory.Exists(rutaA) Then

        Else
            My.Computer.FileSystem.CreateDirectory(rutaA)
            MessageBox.Show("Se crea directorios")
        End If
        Dim pdfarch As New System.IO.FileStream(path, System.IO.FileMode.Create)
        pdfarch.Write(contenido, 0, contenido.Length)
        pdfarch.Close()
        'impresion de la factura desde el pdf
        Dim ruta As String
        ruta = Application.StartupPath
        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        psi.UseShellExecute = True
        psi.Verb = "print"
        psi.FileName = ruta & "\facturas\factura" & factura & ".pdf"
        psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal

        psi.ErrorDialog = True
        psi.Arguments = "/p"

        Dim p As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        p.WaitForInputIdle()

        Me.Dispose()
    End Sub
End Class