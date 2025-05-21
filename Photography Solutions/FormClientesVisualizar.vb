Public Class FormClientesVisualizar
    Sub ReiniciarVentana()
        LlenaGrid(sqlConexion, dgvClientes, "sp_BusquedaClientes 1,NULL")
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtCliente.Enabled = False
        txtCorreo.Enabled = False
        txtFecha.Enabled = False
        txtTelefono.Enabled = False

        txtCliente.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtFecha.Text = ""
        lblIdCliente.Text = "default"
    End Sub
    Private Sub FormAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvClientes, "sp_BusquedaClientes 1,NULL")

        dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvClientes.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvClientes.RowsDefaultCellStyle.BackColor = Color.White
        dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvClientes.EnableHeadersVisualStyles = False
        dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        dgvClientes.AllowUserToAddRows = False
        dgvClientes.ReadOnly = True

    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FormClienteALTA.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lblIdCliente.Text = "default" Then
            MessageBox.Show("Favor de seleccionar un Cliente para editar", "Atencion")
        Else
            txtCliente.Enabled = True
            txtCorreo.Enabled = True
            txtTelefono.Enabled = True
            txtFecha.Enabled = True
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnEliminar.Enabled = False
            btnEditar.Enabled = False
        End If

    End Sub

    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.CurrentRow IsNot Nothing Then
            Dim idCliente As Integer = dgvClientes.CurrentRow.Cells(0).Value
            Dim NombreCliente As String = dgvClientes.CurrentRow.Cells(1).Value.ToString
            Dim FechaNacimiento As String = Convert.ToDateTime(dgvClientes.CurrentRow.Cells(2).Value.ToString).ToString("yyyy-MM-dd")
            Dim TelefonoCliente As String = dgvClientes.CurrentRow.Cells(3).Value.ToString
            Dim CorreoCliente As String = dgvClientes.CurrentRow.Cells(4).Value

            lblIdCliente.Text = idCliente
            txtCliente.Text = NombreCliente
            txtFecha.Text = FechaNacimiento
            txtTelefono.Text = TelefonoCliente
            txtCorreo.Text = CorreoCliente

        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCliente.Text = "" Or txtCorreo.Text = "" Or txtTelefono.Text = "" Or txtFecha.Text = "" Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_Clientes_ABM 2," & lblIdCliente.Text & ",'" & txtCliente.Text & "','" & Convert.ToDateTime(txtFecha.Text).ToString("yyyy-MM-dd") & "','" & txtTelefono.Text & "','" & txtCorreo.Text & "'"
                sqlcmdComando.Connection = sqlConexion
                Dim sqldrDatos As SqlClient.SqlDataReader
                sqldrDatos = sqlcmdComando.ExecuteReader
                sqldrDatos.Read()
                sqldrDatos.Close()
                MessageBox.Show("Se han guardado los cambios con Exito!", "EXITO")
                ReiniciarVentana()

            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ReiniciarVentana()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lblIdCliente.Text = "default" Then
            MessageBox.Show("Favor de seleccionar un Cliente para eliminar", "Atencion")
        Else
            If MessageBox.Show("Seguro que quieres eliminar al cliente " & txtCliente.Text & "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_Clientes_ABM 3," & lblIdCliente.Text & ",NULL,NULL,NULL,NULL"
                sqlcmdComando.Connection = sqlConexion
                Dim sqldrDatos As SqlClient.SqlDataReader
                sqldrDatos = sqlcmdComando.ExecuteReader
                sqldrDatos.Read()
                sqldrDatos.Close()
                MessageBox.Show("Se ha eliminado al cliente", "EXITO")
                ReiniciarVentana()

            End If
        End If
    End Sub
End Class