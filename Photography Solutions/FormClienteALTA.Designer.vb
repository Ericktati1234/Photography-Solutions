<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClienteALTA
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
        TableLayoutPanel1 = New TableLayoutPanel()
        Nombre = New Label()
        txtNombre = New TextBox()
        txtCorreo = New TextBox()
        ApellidoMaterno = New Label()
        numTelefono = New NumericUpDown()
        ApellidoPaterno = New Label()
        DatosPersonales = New Label()
        CalendarioNacimiento = New MonthCalendar()
        btnReiniciar = New Button()
        btnConfirmar = New Button()
        Label1 = New Label()
        lblFecha = New Label()
        Label3 = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(numTelefono, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.Controls.Add(Nombre, 0, 0)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(txtCorreo, 1, 2)
        TableLayoutPanel1.Controls.Add(ApellidoMaterno, 0, 2)
        TableLayoutPanel1.Controls.Add(numTelefono, 1, 1)
        TableLayoutPanel1.Controls.Add(ApellidoPaterno, 0, 1)
        TableLayoutPanel1.Location = New Point(26, 111)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(397, 96)
        TableLayoutPanel1.TabIndex = 24
        ' 
        ' Nombre
        ' 
        Nombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nombre.AutoSize = True
        Nombre.BackColor = Color.Gainsboro
        Nombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Nombre.Location = New Point(3, 0)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(132, 32)
        Nombre.TabIndex = 7
        Nombre.Text = "Nombre"
        Nombre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Location = New Point(141, 2)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(253, 23)
        txtNombre.TabIndex = 10
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtCorreo.Location = New Point(141, 66)
        txtCorreo.Margin = New Padding(3, 2, 3, 2)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(253, 23)
        txtCorreo.TabIndex = 12
        ' 
        ' ApellidoMaterno
        ' 
        ApellidoMaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoMaterno.AutoSize = True
        ApellidoMaterno.BackColor = Color.Gainsboro
        ApellidoMaterno.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ApellidoMaterno.Location = New Point(3, 64)
        ApellidoMaterno.Name = "ApellidoMaterno"
        ApellidoMaterno.Size = New Size(132, 32)
        ApellidoMaterno.TabIndex = 9
        ApellidoMaterno.Text = "correo electronico"
        ApellidoMaterno.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' numTelefono
        ' 
        numTelefono.Dock = DockStyle.Fill
        numTelefono.Location = New Point(141, 35)
        numTelefono.Name = "numTelefono"
        numTelefono.Size = New Size(253, 23)
        numTelefono.TabIndex = 26
        ' 
        ' ApellidoPaterno
        ' 
        ApellidoPaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoPaterno.AutoSize = True
        ApellidoPaterno.BackColor = Color.White
        ApellidoPaterno.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ApellidoPaterno.Location = New Point(3, 32)
        ApellidoPaterno.Name = "ApellidoPaterno"
        ApellidoPaterno.Size = New Size(132, 32)
        ApellidoPaterno.TabIndex = 8
        ApellidoPaterno.Text = "Telefono"
        ApellidoPaterno.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(155, 70)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(155, 25)
        DatosPersonales.TabIndex = 23
        DatosPersonales.Text = "Datos Personales"
        ' 
        ' CalendarioNacimiento
        ' 
        CalendarioNacimiento.Location = New Point(18, 233)
        CalendarioNacimiento.Name = "CalendarioNacimiento"
        CalendarioNacimiento.TabIndex = 25
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.BackColor = Color.Gainsboro
        btnReiniciar.Location = New Point(272, 312)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(136, 37)
        btnReiniciar.TabIndex = 26
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = False
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Location = New Point(272, 359)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(136, 37)
        btnConfirmar.TabIndex = 27
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(269, 236)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 20)
        Label1.TabIndex = 28
        Label1.Text = "Fecha de Nacimiento"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.BackColor = Color.White
        lblFecha.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFecha.Location = New Point(314, 273)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(48, 17)
        lblFecha.TabIndex = 29
        lblFecha.Text = "default"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(26, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(196, 30)
        Label3.TabIndex = 30
        Label3.Text = "ALTA DE CLIENTES"
        ' 
        ' FormClienteALTA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(448, 439)
        Controls.Add(Label3)
        Controls.Add(lblFecha)
        Controls.Add(Label1)
        Controls.Add(btnConfirmar)
        Controls.Add(btnReiniciar)
        Controls.Add(CalendarioNacimiento)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(DatosPersonales)
        MaximumSize = New Size(464, 478)
        MinimumSize = New Size(464, 478)
        Name = "FormClienteALTA"
        Text = "Alta de Clientes"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(numTelefono, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Nombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents ApellidoPaterno As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents ApellidoMaterno As Label
    Friend WithEvents numTelefono As NumericUpDown
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents CalendarioNacimiento As MonthCalendar
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label3 As Label
End Class
