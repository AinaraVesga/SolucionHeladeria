Imports CapaDatos

Public Class CNDatosIVA
    ' CREAMOS EL OBJETO DE CAPA DATOS
    Dim objCapaDatos As New CDDatosIVA

    ' IMPLEMENTAMOS LA FUNCIÓN QUE DEVUELVE LA LISTA DE IVA
    Public Function ObtenerIVA() As DataTable
        Return objCapaDatos.QrylistarIVA
    End Function

End Class
