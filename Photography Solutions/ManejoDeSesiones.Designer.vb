<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManejoDeSesiones
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
        MSNombre = New Label()
        MSFecha = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MSNombre
        ' 
        MSNombre.AutoSize = True
        MSNombre.Location = New Point(55, 49)
        MSNombre.Name = "MSNombre"
        MSNombre.Size = New Size(137, 20)
        MSNombre.TabIndex = 0
        MSNombre.Text = "Nombre del cliente"
        ' 
        ' MSFecha
        ' 
        MSFecha.AutoSize = True
        MSFecha.Location = New Point(55, 93)
        MSFecha.Name = "MSFecha"
        MSFecha.Size = New Size(123, 20)
        MSFecha.TabIndex = 1
        MSFecha.Text = "Fecha de entrega"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(713, 266)
        DataGridView1.TabIndex = 2
        ' 
        ' ManejoDeSesiones
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(MSFecha)
        Controls.Add(MSNombre)
        Name = "ManejoDeSesiones"
        Text = "ManejoDeSesiones"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MSNombre As Label
    Friend WithEvents MSFecha As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
