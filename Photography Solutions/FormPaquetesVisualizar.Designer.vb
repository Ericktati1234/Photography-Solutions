<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaquetesVisualizar
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
        btnNuevo = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCancelar = New Button()
        IDPack = New Label()
        txtNombrePaquete = New TextBox()
        Label1 = New Label()
        txtDescripcion = New TextBox()
        Cliente = New Label()
        txtPrecio = New TextBox()
        Unidades = New Label()
        dgvPaquetes = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblIdPaquete = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        DatosPersonales = New Label()
        CType(dgvPaquetes, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnNuevo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnNuevo.Location = New Point(3, 2)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(109, 75)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Location = New Point(3, 160)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 75)
        btnGuardar.TabIndex = 1
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEditar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(3, 81)
        btnEditar.Margin = New Padding(3, 2, 3, 2)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(109, 75)
        btnEditar.TabIndex = 2
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnEliminar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(3, 239)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(109, 75)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCancelar.Enabled = False
        btnCancelar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(3, 318)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(109, 78)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' IDPack
        ' 
        IDPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        IDPack.AutoSize = True
        IDPack.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        IDPack.Location = New Point(3, 0)
        IDPack.Name = "IDPack"
        IDPack.Size = New Size(73, 25)
        IDPack.TabIndex = 6
        IDPack.Text = "ID"
        IDPack.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNombrePaquete
        ' 
        txtNombrePaquete.Dock = DockStyle.Fill
        txtNombrePaquete.Enabled = False
        txtNombrePaquete.Location = New Point(82, 27)
        txtNombrePaquete.Margin = New Padding(3, 2, 3, 2)
        txtNombrePaquete.Name = "txtNombrePaquete"
        txtNombrePaquete.Size = New Size(193, 23)
        txtNombrePaquete.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Location = New Point(82, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 25)
        Label1.TabIndex = 8
        Label1.Text = "Nombre"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Dock = DockStyle.Fill
        txtDescripcion.Enabled = False
        txtDescripcion.Location = New Point(281, 27)
        txtDescripcion.Margin = New Padding(3, 2, 3, 2)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(353, 23)
        txtDescripcion.TabIndex = 9
        ' 
        ' Cliente
        ' 
        Cliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cliente.AutoSize = True
        Cliente.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Cliente.Location = New Point(281, 0)
        Cliente.Name = "Cliente"
        Cliente.Size = New Size(353, 25)
        Cliente.TabIndex = 10
        Cliente.Text = "Descripcion"
        Cliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Dock = DockStyle.Fill
        txtPrecio.Enabled = False
        txtPrecio.Location = New Point(640, 27)
        txtPrecio.Margin = New Padding(3, 2, 3, 2)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(155, 23)
        txtPrecio.TabIndex = 11
        ' 
        ' Unidades
        ' 
        Unidades.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Unidades.AutoSize = True
        Unidades.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Unidades.Location = New Point(640, 0)
        Unidades.Name = "Unidades"
        Unidades.Size = New Size(155, 25)
        Unidades.TabIndex = 12
        Unidades.Text = "Precio"
        Unidades.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvPaquetes
        ' 
        dgvPaquetes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPaquetes.BackgroundColor = Color.White
        dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPaquetes.Location = New Point(168, 81)
        dgvPaquetes.Margin = New Padding(3, 2, 3, 2)
        dgvPaquetes.Name = "dgvPaquetes"
        dgvPaquetes.RowHeadersWidth = 51
        dgvPaquetes.RowTemplate.Height = 29
        dgvPaquetes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPaquetes.Size = New Size(798, 328)
        dgvPaquetes.TabIndex = 13
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(txtNombrePaquete, 1, 1)
        TableLayoutPanel1.Controls.Add(Unidades, 3, 0)
        TableLayoutPanel1.Controls.Add(txtDescripcion, 2, 1)
        TableLayoutPanel1.Controls.Add(txtPrecio, 3, 1)
        TableLayoutPanel1.Controls.Add(IDPack, 0, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Cliente, 2, 0)
        TableLayoutPanel1.Controls.Add(lblIdPaquete, 0, 1)
        TableLayoutPanel1.Location = New Point(168, 414)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(798, 50)
        TableLayoutPanel1.TabIndex = 14
        ' 
        ' lblIdPaquete
        ' 
        lblIdPaquete.AutoSize = True
        lblIdPaquete.BackColor = Color.White
        lblIdPaquete.Dock = DockStyle.Fill
        lblIdPaquete.Location = New Point(3, 25)
        lblIdPaquete.Name = "lblIdPaquete"
        lblIdPaquete.Size = New Size(73, 25)
        lblIdPaquete.TabIndex = 13
        lblIdPaquete.Text = "default"
        lblIdPaquete.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnNuevo, 0, 0)
        TableLayoutPanel2.Controls.Add(btnGuardar, 0, 2)
        TableLayoutPanel2.Controls.Add(btnCancelar, 0, 4)
        TableLayoutPanel2.Controls.Add(btnEliminar, 0, 3)
        TableLayoutPanel2.Controls.Add(btnEditar, 0, 1)
        TableLayoutPanel2.Location = New Point(28, 81)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(115, 398)
        TableLayoutPanel2.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(28, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 32)
        Label3.TabIndex = 32
        Label3.Text = "GESTOR DE PAQUETES"
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(354, 46)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(287, 25)
        DatosPersonales.TabIndex = 33
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' FormPaquetesVisualizar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(1000, 528)
        Controls.Add(DatosPersonales)
        Controls.Add(Label3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(dgvPaquetes)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(838, 463)
        Name = "FormPaquetesVisualizar"
        Text = "Gestor de Paquetes"
        CType(dgvPaquetes, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents IDPack As Label
    Friend WithEvents txtNombrePaquete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Cliente As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Unidades As Label
    Friend WithEvents dgvPaquetes As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents lblIdPaquete As Label
End Class
