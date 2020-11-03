Imports System.Runtime.InteropServices
Public Class Inicio
    Dim iniciar As New Logueo
    Friend v As New Ventas
#Region "Form Behaviors"
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()

    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region



#Region "Customize Copntrols"

    Private Sub CustomizeControls()

        TxtUsu.Size = New Size(224, 30)
        TxtPass.Size = New Size(224, 30)
        TxtPass.UseSystemPasswordChar = True
    End Sub

#End Region

    Private Sub BtnIngresar_Paint(sender As Object, e As PaintEventArgs) Handles BtnIngresar.Paint
        Dim ButtonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()

        Dim myrectangle As Rectangle = BtnIngresar.ClientRectangle
        myrectangle.Inflate(0, 15)
        ButtonPath.AddEllipse(myrectangle)
        BtnIngresar.Region = New Region(ButtonPath)


    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeControls()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim usu As String
        Dim pass As String
        usu = TxtUsu.Text
        pass = TxtPass.Text
        If iniciar.credenciales(usu, pass) Then

            Me.Hide()
            TxtPass.Clear()
            TxtUsu.Clear()
            v.Show()
        Else
            TxtPass.Clear()
            TxtUsu.Clear()
        End If


    End Sub
End Class