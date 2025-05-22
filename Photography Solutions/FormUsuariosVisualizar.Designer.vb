<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuariosVisualizar
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
        DatosPersonales = New Label()
        Label3 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtNombrePaquete = New TextBox()
        Unidades = New Label()
        Label2 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnNuevo = New Button()
        btnEditar = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnCancelar = New Button()
        TableLayoutPanel4 = New TableLayoutPanel()
        txtUsuario = New TextBox()
        Label4 = New Label()
        txtEmpleado = New TextBox()
        txtNacimiento = New TextBox()
        IDPack = New Label()
        Label5 = New Label()
        Cliente = New Label()
        lblIdUsuario = New Label()
        dgvUsuariosEmpleados = New DataGridView()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(dgvUsuariosEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(307, 45)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(287, 25)
        DatosPersonales.TabIndex = 38
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(-19, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(268, 32)
        Label3.TabIndex = 37
        Label3.Text = "GESTOR DE PAQUETES"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Location = New Point(-19, 80)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel2.Size = New Size(115, 398)
        TableLayoutPanel2.TabIndex = 36
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel1.Controls.Add(txtNombrePaquete, 1, 1)
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(200, 100)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' txtNombrePaquete
        ' 
        txtNombrePaquete.Dock = DockStyle.Fill
        txtNombrePaquete.Enabled = False
        txtNombrePaquete.Location = New Point(23, 22)
        txtNombrePaquete.Margin = New Padding(3, 2, 3, 2)
        txtNombrePaquete.Name = "txtNombrePaquete"
        txtNombrePaquete.Size = New Size(44, 23)
        txtNombrePaquete.TabIndex = 7
        ' 
        ' Unidades
        ' 
        Unidades.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Unidades.AutoSize = True
        Unidades.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Unidades.Location = New Point(163, 0)
        Unidades.Name = "Unidades"
        Unidades.Size = New Size(34, 30)
        Unidades.TabIndex = 12
        Unidades.Text = "Precio"
        Unidades.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label2.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(35, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(438, 32)
        Label2.TabIndex = 37
        Label2.Text = "GESTOR DE USUARIOS Y EMPLEADOS"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Controls.Add(btnNuevo, 0, 0)
        TableLayoutPanel3.Controls.Add(btnEditar, 0, 1)
        TableLayoutPanel3.Controls.Add(btnGuardar, 0, 2)
        TableLayoutPanel3.Controls.Add(btnEliminar, 0, 3)
        TableLayoutPanel3.Controls.Add(btnCancelar, 0, 4)
        TableLayoutPanel3.Location = New Point(35, 94)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 5
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel3.Size = New Size(115, 398)
        TableLayoutPanel3.TabIndex = 36
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Dock = DockStyle.Fill
        btnNuevo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnNuevo.Location = New Point(3, 3)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(109, 73)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Dock = DockStyle.Fill
        btnEditar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(3, 82)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(109, 73)
        btnEditar.TabIndex = 1
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Dock = DockStyle.Fill
        btnGuardar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Location = New Point(3, 161)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 73)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Dock = DockStyle.Fill
        btnEliminar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(3, 240)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(109, 73)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Dock = DockStyle.Fill
        btnCancelar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(3, 319)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(109, 76)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel4.Controls.Add(txtUsuario, 1, 1)
        TableLayoutPanel4.Controls.Add(Label4, 3, 0)
        TableLayoutPanel4.Controls.Add(txtEmpleado, 2, 1)
        TableLayoutPanel4.Controls.Add(txtNacimiento, 3, 1)
        TableLayoutPanel4.Controls.Add(IDPack, 0, 0)
        TableLayoutPanel4.Controls.Add(Label5, 1, 0)
        TableLayoutPanel4.Controls.Add(Cliente, 2, 0)
        TableLayoutPanel4.Controls.Add(lblIdUsuario, 0, 1)
        TableLayoutPanel4.Location = New Point(175, 427)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel4.Size = New Size(984, 50)
        TableLayoutPanel4.TabIndex = 35
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Dock = DockStyle.Fill
        txtUsuario.Enabled = False
        txtUsuario.Location = New Point(101, 27)
        txtUsuario.Margin = New Padding(3, 2, 3, 2)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(240, 23)
        txtUsuario.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label4.Location = New Point(789, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(192, 25)
        Label4.TabIndex = 12
        Label4.Text = "Fecha Nacimiento"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtEmpleado
        ' 
        txtEmpleado.Dock = DockStyle.Fill
        txtEmpleado.Enabled = False
        txtEmpleado.Location = New Point(347, 27)
        txtEmpleado.Margin = New Padding(3, 2, 3, 2)
        txtEmpleado.Name = "txtEmpleado"
        txtEmpleado.Size = New Size(436, 23)
        txtEmpleado.TabIndex = 9
        ' 
        ' txtNacimiento
        ' 
        txtNacimiento.Dock = DockStyle.Fill
        txtNacimiento.Enabled = False
        txtNacimiento.Location = New Point(789, 27)
        txtNacimiento.Margin = New Padding(3, 2, 3, 2)
        txtNacimiento.Name = "txtNacimiento"
        txtNacimiento.Size = New Size(192, 23)
        txtNacimiento.TabIndex = 11
        ' 
        ' IDPack
        ' 
        IDPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        IDPack.AutoSize = True
        IDPack.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        IDPack.Location = New Point(3, 0)
        IDPack.Name = "IDPack"
        IDPack.Size = New Size(92, 25)
        IDPack.TabIndex = 6
        IDPack.Text = "ID Usuario"
        IDPack.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label5.Location = New Point(101, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(240, 25)
        Label5.TabIndex = 8
        Label5.Text = "Usuario"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Cliente
        ' 
        Cliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cliente.AutoSize = True
        Cliente.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Cliente.Location = New Point(347, 0)
        Cliente.Name = "Cliente"
        Cliente.Size = New Size(436, 25)
        Cliente.TabIndex = 10
        Cliente.Text = "Nombre"
        Cliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIdUsuario
        ' 
        lblIdUsuario.AutoSize = True
        lblIdUsuario.BackColor = Color.White
        lblIdUsuario.Dock = DockStyle.Fill
        lblIdUsuario.Location = New Point(3, 25)
        lblIdUsuario.Name = "lblIdUsuario"
        lblIdUsuario.Size = New Size(92, 25)
        lblIdUsuario.TabIndex = 13
        lblIdUsuario.Text = "default"
        lblIdUsuario.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvUsuariosEmpleados
        ' 
        dgvUsuariosEmpleados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvUsuariosEmpleados.BackgroundColor = Color.White
        dgvUsuariosEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuariosEmpleados.Location = New Point(175, 94)
        dgvUsuariosEmpleados.Margin = New Padding(3, 2, 3, 2)
        dgvUsuariosEmpleados.Name = "dgvUsuariosEmpleados"
        dgvUsuariosEmpleados.RowHeadersWidth = 51
        dgvUsuariosEmpleados.RowTemplate.Height = 29
        dgvUsuariosEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuariosEmpleados.Size = New Size(984, 328)
        dgvUsuariosEmpleados.TabIndex = 34
        ' 
        ' FormUsuariosVisualizar
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1207, 543)
        Controls.Add(Label2)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel4)
        Controls.Add(dgvUsuariosEmpleados)
        MinimumSize = New Size(1037, 582)
        Name = "FormUsuariosVisualizar"
        Text = "FormUsuariosVisualizar"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(dgvUsuariosEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DatosPersonales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtNombrePaquete As TextBox
    Friend WithEvents Unidades As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents txtNacimiento As TextBox
    Friend WithEvents IDPack As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cliente As Label
    Friend WithEvents lblIdUsuario As Label
    Friend WithEvents dgvUsuariosEmpleados As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCancelar As Button
End Class
