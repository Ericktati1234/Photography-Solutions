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
        ApellidoPaterno = New Label()
        ApellidoMaterno = New Label()
        Name = New TextBox()
        Paterno = New TextBox()
        Materno = New TextBox()
        Verificar = New Button()
        CambiarUsuario = New Button()
        Alta = New Button()
        AdministradorChBx = New CheckBox()
        FotógrafoChBx = New CheckBox()
        ContadorChBx = New CheckBox()
        DataGridView1 = New DataGridView()
        Modificar = New Button()
        Eliminar = New Button()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' ApellidoPaterno
        ' 
        ApellidoPaterno.AutoSize = True
        ApellidoPaterno.Location = New Point(643, 94)
        ApellidoPaterno.Name = "ApellidoPaterno"
        ApellidoPaterno.Size = New Size(120, 20)
        ApellidoPaterno.TabIndex = 8
        ApellidoPaterno.Text = "Apellido Paterno"
        ' 
        ' ApellidoMaterno
        ' 
        ApellidoMaterno.AutoSize = True
        ApellidoMaterno.Location = New Point(808, 94)
        ApellidoMaterno.Name = "ApellidoMaterno"
        ApellidoMaterno.Size = New Size(126, 20)
        ApellidoMaterno.TabIndex = 9
        ApellidoMaterno.Text = "Apellido Materno"
        ' 
        ' Name
        ' 
        Name.Location = New Point(487, 130)
        Name.Name = "Name"
        Name.Size = New Size(125, 27)
        Name.TabIndex = 10
        ' 
        ' Paterno
        ' 
        Paterno.Location = New Point(643, 130)
        Paterno.Name = "Paterno"
        Paterno.Size = New Size(125, 27)
        Paterno.TabIndex = 11
        ' 
        ' Materno
        ' 
        Materno.Location = New Point(809, 130)
        Materno.Name = "Materno"
        Materno.Size = New Size(125, 27)
        Materno.TabIndex = 12
        ' 
        ' Verificar
        ' 
        Verificar.Location = New Point(170, 186)
        Verificar.Name = "Verificar"
        Verificar.Size = New Size(119, 45)
        Verificar.TabIndex = 13
        Verificar.Text = "Verificar"
        Verificar.UseVisualStyleBackColor = True
        ' 
        ' CambiarUsuario
        ' 
        CambiarUsuario.Location = New Point(160, 249)
        CambiarUsuario.Name = "CambiarUsuario"
        CambiarUsuario.Size = New Size(119, 79)
        CambiarUsuario.TabIndex = 14
        CambiarUsuario.Text = "Cambiar Usuario"
        CambiarUsuario.UseVisualStyleBackColor = True
        ' 
        ' Alta
        ' 
        Alta.Location = New Point(27, 345)
        Alta.Name = "Alta"
        Alta.Size = New Size(338, 79)
        Alta.TabIndex = 15
        Alta.Text = "DAR DE ALTA EMPLEADO"
        Alta.UseVisualStyleBackColor = True
        ' 
        ' AdministradorChBx
        ' 
        AdministradorChBx.AutoSize = True
        AdministradorChBx.Location = New Point(444, 218)
        AdministradorChBx.Name = "AdministradorChBx"
        AdministradorChBx.Size = New Size(126, 24)
        AdministradorChBx.TabIndex = 16
        AdministradorChBx.Text = "Administrador"
        AdministradorChBx.UseVisualStyleBackColor = True
        ' 
        ' FotógrafoChBx
        ' 
        FotógrafoChBx.AutoSize = True
        FotógrafoChBx.Location = New Point(432, 264)
        FotógrafoChBx.Name = "FotógrafoChBx"
        FotógrafoChBx.Size = New Size(97, 24)
        FotógrafoChBx.TabIndex = 17
        FotógrafoChBx.Text = "Fotógrafo"
        FotógrafoChBx.UseVisualStyleBackColor = True
        ' 
        ' ContadorChBx
        ' 
        ContadorChBx.AutoSize = True
        ContadorChBx.Location = New Point(461, 304)
        ContadorChBx.Name = "ContadorChBx"
        ContadorChBx.Size = New Size(93, 24)
        ContadorChBx.TabIndex = 18
        ContadorChBx.Text = "Contador"
        ContadorChBx.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(432, 354)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(300, 188)
        DataGridView1.TabIndex = 19
        ' 
        ' Modificar
        ' 
        Modificar.Location = New Point(354, 594)
        Modificar.Name = "Modificar"
        Modificar.Size = New Size(94, 29)
        Modificar.TabIndex = 20
        Modificar.Text = "Modificar"
        Modificar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        Eliminar.Location = New Point(573, 557)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(94, 73)
        Eliminar.TabIndex = 21
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' NuevoUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(975, 642)
        Controls.Add(Eliminar)
        Controls.Add(Modificar)
        Controls.Add(DataGridView1)
        Controls.Add(ContadorChBx)
        Controls.Add(FotógrafoChBx)
        Controls.Add(AdministradorChBx)
        Controls.Add(Alta)
        Controls.Add(CambiarUsuario)
        Controls.Add(Verificar)
        Controls.Add(Materno)
        Controls.Add(Paterno)
        Controls.Add(Name)
        Controls.Add(ApellidoMaterno)
        Controls.Add(ApellidoPaterno)
        Controls.Add(Nombre)
        Controls.Add(DatosPersonales)
        Controls.Add(UsNuevoContraseñaTxBx)
        Controls.Add(UsNuevoContraseña)
        Controls.Add(UsNuevoTxBx)
        Controls.Add(UsuarioNuevo)
        Controls.Add(Logo)
        Controls.Add(AltasyBajas)
        Name = "NuevoUsuario"
        Text = "Alta y Baja de Empleados"
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ApellidoPaterno As Label
    Friend WithEvents ApellidoMaterno As Label
    Friend WithEvents Name As TextBox
    Friend WithEvents Paterno As TextBox
    Friend WithEvents Materno As TextBox
    Friend WithEvents Verificar As Button
    Friend WithEvents CambiarUsuario As Button
    Friend WithEvents Alta As Button
    Friend WithEvents AdministradorChBx As CheckBox
    Friend WithEvents FotógrafoChBx As CheckBox
    Friend WithEvents ContadorChBx As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Modificar As Button
    Friend WithEvents Eliminar As Button
End Class
