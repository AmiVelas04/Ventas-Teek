﻿Public Class Productos
    Dim principal As New principal
    Dim clie As New Clasecliente

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.BackColor = Color.Transparent
        GroupBox2.BackColor = Color.Transparent

        Label1.BackColor = Color.Transparent
        Me.Focus()
        llenarcli()

    End Sub

    Private Sub llenarcli()
        ' Agregar clientes
        Dim datos As New DataTable
        datos = clie.buscarcli()
        CboCliente.DataSource = datos
        CboCliente.DisplayMember = "nombre"
        CboCliente.ValueMember = "codigo"
        Dim cliente As New AutoCompleteStringCollection
        For Each fila As DataRow In datos.Rows
            cliente.Add(fila("Nombre").ToString)
        Next
        CboCliente.AutoCompleteCustomSource = cliente
        CboCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CboCliente.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub


    Private Sub TxtCod_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCod.KeyDown

        If e.KeyCode = Keys.Return Then

            Buscarc()


        End If
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs)
        Dim indice As Integer

        Try

            If DGV1.Rows.Count <= 0 Then
                MsgBox("No hay productos!")
            Else

                indice = DGV1.CurrentRow.Index
                borrarp(indice)
                calc_total()

            End If
        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub borrarp(ByVal indice As Integer)
        DGV1.Rows.RemoveAt(indice)
    End Sub
    Private Sub calc_total()
        Dim totalp As Integer
        Dim cant As Integer = DGV1.RowCount
        Dim total As Decimal


        Dim k As Integer
        For k = 0 To cant - 1
            totalp = (DGV1.Rows(k).Cells(4).Value) * (DGV1.Rows(k).Cells(5).Value)
            DGV1.Rows(k).Cells(6).Value = totalp
            total += totalp
        Next
        LblT.Text = total
        LblTotal.Text = "Q. " & total

    End Sub

    Friend Sub Buscarc()
        Try
            If TxtCod.Text <> "" Then
                Dim prod As New DataTable
                Dim cod As String
                prod.Dispose()

                If TxtCod.Text <> "" Then
                    cod = TxtCod.Text
                Else

                    cod = "0"
                End If
                TxtCod.Clear()
                If principal.existep(cod) Then

                    prod = principal.buscap(cod)
                    If prod.Rows(0)(5) >= 1 Then
                        DGV1.Rows.Add(prod.Rows(0)(0), prod.Rows(0)(1), prod.Rows(0)(2), prod.Rows(0)(3), prod.Rows(0)(4), 1, 1 * prod.Rows(0)(4), prod.Rows(0)(6), prod.Rows(0)(5))
                        calc_total()
                    Else
                        MessageBox.Show("no se puede agregar el producto, verifique si hay existencias")
                    End If
                Else
                    MessageBox.Show("Producto no encontrado, intente de nuevo")
                End If
            Else
                MessageBox.Show("Codigo incorrencto, intente de nuevo")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub BtnBuscaP_Click(sender As Object, e As EventArgs)
        Buscarc()

    End Sub



    Private Sub Productos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F9 Then
            cambiar_precio()
        ElseIf e.KeyCode = Keys.F6 Then
            cambiar_cant()
        ElseIf e.KeyCode = Keys.F2 Then
            Dim busc As New BuscProd
            busc.Show()
        ElseIf e.KeyCode = Keys.F5 Then
            If estado Then
                TxtCod.Text = codp
                estado = False
                Buscarc()
            End If
        End If
    End Sub
    Private Sub cambiar_precio()
        If selec() Then
            Dim precio As String = InputBox("Ingrese el nuevo precio")
            Dim indice As Integer = DGV1.CurrentRow.Index
            If precio = "" Then
                precio = 0
            End If
            If IsNumeric(precio) And precio > 0 Then
                Dim costo As Decimal
                costo = principal.costo(DGV1.Rows(indice).Cells(0).Value)
                '  MessageBox.Show("Costo: " & costo & Chr(13) & "Precio: " & precio)
                If precio < costo Then
                    MessageBox.Show("El precio ingresado no se puede cambiar debido a que es menor al valor de costo", "Precio muy bajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    DGV1.Rows(indice).Cells(4).Value = precio
                    calc_total()
                End If
            Else
                MessageBox.Show("No es un valor valido")

            End If
        Else
            MessageBox.Show("No ha seleccionado ningun producto", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub cambiar_cant()
        If selec() Then
            Dim cant As String = InputBox("Ingrese cantidad")
            If cant = "" Then
                cant = 0
            End If
            Dim indice As Integer = DGV1.CurrentRow.Index
            If IsNumeric(cant) And cant > 0 Then
                If cant > DGV1.Rows(indice).Cells(8).Value Then
                    MessageBox.Show("No hay existencias para cumplir con esta venta", "Bajo inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    DGV1.Rows(indice).Cells(5).Value = cant
                    calc_total()
                End If

            Else
                MessageBox.Show("No es un valor valido")
            End If
        Else
            MessageBox.Show("No ha seleccionado ningun producto", "No seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Function selec() As Boolean
        If DGV1.RowCount >= 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnBuscarCli_Click(sender As Object, e As EventArgs)
        If TxtNit.Text <> "" Then
            buscarcli()
        End If
    End Sub

    Private Sub BtnCobrar_Click(sender As Object, e As EventArgs)
        If LblTotal.Text = "Total:Q." Then
            MessageBox.Show("No se ha ingresado ningun producto", "No hay productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim codicli As String = ""
        Dim prod As New DataTable
        Dim cliente As New DataTable
        Dim filas As Integer
        filas = DGV1.RowCount
        Dim k As Integer
        Dim largo As Integer = Len(LblTotal.Text)
        Dim Total As Decimal = Convert.ToDecimal(Replace(LblTotal.Text, "Q. ", ""))
        Dim datos() As String
        Dim usuc As Integer = VariablesUNI.cod
        Dim usun As String = VariablesUNI.Nombre
        If (CboCliente.SelectedValue = Nothing) Then
            codicli = "0"
        Else
            codicli = CboCliente.SelectedValue.ToString
        End If
        cliente = principal.buscli(codicli, TxtNit.Text, CboCliente.Text)

        datos = {cliente.Rows(0)(0), cliente.Rows(0)(1), cliente.Rows(0)(2), cliente.Rows(0)(3), cliente.Rows(0)(4), TxtNit.Text, Total}

        prod.Columns.Add("codigo").DataType = System.Type.GetType("System.String")
        prod.Columns.Add("producto").DataType = System.Type.GetType("System.String")
        prod.Columns.Add("descripcion").DataType = System.Type.GetType("System.String")
        prod.Columns.Add("marca").DataType = System.Type.GetType("System.String")
        prod.Columns.Add("precio").DataType = System.Type.GetType("System.String")
        prod.Columns.Add("cantidad").DataType = System.Type.GetType("System.String")
        For k = 0 To filas - 1
            Dim fila = prod.NewRow
            fila("codigo") = DGV1.Rows(k).Cells(0).Value.ToString
            fila("producto") = DGV1.Rows(k).Cells(1).Value
            fila("descripcion") = DGV1.Rows(k).Cells(2).Value
            fila("marca") = DGV1.Rows(k).Cells(3).Value
            fila("precio") = DGV1.Rows(k).Cells(4).Value
            fila("cantidad") = DGV1.Rows(k).Cells(5).Value
            prod.Rows.Add(fila)

        Next

        Dim tipo As String
        ' If LblNombre.Text = "Nombre: N/E" Or LblNombre.Text = "Nombre:" Then
        'MessageBox.Show("No se puede realizar la compra debido a que no exite ningun cliente valido", "No hay cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        If RdbContado.Checked = True Then
            Try
                tipo = "Contado"
                principal.fact_gen(datos, prod, usuc, usun, tipo, 0, Total)
            Catch ex As Exception
                MessageBox.Show("Error en detalle: " & ex.ToString)
            End Try
        Else
            tipo = "Credito"
            Dim saldo = cliente.Rows(0)(3) - cliente.Rows(0)(4)
            If Total > saldo Then
                MessageBox.Show("El monto excede el credito del cliente, cominicquese con su administrador", "Monto Exedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim anti As Decimal
                anti = TxtAntic.Text
                principal.fact_gen(datos, prod, usuc, usun, tipo, anti, Total)

            End If
        End If
        ' End If
        limpiar()
    End Sub


    Private Sub DGV1_Click(sender As Object, e As EventArgs)
        If DGV1.RowCount >= 1 Then
            Dim indice As Integer
            indice = DGV1.CurrentRow.Index
            TxtProd.Text = DGV1.Rows(indice).Cells(1).Value
            TxtDes.Text = DGV1.Rows(indice).Cells(2).Value
            TxtMarc.Text = DGV1.Rows(indice).Cells(3).Value
            TxtPrecio.Text = DGV1.Rows(indice).Cells(4).Value
            If IsDBNull(DGV1.Rows(indice).Cells(7).Value) Then
                ImgProd.Image = Image.FromFile("./imagen/0.jpg")
            Else
                ImgProd.Image = Image.FromFile("./imagen/" & DGV1.Rows(indice).Cells(7).Value)
            End If
        Else
        End If

    End Sub
    Private Sub buscarcli()
        Dim datos As New DataTable
        Dim nit As String = TxtNit.Text
        datos = principal.buscli(CboCliente.SelectedValue.ToString(), TxtNit.Text, CboCliente.Text)

        LblNombre.Text = "Nombre: " & datos.Rows(0)(1).ToString
        LblDir.Text = "Direccion: " & datos.Rows(0)(2).ToString
        LblCredito.Text = "Credito: " & datos.Rows(0)(3).ToString
        If LblNombre.Text = "Nombre: N/E" Then
            RdbCredito.Enabled = False
            RdbContado.Checked = True
        Else
            RdbCredito.Enabled = True
        End If
    End Sub

    Private Sub TxtNit_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Return And TxtNit.Text <> "" Then
            buscarcli()
        End If
    End Sub

    Private Sub RdbContado_CheckedChanged(sender As Object, e As EventArgs)
        LblEfect.Visible = False
        TxtAntic.Visible = False
        TxtAntic.Clear()
    End Sub

    Private Sub RdbCredito_CheckedChanged(sender As Object, e As EventArgs)
        LblEfect.Visible = True
        TxtAntic.Visible = True
        TxtAntic.Text = 0

    End Sub

    Private Sub TxtAntic_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = "." Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAntic_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAntic.KeyDown
        If e.KeyCode = Keys.Escape Then
            TxtAntic.Clear()
        ElseIf e.KeyCode = Keys.Return Then
            If RdbContado.Checked And IsNumeric(TxtAntic.Text) And IsNumeric(LblT.Text) Then
                Dim cambio As Decimal
                cambio = Decimal.Parse(TxtAntic.Text) - Decimal.Parse(LblT.Text)
                If cambio < 0 Then
                    MessageBox.Show("Verifique el monto ingresado")
                Else
                    LblCambio.Text = "Cambio: Q. " & cambio
                End If
            End If
        End If
    End Sub

    Private Sub limpiar()
        TxtCod.Clear()
        TxtAntic.Clear()
        TxtDes.Clear()
        TxtPrecio.Clear()
        TxtProd.Clear()
        TxtNit.Clear()
        TxtMarc.Clear()
        Do While (DGV1.RowCount >= 1)
            DGV1.Rows.Remove(DGV1.CurrentRow)
        Loop
        LblTotal.Text = "Total:Q."
        LblNombre.Text = "Nombre:"
        LblDir.Text = "Dirección:"
        LblCredito.Text = "Credito:"
        RdbContado.Checked = True
        RdbCredito.Enabled = True
        LblEfect.Visible = False
        TxtAntic.Visible = False
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs)
        limpiar()

    End Sub

    Private Sub CboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCliente.SelectedIndexChanged
        If (CboCliente.Text <> "" And CboCliente.SelectedValue.ToString <> "System.Data.DataRowView") Then
            busquedacli(CboCliente.SelectedValue.ToString)
        Else
            busquedacli("0")
        End If
    End Sub

    Private Sub busquedacli(ByVal cod As String)
        Dim datos As New DataTable()

        datos = clie.clieespec(cod)
        If (datos.Rows.Count > 0) Then
            TxtNit.Text = datos.Rows(0)(1).ToString
            LblDir.Text = datos.Rows(0)(0).ToString
            LblCredito.Text = datos.Rows(0)(2).ToString
        End If
    End Sub

    Private Sub BtnBuscarCli_Click_1(sender As Object, e As EventArgs) Handles BtnBuscarCli.Click

    End Sub


End Class