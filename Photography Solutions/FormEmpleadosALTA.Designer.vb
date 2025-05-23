<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmpleadosALTA
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
        Nombre = New Label()
        ApellidoPaterno = New Label()
        ApellidoMaterno = New Label()
        txtNombreEmpleado = New TextBox()
        txtApellidoPa = New TextBox()
        txtApellidoMa = New TextBox()
        btnAlta = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        txtCorreo = New TextBox()
        numTelefono = New NumericUpDown()
        btnCambiarUsuario = New Button()
        Label4 = New Label()
        lblNombreUsuario = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        lblFecha = New Label()
        Label5 = New Label()
        CalendarioNacimiento = New MonthCalendar()
        btnReiniciar = New Button()
        btnEditar = New Button()
        Label9 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(numTelefono, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(140, 142)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(155, 25)
        DatosPersonales.TabIndex = 6
        DatosPersonales.Text = "Datos Personales"
        ' 
        ' Nombre
        ' 
        Nombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nombre.AutoSize = True
        Nombre.BackColor = Color.Gainsboro
        Nombre.Location = New Point(3, 0)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(132, 28)
        Nombre.TabIndex = 7
        Nombre.Text = "Nombre"
        ' 
        ' ApellidoPaterno
        ' 
        ApellidoPaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoPaterno.AutoSize = True
        ApellidoPaterno.BackColor = Color.White
        ApellidoPaterno.Location = New Point(3, 28)
        ApellidoPaterno.Name = "ApellidoPaterno"
        ApellidoPaterno.Size = New Size(132, 28)
        ApellidoPaterno.TabIndex = 8
        ApellidoPaterno.Text = "Apellido Paterno"
        ' 
        ' ApellidoMaterno
        ' 
        ApellidoMaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoMaterno.AutoSize = True
        ApellidoMaterno.BackColor = Color.Gainsboro
        ApellidoMaterno.Location = New Point(3, 56)
        ApellidoMaterno.Name = "ApellidoMaterno"
        ApellidoMaterno.Size = New Size(132, 28)
        ApellidoMaterno.TabIndex = 9
        ApellidoMaterno.Text = "Apellido Materno"
        ' 
        ' txtNombreEmpleado
        ' 
        txtNombreEmpleado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombreEmpleado.Location = New Point(141, 2)
        txtNombreEmpleado.Margin = New Padding(3, 2, 3, 2)
        txtNombreEmpleado.Name = "txtNombreEmpleado"
        txtNombreEmpleado.Size = New Size(253, 23)
        txtNombreEmpleado.TabIndex = 10
        ' 
        ' txtApellidoPa
        ' 
        txtApellidoPa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtApellidoPa.Location = New Point(141, 30)
        txtApellidoPa.Margin = New Padding(3, 2, 3, 2)
        txtApellidoPa.Name = "txtApellidoPa"
        txtApellidoPa.Size = New Size(253, 23)
        txtApellidoPa.TabIndex = 11
        ' 
        ' txtApellidoMa
        ' 
        txtApellidoMa.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtApellidoMa.Location = New Point(141, 58)
        txtApellidoMa.Margin = New Padding(3, 2, 3, 2)
        txtApellidoMa.Name = "txtApellidoMa"
        txtApellidoMa.Size = New Size(253, 23)
        txtApellidoMa.TabIndex = 12
        ' 
        ' btnAlta
        ' 
        btnAlta.Location = New Point(305, 477)
        btnAlta.Margin = New Padding(3, 2, 3, 2)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(101, 36)
        btnAlta.TabIndex = 15
        btnAlta.Text = "CONFIRMAR"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.Controls.Add(Nombre, 0, 0)
        TableLayoutPanel1.Controls.Add(txtNombreEmpleado, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 3)
        TableLayoutPanel1.Controls.Add(ApellidoPaterno, 0, 1)
        TableLayoutPanel1.Controls.Add(txtApellidoMa, 1, 2)
        TableLayoutPanel1.Controls.Add(ApellidoMaterno, 0, 2)
        TableLayoutPanel1.Controls.Add(Label2, 0, 4)
        TableLayoutPanel1.Controls.Add(txtCorreo, 1, 4)
        TableLayoutPanel1.Controls.Add(numTelefono, 1, 3)
        TableLayoutPanel1.Controls.Add(txtApellidoPa, 1, 1)
        TableLayoutPanel1.Location = New Point(26, 182)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(397, 143)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Location = New Point(3, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 28)
        Label1.TabIndex = 23
        Label1.Text = "Telefono"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Gainsboro
        Label2.Location = New Point(3, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 31)
        Label2.TabIndex = 24
        Label2.Text = "Correo electronico"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Location = New Point(141, 115)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(253, 23)
        txtCorreo.TabIndex = 25
        ' 
        ' numTelefono
        ' 
        numTelefono.Dock = DockStyle.Fill
        numTelefono.Location = New Point(141, 87)
        numTelefono.Name = "numTelefono"
        numTelefono.Size = New Size(253, 23)
        numTelefono.TabIndex = 26
        ' 
        ' btnCambiarUsuario
        ' 
        btnCambiarUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnCambiarUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCambiarUsuario.Location = New Point(228, 2)
        btnCambiarUsuario.Margin = New Padding(3, 2, 3, 2)
        btnCambiarUsuario.Name = "btnCambiarUsuario"
        btnCambiarUsuario.Size = New Size(145, 40)
        btnCambiarUsuario.TabIndex = 23
        btnCambiarUsuario.Text = "Cambiar Usuario"
        btnCambiarUsuario.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 44)
        Label4.TabIndex = 25
        Label4.Text = "Usuario:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNombreUsuario
        ' 
        lblNombreUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblNombreUsuario.AutoSize = True
        lblNombreUsuario.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        lblNombreUsuario.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblNombreUsuario.Location = New Point(97, 0)
        lblNombreUsuario.Name = "lblNombreUsuario"
        lblNombreUsuario.Size = New Size(125, 44)
        lblNombreUsuario.TabIndex = 26
        lblNombreUsuario.Text = "default"
        lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.Controls.Add(lblNombreUsuario, 1, 0)
        TableLayoutPanel2.Controls.Add(Label4, 0, 0)
        TableLayoutPanel2.Controls.Add(btnCambiarUsuario, 2, 0)
        TableLayoutPanel2.Location = New Point(42, 77)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(376, 44)
        TableLayoutPanel2.TabIndex = 27
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.BackColor = Color.White
        lblFecha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFecha.Location = New Point(329, 390)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(48, 17)
        lblFecha.TabIndex = 32
        lblFecha.Text = "default"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(283, 351)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 31
        Label5.Text = "Fecha de Nacimiento"
        ' 
        ' CalendarioNacimiento
        ' 
        CalendarioNacimiento.Location = New Point(23, 351)
        CalendarioNacimiento.Name = "CalendarioNacimiento"
        CalendarioNacimiento.TabIndex = 30
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.BackColor = Color.Gainsboro
        btnReiniciar.Location = New Point(305, 428)
        btnReiniciar.Margin = New Padding(3, 2, 3, 2)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(101, 36)
        btnReiniciar.TabIndex = 33
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(305, 477)
        btnEditar.Margin = New Padding(3, 2, 3, 2)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(101, 36)
        btnEditar.TabIndex = 34
        btnEditar.Text = "EDITAR"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(80, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(295, 45)
        Label9.TabIndex = 35
        Label9.Text = "NUEVO EMPLEADO"
        ' 
        ' formEmpleadosALTA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(457, 559)
        Controls.Add(Label9)
        Controls.Add(btnEditar)
        Controls.Add(btnReiniciar)
        Controls.Add(lblFecha)
        Controls.Add(Label5)
        Controls.Add(CalendarioNacimiento)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(btnAlta)
        Controls.Add(DatosPersonales)
        Margin = New Padding(3, 2, 3, 2)
        Name = "formEmpleadosALTA"
        Text = "EMPLEADOS"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(numTelefono, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents ApellidoPaterno As Label
    Friend WithEvents ApellidoMaterno As Label
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents txtApellidoPa As TextBox
    Friend WithEvents txtApellidoMa As TextBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents AdministradorChBx As CheckBox
    Friend WithEvents FotógrafoChBx As CheckBox
    Friend WithEvents ContadorChBx As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCambiarUsuario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents numTelefono As NumericUpDown
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CalendarioNacimiento As MonthCalendar
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label9 As Label
End Class
