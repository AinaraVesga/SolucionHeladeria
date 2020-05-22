Imports CapaNegocio

Public Class FormInicio

    Dim objUsuario As New CNUsuario

    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim usuario As String = txtUsuario.Text
        Dim pw As String = txtPW.Text

        If usuario = "" Or pw = "" Then
            MessageBox.Show("Rellene todos los campos.")
        Else
            Dim ok As Boolean = objUsuario.identificarUsuario(usuario, pw)

            If ok Then
                MessageBox.Show("Se ha identificado correctamente.")
                Dim frm As New FormMain
                Visible = False
                FormMain.ShowDialog()
                Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.")
            End If

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fNuevoUsuario As New FormNuevoUsuario
        AddOwnedForm(fNuevoUsuario)
        fNuevoUsuario.ShowDialog()
    End Sub
End Class