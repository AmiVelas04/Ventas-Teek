Imports MySql.Data.MySqlClient
Public Class Logueo
    Dim servidor As String = "Localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-2020-Sis"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
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

        Try

            Dim adap As New MySqlDataAdapter(consul, conn)
            adap.Fill(datos)

            If datos.Rows.Count >= 1 Then
                logueo(datos)
                'MessageBox.Show(datos.Rows.Count)
                Return True

            Else
                MessageBox.Show(datos.Rows.Count)
                Return False
            End If

        Catch ex As MySqlException
            If Err.Number = 1042 Then
                MessageBox.Show("No es posible conectarse al servidor de base de datos, comuniquese con su administrador")
            End If
            MessageBox.Show(ex.ToString)
        End Try
    End Function
End Class
