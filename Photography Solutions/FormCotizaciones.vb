Imports System.Data.SqlClient

Public Class FormCotizaciones
    Private Sub FormCotizaciones_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Enabled = True
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
            End If

            lblFecha.Text = fechaSeleccionada
        End If

    End Sub

    Private Sub btnCambiarCliente_Click(sender As Object, e As EventArgs) Handles btnCambiarCliente.Click
        Me.Enabled = False
        MessageBox.Show("Elige un cliente por favor", "Atencion")
        FormBusquedaClientes.Show()
    End Sub
End Class