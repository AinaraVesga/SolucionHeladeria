Imports CapaNegocio

Public Class FormNuevoCliente

    Dim objCliente As New CNClientes
    Dim objFacturacion As New CNFacturacion


    Private Sub FormNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id As String = objCliente.nuevoID()
        txtID.Text = id
        listarFrecuenciaCbo()
    End Sub

    Public Sub listarFrecuenciaCbo()
        Dim objFacturacion As New CNFacturacion
        Dim tablaFrec = objFacturacion.frecuencias()
        cboFacturacion.DataSource = tablaFrec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "IDFACTURACION"

        ' Seleccionamos NINGUNO primero
        Dim index = cboFacturacion.FindString("NINGUNO")
        cboFacturacion.SelectedIndex = index

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim formNuevaFact As New FormNuevaFacturacion("añadir")
        AddOwnedForm(formNuevaFact)
        formNuevaFact.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim re = objCliente.reSeleccionado(cbRecargo.Checked)
        Dim fa = cboFacturacion.SelectedValue

        Dim ok = objCliente.insertCliente(txtID.Text, txtNombre.Text, txtDireccion.Text, txtPoblacion.Text,
                                          txtTelefono.Text, txtCIF.Text, txtEmail.Text, txtCuenta.Text, re, fa)
        'Dim ok = objCliente.insertCliente("ain", "abc", "abc", "abc",
        '                                 "abc", "abc", "abc", "abc", -1, "NIN")
        If ok Then
            MessageBox.Show("Se ha insertado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Dim fClientes As FormMain = CType(Owner, FormMain)
        fClientes.listarClientes()
        Close()
    End Sub

End Class