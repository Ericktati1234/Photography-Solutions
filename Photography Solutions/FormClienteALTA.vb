Public Class FormClienteALTA
    Sub reiniciar()
        txtNombre.Text = ""
        txtCorreo.Text = ""
        numTelefono.Value = 1000000000
        lblFecha.Text = "default"
    End Sub

    Private Sub FormClienteALTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CalendarioNacimiento.MaxDate = Today
        numTelefono.Minimum = 1000000000
        numTelefono.Maximum = 10000000000
        reiniciar()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtCorreo.Text) Or numTelefono.Value = 100000000 Or lblFecha.Text = "default" Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres dar de alta a este nuevo cliente? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_BuscarCorreo '" & txtCorreo.Text & "'"
                sqlcmdComando.Connection = sqlConexion
                Dim sqldrDatos As SqlClient.SqlDataReader
                sqldrDatos = sqlcmdComando.ExecuteReader
                sqldrDatos.Read()
                If sqldrDatos.GetValue(0) = 1 Then
                    MessageBox.Show("El correo ya existe favor de elegir uno nuevo", "Atencion")
                    txtCorreo.Focus()
                Else
                    sqldrDatos.Close()
                    sqlcmdComando.CommandText = "sp_Clientes_ABM 1,NULL,'" & txtNombre.Text & "','" & Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd") & "'," & numTelefono.Value & ",'" & txtCorreo.Text & "'"
                    sqlcmdComando.Connection = sqlConexion
                    sqldrDatos = sqlcmdComando.ExecuteReader
                    sqldrDatos.Read()
                    sqldrDatos.Close()
                    MessageBox.Show("Se ha dado de alta al cliente con Exito!", "EXITO")
                    Me.Close()
                    LlenaGrid(sqlConexion, FormClientesVisualizar.dgvClientes, "sp_BusquedaClientes 1,NULL")
                    FormClientesVisualizar.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        If MessageBox.Show("Quieres reiniciar todos los campos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            reiniciar()
            txtNombre.Focus()
        End If

    End Sub

    Private Sub CalendarioNacimiento_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarioNacimiento.DateSelected
        lblFecha.Text = e.Start.Date
    End Sub

    Private Sub FormClienteALTA_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        FormClientesVisualizar.Enabled = True
    End Sub
End Class