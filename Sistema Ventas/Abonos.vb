Public Class FrmCobro
    Dim general As New credito

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        TxtNom.Enabled = True
        mostrar2()
        DGVCredito.Visible = False
        Do While (DGVCliente.Rows.Count >= 1)
            DGVCliente.Rows.Remove(DGVCliente.CurrentRow)
        Loop
        mostrar()


    End Sub

    Private Sub mostrar()
        DGVCliente.Visible = True
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        TxtNomcli.Visible = False
        TxtDirCli.Visible = False
        TxtNit.Visible = False
        TxtSaldo.Visible = False
        TxtPago.Visible = False
        BtnPago.Visible = False
        DgvPagos.Visible = False
        Label11.Visible = False
    End Sub
    Private Sub ocultar()
        DGVCliente.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        TxtNomcli.Visible = True
        TxtDirCli.Visible = True
        TxtNit.Visible = True
        TxtSaldo.Visible = True
        TxtNom.Text = ""
        TxtNom.Enabled = False

    End Sub
    Private Sub mostrar2()
        DGVCredito.Visible = True
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False

        Label9.Visible = False
        Label10.Visible = False
        TxtCodCredi.Visible = False
        TxtCompro.Visible = False

        TxtVende.Visible = False
        TxtDeuda.Visible = False
        TxtTotal.Visible = False
    End Sub
    Private Sub ocultar2()
        DGVCredito.Visible = False
        Label5.Visible = True
        Label6.Visible = True
        Label7.Visible = True

        Label9.Visible = True
        Label10.Visible = True
        TxtCodCredi.Visible = True
        TxtCompro.Visible = True

        TxtVende.Visible = True
        TxtDeuda.Visible = True
        TxtTotal.Visible = True
    End Sub
    Private Sub mostrar3()
        DgvPagos.Visible = True
        TxtPago.Visible = True
        BtnPago.Visible = True
        Label11.Visible = True
    End Sub
    Private Sub ocultar3()
        DgvPagos.Visible = False
        TxtPago.Visible = False
        BtnPago.Visible = False

        Label11.Visible = False
    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        Dim nom As String
        Dim datos As New DataTable
        If TxtNom.Text <> "" Then
            nom = TxtNom.Text
            datos = general.buscarclico(nom)
            DGVCliente.DataSource = datos
            DGVCliente.Columns(0).Width = 60
            DGVCliente.Columns(1).Width = 120
            DGVCliente.Columns(2).Width = 150
            DGVCliente.Columns(3).Width = 80
            DGVCliente.Columns(4).Width = 80

        End If


    End Sub





    Private Sub DGVCliente_DoubleClick(sender As Object, e As EventArgs) Handles DGVCliente.DoubleClick
        If DGVCliente.RowCount >= 1 Then
            Dim indice As Integer
            indice = DGVCliente.CurrentRow.Index
            Dim codigo As Integer
            codigo = DGVCliente.Rows(indice).Cells(0).Value

            TxtNomcli.Text = DGVCliente.Rows(indice).Cells(1).Value
            TxtDirCli.Text = DGVCliente.Rows(indice).Cells(2).Value
            TxtNit.Text = DGVCliente.Rows(indice).Cells(3).Value
            TxtSaldo.Text = DGVCliente.Rows(indice).Cells(4).Value
            ocultar()
            If DGVCredito.RowCount >= 1 Then
                DGVCredito.Rows.RemoveAt(0)
            End If
            Llenardatos(codigo)
        Else

        End If

    End Sub
    Private Sub Llenardatos(ByVal codigo As String)
        Dim datos As New DataTable
        datos = general.buscarcredi(codigo)
        Dim total As Integer
        total = datos.Rows.Count

        DGVCredito.DataSource = datos
        DGVCredito.Columns(3).Visible = False
        Dim i As Integer
        For i = 0 To total - 1
            Dim deuda As Decimal
            ' deuda = general.totalcredito(datos.Rows(i)(1)) - datos.Rows(i)(3)
            'DGVCredito.Rows.Add(datos.Rows(i)(0), datos.Rows(i)(1), general.totalcredito(datos.Rows(i)(1)), datos.Rows(i)(3), deuda)
        Next
        mostrar2()



    End Sub
    'utilizar mas adelante
    Private Sub creditos()
        Dim total As Decimal
        Dim datos As New DataTable
        total = general.totalcredito(datos.Rows(0)(1))
        Dim indice As Integer
        indice = DGVCredito.CurrentRow.Index
        TxtCodCredi.Text = DGVCredito.Rows(indice).Cells(0).Value
        TxtCompro.Text = DGVCredito.Rows(indice).Cells(1).Value
        TxtTotal.Text = DGVCredito.Rows(indice).Cells(4).Value
        TxtVende.Text = DGVCredito.Rows(indice).Cells(2).Value

    End Sub


    Private Sub DGVCredito_DoubleClick(sender As Object, e As EventArgs) Handles DGVCredito.DoubleClick
        If DGVCredito.RowCount >= 1 Then
            Dim indice As Integer
            Dim total As Decimal
            indice = DGVCredito.CurrentRow.Index
            TxtCodCredi.Text = DGVCredito.Rows(indice).Cells(0).Value
            TxtCompro.Text = DGVCredito.Rows(indice).Cells(1).Value
            TxtTotal.Text = DGVCredito.Rows(indice).Cells(4).Value
            TxtVende.Text = DGVCredito.Rows(indice).Cells(2).Value
            total = TxtTotal.Text
            Dim anti As Decimal = DGVCredito.Rows(indice).Cells(3).Value
            ocultar2()
            Dim datos As New DataTable
            Do While (DgvPagos.Rows.Count >= 1)
                DgvPagos.Rows.Remove(DgvPagos.CurrentRow)
            Loop
            datos = general.Buscapago(TxtCodCredi.Text)
            DgvPagos.Rows.Add("1", TxtVende.Text, anti, "01/01/2020", "00:00:000", "Pago inicial")
            If datos.Rows.Count >= 1 Then
                Dim filas As Integer = datos.Rows.Count
                Dim i As Integer

                DgvPagos.Columns(3).DefaultCellStyle.Format = "dd/MM/yyyy"
                For i = 0 To filas - 1
                    'DgvPagos.DataSource = datos
                Dim fechacort As Date
                    fechacort = datos(i)(3)
                    Dim fechacc As String = fechacort.ToString("dd/MM/yyyy")

                    DgvPagos.Rows.Add(i + 2, datos.Rows(i)(1), datos.Rows(i)(2), fechacort, datos.Rows(i)(4), "Abono")

                Next
            Else
            End If


            Do While (DGVCredito.Rows.Count >= 1)
                DGVCredito.Rows.Remove(DGVCredito.CurrentRow)
            Loop
            Dim adeudo As Decimal
            Dim saldocli As Decimal
            saldocli = general.totalpago(TxtCodCredi.Text)
            adeudo = total - anti - saldocli
            TxtDeuda.Text = adeudo
            mostrar3()

            If adeudo > 0 Then
                TxtPago.Enabled = True
                BtnPago.Enabled = True
            Else
                MessageBox.Show("El credito ha sido cancelado", "Credito cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtPago.Enabled = False
                BtnPago.Enabled = False
            End If
        Else
        End If

    End Sub


    Private Sub BtnPago_Click(sender As Object, e As EventArgs) Handles BtnPago.Click
        Dim abono As Decimal
        Dim credito As Integer
        If IsNumeric(TxtCodCredi.Text) Then
            credito = TxtCodCredi.Text
            abono = TxtPago.Text
            If abono > Convert.ToDecimal(TxtDeuda.Text) Then
                MessageBox.Show("El abono es mayor al adeudo", "Monto mayor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                general.abonar(credito, abono)
            End If
        Else
            MessageBox.Show("El valor a abonar es invalido, ingrese de nuevo el valor", "Monto mayor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        ocultar3()
        mostrar()
        mostrar2()
        DGVCredito.Visible = False
        TxtPago.Clear()



    End Sub

    Private Sub GbxCliente_Enter(sender As Object, e As EventArgs) Handles GbxCliente.Enter

    End Sub
End Class