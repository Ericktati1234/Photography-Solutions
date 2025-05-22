Public Class FormPaquetesALTA
    Sub reiniciar()
        txtNombre.Text = ""
        txtDescripcion.Text = ""
        numPrecio.Value = 0

    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtDescripcion.Text) Or numPrecio.Value = 0 Then
            MessageBox.Show("Favor de rellenar todos los campos", "Atencion")
        Else
            If MessageBox.Show("Quieres dar de alta a este nuevo Paquete? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim sqlcmdComando As New SqlClient.SqlCommand
                sqlcmdComando.CommandText = "sp_Paquetes_ABM 1,NULL,'" & txtNombre.Text & "','" & txtDescripcion.Text & "'," & numPrecio.Value
                sqlcmdComando.Connection = sqlConexion
                Dim sqldrDatos As SqlClient.SqlDataReader
                sqldrDatos = sqlcmdComando.ExecuteReader
                sqldrDatos.Read()
                sqldrDatos.Close()
                MessageBox.Show("Se ha dado de alta el paquete con Exito!", "EXITO")
                Me.Close()
                LlenaGrid(sqlConexion, FormPaquetesVisualizar.dgvPaquetes, "sp_BusquedaPaquetes 1,''")
                FormPaquetesVisualizar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        If MessageBox.Show("Quieres reiniciar todos los campos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            reiniciar()
            txtNombre.Focus()
        End If
    End Sub

    Private Sub FormPaquetesALTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numPrecio.Minimum = 0
        numPrecio.Maximum = 1000000
        reiniciar()

    End Sub

    Private Sub FormPaquetesALTA_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        FormPaquetesVisualizar.btnNuevo.Focus()

        FormPaquetesVisualizar.Enabled = True
    End Sub
End Class