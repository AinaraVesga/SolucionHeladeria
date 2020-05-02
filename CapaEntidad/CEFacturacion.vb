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

End Class
