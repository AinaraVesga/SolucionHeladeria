Imports CapaEntidad
Imports CapaDatos
Public Class CNUsuario

    Dim objCapaDatos As New CDUsuario

    ' función para comprobar si existe un usuario con ese nombre
    Public Function buscarUsuario(u As CEUsuario) As Boolean
        Dim dt As DataTable = objCapaDatos.QryBuscarUsuario(u)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ' función para registrar un usuario
    Public Function nuevoUsuario(u As CEUsuario) As Boolean
        Dim ok As Boolean = objCapaDatos.CmdInsertarUsuario(u)
        Return ok
    End Function

    ' funcion para identificar a un usuario
    Public Function identificarUsuario(usuario As String, pw As String) As Boolean
        Dim dt As DataTable = objCapaDatos.QryIdentificarUsuario(usuario, pw)
        If dt.Rows.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
