Imports System.Data
Imports System.Data.OleDb

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

End Class
