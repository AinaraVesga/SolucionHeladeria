Imports System.Data
Imports System.Data.OleDb

Public Class CDDatosIVA
    Dim conexion As New CDConexion

    ' CONECTAMOS A BD
    Function QrylistarIVA() As DataTable
        Dim query = "SELECT * FROM IVA"
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
