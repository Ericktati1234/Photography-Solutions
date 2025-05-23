<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        MenuStrip1 = New MenuStrip()
        TSMIHome = New ToolStripMenuItem()
        OptUsuarios = New ToolStripMenuItem()
        OptPaquetes = New ToolStripMenuItem()
        OptReportes = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        Lb_Sesiones_Pasadas = New Label()
        DgvAgendados = New DataGridView()
        DgvFinalizados = New DataGridView()
        Lb_Sesiones_Pendientes = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        Label8 = New Label()
        layoutgeneral = New TableLayoutPanel()
        TableLayoutPanel8 = New TableLayoutPanel()
        lblIdEditar = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        lblClienteEditar = New Label()
        lblPaqueteEditar = New Label()
        lblRealizadoEditar = New Label()
        lblEntregaEditar = New Label()
        lblFaltanteEditar = New Label()
        lable123 = New Label()
        btnCotizacionNueva = New Button()
        btnSalir = New Button()
        btnPagosSesion = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label14 = New Label()
        lblIDPago = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblCliente = New Label()
        lblPaquete = New Label()
        lblRealizacion = New Label()
        lblEntrega = New Label()
        lblFaltante = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblUsuario = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        layoutGenerales = New TableLayoutPanel()
        layoutBotones = New TableLayoutPanel()
        btnGestionImagenes = New Button()
        btnEliminarSesionAgendada = New Button()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(DgvAgendados, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvFinalizados, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        layoutgeneral.SuspendLayout()
        TableLayoutPanel8.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        layoutGenerales.SuspendLayout()
        layoutBotones.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {TSMIHome})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1368, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' TSMIHome
        ' 
        TSMIHome.DropDownItems.AddRange(New ToolStripItem() {OptUsuarios, OptPaquetes, OptReportes, ClientesToolStripMenuItem})
        TSMIHome.Name = "TSMIHome"
        TSMIHome.Size = New Size(69, 20)
        TSMIHome.Text = "Opciones"
        TSMIHome.Visible = False
        ' 
        ' OptUsuarios
        ' 
        OptUsuarios.Name = "OptUsuarios"
        OptUsuarios.Size = New Size(122, 22)
        OptUsuarios.Text = "Usuarios"
        ' 
        ' OptPaquetes
        ' 
        OptPaquetes.Name = "OptPaquetes"
        OptPaquetes.Size = New Size(122, 22)
        OptPaquetes.Text = "Paquetes"
        ' 
        ' OptReportes
        ' 
        OptReportes.Name = "OptReportes"
        OptReportes.Size = New Size(122, 22)
        OptReportes.Text = "Reportes"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(122, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' Lb_Sesiones_Pasadas
        ' 
        Lb_Sesiones_Pasadas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lb_Sesiones_Pasadas.AutoSize = True
        Lb_Sesiones_Pasadas.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Lb_Sesiones_Pasadas.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Lb_Sesiones_Pasadas.ForeColor = Color.White
        Lb_Sesiones_Pasadas.Location = New Point(3, 255)
        Lb_Sesiones_Pasadas.Name = "Lb_Sesiones_Pasadas"
        Lb_Sesiones_Pasadas.Size = New Size(1072, 37)
        Lb_Sesiones_Pasadas.TabIndex = 5
        Lb_Sesiones_Pasadas.Text = "SESIONES POR FINALIZAR"
        Lb_Sesiones_Pasadas.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' DgvAgendados
        ' 
        DgvAgendados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvAgendados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvAgendados.BackgroundColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DgvAgendados.BorderStyle = BorderStyle.Fixed3D
        DgvAgendados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DgvAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvAgendados.Location = New Point(3, 40)
        DgvAgendados.Name = "DgvAgendados"
        DgvAgendados.RowHeadersWidth = 51
        DgvAgendados.RowTemplate.Height = 25
        DgvAgendados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvAgendados.Size = New Size(1072, 157)
        DgvAgendados.TabIndex = 6
        ' 
        ' DgvFinalizados
        ' 
        DgvFinalizados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvFinalizados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvFinalizados.BackgroundColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DgvFinalizados.BorderStyle = BorderStyle.Fixed3D
        DgvFinalizados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DgvFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvFinalizados.Location = New Point(3, 295)
        DgvFinalizados.Name = "DgvFinalizados"
        DgvFinalizados.RowHeadersWidth = 51
        DgvFinalizados.RowTemplate.Height = 25
        DgvFinalizados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvFinalizados.Size = New Size(1072, 159)
        DgvFinalizados.TabIndex = 7
        ' 
        ' Lb_Sesiones_Pendientes
        ' 
        Lb_Sesiones_Pendientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lb_Sesiones_Pendientes.AutoSize = True
        Lb_Sesiones_Pendientes.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Lb_Sesiones_Pendientes.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Lb_Sesiones_Pendientes.ForeColor = Color.White
        Lb_Sesiones_Pendientes.Location = New Point(3, 0)
        Lb_Sesiones_Pendientes.Name = "Lb_Sesiones_Pendientes"
        Lb_Sesiones_Pendientes.Size = New Size(1072, 37)
        Lb_Sesiones_Pendientes.TabIndex = 8
        Lb_Sesiones_Pendientes.Text = "SESIONES AGENDADAS"
        Lb_Sesiones_Pendientes.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.AutoSize = True
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel2.Controls.Add(Label7, 0, 0)
        TableLayoutPanel2.Location = New Point(0, 0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(200, 100)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 10
        Label7.Text = "Usuario"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Location = New Point(3, 15)
        Label8.Name = "Label8"
        Label8.Size = New Size(48, 15)
        Label8.TabIndex = 11
        Label8.Text = "Balance"
        ' 
        ' layoutgeneral
        ' 
        layoutgeneral.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        layoutgeneral.ColumnCount = 1
        layoutgeneral.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutgeneral.Controls.Add(TableLayoutPanel8, 0, 2)
        layoutgeneral.Controls.Add(Lb_Sesiones_Pendientes, 0, 0)
        layoutgeneral.Controls.Add(DgvFinalizados, 0, 4)
        layoutgeneral.Controls.Add(Lb_Sesiones_Pasadas, 0, 3)
        layoutgeneral.Controls.Add(DgvAgendados, 0, 1)
        layoutgeneral.Location = New Point(3, 3)
        layoutgeneral.Name = "layoutgeneral"
        layoutgeneral.RowCount = 5
        layoutgeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 8.163265F))
        layoutgeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 35.7142868F))
        layoutgeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 12.2448978F))
        layoutgeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 8.163265F))
        layoutgeneral.RowStyles.Add(New RowStyle(SizeType.Percent, 35.7142868F))
        layoutgeneral.Size = New Size(1078, 457)
        layoutgeneral.TabIndex = 20
        ' 
        ' TableLayoutPanel8
        ' 
        TableLayoutPanel8.ColumnCount = 6
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.727272F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel8.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.636364F))
        TableLayoutPanel8.Controls.Add(lblIdEditar, 0, 1)
        TableLayoutPanel8.Controls.Add(Label6, 1, 0)
        TableLayoutPanel8.Controls.Add(Label9, 2, 0)
        TableLayoutPanel8.Controls.Add(Label10, 3, 0)
        TableLayoutPanel8.Controls.Add(Label11, 4, 0)
        TableLayoutPanel8.Controls.Add(Label12, 5, 0)
        TableLayoutPanel8.Controls.Add(lblClienteEditar, 1, 1)
        TableLayoutPanel8.Controls.Add(lblPaqueteEditar, 2, 1)
        TableLayoutPanel8.Controls.Add(lblRealizadoEditar, 3, 1)
        TableLayoutPanel8.Controls.Add(lblEntregaEditar, 4, 1)
        TableLayoutPanel8.Controls.Add(lblFaltanteEditar, 5, 1)
        TableLayoutPanel8.Controls.Add(lable123, 0, 0)
        TableLayoutPanel8.Dock = DockStyle.Fill
        TableLayoutPanel8.Location = New Point(3, 202)
        TableLayoutPanel8.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel8.Name = "TableLayoutPanel8"
        TableLayoutPanel8.RowCount = 2
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel8.Size = New Size(1072, 51)
        TableLayoutPanel8.TabIndex = 31
        ' 
        ' lblIdEditar
        ' 
        lblIdEditar.AutoSize = True
        lblIdEditar.BackColor = Color.White
        lblIdEditar.Dock = DockStyle.Fill
        lblIdEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblIdEditar.Location = New Point(3, 25)
        lblIdEditar.Name = "lblIdEditar"
        lblIdEditar.Size = New Size(91, 26)
        lblIdEditar.TabIndex = 31
        lblIdEditar.Text = "default"
        lblIdEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(100, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(237, 25)
        Label6.TabIndex = 0
        Label6.Text = "Cliente"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label9.Dock = DockStyle.Fill
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(343, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(188, 25)
        Label9.TabIndex = 1
        Label9.Text = "Paquete"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(537, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(188, 25)
        Label10.TabIndex = 2
        Label10.Text = "Realizado"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(731, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(188, 25)
        Label11.TabIndex = 3
        Label11.Text = "Entrega"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label12.Dock = DockStyle.Fill
        Label12.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(925, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(144, 25)
        Label12.TabIndex = 4
        Label12.Text = "Faltante"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblClienteEditar
        ' 
        lblClienteEditar.AutoSize = True
        lblClienteEditar.BackColor = Color.White
        lblClienteEditar.Dock = DockStyle.Fill
        lblClienteEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblClienteEditar.Location = New Point(100, 25)
        lblClienteEditar.Name = "lblClienteEditar"
        lblClienteEditar.Size = New Size(237, 26)
        lblClienteEditar.TabIndex = 5
        lblClienteEditar.Text = "default"
        lblClienteEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPaqueteEditar
        ' 
        lblPaqueteEditar.AutoSize = True
        lblPaqueteEditar.BackColor = Color.White
        lblPaqueteEditar.Dock = DockStyle.Fill
        lblPaqueteEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPaqueteEditar.Location = New Point(343, 25)
        lblPaqueteEditar.Name = "lblPaqueteEditar"
        lblPaqueteEditar.Size = New Size(188, 26)
        lblPaqueteEditar.TabIndex = 6
        lblPaqueteEditar.Text = "default"
        lblPaqueteEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRealizadoEditar
        ' 
        lblRealizadoEditar.AutoSize = True
        lblRealizadoEditar.BackColor = Color.White
        lblRealizadoEditar.Dock = DockStyle.Fill
        lblRealizadoEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRealizadoEditar.Location = New Point(537, 25)
        lblRealizadoEditar.Name = "lblRealizadoEditar"
        lblRealizadoEditar.Size = New Size(188, 26)
        lblRealizadoEditar.TabIndex = 7
        lblRealizadoEditar.Text = "default"
        lblRealizadoEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEntregaEditar
        ' 
        lblEntregaEditar.AutoSize = True
        lblEntregaEditar.BackColor = Color.White
        lblEntregaEditar.Dock = DockStyle.Fill
        lblEntregaEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEntregaEditar.Location = New Point(731, 25)
        lblEntregaEditar.Name = "lblEntregaEditar"
        lblEntregaEditar.Size = New Size(188, 26)
        lblEntregaEditar.TabIndex = 8
        lblEntregaEditar.Text = "default"
        lblEntregaEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFaltanteEditar
        ' 
        lblFaltanteEditar.AutoSize = True
        lblFaltanteEditar.BackColor = Color.White
        lblFaltanteEditar.Dock = DockStyle.Fill
        lblFaltanteEditar.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFaltanteEditar.Location = New Point(925, 25)
        lblFaltanteEditar.Name = "lblFaltanteEditar"
        lblFaltanteEditar.Size = New Size(144, 26)
        lblFaltanteEditar.TabIndex = 9
        lblFaltanteEditar.Text = "default"
        lblFaltanteEditar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lable123
        ' 
        lable123.AutoSize = True
        lable123.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        lable123.Dock = DockStyle.Fill
        lable123.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lable123.Location = New Point(3, 0)
        lable123.Name = "lable123"
        lable123.Size = New Size(91, 25)
        lable123.TabIndex = 10
        lable123.Text = "ID "
        lable123.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCotizacionNueva
        ' 
        btnCotizacionNueva.FlatStyle = FlatStyle.System
        btnCotizacionNueva.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCotizacionNueva.Location = New Point(3, 2)
        btnCotizacionNueva.Margin = New Padding(3, 2, 3, 2)
        btnCotizacionNueva.Name = "btnCotizacionNueva"
        btnCotizacionNueva.Size = New Size(188, 46)
        btnCotizacionNueva.TabIndex = 21
        btnCotizacionNueva.Text = "Crear Cotizacion"
        btnCotizacionNueva.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSalir.FlatStyle = FlatStyle.System
        btnSalir.Location = New Point(65, 561)
        btnSalir.Margin = New Padding(3, 2, 3, 2)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(123, 43)
        btnSalir.TabIndex = 22
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnPagosSesion
        ' 
        btnPagosSesion.Dock = DockStyle.Fill
        btnPagosSesion.FlatStyle = FlatStyle.System
        btnPagosSesion.Location = New Point(919, 2)
        btnPagosSesion.Margin = New Padding(3, 2, 3, 2)
        btnPagosSesion.Name = "btnPagosSesion"
        btnPagosSesion.Size = New Size(156, 44)
        btnPagosSesion.TabIndex = 23
        btnPagosSesion.Text = "Realizar un Pago"
        btnPagosSesion.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 6
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 9.090909F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.727272F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.181818F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.636364F))
        TableLayoutPanel3.Controls.Add(Label14, 0, 0)
        TableLayoutPanel3.Controls.Add(lblIDPago, 0, 1)
        TableLayoutPanel3.Controls.Add(Label1, 1, 0)
        TableLayoutPanel3.Controls.Add(Label2, 2, 0)
        TableLayoutPanel3.Controls.Add(Label3, 3, 0)
        TableLayoutPanel3.Controls.Add(Label4, 4, 0)
        TableLayoutPanel3.Controls.Add(Label5, 5, 0)
        TableLayoutPanel3.Controls.Add(lblCliente, 1, 1)
        TableLayoutPanel3.Controls.Add(lblPaquete, 2, 1)
        TableLayoutPanel3.Controls.Add(lblRealizacion, 3, 1)
        TableLayoutPanel3.Controls.Add(lblEntrega, 4, 1)
        TableLayoutPanel3.Controls.Add(lblFaltante, 5, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 2)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(910, 44)
        TableLayoutPanel3.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label14.Dock = DockStyle.Fill
        Label14.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(3, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(76, 22)
        Label14.TabIndex = 32
        Label14.Text = "ID "
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIDPago
        ' 
        lblIDPago.AutoSize = True
        lblIDPago.BackColor = Color.White
        lblIDPago.Dock = DockStyle.Fill
        lblIDPago.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblIDPago.Location = New Point(3, 22)
        lblIDPago.Name = "lblIDPago"
        lblIDPago.Size = New Size(76, 22)
        lblIDPago.TabIndex = 33
        lblIDPago.Text = "default"
        lblIDPago.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(85, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 22)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(291, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 22)
        Label2.TabIndex = 1
        Label2.Text = "Paquete"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(456, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 22)
        Label3.TabIndex = 2
        Label3.Text = "Realizado"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(621, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(159, 22)
        Label4.TabIndex = 3
        Label4.Text = "Entrega"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(786, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 22)
        Label5.TabIndex = 4
        Label5.Text = "Faltante"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.BackColor = Color.White
        lblCliente.Dock = DockStyle.Fill
        lblCliente.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblCliente.Location = New Point(85, 22)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(200, 22)
        lblCliente.TabIndex = 5
        lblCliente.Text = "default"
        lblCliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPaquete
        ' 
        lblPaquete.AutoSize = True
        lblPaquete.BackColor = Color.White
        lblPaquete.Dock = DockStyle.Fill
        lblPaquete.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblPaquete.Location = New Point(291, 22)
        lblPaquete.Name = "lblPaquete"
        lblPaquete.Size = New Size(159, 22)
        lblPaquete.TabIndex = 6
        lblPaquete.Text = "default"
        lblPaquete.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRealizacion
        ' 
        lblRealizacion.AutoSize = True
        lblRealizacion.BackColor = Color.White
        lblRealizacion.Dock = DockStyle.Fill
        lblRealizacion.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblRealizacion.Location = New Point(456, 22)
        lblRealizacion.Name = "lblRealizacion"
        lblRealizacion.Size = New Size(159, 22)
        lblRealizacion.TabIndex = 7
        lblRealizacion.Text = "default"
        lblRealizacion.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEntrega
        ' 
        lblEntrega.AutoSize = True
        lblEntrega.BackColor = Color.White
        lblEntrega.Dock = DockStyle.Fill
        lblEntrega.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblEntrega.Location = New Point(621, 22)
        lblEntrega.Name = "lblEntrega"
        lblEntrega.Size = New Size(159, 22)
        lblEntrega.TabIndex = 8
        lblEntrega.Text = "default"
        lblEntrega.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFaltante
        ' 
        lblFaltante.AutoSize = True
        lblFaltante.BackColor = Color.White
        lblFaltante.Dock = DockStyle.Fill
        lblFaltante.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        lblFaltante.Location = New Point(786, 22)
        lblFaltante.Name = "lblFaltante"
        lblFaltante.Size = New Size(121, 22)
        lblFaltante.TabIndex = 9
        lblFaltante.Text = "default"
        lblFaltante.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(16, 295)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(7, 6)
        FlowLayoutPanel1.TabIndex = 25
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 1
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel5.Controls.Add(lblUsuario, 0, 0)
        TableLayoutPanel5.Location = New Point(42, 38)
        TableLayoutPanel5.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 1
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel5.Size = New Size(931, 30)
        TableLayoutPanel5.TabIndex = 26
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        lblUsuario.Dock = DockStyle.Left
        lblUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblUsuario.Location = New Point(3, 0)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(64, 30)
        lblUsuario.TabIndex = 13
        lblUsuario.Text = "Usuario"
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel6.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel6.Controls.Add(btnPagosSesion, 1, 0)
        TableLayoutPanel6.Location = New Point(3, 465)
        TableLayoutPanel6.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(1078, 48)
        TableLayoutPanel6.TabIndex = 27
        ' 
        ' layoutGenerales
        ' 
        layoutGenerales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        layoutGenerales.ColumnCount = 1
        layoutGenerales.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutGenerales.Controls.Add(layoutgeneral, 0, 0)
        layoutGenerales.Controls.Add(TableLayoutPanel6, 0, 1)
        layoutGenerales.Location = New Point(253, 89)
        layoutGenerales.Margin = New Padding(3, 2, 3, 2)
        layoutGenerales.Name = "layoutGenerales"
        layoutGenerales.RowCount = 2
        layoutGenerales.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        layoutGenerales.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        layoutGenerales.Size = New Size(1084, 515)
        layoutGenerales.TabIndex = 28
        ' 
        ' layoutBotones
        ' 
        layoutBotones.ColumnCount = 1
        layoutBotones.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        layoutBotones.Controls.Add(btnGestionImagenes, 0, 2)
        layoutBotones.Controls.Add(btnCotizacionNueva, 0, 0)
        layoutBotones.Controls.Add(btnEliminarSesionAgendada, 0, 1)
        layoutBotones.Location = New Point(31, 105)
        layoutBotones.Name = "layoutBotones"
        layoutBotones.RowCount = 3
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        layoutBotones.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        layoutBotones.Size = New Size(194, 227)
        layoutBotones.TabIndex = 29
        ' 
        ' btnGestionImagenes
        ' 
        btnGestionImagenes.FlatStyle = FlatStyle.System
        btnGestionImagenes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnGestionImagenes.Location = New Point(3, 152)
        btnGestionImagenes.Margin = New Padding(3, 2, 3, 2)
        btnGestionImagenes.Name = "btnGestionImagenes"
        btnGestionImagenes.Size = New Size(188, 46)
        btnGestionImagenes.TabIndex = 31
        btnGestionImagenes.Text = "Gestionar Imagenes"
        btnGestionImagenes.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarSesionAgendada
        ' 
        btnEliminarSesionAgendada.FlatStyle = FlatStyle.System
        btnEliminarSesionAgendada.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminarSesionAgendada.Location = New Point(3, 77)
        btnEliminarSesionAgendada.Margin = New Padding(3, 2, 3, 2)
        btnEliminarSesionAgendada.Name = "btnEliminarSesionAgendada"
        btnEliminarSesionAgendada.Size = New Size(188, 46)
        btnEliminarSesionAgendada.TabIndex = 32
        btnEliminarSesionAgendada.Text = "Eliminar Sesion seleccionada"
        btnEliminarSesionAgendada.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 375)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 160)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(1368, 652)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(layoutBotones)
        Controls.Add(layoutGenerales)
        Controls.Add(TableLayoutPanel5)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(btnSalir)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DgvAgendados, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvFinalizados, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        layoutgeneral.ResumeLayout(False)
        layoutgeneral.PerformLayout()
        TableLayoutPanel8.ResumeLayout(False)
        TableLayoutPanel8.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        layoutGenerales.ResumeLayout(False)
        layoutBotones.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMIHome As ToolStripMenuItem
    Friend WithEvents OptUsuarios As ToolStripMenuItem
    Friend WithEvents OptPaquetes As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Lb_Sesiones_Pasadas As Label
    Friend WithEvents DgvAgendados As DataGridView
    Friend WithEvents DgvFinalizados As DataGridView
    Friend WithEvents Lb_Sesiones_Pendientes As Label
    Friend WithEvents OptReportes As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents layoutgeneral As TableLayoutPanel
    Friend WithEvents btnCotizacionNueva As Button
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnPagosSesion As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblPaquete As Label
    Friend WithEvents lblRealizacion As Label
    Friend WithEvents lblEntrega As Label
    Friend WithEvents lblFaltante As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents layoutGenerales As TableLayoutPanel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents layoutBotones As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGestionImagenes As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblClienteEditar As Label
    Friend WithEvents lblPaqueteEditar As Label
    Friend WithEvents lblRealizadoEditar As Label
    Friend WithEvents lblEntregaEditar As Label
    Friend WithEvents lblFaltanteEditar As Label
    Friend WithEvents lblIdEditar As Label
    Friend WithEvents lable123 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblIDPago As Label
    Friend WithEvents btnEliminarSesionAgendada As Button
End Class
