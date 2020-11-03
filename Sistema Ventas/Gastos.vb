Imports MySql.Data.MySqlClient
Public Class Gastos
    Dim servidor As String = "192.168.1.103"
    Dim bd As String = "prod"
    Dim user As String = "prueba"
    Dim pass As String = "1532"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim doc As Integer
        Dim monto As Decimal
        Dim concepto As String
        If IsNumeric(TxtDoc.Text) Then
            doc = TxtDoc.Text
        Else
            MessageBox.Show("Ingrese un valor valido")
            TxtDoc.Clear()

        End If
        If IsNumeric(TxtMonto.Text) Then
            monto = TxtMonto.Text
        Else
            MessageBox.Show("Ingrese un valor valido")
            TxtMonto.Clear()

        End If



        concepto = TxtDesc.Text
        Dim id As Integer = buscarid()
        Dim consulta As String
        consulta = "Insert into gasto(id_gasto,fecha,hora,cod_usu,monto,concepto) values(" & id & ",'" & diaactual() & "','" & horactual() & "'," & cod & "," & monto & ",'" & concepto & "')"
        Dim com As New MySqlCommand
        com.Connection = conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try

            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Gasto ingresado correctamenteo")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        limpiar()

    End Sub

    Private Function buscarid() As Integer
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "Select * from gasto"
        Dim total As Integer

        Try
            Dim adap As New MySqlDataAdapter(consulta, conn)
            adap.Fill(datos)
            If datos.Rows.Count >= 1 Then
                total = datos.Rows.Count + 1
            Else
                total = 1
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        Return total



    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()

    End Sub
    Private Sub limpiar()
        TxtDesc.Clear()
        TxtDoc.Clear()
        TxtMonto.Clear()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class