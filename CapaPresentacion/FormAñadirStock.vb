Imports CapaNegocio

Public Class FormAñadirStock
    Dim objStock As New CNStock

    Private Sub FormAñadirStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProd()
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
        txtID.Text = id
        txtLote.Text = objStock.setNumeroLote(id)
    End Sub

End Class