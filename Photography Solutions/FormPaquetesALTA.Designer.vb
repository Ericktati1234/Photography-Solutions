<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaquetesALTA
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
        Label3 = New Label()
        btnConfirmar = New Button()
        btnReiniciar = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Nombre = New Label()
        numPrecio = New NumericUpDown()
        ApellidoMaterno = New Label()
        ApellidoPaterno = New Label()
        txtNombre = New TextBox()
        txtDescripcion = New RichTextBox()
        DatosPersonales = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(numPrecio, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(30, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 30)
        Label3.TabIndex = 38
        Label3.Text = "ALTA DE PAQUETES"
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.Location = New Point(256, 282)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(136, 37)
        btnConfirmar.TabIndex = 35
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = True
        ' 
        ' btnReiniciar
        ' 
        btnReiniciar.BackColor = Color.Gainsboro
        btnReiniciar.Location = New Point(78, 282)
        btnReiniciar.Name = "btnReiniciar"
        btnReiniciar.Size = New Size(136, 37)
        btnReiniciar.TabIndex = 34
        btnReiniciar.Text = "Reiniciar"
        btnReiniciar.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 35F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65F))
        TableLayoutPanel1.Controls.Add(Nombre, 0, 0)
        TableLayoutPanel1.Controls.Add(numPrecio, 1, 2)
        TableLayoutPanel1.Controls.Add(ApellidoMaterno, 0, 2)
        TableLayoutPanel1.Controls.Add(ApellidoPaterno, 0, 1)
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 0)
        TableLayoutPanel1.Controls.Add(txtDescripcion, 1, 1)
        TableLayoutPanel1.Location = New Point(30, 119)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Size = New Size(397, 129)
        TableLayoutPanel1.TabIndex = 32
        ' 
        ' Nombre
        ' 
        Nombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nombre.AutoSize = True
        Nombre.BackColor = Color.Gainsboro
        Nombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Nombre.Location = New Point(3, 0)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(132, 32)
        Nombre.TabIndex = 7
        Nombre.Text = "Nombre"
        Nombre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' numPrecio
        ' 
        numPrecio.Location = New Point(141, 99)
        numPrecio.Name = "numPrecio"
        numPrecio.Size = New Size(253, 23)
        numPrecio.TabIndex = 26
        ' 
        ' ApellidoMaterno
        ' 
        ApellidoMaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoMaterno.AutoSize = True
        ApellidoMaterno.BackColor = Color.Gainsboro
        ApellidoMaterno.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ApellidoMaterno.Location = New Point(3, 96)
        ApellidoMaterno.Name = "ApellidoMaterno"
        ApellidoMaterno.Size = New Size(132, 33)
        ApellidoMaterno.TabIndex = 9
        ApellidoMaterno.Text = "Precio"
        ApellidoMaterno.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ApellidoPaterno
        ' 
        ApellidoPaterno.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApellidoPaterno.AutoSize = True
        ApellidoPaterno.BackColor = Color.White
        ApellidoPaterno.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ApellidoPaterno.Location = New Point(3, 32)
        ApellidoPaterno.Name = "ApellidoPaterno"
        ApellidoPaterno.Size = New Size(132, 64)
        ApellidoPaterno.TabIndex = 8
        ApellidoPaterno.Text = "Descripcion"
        ApellidoPaterno.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNombre
        ' 
        txtNombre.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtNombre.Location = New Point(141, 2)
        txtNombre.Margin = New Padding(3, 2, 3, 2)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(253, 23)
        txtNombre.TabIndex = 12
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Dock = DockStyle.Fill
        txtDescripcion.Location = New Point(141, 35)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(253, 58)
        txtDescripcion.TabIndex = 27
        txtDescripcion.Text = ""
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(159, 78)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(166, 25)
        DatosPersonales.TabIndex = 31
        DatosPersonales.Text = "Datos Del Paquete"
        ' 
        ' FormPaquetesALTA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(468, 344)
        Controls.Add(Label3)
        Controls.Add(btnConfirmar)
        Controls.Add(btnReiniciar)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(DatosPersonales)
        Name = "FormPaquetesALTA"
        Text = "FormPaquetesALTA"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(numPrecio, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Nombre As Label
    Friend WithEvents numPrecio As NumericUpDown
    Friend WithEvents ApellidoMaterno As Label
    Friend WithEvents ApellidoPaterno As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents DatosPersonales As Label
    Friend WithEvents txtDescripcion As RichTextBox
End Class
