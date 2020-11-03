Public Class Respaldo
    Dim carpeta As New FolderBrowserDialog
    Dim MiFecha As String = Format(Date.Now.ToString("dd-MM-yyyy"))

    Dim usuario As String = "root"
    Dim rutaDump As String = "C:\xampp\mysql\bin\mysqldump"
    Dim destino As String

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        carpeta.ShowDialog()
        Dim miCarpeta As String
        If carpeta.SelectedPath <> "" Then
            TxtRuta.Text = carpeta.SelectedPath
            miCarpeta = carpeta.SelectedPath
            destino = """" & miCarpeta.Trim & "\RespaldoBd_" & MiFecha & ".sql" & """"
        End If

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'guardar1()
        guardar2()
        'Guardar3()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub guardar1()
        If TxtRuta.Text <> "" Then

            Dim pro As New ProcessStartInfo(rutaDump, " -u prueba -p1532 prod > """ & destino & """")
            Dim startinfo As ProcessStartInfo = New ProcessStartInfo(rutaDump, " -u prueba -p1532 prod > " & destino & "")


            startinfo.UseShellExecute = False

            startinfo.CreateNoWindow = False
            startinfo.WindowStyle = ProcessWindowStyle.Normal

            startinfo.RedirectStandardOutput = True

            Try


                Dim p As Diagnostics.Process = System.Diagnostics.Process.Start(startinfo)

                '  System.Threading.Thread.Sleep(3000)
                Dim sr As System.IO.StreamReader = p.StandardOutput

                Dim cadenaSalida As String = sr.ReadToEnd()
                sr.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            If IO.File.Exists(destino) Then
                MessageBox.Show("El respaldo se ha realizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRuta.Clear()

            Else
                MessageBox.Show("El respaldo no se ha podido realizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtRuta.Clear()

            End If
        Else
            MessageBox.Show("No se ha seleccionado ninguna carpeta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub guardar2()
        Try
            Dim cadena As String
            cadena = "cmd.exe /k " & rutaDump & " -h 192.168.1.103 -u prueba -p1532  prod > " & destino
            ' MessageBox.Show(cadena)
            Shell(cadena, 0)
            MessageBox.Show("El respaldo se ha realizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtRuta.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            TxtRuta.Clear()
        End Try

    End Sub
    Private Sub Guardar3()
        Try
            Dim p As Process = New Process
            Dim pro As ProcessStartInfo = New ProcessStartInfo("cmd.exe", "/C " & rutaDump & " -u prueba -p1532  prod > " & destino)
            pro.RedirectStandardOutput = True
            pro.UseShellExecute = False
            pro.CreateNoWindow = True

            p.StartInfo = pro
            p.Start()
            Dim resultados As String = p.StandardOutput.ReadToEnd
            p.Close()
            '    MessageBox.Show(resultados)
            MessageBox.Show("El respaldo se ha realizado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub
End Class