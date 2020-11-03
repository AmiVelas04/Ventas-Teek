Imports MySql.Data.MySqlClient
Public Class CorteCaja
    Dim servidor As String = "192.168.1.103"
    Dim bd As String = "prod"
    Dim user As String = "prueba"
    Dim pass As String = "1532"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
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
    Private Sub buscar(ByVal consulta As String, ByRef datos As DataTable)
        datos.Dispose()

        Try
            Dim adap As New MySqlDataAdapter(consulta, conn)
            adap.Fill(datos)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub
    Private Function consultag(ByVal consulta As String) As Boolean
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

    Private Sub BtnCorte_Click(sender As Object, e As EventArgs) Handles BtnCorte.Click
        Dim fecha As String = diaactual()
        Dim cons1 As String
        Dim cons2 As String
        Dim cons3 As String
        Dim cons4 As String
        Dim cons5 As String



        Dim dat1 As New DataTable
        Dim dat2 As New DataTable
        Dim dat3 As New DataTable
        Dim dat4 As New DataTable
        Dim dat5 As New DataTable

        cons1 = "select sum(vd.CANTIDAD*vd.PRECIO) as total from venta v INNER join ventadetalle vd on vd.COMPROBANTE=v.COMPROBANTE where v.tipo='contado' and fecha ='" & fecha & "'"
        cons2 = "Select sum(cre.anticipo) from credito cre join venta v on v.COMPROBANTE=cre.COMPROBANTE where v.FECHA='" & fecha & "'"
        cons3 = "select sum(p.monto) from pago p where p.FECHA = '" & fecha & "'"
        cons4 = "select sum(monto) from gasto where fecha='" & fecha & "'"
        cons5 = "select saldo from caja where id_caja=1"
        buscar(cons1, dat1)
        buscar(cons2, dat2)
        buscar(cons3, dat3)
        buscar(cons4, dat4)
        buscar(cons5, dat5)
        If IsDBNull(dat1.Rows(0)(0)) Then
            TxtCont.Text = 0
        Else
            TxtCont.Text = dat1.Rows(0)(0)
        End If
        If IsDBNull(dat2.Rows(0)(0)) Then
            TxtAntic.Text = 0
        Else
            TxtAntic.Text = dat2.Rows(0)(0)
        End If
        If IsDBNull(dat3.Rows(0)(0)) Then
            TxtAbonos.Text = 0
        Else
            TxtAbonos.Text = dat3.Rows(0)(0)
        End If
        If IsDBNull(dat4.Rows(0)(0)) Then
            TxtGastos.Text = 0
        Else
            TxtGastos.Text = dat4.Rows(0)(0)
        End If
        If IsDBNull(dat5.Rows(0)(0)) Then
            TxtSaldo.Text = 0
        Else
            TxtSaldo.Text = dat5.Rows(0)(0)
        End If




        TxtTotal.Text = Convert.ToDecimal(TxtSaldo.Text) + Convert.ToDecimal(TxtAbonos.Text) + Convert.ToDecimal(TxtAntic.Text) + Convert.ToDecimal(TxtCont.Text)
        TxtTotalCaja.Text = Convert.ToDecimal(TxtTotal.Text) - Convert.ToDecimal(TxtGastos.Text)
        Dim saldo As Decimal = TxtTotalCaja.Text
        Dim consulta As String
        consulta = "Select estado from caja where id_caja=1"
        Dim datos As New DataTable
        buscar(consulta, datos)
        If datos.Rows.Count >= 1 Then
            If datos.Rows(0)(0) = "activa" Or datos.Rows(0)(0) = "abierta" Then
                Dim consultacaja As String
                consultacaja = "update caja set estado='cerrada', saldo=" & saldo & " where id_caja=1"
                If consultag(consultacaja) Then
                    MessageBox.Show("Cierre de caja Correcto correctamente")
                Else
                    MessageBox.Show("error en cierre de caja")
                End If
            ElseIf datos.Rows(0)(0) = "cerrada" Then
                MessageBox.Show("La caja ya ha sido Cerrada", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Dispose()

    End Sub

    Private Sub CorteCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class