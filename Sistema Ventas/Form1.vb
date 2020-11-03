Public Class Form1

   

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tmr1.Enabled = True
    End Sub

    Private Sub Tmr1_Tick(sender As Object, e As EventArgs) Handles Tmr1.Tick
        Tmr1.Enabled = False
        Me.Hide()
        Dim v As New Ventas
        'v.Show()
        Dim ini As New Inicio
        ini.Show()





    End Sub
End Class
