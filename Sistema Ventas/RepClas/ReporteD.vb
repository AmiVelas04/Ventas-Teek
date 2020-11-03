Imports Microsoft.Reporting.WinForms
Imports System.Diagnostics

Public Class ReporteD
    Public encabezado As New List(Of EncRep)()
    Public Detalle As New List(Of DetRep)()
    Private Sub ReporteD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        ReportViewer1.RefreshReport()

    End Sub
End Class