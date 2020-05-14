Imports System.Data
Imports System.Data.OleDb
Imports CapaEntidad

Public Class CDStock
    Dim conexion As New CDConexion

    ' Listar todos los productos en stock
    Function QryListarStock() As DataTable
        Dim query = "SELECT * FROM PRODSTOCK"
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

End Class
