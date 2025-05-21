<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaClientes
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
        TableLayoutPanel2 = New TableLayoutPanel()
        Nuevo = New Button()
        Editar = New Button()
        Eliminar = New Button()
        Cancelar = New Button()
        dgvClientes = New DataGridView()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Nuevo, 0, 0)
        TableLayoutPanel2.Controls.Add(Editar, 0, 1)
        TableLayoutPanel2.Controls.Add(Eliminar, 0, 2)
        TableLayoutPanel2.Controls.Add(Cancelar, 0, 3)
        TableLayoutPanel2.Location = New Point(22, 62)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(115, 379)
        TableLayoutPanel2.TabIndex = 18
        ' 
        ' Nuevo
        ' 
        Nuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nuevo.Location = New Point(3, 2)
        Nuevo.Margin = New Padding(3, 2, 3, 2)
        Nuevo.Name = "Nuevo"
        Nuevo.Size = New Size(109, 90)
        Nuevo.TabIndex = 0
        Nuevo.Text = "Nuevo"
        Nuevo.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Editar.Location = New Point(3, 96)
        Editar.Margin = New Padding(3, 2, 3, 2)
        Editar.Name = "Editar"
        Editar.Size = New Size(109, 90)
        Editar.TabIndex = 2
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        Eliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Eliminar.Location = New Point(3, 190)
        Eliminar.Margin = New Padding(3, 2, 3, 2)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(109, 90)
        Eliminar.TabIndex = 3
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' Cancelar
        ' 
        Cancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cancelar.Location = New Point(3, 284)
        Cancelar.Margin = New Padding(3, 2, 3, 2)
        Cancelar.Name = "Cancelar"
        Cancelar.Size = New Size(109, 93)
        Cancelar.TabIndex = 4
        Cancelar.Text = "Cancelar"
        Cancelar.UseVisualStyleBackColor = True
        ' 
        ' dgvClientes
        ' 
        dgvClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(162, 62)
        dgvClientes.Margin = New Padding(3, 2, 3, 2)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.RowHeadersWidth = 51
        dgvClientes.RowTemplate.Height = 29
        dgvClientes.Size = New Size(817, 404)
        dgvClientes.TabIndex = 16
        ' 
        ' FormAltaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1001, 484)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvClientes)
        Name = "FormAltaClientes"
        Text = "AltaClientes"
        TableLayoutPanel2.ResumeLayout(False)
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Nuevo As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents dgvClientes As DataGridView
End Class
