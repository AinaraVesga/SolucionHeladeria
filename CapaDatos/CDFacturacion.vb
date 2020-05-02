Imports System.Data
Imports System.Data.OleDb

Public Class CDFacturacion

    Dim conexion As New CDConexion

    ' Listamos los nombres de los tipos de facturacion
    Function QryListarFacturacionNames() As DataTable
        Dim query = "SELECT FRECUENCIA FROM FACTURACIONES"
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

End Class
