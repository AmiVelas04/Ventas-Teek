Imports MySql.Data.MySqlClient
Module VariablesUNI

    Public cod As Integer
    Public Nombre As String
    Public nivel As Integer
    Dim servidor As String = "localhost"
    Dim bd As String = "prod"
    Dim user As String = "creditos"
    Dim pass As String = "Cre-2020-Sis"
    Dim cadenaconn As String = "server=" & servidor & ";" & "database=" & bd & ";" & "user id=" & user & ";" & "password=" & pass
    Dim conn As New MySqlConnection(cadenaconn)

#Region "Productos"
    Public estado As Boolean = False
    Public codp As String
    Public nomp As String
    Public descp As String
    Public marcp As String
    Public cantp As Integer = 1
    Public precp As Decimal
    Public totP As Decimal
    Public Imgp As String
    Public DisP As Integer



#End Region
#Region "Clientes"
    Public estadocli As Boolean = False
    Public codc As String
    Public nomc As String
    Public Nitc As String

#End Region



    Public Function horactual()
        Dim mihora As String
        mihora = DateTime.Now.ToString("HH:mm:ss")

        Return mihora
    End Function
    Public Function diaactual()
        Dim miDia As String
        miDia = DateTime.Now.ToString("yyyy/MM/dd")
        Return miDia
    End Function
End Module
