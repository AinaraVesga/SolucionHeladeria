Imports CapaDatos
Imports CapaEntidad

Public Class CNProductos
    Dim objCapaDatos As New CDProductos

    ' Funcion que devuelve la lista de clientes
    Public Function ObtenerProductos() As DataTable
        Return objCapaDatos.QryListarProductos()
    End Function

    ' Funcion que devuelve la lista de clientes SEGUN FILTRO
    Public Function ObtenerProductosFiltro(filtro As String) As DataTable
        Return objCapaDatos.QryListarProductosFiltro(filtro)
    End Function

    ' Funcion para determinar el id de un nuevo producto
    Public Function idProducto(nombre As String)
        Dim id = ""
        If nombre.Length > 0 Then
            If nombre.Length = 1 Then
                id = nombre.Substring(0, 1)
            ElseIf nombre.Length = 2 Then
                id = nombre.Substring(0, 2)
            ElseIf nombre.Length = 3 Then
                id = nombre.Substring(0, 3)
            Else
                id = nombre.Substring(0, 4)
            End If
        End If
        Return id
    End Function

    ' Funcion que comprueba si existe un id de producto
    Public Function comprobarId(id As String)
        Dim res = objCapaDatos.QryBuscarId(id)
        Dim valido = False
        If res.Rows.Count = 0 Then
            valido = True
        End If
        Return valido
    End Function

    ' Funcion que inserta un nuevo producto
    Public Function insertProducto(id As String, nombre As String)
        Dim producto As New CEProducto(id, nombre)

        Dim ok = objCapaDatos.CmdInsert(producto)
        Return ok
    End Function

    ' Funcion para actualizar un producto en la BD
    Public Function updateProducto(id As String, nombre As String)
        Dim producto As New CEProducto(id, nombre)

        Dim ok = objCapaDatos.CmdUpdate(producto)
        Return ok
    End Function
End Class
