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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
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
        TableLayoutPanel4 = New TableLayoutPanel()
        btnCotizacionNueva = New Button()
        btnSalir = New Button()
        Button3 = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel5 = New TableLayoutPanel()
        lblUsuario = New Label()
        TableLayoutPanel6 = New TableLayoutPanel()
        TableLayoutPanel7 = New TableLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(DgvAgendados, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvFinalizados, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
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
        OptUsuarios.Size = New Size(180, 22)
        OptUsuarios.Text = "Usuarios"
        ' 
        ' OptPaquetes
        ' 
        OptPaquetes.Name = "OptPaquetes"
        OptPaquetes.Size = New Size(180, 22)
        OptPaquetes.Text = "Paquetes"
        ' 
        ' OptReportes
        ' 
        OptReportes.Name = "OptReportes"
        OptReportes.Size = New Size(180, 22)
        OptReportes.Text = "Reportes"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(180, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' Lb_Sesiones_Pasadas
        ' 
        Lb_Sesiones_Pasadas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lb_Sesiones_Pasadas.AutoSize = True
        Lb_Sesiones_Pasadas.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Lb_Sesiones_Pasadas.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Lb_Sesiones_Pasadas.ForeColor = Color.White
        Lb_Sesiones_Pasadas.Location = New Point(3, 227)
        Lb_Sesiones_Pasadas.Name = "Lb_Sesiones_Pasadas"
        Lb_Sesiones_Pasadas.Size = New Size(1072, 36)
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
        DgvAgendados.Location = New Point(3, 39)
        DgvAgendados.Name = "DgvAgendados"
        DgvAgendados.RowHeadersWidth = 51
        DgvAgendados.RowTemplate.Height = 25
        DgvAgendados.Size = New Size(1072, 176)
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
        DgvFinalizados.Location = New Point(3, 266)
        DgvFinalizados.Name = "DgvFinalizados"
        DgvFinalizados.RowHeadersWidth = 51
        DgvFinalizados.RowTemplate.Height = 25
        DgvFinalizados.Size = New Size(1072, 188)
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
        Lb_Sesiones_Pendientes.Size = New Size(1072, 36)
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
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 1
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel4.Controls.Add(Lb_Sesiones_Pendientes, 0, 0)
        TableLayoutPanel4.Controls.Add(DgvFinalizados, 0, 4)
        TableLayoutPanel4.Controls.Add(Lb_Sesiones_Pasadas, 0, 3)
        TableLayoutPanel4.Controls.Add(DgvAgendados, 0, 1)
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 5
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 8F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 2F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 8F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 42F))
        TableLayoutPanel4.Size = New Size(1078, 457)
        TableLayoutPanel4.TabIndex = 20
        ' 
        ' btnCotizacionNueva
        ' 
        btnCotizacionNueva.Dock = DockStyle.Top
        btnCotizacionNueva.FlatStyle = FlatStyle.System
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
        ' Button3
        ' 
        Button3.Dock = DockStyle.Fill
        Button3.FlatStyle = FlatStyle.System
        Button3.Location = New Point(865, 2)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(210, 44)
        Button3.TabIndex = 23
        Button3.Text = "Gestionar Sesion seleccionada"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 5
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.Controls.Add(Label1, 0, 0)
        TableLayoutPanel3.Controls.Add(Label2, 1, 0)
        TableLayoutPanel3.Controls.Add(Label3, 2, 0)
        TableLayoutPanel3.Controls.Add(Label4, 3, 0)
        TableLayoutPanel3.Controls.Add(Label5, 4, 0)
        TableLayoutPanel3.Controls.Add(Label6, 0, 1)
        TableLayoutPanel3.Controls.Add(Label9, 1, 1)
        TableLayoutPanel3.Controls.Add(Label10, 2, 1)
        TableLayoutPanel3.Controls.Add(Label11, 3, 1)
        TableLayoutPanel3.Controls.Add(Label12, 4, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 2)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(856, 44)
        TableLayoutPanel3.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 22)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label2.Dock = DockStyle.Fill
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(217, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 22)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(431, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 22)
        Label3.TabIndex = 2
        Label3.Text = "Label3"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label4.Dock = DockStyle.Fill
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(602, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 22)
        Label4.TabIndex = 3
        Label4.Text = "Label4"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        Label5.Dock = DockStyle.Fill
        Label5.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(773, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 22)
        Label5.TabIndex = 4
        Label5.Text = "Label5"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Dock = DockStyle.Fill
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(3, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 22)
        Label6.TabIndex = 5
        Label6.Text = "Label6"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Dock = DockStyle.Fill
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(217, 22)
        Label9.Name = "Label9"
        Label9.Size = New Size(208, 22)
        Label9.TabIndex = 6
        Label9.Text = "Label9"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Dock = DockStyle.Fill
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(431, 22)
        Label10.Name = "Label10"
        Label10.Size = New Size(165, 22)
        Label10.TabIndex = 7
        Label10.Text = "Label10"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Dock = DockStyle.Fill
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(602, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(165, 22)
        Label11.TabIndex = 8
        Label11.Text = "Label11"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Dock = DockStyle.Fill
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(773, 22)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 22)
        Label12.TabIndex = 9
        Label12.Text = "Label12"
        Label12.TextAlign = ContentAlignment.MiddleCenter
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
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel6.Controls.Add(TableLayoutPanel3, 0, 0)
        TableLayoutPanel6.Controls.Add(Button3, 1, 0)
        TableLayoutPanel6.Location = New Point(3, 465)
        TableLayoutPanel6.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(1078, 48)
        TableLayoutPanel6.TabIndex = 27
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel7.ColumnCount = 1
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel7.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel7.Controls.Add(TableLayoutPanel6, 0, 1)
        TableLayoutPanel7.Location = New Point(253, 89)
        TableLayoutPanel7.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel7.Size = New Size(1084, 515)
        TableLayoutPanel7.TabIndex = 28
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Button1, 0, 1)
        TableLayoutPanel1.Controls.Add(btnCotizacionNueva, 0, 0)
        TableLayoutPanel1.Location = New Point(31, 106)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(194, 176)
        TableLayoutPanel1.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Top
        Button1.FlatStyle = FlatStyle.System
        Button1.Location = New Point(3, 90)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 46)
        Button1.TabIndex = 22
        Button1.Text = "Crear Cotizacion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 358)
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
        Controls.Add(TableLayoutPanel1)
        Controls.Add(TableLayoutPanel7)
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
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel5.PerformLayout()
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
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
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btnCotizacionNueva As Button
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
