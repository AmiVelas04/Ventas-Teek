Imports MySql.Data.MySqlClient

Public Class BuscProd
    Dim conec As New Conexion
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        buscar()

    End Sub
    Private Sub buscar()
        Dim nombre As String
        nombre = TxtNom.Text
        Dim prod As New DataTable
        Dim consulta As String
        consulta = "select codigo_p as Codigo,Nombre,Descripcion,Marca, Preciov as Precio from producto where nombre like '%" & nombre & "%'"
        Try
            conec.iniciar()
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            adap.Fill(prod)
            Dgv1.DataSource = prod
            ' Dgv1.Columns(0).Visible = False
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If Dgv1.RowCount >= 1 Then
            Dim indice As String
            indice = Dgv1.CurrentRow.Index

            codp = Dgv1.Rows(indice).Cells(0).Value
            estado = True
            Me.Close()
        Else
            MessageBox.Show("No se ha seleccionado ningín producto", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub BuscProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtNom_TextChanged(sender As Object, e As EventArgs) Handles TxtNom.TextChanged
        buscar()

    End Sub
End Class