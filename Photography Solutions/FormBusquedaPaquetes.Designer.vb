<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaPaquetes
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
        txtBusqueda = New TextBox()
        lblTitulo = New Label()
        btnBusqueda = New Button()
        btnDefault = New Button()
        dgvBusqueda = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvBusqueda, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(58, 63)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(672, 23)
        txtBusqueda.TabIndex = 0
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(315, 32)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(127, 15)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Busqueda por Nombre"
        ' 
        ' btnBusqueda
        ' 
        btnBusqueda.Dock = DockStyle.Fill
        btnBusqueda.Location = New Point(3, 3)
        btnBusqueda.Name = "btnBusqueda"
        btnBusqueda.Size = New Size(122, 33)
        btnBusqueda.TabIndex = 2
        btnBusqueda.Text = "Buscar"
        btnBusqueda.UseVisualStyleBackColor = True
        ' 
        ' btnDefault
        ' 
        btnDefault.Dock = DockStyle.Fill
        btnDefault.Location = New Point(131, 3)
        btnDefault.Name = "btnDefault"
        btnDefault.Size = New Size(123, 33)
        btnDefault.TabIndex = 3
        btnDefault.Text = "TODOS"
        btnDefault.UseVisualStyleBackColor = True
        ' 
        ' dgvBusqueda
        ' 
        dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBusqueda.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvBusqueda.Location = New Point(58, 158)
        dgvBusqueda.Name = "dgvBusqueda"
        dgvBusqueda.ReadOnly = True
        dgvBusqueda.RowTemplate.Height = 25
        dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBusqueda.Size = New Size(672, 227)
        dgvBusqueda.TabIndex = 4
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnBusqueda, 0, 0)
        TableLayoutPanel1.Controls.Add(btnDefault, 1, 0)
        TableLayoutPanel1.Location = New Point(252, 103)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(257, 39)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' FormBusquedaPaquetes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 442)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(dgvBusqueda)
        Controls.Add(lblTitulo)
        Controls.Add(txtBusqueda)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormBusquedaPaquetes"
        Text = "Busqueda Paquetes"
        CType(dgvBusqueda, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnBusqueda As Button
    Friend WithEvents btnDefault As Button
    Friend WithEvents dgvBusqueda As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
