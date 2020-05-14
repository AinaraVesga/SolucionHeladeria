Imports CapaNegocio
Imports CapaEntidad
Public Class FormMain
    Dim objCapaNegocio As New CNClientes
    Dim objCapaNegocioP As New CNProductos
    Dim objCapaNegocioS As New CNStock

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
        listarProductos()
        listarStock()
        panClientes.Show()
        panProductos.Hide()
        panStock.Hide()

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        panClientes.Show()
        panProductos.Hide()
        panStock.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        panClientes.Hide()
        panProductos.Show()
        panStock.Hide()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStock_Click_1(sender As Object, e As EventArgs) Handles btnStock.Click
        panClientes.Hide()
        panProductos.Hide()
        panStock.Show()
    End Sub


    ' LISTENERS DEL PANEL CLIENTES
    Sub listarClientes()
        dgvClientes.DataSource = objCapaNegocio.ObtenerClientes()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        dgvClientes.DataSource = objCapaNegocio.ObtenerClientesFiltro(txtBuscar.Text)
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim fNuevoCliente As New FormNuevoCliente()
        AddOwnedForm(fNuevoCliente)
        fNuevoCliente.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditarE.Click
        editarClienteCampos()
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        editarClienteCampos()
    End Sub

    ' Funcion para pasar los datos al formulario de editar cliente
    Public Sub editarClienteCampos()
        If dgvClientes.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim id = row.Cells(0).Value.ToString
            Dim nombre = row.Cells(1).Value.ToString
            Dim direccion = row.Cells(2).Value.ToString
            Dim poblacion = row.Cells(3).Value.ToString
            Dim telefono = row.Cells(4).Value.ToString
            Dim cif = row.Cells(5).Value.ToString
            Dim email = row.Cells(6).Value.ToString
            Dim cuenta = row.Cells(7).Value.ToString
            Dim re = row.Cells(8).Value
            Dim fa = row.Cells(9).Value.ToString

            Dim c As New CECliente(id, nombre, direccion, poblacion, telefono, cif, email, cuenta, re, fa)
            Dim fEditarCliente As New FormEditarCliente(c)
            AddOwnedForm(fEditarCliente)
            fEditarCliente.ShowDialog()
        Else
            MessageBox.Show("Por favor seleccione una fila.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvClientes.SelectedRows.Count = 0 Then
            Dim row = dgvClientes.CurrentRow
            Dim id = row.Cells(0).Value.ToString
            Dim nombre = row.Cells(1).Value.ToString

            Dim fEliminarCliente As New FormEliminarCliente(id, nombre)
            AddOwnedForm(fEliminarCliente)
            fEliminarCliente.ShowDialog()

        Else
            MessageBox.Show("Por favor seleccione una fila.")
        End If
    End Sub


    ' LISTENERS DEL PANEL DE PRODUCTOS
    Sub listarProductos()
        dgvProductos.DataSource = objCapaNegocioP.ObtenerProductos()
    End Sub

    Private Sub txtBuscarP_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarP.TextChanged
        dgvProductos.DataSource = objCapaNegocioP.ObtenerProductosFiltro(txtBuscarP.Text)
    End Sub

    Private Sub btnAñadirP_Click(sender As Object, e As EventArgs) Handles btnAñadirP.Click
        Dim fNuevoProducto As New FormNuevoProducto
        AddOwnedForm(fNuevoProducto)
        fNuevoProducto.ShowDialog()
        listarProductos()
    End Sub

    Public Sub editarProductoCampos()
        If dgvProductos.SelectedRows.Count = 0 Then
            Dim row = dgvProductos.CurrentRow
            Dim id = row.Cells(0).Value.ToString
            Dim nombre = row.Cells(1).Value.ToString

            Dim p As New CEProducto(id, nombre)
            Dim fEditarProducto As New FormEditarProducto(p)
            AddOwnedForm(fEditarProducto)
            fEditarProducto.ShowDialog()
            listarProductos()
        Else
            MessageBox.Show("Por favor seleccione una fila.")
        End If
    End Sub

    Private Sub btnEditarP_Click(sender As Object, e As EventArgs) Handles btnEditarP.Click
        editarProductoCampos()
    End Sub

    Private Sub dgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        editarProductoCampos()
    End Sub

    Private Sub btnEliminarP_Click(sender As Object, e As EventArgs) Handles btnEliminarP.Click
        Dim row = dgvProductos.CurrentRow
        Dim id = row.Cells(0).Value.ToString
        Dim nombre = row.Cells(1).Value.ToString

        Dim fEliminarProducto As New FormEliminarProducto(id, nombre)
        AddOwnedForm(fEliminarProducto)
        fEliminarProducto.ShowDialog()
        listarProductos()

    End Sub

    ' LISTENERS DEL PANEL DE STOCK
    Sub listarStock()
        dgvStock.DataSource = objCapaNegocioS.ObtenerStock()
    End Sub

    Private Sub txtBuscarS_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarS.TextChanged
        dgvStock.DataSource = objCapaNegocioS.ObtenerStockFiltro(txtBuscarS.Text)
    End Sub
End Class