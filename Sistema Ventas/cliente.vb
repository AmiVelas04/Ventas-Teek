
Public Class cliente
    Dim funcion As New principal
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click 
        If DgvCli.RowCount >= 1 Then
            DgvCli.Rows.RemoveAt(0)
        End If
        Dim nom As String = TxtNom.Text
        Dim datos As New DataTable
        Dim total As Integer
        datos = funcion.buscarcli2(nom)
        total = datos.Rows.Count - 1

        DgvCli.DataSource = datos
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click 
        activar()
        Dim celda As Integer = DgvCli.RowCount
        If celda >= 1 Then
            Dim indice As Integer = DgvCli.CurrentRow.Index

            TxtCod.Text = DgvCli.Rows(indice).Cells(0).Value
            TxtNomCli.Text = DgvCli.Rows(indice).Cells(1).Value
            TxtDir.Text = DgvCli.Rows(indice).Cells(2).Value
            TxtNit.Text = DgvCli.Rows(indice).Cells(3).Value
            TxtCred.Text = DgvCli.Rows(indice).Cells(4).Value
            TxtSald.Text = DgvCli.Rows(indice).Cells(5).Value

        Else
            MessageBox.Show("No se ha seleccionado ningun cliente", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If





    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click 
        limpiar()
        activar()


    End Sub
    Private Sub limpiar()
        TxtCod.Clear()
        TxtNom.Clear()
        TxtNomCli.Clear()

        TxtDir.Clear()
        TxtNit.Clear()
        TxtCred.Clear()
        TxtSald.Clear()

    End Sub
    Private Sub activar()
        TxtNomCli.Enabled = True

        TxtDir.Enabled = True
        TxtNit.Enabled = True
        TxtCred.Enabled = True
        TxtSald.Enabled = True
    End Sub
    Private Sub desactivar()
        TxtNomCli.Enabled = False
        TxtDir.Enabled = False
        TxtNit.Enabled = False
        TxtCred.Enabled = False
        TxtSald.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim nit As String = TxtNit.Text
        Dim cod As String = TxtCod.Text
        Dim datos() As String
        datos = {TxtNomCli.Text, TxtDir.Text, nit, TxtCred.Text, TxtSald.Text, TxtCod.text}

        If funcion.existecli(cod) Then

            funcion.updcli(datos)
        Else
            funcion.addcli(datos)
        End If
        limpiar()
        desactivar()

    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) 
        If TxtNit.Text <> "" And TxtCod.Text <> "" Then
            Dim codigo As Integer = TxtCod.Text
            If funcion.existecli(codigo) Then
                funcion.borrarc(codigo)
                limpiar()

            Else
                MessageBox.Show("Cliente no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            MessageBox.Show("no se ha seleccionado ningún cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class