Imports CapaEntidad
Imports CapaNegocio
Public Class FormEditarStock

    Dim objStock As New CNStock

    Public Sub New(s As CEStock)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtIdProd.Text = s.idproducto
        txtProd.Text = objStock.nombreProducto(s.idproducto)
        txtIdEnvase.Text = s.idenvase
        txtEnvase.Text = objStock.capacidadEnvase(s.idenvase)
        txtLote.Text = s.nlote
        numUnidades.Value = s.unidades
        txtPrecio.Text = s.precio
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idproducto As String = txtIdProd.Text
        Dim idenvase As String = txtIdEnvase.Text
        Dim nlote As String = txtLote.Text
        Dim unidades As Integer = numUnidades.Value

        Dim ok = objStock.updateStock(idproducto, idenvase, nlote, unidades)

        If ok Then
            MessageBox.Show("Se ha actualizado correctamente.")
        Else
            MessageBox.Show("Ha ocurrido un error.")
        End If

        Close()
    End Sub


End Class