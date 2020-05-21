Public Class CEStock

    ' Declaramos los atributos
    Private _idproducto As String
    Private _idenvase As String
    Private _nlote As String
    Private _numero As Integer
    Private _consumop As String
    Private _unidades As Integer
    Private _precio As Double

    ' Creamos las constructoras
    Public Sub New()

    End Sub

    Public Sub New(idproducto As String, idenvase As String, nlote As String, numero As Integer, consumop As String, unidades As Integer, precio As Double)
        _idproducto = idproducto
        _idenvase = idenvase
        _nlote = nlote
        _numero = numero
        _consumop = consumop
        _unidades = unidades
        _precio = precio
    End Sub

    Public Sub New(row As DataRow)
        _idproducto = row("IDPRODUCTO")
        _idenvase = row("IDENVASE")
        _nlote = row("NLOTE")
        _numero = row("NUMERO")
        _consumop = row("CONSUMOPREF")
        _unidades = row("UNIDADES")
        _precio = row("PRECIOENVASE")
    End Sub

    ' Declaramos los getters
    Public ReadOnly Property idproducto As String
        Get
            Return _idproducto
        End Get
    End Property

    Public ReadOnly Property idenvase As String
        Get
            Return _idenvase
        End Get
    End Property

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

    Public ReadOnly Property consumop As String
        Get
            Return _consumop
        End Get
    End Property

    Public ReadOnly Property unidades As Integer
        Get
            Return _unidades
        End Get
    End Property

    Public ReadOnly Property precio As Double
        Get
            Return _precio
        End Get
    End Property

End Class
