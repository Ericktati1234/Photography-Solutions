<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmpleado
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
        Verificar = New Button()
        UsNuevoContraseñaTxBx = New TextBox()
        UsNuevoContraseña = New Label()
        UsNuevoTxBx = New TextBox()
        UsuarioNuevo = New Label()
        AltasyBajas = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Verificar
        ' 
        Verificar.Location = New Point(79, 251)
        Verificar.Name = "Verificar"
        Verificar.Size = New Size(119, 39)
        Verificar.TabIndex = 21
        Verificar.Text = "Verificar"
        Verificar.UseVisualStyleBackColor = True
        ' 
        ' UsNuevoContraseñaTxBx
        ' 
        UsNuevoContraseñaTxBx.Dock = DockStyle.Fill
        UsNuevoContraseñaTxBx.Location = New Point(3, 117)
        UsNuevoContraseñaTxBx.Name = "UsNuevoContraseñaTxBx"
        UsNuevoContraseñaTxBx.Size = New Size(176, 27)
        UsNuevoContraseñaTxBx.TabIndex = 20
        ' 
        ' UsNuevoContraseña
        ' 
        UsNuevoContraseña.AutoSize = True
        UsNuevoContraseña.Dock = DockStyle.Fill
        UsNuevoContraseña.Location = New Point(3, 76)
        UsNuevoContraseña.Name = "UsNuevoContraseña"
        UsNuevoContraseña.Size = New Size(176, 38)
        UsNuevoContraseña.TabIndex = 19
        UsNuevoContraseña.Text = "Contraseña"
        UsNuevoContraseña.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UsNuevoTxBx
        ' 
        UsNuevoTxBx.Dock = DockStyle.Fill
        UsNuevoTxBx.Location = New Point(3, 41)
        UsNuevoTxBx.Name = "UsNuevoTxBx"
        UsNuevoTxBx.Size = New Size(176, 27)
        UsNuevoTxBx.TabIndex = 18
        ' 
        ' UsuarioNuevo
        ' 
        UsuarioNuevo.AutoSize = True
        UsuarioNuevo.Dock = DockStyle.Fill
        UsuarioNuevo.Location = New Point(3, 0)
        UsuarioNuevo.Name = "UsuarioNuevo"
        UsuarioNuevo.Size = New Size(176, 38)
        UsuarioNuevo.TabIndex = 17
        UsuarioNuevo.Text = "Usuario Nuevo:"
        UsuarioNuevo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AltasyBajas
        ' 
        AltasyBajas.AutoSize = True
        AltasyBajas.Location = New Point(57, 35)
        AltasyBajas.Name = "AltasyBajas"
        AltasyBajas.Size = New Size(182, 20)
        AltasyBajas.TabIndex = 15
        AltasyBajas.Text = "USUARIO Y CONTRASEÑA"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(UsuarioNuevo, 0, 0)
        TableLayoutPanel1.Controls.Add(UsNuevoTxBx, 0, 1)
        TableLayoutPanel1.Controls.Add(UsNuevoContraseñaTxBx, 0, 3)
        TableLayoutPanel1.Controls.Add(UsNuevoContraseña, 0, 2)
        TableLayoutPanel1.Location = New Point(49, 79)
        TableLayoutPanel1.Margin = New Padding(3, 4, 3, 4)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 4
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.9999962F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.9999962F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 27F))
        TableLayoutPanel1.Size = New Size(182, 153)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' FormEmpleado
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(281, 308)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(AltasyBajas)
        Controls.Add(Verificar)
        Margin = New Padding(3, 4, 3, 4)
        MaximumSize = New Size(299, 355)
        MinimumSize = New Size(299, 354)
        Name = "FormEmpleado"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Verificar As Button
    Friend WithEvents UsNuevoContraseñaTxBx As TextBox
    Friend WithEvents UsNuevoContraseña As Label
    Friend WithEvents UsNuevoTxBx As TextBox
    Friend WithEvents UsuarioNuevo As Label
    Friend WithEvents AltasyBajas As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
