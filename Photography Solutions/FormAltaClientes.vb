Public Class FormAltaClientes
    Private Sub FormAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvClientes, "sp_BusquedaClientes 1,NULL")
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        FormClienteALTA.Show()
        Me.Enabled = False
    End Sub
End Class