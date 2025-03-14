<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IniciarSesión
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtUsuario = New TextBox()
        TxtContrasena = New TextBox()
        LblUsuario = New Label()
        LblContraseña = New Label()
        Ingresar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(167, 100)
        TxtUsuario.Margin = New Padding(3, 4, 3, 4)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(190, 27)
        TxtUsuario.TabIndex = 0
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(167, 159)
        TxtContrasena.Margin = New Padding(3, 4, 3, 4)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.Size = New Size(190, 27)
        TxtContrasena.TabIndex = 1
        ' 
        ' LblUsuario
        ' 
        LblUsuario.AutoSize = True
        LblUsuario.Location = New Point(79, 111)
        LblUsuario.Name = "LblUsuario"
        LblUsuario.Size = New Size(59, 20)
        LblUsuario.TabIndex = 2
        LblUsuario.Text = "Usuario"
        ' 
        ' LblContraseña
        ' 
        LblContraseña.AutoSize = True
        LblContraseña.Location = New Point(79, 163)
        LblContraseña.Name = "LblContraseña"
        LblContraseña.Size = New Size(83, 20)
        LblContraseña.TabIndex = 3
        LblContraseña.Text = "Contraseña"
        ' 
        ' Ingresar
        ' 
        Ingresar.Location = New Point(218, 241)
        Ingresar.Margin = New Padding(3, 4, 3, 4)
        Ingresar.Name = "Ingresar"
        Ingresar.Size = New Size(86, 31)
        Ingresar.TabIndex = 4
        Ingresar.Text = "Ingresar"
        Ingresar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 20)
        Label1.TabIndex = 5
        Label1.Text = "BIENVENIDO A PHOTOGRAPHY SOLUTIONS"
        ' 
        ' IniciarSesión
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 375)
        Controls.Add(Label1)
        Controls.Add(Ingresar)
        Controls.Add(LblContraseña)
        Controls.Add(LblUsuario)
        Controls.Add(TxtContrasena)
        Controls.Add(TxtUsuario)
        Name = "IniciarSesión"
        Text = "Photografy Solutions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents Ingresar As Button
    Friend WithEvents Label1 As Label
End Class
