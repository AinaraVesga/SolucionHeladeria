Imports CapaEntidad
Imports CapaDatos
Public Class CNUsuario

    Dim objCapaDatos As New CDUsuario

    ' función para registrar un usuario
    Public Function nuevoUsuario(u As CEUsuario) As Boolean
        Dim ok As Boolean = objCapaDatos.CmdInsertarUsuario(u)
        Return ok
    End Function

End Class
