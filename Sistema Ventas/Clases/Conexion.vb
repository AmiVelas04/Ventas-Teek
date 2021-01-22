Imports MySql.Data.MySqlClient
Public Class Conexion
    Dim servidor As String = "192.168.0.102"
    'op del servidor 
    Dim bd As String = "VentasTeek"
    'base de datos: ventasteek
    Dim user As String = "Teek"
    'Dim user As String = "root"
    'user nuevo: Teek
    Dim pass As String = "Ventas_Teek_Sis"
    ' Dim pass As String = "Ami_1532"
    'contraseña nueva: Sis_Venta_19
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass & "; SslMode=none"
    Public conn As New MySqlConnection()


    Public Sub iniciar()

        conn.ConnectionString = cadenaconn

    End Sub

    Public Function probar_conn() As String

        Dim mensaje As String
        conn.ConnectionString = cadenaconn
        Try


            conn.Open()
            conn.Close()

            mensaje = "Conexion exitosa"
            Return mensaje


        Catch ex As Exception

            conn.Close()
            mensaje = "Error: " + ex.ToString() + "\n" + cadenaconn
            Return mensaje

        End Try
    End Function
End Class
