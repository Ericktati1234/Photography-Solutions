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
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        AltaUsuariosToolStripMenuItem = New ToolStripMenuItem()
        AltaDeUsuariosToolStripMenuItem = New ToolStripMenuItem()
        AltaDePaquetesToolStripMenuItem = New ToolStripMenuItem()
        ManejoDeSesionesToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        Lb_Sesiones_Pasadas = New Label()
        DgvAgendados = New DataGridView()
        DgvFinalizados = New DataGridView()
        Lb_Sesiones_Pendientes = New Label()
        lblTitleUsuario = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        lblBalance = New Label()
        lblUsuario = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Label7 = New Label()
        Label8 = New Label()
        TableLayoutPanel3 = New TableLayoutPanel()
        Label12 = New Label()
        Label11 = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        MenuStrip1.SuspendLayout()
        CType(DgvAgendados, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvFinalizados, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 413)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 1
        Label1.Text = "Texto default"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AltaUsuariosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(1368, 24)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AltaUsuariosToolStripMenuItem
        ' 
        AltaUsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaDeUsuariosToolStripMenuItem, AltaDePaquetesToolStripMenuItem, ManejoDeSesionesToolStripMenuItem, VentasToolStripMenuItem})
        AltaUsuariosToolStripMenuItem.Name = "AltaUsuariosToolStripMenuItem"
        AltaUsuariosToolStripMenuItem.Size = New Size(66, 20)
        AltaUsuariosToolStripMenuItem.Text = "Ventanas"
        ' 
        ' AltaDeUsuariosToolStripMenuItem
        ' 
        AltaDeUsuariosToolStripMenuItem.Name = "AltaDeUsuariosToolStripMenuItem"
        AltaDeUsuariosToolStripMenuItem.Size = New Size(178, 22)
        AltaDeUsuariosToolStripMenuItem.Text = "Alta de Usuarios"
        ' 
        ' AltaDePaquetesToolStripMenuItem
        ' 
        AltaDePaquetesToolStripMenuItem.Name = "AltaDePaquetesToolStripMenuItem"
        AltaDePaquetesToolStripMenuItem.Size = New Size(178, 22)
        AltaDePaquetesToolStripMenuItem.Text = "Alta de Paquetes"
        ' 
        ' ManejoDeSesionesToolStripMenuItem
        ' 
        ManejoDeSesionesToolStripMenuItem.Name = "ManejoDeSesionesToolStripMenuItem"
        ManejoDeSesionesToolStripMenuItem.Size = New Size(178, 22)
        ManejoDeSesionesToolStripMenuItem.Text = "Manejo de Sesiones"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(178, 22)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' Lb_Sesiones_Pasadas
        ' 
        Lb_Sesiones_Pasadas.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lb_Sesiones_Pasadas.AutoSize = True
        Lb_Sesiones_Pasadas.BackColor = SystemColors.AppWorkspace
        Lb_Sesiones_Pasadas.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Lb_Sesiones_Pasadas.ForeColor = Color.White
        Lb_Sesiones_Pasadas.Location = New Point(675, 0)
        Lb_Sesiones_Pasadas.Name = "Lb_Sesiones_Pasadas"
        Lb_Sesiones_Pasadas.Size = New Size(666, 25)
        Lb_Sesiones_Pasadas.TabIndex = 5
        Lb_Sesiones_Pasadas.Text = "SESIONES POR FINALIZAR"
        Lb_Sesiones_Pasadas.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DgvAgendados
        ' 
        DgvAgendados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvAgendados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvAgendados.BorderStyle = BorderStyle.Fixed3D
        DgvAgendados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DgvAgendados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvAgendados.Location = New Point(3, 28)
        DgvAgendados.Name = "DgvAgendados"
        DgvAgendados.RowHeadersWidth = 51
        DgvAgendados.RowTemplate.Height = 25
        DgvAgendados.Size = New Size(666, 481)
        DgvAgendados.TabIndex = 6
        ' 
        ' DgvFinalizados
        ' 
        DgvFinalizados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvFinalizados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DgvFinalizados.BorderStyle = BorderStyle.Fixed3D
        DgvFinalizados.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DgvFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvFinalizados.Location = New Point(675, 28)
        DgvFinalizados.Name = "DgvFinalizados"
        DgvFinalizados.RowHeadersWidth = 51
        DgvFinalizados.RowTemplate.Height = 25
        DgvFinalizados.Size = New Size(666, 481)
        DgvFinalizados.TabIndex = 7
        ' 
        ' Lb_Sesiones_Pendientes
        ' 
        Lb_Sesiones_Pendientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Lb_Sesiones_Pendientes.AutoSize = True
        Lb_Sesiones_Pendientes.BackColor = SystemColors.AppWorkspace
        Lb_Sesiones_Pendientes.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Lb_Sesiones_Pendientes.ForeColor = Color.White
        Lb_Sesiones_Pendientes.Location = New Point(3, 0)
        Lb_Sesiones_Pendientes.Name = "Lb_Sesiones_Pendientes"
        Lb_Sesiones_Pendientes.Size = New Size(666, 25)
        Lb_Sesiones_Pendientes.TabIndex = 8
        Lb_Sesiones_Pendientes.Text = "SESIONES AGENDADAS"
        Lb_Sesiones_Pendientes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitleUsuario
        ' 
        lblTitleUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitleUsuario.AutoSize = True
        lblTitleUsuario.BackColor = Color.White
        lblTitleUsuario.Location = New Point(3, 0)
        lblTitleUsuario.Name = "lblTitleUsuario"
        lblTitleUsuario.Size = New Size(138, 31)
        lblTitleUsuario.TabIndex = 10
        lblTitleUsuario.Text = "Usuario"
        lblTitleUsuario.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Location = New Point(147, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 32)
        Label4.TabIndex = 11
        Label4.Text = "Balance"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Location = New Point(292, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(188, 31)
        Label5.TabIndex = 12
        Label5.Text = "Ingresos"
        Label5.TextAlign = ContentAlignment.MiddleRight
        Label5.UseWaitCursor = True
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Location = New Point(292, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(188, 32)
        Label6.TabIndex = 13
        Label6.Text = "Egresos"
        Label6.TextAlign = ContentAlignment.MiddleRight
        Label6.UseWaitCursor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70F))
        TableLayoutPanel1.Controls.Add(lblBalance, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(lblTitleUsuario, 0, 0)
        TableLayoutPanel1.Controls.Add(lblUsuario, 1, 0)
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns
        TableLayoutPanel1.Location = New Point(64, 27)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(483, 63)
        TableLayoutPanel1.TabIndex = 16
        ' 
        ' lblBalance
        ' 
        lblBalance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblBalance.AutoSize = True
        lblBalance.BackColor = Color.White
        lblBalance.Location = New Point(3, 31)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(138, 32)
        lblBalance.TabIndex = 12
        lblBalance.Text = "Usuario"
        lblBalance.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblUsuario
        ' 
        lblUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblUsuario.AutoSize = True
        lblUsuario.BackColor = Color.White
        lblUsuario.Location = New Point(147, 0)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(333, 31)
        lblUsuario.TabIndex = 13
        lblUsuario.Text = "Usuario"
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft
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
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel3.AutoSize = True
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel3.Controls.Add(Label12, 0, 1)
        TableLayoutPanel3.Controls.Add(Label11, 0, 0)
        TableLayoutPanel3.Controls.Add(Label5, 1, 0)
        TableLayoutPanel3.Controls.Add(Label6, 1, 1)
        TableLayoutPanel3.GrowStyle = TableLayoutPanelGrowStyle.AddColumns
        TableLayoutPanel3.Location = New Point(817, 27)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(483, 63)
        TableLayoutPanel3.TabIndex = 18
        TableLayoutPanel3.UseWaitCursor = True
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.BackColor = Color.White
        Label12.Location = New Point(3, 31)
        Label12.Name = "Label12"
        Label12.Size = New Size(283, 32)
        Label12.TabIndex = 21
        Label12.Text = "Egresos"
        Label12.TextAlign = ContentAlignment.MiddleRight
        Label12.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Location = New Point(3, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(283, 31)
        Label11.TabIndex = 20
        Label11.Text = "Ingresos"
        Label11.TextAlign = ContentAlignment.MiddleRight
        Label11.UseWaitCursor = True
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(Lb_Sesiones_Pendientes, 0, 0)
        TableLayoutPanel4.Controls.Add(DgvAgendados, 0, 1)
        TableLayoutPanel4.Controls.Add(Lb_Sesiones_Pasadas, 1, 0)
        TableLayoutPanel4.Controls.Add(DgvFinalizados, 1, 1)
        TableLayoutPanel4.Location = New Point(12, 128)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 5F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 95F))
        TableLayoutPanel4.Size = New Size(1344, 512)
        TableLayoutPanel4.TabIndex = 20
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ScrollBar
        ClientSize = New Size(1368, 652)
        ControlBox = False
        Controls.Add(TableLayoutPanel4)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DgvAgendados, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvFinalizados, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDePaquetesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Lb_Sesiones_Pasadas As Label
    Friend WithEvents DgvAgendados As DataGridView
    Friend WithEvents DgvFinalizados As DataGridView
    Friend WithEvents Lb_Sesiones_Pendientes As Label
    Friend WithEvents lblTitleUsuario As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ManejoDeSesionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class
