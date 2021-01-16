Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Text
Public Class Ticket
    Public encabezado As New List(Of EncFact)()
    Public Detalle As New List(Of DetFact)()
    Dim m_currentPageIndex As Integer
    Dim m_streams As New List(Of Stream)
    Public total As Integer
    Dim tama As Integer
    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rp As New LocalReport()

        RpvTicket.LocalReport.DataSources.Clear()
        RpvTicket.LocalReport.DataSources.Add(New ReportDataSource("Encabezado", encabezado))
        RpvTicket.LocalReport.DataSources.Add(New ReportDataSource("Detalle", Detalle))
        RpvTicket.SetDisplayMode(DisplayMode.PrintLayout)
        RpvTicket.ZoomMode = ZoomMode.Percent
        Me.RpvTicket.RefreshReport()
        Dim ps As New PageSettings()
        tama = 300 * total / 10
        tama += 250
        tama = 354
        ps.PaperSize = New PaperSize("Custom", 312, tama)
        ps.PaperSize.Height = tama
        ps.Margins.Bottom = 0
        ps.Margins.Left = 0
        ps.Margins.Top = 0
        ps.Margins.Right = 0
        ps.PaperSize.RawKind = CInt(PaperKind.Custom)
        RpvTicket.SetPageSettings(ps)
        RpvTicket.RefreshReport()
        '        imprimir(RpvTicket.LocalReport)

    End Sub


    Private Sub imprimir(ByVal rep As LocalReport)

        exportar(rep)
        print()

    End Sub

    Private Sub exportar(ByVal rep As LocalReport)

        Dim deviceinfo As String = "" &
              "<DeviceInfo>" &
              " <OutputFormat>EMF</OutputFormat>" &
              " <PageWidth>" & 3.12 & "in</PageWidth>" &
              " <PageHeight>" & 3.24 & "in</PageHeight>" &
              " <MarginTop>0.01in</MarginTop>" &
              " <MarginLeft>0.01in</MarginLeft>" &
              " <MarginRight>0.1in</MarginRight>" &
              " <MarginBottom>0.1in</MarginBottom>" &
              "</DeviceInfo>"
        Dim Warnings As Warning()
        Dim m_streams As New List(Of Stream)()
        ' rep.Render("Image", deviceinfo, CreateStream, Warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next


    End Sub
    Private Function CreateStream(ByVal name As String, ByVal FileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream

        Dim Stream As New MemoryStream()
        m_streams.Add(Stream)
        Return Stream

    End Function
    Private Sub print()

        Dim printdoc As PrintDocument
        Dim printname As String = ImpresoraPred()
        If (m_streams Is Nothing Or m_streams.Count = 0) Then
            Throw New Exception("Error: no hay datos que imprimir")
        End If
        printdoc = New PrintDocument()
            printdoc.PrinterSettings.PrinterName = printname

        If (Not printdoc.PrinterSettings.IsValid) Then
            Throw New Exception(String.Format("No se puede encontrar la impresora", printname))
        Else

            'printdoc.PrintPage += New PrintPageEventHandler(printpage);
            m_currentPageIndex = 0

            printdoc.Print()

        End If
        End Sub
    Private Sub printpage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)

        Dim PageImage As New Metafile(m_streams(m_currentPageIndex))
        Dim adjustRectangle As New Rectangle(
                ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                312,
                tama)
        ev.Graphics.FillRectangle(Brushes.White, adjustRectangle)
        ev.Graphics.DrawImage(PageImage, adjustRectangle)
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)


    End Sub
    Private Function ImpresoraPred() As String

        For i As Integer = 0 To (PrinterSettings.InstalledPrinters.Count - 1)

            Dim a As New PrinterSettings()
            a.PrinterName = PrinterSettings.InstalledPrinters(i).ToString
            If (a.IsDefaultPrinter) Then
                Return PrinterSettings.InstalledPrinters(i).ToString
            End If
        Next
        Return ""

        End Function
    Public Sub Disposes()

        If (Not m_streams Is Nothing) Then

            For Each stream As Stream In m_streams
                stream.Close()
                m_streams = Nothing
            Next
        End If

    End Sub
End Class