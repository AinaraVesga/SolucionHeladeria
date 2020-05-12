Imports CapaDatos
Imports CapaEntidad

Public Class CNProductos
    Dim objCapaDatos As New CDProductos

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerProductos() As DataTable
        Return objCapaDatos.QryListarProductos()
    End Function
End Class
