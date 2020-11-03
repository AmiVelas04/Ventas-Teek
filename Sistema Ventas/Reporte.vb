
Public Class Reporte
    Dim rep As New Report

    Dim tipo As String = "Contado"



    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboPeriodo.Items.Clear()
        CboAnio.Items.Clear()
        CboMes.Items.Clear()
        CboDia.Items.Clear()
        CboPeriodo.Items.Add("Diario")
        CboPeriodo.Items.Add("Mensual")
        CboPeriodo.Items.Add("Anual")
        llenaranio()
        llenarmes()
        llenardia()
    End Sub
    Private Sub llenardia()

        Dim i As Integer
        For i = 1 To 31
            CboDia.Items.Add(i)
        Next

    End Sub
    Private Sub llenarmes()

        Dim mes() As String
        Dim i As Integer
        mes = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        For i = 0 To 11
            CboMes.Items.Add(mes(i))
        Next
    End Sub
    Private Sub llenaranio()

        Dim i As Integer
        For i = 2000 To 2025
            CboAnio.Items.Add(i)
        Next

    End Sub

    Private Sub CboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPeriodo.SelectedIndexChanged
        If CboPeriodo.Text = "Diario" Then
            CboDia.Enabled = True
            CboMes.Enabled = True
            CboAnio.Enabled = True
        ElseIf CboPeriodo.Text = "Mensual" Then
            CboDia.Enabled = False
            CboMes.Enabled = True
            CboAnio.Enabled = True
        ElseIf CboPeriodo.Text = "Anual" Then
            CboDia.Enabled = False
            CboMes.Enabled = False
            CboAnio.Enabled = True
        End If
    End Sub

    Private Sub BtnMos_Click(sender As Object, e As EventArgs) Handles BtnMos.Click
        Dim valortotal As Decimal
        Do While DGV1.Rows.Count >= 1
            DGV1.Rows.RemoveAt(0)
        Loop
        Do While DGV1.Columns.Count >= 1
            DGV1.Columns.RemoveAt(0)
        Loop

        Dim fecha As String
        Dim dia As Integer
        Dim anio As Integer
        Dim mes As Integer
        Dim datos As New DataTable
        If CboDia.Text <> "" Then
            dia = CboDia.Text
        End If
        If CboAnio.Text <> "" Then
            anio = CboAnio.Text
        End If
        If CboMes.Text <> "" Then
            mes = obtenermes(CboMes.Text)
        End If
        If CboPeriodo.Text = "Diario" Then
            valortotal = 0
            fecha = anio & "/" & mes & "/" & dia
            datos = rep.reporteDiario(fecha, tipo)

            If datos.Rows.Count >= 1 Then
                DGV1.Columns.Add("No", "No")
                DGV1.Columns.Add("Doc", "Doc")
                DGV1.Columns.Add("Total", "Total")
                DGV1.Columns.Add("Vendedor", "Vendedor")
                DGV1.Columns.Add("Tipo", "Tipo")
                Dim i As Integer
                Dim total As Integer
                total = datos.Rows.Count

                For i = 0 To total - 1
                    DGV1.Rows.Add(i + 1, datos.Rows(i)(0), datos.Rows(i)(1), datos.Rows(i)(2), datos.Rows(i)(3))
                    valortotal += datos.Rows(i)(1)
                Next
                LblTotal.Text = "Q." & valortotal
            Else
                MessageBox.Show("No existen registros")
            End If
        ElseIf CboPeriodo.Text = "Mensual" Then
            valortotal = 0
            Dim fecha1 As String = anio & "/" & mes & "/01"
            Dim fecha2 As String = anio & "/" & mes & "/31"
            datos = rep.reporteMensual(fecha1, fecha2, tipo)

            If datos.Rows.Count >= 1 Then

                DGV1.Columns.Add("No", "No")
                DGV1.Columns.Add("Doc", "Doc")
                DGV1.Columns.Add("Total", "Total")
                DGV1.Columns.Add("Vendedor", "Vendedor")
                DGV1.Columns.Add("Tipo", "Tipo")
                DGV1.Columns.Add("Fecha", "Fecha")
                Dim i As Integer
                Dim total As Integer
                total = datos.Rows.Count
                For i = 0 To total - 1
                    Dim fech As Date = datos.Rows(i)(4)
                    DGV1.Rows.Add(i + 1, datos.Rows(i)(0), datos.Rows(i)(1), datos.Rows(i)(2), datos.Rows(i)(3), fech.ToString("dd/MM/yyyy"))
                    valortotal += datos.Rows(i)(1)

                Next
                LblTotal.Text = "Q." & valortotal
            Else
                MessageBox.Show("No existen registros")
            End If
        ElseIf CboPeriodo.Text = "Anual" Then
            valortotal = 0
            Dim fecha1 As String = anio & "/" & "01/01"
            Dim fecha2 As String = anio & "/" & "12/31"
            datos = rep.reporteAnual(fecha1, fecha2, tipo)

            If datos.Rows.Count >= 1 Then

                DGV1.Columns.Add("No", "No")
                DGV1.Columns.Add("Doc", "Doc")
                DGV1.Columns.Add("Total", "Total")
                DGV1.Columns.Add("Vendedor", "Vendedor")
                DGV1.Columns.Add("Tipo", "Tipo")
                DGV1.Columns.Add("Fecha", "Fecha")
                Dim i As Integer
                Dim total As Integer
                total = datos.Rows.Count
                For i = 0 To total - 1
                    Dim fech As Date = datos.Rows(i)(4)
                    DGV1.Rows.Add(i + 1, datos.Rows(i)(0), datos.Rows(i)(1), datos.Rows(i)(2), datos.Rows(i)(3), fech.ToString("dd/MM/yyyy"))
                    valortotal += datos.Rows(i)(1)
                Next
                LblTotal.Text = "Q." & valortotal
            Else
                MessageBox.Show("No existen registros")
            End If
        End If

    End Sub

    Private Function obtenermes(ByVal MesT As String) As Integer
        Dim mes As Integer
        Select Case MesT
            Case "Enero"
                mes = 1
            Case "Febrero"
                mes = 2
            Case "Marzo"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Mayo"
                mes = 5
            Case "Junio"
                mes = 6
            Case "Julio"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Septiembre"
                mes = 9
            Case "Octubre"
                mes = 10
            Case "Noviembre"
                mes = 11
            Case "Diciembre"
                mes = 12

        End Select

        Return mes
    End Function

    Private Sub RdbContado_CheckedChanged(sender As Object, e As EventArgs) Handles RdbContado.CheckedChanged
        tipo = "Contado"
    End Sub

    Private Sub RdbCredito_CheckedChanged(sender As Object, e As EventArgs) Handles RdbCredito.CheckedChanged
        tipo = "Credito"
    End Sub
End Class