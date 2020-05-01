Imports CapaNegocio
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
    End Sub

    Sub listarClientes()
        Dim objCapaNegocio As New CNClientes
        dgvClientes.DataSource = objCapaNegocio.ObtenerClientes()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class