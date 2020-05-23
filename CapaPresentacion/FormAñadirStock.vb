Imports CapaNegocio
Imports CapaEntidad

Public Class FormAñadirStock
    Dim objStock As New CNStock
    Dim tablaEnvases As DataTable
    Dim numero As Integer
    Dim idproducto As String

    ' FUNCIONES DEL PANEL MAIN 1
    Private Sub FormAñadirStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProd()
        listarEnvases()
        panBody2.Visible = False
        panBody1.Visible = True

    End Sub

    Public Sub listarProd()
        Dim tablaProd = objStock.listarProductos
        cbxProducto.DataSource = tablaProd
        cbxProducto.DisplayMember = "NOMBRE"
        cbxProducto.ValueMember = "IDPRODUCTO"
    End Sub

    Private Sub cbxProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProducto.SelectedIndexChanged
        Dim dv As DataRowView = cbxProducto.SelectedItem
        Dim id As String = dv.Row("IDPRODUCTO")
        Dim prod As String = dv.Row("NOMBRE")

        idproducto = id
        txtID.Text = id
        Dim lote = objStock.setNumeroLote(id)
        txtLote.Text = lote.nlote
        numero = lote.numero
        txtProducto.Text = prod
        txtID2.Text = txtID.Text
        txtLote2.Text = txtLote.Text
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Width = 1200
        Height = 487
        panBody1.Visible = False
        panBody2.Visible = True

        objStock.crearTablaIntermedia()
        dgvNuevoStock.DataSource = objStock.listarTablaIntermedia()
        objStock.confumoPref()
    End Sub

    ' FUNCIONES DEL PANEL MAIN 2
    Public Sub listarEnvases()
        tablaEnvases = objStock.listarEnvases
        cbxEnvase.DataSource = tablaEnvases
        cbxEnvase.DisplayMember = "CAPACIDAD"
        cbxEnvase.ValueMember = "IDENVASE"
    End Sub

    Private Sub cbxEnvase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEnvase.SelectedIndexChanged

        Dim idenvase = cbxEnvase.SelectedValue
        'MsgBox(cbxEnvase.SelectedValue.ToString)
        Dim rows As DataRow()
        'MsgBox(idenvase)
        Try
            rows = tablaEnvases.Select("IDENVASE = '" + idenvase + "'")
        Catch ex As Exception
            rows = tablaEnvases.Select("IDENVASE = 'E001'")
        End Try

        Dim row = rows(0)
        Dim precio As Double = row("PRECIOENVASE")
        txtPrecio.Text = precio

        'MsgBox(precio)
    End Sub

    ' Añadir lineas de stock a la tabla intermedia
    Private Sub btnAñadir2_Click(sender As Object, e As EventArgs) Handles btnAñadir2.Click


        Dim idproducto As String = txtID2.Text
        Dim idenvase As String = cbxEnvase.SelectedValue
        Dim nlote As String = txtLote.Text
        Dim num As Integer = numero
        Dim consumop As String = objStock.confumoPref()
        Dim unidades As Integer = numUnidades.Value
        Dim precio As Double = txtPrecio.Text

        'Console.WriteLine(idproducto + " " + idenvase + " " + nlote + " " + CStr(num) + " " + consumop + " " + unidades + " " + CStr(precio))

        Dim ok = objStock.insertarTablaIntermedia(idproducto, idenvase, nlote, num, consumop, unidades, precio)
        dgvNuevoStock.DataSource = objStock.listarTablaIntermedia()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        objStock.insertarStock(idproducto, numero)
        Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvNuevoStock.Rows.Count > 1 Then
            Dim row = dgvNuevoStock.CurrentRow
            Dim idproducto = row.Cells(0).Value.ToString
            Dim idenvase = row.Cells(1).Value.ToString
            Dim nlote = row.Cells(2).Value.ToString

            Dim ok = objStock.deleteTablaIntermedia(idproducto, idenvase, nlote)

            If ok Then
                MessageBox.Show("Se ha eliminado correctamente.")
            Else
                MessageBox.Show("Ha ocurrido un error.")
            End If

            dgvNuevoStock.DataSource = objStock.listarTablaIntermedia()
        Else
            MessageBox.Show("No existen registros para eliminar.")
        End If

    End Sub
End Class