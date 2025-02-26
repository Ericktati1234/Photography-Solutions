<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoUsuario
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
        AltasyBajas = New Label()
        Logo = New PictureBox()
        UsuarioNuevo = New Label()
        UsNuevoTxBx = New TextBox()
        UsNuevoContraseña = New Label()
        UsNuevoContraseñaTxBx = New TextBox()
        DatosPersonales = New Label()
        Nombre = New Label()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AltasyBajas
        ' 
        AltasyBajas.AutoSize = True
        AltasyBajas.Location = New Point(12, 23)
        AltasyBajas.Name = "AltasyBajas"
        AltasyBajas.Size = New Size(204, 20)
        AltasyBajas.TabIndex = 0
        AltasyBajas.Text = "ALTA Y BAJA DE EMPLEADOS"
        ' 
        ' Logo
        ' 
        Logo.Location = New Point(12, 46)
        Logo.Name = "Logo"
        Logo.Size = New Size(152, 120)
        Logo.TabIndex = 1
        Logo.TabStop = False
        ' 
        ' UsuarioNuevo
        ' 
        UsuarioNuevo.AutoSize = True
        UsuarioNuevo.Location = New Point(170, 55)
        UsuarioNuevo.Name = "UsuarioNuevo"
        UsuarioNuevo.Size = New Size(109, 20)
        UsuarioNuevo.TabIndex = 2
        UsuarioNuevo.Text = "Usuario Nuevo:"
        ' 
        ' UsNuevoTxBx
        ' 
        UsNuevoTxBx.Location = New Point(170, 78)
        UsNuevoTxBx.Name = "UsNuevoTxBx"
        UsNuevoTxBx.Size = New Size(125, 27)
        UsNuevoTxBx.TabIndex = 3
        ' 
        ' UsNuevoContraseña
        ' 
        UsNuevoContraseña.AutoSize = True
        UsNuevoContraseña.Location = New Point(170, 108)
        UsNuevoContraseña.Name = "UsNuevoContraseña"
        UsNuevoContraseña.Size = New Size(83, 20)
        UsNuevoContraseña.TabIndex = 4
        UsNuevoContraseña.Text = "Contraseña"
        ' 
        ' UsNuevoContraseñaTxBx
        ' 
        UsNuevoContraseñaTxBx.Location = New Point(170, 131)
        UsNuevoContraseñaTxBx.Name = "UsNuevoContraseñaTxBx"
        UsNuevoContraseñaTxBx.Size = New Size(125, 27)
        UsNuevoContraseñaTxBx.TabIndex = 5
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.Location = New Point(611, 31)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(121, 20)
        DatosPersonales.TabIndex = 6
        DatosPersonales.Text = "Datos Personales"
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Location = New Point(494, 94)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(64, 20)
        Nombre.TabIndex = 7
        Nombre.Text = "Nombre"
        ' 
        ' NuevoUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1470, 642)
        Controls.Add(Nombre)
        Controls.Add(DatosPersonales)
        Controls.Add(UsNuevoContraseñaTxBx)
        Controls.Add(UsNuevoContraseña)
        Controls.Add(UsNuevoTxBx)
        Controls.Add(UsuarioNuevo)
        Controls.Add(Logo)
        Controls.Add(AltasyBajas)
        Name = "NuevoUsuario"
        Text = "NuevoUsuario"
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AltasyBajas As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents UsuarioNuevo As Label
    Friend WithEvents UsNuevoTxBx As TextBox
    Friend WithEvents UsNuevoContraseña As Label
    Friend WithEvents UsNuevoContraseñaTxBx As TextBox
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents Nombre As Label
End Class
