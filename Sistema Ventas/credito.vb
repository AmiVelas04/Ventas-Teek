Imports MySql.Data.MySqlClient
Public Class credito

    Dim servidor As String = "localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-2020-Sis"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)

    Dim bita As New Bitacora
    Protected Sub buscar(ByVal consulta As String, ByRef tabla As DataTable)
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
    Private Function consulgeneral(consulta) As Boolean
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


    Public Function buscarclico(ByVal nom As String)
        Dim prod As New DataTable
        Dim consulta As String
        consulta = "select cod_cli as Codigo,nombre as Nombre,direccion AS Direccion,nit as NIT,saldo as Saldo from cliente where nombre like '%" & nom & "%'"
        conn = New MySqlConnection(cadenaconn)
        buscar(consulta, prod)
        Return prod
    End Function
    Public Function buscarcredi(ByVal codcli As Integer) As DataTable
        Dim consulta As String
        consulta = "Select c.Cod_credi as Codigo ,c.comprobante as Doc ,u.nombre as Vendedor,c.Anticipo,(SELECT sum(vd.precio*vd.cantidad) from ventadetalle vd where vd.comprobante=c.COMPROBANTE) as Total  from credito c
    inner join usuario u on c.cod_usu=u.Cod_usu where c.cod_cli='" & codcli & "'"
        Dim datos As New DataTable
        buscar(consulta, datos)
        Return datos
    End Function
    Public Function totalcredito(ByVal compro As Integer) As Decimal
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "select sum(precio*cantidad) from ventadetalle where COMPROBANTE =" & compro
        buscar(consulta, datos)
        Return datos.Rows(0)(0)
    End Function
    Public Function buscausu(ByVal cod As Integer) As String
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "select nombre from usuario where cod_usu=" & cod
        buscar(consulta, datos)
        Return datos.Rows(0)(0)
    End Function
    Public Function Buscapago(ByVal idcredi As Integer) As DataTable
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "Select p.id_pago, u.Nombre, p.monto, p.fecha, p.Hora from pago p join usuario u on p.cod_usu=u.cod_usu  where p.cod_credi=" & idcredi
        buscar(consulta, datos)
        Return datos

    End Function
    Public Sub abonar(ByVal codigo As Integer, ByVal abono As Decimal)
        Dim codigop As Integer
        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim hora As String = DateTime.Now.ToString("HH:mm:ss")
        Dim consul1 As String
        Dim datos1 As New DataTable
        consul1 = "Select * from pago"
        buscar(consul1, datos1)
        Dim total As Integer
        total = datos1.Rows.Count
        codigop = total + 1
        Dim consulta As String
        consulta = "Insert into pago(id_pago,cod_credi,Cod_usu,monto,fecha,hora) values(" _
            & codigop & "," & codigo & "," & cod & "," & abono & ",'" & fecha & "','" & hora & "')"
        Dim saldo As Decimal = saldoact(codigo)
        If abono > saldo Then
            MessageBox.Show("Abono execido")
        Else
            Dim valor As Decimal
            valor = saldo - abono
            modSaldo(codigo, valor)
            If consulgeneral(consulta) Then
                MessageBox.Show("Pago ingresado con exito")
                Dim accion As String
                accion = "Se realizo un abono el abono No.:" & codigop & ", al credito: " & codigo & Chr(13)
                bita.bitacora(Nombre, accion)
                Dim datos() As String
                datos = {codigop, codigo, abono, Nombre, fecha, hora}
                comproabono(datos)
            Else
                Dim accion As String
                accion = "Error al generar pago de boleta:" & codigop & ", del credito: " & codigo & Chr(13)
                bita.bitacora(Nombre, accion)
                MessageBox.Show("Error en el ingreso del abono")

            End If
        End If


    End Sub
    Private Sub comproabono(ByVal datos() As String)
        Dim abono As New DatosAbono
        Dim saldo As Decimal
        Dim saldod As New DataTable
        Dim nom As New DataTable
        Dim consulta1 As String
        Dim consulta2 As String
        consulta1 = "Select (c.TOTAL -(sum(p.monto) +c.ANTICIPO) ) as saldo from pago p join credito c on c.COD_CREDI=p.COD_CREDI where p.cod_credi=" & datos(1)
        buscar(consulta1, saldod)
        consulta2 = "Select c.nombre from cliente c join credito cre On cre.COD_CLI=c.COD_CLI where cre.COD_CREDI=" & datos(1)
        buscar(consulta2, nom)
        abono.Numabono = datos(0)
        abono.NumCre = datos(1)
        If nom.Rows.Count >= 1 Then
            abono.Nombrecli = nom.Rows(0)(0)
        Else
            abono.Nombrecli = ""
        End If

        abono.Monto = datos(2)
        abono.Usuario = datos(3)
        abono.Fecha = datos(4)
        If saldod.Rows.Count >= 1 Then
            abono.Saldo = saldod.Rows(0)(0)
        Else
            abono.Saldo = 0

        End If

        Dim pagodoc As New DocPAgo()
        pagodoc.pago.Add(abono)
        pagodoc.numpago = datos(0)
        pagodoc.Show()
    End Sub
    Private Function saldoact(ByVal cod As Integer) As Decimal
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "Select cli.saldo from cliente cli join credito c on c.cod_cli=cli.cod_cli where c.COD_CREDI=" & cod
        buscar(consulta, datos)
        Return datos(0)(0)
    End Function

    Private Sub modSaldo(ByVal cod As Integer, ByVal saldo As Decimal)
        Dim consulta As String
        Dim datos As New DataTable
        consulta = "Select cli.COD_CLI from cliente cli join credito c on c.cod_cli=cli.cod_cli where c.COD_CREDI=" & cod
        buscar(consulta, datos)
        Dim cod_cli As String
        cod_cli = datos.Rows(0)(0)
        Dim consulupd As String
        consulupd = "Update cliente set saldo=" & saldo & " where cod_cli='" & cod_cli & "'"
        consulgeneral(consulupd)
    End Sub

    Public Function totalpago(ByVal codigo As Integer) As Decimal
        Dim consulta As String
        consulta = "SELECT sum(monto) from pago p join credito c on p.COD_CREDI=c.COD_CREDI join cliente cli on c.COD_CLI=cli.COD_CLI where c.COD_CREDI=" & codigo
        Dim dato As New DataTable
        buscar(consulta, dato)
        If dato.Rows.Count < 1 Or IsDBNull(dato.Rows(0)(0)) Then

            Return 0
        Else
            Return dato.Rows(0)(0)

        End If
    End Function

End Class

