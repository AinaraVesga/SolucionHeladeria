Imports CapaEntidad
Imports CapaNegocio

Public Class FormEditarProducto
    Public Sub New(p As CEProducto)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        txtId.Text = p.idproducto
        txtNombre.Text = p.nombre

    End Sub
End Class