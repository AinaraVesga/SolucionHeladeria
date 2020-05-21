Imports CapaEntidad
Imports CapaNegocio

Public Class FormEliminarPedido

    Dim objVentas As New CNVentas

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

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Dim ok = objVentas.eliminarPedido(txtIDPedido.Text)

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