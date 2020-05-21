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

    ' función para listar los productos en stock en el cbox
    Public Function listarStock() As DataTable
        Return objDatosVentas.QryListaStock
    End Function

    ' función para listar los envases disponibles de un producto en stock
    Public Function listarEnvases(idproducto As String) As DataTable
        Return objDatosVentas.QryListaEnvases(idproducto)
    End Function

    ' función para obtener la lista de nº de lote y unidades de un producto en stock
    Public Function listarLoteUnidades(idproducto As String, idenvase As String) As DataTable
        Return objDatosVentas.QryBuscarStock(idproducto, idenvase)
    End Function

    ' obtener el número total de unidades de un producto y envase concretos
    Public Function unidadesDisponibles(idproducto As String, idenvase As String)
        Dim dv As DataTable = listarLoteUnidades(idproducto, idenvase)
        Dim unidades As Integer = 0
        For i As Integer = 0 To dv.Rows.Count - 1
            unidades += dv(i)(1)
        Next
        Return unidades
    End Function

    ' obtener el precio de un envase
    Public Function precioEnvase(idenvase As String) As DataTable
        Return objDatosVentas.QryPrecioEnvase(idenvase)
    End Function

    ' calcular la bi
    Public Function calcularBI(unidades As Integer, precio As Double)
        Dim bi As Double = unidades * precio
        Return bi
    End Function

    ' Crear tabla intermedia
    Public Sub crearTablaIntermedia()
        objDatosVentas.CmdCrearTablaIntermedia()
    End Sub

    ' obtener lineas de la tabla intermedia
    Public Function listarTablaIntermedia()
        Return objDatosVentas.QryListarTablaIntermedia
    End Function

    ' eliminar la tabla intermedia
    Public Sub eliminarTablaIntermedia()
        objDatosVentas.CmdEliminarTablaIntermedia()
    End Sub

    ' crear una tabla para editar el stock sin confirmar
    Public Sub crearTablaEditarStock()
        objDatosVentas.CmdCrearTablaEditarStock()
    End Sub

    ' eliminar la tabla intermedia para editar el stock
    Public Sub eliminarTablaEditarStock()
        objDatosVentas.CmdEliminarTablaEditarStock()
    End Sub

    ' añadir unidades al pedido
    Public Function añadirUnidades(idpedido As String, idproducto As String, idenvase As String, unidades As Integer,
                                   precio As Double, bi As Double) As Boolean

        Dim u As Integer = unidades
        Dim i As Integer = 0
        Dim ok As Boolean = True

        While u > 0 And ok
            Dim lotes As DataTable = objDatosVentas.QryBuscarStock(idproducto, idenvase)
            Dim lote As String = lotes(i)(0)
            Dim uLote As Integer = lotes(i)(1)
            Dim uLinea As Integer

            If uLote > u Then
                Dim resto = uLote - u
                uLinea = u
                u = 0
                objDatosVentas.CmdUpdateTablaEditarStock(idproducto, idenvase, lote, resto)
            Else
                u = u - uLote
                uLinea = uLote
                objDatosVentas.CmdDeleteTablaIntermediaStock(idproducto, idenvase, lote)
            End If

            Dim linea As New CELinea(idpedido, idproducto, idenvase, lote, uLinea, precio, bi)

            Dim dt As DataTable = objDatosVentas.QryBuscarTablaIntermedia(linea)
            If dt.Rows.Count = 0 Then
                ok = objDatosVentas.CmdInsertarTablaIntermediaLinea(linea)
            Else
                uLote = dt.Rows(0)("UNIDADES")
                uLinea += uLote
                ok = objDatosVentas.CmdUpdateTablaIntermediaLinea(linea, uLinea)
            End If

        End While

        Return ok
    End Function


End Class
