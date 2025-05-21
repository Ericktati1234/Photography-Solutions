<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientesVisualizar
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
        TableLayoutPanel2 = New TableLayoutPanel()
        btnGuardar = New Button()
        btnNuevo = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCancelar = New Button()
        dgvClientes = New DataGridView()
        Label3 = New Label()
        DatosPersonales = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtCliente = New TextBox()
        txtFecha = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        lblIdCliente = New Label()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnGuardar, 0, 2)
        TableLayoutPanel2.Controls.Add(btnNuevo, 0, 0)
        TableLayoutPanel2.Controls.Add(btnEditar, 0, 1)
        TableLayoutPanel2.Controls.Add(btnEliminar, 0, 3)
        TableLayoutPanel2.Controls.Add(btnCancelar, 0, 4)
        TableLayoutPanel2.Location = New Point(38, 74)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(115, 357)
        TableLayoutPanel2.TabIndex = 18
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.White
        btnGuardar.Dock = DockStyle.Fill
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnGuardar.Location = New Point(3, 144)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(109, 67)
        btnGuardar.TabIndex = 34
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.White
        btnNuevo.Dock = DockStyle.Fill
        btnNuevo.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnNuevo.Location = New Point(3, 2)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(109, 67)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.White
        btnEditar.Dock = DockStyle.Fill
        btnEditar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEditar.Location = New Point(3, 73)
        btnEditar.Margin = New Padding(3, 2, 3, 2)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(109, 67)
        btnEditar.TabIndex = 2
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.White
        btnEliminar.Dock = DockStyle.Fill
        btnEliminar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(3, 215)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(109, 67)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.White
        btnCancelar.Dock = DockStyle.Fill
        btnCancelar.Enabled = False
        btnCancelar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Location = New Point(3, 286)
        btnCancelar.Margin = New Padding(3, 2, 3, 2)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(109, 69)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' dgvClientes
        ' 
        dgvClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClientes.BackgroundColor = Color.White
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(181, 74)
        dgvClientes.Margin = New Padding(3, 2, 3, 2)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.RowHeadersWidth = 51
        dgvClientes.RowTemplate.Height = 29
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.Size = New Size(783, 305)
        dgvClientes.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(38, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(256, 32)
        Label3.TabIndex = 31
        Label3.Text = "GESTOR DE CLIENTES"
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(436, 37)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(287, 25)
        DatosPersonales.TabIndex = 32
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 5
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 1, 0)
        TableLayoutPanel3.Controls.Add(Label4, 2, 0)
        TableLayoutPanel3.Controls.Add(Label5, 3, 0)
        TableLayoutPanel3.Controls.Add(Label6, 4, 0)
        TableLayoutPanel3.Controls.Add(txtCliente, 1, 1)
        TableLayoutPanel3.Controls.Add(txtFecha, 2, 1)
        TableLayoutPanel3.Controls.Add(txtTelefono, 3, 1)
        TableLayoutPanel3.Controls.Add(txtCorreo, 4, 1)
        TableLayoutPanel3.Controls.Add(lblIdCliente, 0, 1)
        TableLayoutPanel3.Location = New Point(181, 387)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(783, 44)
        TableLayoutPanel3.TabIndex = 33
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 22)
        Label1.TabIndex = 0
        Label1.Text = "Id"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(81, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 22)
        Label2.TabIndex = 1
        Label2.Text = "Nombre"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(276, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 22)
        Label4.TabIndex = 2
        Label4.Text = "Fecha Nacimiento"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(432, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 22)
        Label5.TabIndex = 3
        Label5.Text = "Telefono"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(588, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 22)
        Label6.TabIndex = 4
        Label6.Text = "Correo"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtCliente
        ' 
        txtCliente.BackColor = Color.White
        txtCliente.Dock = DockStyle.Fill
        txtCliente.Enabled = False
        txtCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCliente.Location = New Point(81, 25)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(189, 25)
        txtCliente.TabIndex = 6
        ' 
        ' txtFecha
        ' 
        txtFecha.BackColor = Color.White
        txtFecha.Dock = DockStyle.Fill
        txtFecha.Enabled = False
        txtFecha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtFecha.Location = New Point(276, 25)
        txtFecha.Name = "txtFecha"
        txtFecha.Size = New Size(150, 25)
        txtFecha.TabIndex = 7
        ' 
        ' txtTelefono
        ' 
        txtTelefono.BackColor = Color.White
        txtTelefono.Dock = DockStyle.Fill
        txtTelefono.Enabled = False
        txtTelefono.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtTelefono.Location = New Point(432, 25)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(150, 25)
        txtTelefono.TabIndex = 8
        ' 
        ' txtCorreo
        ' 
        txtCorreo.BackColor = Color.White
        txtCorreo.Dock = DockStyle.Fill
        txtCorreo.Enabled = False
        txtCorreo.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtCorreo.Location = New Point(588, 25)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(192, 25)
        txtCorreo.TabIndex = 9
        ' 
        ' lblIdCliente
        ' 
        lblIdCliente.AutoSize = True
        lblIdCliente.BackColor = Color.White
        lblIdCliente.Dock = DockStyle.Fill
        lblIdCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblIdCliente.Location = New Point(3, 22)
        lblIdCliente.Name = "lblIdCliente"
        lblIdCliente.Size = New Size(72, 22)
        lblIdCliente.TabIndex = 10
        lblIdCliente.Text = "default"
        lblIdCliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormClientesVisualizar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(1001, 484)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(DatosPersonales)
        Controls.Add(Label3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvClientes)
        MinimumSize = New Size(1017, 523)
        Name = "FormClientesVisualizar"
        Text = "AltaClientes"
        TableLayoutPanel2.ResumeLayout(False)
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblIdCliente As Label
End Class
