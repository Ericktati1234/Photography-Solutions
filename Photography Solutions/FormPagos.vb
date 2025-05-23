Public Class FormPagos
    Private Sub FormPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCuantoDebe.Text = "Se desea realizar un pago para la sesion número " & idSesion & " con un Faltante de " & Faltante & ". Si desea confirmar el pago favor de dar click al boton."
    End Sub

    Private Sub btnConfirmarOrden_Click(sender As Object, e As EventArgs) Handles btnConfirmarOrden.Click
        If MessageBox.Show("Estas seguro de realizar el pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sqlcmdComando As New SqlClient.SqlCommand
            sqlcmdComando.CommandText = "sp_AgregarPago " & idSesion & "," & Faltante & ",'" & Today.Date.ToString("yyyy-MM-dd") & "'"
            sqlcmdComando.Connection = sqlConexion
            Dim sqldrDatos As SqlClient.SqlDataReader
            sqldrDatos = sqlcmdComando.ExecuteReader
            sqldrDatos.Read()
            sqldrDatos.Close()
            MessageBox.Show("PAGO REALIZADO CON EXITO", "EXITO")
            Me.Close()
            Home.Enabled = True
            Home.llenadoGrid()
        Else
            MessageBox.Show("Pago cancelado", "Atencion")
        End If

    End Sub

    Private Sub FormPagos_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Enabled = True
    End Sub
End Class