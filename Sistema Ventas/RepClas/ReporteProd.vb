Imports Microsoft.Reporting.WinForms
Public Class ReporteProd
    Public encabezado As New List(Of EncProd)()
    Public Detalle As New List(Of DetProd)()
    Private Sub ReporteProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class