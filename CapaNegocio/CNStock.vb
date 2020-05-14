Imports CapaDatos
Imports CapaEntidad

Public Class CNStock
    Dim objStock As New CDStock

    ' Funcion que devuelve la lista de productos en stock
    Public Function ObtenerStock() As DataTable
        Return objStock.QryListarStock()
    End Function

    ' Funcion que devuelve la lista de stock SEGUN FILTRO
    Public Function ObtenerStockFiltro(filtro As String) As DataTable
        Return objStock.QryListarStockFiltro(filtro)
    End Function


End Class
