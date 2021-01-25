Imports MySql.Data.MySqlClient
Public Class LLenRep
    Dim conec As New Conexion


    Protected Sub buscar(ByVal consulta As String, ByRef tabla As DataTable)
        conec.iniciar()

        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            tabla.Dispose()
            adap.Fill(tabla)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try

    End Sub

    Private Function consulgeneral(consulta) As Boolean
        conec.iniciar()
        Dim com As New MySqlCommand
        com.Connection = conec.conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com.ExecuteNonQuery()
            conec.conn.Close()
            Return True

        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show(ex.ToString)
            Return False
        End Try

    End Function
    Public Sub reportediarioV(ByVal fecha As String, ByVal tipo As String)
        Dim datos As New DataTable
        Dim datost As New DataTable
        Dim consulta As String
        Dim consultat As String
        Dim total As Decimal
        If tipo = "Contado" Or tipo = "Credito" Then
            consulta = "Select v.comprobante ,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo 
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha='" & fecha & "' and v.tipo='" & tipo & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha='" & fecha & "' and v.tipo='" & tipo & "'"
        Else
            consulta = "Select v.comprobante,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo 
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha='" & fecha & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha='" & fecha & "'"
            tipo = "Todas"
        End If

        buscar(consulta, datos)
        buscar(consultat, datost)
        If IsDBNull(datost.Rows(0)(0)) Then
            total = 0
        Else
            total = datost.Rows(0)(0)
        End If

        If llenarRepD(datos, total, tipo, fecha) Then

        Else
            MessageBox.Show("Hubo un error en el reporte, consulte con su administrador")
        End If

    End Sub
    Public Sub reportemensualV(ByVal fechai As String, ByVal fechaf As String, ByVal tipo As String)
        Dim datos As New DataTable
        Dim datost As New DataTable
        Dim consulta As String
        Dim consultat As String
        Dim total As Decimal
        If tipo = "Contado" Or tipo = "Credito" Then
            consulta = "Select v.comprobante ,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo, v.fecha
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "' and v.tipo='" & tipo & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "' and v.tipo='" & tipo & "'"
        Else
            consulta = "Select v.comprobante ,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo, v.fecha
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "'"
            tipo = "Todas"
        End If

        buscar(consulta, datos)
        buscar(consultat, datost)
        If IsDBNull(datost.Rows(0)(0)) Then
            total = 0
        Else
            total = datost.Rows(0)(0)
        End If
        Dim mes As Integer = Month(fechai)
        Dim anio As Integer = Year(fechai)
        Dim periodo As String = ""
        Select Case mes
            Case 1
                periodo = "Enero de " & anio
            Case 2
                periodo = "Febrero de " & anio
            Case 3
                periodo = "Marzo de " & anio
            Case 4
                periodo = "Abril de " & anio
            Case 5
                periodo = "Mayo de " & anio
            Case 6
                periodo = "Junio de " & anio
            Case 7
                periodo = "Julio de " & anio
            Case 8
                periodo = "Agosto de " & anio
            Case 9
                periodo = "Septiembre de " & anio
            Case 10
                periodo = "Octubre de " & anio
            Case 11
                periodo = "Noviembre de " & anio
            Case 12
                periodo = "Diciembre de " & anio

        End Select

        If llenarRepM(datos, total, tipo, periodo) Then

        Else
            MessageBox.Show("Hubo un error en el reporte, consulte con su administrador")
        End If

    End Sub
    Public Sub reporteanualV(ByVal fechai As String, ByVal fechaf As String, ByVal tipo As String)
        Dim datos As New DataTable
        Dim datost As New DataTable
        Dim consulta As String
        Dim consultat As String
        Dim total As Decimal
        If tipo = "Contado" Or tipo = "Credito" Then
            consulta = "Select v.comprobante ,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo, v.fecha
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "' and v.tipo='" & tipo & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "' and v.tipo='" & tipo & "'"
        Else
            consulta = "Select v.comprobante ,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as Total, u.nombre, v.tipo, v.fecha
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "'"
            consultat = "select sum(vd.cantidad*vd.precio) as Total from ventadetalle vd join venta v on vd.COMPROBANTE=v.COMPROBANTE where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "'"
            tipo = "Todas"
        End If

        buscar(consulta, datos)
        buscar(consultat, datost)
        If IsDBNull(datost.Rows(0)(0)) Then
            total = 0
        Else
            total = datost.Rows(0)(0)
        End If
        Dim anio As Integer = Year(fechai)
        Dim periodo As String = "Enero a Diciembre de " & anio

        If llenarRepA(datos, total, tipo, Periodo) Then

        Else
            MessageBox.Show("Hubo un error en el reporte, consulte con su administrador")
        End If

    End Sub

    Private Function llenarRepD(ByVal datos As DataTable, ByVal total As Decimal, ByVal tipo As String, ByVal fecha As String) As Boolean

        Dim Encabezado As New EncRep
        Dim tvent As Integer = datos.Rows.Count
        Dim cont As Integer
        Try
            Encabezado.Tipo = tipo
            Encabezado.Fecha = diaactual()
            Encabezado.Total = total

            For cont = 0 To tvent - 1
                Dim detalle As New DetRep()
                detalle.compro = datos(cont)(0)
                detalle.Total = datos(cont)(1)
                detalle.vendedor = datos(cont)(2)
                detalle.tipo = datos(cont)(3)
                detalle.fecha = fecha
                Encabezado.Detalle.Add(detalle)
                MessageBox.Show("No. " & datos(cont)(0) & Chr(13) & "Total: " & datos(cont)(1) & Chr(13) & "Vendedor" & datos(cont)(2) & Chr(13) & "Tipo: " & datos(cont)(2))
            Next

            Dim reporte As New ReporteD()
            reporte.encabezado.Add(Encabezado)
            reporte.Detalle = Encabezado.Detalle
            reporte.Show()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False

        End Try
    End Function
    Private Function llenarRepM(ByVal datos As DataTable, ByVal total As Decimal, ByVal tipo As String, ByVal peri As String) As Boolean

        Dim Encabezado As New EncRep
        Dim tvent As Integer = datos.Rows.Count
        Dim cont As Integer
        Try
            Encabezado.Tipo = tipo
            Encabezado.Fecha = peri
            Encabezado.Total = total
            For cont = 0 To tvent - 1
                Dim detalle As New DetRep()
                detalle.compro = datos(cont)(0)
                detalle.Total = datos(cont)(1)
                detalle.vendedor = datos(cont)(2)
                detalle.tipo = datos(cont)(3)
                detalle.fecha = datos(cont)(4)
                Encabezado.Detalle.Add(detalle)
                'MessageBox.Show("No. " & datos(cont)(0) & Chr(13) & "Total: " & datos(cont)(1) & Chr(13) & "Vendedor" & datos(cont)(2) & Chr(13) & "Tipo: " & datos(cont)(2))
            Next

            Dim reporte As New ReporteM()
            reporte.encabezado.Add(Encabezado)
            reporte.Detalle = Encabezado.Detalle
            reporte.Show()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False

        End Try
    End Function
    Private Function llenarRepA(ByVal datos As DataTable, ByVal total As Decimal, ByVal tipo As String, ByVal Periodo As String) As Boolean

        Dim Encabezado As New EncRep
        Dim tvent As Integer = datos.Rows.Count
        Dim cont As Integer
        Try
            Encabezado.Tipo = tipo
            Encabezado.Fecha = Periodo
            Encabezado.Total = total

            For cont = 0 To tvent - 1
                Dim detalle As New DetRep()
                detalle.compro = datos(cont)(0)
                detalle.Total = datos(cont)(1)
                detalle.vendedor = datos(cont)(2)
                detalle.tipo = datos(cont)(3)
                detalle.fecha = datos(cont)(4)
                Encabezado.Detalle.Add(detalle)
                'MessageBox.Show("No. " & datos(cont)(0) & Chr(13) & "Total: " & datos(cont)(1) & Chr(13) & "Vendedor" & datos(cont)(2) & Chr(13) & "Tipo: " & datos(cont)(2))
            Next

            Dim reporte As New ReporteA()
            reporte.encabezado.Add(Encabezado)
            reporte.Detalle = Encabezado.Detalle
            reporte.Show()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False

        End Try
    End Function
    Public Sub TodosProd()
        Dim consulta As String
        Dim consultat As String
        Dim datos As New DataTable
        Dim datost As New DataTable
        Dim total As Decimal
        consulta = "Select Nombre, Marca, cantidad, precioc,imagen, descripcion, preciov from producto order by Nombre,Marca"
        consultat = "select Sum(cantidad*precioc) as Total from producto"
        buscar(consulta, datos)
        buscar(consultat, datost)
        If IsDBNull(datost(0)(0)) Then
            total = 0
        Else
            total = datost(0)(0)
        End If
        llenarp(datos, total)


    End Sub
    Private Sub llenarp(ByVal dat As DataTable, ByVal Total As Decimal)
        Dim Encabezado As New EncProd
        Dim tprod As Integer = dat.Rows.Count
        Dim cont As Integer
        Encabezado.Total = Total
        Try
            For cont = 0 To tprod - 1
                Dim detalle As New DetProd()
                detalle.Nombre = dat(cont)(0)
                detalle.Descripcion = dat(cont)(5)
                detalle.Marca = dat(cont)(1)
                detalle.Cantidad = dat(cont)(2)
                detalle.Precio = dat(cont)(3)
                detalle.imagen = Application.StartupPath & "\imagen\" & dat(cont)(4)
                detalle.PrecioV = dat(cont)(6)
                'MessageBox.Show(Application.StartupPath & "\imagen\" & dat(cont)(4))
                Encabezado.Detalle.Add(detalle)
            Next
            Dim reporte As New ReporteProd()
            reporte.encabezado.Add(Encabezado)
            reporte.Detalle = Encabezado.Detalle
            reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub ganacia(ByVal fechai As String, fechaf As String)
        Dim consult As String
        Dim datos As New DataTable
        consult = "Select v.COMPROBANTE as Comprobante,v.FECHA as Fecha,us.Nombre as Atendio,sum(vd.precio-p.PRECIOC) as Ganacia, v.tipo as Tipo
        from producto p 
        join ventadetalle vd on vd.codigo_p=p.codigo_p
        join venta v on v.comprobante=vd.comprobante
        join usuario us on v.cod_usu=us.Cod_usu
        where v.fecha>='" & fechai & "' and v.fecha<='" & fechaf & "'
        group by v.COMPROBANTE, v.fecha
        ORDER by v.comprobante "
        buscar(consult, datos)
        If IsDBNull(datos) Then
            MessageBox.Show("No se encontraron registros de ventas en este ")
        Else
            LlenarGan(datos, fechaf)
        End If
    End Sub
    Private Sub LlenarGan(ByVal datos As DataTable, ByVal fecha As String)
        Dim totdat As Integer = datos.Rows.Count
        Dim mes As Integer = Month(fecha)
        Dim anio As Integer = Year(fecha)
        Dim periodo As String
        Dim encabezado As New EncGan
        Select Case mes
            Case 1
                periodo = "Enero de " & anio
            Case 2
                periodo = "Febrero de " & anio
            Case 3
                periodo = "Marzo de " & anio
            Case 4
                periodo = "Abril de " & anio
            Case 5
                periodo = "Mayo de " & anio
            Case 6
                periodo = "Junio de " & anio
            Case 7
                periodo = "Julio de " & anio
            Case 8
                periodo = "Agosto de " & anio
            Case 9
                periodo = "Septiembre de " & anio
            Case 10
                periodo = "Octubre de " & anio
            Case 11
                periodo = "Noviembre de " & anio
            Case 12
                periodo = "Diciembre de " & anio
        End Select
        Dim cont As Integer
        Dim total As Decimal = 0
        encabezado.Periodo = periodo
        Try
            For cont = 0 To totdat - 1
                Dim detalle As New DetGan()
                detalle.Compro = datos(cont)(0)
                detalle.Fecha = datos(cont)(1)
                detalle.usuario = datos(cont)(2)
                detalle.Ganacia = datos(cont)(3)
                total += datos(cont)(3)
                encabezado.Detalle.Add(detalle)
            Next
            encabezado.Total = total
            Dim reporte As New ReporteGan()
            reporte.encabezado.Add(encabezado)
            reporte.Detalle = encabezado.Detalle
            reporte.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class
