Imports CapaDatos
Imports CapaEntidad

Public Class CNProductos
    Dim objCapaDatos As New CDProductos

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerProductos() As DataTable
        Return objCapaDatos.QryListarProductos()
    End Function

    ' Funcion que devuelve la lista de clientes SEGUN FILTRO
    Public Function ObtenerProductosFiltro(filtro As String) As DataTable
        Return objCapaDatos.QryListarProductosFiltro(filtro)
    End Function
End Class
