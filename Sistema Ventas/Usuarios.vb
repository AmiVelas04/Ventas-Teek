Public Class Usuarios
    Dim general As New Usuario
    Dim indiceg As Integer
    'Accion = 1 guardar un nuevo usuario
    'accion = 2 editar un usuario existente
    Dim accion As Integer

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If DGVUsuarios.RowCount >= 1 Then
            DGVUsuarios.Rows.Clear()

        End If
        Dim datos As New DataTable
        Dim nivel As String = ""
        Dim nom As String
        nom = TxtNom.Text
        Dim total As Integer
        datos = general.buscarusu(nom)
        total = datos.Rows.Count
        If total = 0 Then
            MessageBox.Show("No se encontraron usarios ingresados", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        Dim i As Integer
        For i = 0 To total - 1
            If datos.Rows(i)(4) = 2 Then
                nivel = "Administrador"
            ElseIf datos.Rows(i)(4) = 3 Then
                nivel = "Vendedor"
            End If
            DGVUsuarios.Rows.Add(datos.Rows(i)(0), datos.Rows(i)(1), datos.Rows(i)(2), datos.Rows(i)(3), nivel)

        Next


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        accion = 2
        GroupUsuario.Enabled = True
        Dim celda As Integer = DGVUsuarios.ColumnCount

        If celda >= 1 Then
            Dim indice As Integer = DGVUsuarios.CurrentRow.Index
            indiceg = indice

            TxtNombre.Text = DGVUsuarios.Rows(indice).Cells(1).Value
            TxtUsu.Text = DGVUsuarios.Rows(indice).Cells(2).Value
            If DGVUsuarios.Rows(indice).Cells(4).Value = "Administrador" Then
                RdbAdmin.Select()
                RdbAdmin.Checked = vbTrue
            Else
                RdbVendedor.Checked = vbTrue
            End If




        Else
            MessageBox.Show("No se ha seleccionado ningun producto", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim codigo As Integer
        Dim nivel As Integer
        Dim datos() As String
        If accion = 1 Then
            codigo = 0
        Else
            codigo = DGVUsuarios.Rows(indiceg).Cells(0).Value
        End If


        If RdbAdmin.Checked = True Then
            nivel = 2
        ElseIf RdbVendedor.Checked = True Then
            nivel = 3
        End If
        datos = {codigo, TxtNombre.Text, TxtUsu.Text, TxtPass1.Text, nivel}
        If general.existeUsu(datos(0)) Then
            general.Updusu(datos)
        Else

            general.Addusu(datos)

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim indice As Integer
        indice = DGVUsuarios.CurrentRow.Index
        Dim codigo As Integer = DGVUsuarios.Rows(indice).Cells(0).Value
        If general.existeUsu(codigo) Then
            general.borrarusu(codigo)
        Else
            MessageBox.Show("Producto no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        accion = 1
        GroupUsuario.Enabled = True
        TxtNombre.Clear()
        TxtPass1.Clear()
        TxtPass2.Clear()
        TxtUsu.Clear()
        RdbVendedor.Checked = True
    End Sub

    Private Sub DGVUsuarios_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVUsuarios.CellFormatting
        If e.ColumnIndex = 3 Then
            e.Value = New String("*"c, Convert.ToString(e.Value).Length)
        End If
    End Sub


End Class