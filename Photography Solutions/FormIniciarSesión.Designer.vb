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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormIniciarSesión))
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
        TxtUsuario.Location = New Point(269, 50)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(167, 23)
        TxtUsuario.TabIndex = 0
        ' 
        ' TxtContrasena
        ' 
        TxtContrasena.Location = New Point(269, 81)
        TxtContrasena.Name = "TxtContrasena"
        TxtContrasena.Size = New Size(167, 23)
        TxtContrasena.TabIndex = 1
        ' 
        ' lblTituloUsuario
        ' 
        lblTituloUsuario.AutoSize = True
        lblTituloUsuario.BackColor = Color.White
        lblTituloUsuario.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTituloUsuario.Location = New Point(172, 52)
        lblTituloUsuario.Name = "lblTituloUsuario"
        lblTituloUsuario.Size = New Size(59, 20)
        lblTituloUsuario.TabIndex = 2
        lblTituloUsuario.Text = "Usuario"
        lblTituloUsuario.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTituloContrasena
        ' 
        lblTituloContrasena.AutoSize = True
        lblTituloContrasena.BackColor = Color.White
        lblTituloContrasena.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTituloContrasena.Location = New Point(172, 81)
        lblTituloContrasena.Name = "lblTituloContrasena"
        lblTituloContrasena.Size = New Size(83, 20)
        lblTituloContrasena.TabIndex = 3
        lblTituloContrasena.Text = "Contraseña"
        lblTituloContrasena.TextAlign = ContentAlignment.TopCenter
        ' 
        ' BtnIngresar
        ' 
        BtnIngresar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnIngresar.Location = New Point(228, 114)
        BtnIngresar.Name = "BtnIngresar"
        BtnIngresar.Size = New Size(154, 38)
        BtnIngresar.TabIndex = 4
        BtnIngresar.Text = "Ingresar"
        BtnIngresar.UseVisualStyleBackColor = True
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        lblTitulo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitulo.Location = New Point(48, 12)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(377, 25)
        lblTitulo.TabIndex = 5
        lblTitulo.Text = "BIENVENIDO A PHOTOGRAPHY SOLUTIONS"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(36, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' FormIniciarSesión
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(463, 164)
        Controls.Add(PictureBox1)
        Controls.Add(BtnIngresar)
        Controls.Add(TxtContrasena)
        Controls.Add(TxtUsuario)
        Controls.Add(lblTituloUsuario)
        Controls.Add(lblTituloContrasena)
        Controls.Add(lblTitulo)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(479, 203)
        MinimumSize = New Size(479, 203)
        Name = "FormIniciarSesión"
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
