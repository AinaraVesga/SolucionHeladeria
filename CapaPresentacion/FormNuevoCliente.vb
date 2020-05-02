Imports CapaNegocio

Public Class FormNuevoCliente

    Private Sub FormNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFrecuenciaCbo()
    End Sub

    Private Sub listarFrecuenciaCbo()
        Dim objFacturacion As New CNFacturacion
        Dim frec = objFacturacion.frecuencias()

        cboFacturacion.DataSource = frec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "FRECUENCIA"

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
        'Dim ok = objCliente.insertCliente("abc", txtNombre.Text, txtDireccion.Text, txtPoblacion.Text,
        'txtTelefono.Text, txtCIF.Text, txtEmail.Text, txtCuenta.Text, True,
        '                                 "")
        Dim ok = objCliente.insertCliente("ain", "abc", "abc", "abc",
                                          "abc", "abc", "abc", "abc", -1, "NIN")
        If ok Then
            MessageBox.Show("Se ha insertado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Close()
    End Sub
End Class