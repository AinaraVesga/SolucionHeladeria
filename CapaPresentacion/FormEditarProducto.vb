Imports CapaEntidad
Imports CapaNegocio

Public Class FormEditarProducto
    Dim objProducto As New CNProductos
    Public Sub New(p As CEProducto)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtId.Text = p.idproducto
        txtNombre.Text = p.nombre

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ok = objProducto.updateProducto(txtId.Text, txtNombre.Text)
        If ok Then
            MessageBox.Show("Se ha actualizado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If
        Close()
    End Sub

End Class