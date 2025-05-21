<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIniciarSesión
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
        lblTituloUsuario = New Label()
        lblTituloContrasena = New Label()
        BtnIngresar = New Button()
        lblTitulo = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(241, 60)
        TxtUsuario.Margin = New Padding(3, 4, 3, 4)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(190, 27)
        TxtUsuario.TabIndex = 0
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(241, 101)
        TxtContrasena.Margin = New Padding(3, 4, 3, 4)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.Size = New Size(190, 27)
        TxtContrasena.TabIndex = 1
        ' 
        ' lblTituloUsuario
        ' 
        lblTituloUsuario.AutoSize = True
        lblTituloUsuario.Location = New Point(152, 63)
        lblTituloUsuario.Name = "lblTituloUsuario"
        lblTituloUsuario.Size = New Size(59, 20)
        lblTituloUsuario.TabIndex = 2
        lblTituloUsuario.Text = "Usuario"
        lblTituloUsuario.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTituloContrasena
        ' 
        lblTituloContrasena.AutoSize = True
        lblTituloContrasena.Location = New Point(152, 101)
        lblTituloContrasena.Name = "lblTituloContrasena"
        lblTituloContrasena.Size = New Size(83, 20)
        lblTituloContrasena.TabIndex = 3
        lblTituloContrasena.Text = "Contraseña"
        lblTituloContrasena.TextAlign = ContentAlignment.TopCenter
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.Location = New Point(194, 145)
        BtnIngresar.Margin = New Padding(3, 4, 3, 4)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(176, 50)
        BtnIngresar.TabIndex = 4
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(152, 25)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(298, 20)
        lblTitulo.TabIndex = 5
        lblTitulo.Text = "BIENVENIDO A PHOTOGRAPHY SOLUTIONS"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(29, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(96, 96)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' IniciarSesión
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 219)
        Controls.Add(BtnIngresar)
        Controls.Add(PictureBox1)
        Controls.Add(TxtContrasena)
        Controls.Add(TxtUsuario)
        Controls.Add(lblTituloUsuario)
        Controls.Add(lblTituloContrasena)
        Controls.Add(lblTitulo)
        Name = "IniciarSesión"
        Text = "Photografy Solutions"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents lblTituloUsuario As Label
    Friend WithEvents lblTituloContrasena As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
