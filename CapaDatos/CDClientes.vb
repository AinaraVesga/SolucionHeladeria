Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDClientes

    Dim conexion As New CDConexion

    ' Listar todos los clientes
    Function QryListarClientes() As DataTable
        Dim query = "SELECT * FROM CLIENTES"
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

    'Listar clientes segun un parámetro de entrada
    Function QryListarClientesFiltro(filtro As String) As DataTable
        Dim query = "SELECT * FROM CLIENTES WHERE NOMBRE LIKE @nombre"
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

    'Insertar nuevo cliente
    Public Function CmdInsert(c As CECliente)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO CLIENTES 
                 (IDCLIENTE, NOMBRE, DIRECCION, POBLACION, TELEFONO, CIF, EMAIL, NCUENTA, RE, FACTURACION) VALUES 
                 (@id, @nombre, @direccion, @poblacion, @telefono, @cif, @email, @ncuenta, @re, @facturacion)"
            cmd.Parameters.AddWithValue("@id", c.idcliente)
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@direccion", c.direccion)
            cmd.Parameters.AddWithValue("@poblacion", c.poblacion)
            cmd.Parameters.AddWithValue("@telefono", c.poblacion)
            cmd.Parameters.AddWithValue("@cif", c.cif)
            cmd.Parameters.AddWithValue("@email", c.email)
            cmd.Parameters.AddWithValue("@ncuenta", c.ncuenta)
            cmd.Parameters.AddWithValue("@re", c.re)
            cmd.Parameters.AddWithValue("@facturacion", c.facturacion)
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
