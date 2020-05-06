Imports CapaNegocio
Imports CapaEntidad

Public Class FormEditarCliente

    Dim objClienteE As New CECliente
    Dim objFacturacion As New CNFacturacion
    Dim tablaFrec = objFacturacion.frecuencias()
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
        MsgBox(fa)
    End Sub

    Private Sub FormEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFrecuenciaCbo()

    End Sub

    Private Sub listarFrecuenciaCbo()

        cboFacturacion.DataSource = tablaFrec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "IDFACTURACION"

        ' Seleccionamos NINGUNO primero
        Dim index = cboFacturacion.FindString(fa)
        cboFacturacion.SelectedIndex = index

    End Sub
End Class