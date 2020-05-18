Imports CapaDatos
Imports CapaEntidad

Public Class CNVentas

    Dim objDatosVentas As New CDVentas

    Public Function obtenerPedidos() As DataTable
        Return objDatosVentas.QryListarPedidos
    End Function

    Public Function obtenerPedidosFiltro(filtro As String) As DataTable
        Return objDatosVentas.QryListarPedidosFiltro(filtro)
    End Function

    ' funcioón para obtener el último número de pedido
    Public Function ultimoPedido()
        Dim row As DataRow = objDatosVentas.QryUltimoPedido
        Dim pedido As New CEPedido(row)
        Return pedido.idpedido
    End Function

    ' función para generar un nuevo número de pedido
    Public Function nuevoIDPedido()
        Dim ultID As String = ultimoPedido()
        Dim num As Integer = ultID.Substring(1, ultID.Length - 1)
        num += 1
        Dim newID As String = "P" + num.ToString().PadLeft(3, "0")
        Return newID
    End Function

    ' función para listar los clientes en el cbox
    Public Function listarClientes() As DataTable
        Return objDatosVentas.QryListaClientes
    End Function



End Class
