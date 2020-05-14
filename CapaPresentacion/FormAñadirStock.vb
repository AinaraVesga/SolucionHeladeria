Imports CapaNegocio

Public Class FormAñadirStock
    Dim objStock As New CNStock

    ' FUNCIONES DEL PANEL MAIN 1
    Private Sub FormAñadirStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProd()
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
        txtID.Text = id
        txtLote.Text = objStock.setNumeroLote(id)
        txtProducto.Text = prod
        txtID2.Text = txtID.Text
        txtLote2.Text = txtLote.Text
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Width = 805
        Height = 487
        panBody1.Visible = False
        panBody2.Visible = True
        listarEnvases()
    End Sub

    ' FUNCIONES DEL PANEL MAIN 2
    Public Sub listarEnvases()
        Dim tablaEnvases = objStock.listarEnvases
        cbxEnvase.DataSource = tablaEnvases
        cbxEnvase.DisplayMember = "CAPACIDAD (L)"
        cbxEnvase.ValueMember = "IDENVASE"
    End Sub



End Class