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
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        Lb_Sesiones_Pendientes = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
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
        MenuStrip1.Size = New Size(1147, 24)
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
        Lb_Sesiones_Pasadas.AutoSize = True
        Lb_Sesiones_Pasadas.BackColor = SystemColors.AppWorkspace
        Lb_Sesiones_Pasadas.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Lb_Sesiones_Pasadas.ForeColor = Color.White
        Lb_Sesiones_Pasadas.Location = New Point(662, 102)
        Lb_Sesiones_Pasadas.Name = "Lb_Sesiones_Pasadas"
        Lb_Sesiones_Pasadas.Size = New Size(269, 37)
        Lb_Sesiones_Pasadas.TabIndex = 5
        Lb_Sesiones_Pasadas.Text = "SESIONES PASADAS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(144, 149)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(403, 276)
        DataGridView1.TabIndex = 6
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(596, 149)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(403, 276)
        DataGridView2.TabIndex = 7
        ' 
        ' Lb_Sesiones_Pendientes
        ' 
        Lb_Sesiones_Pendientes.AutoSize = True
        Lb_Sesiones_Pendientes.BackColor = SystemColors.AppWorkspace
        Lb_Sesiones_Pendientes.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        Lb_Sesiones_Pendientes.ForeColor = Color.White
        Lb_Sesiones_Pendientes.Location = New Point(191, 102)
        Lb_Sesiones_Pendientes.Name = "Lb_Sesiones_Pendientes"
        Lb_Sesiones_Pendientes.Size = New Size(308, 37)
        Lb_Sesiones_Pendientes.TabIndex = 8
        Lb_Sesiones_Pendientes.Text = "SESIONES PENDIENTES"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 10
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Location = New Point(3, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 11
        Label4.Text = "Balance"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Location = New Point(921, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 15)
        Label5.TabIndex = 12
        Label5.Text = "Ingresos"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Location = New Point(921, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 13
        Label6.Text = "Egresos"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 10
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 9, 0)
        TableLayoutPanel1.Controls.Add(Label6, 9, 1)
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns
        TableLayoutPanel1.Location = New Point(64, 27)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1025, 63)
        TableLayoutPanel1.TabIndex = 16
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1147, 437)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Lb_Sesiones_Pendientes)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Lb_Sesiones_Pasadas)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Home"
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Lb_Sesiones_Pendientes As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ManejoDeSesionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
