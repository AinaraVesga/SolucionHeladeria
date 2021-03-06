﻿Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDClientes

    Private conexion As New CDConexion

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

    ' Obtener el último cliente registrado
    Function QryUltimoCliente() As DataRow
        Dim query = "SELECT * FROM CLIENTES AS C, (SELECT Max(IDCLIENTE) AS ULTIMO FROM CLIENTES) AS U WHERE C.IDCLIENTE LIKE U.ULTIMO"
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
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
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

    ' ACTUALIZAR REGISTRO DE UN CLIENTE
    Public Function CmdUpdate(c As CECliente)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "UPDATE CLIENTES 
                SET NOMBRE = @nombre,
                DIRECCION = @direccion,
                POBLACION = @poblacion,
                TELEFONO = @telefono,
                CIF = @cif,
                EMAIL = @email,
                NCUENTA = @ncuenta,
                RE = @re,
                FACTURACION = @facturacion 
                WHERE IDCLIENTE = @id"
            cmd.Parameters.AddWithValue("@nombre", c.nombre)
            cmd.Parameters.AddWithValue("@direccion", c.direccion)
            cmd.Parameters.AddWithValue("@poblacion", c.poblacion)
            cmd.Parameters.AddWithValue("@telefono", c.telefono)
            cmd.Parameters.AddWithValue("@cif", c.cif)
            cmd.Parameters.AddWithValue("@email", c.email)
            cmd.Parameters.AddWithValue("@ncuenta", c.ncuenta)
            cmd.Parameters.AddWithValue("@re", c.re)
            cmd.Parameters.AddWithValue("@facturacion", c.facturacion)
            cmd.Parameters.AddWithValue("@id", c.idcliente)
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

    ' ELIMINAR EL REGISTRO DE UN CLIENTE
    Public Function CmdDelete(id As String)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "DELETE FROM CLIENTES WHERE IDCLIENTE = @id"
            cmd.Parameters.AddWithValue("@id", id)
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
