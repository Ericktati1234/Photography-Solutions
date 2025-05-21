Public Class FormBusquedaClientes
    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 2,'" & txtBusqueda.Text & "'")
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 1,''")
    End Sub

    Private Sub FormBusquedaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvBusqueda, "sp_BusquedaClientes 1,''")

        dgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvBusqueda.DefaultCellStyle.Font = New Font("Arial", 11)
        dgvBusqueda.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)

        dgvBusqueda.RowsDefaultCellStyle.BackColor = Color.White
        dgvBusqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvBusqueda.EnableHeadersVisualStyles = False
        dgvBusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvBusqueda.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvBusqueda.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 13, FontStyle.Bold)
    End Sub

    Private Sub dgvBusqueda_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBusqueda.CellContentDoubleClick
        IdCliente = dgvBusqueda.CurrentRow.Cells(0).Value
        NombreCliente = dgvBusqueda.CurrentRow.Cells(1).Value.ToString
        FechaNacimientoCliente = dgvBusqueda.CurrentRow.Cells(2).Value
        NumeroTelefonicoCliente = dgvBusqueda.CurrentRow.Cells(3).Value
        CorreoCliente = dgvBusqueda.CurrentRow.Cells(4).Value.ToString
        Me.Hide()
        FormCotizaciones.Show()
        FormCotizaciones.lblUsuario.Text = "Usuario fotografo a cargo: " & NombreUsuario
        FormCotizaciones.lblCliente.Text = "Sesion para el cliente: " & NombreCliente
        FormCotizaciones.Enabled = True
        MessageBox.Show("Selecciona un paquete para la sesion del cliente", "Atencion")
        FormCotizaciones.NombreSearch.Focus()

    End Sub

    Private Sub FormBusquedaClientes_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Enabled = True
    End Sub

End Class