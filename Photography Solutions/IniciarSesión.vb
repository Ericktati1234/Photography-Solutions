
Imports System.Net

Public Class IniciarSesión
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConexion = New SqlClient.SqlConnection
        sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = AdminPS; data source = localhost,1433; persist security info = False; initial catalog = photography_solutions; password= Admin123!; pooling =FALSE"
        sqlConexion.Open()
    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "select * from users where username = '" & TxtUsuario.Text & "' and password = '" & TxtContrasena.Text & "'"
        sqlcmdComando.Connection = sqlConexion
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader
        sqldrDatos.Read()
        IdUsuario = sqldrDatos.GetValue(0)
        Dim Nombre As String = sqldrDatos.GetValue(2).ToString
        Dim Rol As String = sqldrDatos.GetValue(3).ToString
        If Nombre <> "" And Rol <> "" Then
            MessageBox.Show("Bienvenido " & Nombre & " tu eres " & Rol, "ATENCION")
            Home.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrecta")
        End If
        sqldrDatos.Close()
    End Sub


End Class
