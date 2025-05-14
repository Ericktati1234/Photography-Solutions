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
        DatosPersonales = New Label()
        Nombre = New Label()
        ApellidoPaterno = New Label()
        ApellidoMaterno = New Label()
        NameTxBx = New TextBox()
        Paterno = New TextBox()
        Materno = New TextBox()
        Alta = New Button()
        AdministradorChBx = New CheckBox()
        FotógrafoChBx = New CheckBox()
        ContadorChBx = New CheckBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        CambiarUsuario = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.Location = New Point(162, 114)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(96, 15)
        DatosPersonales.TabIndex = 6
        DatosPersonales.Text = "Datos Personales"
        ' 
        ' Nombre
        ' 
        Nombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nombre.AutoSize = True
        Nombre.Location = New Point(3, 0)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(132, 28)
        Nombre.TabIndex = 7
        Nombre.Text = "Nombre"
        ' 
        ' ApellidoPaterno
        ' 
        ApellidoPaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoPaterno.AutoSize = True
        ApellidoPaterno.Location = New Point(3, 28)
        ApellidoPaterno.Name = "ApellidoPaterno"
        ApellidoPaterno.Size = New Size(132, 28)
        ApellidoPaterno.TabIndex = 8
        ApellidoPaterno.Text = "Apellido Paterno"
        ' 
        ' ApellidoMaterno
        ' 
        ApellidoMaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoMaterno.AutoSize = True
        ApellidoMaterno.Location = New Point(3, 56)
        ApellidoMaterno.Name = "ApellidoMaterno"
        ApellidoMaterno.Size = New Size(132, 28)
        ApellidoMaterno.TabIndex = 9
        ApellidoMaterno.Text = "Apellido Materno"
        ' 
        ' NameTxBx
        ' 
        NameTxBx.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        NameTxBx.Location = New Point(141, 2)
        NameTxBx.Margin = New Padding(3, 2, 3, 2)
        NameTxBx.Name = "NameTxBx"
        NameTxBx.Size = New Size(253, 23)
        NameTxBx.TabIndex = 10
        ' 
        ' Paterno
        ' 
        Paterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Paterno.Location = New Point(141, 30)
        Paterno.Margin = New Padding(3, 2, 3, 2)
        Paterno.Name = "Paterno"
        Paterno.Size = New Size(253, 23)
        Paterno.TabIndex = 11
        ' 
        ' Materno
        ' 
        Materno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Materno.Location = New Point(141, 58)
        Materno.Margin = New Padding(3, 2, 3, 2)
        Materno.Name = "Materno"
        Materno.Size = New Size(253, 23)
        Materno.TabIndex = 12
        ' 
        ' Alta
        ' 
        Alta.Location = New Point(75, 347)
        Alta.Margin = New Padding(3, 2, 3, 2)
        Alta.Name = "Alta"
        Alta.Size = New Size(296, 59)
        Alta.TabIndex = 15
        Alta.Text = "DAR DE ALTA EMPLEADO"
        Alta.UseVisualStyleBackColor = True
        ' 
        ' AdministradorChBx
        ' 
        AdministradorChBx.AutoSize = True
        AdministradorChBx.Location = New Point(24, 309)
        AdministradorChBx.Margin = New Padding(3, 2, 3, 2)
        AdministradorChBx.Name = "AdministradorChBx"
        AdministradorChBx.Size = New Size(102, 19)
        AdministradorChBx.TabIndex = 16
        AdministradorChBx.Text = "Administrador"
        AdministradorChBx.UseVisualStyleBackColor = True
        ' 
        ' FotógrafoChBx
        ' 
        FotógrafoChBx.AutoSize = True
        FotógrafoChBx.Location = New Point(141, 309)
        FotógrafoChBx.Margin = New Padding(3, 2, 3, 2)
        FotógrafoChBx.Name = "FotógrafoChBx"
        FotógrafoChBx.Size = New Size(78, 19)
        FotógrafoChBx.TabIndex = 17
        FotógrafoChBx.Text = "Fotógrafo"
        FotógrafoChBx.UseVisualStyleBackColor = True
        ' 
        ' ContadorChBx
        ' 
        ContadorChBx.AutoSize = True
        ContadorChBx.Location = New Point(229, 309)
        ContadorChBx.Margin = New Padding(3, 2, 3, 2)
        ContadorChBx.Name = "ContadorChBx"
        ContadorChBx.Size = New Size(76, 19)
        ContadorChBx.TabIndex = 18
        ContadorChBx.Text = "Contador"
        ContadorChBx.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.Controls.Add(TextBox1, 1, 3)
        TableLayoutPanel1.Controls.Add(Nombre, 0, 0)
        TableLayoutPanel1.Controls.Add(NameTxBx, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 0, 3)
        TableLayoutPanel1.Controls.Add(ApellidoPaterno, 0, 1)
        TableLayoutPanel1.Controls.Add(Paterno, 1, 1)
        TableLayoutPanel1.Controls.Add(Materno, 1, 2)
        TableLayoutPanel1.Controls.Add(ApellidoMaterno, 0, 2)
        TableLayoutPanel1.Controls.Add(Label2, 0, 4)
        TableLayoutPanel1.Controls.Add(TextBox2, 1, 4)
        TableLayoutPanel1.Location = New Point(21, 143)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(397, 143)
        TableLayoutPanel1.TabIndex = 22
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(141, 86)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(253, 23)
        TextBox1.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(3, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 28)
        Label1.TabIndex = 23
        Label1.Text = "Numero celular"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(3, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 31)
        Label2.TabIndex = 24
        Label2.Text = "Correo electronico"
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Location = New Point(141, 115)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(253, 23)
        TextBox2.TabIndex = 25
        ' 
        ' CambiarUsuario
        ' 
        CambiarUsuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        CambiarUsuario.Location = New Point(228, 2)
        CambiarUsuario.Margin = New Padding(3, 2, 3, 2)
        CambiarUsuario.Name = "CambiarUsuario"
        CambiarUsuario.Size = New Size(145, 40)
        CambiarUsuario.TabIndex = 23
        CambiarUsuario.Text = "Cambiar Usuario"
        CambiarUsuario.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(162, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 24
        Label3.Text = "NUEVO EMPLEADO"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(3, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 44)
        Label4.TabIndex = 25
        Label4.Text = "Usuario:"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(97, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 44)
        Label5.TabIndex = 26
        Label5.Text = "Usuario"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.Controls.Add(Label4, 0, 0)
        TableLayoutPanel2.Controls.Add(Label5, 1, 0)
        TableLayoutPanel2.Controls.Add(CambiarUsuario, 2, 0)
        TableLayoutPanel2.Location = New Point(39, 56)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(376, 44)
        TableLayoutPanel2.TabIndex = 27
        ' 
        ' NuevoUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(445, 417)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label3)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(ContadorChBx)
        Controls.Add(FotógrafoChBx)
        Controls.Add(AdministradorChBx)
        Controls.Add(Alta)
        Controls.Add(DatosPersonales)
        Margin = New Padding(3, 2, 3, 2)
        Name = "NuevoUsuario"
        Text = "EMPLEADOS"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents ApellidoPaterno As Label
    Friend WithEvents ApellidoMaterno As Label
    Friend WithEvents NameTxBx As TextBox
    Friend WithEvents Paterno As TextBox
    Friend WithEvents Materno As TextBox
    Friend WithEvents Alta As Button
    Friend WithEvents AdministradorChBx As CheckBox
    Friend WithEvents FotógrafoChBx As CheckBox
    Friend WithEvents ContadorChBx As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CambiarUsuario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
