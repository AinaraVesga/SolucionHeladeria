Public Class CELinea
    Private _idpedido As String
    Private _idproducto As String
    Private _idenvase As String
    Private _nlote As String
    Private _unidades As Integer
    Private _precio As Double
    Private _bi As Double

    Public Sub New()

    End Sub

    Public Sub New(idpedido As String, idproducto As String, idenvase As String, nlote As String,
                   unidades As Integer, precio As Double, bi As Double)
        _idpedido = idpedido
        _idproducto = idproducto
        _idenvase = idenvase
        _nlote = nlote
        _unidades = unidades
        _precio = precio
        _bi = bi
    End Sub

    Public Sub New(row As DataRow)
        _idpedido = row("IDPEDIDO")
        _idproducto = row("IDPRODUCTO")
        _idenvase = row("IDENVASE")
        _nlote = row("NLOTE")
        _unidades = row("UNIDADES")
        _precio = row("PRECIOUNIDAD")
        _bi = row("BASEIMPONIBLE")
    End Sub

    ' Declaramos los getters
    Public ReadOnly Property idpedido As String
        Get
            Return _idpedido
        End Get
    End Property

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
    Public ReadOnly Property bi As String
        Get
            Return _bi
        End Get
    End Property


End Class
