Public Class CrudProd
    Dim este As New principal



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If DGVprod.RowCount >= 1 Then
            DGVprod.Rows.RemoveAt(0)
        End If
        Dim nom As String = TxtNombre.Text
        Dim datos As New DataTable
        Dim total As Integer
        datos = este.buscarpt(nom)
        total = datos.Rows.Count - 1

        DGVprod.DataSource = datos

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        TxtCodigo.Enabled = False
        Dim celda As Integer = DGVprod.ColumnCount
        If celda >= 1 Then
            Dim indice As Integer = DGVprod.CurrentRow.Index

            TxtCodigo.Text = DGVprod.Rows(indice).Cells(0).Value
            TxtNomprod.Text = DGVprod.Rows(indice).Cells(1).Value
            TxtDesc.Text = DGVprod.Rows(indice).Cells(2).Value
            TxtMarc.Text = DGVprod.Rows(indice).Cells(3).Value
            TxtCant.Text = DGVprod.Rows(indice).Cells(4).Value
            TxtPrecioc.Text = DGVprod.Rows(indice).Cells(5).Value
            TxtPrecioV.Text = DGVprod.Rows(indice).Cells(6).Value
            TxtGan.Text = DGVprod.Rows(indice).Cells(7).Value
        Else
            MessageBox.Show("No se ha seleccionado ningun producto", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If








    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        TxtCodigo.Enabled = True
        TxtCodigo.Clear()
        TxtNomprod.Clear()
        TxtDesc.Clear()
        TxtMarc.Clear()
        TxtCant.Clear()
        TxtPrecioc.Clear()
        TxtPrecioV.Clear()
        TxtGan.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtCodigo.Text <> "" Then
            'falta agregar imagen
            Dim codigo As String = TxtCodigo.Text
            Dim datos() As String

            Dim imagen As String
            imagen = TxtCodigo.Text
            Dim extension As String = System.IO.Path.GetExtension(OFD1.FileName)
            Dim nomcomp As String
            If extension <> "" Then
                nomcomp = imagen & extension
            Else
                nomcomp = "0.jpg"
            End If
            If TxtPrecioc.Text <> "" Then
            Else
                TxtPrecioc.Text = "0"
            End If
            If TxtPrecioV.Text <> "" Then
            Else
                TxtPrecioV.Text = "0"
            End If
            If TxtCant.Text <> "" Then
            Else
                TxtCant.Text = "0"
            End If
            If TxtGan.Text <> "" Then
            Else
                TxtGan.Text = "0"
            End If
            datos = {codigo, TxtNomprod.Text, TxtDesc.Text, TxtMarc.Text, TxtCant.Text, TxtPrecioc.Text, TxtPrecioV.Text, TxtGan.Text, nomcomp}

            If este.existep(codigo) Then
                revImagen(imagen)
                este.Updprod(datos)

            Else
                revImagen(imagen)
                este.Addprod(datos)


            End If
            limpiar()

        Else
            MessageBox.Show("No se ha encontrado ningún código de producto")
            limpiar()

        End If


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As String = TxtCodigo.Text
        If este.existep(codigo) Then
            este.borrarp(codigo)
        Else
            MessageBox.Show("Producto no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub BtnSubImagen_Click(sender As Object, e As EventArgs) Handles BtnSubImagen.Click
        OFD1.Title = "Seleccione un archivo de imagen"
        OFD1.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|GIF|*.gif"
        If OFD1.ShowDialog() = DialogResult.OK Then

        Else
            MessageBox.Show("No se Selecciono ningun Archivo!")
        End If

    End Sub
    Private Sub revImagen(ByVal imagen As String)
        Dim extension As String = System.IO.Path.GetExtension(OFD1.FileName)

        Dim NombreFull As String
        NombreFull = imagen & extension
        Dim ruta As String
        If System.IO.Directory.Exists("./imagen") Then

        Else
            System.IO.Directory.CreateDirectory("./imagen")

        End If
        ruta = System.IO.Path.GetFullPath("./imagen/" & NombreFull)

        If System.IO.File.Exists(ruta) Then

            System.IO.File.Delete(ruta)
            If extension = ".jpg" Or extension = ".jpeg" Or extension = ".gif" Or extension = ".png" Then
                Try
                    System.IO.File.Copy(OFD1.FileName, "./imagen/" & imagen & extension)
                Catch ex As Exception
                    MessageBox.Show("./imagen/" & imagen & extension)
                    MessageBox.Show(ex.ToString)
                End Try

            Else
                MessageBox.Show("Imagen no valida/ o inexistente")
            End If
        Else
            If extension = ".jpg" Or extension = ".jpeg" Or extension = ".gif" Or extension = ".png" Then
                System.IO.File.Copy(OFD1.FileName, "./imagen/" & imagen & extension)

            Else
                MessageBox.Show("Imagen no valida/ o inexistente")
            End If
        End If
    End Sub



    Private Sub DGVprod_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If DGVprod.Columns(e.ColumnIndex).Name = "" Then

        End If
    End Sub


End Class