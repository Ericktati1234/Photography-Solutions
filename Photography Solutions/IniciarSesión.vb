
Imports System.Net

Public Class IniciarSesión
    Private Sub Button1_Click(sender As Object, e As EventArgs)

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
        Dim Rol = sqldrDatos.GetValue(0)
        Dim Nombre As String = sqldrDatos.GetValue(1).ToString
        IdUsuario = sqldrDatos.GetValue(2).ToString
        Dim Mensaje = sqldrDatos.GetValue(3).ToString
        If Rol <> 0 Then
            If Rol = 1 Then
                MessageBox.Show("Bienvenido " & Nombre & ", " & Mensaje, "ATENCION")
                Home.Show()
                Home.TSMIHome.Visible = True
                Me.Hide()
            ElseIf Rol = 2 Then
                MessageBox.Show("Bienvenido " & Nombre & ", " & Mensaje, "ATENCION")
                Home.Show()
                Me.Hide()
            ElseIf Rol = 3 Then
                MessageBox.Show("Bienvenido " & Nombre & ", " & Mensaje, "ATENCION")
                Home.Show()
                Home.TSMIHome.Visible = True
                Home.TSMIHome.DropDownItems(0).Visible = False
                Home.TSMIHome.DropDownItems(1).Visible = False
                Me.Hide()
            End If
        Else
            MessageBox.Show(Mensaje, "ERROR")
        End If
        sqldrDatos.Close()
    End Sub


End Class
