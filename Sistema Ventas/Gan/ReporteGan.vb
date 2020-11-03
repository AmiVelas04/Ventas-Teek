Imports Microsoft.Reporting.WinForms
Public Class ReporteGan
    Public encabezado As New List(Of EncGan)()
    Public Detalle As New List(Of DetGan)()
    Private Sub ReporteGan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class