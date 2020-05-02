Imports CapaDatos
Imports CapaEntidad
Public Class CNFacturacion

    ' Creamos el objeto de la capa datos
    Dim objCapaDatos As New CDFacturacion

    ' Funcion que devuelve la lista de frecuencia de facturaciones
    Public Function frecuencias() As DataTable
        Return objCapaDatos.QryListarFacturacionNames
    End Function

    ' Función para generar id de facturacion
    Public Function idFacturacion(frecuencia As String)
        Dim id = ""
        If frecuencia.Length > 0 Then
            If frecuencia.Length = 1 Then
                id = frecuencia.Substring(0, 1)
            ElseIf frecuencia.Length = 2 Then
                id = frecuencia.Substring(0, 2)
            Else
                id = frecuencia.Substring(0, 3)
            End If
        End If
        Return id
    End Function

    ' Función para insertar un tipo de facturacion en la BD
    Public Function insertFacturacion(id As String, frecuencia As String)
        Dim fact As New CEFacturacion(id, frecuencia)
        Dim ok = objCapaDatos.CmdInsert(fact)
        Return ok
    End Function

End Class
