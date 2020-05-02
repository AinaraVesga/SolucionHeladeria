Imports CapaDatos
Imports CapaEntidad

Public Class CNClientes
    ' Creamos el objeto de la capa datos
    Dim objCapaDatos As New CDClientes

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerClientes() As DataTable
        Return objCapaDatos.QryListarClientes()
    End Function

    ' Función para insertar un tipo de facturacion en la BD
    Public Function insertCliente(id As String, nombre As String, direccion As String, poblacion As String, telefono As String, cif As String,
                   email As String, ncuenta As String, re As Integer, facturacion As String)
        Dim cliente As New CECliente(id, nombre, direccion, poblacion, telefono, cif, email, ncuenta, re, facturacion)

        Dim ok = objCapaDatos.CmdInsert(cliente)
        Return ok
    End Function

End Class
