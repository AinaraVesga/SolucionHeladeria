Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDStock
    Private conexion As New CDConexion

    ' Listar todos los productos en stock
    Function QryListarStock() As DataTable
        Dim query = "SELECT * FROM PRODSTOCK ORDER BY NLOTE"
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

    'Listar STOCK segun un parámetro de entrada
    Function QryListarStockFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM PRODSTOCK WHERE IDPRODUCTO LIKE @producto"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@producto", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Obtener el número que toca del lote
    Function QryUltNumeroLote(idproducto As String) As DataTable
        Dim query = "SELECT MAX(NUMERO) AS NUM
                    FROM PRODSTOCK
                    WHERE IDPRODUCTO LIKE @idproducto;"
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

    'Listar envases
    Function QryListarEnvases() As DataTable
        Dim query = "SELECT * FROM ENVASES"
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

    ' Obtener el precio de un envase
    Function QryPrecioEnvase(idenvase As String) As DataTable
        Dim query = "SELECT PRECIOENVASE FROM ENVASES WHERE IDENVASE = @idenvase"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Crear una tabla intermedia para meter los stocks nuevos provisionales
    Sub CmdCrearTablaIntermedia()
        Dim query = "SELECT * INTO INSERTAR FROM PRODSTOCK WHERE 0=1;"
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

    ' Listar las lineas de la tabla intermedia de stock
    Function QryListarTablaIntermedia() As DataTable
        Dim query = "SELECT * FROM INSERTAR"
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

    ' Insertar lineas en la tabla intermedia
    Function CmdInsertarTablaIntermedia(s As CEStock)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO INSERTAR 
                 (IDPRODUCTO, IDENVASE, NLOTE, NUMERO, CONSUMOPREF, UNIDADES, PRECIOENVASE) VALUES 
                 (@idproducto, @idenvase, @nlote, @numero, @consumopref, @unidades, @precio)"
            cmd.Parameters.AddWithValue("@idproducto", s.idproducto)
            cmd.Parameters.AddWithValue("@idenvase", s.idenvase)
            cmd.Parameters.AddWithValue("@nlote", s.nlote)
            cmd.Parameters.AddWithValue("@numero", s.numero)
            cmd.Parameters.AddWithValue("@consumopref", s.consumop)
            cmd.Parameters.AddWithValue("@unidades", s.unidades)
            cmd.Parameters.AddWithValue("@precio", s.precio)
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

    ' Obtener el registro de la tabla de insertar
    Function QryUnidadesTablaIntermedia(idenvase As String) As DataTable
        Dim query = "SELECT UNIDADES FROM INSERTAR WHERE IDENVASE = @idenvase"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Cambiar las unidades de una linea de la tabla temporal
    Public Function CmdUpdateTablaIntermedia(idenvase As String, unidades As Integer)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE INSERTAR 
                SET UNIDADES = @unidades 
                WHERE IDENVASE = @id"
            cmd.Parameters.AddWithValue("@unidades", unidades)
            cmd.Parameters.AddWithValue("@id", idenvase)
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

    ' intertar filas de la tabla intermedia en prodstock
    Public Sub CmdInsertarStock()
        Dim query = "INSERT INTO PRODSTOCK SELECT INSERTAR.* FROM INSERTAR;"
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

    ' eliminar linea de tabla intermedia
    Public Function CmdDeleteTablaIntermedia(idproducto As String, idenvase As String, nlote As String)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM INSERTAR WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
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

    ' eliminar la tabla insertar
    Public Sub CmdDropTablaIntermedia()
        Dim query = "DROP TABLE INSERTAR;"
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

    ' obtener el nombre de producto a partir de su idproducto
    Function QryNombreProducto(idproducto As String) As DataTable
        Dim query = "SELECT NOMBRE FROM PRODUCTOS WHERE IDPRODUCTO = @idproducto"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idproducto", idproducto)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' obtener capacidad del envase a partir de su idenvase
    Function QryCapacidadEnvase(idenvase As String) As DataTable
        Dim query = "SELECT CAPACIDAD FROM ENVASES WHERE IDENVASE = @idenvase"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@idenvase", idenvase)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' actualizar las unidades de stock
    Public Function CmdUpdateStock(idproducto As String, idenvase As String, nlote As String, unidades As Integer)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE PRODSTOCK 
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

    ' eliminar linea de stock
    Public Function CmdDeleteStock(idproducto As String, idenvase As String, nlote As String)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM PRODSTOCK WHERE IDPRODUCTO = @idproducto AND IDENVASE = @idenvase AND NLOTE = @nlote"
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

End Class
