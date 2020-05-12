Public Class CEProducto
    ' Declaramos los atributos
    Private _id As String
    Private _nombre As String

    ' Constructoras
    Public Sub New()

    End Sub

    Public Sub New(id As String, nombre As String)
        _id = id
        _nombre = nombre
    End Sub

    Public Sub New(row As DataRow)
        _id = row("IDPRODUCTO")
        _nombre = row("NOMBRE")
    End Sub

    ' GETTERS
    Public ReadOnly Property idproducto As String
        Get
            Return _id
        End Get
    End Property
    Public ReadOnly Property nombre As String
        Get
            Return _nombre
        End Get
    End Property


End Class
