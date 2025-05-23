Imports System.Data.SqlClient

Public Class FormCotizaciones
    Private Sub FormCotizaciones_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Enabled = True
    End Sub

    Sub PrepararImpresion()
        layoutCliente.Enabled = False
        LayoutGeneral.Enabled = False
        LayoutConsideraciones.Enabled = False
        btnConfirmarOrden.Enabled = False
        btnImprimirNota.Enabled = True

    End Sub

    Private Sub NombreSearch_Click(sender As Object, e As EventArgs) Handles NombreSearch.Click
        Me.Enabled = False
        FormBusquedaPaquetes.Show()
    End Sub

    Private Sub FormCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = False
        CalendarioFechasLibres.MinDate = Today.AddDays(1)
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "sp_FechasOcupadas"
        sqlcmdComando.Connection = sqlConexion
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader

        Dim fechasBold As New List(Of Date)




        While sqldrDatos.Read()
            Dim fecha As Date = Convert.ToDateTime(sqldrDatos.GetValue(0))
            fechasBold.Add(fecha)
        End While
        CalendarioFechasLibres.BoldedDates = fechasBold.ToArray()
        sqldrDatos.Close()

        numAnticipo.Minimum = 0
        numAnticipo.Maximum = 10000

        numAnticipoExtra.Minimum = 0
        numAnticipoExtra.Maximum = 10000

        numExtras.Minimum = 0
        numExtras.Maximum = 10000
    End Sub

    Private Sub CalendarioFechasLibres_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarioFechasLibres.DateSelected
        Dim fechaSeleccionada As Date = e.Start.Date
        If CalendarioFechasLibres.BoldedDates.Contains(e.Start.Date) Then
            MessageBox.Show("¡Esa fecha está ocupada (en negrita)!")
        Else
            If MessageBox.Show("Quieres asignar un evento para la fecha " & e.Start.Date & " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MessageBox.Show("Fecha " & e.Start.Date & " seleccionada")
                layoutFecha.Enabled = False
                LayoutPagos.Enabled = True
                layoutDetalles.Enabled = True
                lblTotalAnticipo.Text = lblPrecio.Text
                lblFecha.Text = fechaSeleccionada
                MessageBox.Show("Define cuanto será el anticipo que va a dejar el cliente?", "Atencion")
                numAnticipo.Focus()
            Else
                MessageBox.Show("Selecciona la fecha de la sesion", "Atencion")
                CalendarioFechasLibres.Focus()
            End If

        End If

    End Sub

    Private Sub btnCambiarCliente_Click(sender As Object, e As EventArgs) Handles btnCambiarCliente.Click
        Me.Enabled = False
        Me.Hide()
        MessageBox.Show("Elige un cliente por favor", "Atencion")
        FormBusquedaClientes.Show()
    End Sub

    Private Sub numAnticipo_ValueChanged(sender As Object, e As EventArgs) Handles numAnticipo.ValueChanged
        If Convert.ToInt32(lblPrecio.Text) >= numAnticipo.Value Then
            If Convert.ToInt32(lblPrecio.Text) * 0.3 > numAnticipo.Value Then
                MessageBox.Show("El anticipo debe de ser mayor al 30% del Pago: " & Convert.ToInt32(lblPrecio.Text) * 0.3, "Atencion")
                lblFaltanteAnticipo.Text = (Convert.ToInt32(lblPrecio.Text) - numAnticipo.Value).ToString()
                btnConfirmarOrden.Enabled = False
                layoutExtras.Enabled = False
            Else
                lblFaltanteAnticipo.Text = (Convert.ToInt32(lblPrecio.Text) - numAnticipo.Value).ToString()
                btnConfirmarOrden.Enabled = True
                layoutExtras.Enabled = True
                MessageBox.Show("Define los detalles de la sesion de fotos en CONSIDERACIONES ESPECIALES", "Atencion")
                txtConsideraciones.Focus()
            End If
        Else
            MessageBox.Show("Favor de escribir un anticipo menor al Precio Total: " & Convert.ToInt32(lblPrecio.Text), "Atencion")
            btnConfirmarOrden.Enabled = False
            layoutExtras.Enabled = False
            lblFaltanteAnticipo.Text = "Error"
        End If


    End Sub

    Private Sub btnConfirmarOrden_Click(sender As Object, e As EventArgs) Handles btnConfirmarOrden.Click
        If MessageBox.Show("Confirmacion Fecha: " & lblFecha.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If MessageBox.Show("Confirmacion Paquete: " & lblNombre.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If MessageBox.Show("Confirmacion Anticipo general: " & numAnticipo.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If numExtras.Value > 0 Then

                        If MessageBox.Show("Confirmacion Anticipo Extras: " & numAnticipoExtra.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            If MessageBox.Show("Todo confirmado!, da click en SI para dar de alta la cotizacion ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                                Dim sqlcmdComando As New SqlClient.SqlCommand
                                sqlcmdComando.CommandText = "sp_Cotizaciones_ABM 1,NULL," & IdCliente & "," & IdUsuario & "," & IdPaquete & ",'" & Today.Date.ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd") & "','" & txtConsideraciones.Text & "'," & numExtras.Value & ",'No Entregado'," & numAnticipo.Value & "," & numAnticipoExtra.Value
                                sqlcmdComando.Connection = sqlConexion
                                Dim sqldrDatos As SqlClient.SqlDataReader
                                sqldrDatos = sqlcmdComando.ExecuteReader
                                sqldrDatos.Read()
                                sqldrDatos.Close()
                                MessageBox.Show("COTIZACION REALIZADA CON EXITO", "EXITO")
                                btnConfirmarOrden.Enabled = False
                                btnImprimirNota.Enabled = True
                                PrepararImpresion()
                                Home.Enabled = True
                                Home.llenadoGrid()
                                btnImprimirNota.Focus()
                            Else
                                MessageBox.Show("Cotizacion interrumpida", "Error")
                            End If

                        End If
                    Else
                        If MessageBox.Show("Todo confirmado!, da click en SI para dar de alta la cotizacion ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                            Dim sqlcmdComando As New SqlClient.SqlCommand
                            sqlcmdComando.CommandText = "sp_Cotizaciones_ABM 1,NULL," & IdCliente & "," & IdUsuario & "," & IdPaquete & ",'" & Today.Date.ToString("yyyy-MM-dd") & "','" & Convert.ToDateTime(lblFecha.Text).ToString("yyyy-MM-dd") & "','" & txtConsideraciones.Text & "',0,'No Entregado'," & numAnticipo.Value & ",0"
                            sqlcmdComando.Connection = sqlConexion
                            Dim sqldrDatos As SqlClient.SqlDataReader
                            sqldrDatos = sqlcmdComando.ExecuteReader
                            sqldrDatos.Read()
                            sqldrDatos.Close()
                            MessageBox.Show("COTIZACION REALIZADA CON EXITO", "EXITO")
                            btnConfirmarOrden.Enabled = False
                            btnImprimirNota.Enabled = True
                            PrepararImpresion()
                            Home.Enabled = True
                            Home.llenadoGrid()
                            btnImprimirNota.Focus()
                        Else
                            MessageBox.Show("Cotizacion interrumpida", "Error")
                        End If

                    End If
                Else
                    MessageBox.Show("Cotizacion interrumpida", "Error")
                End If
            Else
                MessageBox.Show("Cotizacion interrumpida", "Error")
            End If
        Else
            MessageBox.Show("Cotizacion interrumpida", "Error")
        End If
    End Sub

    Private Sub numExtras_ValueChanged(sender As Object, e As EventArgs) Handles numExtras.ValueChanged
        If numExtras.Value > 0 Then
            lblFaltanteExtra.Text = numExtras.Value - numAnticipoExtra.Value
            numAnticipoExtra.Enabled = True
            If numExtras.Value * 0.5 < numAnticipoExtra.Value Then
                btnConfirmarOrden.Enabled = True
            Else
                MessageBox.Show("El anticipo de extras debe de ser mayor al 50% del Pago: " & numExtras.Value * 0.5, "Atencion")
                btnConfirmarOrden.Enabled = False
            End If
        Else
            numAnticipoExtra.Enabled = False
            lblFaltanteExtra.Text = numExtras.Value - numAnticipoExtra.Value
            btnConfirmarOrden.Enabled = True
        End If
    End Sub
    Private Sub numAnticipoExtra_ValueChanged(sender As Object, e As EventArgs) Handles numAnticipoExtra.ValueChanged
        If numAnticipoExtra.Value <= numExtras.Value Then
            If numExtras.Value * 0.5 > numAnticipoExtra.Value And numExtras.Value > 0 Then
                MessageBox.Show("El anticipo de extras debe de ser mayor al 50% del Pago: " & numExtras.Value * 0.5, "Atencion")
                lblFaltanteExtra.Text = numExtras.Value - numAnticipoExtra.Value
                btnConfirmarOrden.Enabled = False
            Else
                lblFaltanteExtra.Text = numExtras.Value - numAnticipoExtra.Value
                btnConfirmarOrden.Enabled = True
                MessageBox.Show("Ya terminaste? Da click en CONFIRMAR ORDEN ", "Atencion")
                btnConfirmarOrden.Focus()
            End If
        Else
            MessageBox.Show("Favor de escribir un anticipo menor al Precio extra: " & numExtras.Value, "Atencion")
            btnConfirmarOrden.Enabled = False
            lblFaltanteExtra.Text = "Error"
        End If


    End Sub

    Private Sub numAnticipoExtra_TextChanged(sender As Object, e As EventArgs) Handles numAnticipoExtra.TextChanged
        If String.IsNullOrWhiteSpace(numAnticipoExtra.Text) Then
            numAnticipoExtra.Value = 0
        End If

    End Sub

    Private Sub numAnticipo_TextChanged(sender As Object, e As EventArgs) Handles numAnticipo.TextChanged
        If String.IsNullOrWhiteSpace(numAnticipo.Text) Then
            numAnticipo.Value = 0
        End If

    End Sub

    Private Sub numExtras_TextChanged(sender As Object, e As EventArgs) Handles numExtras.TextChanged
        If String.IsNullOrWhiteSpace(numExtras.Text) Then
            numExtras.Value = 0
        End If

    End Sub

    Private Sub btnreinicio_Click(sender As Object, e As EventArgs) Handles btnreinicio.Click

        If MessageBox.Show("Estas seguro que quieres reiniciar todos los cambios? (NO PODAS RECUPERAR LA INFORMACION ASIGNADA)", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            FormBusquedaClientes.Show()
        Else
            MessageBox.Show("Reinicio cancelado", "Atencion")
        End If

    End Sub
End Class