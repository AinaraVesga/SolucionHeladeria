Public Class FormInicio
    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim frm As New FormMain
        FormMain.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fNuevoUsuario As New FormNuevoUsuario
        AddOwnedForm(fNuevoUsuario)
        fNuevoUsuario.ShowDialog()
    End Sub
End Class