<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestorImagenesForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvImagenes = New DataGridView()
        btnSeleccionarCarpetaA = New Button()
        btnSeleccionarCarpetaB = New Button()
        btnCrearCopiaEditable = New Button()
        btnExportarSeleccionados = New Button()
        PictureBox1 = New PictureBox()
        btnEliminarSeleccionados = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label9 = New Label()
        Label1 = New Label()
        CType(dgvImagenes, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvImagenes
        ' 
        dgvImagenes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvImagenes.BackgroundColor = Color.White
        dgvImagenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvImagenes.Location = New Point(198, 98)
        dgvImagenes.MultiSelect = False
        dgvImagenes.Name = "dgvImagenes"
        dgvImagenes.RowTemplate.Height = 25
        dgvImagenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvImagenes.Size = New Size(181, 491)
        dgvImagenes.TabIndex = 0
        ' 
        ' btnSeleccionarCarpetaA
        ' 
        btnSeleccionarCarpetaA.Dock = DockStyle.Top
        btnSeleccionarCarpetaA.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSeleccionarCarpetaA.Location = New Point(3, 3)
        btnSeleccionarCarpetaA.Name = "btnSeleccionarCarpetaA"
        btnSeleccionarCarpetaA.Size = New Size(131, 37)
        btnSeleccionarCarpetaA.TabIndex = 1
        btnSeleccionarCarpetaA.Text = "Carpeta JPG"
        btnSeleccionarCarpetaA.UseVisualStyleBackColor = True
        ' 
        ' btnSeleccionarCarpetaB
        ' 
        btnSeleccionarCarpetaB.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        btnSeleccionarCarpetaB.Dock = DockStyle.Top
        btnSeleccionarCarpetaB.Enabled = False
        btnSeleccionarCarpetaB.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSeleccionarCarpetaB.Location = New Point(3, 81)
        btnSeleccionarCarpetaB.Name = "btnSeleccionarCarpetaB"
        btnSeleccionarCarpetaB.Size = New Size(131, 37)
        btnSeleccionarCarpetaB.TabIndex = 2
        btnSeleccionarCarpetaB.Text = "Carpeta RAW"
        btnSeleccionarCarpetaB.UseVisualStyleBackColor = False
        ' 
        ' btnCrearCopiaEditable
        ' 
        btnCrearCopiaEditable.Dock = DockStyle.Top
        btnCrearCopiaEditable.Enabled = False
        btnCrearCopiaEditable.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnCrearCopiaEditable.Location = New Point(3, 159)
        btnCrearCopiaEditable.Name = "btnCrearCopiaEditable"
        btnCrearCopiaEditable.Size = New Size(131, 37)
        btnCrearCopiaEditable.TabIndex = 3
        btnCrearCopiaEditable.Text = "Grid"
        btnCrearCopiaEditable.UseVisualStyleBackColor = True
        ' 
        ' btnExportarSeleccionados
        ' 
        btnExportarSeleccionados.Dock = DockStyle.Top
        btnExportarSeleccionados.Enabled = False
        btnExportarSeleccionados.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnExportarSeleccionados.Location = New Point(3, 315)
        btnExportarSeleccionados.Name = "btnExportarSeleccionados"
        btnExportarSeleccionados.Size = New Size(131, 37)
        btnExportarSeleccionados.TabIndex = 4
        btnExportarSeleccionados.Text = "Exportar"
        btnExportarSeleccionados.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.White
        PictureBox1.Location = New Point(417, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(616, 491)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnEliminarSeleccionados
        ' 
        btnEliminarSeleccionados.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        btnEliminarSeleccionados.Dock = DockStyle.Top
        btnEliminarSeleccionados.Enabled = False
        btnEliminarSeleccionados.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminarSeleccionados.Location = New Point(3, 237)
        btnEliminarSeleccionados.Name = "btnEliminarSeleccionados"
        btnEliminarSeleccionados.Size = New Size(131, 37)
        btnEliminarSeleccionados.TabIndex = 6
        btnEliminarSeleccionados.Text = "Eliminar"
        btnEliminarSeleccionados.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(btnSeleccionarCarpetaA, 0, 0)
        TableLayoutPanel1.Controls.Add(btnEliminarSeleccionados, 0, 3)
        TableLayoutPanel1.Controls.Add(btnExportarSeleccionados, 0, 4)
        TableLayoutPanel1.Controls.Add(btnSeleccionarCarpetaB, 0, 1)
        TableLayoutPanel1.Controls.Add(btnCrearCopiaEditable, 0, 2)
        TableLayoutPanel1.Location = New Point(33, 98)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(137, 391)
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(33, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(343, 45)
        Label9.TabIndex = 29
        Label9.Text = "GESTOR DE IMAGENES"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(566, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 32)
        Label1.TabIndex = 30
        Label1.Text = "VISUALIZACION DE IMAGEN"
        ' 
        ' GestorImagenesForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(1064, 632)
        Controls.Add(Label1)
        Controls.Add(Label9)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(PictureBox1)
        Controls.Add(dgvImagenes)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1080, 671)
        Name = "GestorImagenesForm"
        Text = "Gestor de sesion"
        CType(dgvImagenes, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvImagenes As DataGridView
    Friend WithEvents btnSeleccionarCarpetaA As Button
    Friend WithEvents btnSeleccionarCarpetaB As Button
    Friend WithEvents btnCrearCopiaEditable As Button
    Friend WithEvents btnExportarSeleccionados As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminarSeleccionados As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
End Class
