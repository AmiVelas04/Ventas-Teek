Imports MySql.Data.MySqlClient
Public Class Usuario

    Dim cone As New Conexion
    Protected Sub buscar(ByVal consulta As String, ByRef tabla As DataTable)
        cone.iniciar()
        Try
            Dim adap As New MySqlDataAdapter(consulta, cone.conn)
            tabla.Dispose()
            adap.Fill(tabla)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try

    End Sub

    Public Function buscarusu(ByVal nom As String)
        Dim consulta As String
        Dim datos As New DataTable
        datos.Dispose()
        consulta = "Select * from usuario where cod_usu!=1 and nombre like '%" & nom & "%'"
        buscar(consulta, datos)
        Return datos
    End Function

    'busca el Usuario por medio del nombre de persona o de usuario
    Public Function buscarpt(ByVal nom As String)
        Dim usu As New DataTable
        Dim consulta As String
        consulta = "select * from usuario where nombre like '%" & nom & "%'"

        buscar(consulta, usu)
        Return usu
    End Function
    'busca y determina si existe o no el  susrio////  revisar utilidad antes de compilar
    Friend Function existeUsu(ByVal cod As String) As Boolean
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select * from usuario where cod_usu=" & cod
        cone.iniciar()
        Dim adap As New MySqlDataAdapter(consulta, cone.conn)
        adap.Fill(datos)
        If datos.Rows.Count >= 1 Then
            Return True
        Else

            Return False

        End If
    End Function

    ''Actualiza los datos del usuario
    Friend Sub Updusu(ByVal datos() As String)
        'revisar el ingreso de la imagen
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "update usuario set nombre='" & datos(1) & "', usuario='" & datos(2) & "', contrasena='" & datos(3) & "', nivel=" & datos(4) & " where cod_usu=" & datos(0)
        cone.iniciar()
        comando.Connection = cone.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            cone.conn.Open()
            comando.ExecuteNonQuery()
            cone.conn.Close()
            MessageBox.Show("Datos de usuario actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Se actualizaron datos del usuario: " & datos(0) & ", con codigo: " & datos(0)
            MessageBox.Show(accion)
            bita.bitacora(Nombre, accion)

        Catch ex As Exception
            cone.conn.Close()
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Error al actualizar datos de Usuario: " & datos(1) & "con codigo: " & datos(0) & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)


        End Try
    End Sub
    'Agregar nuevo usuario
    Friend Sub Addusu(ByVal datos() As String)
        'revisar el ingreso de la imagen
        Dim consulta As String
        Dim comando As New MySqlCommand
        Dim codigocon As String
        codigocon = "select cod_usu from usuario"
        Dim cod As New DataTable
        Dim codigo As Integer
        buscar(codigocon, cod)
        Dim total As Integer
        total = cod.Rows.Count
        codigo = total + 1
        cone.iniciar()
        consulta = "insert into usuario (cod_usu, nombre, usuario, contrasena,nivel) values (" & codigo & ",'" & datos(1) & "','" & datos(2) & "','" & datos(3) & "'," & datos(4) & ")"
        comando.Connection = cone.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            cone.conn.Open()
            comando.ExecuteNonQuery()
            cone.conn.Close()
            MessageBox.Show("Datos almacenados de usuario correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Se añadio un nuevo usuario: " & datos(0) & "con codigo: " & datos(5) & Chr(13)
            bita.bitacora(Nombre, accion)
        Catch ex As Exception
            cone.conn.Close()
            MessageBox.Show(ex.ToString)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Error al añadir nuevo usuario : " & datos(1) & "con codigo: " & datos(0) & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)

        End Try



    End Sub
    'Elimina el usuario seleccionado
    Friend Sub borrarusu(ByVal cod As String)
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "delete from usuario where cod_usu=" & cod
        cone.iniciar()
        comando.Connection = cone.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            cone.conn.Open()
            comando.ExecuteNonQuery()
            cone.conn.Close()
            MessageBox.Show("Datos eliminados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Se elimino usuario con codigo: " & cod & Chr(13)
            bita.bitacora(Nombre, accion)
        Catch ex As Exception
            cone.conn.Close()
            MessageBox.Show(ex.ToString)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Error al borrar ususario: con codigo: " & cod & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)

        End Try
    End Sub
End Class
