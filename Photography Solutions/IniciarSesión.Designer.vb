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
        SuspendLayout()
        ' 
        ' Correo
        ' 
        Correo.Location = New Point(146, 75)
        Correo.Name = "Correo"
        Correo.Size = New Size(167, 23)
        Correo.TabIndex = 0
        ' 
        ' Contraseña
        ' 
        Contraseña.Location = New Point(146, 119)
        Contraseña.Name = "Contraseña"
        Contraseña.Size = New Size(167, 23)
        Contraseña.TabIndex = 1
        ' 
        ' LCorreo
        ' 
        LCorreo.AutoSize = True
        LCorreo.Location = New Point(69, 83)
        LCorreo.Name = "LCorreo"
        LCorreo.Size = New Size(43, 15)
        LCorreo.TabIndex = 2
        LCorreo.Text = "Correo"
        ' 
        ' LContraseña
        ' 
        LContraseña.AutoSize = True
        LContraseña.Location = New Point(69, 122)
        LContraseña.Name = "LContraseña"
        LContraseña.Size = New Size(67, 15)
        LContraseña.TabIndex = 3
        LContraseña.Text = "Contraseña"
        ' 
        ' Ingresar
        ' 
        Ingresar.Location = New Point(191, 181)
        Ingresar.Name = "Ingresar"
        Ingresar.Size = New Size(75, 23)
        Ingresar.TabIndex = 4
        Ingresar.Text = "Ingresar"
        Ingresar.UseVisualStyleBackColor = True
        ' 
        ' IniciarSesión
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 281)
        Controls.Add(Ingresar)
        Controls.Add(LContraseña)
        Controls.Add(LCorreo)
        Controls.Add(Contraseña)
        Controls.Add(Correo)
        Margin = New Padding(3, 2, 3, 2)
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
End Class
