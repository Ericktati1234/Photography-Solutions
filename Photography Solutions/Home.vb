Imports System.Net

Public Class Home
    Private Sub PausaVentana()
        Me.Enabled = False
    End Sub
    Private Sub Reinicio()
        TSMIHome.Visible = False
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Deshabilita la opción de maximizar (aunque la ventana estará maximizada)
        Me.MinimizeBox = False  ' Deshabilita la opción de minimizar
        Me.ControlBox = False  ' Deshabilita el cuadro de control (minimizar, maximizar, cerrar)
        Me.StartPosition = FormStartPosition.CenterScreen  ' Centra la ventana en la pantalla
        Dim pantalla As Screen = Screen.FromControl(Me)
        Dim ancho As Integer = pantalla.Bounds.Width
        Dim alto As Integer = pantalla.Bounds.Height

        Me.MinimumSize = New Size(ancho, alto)

        ' Se configura el Titulo de la Ventana del Home
        Me.Text = "BIENVENIDO " & NombreUsuario

        lblUsuario.Text = "Hola " & NombreUsuario & "!"

        LlenaGrid(sqlConexion, DgvAgendados, "sp_ConsultasAvanzadas 2,''," & IdUsuario)
        LlenaGrid(sqlConexion, DgvFinalizados, "sp_ConsultasAvanzadas 1,''," & IdUsuario)
        'Configurar DataGridView(Ajuste automático de columnas y fuente)
        DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvAgendados.DefaultCellStyle.Font = New Font("Arial", 12)
        DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        DgvAgendados.RowsDefaultCellStyle.BackColor = Color.White
        DgvAgendados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        DgvAgendados.EnableHeadersVisualStyles = False
        DgvAgendados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        DgvAgendados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DgvAgendados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)



        DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvFinalizados.DefaultCellStyle.Font = New Font("Arial", 12)
        DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 13, FontStyle.Bold)

        DgvFinalizados.RowsDefaultCellStyle.BackColor = Color.White
        DgvFinalizados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        DgvFinalizados.EnableHeadersVisualStyles = False
        DgvFinalizados.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        DgvFinalizados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DgvFinalizados.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 14, FontStyle.Bold)


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

    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormIniciarSesión.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FormAltaClientes.Show()
        Me.Enabled = False
    End Sub
End Class