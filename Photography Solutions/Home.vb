Imports System.Net

Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sqlConexion = New SqlClient.SqlConnection
        sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = AdminPS; data source = 10.20.11.137,1433; persist security info = False; initial catalog = photography_solutions; password= Admin123!; pooling =FALSE"
        sqlConexion.Open()
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "select name from clients"
        sqlcmdComando.Connection = sqlConexion
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader
        sqldrDatos.Read()
        Label1.Text = sqldrDatos.GetValue(0)
        sqldrDatos.Close()

    End Sub


End Class