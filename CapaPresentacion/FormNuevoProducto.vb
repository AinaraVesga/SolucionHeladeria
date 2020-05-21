Imports CapaNegocio

Public Class FormNuevoProducto

    Dim objProductos As New CNProductos

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        txtId.Text = objProductos.idProducto(txtNombre.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim valido = objProductos.comprobarId(txtId.Text)

        If valido Then
            Dim ok = objProductos.insertProducto(txtId.Text, txtNombre.Text)
            If ok Then
                MessageBox.Show("Se ha insertado correctamente.")
            Else
                MessageBox.Show("Ha ocurrido un error.")
            End If
            Close()
        Else
            MessageBox.Show("Identificador de producto ya registrado. Escriba un nuevo código.")
            txtId.Enabled = True
            txtNombre.Enabled = False
        End If
    End Sub

End Class