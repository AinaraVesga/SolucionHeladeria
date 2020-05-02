Imports CapaNegocio

Public Class FormNuevoCliente

    Private Sub FormNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarFrecuenciaCbo()
    End Sub

    Private Sub listarFrecuenciaCbo()
        Dim objCapaNegocio As New CNFacturacion
        Dim frec = objCapaNegocio.frecuencias()

        cboFacturacion.DataSource = frec
        cboFacturacion.DisplayMember = "FRECUENCIA"
        cboFacturacion.ValueMember = "FRECUENCIA"

        ' Seleccionamos NINGUNO primero
        Dim index = cboFacturacion.FindString("NINGUNO")
        cboFacturacion.SelectedIndex = index

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim formNuevaFact As New FormNuevaFacturacion
        formNuevaFact.Show()
        Close()
    End Sub
End Class