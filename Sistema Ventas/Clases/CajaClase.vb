Imports MySql.Data.MySqlClient
Public Class CajaClase
    Dim conec As New Conexion
    Private Sub buscar(ByVal consulta As String, ByRef datos As DataTable)
        conec.iniciar()
        datos.Dispose()

        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            adap.Fill(datos)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub
    Private Function consultag(ByVal consulta As String) As Boolean
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
    Private Sub iniciarlo()

        Dim consulta As String
        consulta = "Select estado from caja where id_caja=1"
        Dim datos As New DataTable
        buscar(consulta, datos)

        If datos.Rows.Count >= 1 Then
            If datos.Rows(0)(0) = "nula" Then
                Dim valor As String = InputBox("Ingrese la cantidad de efectivo para inicalizar la caja")
                If IsNumeric(valor) Then
                    Dim consultacaja As String
                    consultacaja = "update caja set estado='activa' where id_caja=1"
                    If consultag(consultacaja) Then
                        MessageBox.Show("Caja inicializada correctamente")
                    Else
                        MessageBox.Show("Error en inicializacion de caja")
                    End If
                Else
                    MessageBox.Show("El valor ingresado no es valido, intente de nuevo", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("La caja ya ha sido Inicializada", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub
    Private Sub cortecaja()

    End Sub

    Private Function idcaja() As Integer
        Dim consulta As String
        Dim datos As New DataTable
        Dim codigo As Integer
        consulta = "Select max(id_caja) from caja"
        buscar(consulta, datos)
        If datos.Rows.Count = 0 Then
            Return 1
        Else
            codigo = Integer.Parse(datos.Rows(0)(0).ToString)
            codigo += 1
            Return codigo
        End If
    End Function

    Private Sub iniciar()
        Dim consulta As String
        consulta = "Select estado from caja where id_caja=1"
        Dim datos As New DataTable
        buscar(consulta, datos)
        If datos.Rows.Count >= 1 Then
            If datos.Rows(0)(0) = "activa" Or datos.Rows(0)(0) = "cerrada" Then
                Dim consultacaja As String
                consultacaja = "update caja set estado='abierta' where id_caja=1"
                If consultag(consultacaja) Then
                    MessageBox.Show("Caja Abierta correctamente")
                Else
                    MessageBox.Show("apertura de caja de caja")
                End If
            ElseIf datos.Rows(0)(0) = "abierta" Then
                MessageBox.Show("La caja ya ha sido Abierta", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Public Function ingresoope(ByVal datos() As String) As Boolean
        Dim consulta As String
        Dim codigo As Integer = idcaja()

        consulta = "insert into caja(id_caja,monto,descripcion,operacion,estado,fecha,usuario) " &
            "values(" & codigo.ToString & "," & datos(0) & ",'" & datos(1) & "','" & datos(2) & "','" & datos(3) & "','" & datos(4) & "','" & datos(5) & "')"
        Return consultag(consulta)
    End Function

    Public Function totalingre(ByVal fecha As String) As Decimal
        Dim consulta As String
        Dim datos As New DataTable
        Dim total As String
        Dim fechai As String = fecha & " 00:00:00"
        Dim fechaf As String = fecha & " 23:59:59"
        consulta = "Select sum(monto) from caja where fecha>='" & fechai & "' and fecha<='" & fechaf & "' and Operacion='Ingreso'"
        buscar(consulta, datos)
        If (Not IsDBNull(datos.Rows(0)(0))) Then
            total = Decimal.Parse(datos.Rows(0)(0).ToString)
        Else
            total = 0
        End If

        Return total
    End Function

    Public Function totalegre(ByVal fecha As String) As Decimal
        Dim consulta As String
        Dim datos As New DataTable
        Dim total As String
        Dim fechai As String = fecha & " 00:00:00"
        Dim fechaf As String = fecha & " 23:59:59"
        consulta = "Select sum(monto) from caja where fecha>='" & fechai & "' and fecha<='" & fechaf & "' and Operacion='Egreso'"
        buscar(consulta, datos)
        If (Not IsDBNull(datos.Rows(0)(0))) Then
            total = Decimal.Parse(datos.Rows(0)(0).ToString)
        Else
            total = 0
        End If
        Return total
    End Function

    Public Function operaciones(ByVal fecha As String) As DataTable
        Dim fechai As String = fecha & " 00:00:00"
        Dim fechaf As String = fecha & " 23:59:59"
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "Select id_caja as Codigo,Operacion, Monto, Descripcion, date_format(fecha, '%H:%m:%s') as Hora, Usuario as Opero from caja where " &
            "fecha>='" & fechai & "' and fecha<='" & fechaf & "'"
        buscar(consulta, datos)
        Return datos
    End Function
End Class
