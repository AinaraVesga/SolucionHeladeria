Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDVentas

    Dim conexion As New CDConexion

    ' Listar todas las líneas de pedidos
    Function QryListarPedidos() As DataTable
        Dim query = "SELECT * FROM PEDIDOS"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    'Listar pedidos segun un parámetro de entrada (idcliente)
    Function QryListarPedidosFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM PEDIDOS WHERE IDCLIENTE LIKE @filtro"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@filtro", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Obtener el último pedido registrado
    Function QryUltimoPedido() As DataRow
        Dim query = "SELECT * FROM PEDIDOS AS P, (SELECT Max(IDPEDIDO) AS ULTIMO FROM PEDIDOS) AS U WHERE P.IDPEDIDO LIKE U.ULTIMO"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Dim row = table.Select.FirstOrDefault()
        Return row
    End Function

    ' Obtener el el id y el nombre de todos los clientes
    Function QryListaClientes() As DataTable
        Dim query = "SELECT IDCLIENTE, NOMBRE FROM CLIENTES"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Obtener el el id y el nombre de todos los productos en stock
    Function QryListaStock() As DataTable
        Dim query = "SELECT DISTINCT S.IDPRODUCTO, P.NOMBRE FROM PRODUCTOS AS P, PRODSTOCK AS S WHERE P.IDPRODUCTO LIKE S.IDPRODUCTO;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Obtener el el id y el nombre de los envases disponibles de un tipo de producto
    Function QryListaEnvases(idproducto As String) As DataTable
        Dim query = "SELECT DISTINCT S.IDENVASE, E.CAPACIDAD FROM PRODSTOCK AS S, ENVASES AS E WHERE S.IDENVASE LIKE E.IDENVASE AND S.IDPRODUCTO LIKE @idproducto;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", idproducto)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' función para obtener los nº de lote y unidades de un producto en stock
    Function QryLoteUnidades(idproducto As String, idenvase As String) As DataTable
        Dim query = "SELECT NLOTE, UNIDADES, NUMERO FROM PRODSTOCK WHERE IDPRODUCTO LIKE @idproducto AND IDENVASE LIKE @idenvase ORDER BY NUMERO;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", idproducto)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' funcion para obtener el precio de un envase
    Function QryPrecioEnvase(idenvase As String) As DataTable
        Dim query = "SELECT PRECIOENVASE FROM ENVASES WHERE IDENVASE LIKE @idenvase;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' crear una tabla intermedia para las líneas a insertar
    Sub QryCrearTablaIntermedia()
        Dim query = "SELECT * INTO ILINEAS FROM LINEAS WHERE 0=1;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        sqlCommand.Dispose()
        conn.Close()
    End Sub

    ' listar tabla intermedia
    Function QryListarTablaIntermedia() As DataTable
        Dim query = "SELECT * FROM ILINEAS"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' eliminar la tabla intermedia
    Public Sub QryEliminarTablaIntermedia()
        Dim query = "DROP TABLE ILINEAS;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        'Dim table = New DataTable()
        ' Dim executeReader = sqlCommand.ExecuteReader
        'table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
    End Sub

End Class
