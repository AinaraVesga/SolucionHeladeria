Imports CapaEntidad
Imports CapaNegocio

Public Class FormNuevoPedido

    Private objVentas As New CNVentas
    Private clienteBloqueado As Boolean = False

    Private Sub FormNuevoPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIdPedido.Text = objVentas.nuevoIDPedido
        listarClientes()
        listarStock()
        listarEnvases()
        txtUniMax.Text = objVentas.unidadesDisponibles(objVentas.listarStock(0)(0), objVentas.listarEnvases(objVentas.listarStock(0)(0))(0)(0))
        txtPrecio.Text = objVentas.precioEnvase(objVentas.listarEnvases(objVentas.listarStock(0)(0))(0)(0))(0)(0)
        txtBI.Text = objVentas.calcularBI(1, txtPrecio.Text)
        numUnidades.Maximum = objVentas.unidadesDisponibles(objVentas.listarStock(0)(0), objVentas.listarEnvases(objVentas.listarStock(0)(0))(0)(0))

        ' creamos la tabla que se muestra en el datagridview
        Try
            objVentas.eliminarTablaIntermedia()
        Catch ex As Exception
            Console.WriteLine("No existe esa tabla")
        End Try
        objVentas.crearTablaIntermedia()
        dgvLineas.DataSource = objVentas.listarTablaIntermedia()
    End Sub

    Sub listarClientes()
        Dim dv As DataTable = objVentas.listarClientes
        cbxCliente.DataSource = dv
        cbxCliente.DisplayMember = "NOMBRE"
        cbxCliente.ValueMember = "IDCLIENTE"
    End Sub

    Sub listarStock()
        Dim dv As DataTable = objVentas.listarStock
        cbxProducto.DataSource = dv
        cbxProducto.DisplayMember = "NOMBRE"
        cbxProducto.ValueMember = "IDPRODUCTO"
    End Sub

    Sub listarEnvases()
        Dim dv As DataTable = objVentas.listarEnvases(txtIdProducto.Text)
        cbxEnvase.DataSource = dv
        cbxEnvase.DisplayMember = "CAPACIDAD"
        cbxEnvase.ValueMember = "IDENVASE"
    End Sub

    Private Sub cbxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCliente.SelectedIndexChanged
        Try
            txtIdCliente.Text = cbxCliente.SelectedValue
        Catch ex As Exception
            txtIdCliente.Text = objVentas.listarClientes(0)(0)
        End Try
    End Sub

    Private Sub cbxProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProducto.SelectedIndexChanged
        Try
            txtIdProducto.Text = cbxProducto.SelectedValue
            listarEnvases()
            txtUniMax.Text = objVentas.unidadesDisponibles(cbxProducto.SelectedValue, cbxEnvase.SelectedValue)
            numUnidades.Maximum = txtUniMax.Text
        Catch ex As Exception
            txtIdProducto.Text = objVentas.listarStock(0)(0)
        End Try
    End Sub

    Private Sub cbxEnvase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEnvase.SelectedIndexChanged
        Try
            txtIdEnvase.Text = cbxEnvase.SelectedValue
            txtUniMax.Text = objVentas.unidadesDisponibles(cbxProducto.SelectedValue, cbxEnvase.SelectedValue)
            txtPrecio.Text = objVentas.precioEnvase(cbxEnvase.SelectedValue)(0)(0)
            txtBI.Text = objVentas.calcularBI(numUnidades.Value, txtPrecio.Text)
            numUnidades.Maximum = txtUniMax.Text
        Catch ex As Exception
            txtIdEnvase.Text = objVentas.listarEnvases(objVentas.listarStock(0)(0))(0)(0)
        End Try
    End Sub

    Private Sub numUnidades_ValueChanged(sender As Object, e As EventArgs) Handles numUnidades.ValueChanged
        Try
            txtBI.Text = objVentas.calcularBI(numUnidades.Value, txtPrecio.Text)
        Catch ex As Exception
            txtBI.Text = objVentas.calcularBI(1, objVentas.precioEnvase(objVentas.listarEnvases(objVentas.listarStock(0)(0))(0)(0))(0)(0))
        End Try
    End Sub

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim idpedido As String = txtIdPedido.Text
        Dim idproducto As String = txtIdProducto.Text
        Dim idenvase As String = txtIdEnvase.Text
        Dim unidades As Integer = numUnidades.Value
        Dim precio As Double = txtPrecio.Text
        Dim bi As Double = txtBI.Text

        Dim ok As Boolean = objVentas.añadirUnidades(idpedido, idproducto, idenvase, unidades, precio, bi)

        If ok Then
            MessageBox.Show("Se ha añadido correctamente.")
            dgvLineas.DataSource = objVentas.listarTablaIntermedia()
            listarStock()
            listarEnvases()
            If clienteBloqueado = False Then
                cbxCliente.Enabled = False
                clienteBloqueado = True
            End If
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvLineas.Rows.Count > 1 Then
            Dim row = dgvLineas.CurrentRow
            Dim idpedido As String = row.Cells(0).Value.ToString
            Dim idproducto As String = row.Cells(1).Value.ToString
            Dim idenvase As String = row.Cells(2).Value.ToString
            Dim nlote As String = row.Cells(3).Value.ToString
            Dim unidades As Integer = row.Cells(4).Value
            Dim precio As Double = row.Cells(5).Value
            Dim bi As Double = row.Cells(6).Value

            Dim linea As New CELinea(idpedido, idproducto, idenvase, nlote, unidades, precio, bi)

            Dim ok = objVentas.eliminarLinea(linea)

            If ok Then
                MessageBox.Show("Se ha eliminado correctamente.")
                dgvLineas.DataSource = objVentas.listarTablaIntermedia()
                listarStock()
                listarEnvases()
            Else
                MessageBox.Show("Ha ocurrido un error.")
            End If
        Else
            MessageBox.Show("No existen registros para eliminar.")
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idpedido As String = txtIdPedido.Text
        Dim idcliente As String = txtIdCliente.Text


        Dim ok = objVentas.añadirPedido(idpedido, idcliente)

        If ok Then
            MessageBox.Show("Se ha añadido correctamente.")
            Close()
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim fNuevoCliente As New FormNuevoCliente
        AddOwnedForm(fNuevoCliente)
        fNuevoCliente.ShowDialog()
        listarClientes()
    End Sub
End Class