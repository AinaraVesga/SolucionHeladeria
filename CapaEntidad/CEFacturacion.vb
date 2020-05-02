Public Class CEFacturacion
    ' Atributos
    Private _idfacturacion As String
    Private _frecuencia As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(idfacturacion As String, frecuencia As String)
        _idfacturacion = idfacturacion
        _frecuencia = frecuencia
    End Sub

    Public Sub New(row As DataRow)
        _idfacturacion = row("IDFACTURACION")
        _frecuencia = row("FRECUENCIA")
    End Sub

    ' Propiedades
    Public ReadOnly Property idfacturacion As String
        Get
            Return _idfacturacion
        End Get
    End Property

    Public ReadOnly Property frecuencia As String
        Get
            Return _frecuencia
        End Get
    End Property


End Class
