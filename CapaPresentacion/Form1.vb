Imports CapaNegocio

Public Class frmListadoIVA
    Private Sub frmListadoIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarPersonas()
    End Sub

    Sub ListarPersonas()
        Dim objCapaNegocio As New CNDatosIVA
        dgvIVA.DataSource = objCapaNegocio.ObtenerIVA
        lblNumeroLineas.Text = objCapaNegocio.ObtenerIVA.Rows.Count
    End Sub

End Class