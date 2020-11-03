Imports MySql.Data.MySqlClient
Public Class Bitacora
    Dim servidor As String = "localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-2020-Sis"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
    Private Sub buscar(ByRef tabla As DataTable, ByVal consulta As String)
        Try
            Dim adap As New MySqlDataAdapter(consulta, conn)
            tabla.Dispose()
            adap.Fill(tabla)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try

    End Sub
    Public Sub bitacora(ByVal usu As String, ByVal accion As String)
        Dim consulta As String
        consulta = "Select * from bitacora"
        Dim datos As New DataTable
        buscar(datos, consulta)
        Dim codbit As Integer
        If datos.Rows.Count >= 1 Then
            codbit = datos.Rows.Count + 1
        Else
            codbit = 1
        End If
        Dim insertbita As String
        insertbita = "insert into bitacora(id,cod_usu,fecha,hora,accion) values(" & codbit & ",'" & cod & "','" & diaactual() & "','" & horactual() & "','" & accion & "')"
        If ingresartbita(insertbita) Then
            ' MessageBox.Show("Ingreso en bitacora correcto")

        Else
            MessageBox.Show("Error en registro de actividad!")

        End If


    End Sub

    Private Function ingresartbita(ByVal consulta As String) As Boolean
        Dim com As New MySqlCommand
        com.Connection = conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try
            conn.Open()
            com.ExecuteNonQuery()
            conn.Close()

            Return True
        Catch ex As Exception
            conn.Close()
            MessageBox.Show(ex.ToString)

            Return False
        End Try
    End Function





End Class
