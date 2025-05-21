' Requiere: Formulario de Windows Forms con los siguientes controles:
' - btnSeleccionarCarpetaA (Button)
' - btnSeleccionarCarpetaB (Button)
' - btnCrearCopiaEditable (Button)
' - btnExportarSeleccionados (Button)
' - btnEliminarSeleccionados (Button)
' - dgvImagenes (DataGridView)
' - PictureBox1 (PictureBox)

Imports System.IO

Public Class GestorImagenesForm

    Private rutaCarpetaA As String
    Private rutaCarpetaB As String
    Private rutaTemporal As String = Path.Combine(Path.GetTempPath(), "ImagenesFiltradas")

    Private Sub GestorImagenesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reiniciar todo al cargar el formulario
        dgvImagenes.Columns.Clear()
        dgvImagenes.Rows.Clear()
        If PictureBox1.Image IsNot Nothing Then
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If

        btnSeleccionarCarpetaB.Enabled = False
        btnCrearCopiaEditable.Enabled = False
        btnExportarSeleccionados.Enabled = False
        btnEliminarSeleccionados.Enabled = False

        dgvImagenes.MultiSelect = False
        dgvImagenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom


        dgvImagenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvImagenes.DefaultCellStyle.Font = New Font("Arial", 11)
        dgvImagenes.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)

        dgvImagenes.RowsDefaultCellStyle.BackColor = Color.White
        dgvImagenes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        dgvImagenes.EnableHeadersVisualStyles = False
        dgvImagenes.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        dgvImagenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvImagenes.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 13, FontStyle.Bold)

        dgvImagenes.AllowUserToAddRows = False

    End Sub

    Private Sub btnSeleccionarCarpetaA_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCarpetaA.Click
        Using fbd As New FolderBrowserDialog()
            If fbd.ShowDialog() = DialogResult.OK Then
                rutaCarpetaA = fbd.SelectedPath
                MessageBox.Show("Carpeta JPG seleccionada", "Exito")
                btnSeleccionarCarpetaA.Enabled = False
                btnSeleccionarCarpetaB.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btnSeleccionarCarpetaB_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCarpetaB.Click
        Using fbd As New FolderBrowserDialog()
            If fbd.ShowDialog() = DialogResult.OK Then
                rutaCarpetaB = fbd.SelectedPath
                MessageBox.Show("Carpeta RAW seleccionada!, Da click en Importar JPG para observar los archivos de la carpeta JPG", "Atencion")
                btnSeleccionarCarpetaB.Enabled = False
                btnCrearCopiaEditable.Enabled = True
            End If
        End Using
    End Sub

    Private Sub btnCrearCopiaEditable_Click(sender As Object, e As EventArgs) Handles btnCrearCopiaEditable.Click
        If Directory.Exists(rutaTemporal) Then
            Directory.Delete(rutaTemporal, True)
        End If
        Directory.CreateDirectory(rutaTemporal)

        For Each archivo In Directory.GetFiles(rutaCarpetaA, "*.jpg")
            File.Copy(archivo, Path.Combine(rutaTemporal, Path.GetFileName(archivo)))
        Next

        CargarImagenesEnGrid()
        btnCrearCopiaEditable.Enabled = False
        btnExportarSeleccionados.Enabled = True
        btnEliminarSeleccionados.Enabled = True
        MessageBox.Show("Con el boton Eliminar puedes eliminar la imagen seleccionada en la lista. Da click en Exportar cuando termines de eliminar", "Atencion")
    End Sub

    Private Sub CargarImagenesEnGrid()
        dgvImagenes.Columns.Clear()
        dgvImagenes.Rows.Clear()
        dgvImagenes.Columns.Add("Nombre", "Nombre")
        dgvImagenes.Columns.Add("Ruta", "Ruta")
        dgvImagenes.Columns("Ruta").Visible = False

        For Each archivo In Directory.GetFiles(rutaTemporal, "*.jpg")
            dgvImagenes.Rows.Add(Path.GetFileName(archivo), archivo)
        Next
    End Sub

    Private Sub dgvImagenes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvImagenes.SelectionChanged
        If dgvImagenes.CurrentRow IsNot Nothing Then
            Dim ruta As String = dgvImagenes.CurrentRow.Cells("Ruta").Value.ToString()
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If
            Using fs As New FileStream(ruta, FileMode.Open, FileAccess.Read)
                PictureBox1.Image = Image.FromStream(fs)
            End Using
        End If
    End Sub

    Private Sub btnExportarSeleccionados_Click(sender As Object, e As EventArgs) Handles btnExportarSeleccionados.Click
        Using fbd As New FolderBrowserDialog()
            If fbd.ShowDialog() = DialogResult.OK Then
                Dim destinoFinal = fbd.SelectedPath
                For Each fila As DataGridViewRow In dgvImagenes.Rows
                    If fila.IsNewRow Then Continue For
                    Dim nombreBase = Path.GetFileNameWithoutExtension(fila.Cells("Ruta").Value.ToString())

                    ' Buscar archivos relacionados en Carpeta B
                    For Each archivoRelacionado In Directory.GetFiles(rutaCarpetaB)
                        If Path.GetFileNameWithoutExtension(archivoRelacionado) = nombreBase Then
                            Dim destinoRelacionado = Path.Combine(destinoFinal, Path.GetFileName(archivoRelacionado))
                            File.Copy(archivoRelacionado, destinoRelacionado, True)
                        End If
                    Next
                Next
                MessageBox.Show("Archivos exportados exitosamente desde Carpeta B.", "Exito")
            End If
        End Using
    End Sub

    Private Sub btnEliminarSeleccionados_Click(sender As Object, e As EventArgs) Handles btnEliminarSeleccionados.Click
        If dgvImagenes.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecciona al menos una imagen para eliminar.", "Error")
            Return
        End If

        If MessageBox.Show("¿Estás seguro que deseas eliminar las imágenes seleccionadas?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each fila As DataGridViewRow In dgvImagenes.SelectedRows
                Dim rutaImagen = fila.Cells("Ruta").Value.ToString()
                If File.Exists(rutaImagen) Then
                    File.Delete(rutaImagen)
                End If
                dgvImagenes.Rows.Remove(fila)
            Next
            If PictureBox1.Image IsNot Nothing Then
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Nothing
            End If
            MessageBox.Show("Imágen eliminada.", "Exito")
        End If
    End Sub

    Private Sub GestorImagenesForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Home.Enabled = True
    End Sub
End Class