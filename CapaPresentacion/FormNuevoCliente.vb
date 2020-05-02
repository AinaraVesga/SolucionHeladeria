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
    End Sub
End Class