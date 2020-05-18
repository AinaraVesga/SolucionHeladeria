Public Class CEPedido

    Private _idpedido As String
    Private _idcliente As String
    Private _fecha As String
    Private _totalBI As Double
    Private _iva As Integer
    Private _re As Double
    Private _total As Double
    Private _facturado As Integer
    Private _idfactura As String

    Public Sub New()

    End Sub

    Public Sub New(idpedido As String, idcliente As String, fecha As String, totalBI As String, iva As Integer, re As Double, total As Double)
        _idpedido = idpedido
        _idcliente = idcliente
        _fecha = fecha
        _totalBI = totalBI
        _iva = iva
        _re = re
        _total = total
        _facturado = 0
        _idfactura = ""
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

End Class
