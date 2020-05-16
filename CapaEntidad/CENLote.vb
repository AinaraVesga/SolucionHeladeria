Public Class CENLote

    Private _nlote As String
    Private _numero As Integer


    Public Sub New()

    End Sub

    Public Sub New(nlote As String, numero As Integer)
        _nlote = nlote
        _numero = numero
    End Sub

    Public ReadOnly Property nlote As String
        Get
            Return _nlote
        End Get
    End Property

    Public ReadOnly Property numero As Integer
        Get
            Return _numero
        End Get
    End Property

End Class
