Imports CapaNegocio
Imports CapaEntidad
Public Class FormMain
    Dim objCapaNegocio As New CNClientes
    Dim objCapaNegocioP As New CNProductos
    Dim objCapaNegocioS As New CNStock
    Dim objCapaNegocioV As New CNVentas

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientes()
        listarProductos()
        listarStock()
        listarVentas()
        panClientes.Show()
        panProductos.Hide()
        panStock.Hide()
        panVentas.Hide()

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        panClientes.Show()
        panProductos.Hide()
        panStock.Hide()
        panVentas.Hide()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        panClientes.Hide()
        panProductos.Show()
        panStock.Hide()
        panVentas.Hide()
    End Sub

    Private Sub btnStock_Click_1(sender As Object, e As EventArgs) Handles btnStock.Click
        panClientes.Hide()
        panProductos.Hide()
        panStock.Show()
        panVentas.Hide()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        panClientes.Hide()
        panProductos.Hide()
        panStock.Hide()
        panVentas.Show()
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
        listarClientes()
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

    Private Sub btnNuevoS_Click(sender As Object, e As EventArgs) Handles btnNuevoS.Click
        Dim fAnadirStock As New FormAñadirStock
        AddOwnedForm(fAnadirStock)
        fAnadirStock.ShowDialog()
        listarStock()

    End Sub

    Public Sub editarStockUnidades()
        If dgvProductos.SelectedRows.Count = 0 Then
            Dim row = dgvStock.CurrentRow
            Dim idproducto = row.Cells(0).Value.ToString
            Dim idenvase = row.Cells(1).Value.ToString
            Dim nlote = row.Cells(2).Value.ToString
            Dim num As Integer = row.Cells(3).Value.ToString
            Dim consumo = row.Cells(4).Value.ToString
            Dim unidades = row.Cells(5).Value.ToString
            Dim precio As Double = row.Cells(6).Value.ToString

            Dim s As New CEStock(idproducto, idenvase, nlote, num, consumo, unidades, precio)

            Dim fEditarStock As New FormEditarStock(s)
            AddOwnedForm(fEditarStock)
            fEditarStock.ShowDialog()
            listarStock()

        Else
            MessageBox.Show("Por favor seleccione una fila.")
        End If
    End Sub

    Private Sub btnEditarS_Click(sender As Object, e As EventArgs) Handles btnEditarS.Click
        editarStockUnidades()
    End Sub

    Private Sub dgvStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStock.CellContentClick
        editarStockUnidades()
    End Sub

    Private Sub btnEliminarS_Click(sender As Object, e As EventArgs) Handles btnEliminarS.Click
        If dgvProductos.SelectedRows.Count = 0 Then
            Dim row = dgvStock.CurrentRow
            Dim idproducto = row.Cells(0).Value.ToString
            Dim idenvase = row.Cells(1).Value.ToString
            Dim nlote = row.Cells(2).Value.ToString

            Dim fEliminarStock As New FormEliminarStock(idproducto, idenvase, nlote)
            AddOwnedForm(fEliminarStock)
            fEliminarStock.ShowDialog()
            listarStock()

        Else
            MessageBox.Show("Por favor seleccione una fila.")
        End If


    End Sub

    ' LISTENERS DEL PANEL DE VENTAS
    Sub listarVentas()
        dgvVentas.DataSource = objCapaNegocioV.obtenerPedidos
    End Sub

    Private Sub txtBuscarV_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarV.TextChanged
        dgvVentas.DataSource = objCapaNegocioV.obtenerPedidosFiltro(txtBuscarV.Text)
    End Sub

    Private Sub btnNuevaV_Click(sender As Object, e As EventArgs) Handles btnNuevaV.Click
        Try
            objCapaNegocioV.eliminarTablaEditarStock()
        Catch ex As Exception
            Console.WriteLine("No existe tabla.")
        End Try
        objCapaNegocioV.crearTablaEditarStock()
        Dim fNuevoPedido As New FormNuevoPedido
        AddOwnedForm(fNuevoPedido)
        fNuevoPedido.ShowDialog()
        listarVentas()

    End Sub

    Private Sub btnEliminarV_Click(sender As Object, e As EventArgs) Handles btnEliminarV.Click

    End Sub
End Class