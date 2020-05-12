Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad
Public Class CDProductos

    Dim conexion As New CDConexion

    ' Listar todos los productos
    Function QryListarProductos() As DataTable
        Dim query = "SELECT * FROM PRODUCTOS"
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

    'Listar productos segun un parámetro de entrada
    Function QryListarProductosFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM PRODUCTOS WHERE NOMBRE LIKE @nombre"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@nombre", filtro + "%")
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Buscar si un id ya está registrado

    Function QryBuscarId(id As String) As DataTable
        Dim query = "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO LIKE @id"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@id", id)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' Insertar nuevo producto
    Public Function CmdInsert(p As CEProducto)

        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO PRODUCTOS 
                 (IDPRODUCTO, NOMBRE) VALUES 
                 (@id, @nombre)"
            cmd.Parameters.AddWithValue("@id", p.idproducto)
            cmd.Parameters.AddWithValue("@nombre", p.nombre)
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

    ' ACTUALIZAR REGISTRO DE UN PRODUCTO
    Public Function CmdUpdate(p As CEProducto)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE PRODUCTOS 
                SET NOMBRE = @nombre 
                WHERE IDPRODUCTO = @id"
            cmd.Parameters.AddWithValue("@nombre", p.nombre)
            cmd.Parameters.AddWithValue("@id", p.idproducto)
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
