Imports CapaDatos
Imports CapaEntidad

Public Class CNStock
    Dim objStock As New CDStock
    Dim objProducto As New CDProductos

    ' Funcion que devuelve la lista de productos en stock
    Public Function ObtenerStock() As DataTable
        Return objStock.QryListarStock()
    End Function

    ' Funcion que devuelve la lista de stock SEGUN FILTRO
    Public Function ObtenerStockFiltro(filtro As String) As DataTable
        Return objStock.QryListarStockFiltro(filtro)
    End Function

    ' Funcion que lista los productos en el combobox
    Public Function listarProductos() As DataTable
        Return objProducto.QryListarProductos
    End Function

    ' Función que genera el número de lote
    Public Function setNumeroLote(idproducto As String)
        Dim dt As DataTable = objStock.QryUltNumeroLote(idproducto)
        Dim row As DataRow = dt.Rows(0)
        Dim num As Integer

        If IsDBNull(row("NUM")) Then
            num = 1
        Else
            num = CInt(row("NUM"))
        End If

        Dim hoy As String = DateTime.Now.ToString("ddMMyyyy")

        Dim nlote As String = hoy + num.ToString().PadLeft(3, "0") + idproducto

        Return nlote
    End Function


End Class
