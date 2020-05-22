Public Class CEUsuario

    Private _idusuario As String
    Private _usuario As String
    Private _pw As String

    Public Sub New(idusuario As String, usuario As String, pw As String)
        _idusuario = idusuario
        _usuario = usuario
        _pw = pw
    End Sub

    Public ReadOnly Property idusuario As String
        Get
            Return _idusuario
        End Get
    End Property

    Public ReadOnly Property usuario As String
        Get
            Return _usuario
        End Get
    End Property

    Public ReadOnly Property pw As String
        Get
            Return _pw
        End Get
    End Property

End Class
