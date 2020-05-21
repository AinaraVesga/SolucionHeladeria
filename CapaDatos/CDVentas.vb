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

    ' crear una tabla intermedia para para editar el stock sin confirmar
    Sub CmdCrearTablaEditarStock()
        Dim query = "SELECT * INTO ESTOCK FROM PRODSTOCK;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        sqlCommand.Dispose()
        conn.Close()
    End Sub

    ' buscar stock de productos en la tabla intermedia de editar stock
    Function QryBuscarStock(idproducto As String, idenvase As String) As DataTable
        Dim query = "SELECT NLOTE, UNIDADES, NUMERO FROM ESTOCK WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND UNIDADES > 0"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", idproducto)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' eliminar la tabla intermedia de editar el stock
    Public Sub CmdEliminarTablaEditarStock()
        Dim query = "DROP TABLE ESTOCK;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        sqlCommand.Dispose()
        conn.Close()
    End Sub

    ' Obtener el el id y el nombre de todos los productos en stock
    Function QryListaStock() As DataTable
        Dim query = "SELECT DISTINCT S.IDPRODUCTO, P.NOMBRE FROM PRODUCTOS AS P, ESTOCK AS S WHERE P.IDPRODUCTO LIKE S.IDPRODUCTO AND UNIDADES > 0;"
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
        Dim query = "SELECT DISTINCT S.IDENVASE, E.CAPACIDAD FROM ESTOCK AS S, ENVASES AS E WHERE S.IDENVASE LIKE E.IDENVASE AND S.IDPRODUCTO LIKE @idproducto AND UNIDADES > 0;"
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

    ' funcion para obtener las unidades de un producto en stock
    Function QryUnidadesStock(l As CELinea) As DataTable
        Dim query = "SELECT UNIDADES FROM ESTOCK WHERE IDPRODUCTO = @idproducto AND IDENVASE LIKE @idenvase AND NLOTE = @nlote;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", l.idproducto)
        sqlCommand.Parameters.AddWithValue("@idenvase", l.idenvase)
        sqlCommand.Parameters.AddWithValue("@nlote", l.nlote)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Editar unidades en stock de la tabla intermedia de stock
    Public Function CmdUpdateTablaEditarStock(idproducto As String, idenvase As String, nlote As String, unidades As Integer)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE ESTOCK 
                SET UNIDADES = @unidades 
                WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
            cmd.Parameters.AddWithValue("@unidades", unidades)
            cmd.Parameters.AddWithValue("@idproducto", idproducto)
            cmd.Parameters.AddWithValue("@idenvase", idenvase)
            cmd.Parameters.AddWithValue("@nlote", nlote)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' crear una tabla intermedia para las líneas a insertar
    Sub CmdCrearTablaIntermedia()
        Dim query = "SELECT * INTO ILINEAS FROM LINEAS WHERE 0=1;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        sqlCommand.Dispose()
        conn.Close()
    End Sub

    ' listar tabla intermedia de lineas
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

    ' buscar si existe une línea
    Function QryBuscarTablaIntermedia(l As CELinea) As DataTable
        Dim query = "SELECT * FROM ILINEAS WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", l.idproducto)
        sqlCommand.Parameters.AddWithValue("@idenvase", l.idenvase)
        sqlCommand.Parameters.AddWithValue("@nlote", l.nlote)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' eliminar la tabla intermedia de lineas
    Public Sub CmdEliminarTablaIntermedia()
        Dim query = "DROP TABLE ILINEAS;"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.ExecuteReader()
        sqlCommand.Dispose()
        conn.Close()
    End Sub

    ' insertar una linea a la tabla intermedia de lineas
    Function CmdInsertarTablaIntermediaLinea(l As CELinea)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO ILINEAS 
                 (IDPEDIDO, IDPRODUCTO, IDENVASE, NLOTE, UNIDADES, PRECIOUNIDAD, BASEIMPONIBLE) VALUES 
                 (@idpedido, @idproducto, @idenvase, @nlote, @unidades, @precio, @bi)"
            cmd.Parameters.AddWithValue("@idpedido", l.idpedido)
            cmd.Parameters.AddWithValue("@idproducto", l.idproducto)
            cmd.Parameters.AddWithValue("@idenvase", l.idenvase)
            cmd.Parameters.AddWithValue("@nlote", l.nlote)
            cmd.Parameters.AddWithValue("@unidades", l.unidades)
            cmd.Parameters.AddWithValue("@precio", l.precio)
            cmd.Parameters.AddWithValue("@bi", l.bi)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' Editar unidades en stock de la tabla intermedia de stock
    Public Function CmdUpdateTablaIntermediaLinea(l As CELinea, unidades As Integer)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE ILINEAS 
                SET UNIDADES = @unidades 
                WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
            cmd.Parameters.AddWithValue("@unidades", unidades)
            cmd.Parameters.AddWithValue("@idproducto", l.idproducto)
            cmd.Parameters.AddWithValue("@idenvase", l.idenvase)
            cmd.Parameters.AddWithValue("@nlote", l.nlote)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' Eliminar linea de la tabla intermedia de lineas
    Public Function CmdDeleteTablaIntermediaLinea(l As CELinea)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM ILINEAS WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
            cmd.Parameters.AddWithValue("@idproducto", l.idproducto)
            cmd.Parameters.AddWithValue("@idenvase", l.idenvase)
            cmd.Parameters.AddWithValue("@nlote", l.nlote)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            conn.Close()
        End Try
        Return ok
    End Function

    ' función para obtener el importe total de todas las líneas
    Function QryBaseImponible() As DataTable
        Dim query = "SELECT SUM(BASEIMPONIBLE) AS BI FROM ILINEAS GROUP BY IDPEDIDO;"
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

End Class
