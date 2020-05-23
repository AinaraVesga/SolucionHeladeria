Imports CapaEntidad
Imports System.Data
Imports System.Data.OleDb

Public Class CDUsuario

    Private conexion As New CDConexion

    ' funcion para comprobar si un usuario ya existe
    Function QryBuscarUsuario(u As CEUsuario) As DataTable
        Dim query = "SELECT * FROM USUARIOS WHERE USUARIO LIKE @usuario"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@usuario", u.usuario)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

    ' función para registrar un nuevo usuario
    Function CmdInsertarUsuario(u As CEUsuario)
        Dim ok = False
        Dim conn = conexion.getConnection()
        conn.Open()
        Try
            Dim cmd = conn.CreateCommand
            cmd.CommandText = "INSERT INTO USUARIOS 
                 (IDUSUARIO, USUARIO, CONTRASEÑA) VALUES 
                 (@idusuario, @usuario, @pw)"
            cmd.Parameters.AddWithValue("@idusuario", u.idusuario)
            cmd.Parameters.AddWithValue("@usuario", u.usuario)
            cmd.Parameters.AddWithValue("@pw", u.pw)
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

    ' funcion para identificar a un usuario
    Function QryIdentificarUsuario(usuario As String, pw As String) As DataTable
        Dim query = "SELECT * FROM USUARIOS WHERE USUARIO LIKE @usuario AND CONTRASEÑA LIKE @pw"
        Dim conn = conexion.getConnection()
        conn.Open()
        Dim sqlCommand = New OleDbCommand(query, conn)
        sqlCommand.Parameters.AddWithValue("@usuario", usuario)
        sqlCommand.Parameters.AddWithValue("@pw", pw)
        Dim table = New DataTable()
        Dim executeReader = sqlCommand.ExecuteReader()
        table.Load(executeReader)
        sqlCommand.Dispose()
        conn.Close()
        Return table
    End Function

End Class
