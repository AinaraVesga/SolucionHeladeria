Public Class FormInicio
    Private Sub btnEmpezar_Click(sender As Object, e As EventArgs) Handles btnEmpezar.Click
        Dim frm As New FormClientes
        FormClientes.ShowDialog()

    End Sub
End Class