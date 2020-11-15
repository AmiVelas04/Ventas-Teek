Public Class Ventas

    Friend dataprod() As String



    Private Sub TmrMostrar_Tick(sender As Object, e As EventArgs) Handles TmrMostrar.Tick
        Dim val As Integer
        val = panelLat.Width
        If panelLat.Width >= 138 Then
            TmrMostrar.Enabled = False
        Else
            val += 15
            panelLat.Width = val
        End If
    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles BotonMenu.Click
        If panelLat.Width <= 48 Then
            TmrMostrar.Enabled = True
        ElseIf panelLat.Width >= 138 Then
            TmrOcultar.Enabled = True



        End If
    End Sub

    Private Sub TmrOcultar_Tick(sender As Object, e As EventArgs) Handles TmrOcultar.Tick
        Dim val As Integer
        val = panelLat.Width
        If panelLat.Width <= 48 Then
            TmrOcultar.Enabled = False
        Else
            val -= 15
            panelLat.Width = val
        End If
    End Sub


    Private Sub abrir_from(ByVal formhijo As Object)
        If Me.PanelCentral.Controls.Count >= 1 Then
            Me.PanelCentral.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        Me.PanelCentral.Controls.Add(fh)
        Me.PanelCentral.Tag = fh
        fh.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        Dim prodform As New Productos
        abrir_from(prodform)
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click

        If (MessageBox.Show("¿Desea salir del programa?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes) Then
            End
        End If
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        abrir_from(New CrudProd)

    End Sub

    Private Sub PanelCentral_Paint(sender As Object, e As PaintEventArgs) Handles PanelCentral.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        abrir_from(New cliente)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        abrir_from(New Usuarios)
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbUsu.Text = LbUsu.Text & " " & VariablesUNI.Nombre
        If VariablesUNI.nivel = 2 Or VariablesUNI.nivel = 1 Then
            BtnVentas.Visible = True
            BtnAbono.Visible = True
            BtnCliente.Visible = True
            BtnUsuario.Visible = True
            btnInventario.Visible = True
            BtnReportes.Visible = True
            BtnCaja.Visible = True
            BtnGuardar.Visible = True

        ElseIf nivel = 3 Then
            BtnVentas.Visible = True
            BtnAbono.Visible = True
            BtnCliente.Visible = False
            BtnUsuario.Visible = False
            btnInventario.Visible = False
            BtnReportes.Visible = False
            BtnCaja.Visible = False
            BtnGuardar.Visible = False
        End If

    End Sub

    Private Sub BtnAbono_Click(sender As Object, e As EventArgs)
        abrir_from(New FrmCobro)
    End Sub

    Private Sub BtnReportes_Click(sender As Object, e As EventArgs) Handles BtnReportes.Click
        abrir_from(New ImpReportes)
    End Sub

    Private Sub BtnABono_Click_1(sender As Object, e As EventArgs) Handles BtnABono.Click
        abrir_from(New FrmCobro)
    End Sub

    Private Sub BtnGastos_Click(sender As Object, e As EventArgs) Handles BtnGastos.Click
        Dim g As New Gastos
        g.Show()

    End Sub

    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles BtnCaja.Click
        Dim caja As New CorteCaja
        caja.Show()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim res As New Respaldo()
        res.Show()

    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnCod_Click(sender As Object, e As EventArgs) Handles BtnCod.Click
        'abrir_from(New GeneradorCod)
        Dim codi As New GeneradorCod
        codi.ShowDialog()

    End Sub
End Class