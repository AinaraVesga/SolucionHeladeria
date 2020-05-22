Imports CapaEntidad

Public Class CDUsuario

    Dim conexion As New CDConexion

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

End Class
