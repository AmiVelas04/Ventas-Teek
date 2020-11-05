Imports MySql.Data.MySqlClient
Public Class Logueo
    Dim conec As New Conexion



    Private Function buscar(ByVal consulta As String) As DataTable

        conec.iniciar()
        Dim datos As New DataTable
        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            adap.Fill(datos)

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            MessageBox.Show(consulta)


        End Try
        Return datos

    End Function
    Private Function consulta_gen(ByVal consulta As String) As Boolean

        conec.iniciar()
        Dim com1 As New MySqlCommand()
        com1.Connection = conec.conn
        com1.CommandText = consulta
        com1.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com1.ExecuteNonQuery()
            conec.conn.Close()
            Return True
        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show(ex.ToString())
            MessageBox.Show(consulta)
            Return False

        End Try
    End Function

    Public Function credenciales(ByVal usu As String, ByVal pass As String) As Boolean
        Dim consulta As String
        consulta = "Select cod_usu,nombre,nivel from usuario where usuario='" & usu & "' and contrasena ='" & pass & "'"

        If buscar_usu(consulta) Then
            MessageBox.Show("Bienvenido: " & VariablesUNI.Nombre, "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            MessageBox.Show("Usuario o contraseña incorrecta, por favor intente de nuevo", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False

        End If
    End Function
    Private Sub logueo(ByVal datos As DataTable)
        VariablesUNI.cod = datos.Rows(0)(0)
        VariablesUNI.Nombre = datos.Rows(0)(1)
        VariablesUNI.nivel = datos.Rows(0)(2)

    End Sub
    Private Function buscar_usu(ByVal consul As String) As Boolean

        Dim datos As New DataTable
        datos.Dispose()
        datos = buscar(consul)


        If datos.Rows.Count >= 1 Then
                logueo(datos)
                'MessageBox.Show(datos.Rows.Count)
                Return True

            Else
            MessageBox.Show("No es posible conectarse al servidor de base de datos, comuniquese con su administrador")
            MessageBox.Show(datos.Rows.Count)
            Return False
            End If

    End Function
End Class
