Public Class CECliente
    ' Declaramos los atributos
    Private _id As String
    Private _nombre As String
    Private _direccion As String
    Private _poblacion As String
    Private _telefono As String
    Private _cif As String
    Private _email As String
    Private _ncuenta As String
    Private _re As Integer
    Private _facturacion As String

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(id As String, nombre As String, direccion As String, poblacion As String, telefono As String, cif As String,
                   email As String, ncuenta As String, re As Integer, facturacion As String)
        _id = id
        _nombre = nombre
        _direccion = direccion
        _poblacion = poblacion
        _telefono = telefono
        _cif = cif
        _email = email
        _ncuenta = ncuenta
        _re = re
        _facturacion = facturacion

    End Sub

    Public Sub New(row As DataRow)
        _id = row("IDCLIENTE")
        _nombre = row("NOMBRE")
    End Sub

    ' Propiedades
    Public ReadOnly Property idcliente As String
        Get
            Return _id
        End Get
    End Property

    Public ReadOnly Property nombre As String
        Get
            Return _nombre
        End Get
    End Property

    Public ReadOnly Property direccion As String
        Get
            Return _direccion
        End Get
    End Property

    Public ReadOnly Property poblacion As String
        Get
            Return _poblacion
        End Get
    End Property

    Public ReadOnly Property telefono As String
        Get
            Return _telefono
        End Get
    End Property

    Public ReadOnly Property cif As String
        Get
            Return _cif
        End Get
    End Property

    Public ReadOnly Property email As String
        Get
            Return _email
        End Get
    End Property

    Public ReadOnly Property ncuenta As String
        Get
            Return _ncuenta
        End Get
    End Property

    Public ReadOnly Property re As Integer
        Get
            Return _re
        End Get
    End Property

    Public ReadOnly Property facturacion As String
        Get
            Return _facturacion
        End Get
    End Property

End Class
