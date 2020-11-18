

Imports MySql.Data.MySqlClient

Public Class principal
    Dim bita As New Bitacora
    Dim conec As New Conexion
    Dim caj As New CajaClase

    'busqueda general
    Protected Sub buscar(ByVal consulta As String, ByRef tabla As DataTable)
        conec.iniciar()
        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)

            tabla.Dispose()
            adap.Fill(tabla)
            adap.Dispose()
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            ' MessageBox.Show(consulta)
        End Try

    End Sub
    Protected Sub Consulgeneral(ByVal consulta As String)
        Dim com As New MySqlCommand
        com.Connection = conec.conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com.ExecuteNonQuery()
            conec.conn.Close()
        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show("Error de consulta general: " & Chr(13) & ex.ToString)
        End Try
    End Sub


#Region "Clientes"
    'busca el cliente y devuele los datos en un datatable
    Friend Function buscli(ByVal cod As String, ByVal nit As String, ByVal nomcli As String)

        If (existecli(nit)) Then
            Dim datos As New DataTable
            Dim consulta As String
            consulta = "Select cod_cli,nombre, direccion, credito, saldo from cliente where cod_cli='" & cod & "'"
            buscar(consulta, datos)
            If datos.Rows.Count >= 1 Then
                Return datos

            Else
                MessageBox.Show("No se encontró el cliente")
                Dim fila = datos.NewRow
                fila("cod_cli") = "0"
                fila("Nombre") = "N/E"
                fila("direccion") = "N/E"
                fila("Credito") = 0
                fila("Saldo") = 0

                datos.Rows.Add(fila)
                Return datos
            End If
        Else
            Dim datosing() As String = {nomcli, "", nit, "0", "0"}
            Dim codi As Integer = nuevocli(datosing)
            Dim datos2 As New DataTable
            Dim consulta1 = "Select cod_cli,nombre, direccion, credito, saldo from cliente where cod_cli='" & codi & "'"
            buscar(consulta1, datos2)
            If datos2.Rows.Count >= 1 Then
                Return datos2
            End If

        End If



    End Function
    'busca el cliente por medio del nombre
    Friend Function buscarcli2(ByVal nom As String)
        Dim prod As New DataTable
        Dim consulta As String
        consulta = "select cod_cli as Codigo,Nombre, Direccion, Nit, Credito, Saldo from cliente where nombre like '%" & nom & "%'"
        '  conn = New MySqlConnection(cadenaconn)
        buscar(consulta, prod)
        Return prod
    End Function

    'Determina si existe el cliente
    Friend Function existecli(ByVal nit As String) As Boolean
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select * from cliente where cod_cli='" & nit & "'"

        Dim adap As New MySqlDataAdapter(consulta, conec.conn)
        adap.Fill(datos)
        If datos.Rows.Count >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    'retorna el cod del cliente
    Friend Function codcli(ByVal nom As String) As String
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select cod_cli from cliente where Nombre='" & nom & "'"
        If datos.Rows.Count >= 1 Then
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            adap.Fill(datos)
            Dim codigo As String
            codigo = datos.Rows(0)(0).ToString
            Return codigo
        Else
            MessageBox.Show("No existe el cliente")
            MessageBox.Show(consulta)
            Exit Function
            Return 0
        End If

    End Function
    Friend Function conteocli() As Integer
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select * from cliente"

        Dim adap As New MySqlDataAdapter(consulta, conec.conn)
        adap.Fill(datos)
        Dim total As Integer
        total = datos.Rows.Count
        If datos.Rows.Count >= 1 Then
            Return total

        Else

            Return 0

        End If
    End Function
    'Agrega un nuevo cliente con los datos enviados desde el fortmulario
    Friend Sub addcli(ByVal datos())
        Dim consulta As String
        Dim comando As New MySqlCommand
        Dim codigo As Integer
        codigo = conteocli() + 1
        consulta = "insert into cliente (cod_cli, nombre, direccion, nit,credito,saldo) values ('" & codigo & "','" & datos(0) & "','" & datos(1) & "','" & datos(2) & "'," & datos(3) & "," & datos(4) & ")"
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos almacenados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim bita As New Bitacora
            Dim accion As String
            accion = "Ingreso un nuevo cliente de codigo " & codigo
            bita.bitacora(Nombre, accion)

        Catch ex As Exception
            conec.conn.Close()

            MessageBox.Show("No se pudo ingresar el cliente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim accion As String
            accion = "Error al ingresar al cliente de nombre: " & datos(0) & " y codigo: " & codigo & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)

        End Try
    End Sub
    'Borra el cliente 
    Friend Sub borrarc(ByVal nit As String)
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "delete from cliente where cod_cli='" & nit & "'"
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos eliminados correctamente", "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Dim accion As String
            accion = "Se elimino cliente con Nit : " & nit
            bita.bitacora(Nombre, accion)

        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show("No se pudo Eliminar el cliente, consulte con su administrador", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim accion As String
            accion = "Error al borrar cliente de Nit codigo: " & nit & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)

        End Try
    End Sub
    'Actualiza los datos del cliente
    Friend Sub updcli(ByVal datos() As String)


        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "update cliente set nombre='" & datos(0) & "',direccion='" & datos(1) & "', nit='" & datos(2) & "', credito=" & datos(3) & ",saldo=" & datos(4) & " where cod_cli='" & datos(5) & "'"
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Dim accion As String
            accion = "Se actualizaron los datos del cliente: " & datos(0) & "con codigo: " & datos(5) & Chr(13) & "Con los siguientes vaores, Direccion: " & datos(1) & Chr(13) & "Credito: " & datos(3) & Chr(13) & "saldo: " & datos(4)
            bita.bitacora(Nombre, accion)
        Catch ex As Exception
            conec.conn.Close()

            MessageBox.Show("No se pudo actualizar el cliente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim accion As String
            accion = "Error al actualizar datos de cliente: " & datos(0) & "con codigo: " & datos(5) & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)


        End Try
    End Sub

    Private Function nuevocli(ByVal datos() As String) As Integer
        Dim consulta As String
        Dim codigo As Integer
        codigo = conteocli() + 1
        consulta = "insert into cliente (cod_cli, nombre, direccion, nit,credito,saldo) values ('" & codigo & "','" & datos(0) & "','" & datos(1) & "','" & datos(2) & "'," & datos(3) & "," & datos(4) & ")"
        Consulgeneral(consulta)
        Return codigo

    End Function

