Public Class CEIVA

    ' DECLARAMOS LOS ATRIBUTOS
    Private _idIVA As Integer
    Private _descripcion As String
    Private _re As Double

    ' IMPLEMENTAMOS LAS PROPIEDADES
    Public Property idIVA As Integer
        Get
            Return _idIVA
        End Get
        Set(value As Integer)
            _idIVA = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property re As Double
        Get
            Return _re
        End Get
        Set(value As Double)
            _re = value
        End Set
    End Property
End Class
