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

    Private Sub FormNuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblAñadirProd_Click(sender As Object, e As EventArgs) Handles lblAñadirProd.Click

    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub lblId_Click(sender As Object, e As EventArgs) Handles lblId.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class