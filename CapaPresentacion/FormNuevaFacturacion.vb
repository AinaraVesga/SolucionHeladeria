Imports CapaNegocio
Public Class FormNuevaFacturacion

    Dim objFacturacion As New CNFacturacion

    Private Sub txtFrecuencia_TextChanged(sender As Object, e As EventArgs) Handles txtFrecuencia.TextChanged
        txtIdent.Text = objFacturacion.idFacturacion(txtFrecuencia.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ok = objFacturacion.insertFacturacion(txtIdent.Text, txtFrecuencia.Text)
        If ok Then
            MessageBox.Show("Se ha insertado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        FormNuevoCliente.Show()
        Close()
    End Sub

    Private Sub FormNuevaFacturacion_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FormNuevoCliente.Show()
    End Sub
End Class