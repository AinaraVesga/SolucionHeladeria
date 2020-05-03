Imports CapaNegocio
Public Class Cliente

    Dim objCapaNegocio As New CNClientes

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
    End Sub

    Sub listarClientes()
        dgvClientes.DataSource = objCapaNegocio.ObtenerClientes()
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim fNuevoCliente As New FormNuevoCliente()
        fNuevoCliente.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dgvClientes.DataSource = objCapaNegocio.ObtenerClientesFiltro(txtBuscar.Text)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim row As DataRow = DirectCast(dgvClientes.CurrentRow.DataBoundItem, DataRow)
        Dim cliente = objCapaNegocio.generarCliente(row)
        FormEditarCliente.Show()

    End Sub
End Class