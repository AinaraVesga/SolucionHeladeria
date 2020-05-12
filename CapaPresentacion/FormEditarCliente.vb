Imports CapaNegocio
Imports CapaEntidad

Public Class FormEditarCliente

    Dim objClienteE As New CECliente
    Dim objCliente As New CNClientes

    Dim fa As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(c As CECliente)

        ' Esta llamada es exigida por el diseñador.
        Me.New()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtID.Text = c.idcliente
        txtNombre.Text = c.nombre
        txtDireccion.Text = c.direccion
        txtPoblacion.Text = c.poblacion
        txtTelefono.Text = c.telefono
        txtCIF.Text = c.cif
        txtEmail.Text = c.email
        txtCuenta.Text = c.ncuenta
        cbRecargo.Checked = c.re
        fa = c.facturacion
        ' MsgBox(fa)
    End Sub

    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFrecuenciaCbo()
    End Sub

    Public Sub listarFrecuenciaCbo()

        Dim objFacturacion As New CNFacturacion
        Dim tablaFrec = objFacturacion.frecuencias()
        cboFacturacion.DataSource = tablaFrec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "IDFACTURACION"

        ' Seleccionamos NINGUNO primero
        Dim index = cboFacturacion.FindString(fa)
        cboFacturacion.SelectedIndex = index

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim formNuevaFact As New FormNuevaFacturacion("editar")
        AddOwnedForm(formNuevaFact)
        formNuevaFact.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim re = objCliente.reSeleccionado(cbRecargo.Checked)
        Dim fa = cboFacturacion.SelectedValue

        Dim ok = objCliente.updateCliente(txtID.Text, txtNombre.Text, txtDireccion.Text, txtPoblacion.Text,
                                          txtTelefono.Text, txtCIF.Text, txtEmail.Text, txtCuenta.Text, re, fa)

        If ok Then
            MessageBox.Show("Se ha actualizado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Dim fClientes As FormMain = CType(Owner, FormMain)
        fClientes.listarClientes()
        Close()
    End Sub

End Class