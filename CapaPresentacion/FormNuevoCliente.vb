Imports CapaNegocio

Public Class FormNuevoCliente

    Dim objFacturacion As New CNFacturacion
    Dim tablaFrec = objFacturacion.frecuencias()

    Private Sub FormNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFrecuenciaCbo()
    End Sub

    Private Sub listarFrecuenciaCbo()

        cboFacturacion.DataSource = tablaFrec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "IDFACTURACION"

        ' Seleccionamos NINGUNO primero
        Dim index = cboFacturacion.FindString("NINGUNO")
        cboFacturacion.SelectedIndex = index

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim formNuevaFact As New FormNuevaFacturacion
        formNuevaFact.Show()
        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objCliente As New CNClientes
        Dim re = objCliente.reSeleccionado(cbRecargo.Checked)

        Dim prueba = cboFacturacion.SelectedValue

        Dim ok = objCliente.insertCliente("xzf", txtNombre.Text, txtDireccion.Text, txtPoblacion.Text,
                                          txtTelefono.Text, txtCIF.Text, txtEmail.Text, txtCuenta.Text, re, prueba)
        'Dim ok = objCliente.insertCliente("ain", "abc", "abc", "abc",
        '                                 "abc", "abc", "abc", "abc", -1, "NIN")
        If ok Then
            MessageBox.Show("Se ha insertado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Close()
    End Sub

    Private Sub cboFacturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFacturacion.SelectedIndexChanged

    End Sub
End Class