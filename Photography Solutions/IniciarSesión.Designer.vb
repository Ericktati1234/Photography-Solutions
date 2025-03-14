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
        Correo = New TextBox()
        Contraseña = New TextBox()
        LCorreo = New Label()
        LContraseña = New Label()
        Ingresar = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Correo
        ' 
        Correo.Location = New Point(167, 100)
        Correo.Margin = New Padding(3, 4, 3, 4)
        Correo.Name = "Correo"
        Correo.Size = New Size(190, 27)
        Correo.TabIndex = 0
        ' 
        ' Contraseña
        ' 
        Contraseña.Location = New Point(167, 159)
        Contraseña.Margin = New Padding(3, 4, 3, 4)
        Contraseña.Name = "Contraseña"
        Contraseña.Size = New Size(190, 27)
        Contraseña.TabIndex = 1
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Location = New Point(79, 111)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(54, 20)
        LCorreo.TabIndex = 2
        LCorreo.Text = "Correo"
        ' 
        ' LContraseña
        ' 
        LContraseña.AutoSize = True
        LContraseña.Location = New Point(79, 163)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New Size(83, 20)
        LContraseña.TabIndex = 3
        LContraseña.Text = "Contraseña"
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
        Controls.Add(LContraseña)
        Controls.Add(LCorreo)
        Controls.Add(Contraseña)
        Controls.Add(Correo)
        Name = "IniciarSesión"
        Text = "Photografy Solutions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Correo As TextBox
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents LCorreo As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents Ingresar As Button
    Friend WithEvents Label1 As Label
End Class
