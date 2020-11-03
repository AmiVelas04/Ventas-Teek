Imports MySql.Data.MySqlClient

Public Class Report
    Dim servidor As String = "localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-2020-Sis"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)
    Protected Sub buscar(ByVal consulta As String, ByRef tabla As DataTable)
        Try
            Dim adap As New MySqlDataAdapter(consulta, conn)
            tabla.Dispose()
            adap.Fill(tabla)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            MessageBox.Show(consulta)
        End Try

    End Sub

    Private Function consulgeneral(consulta) As Boolean
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
    Public Function reporteDiario(ByVal fecha As String, ByVal tipo As String) As DataTable
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "Select v.comprobante,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as total, u.nombre, v.tipo 
        from venta v join usuario u on u.COD_USU=v.COD_USU where v.fecha='" & fecha & "' and v.tipo='" & tipo & "'"
        buscar(consulta, datos)
        Return datos

    End Function

    Public Function reporteMensual(ByVal fech1 As String, ByVal fech2 As String, ByVal tipo As String) As DataTable
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "Select v.comprobante,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as total, u.nombre, v.tipo,v.fecha 
        from venta v join usuario u on u.COD_USU=v.COD_USU 
        where v.fecha<'" & fech2 & "' and v.fecha>'" & fech1 & "' and tipo='" & tipo & "'"
        buscar(consulta, datos)
        Return datos

    End Function
    Public Function reporteAnual(ByVal fech1 As String, ByVal fech2 As String, ByVal tipo As String) As DataTable
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "Select v.comprobante,(select sum(vd.cantidad*vd.precio) from ventadetalle vd where vd.COMPROBANTE=v.COMPROBANTE ) as total, u.nombre, v.tipo,v.fecha 
        from venta v join usuario u on u.COD_USU=v.COD_USU 
        where v.fecha<'" & fech2 & "' and v.fecha>'" & fech1 & "' and tipo='" & tipo & "'"
        buscar(consulta, datos)
        Return datos

    End Function
End Class
