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
        Guardar = New Button()
        Editar = New Button()
        Cancelar = New Button()
        Eliminar = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        IDPackTxBx = New TextBox()
        CategoryTxBx = New TextBox()
        Unidades = New Label()
        ClienteTxBx = New TextBox()
        UnidadesTxBx = New TextBox()
        IDPack = New Label()
        Label1 = New Label()
        Cliente = New Label()
        DataGridPack = New DataGridView()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridPack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(Nuevo, 0, 0)
        TableLayoutPanel2.Controls.Add(Guardar, 0, 1)
        TableLayoutPanel2.Controls.Add(Editar, 0, 2)
        TableLayoutPanel2.Controls.Add(Cancelar, 0, 4)
        TableLayoutPanel2.Controls.Add(Eliminar, 0, 3)
        TableLayoutPanel2.Location = New Point(22, 28)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel2.Size = New Size(115, 355)
        TableLayoutPanel2.TabIndex = 18
        ' 
        ' Nuevo
        ' 
        Nuevo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Nuevo.Location = New Point(3, 2)
        Nuevo.Margin = New Padding(3, 2, 3, 2)
        Nuevo.Name = "Nuevo"
        Nuevo.Size = New Size(109, 67)
        Nuevo.TabIndex = 0
        Nuevo.Text = "Nuevo"
        Nuevo.UseVisualStyleBackColor = True
        ' 
        ' Guardar
        ' 
        Guardar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Guardar.Location = New Point(3, 73)
        Guardar.Margin = New Padding(3, 2, 3, 2)
        Guardar.Name = "Guardar"
        Guardar.Size = New Size(109, 67)
        Guardar.TabIndex = 1
        Guardar.Text = "Guardar"
        Guardar.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Editar.Location = New Point(3, 144)
        Editar.Margin = New Padding(3, 2, 3, 2)
        Editar.Name = "Editar"
        Editar.Size = New Size(109, 67)
        Editar.TabIndex = 2
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Cancelar
        ' 
        Cancelar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cancelar.Location = New Point(3, 286)
        Cancelar.Margin = New Padding(3, 2, 3, 2)
        Cancelar.Name = "Cancelar"
        Cancelar.Size = New Size(109, 67)
        Cancelar.TabIndex = 4
        Cancelar.Text = "Cancelar"
        Cancelar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        Eliminar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Eliminar.Location = New Point(3, 215)
        Eliminar.Margin = New Padding(3, 2, 3, 2)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(109, 67)
        Eliminar.TabIndex = 3
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(IDPackTxBx, 0, 1)
        TableLayoutPanel1.Controls.Add(CategoryTxBx, 1, 1)
        TableLayoutPanel1.Controls.Add(Unidades, 3, 0)
        TableLayoutPanel1.Controls.Add(ClienteTxBx, 2, 1)
        TableLayoutPanel1.Controls.Add(UnidadesTxBx, 3, 1)
        TableLayoutPanel1.Controls.Add(IDPack, 0, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 0)
        TableLayoutPanel1.Controls.Add(Cliente, 2, 0)
        TableLayoutPanel1.Location = New Point(180, 18)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(603, 50)
        TableLayoutPanel1.TabIndex = 17
        ' 
        ' IDPackTxBx
        ' 
        IDPackTxBx.Dock = DockStyle.Fill
        IDPackTxBx.Location = New Point(3, 27)
        IDPackTxBx.Margin = New Padding(3, 2, 3, 2)
        IDPackTxBx.Name = "IDPackTxBx"
        IDPackTxBx.Size = New Size(54, 23)
        IDPackTxBx.TabIndex = 5
        ' 
        ' CategoryTxBx
        ' 
        CategoryTxBx.Dock = DockStyle.Fill
        CategoryTxBx.Location = New Point(63, 27)
        CategoryTxBx.Margin = New Padding(3, 2, 3, 2)
        CategoryTxBx.Name = "CategoryTxBx"
        CategoryTxBx.Size = New Size(144, 23)
        CategoryTxBx.TabIndex = 7
        ' 
        ' Unidades
        ' 
        Unidades.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Unidades.AutoSize = True
        Unidades.Location = New Point(484, 0)
        Unidades.Name = "Unidades"
        Unidades.Size = New Size(116, 25)
        Unidades.TabIndex = 12
        Unidades.Text = "Unidades"
        Unidades.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ClienteTxBx
        ' 
        ClienteTxBx.Dock = DockStyle.Fill
        ClienteTxBx.Location = New Point(213, 27)
        ClienteTxBx.Margin = New Padding(3, 2, 3, 2)
        ClienteTxBx.Name = "ClienteTxBx"
        ClienteTxBx.Size = New Size(265, 23)
        ClienteTxBx.TabIndex = 9
        ' 
        ' UnidadesTxBx
        ' 
        UnidadesTxBx.Dock = DockStyle.Fill
        UnidadesTxBx.Location = New Point(484, 27)
        UnidadesTxBx.Margin = New Padding(3, 2, 3, 2)
        UnidadesTxBx.Name = "UnidadesTxBx"
        UnidadesTxBx.Size = New Size(116, 23)
        UnidadesTxBx.TabIndex = 11
        ' 
        ' IDPack
        ' 
        IDPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        IDPack.AutoSize = True
        IDPack.Location = New Point(3, 0)
        IDPack.Name = "IDPack"
        IDPack.Size = New Size(54, 25)
        IDPack.TabIndex = 6
        IDPack.Text = "ID"
        IDPack.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(63, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 8
        Label1.Text = "Categoría"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Cliente
        ' 
        Cliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cliente.AutoSize = True
        Cliente.Location = New Point(213, 0)
        Cliente.Name = "Cliente"
        Cliente.Size = New Size(265, 25)
        Cliente.TabIndex = 10
        Cliente.Text = "Cliente"
        Cliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridPack
        ' 
        DataGridPack.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridPack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPack.Location = New Point(162, 87)
        DataGridPack.Margin = New Padding(3, 2, 3, 2)
        DataGridPack.Name = "DataGridPack"
        DataGridPack.RowHeadersWidth = 51
        DataGridPack.RowTemplate.Height = 29
        DataGridPack.Size = New Size(639, 321)
        DataGridPack.TabIndex = 16
        ' 
        ' FormAltaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 426)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(DataGridPack)
        Name = "FormAltaClientes"
        Text = "AltaClientes"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(DataGridPack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Nuevo As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IDPackTxBx As TextBox
    Friend WithEvents CategoryTxBx As TextBox
    Friend WithEvents Unidades As Label
    Friend WithEvents ClienteTxBx As TextBox
    Friend WithEvents UnidadesTxBx As TextBox
    Friend WithEvents IDPack As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cliente As Label
    Friend WithEvents DataGridPack As DataGridView
End Class
