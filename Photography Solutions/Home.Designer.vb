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
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(332, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 1
        Label1.Text = "Texto default"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {AltaUsuariosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1311, 28)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AltaUsuariosToolStripMenuItem
        ' 
        AltaUsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaDeUsuariosToolStripMenuItem, AltaDePaquetesToolStripMenuItem})
        AltaUsuariosToolStripMenuItem.Name = "AltaUsuariosToolStripMenuItem"
        AltaUsuariosToolStripMenuItem.Size = New Size(82, 24)
        AltaUsuariosToolStripMenuItem.Text = "Ventanas"
        ' 
        ' AltaDeUsuariosToolStripMenuItem
        ' 
        AltaDeUsuariosToolStripMenuItem.Name = "AltaDeUsuariosToolStripMenuItem"
        AltaDeUsuariosToolStripMenuItem.Size = New Size(224, 26)
        AltaDeUsuariosToolStripMenuItem.Text = "Alta de Usuarios"
        ' 
        ' AltaDePaquetesToolStripMenuItem
        ' 
        AltaDePaquetesToolStripMenuItem.Name = "AltaDePaquetesToolStripMenuItem"
        AltaDePaquetesToolStripMenuItem.Size = New Size(224, 26)
        AltaDePaquetesToolStripMenuItem.Text = "Alta de Paquetes"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1311, 583)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Home"
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltaUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaDePaquetesToolStripMenuItem As ToolStripMenuItem
End Class
