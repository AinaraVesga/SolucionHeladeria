Imports CapaEntidad
Imports CapaNegocio

Public Class FormNuevoPedido

    Dim objVentas As New CNVentas

    Private Sub FormNuevoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdPedido.Text = objVentas.nuevoIDPedido
        listarClientes()
    End Sub

    Sub listarClientes()
        Dim dv As DataTable = objVentas.listarClientes
        cbxCliente.DataSource = dv
        cbxCliente.DisplayMember = "NOMBRE"
        cbxCliente.ValueMember = "IDCLIENTE"
    End Sub

    Private Sub cbxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCliente.SelectedIndexChanged
        Try
            txtIdCliente.Text = cbxCliente.SelectedValue
        Catch ex As Exception
            txtIdCliente.Text = objVentas.listarClientes(0)(0)
        End Try

    End Sub
End Class