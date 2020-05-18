Imports CapaDatos

Public Class CNVentas

    Dim objDatosVentas As New CDVentas

    Public Function obtenerPedidos() As DataTable
        Return objDatosVentas.QryListarPedidos
    End Function

    Public Function obtenerPedidosFiltro(filtro As String) As DataTable
        Return objDatosVentas.QryListarPedidosFiltro(filtro)
    End Function

End Class
