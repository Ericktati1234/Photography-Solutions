Public Class FormUsuariosVisualizar
    Sub reiniciarventana()
        LlenaGrid(sqlConexion, dgvUsuariosEmpleados, "sp_Empleados_Usuarios_ABM 6,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL")
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtUsuario.Enabled = False
        txtEmpleado.Enabled = False
        txtNacimiento.Enabled = False
        txtUsuario.Text = ""
        txtEmpleado.Text = ""
        txtNacimiento.Text = ""
        lblIdUsuario.Text = "default"
    End Sub
    Private Sub FormUsuariosVisualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reiniciarventana()

        dgvUsuariosEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvUsuariosEmpleados.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvUsuariosEmpleados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvUsuariosEmpleados.RowsDefaultCellStyle.BackColor = Color.White
        dgvUsuariosEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvUsuariosEmpleados.EnableHeadersVisualStyles = False
        dgvUsuariosEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvUsuariosEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvUsuariosEmpleados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        dgvUsuariosEmpleados.AllowUserToAddRows = False
        dgvUsuariosEmpleados.ReadOnly = True
    End Sub


    Private Sub dgvUsuariosEmpleados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsuariosEmpleados.SelectionChanged
        If dgvUsuariosEmpleados.CurrentRow IsNot Nothing Then
            Dim idEmpleado As Integer = dgvUsuariosEmpleados.CurrentRow.Cells(0).Value
            Dim idUsuario As Integer = dgvUsuariosEmpleados.CurrentRow.Cells(1).Value
            Dim NombreEmpleado As String = dgvUsuariosEmpleados.CurrentRow.Cells(2).Value.ToString
            Dim NombreUsuario As String = dgvUsuariosEmpleados.CurrentRow.Cells(7).Value.ToString
            Dim FechaNacimiento As String = dgvUsuariosEmpleados.CurrentRow.Cells(4).Value

            lblIDEmpleado.Text = idEmpleado
            lblIdUsuario.Text = idUsuario
            txtUsuario.Text = NombreUsuario
            txtEmpleado.Text = NombreEmpleado
            txtNacimiento.Text = FechaNacimiento

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        FormUsuariosALTA.Show()
        FormUsuariosALTA.Text = "Alta de Usuarios"
        formEmpleadosALTA.btnEditar.Visible = False
        Me.Enabled = False
        FormUsuariosALTA.btnVerificar.Visible = True
        FormUsuariosALTA.btnVerificarEditado.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lblIdUsuario.Text = "default" Then
            MessageBox.Show("Favor de seleccionar un Usuario para editar", "Atencion")
        Else
            FormUsuariosALTA.Show()
            FormUsuariosALTA.Text = "Edicion de Usuarios"
            formEmpleadosALTA.btnEditar.Visible = True
            idALTA = lblIdUsuario.Text
            idEmpleado = lblIDEmpleado.Text
            FormUsuariosALTA.btnVerificarEditado.Visible = True
            FormUsuariosALTA.btnVerificar.Visible = False
        End If

    End Sub


    Private Sub FormUsuariosVisualizar_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Home.Enabled = True

    End Sub
End Class