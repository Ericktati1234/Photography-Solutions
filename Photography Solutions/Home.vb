Imports System.Net

Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Se crea la nueva conexión con la base de datos, para posteriormente abrirla.
        sqlConexion = New SqlClient.SqlConnection
        ' Para esto se  debe especificar los parámetros necesarios para su funcionamiento, entre los más destacados estando el id y la contraseña.
        sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = AdminPS; data source = localhost,1433; persist security info = False; initial catalog = photography_solutions; password= Admin123!; pooling =FALSE"
        sqlConexion.Open()

        ' Se crea un nuevo comando de SQL, al cual se le asigna la query.
        ' Esta se asigna a la conexión creada anteriormente.
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "select name from clients"
        sqlcmdComando.Connection = sqlConexion

        ' Se crea un lector de datos, el cual ejecutará la query anterior. Leerá la primera fila de datos.
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader
        sqldrDatos.Read()

        ' Tomará el primer valor encontrado en la lectura y lo asignará como texto a Label1.
        Label1.Text = sqldrDatos.GetValue(0)
        sqldrDatos.Close()

    End Sub


End Class