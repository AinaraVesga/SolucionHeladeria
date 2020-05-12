Imports CapaEntidad
Imports CapaNegocio

Public Class FormEliminarProducto

    Dim objProducto As New CNProductos

    Public Sub New(id As String, nombre As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtID.Text = id
        txtNombre.Text = nombre

    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Dim id As String = txtID.Text
        Dim ok = objProducto.deleteProducto(id)

        If ok Then
            MessageBox.Show("Se ha eliminado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Close()
    End Sub
End Class