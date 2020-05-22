Imports CapaEntidad
Imports CapaNegocio

Public Class FormNuevoUsuario

    Dim objUsuario As New CNUsuario

    Private Sub FormNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarID()
    End Sub

    Public Sub generarID()
        Dim id As Guid = Guid.NewGuid
        txtIDUsuario.Text = id.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim id As String = txtIDUsuario.Text
        Dim usuario As String = txtUsuario.Text
        Dim pw As String = txtPW.Text
        Dim pw2 As String = txtPW2.Text

        If id = "" Or usuario = "" Or pw = "" Or pw2 = "" Then
            MessageBox.Show("Rellene todos los campos.")
        ElseIf pw <> pw2 Then
            MessageBox.Show("Las contraseñas no coinciden.")
        Else
            Dim newUsuario As New CEUsuario(id, usuario, pw)
            Dim ok As Boolean = objUsuario.nuevoUsuario(newUsuario)

            If ok Then
                MessageBox.Show("Se ha registrado correctamente.")
            Else
                MessageBox.Show("Ha ocurrido un error.")
            End If

            Close()
        End If


    End Sub
End Class