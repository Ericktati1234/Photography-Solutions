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
        lblTituloUsuario = New Label()
        lblTituloCliente = New Label()
        NombreSearch = New Button()
        EliminarSelección = New Button()
        FaltanteAnticipo = New Label()
        lblUsuario = New Label()
        lblCliente = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label3 = New Label()
        Label4 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label6 = New Label()
        Label5 = New Label()
        lblTotalAnticipo = New Label()
        Label8 = New Label()
        txtAnticipo = New TextBox()
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
        RichTextBox1 = New RichTextBox()
        Label10 = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        Button1 = New Button()
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
        TableLayoutPanel14 = New TableLayoutPanel()
        Label34 = New Label()
        TableLayoutPanel15 = New TableLayoutPanel()
        Label35 = New Label()
        Label36 = New Label()
        Label38 = New Label()
        txtAnticipoExtra = New TextBox()
        lblFaltanteExtra = New Label()
        txtTotalExtra = New TextBox()
        TableLayoutPanel16 = New TableLayoutPanel()
        TableLayoutPanel17 = New TableLayoutPanel()
        btnCambiarCliente = New Button()
        layoutDetalles = New TableLayoutPanel()
        LayoutPagos = New TableLayoutPanel()
        TableLayoutPanel20 = New TableLayoutPanel()
        LayoutGeneral = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        layoutFecha.SuspendLayout()
        TableLayoutPanel10.SuspendLayout()
        TableLayoutPanel11.SuspendLayout()
        TableLayoutPanel12.SuspendLayout()
        TableLayoutPanel13.SuspendLayout()
        TableLayoutPanel14.SuspendLayout()
        TableLayoutPanel15.SuspendLayout()
        TableLayoutPanel16.SuspendLayout()
        TableLayoutPanel17.SuspendLayout()
        layoutDetalles.SuspendLayout()
        LayoutPagos.SuspendLayout()
        TableLayoutPanel20.SuspendLayout()
        LayoutGeneral.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTituloUsuario
        ' 
        lblTituloUsuario.AutoSize = True
        lblTituloUsuario.Location = New Point(503, 0)
        lblTituloUsuario.Name = "lblTituloUsuario"
        lblTituloUsuario.Size = New Size(56, 15)
        lblTituloUsuario.TabIndex = 0
        lblTituloUsuario.Text = "USUARIO"
        lblTituloUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloCliente
        ' 
        lblTituloCliente.AutoSize = True
        lblTituloCliente.Dock = DockStyle.Fill
        lblTituloCliente.Location = New Point(3, 0)
        lblTituloCliente.Name = "lblTituloCliente"
        lblTituloCliente.Size = New Size(143, 64)
        lblTituloCliente.TabIndex = 1
        lblTituloCliente.Text = "CLIENTE"
        lblTituloCliente.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' NombreSearch
        ' 
        NombreSearch.Location = New Point(1004, 2)
        NombreSearch.Margin = New Padding(3, 2, 3, 2)
        NombreSearch.Name = "NombreSearch"
        NombreSearch.Size = New Size(245, 66)
        NombreSearch.TabIndex = 5
        NombreSearch.Text = "SELECCIONAR PAQUETE"
        NombreSearch.UseVisualStyleBackColor = True
        ' 
        ' EliminarSelección
        ' 
        EliminarSelección.Dock = DockStyle.Fill
        EliminarSelección.Location = New Point(3, 2)
        EliminarSelección.Margin = New Padding(3, 2, 3, 2)
        EliminarSelección.Name = "EliminarSelección"
        EliminarSelección.Size = New Size(304, 54)
        EliminarSelección.TabIndex = 6
        EliminarSelección.Text = "CONFIRMAR ORDEN"
        EliminarSelección.UseVisualStyleBackColor = True
        ' 
        ' FaltanteAnticipo
        ' 
        FaltanteAnticipo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FaltanteAnticipo.AutoSize = True
        FaltanteAnticipo.Location = New Point(87, 54)
        FaltanteAnticipo.Name = "FaltanteAnticipo"
        FaltanteAnticipo.Size = New Size(193, 38)
        FaltanteAnticipo.TabIndex = 12
        FaltanteAnticipo.Text = "0"
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Location = New Point(753, 0)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(45, 15)
        lblUsuario.TabIndex = 17
        lblUsuario.Text = "Default"
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Dock = DockStyle.Fill
        lblCliente.Location = New Point(152, 0)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(590, 64)
        lblCliente.TabIndex = 18
        lblCliente.Text = "Default"
        lblCliente.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.Controls.Add(lblTituloCliente, 0, 0)
        TableLayoutPanel1.Controls.Add(lblCliente, 1, 0)
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(745, 64)
        TableLayoutPanel1.TabIndex = 19
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
        TableLayoutPanel3.Controls.Add(txtAnticipo, 1, 1)
        TableLayoutPanel3.Controls.Add(FaltanteAnticipo, 1, 2)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 20)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 3
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel3.Size = New Size(283, 92)
        TableLayoutPanel3.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(3, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 38)
        Label6.TabIndex = 19
        Label6.Text = "FALTANTE"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Dock = DockStyle.Fill
        Label5.Location = New Point(3, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 27)
        Label5.TabIndex = 0
        Label5.Text = "TOTAL"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalAnticipo
        ' 
        lblTotalAnticipo.AutoSize = True
        lblTotalAnticipo.Dock = DockStyle.Fill
        lblTotalAnticipo.Location = New Point(87, 0)
        lblTotalAnticipo.Name = "lblTotalAnticipo"
        lblTotalAnticipo.Size = New Size(193, 27)
        lblTotalAnticipo.TabIndex = 17
        lblTotalAnticipo.Text = "0"
        lblTotalAnticipo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Dock = DockStyle.Fill
        Label8.Location = New Point(3, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 27)
        Label8.TabIndex = 1
        Label8.Text = "ANTICIPO"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAnticipo
        ' 
        txtAnticipo.Dock = DockStyle.Fill
        txtAnticipo.Location = New Point(87, 30)
        txtAnticipo.Name = "txtAnticipo"
        txtAnticipo.Size = New Size(193, 23)
        txtAnticipo.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(494, 15)
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
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 4
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel5.Size = New Size(602, 163)
        TableLayoutPanel5.TabIndex = 29
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Dock = DockStyle.Fill
        lblDescripcion.Location = New Point(93, 96)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(506, 67)
        lblDescripcion.TabIndex = 32
        lblDescripcion.Text = "Default"
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Dock = DockStyle.Fill
        lblPrecio.Location = New Point(93, 64)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(506, 32)
        lblPrecio.TabIndex = 31
        lblPrecio.Text = "Default"
        lblPrecio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloDescripcion
        ' 
        lblTituloDescripcion.AutoSize = True
        lblTituloDescripcion.Dock = DockStyle.Fill
        lblTituloDescripcion.Location = New Point(3, 96)
        lblTituloDescripcion.Name = "lblTituloDescripcion"
        lblTituloDescripcion.Size = New Size(84, 67)
        lblTituloDescripcion.TabIndex = 31
        lblTituloDescripcion.Text = "DESCRIPCION"
        lblTituloDescripcion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloPrecio
        ' 
        lblTituloPrecio.AutoSize = True
        lblTituloPrecio.Dock = DockStyle.Fill
        lblTituloPrecio.Location = New Point(3, 64)
        lblTituloPrecio.Name = "lblTituloPrecio"
        lblTituloPrecio.Size = New Size(84, 32)
        lblTituloPrecio.TabIndex = 31
        lblTituloPrecio.Text = "PRECIO MXN"
        lblTituloPrecio.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Dock = DockStyle.Fill
        lblNombre.Location = New Point(93, 32)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(506, 32)
        lblNombre.TabIndex = 31
        lblNombre.Text = "Default"
        lblNombre.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNumPaquete
        ' 
        lblNumPaquete.AutoSize = True
        lblNumPaquete.Dock = DockStyle.Fill
        lblNumPaquete.Location = New Point(93, 0)
        lblNumPaquete.Name = "lblNumPaquete"
        lblNumPaquete.Size = New Size(506, 32)
        lblNumPaquete.TabIndex = 31
        lblNumPaquete.Text = "Default"
        lblNumPaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloNombrePaquete
        ' 
        lblTituloNombrePaquete.AutoSize = True
        lblTituloNombrePaquete.Dock = DockStyle.Fill
        lblTituloNombrePaquete.Location = New Point(3, 32)
        lblTituloNombrePaquete.Name = "lblTituloNombrePaquete"
        lblTituloNombrePaquete.Size = New Size(84, 32)
        lblTituloNombrePaquete.TabIndex = 31
        lblTituloNombrePaquete.Text = "NOMBRE "
        lblTituloNombrePaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTituloPaquete
        ' 
        lblTituloPaquete.AutoSize = True
        lblTituloPaquete.Dock = DockStyle.Fill
        lblTituloPaquete.Location = New Point(3, 0)
        lblTituloPaquete.Name = "lblTituloPaquete"
        lblTituloPaquete.Size = New Size(84, 32)
        lblTituloPaquete.TabIndex = 31
        lblTituloPaquete.Text = "PAQUETE #"
        lblTituloPaquete.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(3, 38)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(614, 313)
        RichTextBox1.TabIndex = 30
        RichTextBox1.Text = ""
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(614, 35)
        Label10.TabIndex = 31
        Label10.Text = "Consideraciones especiales"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 1
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Controls.Add(Label10, 0, 0)
        TableLayoutPanel6.Controls.Add(RichTextBox1, 0, 1)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel6.Size = New Size(620, 354)
        TableLayoutPanel6.TabIndex = 32
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Button1, 1, 0)
        TableLayoutPanel4.Controls.Add(EliminarSelección, 0, 0)
        TableLayoutPanel4.Location = New Point(3, 363)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 1
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(620, 58)
        TableLayoutPanel4.TabIndex = 33
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Fill
        Button1.Location = New Point(313, 2)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(304, 54)
        Button1.TabIndex = 8
        Button1.Text = "IMPRIMIR NOTA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Location = New Point(3, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(283, 17)
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
        TableLayoutPanel7.Size = New Size(289, 115)
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
        lblTituloFecha.Location = New Point(3, 0)
        lblTituloFecha.Name = "lblTituloFecha"
        lblTituloFecha.Size = New Size(51, 43)
        lblTituloFecha.TabIndex = 37
        lblTituloFecha.Text = "Fecha"
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel8.ColumnCount = 2
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel8.Controls.Add(lblFecha, 1, 0)
        TableLayoutPanel8.Controls.Add(lblTituloFecha, 0, 0)
        TableLayoutPanel8.Location = New Point(3, 197)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 1
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel8.Size = New Size(289, 43)
        TableLayoutPanel8.TabIndex = 38
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Dock = DockStyle.Fill
        lblFecha.Location = New Point(60, 0)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(226, 43)
        lblFecha.TabIndex = 39
        lblFecha.Text = "Fecha"
        ' 
        ' layoutFecha
        ' 
        layoutFecha.ColumnCount = 1
        layoutFecha.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutFecha.Controls.Add(CalendarioFechasLibres, 0, 0)
        layoutFecha.Controls.Add(TableLayoutPanel8, 0, 1)
        layoutFecha.Dock = DockStyle.Fill
        layoutFecha.Enabled = False
        layoutFecha.Location = New Point(3, 3)
        layoutFecha.Name = "layoutFecha"
        layoutFecha.RowCount = 2
        layoutFecha.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        layoutFecha.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        layoutFecha.Size = New Size(295, 243)
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
        ' TableLayoutPanel14
        ' 
        TableLayoutPanel14.ColumnCount = 1
        TableLayoutPanel14.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel14.Controls.Add(Label34, 0, 0)
        TableLayoutPanel14.Controls.Add(TableLayoutPanel15, 0, 1)
        TableLayoutPanel14.Dock = DockStyle.Fill
        TableLayoutPanel14.Location = New Point(3, 124)
        TableLayoutPanel14.Name = "TableLayoutPanel14"
        TableLayoutPanel14.RowCount = 2
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        TableLayoutPanel14.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel14.Size = New Size(289, 116)
        TableLayoutPanel14.TabIndex = 40
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Dock = DockStyle.Fill
        Label34.Location = New Point(3, 0)
        Label34.Name = "Label34"
        Label34.Size = New Size(283, 17)
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
        TableLayoutPanel15.Controls.Add(txtAnticipoExtra, 1, 1)
        TableLayoutPanel15.Controls.Add(lblFaltanteExtra, 1, 2)
        TableLayoutPanel15.Controls.Add(txtTotalExtra, 1, 0)
        TableLayoutPanel15.Dock = DockStyle.Fill
        TableLayoutPanel15.Location = New Point(3, 20)
        TableLayoutPanel15.Name = "TableLayoutPanel15"
        TableLayoutPanel15.RowCount = 3
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel15.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel15.Size = New Size(283, 93)
        TableLayoutPanel15.TabIndex = 20
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Dock = DockStyle.Fill
        Label35.Location = New Point(3, 54)
        Label35.Name = "Label35"
        Label35.Size = New Size(78, 39)
        Label35.TabIndex = 19
        Label35.Text = "FALTANTE"
        Label35.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Dock = DockStyle.Fill
        Label36.Location = New Point(3, 0)
        Label36.Name = "Label36"
        Label36.Size = New Size(78, 27)
        Label36.TabIndex = 0
        Label36.Text = "TOTAL"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Dock = DockStyle.Fill
        Label38.Location = New Point(3, 27)
        Label38.Name = "Label38"
        Label38.Size = New Size(78, 27)
        Label38.TabIndex = 1
        Label38.Text = "ANTICIPO"
        Label38.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAnticipoExtra
        ' 
        txtAnticipoExtra.Dock = DockStyle.Fill
        txtAnticipoExtra.Location = New Point(87, 30)
        txtAnticipoExtra.Name = "txtAnticipoExtra"
        txtAnticipoExtra.Size = New Size(193, 23)
        txtAnticipoExtra.TabIndex = 18
        ' 
        ' lblFaltanteExtra
        ' 
        lblFaltanteExtra.AutoSize = True
        lblFaltanteExtra.Dock = DockStyle.Fill
        lblFaltanteExtra.Location = New Point(87, 54)
        lblFaltanteExtra.Name = "lblFaltanteExtra"
        lblFaltanteExtra.Size = New Size(193, 39)
        lblFaltanteExtra.TabIndex = 12
        lblFaltanteExtra.Text = "0"
        ' 
        ' txtTotalExtra
        ' 
        txtTotalExtra.Dock = DockStyle.Fill
        txtTotalExtra.Location = New Point(87, 3)
        txtTotalExtra.Name = "txtTotalExtra"
        txtTotalExtra.Size = New Size(193, 23)
        txtTotalExtra.TabIndex = 20
        ' 
        ' TableLayoutPanel16
        ' 
        TableLayoutPanel16.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel16.ColumnCount = 3
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel16.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel16.Controls.Add(lblTituloUsuario, 1, 0)
        TableLayoutPanel16.Controls.Add(lblUsuario, 2, 0)
        TableLayoutPanel16.Controls.Add(Label9, 0, 0)
        TableLayoutPanel16.Location = New Point(12, 12)
        TableLayoutPanel16.Name = "TableLayoutPanel16"
        TableLayoutPanel16.RowCount = 1
        TableLayoutPanel16.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel16.Size = New Size(1251, 39)
        TableLayoutPanel16.TabIndex = 41
        ' 
        ' TableLayoutPanel17
        ' 
        TableLayoutPanel17.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel17.ColumnCount = 3
        TableLayoutPanel17.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel17.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel17.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel17.Controls.Add(TableLayoutPanel1, 0, 0)
        TableLayoutPanel17.Controls.Add(NombreSearch, 2, 0)
        TableLayoutPanel17.Controls.Add(btnCambiarCliente, 1, 0)
        TableLayoutPanel17.Location = New Point(12, 66)
        TableLayoutPanel17.Name = "TableLayoutPanel17"
        TableLayoutPanel17.RowCount = 1
        TableLayoutPanel17.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel17.Size = New Size(1252, 70)
        TableLayoutPanel17.TabIndex = 42
        ' 
        ' btnCambiarCliente
        ' 
        btnCambiarCliente.Dock = DockStyle.Fill
        btnCambiarCliente.Location = New Point(754, 3)
        btnCambiarCliente.Name = "btnCambiarCliente"
        btnCambiarCliente.Size = New Size(244, 64)
        btnCambiarCliente.TabIndex = 20
        btnCambiarCliente.Text = "Modificar Cliente"
        btnCambiarCliente.UseVisualStyleBackColor = True
        ' 
        ' layoutDetalles
        ' 
        layoutDetalles.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        layoutDetalles.ColumnCount = 1
        layoutDetalles.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutDetalles.Controls.Add(TableLayoutPanel6, 0, 0)
        layoutDetalles.Controls.Add(TableLayoutPanel4, 0, 1)
        layoutDetalles.Enabled = False
        layoutDetalles.Location = New Point(637, 155)
        layoutDetalles.Name = "layoutDetalles"
        layoutDetalles.RowCount = 2
        layoutDetalles.RowStyles.Add(New RowStyle(SizeType.Percent, 85F))
        layoutDetalles.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        layoutDetalles.Size = New Size(626, 424)
        layoutDetalles.TabIndex = 43
        ' 
        ' LayoutPagos
        ' 
        LayoutPagos.ColumnCount = 1
        LayoutPagos.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        LayoutPagos.Controls.Add(TableLayoutPanel7, 0, 0)
        LayoutPagos.Controls.Add(TableLayoutPanel14, 0, 1)
        LayoutPagos.Dock = DockStyle.Fill
        LayoutPagos.Enabled = False
        LayoutPagos.Location = New Point(304, 3)
        LayoutPagos.Name = "LayoutPagos"
        LayoutPagos.RowCount = 2
        LayoutPagos.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        LayoutPagos.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        LayoutPagos.Size = New Size(295, 243)
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
        TableLayoutPanel20.Location = New Point(3, 172)
        TableLayoutPanel20.Name = "TableLayoutPanel20"
        TableLayoutPanel20.RowCount = 1
        TableLayoutPanel20.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel20.Size = New Size(602, 249)
        TableLayoutPanel20.TabIndex = 45
        ' 
        ' LayoutGeneral
        ' 
        LayoutGeneral.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        LayoutGeneral.ColumnCount = 1
        LayoutGeneral.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        LayoutGeneral.Controls.Add(TableLayoutPanel5, 0, 0)
        LayoutGeneral.Controls.Add(TableLayoutPanel20, 0, 1)
        LayoutGeneral.Location = New Point(12, 155)
        LayoutGeneral.Name = "LayoutGeneral"
        LayoutGeneral.RowCount = 2
        LayoutGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        LayoutGeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        LayoutGeneral.Size = New Size(608, 424)
        LayoutGeneral.TabIndex = 46
        ' 
        ' FormCotizaciones
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1285, 610)
        Controls.Add(LayoutGeneral)
        Controls.Add(layoutDetalles)
        Controls.Add(TableLayoutPanel17)
        Controls.Add(TableLayoutPanel16)
        Margin = New Padding(3, 2, 3, 2)
        MinimumSize = New Size(1301, 649)
        Name = "FormCotizaciones"
        Text = "Ventas"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
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
        TableLayoutPanel14.ResumeLayout(False)
        TableLayoutPanel14.PerformLayout()
        TableLayoutPanel15.ResumeLayout(False)
        TableLayoutPanel15.PerformLayout()
        TableLayoutPanel16.ResumeLayout(False)
        TableLayoutPanel16.PerformLayout()
        TableLayoutPanel17.ResumeLayout(False)
        layoutDetalles.ResumeLayout(False)
        LayoutPagos.ResumeLayout(False)
        TableLayoutPanel20.ResumeLayout(False)
        LayoutGeneral.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTituloUsuario As Label
    Friend WithEvents lblTituloCliente As Label
    Friend WithEvents NombreSearch As Button
    Friend WithEvents EliminarSelección As Button
    Friend WithEvents MXN As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
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
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents CalendarioFechasLibres As MonthCalendar
    Friend WithEvents Button1 As Button
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
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents Label34 As Label
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents layoutDetalles As TableLayoutPanel
    Friend WithEvents LayoutPagos As TableLayoutPanel
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents LayoutGeneral As TableLayoutPanel
    Friend WithEvents btnCambiarCliente As Button
    Friend WithEvents FaltanteAnticipo As Label
    Friend WithEvents lblTotalAnticipo As Label
    Friend WithEvents txtAnticipo As TextBox
    Friend WithEvents txtAnticipoExtra As TextBox
    Friend WithEvents lblFaltanteExtra As Label
    Friend WithEvents txtTotalExtra As TextBox
End Class
