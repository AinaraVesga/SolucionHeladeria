Imports System.Data
Imports CapaDatos
Imports CapaEntidad


Module Program
    Sub Main(args As String())

        Console.WriteLine("PRUEBAS DE ACCESO A DATOS")

        Dim objDClientes As New CDClientes
        Dim cliente As New CECliente("C012", "ELENA", "HARROBIETA", "IRUN", "636779427", "44567925L", "ELENA@GMAIL.COM", "1234", 0, "NIN")

        Console.WriteLine(cliente.cif)
        objDClientes.QryListarClientes()



    End Sub
End Module
