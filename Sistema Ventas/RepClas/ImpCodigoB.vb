Imports Microsoft.Reporting.WinForms
Public Class ImpCodigoB
    Public encabezado As New List(Of EncProd)()
    Public code As New List(Of EtiquetaClase)()
    Private Sub ImpCodigoB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Rpv1.LocalReport.DataSources.Clear()
        Rpv1.LocalReport.EnableExternalImages = True
        Rpv1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        Rpv1.LocalReport.DataSources.Add(New ReportDataSource("DetEtiqueta", code))
        Rpv1.SetDisplayMode(DisplayMode.PrintLayout)
        Rpv1.ZoomMode = ZoomMode.Percent
        Rpv1.ZoomPercent = 100
        Me.Rpv1.RefreshReport()
    End Sub
End Class