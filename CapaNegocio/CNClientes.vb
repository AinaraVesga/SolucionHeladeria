Imports CapaDatos
Imports CapaEntidad

Public Class CNClientes
    ' Creamos el objeto de la capa datos
    Dim objCapaDatos As New CDClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerClientes() As DataTable
        Return objCapaDatos.QryListarClientes()
    End Function

    ' Funcion que devuelve la lista de clientes segun parametro de entradaç
    Public Function ObtenerClientesFiltro(filtro As String) As DataTable
        Return objCapaDatos.QryListarClientesFiltro(filtro)
    End Function

    ' Función para insertar un tipo de facturacion en la BD
    Public Function insertCliente(id As String, nombre As String, direccion As String, poblacion As String, telefono As String, cif As String,
                   email As String, ncuenta As String, re As Integer, facturacion As String)
        Dim cliente As New CECliente(id, nombre, direccion, poblacion, telefono, cif, email, ncuenta, re, facturacion)

        Dim ok = objCapaDatos.CmdInsert(cliente)
        Return ok
    End Function

    'Función para obtener RE
    Public Function reSeleccionado(cb As Boolean)

        If cb Then
            Return -1
        Else
            Return 0
        End If
    End Function

    ' Funcion para obtener el ultimo registro de clientes
    Public Function idUltCliente()
        Dim row = objCapaDatos.QryUltimoCliente
        Dim ultimo As New CECliente(row)
        Return ultimo.idcliente
    End Function

    ' Funcion para obtener el id de un nuevo cliente
    Public Function nuevoID()
        Dim ultID As String = idUltCliente()
        Dim letra As Char = ultID.Substring(0, 1)
        Dim num As Integer = ultID.Substring(1, ultID.Length - 1)
        Dim newID As String

        If num < 999 Then
            num = num + 1
            newID = letra + num.ToString().PadLeft(3, "0")
        Else
            letra = Chr(Asc(letra) + 1)
            newID = letra + 1.ToString().PadLeft(3, "0")
        End If
        Return newID
    End Function

    ' Funcion para generar una instancia de un cliente
    Public Function generarCliente(row As DataRow)
        Dim cliente As New CECliente(row)
        Return cliente
    End Function

End Class
