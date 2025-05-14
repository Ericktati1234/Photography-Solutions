<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Label2 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        Nuevo = New Button()
        Editar = New Button()
        Eliminar = New Button()
        Cancelar = New Button()
        DataGridPack = New DataGridView()
        TableLayoutPanel3 = New TableLayoutPanel()
        IDPackTxBx = New TextBox()
        CategoryTxBx = New TextBox()
        TableLayoutPanel2.SuspendLayout()
        CType(DataGridPack, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 15)
        Label2.TabIndex = 23
        Label2.Text = "ALTAS Y BAJAS DE CLIENTES"
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
        TableLayoutPanel2.Location = New Point(26, 104)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 4
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(100, 396)
        TableLayoutPanel2.TabIndex = 22
        ' 
        ' Nuevo
        ' 
        Nuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nuevo.Location = New Point(3, 2)
        Nuevo.Margin = New Padding(3, 2, 3, 2)
        Nuevo.Name = "Nuevo"
        Nuevo.Size = New Size(94, 95)
        Nuevo.TabIndex = 0
        Nuevo.Text = "Nuevo"
        Nuevo.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Editar.Location = New Point(3, 101)
        Editar.Margin = New Padding(3, 2, 3, 2)
        Editar.Name = "Editar"
        Editar.Size = New Size(94, 95)
        Editar.TabIndex = 2
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        Eliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Eliminar.Location = New Point(3, 200)
        Eliminar.Margin = New Padding(3, 2, 3, 2)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(94, 95)
        Eliminar.TabIndex = 3
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' Cancelar
        ' 
        Cancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cancelar.Location = New Point(3, 299)
        Cancelar.Margin = New Padding(3, 2, 3, 2)
        Cancelar.Name = "Cancelar"
        Cancelar.Size = New Size(94, 95)
        Cancelar.TabIndex = 4
        Cancelar.Text = "Cancelar"
        Cancelar.UseVisualStyleBackColor = True
        ' 
        ' DataGridPack
        ' 
        DataGridPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridPack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPack.Location = New Point(157, 104)
        DataGridPack.Margin = New Padding(3, 2, 3, 2)
        DataGridPack.Name = "DataGridPack"
        DataGridPack.RowHeadersWidth = 51
        DataGridPack.RowTemplate.Height = 29
        DataGridPack.Size = New Size(919, 394)
        DataGridPack.TabIndex = 20
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel3.ColumnCount = 4
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel3.Controls.Add(IDPackTxBx, 0, 1)
        TableLayoutPanel3.Location = New Point(0, 0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 2
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(200, 100)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' IDPackTxBx
        ' 
        IDPackTxBx.Dock = DockStyle.Fill
        IDPackTxBx.Location = New Point(3, 22)
        IDPackTxBx.Margin = New Padding(3, 2, 3, 2)
        IDPackTxBx.Name = "IDPackTxBx"
        IDPackTxBx.Size = New Size(14, 23)
        IDPackTxBx.TabIndex = 5
        ' 
        ' CategoryTxBx
        ' 
        CategoryTxBx.Dock = DockStyle.Fill
        CategoryTxBx.Location = New Point(23, 2)
        CategoryTxBx.Margin = New Padding(3, 2, 3, 2)
        CategoryTxBx.Name = "CategoryTxBx"
        CategoryTxBx.Size = New Size(44, 23)
        CategoryTxBx.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1104, 521)
        Controls.Add(Label2)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(DataGridPack)
        Name = "Form1"
        Text = "Form1"
        TableLayoutPanel2.ResumeLayout(False)
        CType(DataGridPack, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Nuevo As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents DataGridPack As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents IDPackTxBx As TextBox
    Friend WithEvents CategoryTxBx As TextBox
End Class
