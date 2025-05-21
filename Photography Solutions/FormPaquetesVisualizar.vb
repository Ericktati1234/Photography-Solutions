Public Class FormPaquetesVisualizar
    Sub ReiniciarVentana()
        LlenaGrid(sqlConexion, dgvPaquetes, "sp_BusquedaPaquetes 1,''")
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        txtNombrePaquete.Enabled = False
        txtDescripcion.Enabled = False
        txtPrecio.Enabled = False
        txtNombrePaquete.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        lblIdPaquete.Text = "default"

    End Sub

    Private Sub FormPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaGrid(sqlConexion, dgvPaquetes, "sp_BusquedaPaquetes 1,''")

        dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvPaquetes.DefaultCellStyle.Font = New Font("Arial", 12)
        dgvPaquetes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        dgvPaquetes.RowsDefaultCellStyle.BackColor = Color.White
        dgvPaquetes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvPaquetes.EnableHeadersVisualStyles = False
        dgvPaquetes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvPaquetes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPaquetes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)

        dgvPaquetes.AllowUserToAddRows = False
        dgvPaquetes.ReadOnly = True

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If lblIdPaquete.Text = "default" Then
            MessageBox.Show("Favor de seleccionar un Paquete para editar", "Atencion")
        Else
            txtNombrePaquete.Enabled = True
            txtDescripcion.Enabled = True
            txtPrecio.Enabled = True
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True
            btnNuevo.Enabled = False
            btnEliminar.Enabled = False
            btnEditar.Enabled = False
        End If

    End Sub

    Private Sub dgvPaquetes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPaquetes.SelectionChanged
        If dgvPaquetes.CurrentRow IsNot Nothing Then
            Dim idPaquete As Integer = dgvPaquetes.CurrentRow.Cells(0).Value
            Dim NombrePaquete As String = dgvPaquetes.CurrentRow.Cells(1).Value.ToString
            Dim DescripcionPaquete As String = dgvPaquetes.CurrentRow.Cells(2).Value.ToString
            Dim PrecioPaquete As String = dgvPaquetes.CurrentRow.Cells(3).Value


            lblIdPaquete.Text = idPaquete
            txtNombrePaquete.Text = NombrePaquete
            txtDescripcion.Text = DescripcionPaquete
            txtPrecio.Text = PrecioPaquete


        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombrePaquete.Text = "" Or txtDescripcion.Text = "" Or txtPrecio.Text = "" Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_Paquetes_ABM 2," & lblIdPaquete.Text & ",'" & txtNombrePaquete.Text & "','" & txtDescripcion.Text & "'," & txtPrecio.Text
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
        If lblIdPaquete.Text = "default" Then
            MessageBox.Show("Favor de seleccionar un Paquete para eliminar", "Atencion")
        Else
            If MessageBox.Show("Seguro que quieres eliminar el paquete " & txtNombrePaquete.Text & "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_Paquetes_ABM 3," & lblIdPaquete.Text & ",NULL,NULL,NULL"
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