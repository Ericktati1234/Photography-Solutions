<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Nuevo = New Button()
        Guardar = New Button()
        Editar = New Button()
        Eliminar = New Button()
        Cancelar = New Button()
        IDPackTxBx = New TextBox()
        IDPack = New Label()
        CategoryTxBx = New TextBox()
        Label1 = New Label()
        ClienteTxBx = New TextBox()
        Cliente = New Label()
        UnidadesTxBx = New TextBox()
        Unidades = New Label()
        DataGridPack = New DataGridView()
        CType(DataGridPack, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Nuevo
        ' 
        Nuevo.Location = New Point(27, 34)
        Nuevo.Name = "Nuevo"
        Nuevo.Size = New Size(94, 29)
        Nuevo.TabIndex = 0
        Nuevo.Text = "Nuevo"
        Nuevo.UseVisualStyleBackColor = True
        ' 
        ' Guardar
        ' 
        Guardar.Location = New Point(27, 78)
        Guardar.Name = "Guardar"
        Guardar.Size = New Size(94, 29)
        Guardar.TabIndex = 1
        Guardar.Text = "Guardar"
        Guardar.UseVisualStyleBackColor = True
        ' 
        ' Editar
        ' 
        Editar.Location = New Point(27, 125)
        Editar.Name = "Editar"
        Editar.Size = New Size(94, 29)
        Editar.TabIndex = 2
        Editar.Text = "Editar"
        Editar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        Eliminar.Location = New Point(12, 182)
        Eliminar.Name = "Eliminar"
        Eliminar.Size = New Size(94, 29)
        Eliminar.TabIndex = 3
        Eliminar.Text = "Eliminar"
        Eliminar.UseVisualStyleBackColor = True
        ' 
        ' Cancelar
        ' 
        Cancelar.Location = New Point(12, 230)
        Cancelar.Name = "Cancelar"
        Cancelar.Size = New Size(94, 29)
        Cancelar.TabIndex = 4
        Cancelar.Text = "Cancelar"
        Cancelar.UseVisualStyleBackColor = True
        ' 
        ' IDPackTxBx
        ' 
        IDPackTxBx.Location = New Point(183, 59)
        IDPackTxBx.Name = "IDPackTxBx"
        IDPackTxBx.Size = New Size(125, 27)
        IDPackTxBx.TabIndex = 5
        ' 
        ' IDPack
        ' 
        IDPack.AutoSize = True
        IDPack.Location = New Point(205, 36)
        IDPack.Name = "IDPack"
        IDPack.Size = New Size(81, 20)
        IDPack.TabIndex = 6
        IDPack.Text = "Id paquete"
        ' 
        ' CategoryTxBx
        ' 
        CategoryTxBx.Location = New Point(332, 59)
        CategoryTxBx.Name = "CategoryTxBx"
        CategoryTxBx.Size = New Size(125, 27)
        CategoryTxBx.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(332, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 20)
        Label1.TabIndex = 8
        Label1.Text = "Categoría"
        ' 
        ' ClienteTxBx
        ' 
        ClienteTxBx.Location = New Point(494, 59)
        ClienteTxBx.Name = "ClienteTxBx"
        ClienteTxBx.Size = New Size(125, 27)
        ClienteTxBx.TabIndex = 9
        ' 
        ' Cliente
        ' 
        Cliente.AutoSize = True
        Cliente.Location = New Point(511, 34)
        Cliente.Name = "Cliente"
        Cliente.Size = New Size(55, 20)
        Cliente.TabIndex = 10
        Cliente.Text = "Cliente"
        ' 
        ' UnidadesTxBx
        ' 
        UnidadesTxBx.Location = New Point(648, 59)
        UnidadesTxBx.Name = "UnidadesTxBx"
        UnidadesTxBx.Size = New Size(125, 27)
        UnidadesTxBx.TabIndex = 11
        ' 
        ' Unidades
        ' 
        Unidades.AutoSize = True
        Unidades.Location = New Point(681, 36)
        Unidades.Name = "Unidades"
        Unidades.Size = New Size(71, 20)
        Unidades.TabIndex = 12
        Unidades.Text = "Unidades"
        ' 
        ' DataGridPack
        ' 
        DataGridPack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPack.Location = New Point(319, 157)
        DataGridPack.Name = "DataGridPack"
        DataGridPack.RowHeadersWidth = 51
        DataGridPack.RowTemplate.Height = 29
        DataGridPack.Size = New Size(300, 188)
        DataGridPack.TabIndex = 13
        ' 
        ' Almacen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 450)
        Controls.Add(DataGridPack)
        Controls.Add(Unidades)
        Controls.Add(UnidadesTxBx)
        Controls.Add(Cliente)
        Controls.Add(ClienteTxBx)
        Controls.Add(Label1)
        Controls.Add(CategoryTxBx)
        Controls.Add(IDPack)
        Controls.Add(IDPackTxBx)
        Controls.Add(Cancelar)
        Controls.Add(Eliminar)
        Controls.Add(Editar)
        Controls.Add(Guardar)
        Controls.Add(Nuevo)
        Name = "Almacen"
        Text = "Almacen"
        CType(DataGridPack, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Nuevo As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents Editar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents IDPackTxBx As TextBox
    Friend WithEvents IDPack As Label
    Friend WithEvents CategoryTxBx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClienteTxBx As TextBox
    Friend WithEvents Cliente As Label
    Friend WithEvents UnidadesTxBx As TextBox
    Friend WithEvents Unidades As Label
    Friend WithEvents DataGridPack As DataGridView
End Class
