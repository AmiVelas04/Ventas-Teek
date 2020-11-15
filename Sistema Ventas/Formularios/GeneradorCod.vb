Imports System.Drawing.Imaging
Public Class GeneradorCod
    Dim codif As New GeneraCodi
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnGen_Click(sender As Object, e As EventArgs) Handles BtnGen.Click

        Dim bandera As Boolean = True
        Do While bandera = True
            Dim cont As Integer
            Dim cod As String = "2020"
            For cont = 1 To 9
                Dim num As Integer
                Randomize()
                num = CLng((0 - 9) * Rnd() + 9)
                cod = cod & num.ToString
            Next
            TxtCodBarras.Text = cod
            bandera = False
        Loop

    End Sub

    Private Sub BtnImp_Click(sender As Object, e As EventArgs) Handles BtnImp.Click
        Dim texto As String = TxtCodBarras.Text
        Dim mensaje As String = TxtTexto.Text
        Try
            Dim alto As Single = 40
            Dim bm As Bitmap = Nothing
            bm = codif.codigob(texto, True, alto, mensaje)
            ' Dim CodecInfo As ImageCodecInfo = GetEncoderInfo("image/jpeg")
            ' PcbCod.Image = bm
            PcbCod.BackgroundImage = bm
            Dim imagen As Image = PcbCod.BackgroundImage




            imagen.Save("C:\Users\DevMax\Documents\eres.jpg")
            Dim cantidadeti As Integer
            cantidadeti = NudEtiqueta.Value
            codif.imprimircod(mensaje, cantidadeti)

            '  bm.Save("c:\\eres.jpg", ImageFormat.Bmp)



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class