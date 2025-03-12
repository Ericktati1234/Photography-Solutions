<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureAlmacen = New PictureBox()
        PictureAltaBaja = New PictureBox()
        PictureVentas = New PictureBox()
        PictureSesiones = New PictureBox()
        Label1 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureAlmacen, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureAltaBaja, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureVentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureSesiones, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureAlmacen)
        FlowLayoutPanel1.Controls.Add(PictureAltaBaja)
        FlowLayoutPanel1.Controls.Add(PictureVentas)
        FlowLayoutPanel1.Controls.Add(PictureSesiones)
        FlowLayoutPanel1.Location = New Point(52, 71)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(650, 302)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' PictureAlmacen
        ' 
        PictureAlmacen.Location = New Point(3, 3)
        PictureAlmacen.Name = "PictureAlmacen"
        PictureAlmacen.Size = New Size(158, 93)
        PictureAlmacen.TabIndex = 0
        PictureAlmacen.TabStop = False
        ' 
        ' PictureAltaBaja
        ' 
        PictureAltaBaja.Location = New Point(167, 3)
        PictureAltaBaja.Name = "PictureAltaBaja"
        PictureAltaBaja.Size = New Size(158, 93)
        PictureAltaBaja.TabIndex = 1
        PictureAltaBaja.TabStop = False
        ' 
        ' PictureVentas
        ' 
        PictureVentas.Location = New Point(331, 3)
        PictureVentas.Name = "PictureVentas"
        PictureVentas.Size = New Size(158, 93)
        PictureVentas.TabIndex = 2
        PictureVentas.TabStop = False
        ' 
        ' PictureSesiones
        ' 
        PictureSesiones.Location = New Point(3, 102)
        PictureSesiones.Name = "PictureSesiones"
        PictureSesiones.Size = New Size(158, 93)
        PictureSesiones.TabIndex = 3
        PictureSesiones.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(255, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 1
        Label1.Text = "Texto default"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Name = "Home"
        Text = "Home"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureAlmacen, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureAltaBaja, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureVentas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureSesiones, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureAlmacen As PictureBox
    Friend WithEvents PictureAltaBaja As PictureBox
    Friend WithEvents PictureVentas As PictureBox
    Friend WithEvents PictureSesiones As PictureBox
    Friend WithEvents Label1 As Label
End Class
