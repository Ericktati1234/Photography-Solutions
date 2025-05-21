Public Class FormBusquedaClientes
    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 2,'" & txtBusqueda.Text & "'")
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 1,''")
    End Sub

    Private Sub FormBusquedaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 1,''")
    End Sub

    Private Sub dgvBusqueda_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentDoubleClick
        IdCliente = dgvBusqueda.CurrentRow.Cells(0).Value
        NombreCliente = dgvBusqueda.CurrentRow.Cells(1).Value.ToString
        FechaNacimientoCliente = dgvBusqueda.CurrentRow.Cells(2).Value
        NumeroTelefonicoCliente = dgvBusqueda.CurrentRow.Cells(3).Value
        CorreoCliente = dgvBusqueda.CurrentRow.Cells(4).Value.ToString
        Me.Hide()
        FormCotizaciones.Show()
        FormCotizaciones.lblUsuario.Text = NombreUsuario
        FormCotizaciones.lblCliente.Text = NombreCliente
        FormCotizaciones.Enabled = True
    End Sub

    Private Sub FormBusquedaClientes_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Enabled = True
    End Sub

End Class