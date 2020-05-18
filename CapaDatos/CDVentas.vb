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

End Class
