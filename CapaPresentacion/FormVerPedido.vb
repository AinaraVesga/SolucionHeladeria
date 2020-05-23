Imports CapaEntidad
Imports CapaNegocio

Public Class FormVerPedido

    Private objVentas As New CNVentas

    Public Sub New(idpedido As String, idcliente As String, fecha As String, totalBi As Double, totalIVA As Double,
                   totalRE As Double, total As Double)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIDPedido.Text = idpedido
        txtCliente.Text = idcliente
        txtFecha.Text = fecha
        txtBI.Text = totalBi
        txtIVA.Text = totalIVA
        txtRE.Text = totalRE
        txtTotal.Text = total

    End Sub

    Private Sub FormVerPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarLineas()
    End Sub

    Public Sub listarLineas()
        Dim dt As DataTable = objVentas.listarLineasPedido(txtIDPedido.Text)
        dgvLineas.DataSource = dt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Close()
    End Sub


End Class