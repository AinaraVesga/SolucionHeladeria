Public Class CEPedido

    Private _idpedido As String
    Private _idcliente As String
    Private _fecha As String
    Private _totalBI As Double
    Private _iva As Integer
    Private _re As Double
    Private _ivaTotal As Double
    Private _reTotal As Double
    Private _total As Double
    Private _facturado As Integer
    Private _idfactura As String

    Public Sub New()

    End Sub

    Public Sub New(idpedido As String, idcliente As String, fecha As String, totalBI As Double, iva As Integer, re As Double)
        _idpedido = idpedido
        _idcliente = idcliente
        _fecha = fecha
        _totalBI = totalBI
        _iva = iva
        _re = re
        _ivaTotal = _totalBI * _iva / 100
        _reTotal = _totalBI * _re / 100
        _total = _totalBI + _ivaTotal + _reTotal
        _facturado = 0
        _idfactura = 0
    End Sub

    Public Sub New(row As DataRow)
        _idpedido = row("IDPEDIDO")
        _idcliente = row("IDCLIENTE")
        _fecha = row("FECHA")
        _totalBI = row("TOTALBASEIMP")
        _iva = row("IVA")
        _re = row("RE")
        _total = row("TOTAL")
        _facturado = row("FACTURADO")
        _idfactura = row("IDFACTURA")
    End Sub

    Public ReadOnly Property idpedido As String
        Get
            Return _idpedido
        End Get
    End Property

    Public ReadOnly Property idcliente As String
        Get
            Return _idcliente
        End Get
    End Property

    Public ReadOnly Property fecha As String
        Get
            Return _fecha
        End Get
    End Property

    Public ReadOnly Property totalBI As Double
        Get
            Return _totalBI
        End Get
    End Property

    Public ReadOnly Property iva As Integer
        Get
            Return _iva
        End Get
    End Property

    Public ReadOnly Property re As Double
        Get
            Return _re
        End Get
    End Property

    Public ReadOnly Property ivaTotal As Double
        Get
            Return _ivaTotal
        End Get
    End Property

    Public ReadOnly Property reTotal As Double
        Get
            Return _reTotal
        End Get
    End Property

    Public ReadOnly Property total As Double
        Get
            Return _total
        End Get
    End Property

    Public ReadOnly Property facturado As String
        Get
            Return _facturado
        End Get
    End Property

    Public ReadOnly Property idfactura As Integer
        Get
            Return _idfactura
        End Get
    End Property


End Class
