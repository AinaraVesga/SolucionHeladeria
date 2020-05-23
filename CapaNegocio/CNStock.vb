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
    Public Function setNumeroLote(idproducto As String) As CENLote
        Dim dt As DataTable = objStock.QryUltNumeroLote(idproducto)
        Dim row As DataRow = dt.Rows(0)
        Dim num As Integer

        num = CInt(row("NUMERO")) + 1

        Dim hoy As String = DateTime.Now.ToString("ddMMyyyy")

        Dim nlote As String = hoy + num.ToString().PadLeft(3, "0") + idproducto

        Dim lote As New CENLote(nlote, num)

        Return lote
    End Function

    ' Funcion que devuelve la lista de envases
    Public Function listarEnvases() As DataTable
        Return objStock.QryListarEnvases
    End Function

    ' Función para crear una tabla intermedia de stock
    Public Sub crearTablaIntermedia()

        Try
            objStock.CmdDropTablaIntermedia()
        Catch ex As Exception
            Console.WriteLine("No existe tabla INSERTAR")
        End Try

        objStock.CmdCrearTablaIntermedia()
    End Sub

    ' Función para crear y listar las líneas de la tabla intermedia
    Public Function listarTablaIntermedia() As DataTable
        Return objStock.QryListarTablaIntermedia
    End Function

    ' Funcion para calcular el consumo preferente
    Public Function confumoPref()
        Dim hoy = DateTime.Now
        hoy = DateAdd("y", 30, hoy)
        Dim consumop = hoy.ToString("dd-MM-yyyy")
        Return consumop
    End Function

    ' Funcion para insertar lineas en la tabla intermedia
    Public Function insertarTablaIntermedia(idproducto As String, idenvase As String, nlote As String, numero As Integer, consumop As String, unidades As Integer, precio As Double)
        Dim stock As New CEStock(idproducto, idenvase, nlote, numero, consumop, unidades, precio)
        Dim ok As Boolean

        Dim dt = objStock.QryUnidadesTablaIntermedia(idenvase)
        If dt.Rows.Count = 0 Then
            ok = objStock.CmdInsertarTablaIntermedia(stock)
        Else
            Dim u As Integer = dt.Rows(0)("UNIDADES")
            unidades += u
            ok = objStock.CmdUpdateTablaIntermedia(idenvase, unidades)
        End If

        Return ok
    End Function

    ' Funcion para eliminar una línea de la tabla intermedia
    Public Function deleteTablaIntermedia(idproducto As String, idenvase As String, nlote As String)
        Dim ok = objStock.CmdDeleteTablaIntermedia(idproducto, idenvase, nlote)
        Return ok
    End Function

    ' Función para insertar los datos de la tabla intermedia al stock y eliminar la tabla intermedia
    Public Sub insertarStock(idproducto As String, numero As Integer)
        objStock.CmdInsertarStock()
        objStock.CmdUpdateNumeroProducto(idproducto, numero)
        objStock.CmdDropTablaIntermedia()
    End Sub

    ' Función para obtener el nombre del producto
    Public Function nombreProducto(idproducto As String)
        Dim dt = objStock.QryNombreProducto(idproducto)
        Dim nombre As String = dt.Rows(0)("NOMBRE")
        Return nombre
    End Function

    ' Función para obtener la capacidad de un envase
    Public Function capacidadEnvase(idenvase As String)
        Dim dt = objStock.QryCapacidadEnvase(idenvase)
        Dim capacidad As Double = dt.Rows(0)("CAPACIDAD")
        Return capacidad
    End Function

    ' función para actualizar las unidades de un stock
    Public Function updateStock(idproducto As String, idenvase As String, nlote As String, unidades As Integer)
        Dim ok = objStock.CmdUpdateStock(idproducto, idenvase, nlote, unidades)
        Return ok
    End Function

    ' funcion para eliminar una línea del stock
    Public Function deleteStock(idproducto As String, idenvase As String, nlote As String)
        Dim ok = objStock.CmdDeleteStock(idproducto, idenvase, nlote)
        Return ok
    End Function


End Class
