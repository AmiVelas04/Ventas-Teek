Public Class EncFact
    Public Property Numero() As Integer
    Public Property Nombre() As String
    Public Property Nit() As String
    Public Property Direccion() As String
    Public Property Vendedor As String
    Public Property Total() As Decimal
    Public Property FechaFacturacion() As String
    Public Property tipov As String

    Public Detalle As New List(Of DetFact)()

End Class
