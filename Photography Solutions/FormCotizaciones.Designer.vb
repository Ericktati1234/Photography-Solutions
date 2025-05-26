<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCotizaciones
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
        NombreSearch = New Button()
        btnConfirmarOrden = New Button()
        lblFaltanteAnticipo = New Label()
        lblUsuario = New Label()
        lblCliente = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label6 = New Label()
        Label5 = New Label()
        lblTotalAnticipo = New Label()
        Label8 = New Label()
        numAnticipo = New NumericUpDown()
        Label9 = New Label()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblDescripcion = New Label()
        lblPrecio = New Label()
        lblTituloDescripcion = New Label()
        lblTituloPrecio = New Label()
        lblNombre = New Label()
        lblNumPaquete = New Label()
        lblTituloNombrePaquete = New Label()
        lblTituloPaquete = New Label()
        txtConsideraciones = New RichTextBox()
        Label10 = New Label()
        LayoutConsideraciones = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        btnImprimirNota = New Button()
        Label19 = New Label()
        TableLayoutPanel7 = New TableLayoutPanel()
        CalendarioFechasLibres = New MonthCalendar()
        lblTituloFecha = New Label()
        TableLayoutPanel8 = New TableLayoutPanel()
        lblFecha = New Label()
        layoutFecha = New TableLayoutPanel()
        TableLayoutPanel10 = New TableLayoutPanel()
        Label22 = New Label()
        TableLayoutPanel11 = New TableLayoutPanel()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        TextBox2 = New TextBox()
        Label27 = New Label()
        TableLayoutPanel12 = New TableLayoutPanel()
        Label28 = New Label()
        TableLayoutPanel13 = New TableLayoutPanel()
        Label29 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        TextBox3 = New TextBox()
        Label33 = New Label()
        layoutExtras = New TableLayoutPanel()
        Label34 = New Label()
        TableLayoutPanel15 = New TableLayoutPanel()
        Label35 = New Label()
        Label36 = New Label()
        Label38 = New Label()
        lblFaltanteExtra = New Label()
        numAnticipoExtra = New NumericUpDown()
        numExtras = New NumericUpDown()
        layoutTitulo = New TableLayoutPanel()
        btnreinicio = New Button()
        layoutCliente = New TableLayoutPanel()
        btnCambiarCliente = New Button()
        layoutDetalles = New TableLayoutPanel()
        LayoutPagos = New TableLayoutPanel()
        TableLayoutPanel20 = New TableLayoutPanel()
        LayoutGeneral = New TableLayoutPanel()
        Label1 = New Label()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        CType(numAnticipo, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel5.SuspendLayout()
        LayoutConsideraciones.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        layoutFecha.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        TableLayoutPanel13.SuspendLayout()
        layoutExtras.SuspendLayout()
        TableLayoutPanel15.SuspendLayout()
        CType(numAnticipoExtra, ComponentModel.ISupportInitialize).BeginInit()
        CType(numExtras, ComponentModel.ISupportInitialize).BeginInit()
        layoutTitulo.SuspendLayout()
        layoutCliente.SuspendLayout()
        layoutDetalles.SuspendLayout()
        LayoutPagos.SuspendLayout()
        TableLayoutPanel20.SuspendLayout()
        LayoutGeneral.SuspendLayout()
        SuspendLayout()
        ' 
        ' NombreSearch
        ' 
        NombreSearch.Dock = DockStyle.Fill
        NombreSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NombreSearch.Location = New Point(985, 2)
        NombreSearch.Margin = New Padding(3, 2, 3, 2)
        NombreSearch.Name = "NombreSearch"
        NombreSearch.Size = New Size(241, 30)
        NombreSearch.TabIndex = 5
        NombreSearch.Text = "Seleccionar Paquete"
        NombreSearch.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmarOrden
        ' 
        btnConfirmarOrden.BackColor = Color.FromArgb(166, 185, 205)
        btnConfirmarOrden.Dock = DockStyle.Fill
        btnConfirmarOrden.Enabled = False
        btnConfirmarOrden.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirmarOrden.Location = New Point(3, 2)
        btnConfirmarOrden.Margin = New Padding(3, 2, 3, 2)
        btnConfirmarOrden.Name = "btnConfirmarOrden"
        btnConfirmarOrden.Size = New Size(300, 56)
        btnConfirmarOrden.TabIndex = 6
        btnConfirmarOrden.Text = "CONFIRMAR ORDEN"
        btnConfirmarOrden.UseVisualStyleBackColor = False
        ' 
        ' lblFaltanteAnticipo
        ' 
        lblFaltanteAnticipo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblFaltanteAnticipo.AutoSize = True
        lblFaltanteAnticipo.BackColor = Color.White
        lblFaltanteAnticipo.Location = New Point(85, 44)
        lblFaltanteAnticipo.Name = "lblFaltanteAnticipo"
        lblFaltanteAnticipo.Size = New Size(188, 32)
        lblFaltanteAnticipo.TabIndex = 12
        lblFaltanteAnticipo.Text = "0"
        lblFaltanteAnticipo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.FromArgb(238, 243, 248)
        lblUsuario.Dock = DockStyle.Right
        lblUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsuario.Location = New Point(1159, 0)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(67, 48)
        lblUsuario.TabIndex = 17
        lblUsuario.Text = "Default"
        lblUsuario.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.BackColor = Color.FromArgb(238, 243, 248)
        lblCliente.Dock = DockStyle.Left
        lblCliente.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCliente.Location = New Point(3, 0)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(73, 34)
        lblCliente.TabIndex = 18
        lblCliente.Text = "Default"
        lblCliente.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 45)
        Label3.TabIndex = 0
        Label3.Text = "Le atiende:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(43, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 18
        Label4.Text = "Label4"
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel3.Controls.Add(Label6, 0, 2)
        TableLayoutPanel3.Controls.Add(Label5, 0, 0)
        TableLayoutPanel3.Controls.Add(lblTotalAnticipo, 1, 0)
        TableLayoutPanel3.Controls.Add(Label8, 0, 1)
        TableLayoutPanel3.Controls.Add(lblFaltanteAnticipo, 1, 2)
        TableLayoutPanel3.Controls.Add(numAnticipo, 1, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 17)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel3.Size = New Size(276, 76)
        TableLayoutPanel3.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(238, 243, 248)
        Label6.Location = New Point(3, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 32)
        Label6.TabIndex = 19
        Label6.Text = "FALTANTE"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(238, 243, 248)
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 22)
        Label5.TabIndex = 0
        Label5.Text = "TOTAL"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalAnticipo
        ' 
        lblTotalAnticipo.AutoSize = True
        lblTotalAnticipo.BackColor = Color.White
        lblTotalAnticipo.Dock = DockStyle.Fill
        lblTotalAnticipo.Location = New Point(85, 0)
        lblTotalAnticipo.Name = "lblTotalAnticipo"
        lblTotalAnticipo.Size = New Size(188, 22)
        lblTotalAnticipo.TabIndex = 17
        lblTotalAnticipo.Text = "0"
        lblTotalAnticipo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(166, 185, 205)
        Label8.Dock = DockStyle.Fill
        Label8.Location = New Point(3, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 22)
        Label8.TabIndex = 1
        Label8.Text = "ANTICIPO"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' numAnticipo
        ' 
        numAnticipo.BackColor = SystemColors.Menu
        numAnticipo.Dock = DockStyle.Fill
        numAnticipo.Location = New Point(85, 24)
        numAnticipo.Margin = New Padding(3, 2, 3, 2)
        numAnticipo.Name = "numAnticipo"
        numAnticipo.Size = New Size(188, 23)
        numAnticipo.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(130, 151, 176)
        Label9.Dock = DockStyle.Left
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(375, 48)
        Label9.TabIndex = 28
        Label9.Text = "COTIZACION DE EVENTO"
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel5.Controls.Add(lblDescripcion, 1, 3)
        TableLayoutPanel5.Controls.Add(lblPrecio, 1, 2)
        TableLayoutPanel5.Controls.Add(lblTituloDescripcion, 0, 3)
        TableLayoutPanel5.Controls.Add(lblTituloPrecio, 0, 2)
        TableLayoutPanel5.Controls.Add(lblNombre, 1, 1)
        TableLayoutPanel5.Controls.Add(lblNumPaquete, 1, 0)
        TableLayoutPanel5.Controls.Add(lblTituloNombrePaquete, 0, 1)
        TableLayoutPanel5.Controls.Add(lblTituloPaquete, 0, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 46)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 4
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(587, 168)
        TableLayoutPanel5.TabIndex = 29
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.BackColor = Color.FromArgb(238, 243, 248)
        lblDescripcion.Dock = DockStyle.Fill
        lblDescripcion.Location = New Point(91, 99)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(493, 69)
        lblDescripcion.TabIndex = 32
        lblDescripcion.Text = "Default"
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.BackColor = Color.White
        lblPrecio.Dock = DockStyle.Fill
        lblPrecio.Location = New Point(91, 66)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(493, 33)
        lblPrecio.TabIndex = 31
        lblPrecio.Text = "Default"
        lblPrecio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloDescripcion
        ' 
        lblTituloDescripcion.AutoSize = True
        lblTituloDescripcion.BackColor = Color.FromArgb(238, 243, 248)
        lblTituloDescripcion.Dock = DockStyle.Fill
        lblTituloDescripcion.Location = New Point(3, 99)
        lblTituloDescripcion.Name = "lblTituloDescripcion"
        lblTituloDescripcion.Size = New Size(82, 69)
        lblTituloDescripcion.TabIndex = 31
        lblTituloDescripcion.Text = "DESCRIPCION"
        lblTituloDescripcion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloPrecio
        ' 
        lblTituloPrecio.AutoSize = True
        lblTituloPrecio.BackColor = Color.White
        lblTituloPrecio.Dock = DockStyle.Fill
        lblTituloPrecio.Location = New Point(3, 66)
        lblTituloPrecio.Name = "lblTituloPrecio"
        lblTituloPrecio.Size = New Size(82, 33)
        lblTituloPrecio.TabIndex = 31
        lblTituloPrecio.Text = "PRECIO MXN"
        lblTituloPrecio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.BackColor = Color.FromArgb(238, 243, 248)
        lblNombre.Dock = DockStyle.Fill
        lblNombre.Location = New Point(91, 33)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(493, 33)
        lblNombre.TabIndex = 31
        lblNombre.Text = "Default"
        lblNombre.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumPaquete
        ' 
        lblNumPaquete.AutoSize = True
        lblNumPaquete.BackColor = Color.White
        lblNumPaquete.Dock = DockStyle.Fill
        lblNumPaquete.Location = New Point(91, 0)
        lblNumPaquete.Name = "lblNumPaquete"
        lblNumPaquete.Size = New Size(493, 33)
        lblNumPaquete.TabIndex = 31
        lblNumPaquete.Text = "Default"
        lblNumPaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloNombrePaquete
        ' 
        lblTituloNombrePaquete.AutoSize = True
        lblTituloNombrePaquete.BackColor = Color.FromArgb(238, 243, 248)
        lblTituloNombrePaquete.Dock = DockStyle.Fill
        lblTituloNombrePaquete.Location = New Point(3, 33)
        lblTituloNombrePaquete.Name = "lblTituloNombrePaquete"
        lblTituloNombrePaquete.Size = New Size(82, 33)
        lblTituloNombrePaquete.TabIndex = 31
        lblTituloNombrePaquete.Text = "NOMBRE "
        lblTituloNombrePaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloPaquete
        ' 
        lblTituloPaquete.AutoSize = True
        lblTituloPaquete.BackColor = Color.White
        lblTituloPaquete.Dock = DockStyle.Fill
        lblTituloPaquete.Location = New Point(3, 0)
        lblTituloPaquete.Name = "lblTituloPaquete"
        lblTituloPaquete.Size = New Size(82, 33)
        lblTituloPaquete.TabIndex = 31
        lblTituloPaquete.Text = "PAQUETE #"
        lblTituloPaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtConsideraciones
        ' 
        txtConsideraciones.BackColor = SystemColors.InactiveBorder
        txtConsideraciones.Dock = DockStyle.Fill
        txtConsideraciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtConsideraciones.Location = New Point(3, 39)
        txtConsideraciones.Name = "txtConsideraciones"
        txtConsideraciones.Size = New Size(607, 322)
        txtConsideraciones.TabIndex = 30
        txtConsideraciones.Text = ""
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(130, 151, 176)
        Label10.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(607, 36)
        Label10.TabIndex = 31
        Label10.Text = "CONSIDERACIONES ESPECIALES"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LayoutConsideraciones
        ' 
        LayoutConsideraciones.ColumnCount = 1
        LayoutConsideraciones.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        LayoutConsideraciones.Controls.Add(Label10, 0, 0)
        LayoutConsideraciones.Controls.Add(txtConsideraciones, 0, 1)
        LayoutConsideraciones.Dock = DockStyle.Fill
        LayoutConsideraciones.Location = New Point(3, 3)
        LayoutConsideraciones.Name = "LayoutConsideraciones"
        LayoutConsideraciones.RowCount = 2
        LayoutConsideraciones.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        LayoutConsideraciones.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        LayoutConsideraciones.Size = New Size(613, 364)
        LayoutConsideraciones.TabIndex = 32
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(btnImprimirNota, 1, 0)
        TableLayoutPanel4.Controls.Add(btnConfirmarOrden, 0, 0)
        TableLayoutPanel4.Location = New Point(3, 373)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(613, 60)
        TableLayoutPanel4.TabIndex = 33
        ' 
        ' btnImprimirNota
        ' 
        btnImprimirNota.BackColor = Color.FromArgb(166, 185, 205)
        btnImprimirNota.Dock = DockStyle.Fill
        btnImprimirNota.Enabled = False
        btnImprimirNota.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnImprimirNota.Location = New Point(309, 2)
        btnImprimirNota.Margin = New Padding(3, 2, 3, 2)
        btnImprimirNota.Name = "btnImprimirNota"
        btnImprimirNota.Size = New Size(301, 56)
        btnImprimirNota.TabIndex = 8
        btnImprimirNota.Text = "IMPRIMIR NOTA"
        btnImprimirNota.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.FromArgb(130, 151, 176)
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.White
        Label19.Location = New Point(3, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(276, 14)
        Label19.TabIndex = 34
        Label19.Text = "ANTICIPO"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Controls.Add(Label19, 0, 0)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel7.Size = New Size(282, 96)
        TableLayoutPanel7.TabIndex = 35
        ' 
        ' CalendarioFechasLibres
        ' 
        CalendarioFechasLibres.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CalendarioFechasLibres.Location = New Point(9, 9)
        CalendarioFechasLibres.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        CalendarioFechasLibres.MinDate = New Date(2025, 5, 20, 0, 0, 0, 0)
        CalendarioFechasLibres.Name = "CalendarioFechasLibres"
        CalendarioFechasLibres.TabIndex = 36
        ' 
        ' lblTituloFecha
        ' 
        lblTituloFecha.AutoSize = True
        lblTituloFecha.Dock = DockStyle.Fill
        lblTituloFecha.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTituloFecha.Location = New Point(3, 0)
        lblTituloFecha.Name = "lblTituloFecha"
        lblTituloFecha.Size = New Size(50, 36)
        lblTituloFecha.TabIndex = 37
        lblTituloFecha.Text = "Fecha"
        lblTituloFecha.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel8.Controls.Add(lblFecha, 1, 0)
        TableLayoutPanel8.Controls.Add(lblTituloFecha, 0, 0)
        TableLayoutPanel8.Location = New Point(3, 168)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.Size = New Size(281, 36)
        TableLayoutPanel8.TabIndex = 38
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Dock = DockStyle.Fill
        lblFecha.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblFecha.Location = New Point(59, 0)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(219, 36)
        lblFecha.TabIndex = 39
        lblFecha.Text = "Fecha"
        lblFecha.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' layoutFecha
        ' 
        layoutFecha.BackColor = Color.FromArgb(238, 243, 248)
        layoutFecha.ColumnCount = 1
        layoutFecha.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutFecha.Controls.Add(TableLayoutPanel8, 0, 1)
        layoutFecha.Controls.Add(CalendarioFechasLibres, 0, 0)
        layoutFecha.Dock = DockStyle.Fill
        layoutFecha.Enabled = False
        layoutFecha.Location = New Point(3, 3)
        layoutFecha.Name = "layoutFecha"
        layoutFecha.RowCount = 2
        layoutFecha.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        layoutFecha.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        layoutFecha.Size = New Size(287, 207)
        layoutFecha.TabIndex = 39
        ' 
        ' TableLayoutPanel10
        ' 
        TableLayoutPanel10.ColumnCount = 1
        TableLayoutPanel10.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel10.Controls.Add(Label22, 0, 0)
        TableLayoutPanel10.Location = New Point(0, 0)
        TableLayoutPanel10.Name = "TableLayoutPanel10"
        TableLayoutPanel10.RowCount = 2
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel10.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel10.Size = New Size(200, 100)
        TableLayoutPanel10.TabIndex = 0
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Dock = DockStyle.Fill
        Label22.Location = New Point(3, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(194, 20)
        Label22.TabIndex = 34
        Label22.Text = "ANTICIPO"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel11
        ' 
        TableLayoutPanel11.ColumnCount = 2
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel11.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel11.Controls.Add(Label23, 0, 2)
        TableLayoutPanel11.Controls.Add(Label24, 0, 0)
        TableLayoutPanel11.Controls.Add(Label25, 1, 0)
        TableLayoutPanel11.Controls.Add(Label26, 0, 1)
        TableLayoutPanel11.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel11.Controls.Add(Label27, 1, 2)
        TableLayoutPanel11.Dock = DockStyle.Fill
        TableLayoutPanel11.Location = New Point(3, 18)
        TableLayoutPanel11.Name = "TableLayoutPanel11"
        TableLayoutPanel11.RowCount = 3
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel11.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel11.Size = New Size(194, 103)
        TableLayoutPanel11.TabIndex = 20
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Dock = DockStyle.Fill
        Label23.Location = New Point(3, 60)
        Label23.Name = "Label23"
        Label23.Size = New Size(52, 43)
        Label23.TabIndex = 19
        Label23.Text = "FALTANTE"
        Label23.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Dock = DockStyle.Fill
        Label24.Location = New Point(3, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(52, 30)
        Label24.TabIndex = 0
        Label24.Text = "TOTAL"
        Label24.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Dock = DockStyle.Fill
        Label25.Location = New Point(61, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(130, 30)
        Label25.TabIndex = 17
        Label25.Text = "0"
        Label25.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Dock = DockStyle.Fill
        Label26.Location = New Point(3, 30)
        Label26.Name = "Label26"
        Label26.Size = New Size(52, 30)
        Label26.TabIndex = 1
        Label26.Text = "ANTICIPO"
        Label26.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Location = New Point(61, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(130, 23)
        TextBox2.TabIndex = 18
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(61, 60)
        Label27.Name = "Label27"
        Label27.Size = New Size(13, 15)
        Label27.TabIndex = 12
        Label27.Text = "0"
        ' 
        ' TableLayoutPanel12
        ' 
        TableLayoutPanel12.ColumnCount = 1
        TableLayoutPanel12.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel12.Controls.Add(Label28, 0, 0)
        TableLayoutPanel12.Location = New Point(0, 0)
        TableLayoutPanel12.Name = "TableLayoutPanel12"
        TableLayoutPanel12.RowCount = 2
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel12.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel12.Size = New Size(200, 100)
        TableLayoutPanel12.TabIndex = 0
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Dock = DockStyle.Fill
        Label28.Location = New Point(3, 0)
        Label28.Name = "Label28"
        Label28.Size = New Size(194, 20)
        Label28.TabIndex = 34
        Label28.Text = "ANTICIPO"
        Label28.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel13
        ' 
        TableLayoutPanel13.ColumnCount = 2
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel13.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel13.Controls.Add(Label29, 0, 2)
        TableLayoutPanel13.Controls.Add(Label30, 0, 0)
        TableLayoutPanel13.Controls.Add(Label31, 1, 0)
        TableLayoutPanel13.Controls.Add(Label32, 0, 1)
        TableLayoutPanel13.Controls.Add(TextBox3, 1, 1)
        TableLayoutPanel13.Controls.Add(Label33, 1, 2)
        TableLayoutPanel13.Dock = DockStyle.Fill
        TableLayoutPanel13.Location = New Point(3, 18)
        TableLayoutPanel13.Name = "TableLayoutPanel13"
        TableLayoutPanel13.RowCount = 3
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel13.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel13.Size = New Size(194, 103)
        TableLayoutPanel13.TabIndex = 20
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Dock = DockStyle.Fill
        Label29.Location = New Point(3, 60)
        Label29.Name = "Label29"
        Label29.Size = New Size(52, 43)
        Label29.TabIndex = 19
        Label29.Text = "FALTANTE"
        Label29.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Dock = DockStyle.Fill
        Label30.Location = New Point(3, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(52, 30)
        Label30.TabIndex = 0
        Label30.Text = "TOTAL"
        Label30.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Dock = DockStyle.Fill
        Label31.Location = New Point(61, 0)
        Label31.Name = "Label31"
        Label31.Size = New Size(130, 30)
        Label31.TabIndex = 17
        Label31.Text = "0"
        Label31.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Dock = DockStyle.Fill
        Label32.Location = New Point(3, 30)
        Label32.Name = "Label32"
        Label32.Size = New Size(52, 30)
        Label32.TabIndex = 1
        Label32.Text = "ANTICIPO"
        Label32.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox3
        ' 
        TextBox3.Dock = DockStyle.Fill
        TextBox3.Location = New Point(61, 33)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(130, 23)
        TextBox3.TabIndex = 18
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Location = New Point(61, 60)
        Label33.Name = "Label33"
        Label33.Size = New Size(13, 15)
        Label33.TabIndex = 12
        Label33.Text = "0"
        ' 
        ' layoutExtras
        ' 
        layoutExtras.ColumnCount = 1
        layoutExtras.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutExtras.Controls.Add(Label34, 0, 0)
        layoutExtras.Controls.Add(TableLayoutPanel15, 0, 1)
        layoutExtras.Dock = DockStyle.Fill
        layoutExtras.Enabled = False
        layoutExtras.Location = New Point(3, 105)
        layoutExtras.Name = "layoutExtras"
        layoutExtras.RowCount = 2
        layoutExtras.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        layoutExtras.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        layoutExtras.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        layoutExtras.Size = New Size(282, 99)
        layoutExtras.TabIndex = 40
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.BackColor = Color.FromArgb(130, 151, 176)
        Label34.Dock = DockStyle.Fill
        Label34.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label34.ForeColor = Color.White
        Label34.Location = New Point(3, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(276, 14)
        Label34.TabIndex = 34
        Label34.Text = "EXTRAS"
        Label34.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel15
        ' 
        TableLayoutPanel15.ColumnCount = 2
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel15.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel15.Controls.Add(Label35, 0, 2)
        TableLayoutPanel15.Controls.Add(Label36, 0, 0)
        TableLayoutPanel15.Controls.Add(Label38, 0, 1)
        TableLayoutPanel15.Controls.Add(lblFaltanteExtra, 1, 2)
        TableLayoutPanel15.Controls.Add(numAnticipoExtra, 1, 1)
        TableLayoutPanel15.Controls.Add(numExtras, 1, 0)
        TableLayoutPanel15.Dock = DockStyle.Fill
        TableLayoutPanel15.Location = New Point(3, 17)
        TableLayoutPanel15.Name = "TableLayoutPanel15"
        TableLayoutPanel15.RowCount = 3
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel15.Size = New Size(276, 79)
        TableLayoutPanel15.TabIndex = 20
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.BackColor = Color.FromArgb(238, 243, 248)
        Label35.Dock = DockStyle.Fill
        Label35.Location = New Point(3, 46)
        Label35.Name = "Label35"
        Label35.Size = New Size(76, 33)
        Label35.TabIndex = 19
        Label35.Text = "FALTANTE"
        Label35.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.BackColor = Color.FromArgb(238, 243, 248)
        Label36.Dock = DockStyle.Fill
        Label36.Location = New Point(3, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(76, 23)
        Label36.TabIndex = 0
        Label36.Text = "TOTAL"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.BackColor = Color.FromArgb(166, 185, 205)
        Label38.Dock = DockStyle.Fill
        Label38.Location = New Point(3, 23)
        Label38.Name = "Label38"
        Label38.Size = New Size(76, 23)
        Label38.TabIndex = 1
        Label38.Text = "ANTICIPO"
        Label38.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFaltanteExtra
        ' 
        lblFaltanteExtra.AutoSize = True
        lblFaltanteExtra.BackColor = Color.White
        lblFaltanteExtra.Dock = DockStyle.Fill
        lblFaltanteExtra.Location = New Point(85, 46)
        lblFaltanteExtra.Name = "lblFaltanteExtra"
        lblFaltanteExtra.Size = New Size(188, 33)
        lblFaltanteExtra.TabIndex = 12
        lblFaltanteExtra.Text = "0"
        lblFaltanteExtra.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' numAnticipoExtra
        ' 
        numAnticipoExtra.BackColor = SystemColors.Menu
        numAnticipoExtra.Dock = DockStyle.Fill
        numAnticipoExtra.Enabled = False
        numAnticipoExtra.Location = New Point(85, 25)
        numAnticipoExtra.Margin = New Padding(3, 2, 3, 2)
        numAnticipoExtra.Name = "numAnticipoExtra"
        numAnticipoExtra.Size = New Size(188, 23)
        numAnticipoExtra.TabIndex = 21
        ' 
        ' numExtras
        ' 
        numExtras.BackColor = SystemColors.Menu
        numExtras.Dock = DockStyle.Fill
        numExtras.Location = New Point(85, 2)
        numExtras.Margin = New Padding(3, 2, 3, 2)
        numExtras.Name = "numExtras"
        numExtras.Size = New Size(188, 23)
        numExtras.TabIndex = 22
        ' 
        ' layoutTitulo
        ' 
        layoutTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        layoutTitulo.ColumnCount = 3
        layoutTitulo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        layoutTitulo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        layoutTitulo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        layoutTitulo.Controls.Add(btnreinicio, 1, 0)
        layoutTitulo.Controls.Add(lblUsuario, 2, 0)
        layoutTitulo.Controls.Add(Label9, 0, 0)
        layoutTitulo.Location = New Point(27, 12)
        layoutTitulo.Name = "layoutTitulo"
        layoutTitulo.RowCount = 1
        layoutTitulo.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        layoutTitulo.Size = New Size(1229, 48)
        layoutTitulo.TabIndex = 41
        ' 
        ' btnreinicio
        ' 
        btnreinicio.Dock = DockStyle.Fill
        btnreinicio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnreinicio.Location = New Point(494, 3)
        btnreinicio.Name = "btnreinicio"
        btnreinicio.Size = New Size(239, 42)
        btnreinicio.TabIndex = 47
        btnreinicio.Text = "Reiniciar todo"
        btnreinicio.UseVisualStyleBackColor = True
        ' 
        ' layoutCliente
        ' 
        layoutCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        layoutCliente.ColumnCount = 3
        layoutCliente.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        layoutCliente.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        layoutCliente.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        layoutCliente.Controls.Add(lblCliente, 0, 0)
        layoutCliente.Controls.Add(NombreSearch, 2, 0)
        layoutCliente.Controls.Add(btnCambiarCliente, 1, 0)
        layoutCliente.Location = New Point(27, 76)
        layoutCliente.Name = "layoutCliente"
        layoutCliente.RowCount = 1
        layoutCliente.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        layoutCliente.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        layoutCliente.Size = New Size(1229, 34)
        layoutCliente.TabIndex = 42
        ' 
        ' btnCambiarCliente
        ' 
        btnCambiarCliente.Dock = DockStyle.Fill
        btnCambiarCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCambiarCliente.Location = New Point(740, 3)
        btnCambiarCliente.Name = "btnCambiarCliente"
        btnCambiarCliente.Size = New Size(239, 28)
        btnCambiarCliente.TabIndex = 20
        btnCambiarCliente.Text = "Modificar Cliente"
        btnCambiarCliente.UseVisualStyleBackColor = True
        ' 
        ' layoutDetalles
        ' 
        layoutDetalles.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        layoutDetalles.ColumnCount = 1
        layoutDetalles.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutDetalles.Controls.Add(LayoutConsideraciones, 0, 0)
        layoutDetalles.Controls.Add(TableLayoutPanel4, 0, 1)
        layoutDetalles.Enabled = False
        layoutDetalles.Location = New Point(637, 124)
        layoutDetalles.Name = "layoutDetalles"
        layoutDetalles.RowCount = 2
        layoutDetalles.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        layoutDetalles.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        layoutDetalles.Size = New Size(619, 436)
        layoutDetalles.TabIndex = 43
        ' 
        ' LayoutPagos
        ' 
        LayoutPagos.ColumnCount = 1
        LayoutPagos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        LayoutPagos.Controls.Add(TableLayoutPanel7, 0, 0)
        LayoutPagos.Controls.Add(layoutExtras, 0, 1)
        LayoutPagos.Dock = DockStyle.Fill
        LayoutPagos.Enabled = False
        LayoutPagos.Location = New Point(296, 3)
        LayoutPagos.Name = "LayoutPagos"
        LayoutPagos.RowCount = 2
        LayoutPagos.RowStyles.Add(New RowStyle(SizeType.Percent, 49.3827171F))
        LayoutPagos.RowStyles.Add(New RowStyle(SizeType.Percent, 50.6172829F))
        LayoutPagos.Size = New Size(288, 207)
        LayoutPagos.TabIndex = 44
        ' 
        ' TableLayoutPanel20
        ' 
        TableLayoutPanel20.ColumnCount = 2
        TableLayoutPanel20.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.Controls.Add(layoutFecha, 0, 0)
        TableLayoutPanel20.Controls.Add(LayoutPagos, 1, 0)
        TableLayoutPanel20.Dock = DockStyle.Fill
        TableLayoutPanel20.Location = New Point(3, 220)
        TableLayoutPanel20.Name = "TableLayoutPanel20"
        TableLayoutPanel20.RowCount = 1
        TableLayoutPanel20.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.Size = New Size(587, 213)
        TableLayoutPanel20.TabIndex = 45
        ' 
        ' LayoutGeneral
        ' 
        LayoutGeneral.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        LayoutGeneral.ColumnCount = 1
        LayoutGeneral.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        LayoutGeneral.Controls.Add(Label1, 0, 0)
        LayoutGeneral.Controls.Add(TableLayoutPanel5, 0, 1)
        LayoutGeneral.Controls.Add(TableLayoutPanel20, 0, 2)
        LayoutGeneral.Location = New Point(27, 124)
        LayoutGeneral.Name = "LayoutGeneral"
        LayoutGeneral.RowCount = 3
        LayoutGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        LayoutGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        LayoutGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        LayoutGeneral.Size = New Size(593, 436)
        LayoutGeneral.TabIndex = 46
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(130, 151, 176)
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(587, 43)
        Label1.TabIndex = 47
        Label1.Text = "DETALLES DEL PAQUETE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormCotizaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(205, 221, 237)
        ClientSize = New Size(1284, 610)
        Controls.Add(LayoutGeneral)
        Controls.Add(layoutDetalles)
        Controls.Add(layoutCliente)
        Controls.Add(layoutTitulo)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1300, 647)
        Name = "FormCotizaciones"
        Text = "Cotizaciones de eventos"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        CType(numAnticipo, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        LayoutConsideraciones.ResumeLayout(False)
        LayoutConsideraciones.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        layoutFecha.ResumeLayout(False)
        TableLayoutPanel10.ResumeLayout(False)
        TableLayoutPanel10.PerformLayout()
        TableLayoutPanel11.ResumeLayout(False)
        TableLayoutPanel11.PerformLayout()
        TableLayoutPanel12.ResumeLayout(False)
        TableLayoutPanel12.PerformLayout()
        TableLayoutPanel13.ResumeLayout(False)
        TableLayoutPanel13.PerformLayout()
        layoutExtras.ResumeLayout(False)
        layoutExtras.PerformLayout()
        TableLayoutPanel15.ResumeLayout(False)
        TableLayoutPanel15.PerformLayout()
        CType(numAnticipoExtra, ComponentModel.ISupportInitialize).EndInit()
        CType(numExtras, ComponentModel.ISupportInitialize).EndInit()
        layoutTitulo.ResumeLayout(False)
        layoutTitulo.PerformLayout()
        layoutCliente.ResumeLayout(False)
        layoutCliente.PerformLayout()
        layoutDetalles.ResumeLayout(False)
        LayoutPagos.ResumeLayout(False)
        TableLayoutPanel20.ResumeLayout(False)
        LayoutGeneral.ResumeLayout(False)
        LayoutGeneral.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents NombreSearch As Button
    Friend WithEvents btnConfirmarOrden As Button
    Friend WithEvents MXN As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblNumPaquete As Label
    Friend WithEvents lblTituloNombrePaquete As Label
    Friend WithEvents lblTituloPaquete As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblTituloDescripcion As Label
    Friend WithEvents lblTituloPrecio As Label
    Friend WithEvents txtConsideraciones As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LayoutConsideraciones As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents CalendarioFechasLibres As MonthCalendar
    Friend WithEvents btnImprimirNota As Button
    Friend WithEvents lblTituloFecha As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lblFecha As Label
    Friend WithEvents layoutFecha As TableLayoutPanel
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Label28 As Label
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents layoutExtras As TableLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents layoutTitulo As TableLayoutPanel
    Friend WithEvents layoutCliente As TableLayoutPanel
    Friend WithEvents layoutDetalles As TableLayoutPanel
    Friend WithEvents LayoutPagos As TableLayoutPanel
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents LayoutGeneral As TableLayoutPanel
    Friend WithEvents btnCambiarCliente As Button
    Friend WithEvents lblFaltanteAnticipo As Label
    Friend WithEvents lblTotalAnticipo As Label
    Friend WithEvents lblFaltanteExtra As Label
    Friend WithEvents numAnticipo As NumericUpDown
    Friend WithEvents numAnticipoExtra As NumericUpDown
    Friend WithEvents numExtras As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnreinicio As Button
End Class
