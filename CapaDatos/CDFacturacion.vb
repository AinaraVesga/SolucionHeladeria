Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDFacturacion

    Dim conexion As New CDConexion

    ' Listamos los nombres de los tipos de facturacion
    Function QryListarFacturacionNames() As DataTable
        Dim query = "SELECT * FROM FACTURACIONES"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim command = New OleDbCommand(query, conn)
        Dim table = New DataTable()
        Dim executeReader = command.ExecuteReader
        table.Load(executeReader)
        command.Dispose()
        conn.Close()
        Return table
    End Function

    ' Insertar nuevo tipo de facturacion
    Public Function CmdInsert(f As CEFacturacion)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO FACTURACIONES 
                 (IDFACTURACION, FRECUENCIA) VALUES 
                 (@id, @fact)"
            cmd.Parameters.AddWithValue("@id", f.idfacturacion)
            cmd.Parameters.AddWithValue("@fact", f.frecuencia)
            cmd.ExecuteNonQuery()
            ok = True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            ok = False
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
        Return ok
    End Function

End Class
