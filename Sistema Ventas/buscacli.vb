Imports MySql.Data.MySqlClient
Public Class buscacli
    Dim servidor As String = "localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-Sis-2020"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

    End Sub
    Private Sub buscar()

        Dim nombre As String
        nombre = TxtNom.Text
        Dim cli As New DataTable
        Dim consulta As String
        consulta = "select cod_cli as Codigo,Nombre,Direccion,Nit from cliente where nombre like '%" & nombre & "%'"
        Try
            Dim adap As New MySqlDataAdapter(consulta, conn)
            adap.Fill(cli)
            DGV1.DataSource = cli
            ' Dgv1.Columns(0).Visible = False
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub buscacli_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        If DGV1.RowCount >= 1 Then
            Dim indice As String
            indice = DGV1.CurrentRow.Index

            codc = DGV1.Rows(indice).Cells(0).Value
            estadocli = True
            Me.Close()
        Else
            MessageBox.Show("No se ha seleccionado ningín producto", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class