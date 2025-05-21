Public Class FormBusquedaPaquetes

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaPaquetes 2,'" & txtBusqueda.Text & "'")
    End Sub

    Private Sub FormBusquedaPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaPaquetes 1,''")
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaPaquetes 1,''")
    End Sub

    Private Sub FormBusquedaPaquetes_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        FormCotizaciones.Enabled = True
    End Sub

    Private Sub dgvBusqueda_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentDoubleClick
        IdPaquete = dgvBusqueda.CurrentRow.Cells(0).Value
        NombrePaquete = dgvBusqueda.CurrentRow.Cells(1).Value.ToString
        DescripcionPaquete = dgvBusqueda.CurrentRow.Cells(2).Value.ToString
        precioPaquete = dgvBusqueda.CurrentRow.Cells(3).Value
        Me.Hide()
        FormCotizaciones.lblNumPaquete.Text = IdPaquete
        FormCotizaciones.lblNombre.Text = NombrePaquete
        FormCotizaciones.lblDescripcion.Text = DescripcionPaquete
        FormCotizaciones.lblPrecio.Text = precioPaquete
        FormCotizaciones.Enabled = True
        FormCotizaciones.layoutFecha.Enabled = True
    End Sub
End Class