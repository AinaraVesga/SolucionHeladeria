Imports CapaDatos
Public Class CNFacturacion

    ' Creamos el objeto de la capa datos
    Dim objCapaDatos As New CDFacturacion

    ' Funcion que devuelve la lista de frecuencia de facturaciones
    Public Function frecuencias() As DataTable
        Return objCapaDatos.QryListarFacturacionNames
    End Function

End Class