#End Region


#Region "Productos"
    Public Function buscap(ByVal codigo As String)
        Dim prod As New DataTable
        Dim consulta As String
        consulta = "select codigo_p,nombre,descripcion,marca,preciov,cantidad,imagen from producto where codigo_p='" & codigo & "'"
        buscar(consulta, prod)
        Return prod
    End Function
    Public Function costo(ByVal cod As String) As Decimal
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "Select precioc from producto where codigo_p='" & cod & "'"

        buscar(consulta, datos)
        If datos.Rows(0)(0) <= 0 Then
            Return 0
        Else
            Return datos.Rows(0)(0)
        End If

    End Function

    'busca el producto por medio del nombre
    Public Function buscarpt(ByVal nom As String)
        Dim prod As New DataTable
        Dim consulta As String
        consulta = "select Codigo_p as Codigo,Nombre,Descripcion,Marca,Cantidad,Precioc as Costo, Preciov as Venta, Ganacia,Imagen from producto where nombre like '%" & nom & "%'"
        ' conn = New MySqlConnection(cadenaconn)
        buscar(consulta, prod)
        Return prod
    End Function
    'busca y determina si existe o no el producto
    Friend Function existep(ByVal cod As String) As Boolean
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select * from producto where codigo_p='" & cod & "'"
        buscar(consulta, datos)


        If datos.Rows.Count >= 1 Then
            Return True

        Else

            Return False

        End If
    End Function

    Friend Sub Updprod(ByVal datos() As String)
        'revisar el ingreso de la imagen
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "update producto set nombre='" & datos(1) & "',descripcion='" & datos(2) & "',marca='" & datos(3) & "', cantidad=" & datos(4) & ",precioc=" & datos(5) & ",preciov=" & datos(6) & ",ganacia=" & datos(7) & ",imagen='" & datos(8) & "' where codigo_p='" & datos(0) & "'"

        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos actualizados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show(ex.ToString)
            '  MessageBox.Show(consulta)


        End Try
    End Sub
    'Agregar nuevo producto
    Friend Sub Addprod(ByVal datos() As String)
        'revisar el ingreso de la imagen
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "insert into producto (codigo_p, nombre, descripcion, marca,cantidad,precioc,preciov,ganacia,imagen) values ('" & datos(0) & "','" & datos(1) & "','" & datos(2) & "','" & datos(3) & "'," & datos(4) & "," & datos(5) & "," & datos(6) & "," & datos(7) & ",'" & datos(8) & "')"
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos almacenados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim accion As String
            accion = "Nuevo usuario registrado: " & Chr(13) & " de nombre: " & datos(1)
            bita.bitacora(Nombre, accion)
        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show("No se pudo agregar el Producto", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim accion As String
            accion = "No se guardo producto: " & Chr(13) & " de nombre: " & datos(1) & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)
        End Try



    End Sub
    'Elimina el producto selecionado
    Friend Sub borrarp(ByVal cod As String)
        Dim consulta As String
        Dim comando As New MySqlCommand
        consulta = "delete from producto where codigo_p='" & cod & "'"
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            MessageBox.Show("Datos eliminados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim accion As String
            accion = "producto eliminado correctamente" & Chr(13) & " de codigo: " & cod
            bita.bitacora(Nombre, accion)
        Catch ex As Exception
            conec.conn.Close()
            Dim accion As String
            accion = "producto no se elimino" & Chr(13) & " de codigo: " & cod & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)
            MessageBox.Show("No se ha podido eliminar el producto, consulte con su administrador", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
#End Region
#Region "Factura"
    'Genera la factura

    Friend Sub fact_gen(ByVal datos() As String, ByVal prod As DataTable, ByVal usuCod As Integer, ByVal usuNom As String, ByVal tipo As String, ByVal anti As Decimal, ByVal total As Decimal)
        Dim factu As New DataTable
        Dim numcompro As Integer
        Dim consulta As String
        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim datafact() As String

        consulta = "Select * from venta"
        buscar(consulta, factu)
        Dim comptotal As Integer = factu.Rows.Count
        If comptotal >= 1 Then
            numcompro = comptotal + 1
        Else
            numcompro = 1
        End If

        datafact = {numcompro, datos(1), datos(2), datos(5), fecha, datos(6)}
        Dim consultainscomp As String
        'Agregar el id del usuario a la consulta
        consultainscomp = "Insert into venta(comprobante, cod_usu, cod_cli, estado, fecha, tipo) values(" & numcompro & "," & usuCod & ",'" & datos(0) & "','activo','" & fecha & "','" & tipo & "')"
        If ingresoventa(consultainscomp) Then

            If ingresoventadet(numcompro, prod) Then
                llenarFactura(datafact, prod, usuNom, tipo)
                If tipo = "Credito" Then
                    'agregar el codigo del usuario
                    credito(numcompro, datos(0), VariablesUNI.cod, anti, total)
                End If
                MessageBox.Show("Venta realizada con exito", "Venta hecha", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                borrarventadet(numcompro)
                borrarventa(numcompro)
                MessageBox.Show("Error al registrar la venta")
            End If

        Else
            borrarventa(numcompro)

        End If



    End Sub

    'Registra una nueva venta
    Private Function ingresoventa(ByVal consulta As String) As Boolean
        Dim comando As New MySqlCommand
        comando.Connection = conec.conn
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            comando.ExecuteNonQuery()
            conec.conn.Close()
            '  MessageBox.Show("Venta general Hecha", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Return True
        Catch ex As Exception

            conec.conn.Close()
            MessageBox.Show(consulta)
            MessageBox.Show(ex.ToString)
            Dim accion As String
            accion = "Error al generar una venta general: " & Chr(13) & "Error: " & ex.ToString
            bita.bitacora(Nombre, accion)
            Return False
        End Try

    End Function
    'ingresa un nuevo detalle de venta
    Private Function ingresoventadet(ByVal codvent As Integer, ByVal prod As DataTable) As Boolean

        Dim comando As New MySqlCommand
        Dim consulta As String
        Dim cont As Integer
        Dim detalle As New DataTable
        Dim consdetalle As String
        consdetalle = "select * from ventadetalle"
        cont = prod.Rows.Count
        buscar(consdetalle, detalle)
        Dim codigo As Integer = detalle.Rows.Count + 1

        Dim i As Integer
        For i = 0 To cont - 1

            If restarP(prod.Rows(i)(0), prod.Rows(i)(5)) = True Then

            Else
                Return False
            End If
            consulta = "insert into ventadetalle(cod_detalle,codigo_p,comprobante,precio,cantidad) values(" & codigo & ",'" & prod.Rows(i)(0) & "'," & codvent & "," & prod.Rows(i)(4) & "," & prod.Rows(i)(5) & ")"

            codigo += 1

            comando.Connection = conec.conn
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            Try
                conec.conn.Open()
                comando.ExecuteNonQuery()
                conec.conn.Close()


            Catch ex As Exception
                conec.conn.Close()
                MessageBox.Show(consulta)
                MessageBox.Show(ex.ToString)

                Dim accion As String
                accion = "Error al generar un detalle de venta: " & Chr(13) & "Error: " & ex.ToString
                bita.bitacora(Nombre, accion)
                Return False
                Exit Function
            End Try
        Next
        Return True
    End Function
    'Restar productos al inventario
    Private Function restarP(ByVal codigo As String, ByVal cant As Integer) As Boolean
        Dim cant_ant As Integer
        Dim consulta As String
        Dim datos As New DataTable
        Dim cantactual As Integer
        consulta = "Select cantidad from producto where codigo_p='" & codigo & "'"
        buscar(consulta, datos)
        If datos.Rows.Count >= 1 Then
            cant_ant = datos.Rows(0)(0)
            cantactual = cant_ant - cant
            consulta = "update producto set cantidad=" & cantactual & " where codigo_p='" & codigo & "'"
            Consulgeneral(consulta)
            Return True
        Else
            Return False
        End If


    End Function

    'en caso de un error borra la venta que se registro
    Private Sub borrarventa(ByVal compro As Integer)
        Dim consulta As String
        consulta = "delete from venta where comprobante=" & compro
        Dim com As New MySqlCommand
        com.CommandText = consulta
        com.Connection = conec.conn
        com.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com.ExecuteNonQuery()
            conec.conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("Error de eliminacion de venta")

        End Try
    End Sub
    ' en caso de registrar un error borra el detalle de venta que se registro
    Private Sub borrarventadet(ByVal compro As Integer)
        Dim consulta As String
        consulta = "delete from ventadetalle where comprobante=" & compro
        Dim com As New MySqlCommand
        com.CommandText = consulta
        com.Connection = conec.conn
        com.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com.ExecuteNonQuery()
            conec.conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show("Error de eliminacion de ventadetalle")

        End Try
    End Sub
    Private Sub llenarFactura(ByVal datos() As String, ByVal prod As DataTable, ByVal usunom As String, ByVal tipo As String)
        Dim total As Integer = prod.Rows.Count
        Dim encabezado As New EncFact
        Dim gtotal As Decimal = 0
        encabezado.Numero = datos(0)
        encabezado.Nombre = datos(1)
        encabezado.Direccion = datos(2)
        encabezado.Nit = datos(3)
        encabezado.Vendedor = usunom
        encabezado.FechaFacturacion = datos(4)
        encabezado.Total = datos(5)
        encabezado.tipov = tipo
        Dim cont As Integer
        For cont = 0 To total - 1
            Dim producto As New DetFact()
            producto.Prod = prod.Rows(cont)(1).ToString
            producto.Descripcion = prod.Rows(cont)(2).ToString
            producto.Marca = prod.Rows(cont)(3).ToString
            producto.Precio = prod.Rows(cont)(4).ToString
            producto.Cantidad = prod.Rows(cont)(5).ToString
            Dim cant As Integer = Convert.ToInt32(prod.Rows(cont)(5).ToString)
            Dim valor As Decimal = Convert.ToDecimal(prod.Rows(cont)(4).ToString)
            Dim totalp As Integer = cant * valor
            producto.Total = totalp
            gtotal += totalp
            encabezado.Detalle.Add(producto)
        Next
        Dim ingreso() As String = {gtotal.ToString, "Venta No. " & datos(0), "Ingreso", "Activo", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), usunom}
        ingresocaja(ingreso)
        Dim fact As New Ticket
        fact.encabezado.Add(encabezado)
        fact.Detalle = encabezado.Detalle
        'fact.factura = datos(0)
        fact.Show()


    End Sub

    Private Sub ingresocaja(ByVal datos() As String)
        caj.ingresoope(datos)
    End Sub

#End Region

#Region "Credito"
    Private Sub credito(ByVal codigocomp As Integer, ByVal codigocli As Integer, ByVal codigoU As Integer, ByVal anticipo As Decimal, ByVal total As Decimal)
        Dim consulta As String
        Dim codcre As Integer
        Dim credi As New DataTable
        consulta = "Select * from credito"
        buscar(consulta, credi)
        Dim credtotal As Integer = credi.Rows.Count
        If credtotal >= 1 Then
            codcre = credtotal + 1
        Else
            codcre = 1
        End If

        consulta = "Insert into credito(cod_credi,Comprobante,cod_cli,cod_usu,total,anticipo,Estado) values(" & codcre & "," & codigocomp & ",'" & codigocli & "'," & codigoU & "," & total & "," & anticipo & ",'Activo')"
        Consulgeneral(consulta)

        Dim accion As String
        accion = "Se Generó un nuevo credito con codigo: " & codcre & Chr(13) & "anticipo: " & anticipo
        bita.bitacora(Nombre, accion)
        UpdSaldo(codigocli, total, anticipo)
    End Sub
    Private Sub UpdSaldo(ByVal codigo As Integer, ByVal Total As Decimal, ByVal Anticipo As Decimal)
        Dim saldo As Decimal
        Dim datos As New DataTable
        saldo = Total - Anticipo

        Dim consulta As String
        Dim consulsaldo As String

        consulsaldo = "Select saldo from cliente where cod_cli='" & codigo & "'"
        buscar(consulsaldo, datos)
        saldo = saldo + datos.Rows(0)(0)
        consulta = "Update cliente set Saldo=" & saldo & " where cod_cli=" & codigo
        'MessageBox.Show("Actualizacion Decimal saldo:" & consulta)
        Consulgeneral(consulta)
    End Sub


#End Region
End Class
