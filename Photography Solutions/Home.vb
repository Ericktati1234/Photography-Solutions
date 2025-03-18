Imports System.Net

Public Class Home


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.None  ' Elimina los bordes
        Me.MaximizeBox = False  ' Deshabilita la opción de maximizar (aunque la ventana estará maximizada)
        Me.MinimizeBox = False  ' Deshabilita la opción de minimizar
        Me.ControlBox = False  ' Deshabilita el cuadro de control (minimizar, maximizar, cerrar)
        Me.StartPosition = FormStartPosition.CenterScreen  ' Centra la ventana en la pantalla

        ' Asegura que la ventana esté maximizada al tamaño completo de la pantalla
        Me.WindowState = FormWindowState.Maximized  ' Maximiza la ventana

        ' Configura la ventana para que tenga el tamaño máximo disponible en la pantalla
        Me.Bounds = Screen.PrimaryScreen.Bounds

        ' Se crea la nueva conexión con la base de datos, para posteriormente abrirla.
        sqlConexion = New SqlClient.SqlConnection
        ' Para esto se  debe especificar los parámetros necesarios para su funcionamiento, entre los más destacados estando el id y la contraseña.
        sqlConexion.ConnectionString = "workstation id = " & Dns.GetHostName & "; packet size = 8192; user id = AdminPS; data source = localhost,1433; persist security info = False; initial catalog = photography_solutions; password= Admin123!; pooling =FALSE"
        sqlConexion.Open()

        ' Se crea un nuevo comando de SQL, al cual se le asigna la query.
        ' Esta se asigna a la conexión creada anteriormente.
        Dim sqlcmdComando As New SqlClient.SqlCommand
        sqlcmdComando.CommandText = "Select name from users where id = " & IdUsuario
        sqlcmdComando.Connection = sqlConexion

        ' Se crea un lector de datos, el cual ejecutará la query anterior. Leerá la primera fila de datos.
        Dim sqldrDatos As SqlClient.SqlDataReader
        sqldrDatos = sqlcmdComando.ExecuteReader
        sqldrDatos.Read()
        lblUsuario.Text = sqldrDatos.GetValue(0)
        Me.Text = "BIENVENIDO " & lblUsuario.Text

        ' Tomará el primer valor encontrado en la lectura y lo asignará como texto a Label1.

        sqldrDatos.Close()

        LlenaGrid(sqlConexion, DgvAgendados, "select s.title,s.status,s.session_date as FECHA_SESION ,c.name as NombreCliente from sessions s inner join clients c on s.client = c.client_id where session_date > GETDATE() and fotographer =" & IdUsuario)
        LlenaGrid(sqlConexion, DgvFinalizados, "select s.title,s.status,s.session_date as FECHA_SESION ,c.name as NombreCliente from sessions s inner join clients c on s.client = c.client_id where session_date < GETDATE() and fotographer =" & IdUsuario)
        ' Configurar DataGridView (Ajuste automático de columnas y fuente)
        DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvAgendados.DefaultCellStyle.Font = New Font("Arial", 18)
        DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 19, FontStyle.Bold)

        DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvFinalizados.DefaultCellStyle.Font = New Font("Arial", 19)
        DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 20, FontStyle.Bold)

        ' Ajustar columnas específicas al contenido del texto
        DgvAgendados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvAgendados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        DgvFinalizados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DgvFinalizados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        ' Ocultar la columna de input (columna de selección)
        DgvAgendados.RowHeadersVisible = False
        DgvFinalizados.RowHeadersVisible = False

        DgvAgendados.AllowUserToAddRows = False
        DgvFinalizados.AllowUserToAddRows = False

        DgvAgendados.ReadOnly = True
        DgvFinalizados.ReadOnly = True





    End Sub

    Private Sub AltaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDeUsuariosToolStripMenuItem.Click
        Dim nuevoUsuarioForm As New NuevoUsuario()
        nuevoUsuarioForm.Show()
    End Sub

    Private Sub AltaDePaquetesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDePaquetesToolStripMenuItem.Click
        Dim almacenForm As New Almacen()
        almacenForm.Show()
    End Sub

    Private Sub ManejoDeSesionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManejoDeSesionesToolStripMenuItem.Click
        Dim ManejoDeSesionesForm As New ManejoDeSesiones()
        ManejoDeSesiones.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim ventasForm As New Ventas()
        ventasForm.Show()
    End Sub


End Class