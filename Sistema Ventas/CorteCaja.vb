Imports MySql.Data.MySqlClient
Public Class CorteCaja

    Dim caj As New CajaClase
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub BtnCorte_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Private Sub CorteCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As String
        fecha = DateTime.Now.ToString("yyyy/MM/dd")
        totalcaja(fecha)
        CboOpe.SelectedIndex = 0

    End Sub


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If (TxtMonto.Text = "") Then
            MessageBox.Show("No se ha ingresado el monto de la operación")
        Else
            ingresoope()
            Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
            totalcaja(fecha)
            caj.sacarC()
        End If


    End Sub

    Private Sub ingresoope()
        Dim fecha As String = DtpFecha.Value.ToString("yyyy/MM/dd HH:mm:ss")
        Dim operacion As String = CboOpe.Text
        Dim monto As String = TxtMonto.Text
        Dim desc As String = TxtDesc.Text
        Dim usu As String = VariablesUNI.Nombre
        Dim datos() As String = {monto, desc, operacion, "Activo", fecha, usu}
        If caj.ingresoope(datos) Then
            MessageBox.Show("Ingreso de operación correctamente")
        Else
            MessageBox.Show("Error en el ingreso de operacion")
        End If

    End Sub

    Private Sub totalcaja(ByVal fecha As String)
        Dim ingreso As Decimal = caj.totalingre(fecha)
        Dim egreso As Decimal = caj.totalegre(fecha)
        Dim total As Decimal
        total = ingreso - egreso
        TxtIng.Text = ingreso
        TxtEgr.Text = egreso
        TxtTotal.Text = total

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        buscaope()
    End Sub
    Private Sub buscaope()
        Dim fecha As String = DtpFecha.Value.ToString("yyyy/MM/dd")
        Dim datos As New DataTable
        datos = caj.operaciones(fecha)
        DgvOpera.DataSource = datos
        totalcaja(fecha)

    End Sub

    Private Sub BtnSacarCaja_Click(sender As Object, e As EventArgs) Handles BtnSacarCaja.Click
        caj.sacarC()
    End Sub
End Class