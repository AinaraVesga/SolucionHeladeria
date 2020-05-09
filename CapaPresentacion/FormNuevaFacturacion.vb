Imports CapaNegocio
Public Class FormNuevaFacturacion

    Dim objFacturacion As New CNFacturacion
    Dim origen As String

    Public Sub New(f As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        origen = f
    End Sub

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
        If origen = "añadir" Then
            Dim fNuevoCliente As FormNuevoCliente = CType(Owner, FormNuevoCliente)
            fNuevoCliente.listarFrecuenciaCbo()
        ElseIf origen = "editar" Then
            Dim fEditarCliente As FormEditarCliente = CType(Owner, FormEditarCliente)
            fEditarCliente.listarFrecuenciaCbo()
        End If

        Close()
    End Sub

End Class