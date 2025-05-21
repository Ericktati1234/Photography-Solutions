Imports System.Net

Public Class Home
    Private Sub PausaVentana()
        Me.Enabled = False
    End Sub
    Private Sub Reinicio()
        TSMIHome.Visible = False
    End Sub
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

        ' Se configura el Titulo de la Ventana del Home
        Me.Text = "BIENVENIDO " & NombreUsuario

        LlenaGrid(sqlConexion, DgvAgendados, "sp_ConsultasAvanzadas 2,''," & IdUsuario)
        LlenaGrid(sqlConexion, DgvFinalizados, "sp_ConsultasAvanzadas 1,''," & IdUsuario)
        'Configurar DataGridView(Ajuste automático de columnas y fuente)
        DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvAgendados.DefaultCellStyle.Font = New Font("Arial", 15)
        DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 16, FontStyle.Bold)

        DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvFinalizados.DefaultCellStyle.Font = New Font("Arial", 15)
        DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 16, FontStyle.Bold)

        ' Ajustar columnas específicas al contenido del texto
        'DgvAgendados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'DgvAgendados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        'DgvFinalizados.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'DgvFinalizados.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        ' Ocultar la columna de input (columna de selección)
        DgvAgendados.RowHeadersVisible = False
        DgvFinalizados.RowHeadersVisible = False

        DgvAgendados.AllowUserToAddRows = False
        DgvFinalizados.AllowUserToAddRows = False

        DgvAgendados.ReadOnly = True
        DgvFinalizados.ReadOnly = True

    End Sub

    Private Sub AltaDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptUsuarios.Click
        NuevoUsuario.Show()
        PausaVentana()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCotizacionNueva.Click
        PausaVentana()
        MessageBox.Show("Elige un cliente por favor", "Atencion")
        LimpiarRegistros()
        FormBusquedaClientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FormIniciarSesión.Show()
        Me.Hide()
    End Sub
End Class