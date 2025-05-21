


Public Class FormIniciarSesión
    Private Sub LimpiarVentana()
        Me.TxtUsuario.ResetText()
        Me.TxtContrasena.ResetText()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConexion = New SqlClient.SqlConnection
        sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = AdminPS; data source = localhost; persist security info = False; initial catalog = PhotographySolutions; password= Admin123!; pooling =FALSE"
        sqlConexion.Open()
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "sp_LoginUsuario '" & TxtUsuario.Text & "','" & TxtContrasena.Text & "';"
        sqlcmdComando.Connection = sqlConexion
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader
        sqldrDatos.Read()
        Rol = sqldrDatos.GetValue(0)
        NombreUsuario = sqldrDatos.GetValue(1).ToString
        IdUsuario = sqldrDatos.GetValue(2).ToString
        Dim Mensaje = sqldrDatos.GetValue(3).ToString
        sqldrDatos.Close()
        If Rol <> 0 Then
            If Rol = 1 Then
                MessageBox.Show("Bienvenido " & NombreUsuario & ", " & Mensaje, "ATENCION")
                Home.Show()
                Home.TSMIHome.Visible = True
                LimpiarVentana()
                Me.Hide()
            ElseIf Rol = 2 Then
                MessageBox.Show("Bienvenido " & NombreUsuario & ", " & Mensaje, "ATENCION")
                Home.Show()
                LimpiarVentana()
                Me.Hide()
            ElseIf Rol = 3 Then
                MessageBox.Show("Bienvenido " & NombreUsuario & ", " & Mensaje, "ATENCION")
                Home.Show()
                LimpiarVentana()
                Home.TSMIHome.Visible = True
                Home.TSMIHome.DropDownItems(0).Visible = False
                Home.TSMIHome.DropDownItems(1).Visible = False
                Me.Hide()
            End If
        Else
            MessageBox.Show(Mensaje, "ERROR")
        End If

    End Sub

    Private Sub FormIniciarSesión_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        System.Environment.Exit(0)
    End Sub
End Class
