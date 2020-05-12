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

End Class
