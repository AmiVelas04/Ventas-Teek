Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.Barcode
Imports MySql.Data.MySqlClient

Public Class GeneraCodi
    Dim conec As New Conexion

    Private Sub buscar(ByVal consulta As String, ByRef datos As DataTable)
        conec.iniciar()
        datos.Dispose()

        Try
            Dim adap As New MySqlDataAdapter(consulta, conec.conn)
            adap.Fill(datos)
            adap.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub
    Private Function consultag(ByVal consulta As String) As Boolean
        conec.iniciar()
        Dim com As New MySqlCommand
        com.Connection = conec.conn
        com.CommandText = consulta
        com.CommandType = CommandType.Text
        Try
            conec.conn.Open()
            com.ExecuteNonQuery()
            conec.conn.Close()
            Return True
        Catch ex As Exception
            conec.conn.Close()
            MessageBox.Show(ex.ToString)
            Return False
        End Try
    End Function
    Public Function codigob(ByVal codigo As String, Optional ByVal Contexto As Boolean = False, Optional ByVal alto As Single = 0, Optional ByVal texto As String = "")
        Dim barcode As New Barcode128
        barcode.StartStopText = True
        If alto <> 0 Then
            barcode.BarHeight = alto

        End If
        barcode.Code = codigo
        barcode.ChecksumText = True
        barcode.CodeType = BarcodeEANSUPP.UPCA

        Try
        Dim letras As String
            letras = codigo & Chr(13) & texto
            Dim talla As New Size
            talla.Width = 200
            talla.Height = 75
            Dim bm As New Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White), talla)
            Dim bmt As Image
            bmt = New Bitmap(bm.Width, bm.Height + 14)
            Dim g As Graphics = Graphics.FromImage(bmt)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 14)
            Dim pintartexto As New Font("arial", 10)
            Dim brocha As New SolidBrush(Color.Black)
            Dim stringsize As New SizeF

            stringsize = g.MeasureString(codigo, pintartexto)
            Dim centrox As Single
            centrox = (bmt.Width - stringsize.Width) / 2
            Dim x As Single = centrox
            Dim y As Single = bm.Height
            Dim drawformat As New StringFormat
            drawformat.FormatFlags = StringFormatFlags.NoWrap
            g.DrawImage(bm, 0, 0)
            Dim ncode As String = codigo.Substring(1, codigo.Length - 2)
            g.DrawString(codigo, pintartexto, brocha, x, y, drawformat)
            Return bmt


        Catch ex As Exception
            Throw New Exception("Error al genera el codigo:" & ex.ToString)
        End Try

    End Function


    Public Sub imprimircod(ByVal texto As String, ByVal cant As Integer)
        Dim enca As New EncProd
        Dim cantfil As Integer, ultcol As Integer
        cantfil = (cant - (cant Mod 5)) / 5
        If (cant Mod 5) > 0 Then
            cantfil += 1
            ultcol = cant Mod 5
        Else
            ultcol = 5
        End If
        Dim fila As Integer, columna As Integer
        Dim titulo(cantfil, 5) As String
        Dim imgcod(cantfil, 5) As String
        For fila = 0 To (cantfil - 1)
            For columna = 0 To 4
                titulo(fila, columna) = ""
                imgcod(fila, columna) = ""
            Next
        Next

        For fila = 0 To (cantfil - 1)
            If fila = (cantfil - 1) Then
                For columna = 0 To (ultcol - 1)
                    titulo(fila, columna) = texto
                    imgcod(fila, columna) = "D:\Pictures\C.jpg"
                    'imgcod(fila, columna) = "C:\Users\Usuario 1\Pictures\C.jpg"
                    'imgcod(fila, columna) = "C:\Users\Amk\Pictures\C.jpg"

                Next
            Else
                For columna = 0 To 4
                    titulo(fila, columna) = texto
                    imgcod(fila, columna) = "D:\Pictures\C.jpg"
                    'imgcod(fila, columna) = "C:\Users\Usuario 1\Pictures\C.jpg"
                    'imgcod(fila, columna) = "C:\Users\Amk\Pictures\C.jpg"
                Next
            End If
        Next

        For fila = 0 To cantfil - 1
            Dim etiq As New EtiquetaClase
            etiq.Etiqueta1 = titulo(fila, 0)
            etiq.Codigo1 = imgcod(fila, 0)
            etiq.Etiqueta2 = titulo(fila, 1)
            etiq.Codigo2 = imgcod(fila, 1)
            etiq.Etiqueta3 = titulo(fila, 2)
            etiq.Codigo3 = imgcod(fila, 2)
            etiq.Etiqueta4 = titulo(fila, 3)
            etiq.Codigo4 = imgcod(fila, 3)
            etiq.Etiqueta5 = titulo(fila, 4)
            etiq.Codigo5 = imgcod(fila, 4)
            enca.Etiqueta.Add(etiq)


        Next
        Dim ventana As New ImpCodigoB
        ventana.encabezado.Add(enca)
        ventana.code = enca.Etiqueta
        ventana.Show()




    End Sub


    Public Function existecod(ByVal cod As String) As Boolean
        Dim datos As New DataTable
        Dim consulta As String
        consulta = "select COUNT(*) FROM producto p WHERE p.CODIGO_P='" & cod & "'"
        buscar(consulta, datos)
        Dim codi As Integer
        codi = Integer.Parse(datos.Rows(0)(0).ToString)
        If codi > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
