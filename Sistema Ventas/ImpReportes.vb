Public Class ImpReportes
    Dim rep As New LLenRep
    Private Sub ImpReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        CboPeriodo.Items.Add("Diario")
        CboPeriodo.Items.Add("Mensual")
        CboPeriodo.Items.Add("Anual")
        CboCompro.Items.Add("Contado")
        CboCompro.Items.Add("Credito")
        CboCompro.Items.Add("Todo")
        CboCompro.SelectedIndex = 0

        CboPeriodo.SelectedIndex = 0

    End Sub
    Private Sub llenardia()

        Dim i As Integer
        For i = 1 To 31
            CboDia.Items.Add(i)
        Next
        CboDia.SelectedIndex = 0
    End Sub
    Private Sub llenarmes()
        Dim mes() As String
        Dim i As Integer
        mes = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        For i = 0 To 11
            CboMes.Items.Add(mes(i))
            CboGMes.Items.Add(mes(i))
        Next
        CboMes.SelectedIndex = 0
        CboGMes.SelectedIndex = 0
    End Sub
    Private Sub llenaranio()
        Dim i As Integer
        For i = 2019 To 2030
            CboAnio.Items.Add(i)
            CboGAnio.Items.Add(i)
        Next
        CboAnio.SelectedIndex = 0
        CboGAnio.SelectedIndex = 0
    End Sub

    Private Sub limpiar()
        CboAnio.Items.Clear()
        CboDia.Items.Clear()
        CboGAnio.Items.Clear()
        CboGMes.Items.Clear()
        CboMes.Items.Clear()

    End Sub

    Private Sub CboPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPeriodo.SelectedIndexChanged
        If CboPeriodo.Text = "Diario" Then
            CboDia.Enabled = True
            CboMes.Enabled = True
            CboAnio.Enabled = True
            limpiar()
            llenaranio()
            llenardia()
            llenarmes()


        ElseIf CboPeriodo.Text = "Mensual" Then
            CboDia.Enabled = False
            CboMes.Enabled = True
            CboAnio.Enabled = True
            limpiar()
            llenarmes()
            llenaranio()

        ElseIf CboPeriodo.Text = "Anual" Then
            CboDia.Enabled = False
            CboMes.Enabled = False
            CboAnio.Enabled = True
            limpiar()
            llenaranio()
        End If
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Dim fecha As String
        Dim dia As Integer
        Dim anio As Integer = CboAnio.Text
        Dim mes As Integer
        If CboDia.Text <> "" Then
            dia = CboDia.Text
        Else
            dia = 01
        End If


        Select Case CboMes.Text
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
            Case Else
                mes = 1
        End Select



        Dim tipo As String
        tipo = CboCompro.Text
        Dim datos As New DataTable

        If CboPeriodo.Text = "Diario" Then
            fecha = anio & "/" & mes & "/" & dia
            rep.reportediariov(fecha, tipo)

        ElseIf CboPeriodo.Text = "Mensual" Then
            Dim fecha1 As String = anio & "/" & mes & "/01"
            Dim fecha2 As String = anio & "/" & mes & "/31"
            rep.reportemensualV(fecha1, fecha2, tipo)


        ElseIf CboPeriodo.Text = "Anual" Then

            Dim fecha1 As String = anio & "/" & "01/01"
            Dim fecha2 As String = anio & "/" & "12/31"
            rep.reporteanualV(fecha1, fecha2, tipo)


        End If
    End Sub

    Private Sub BtnMProd_Click(sender As Object, e As EventArgs) Handles BtnMProd.Click
        rep.TodosProd()

    End Sub

    Private Sub BtnGan_Click(sender As Object, e As EventArgs) Handles BtnGan.Click
        Dim mes As Integer
        Dim anio As Integer = CboGAnio.Text
        Select Case CboGMes.Text
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
            Case Else
                mes = 1
        End Select
        Dim fechai As String = anio & "/" & mes & "/01"
        Dim fechaf As String = anio & "/" & mes & "/31"
        rep.ganacia(fechai, fechaf)
    End Sub
End Class
