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
    Private _re As Boolean

    ' Constructora
    Public Sub New()

    End Sub

    Public Sub New(id As String, nombre As String, direccion As String, poblacion As String, telefono As String, cif As String,
                   email As String, ncuenta As String, re As Boolean)
        _id = id
        _nombre = nombre
        _direccion = direccion
        _poblacion = poblacion
        _telefono = telefono
        _cif = cif
        _email = email
        _ncuenta = ncuenta
        _re = re

    End Sub

    Public Sub New(row As DataRow)
        _id = row("IDCLIENTE")
        _nombre = row("NOMBRE")

    End Sub

End Class
