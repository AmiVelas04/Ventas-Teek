Imports MySql.Data.MySqlClient
Public Class Clasecliente
    Dim conec As New Conexion
    Private Function buscar(ByVal consulta As String) As DataTable
        conec.iniciar()
        Dim datos As New DataTable
        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)

            adap.Fill(datos)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try
        Return datos
    End Function

    Private Function consulta_gen(ByVal consulta As String) As Boolean

    End Function
    Public Function buscarcli() As DataTable
        Dim consulta As String
        consulta = "select Cod_cli as codigo, nombre, direccion, nit, credito from cliente"
        Return buscar(consulta)

    End Function

    Public Function clieespec(ByVal cod As String) As DataTable
        Dim consulta As String
        consulta = "Select direccion, nit, credito from cliente where Cod_Cli=" & cod
        Return buscar(consulta)
    End Function
End Class
