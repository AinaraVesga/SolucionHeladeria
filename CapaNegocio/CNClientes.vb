Imports CapaDatos

Public Class CNClientes
    ' Creamos el objeto de la capa datos
    Dim objCapaDatos As New CDClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerClientes() As DataTable
        Return objCapaDatos.QryListarClientes
    End Function

End Class
