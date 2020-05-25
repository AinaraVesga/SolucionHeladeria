Imports CapaNegocio
Public Class FormEliminarStock

    Dim objStock As New CNStock
    Dim _idproducto As String
    Dim _idenvase As String
    Dim _nlote As String

    Public Sub New(idproducto As String, idenvase As String, nlote As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtProd.Text = objStock.nombreProducto(idproducto)
        txtEnvase.Text = objStock.capacidadEnvase(idenvase)
        txtLote.Text = nlote
        _idproducto = idproducto
        _idenvase = idenvase
        _nlote = nlote

    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Dim ok = objStock.deleteStock(_idproducto, _idenvase, _nlote)

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