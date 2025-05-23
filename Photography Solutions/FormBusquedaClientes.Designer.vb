<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaClientes
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
        TableLayoutPanel1 = New TableLayoutPanel()
        btnBusqueda = New Button()
        btnDefault = New Button()
        dgvBusqueda = New DataGridView()
        lblTitulo = New Label()
        txtBusqueda = New TextBox()
        TableLayoutPanel1.SuspendLayout()
        CType(dgvBusqueda, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(btnBusqueda, 0, 0)
        TableLayoutPanel1.Controls.Add(btnDefault, 1, 0)
        TableLayoutPanel1.Location = New Point(268, 106)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(257, 39)
        TableLayoutPanel1.TabIndex = 9
        ' 
        ' btnBusqueda
        ' 
        btnBusqueda.Dock = DockStyle.Fill
        btnBusqueda.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBusqueda.Location = New Point(3, 3)
        btnBusqueda.Name = "btnBusqueda"
        btnBusqueda.Size = New Size(122, 33)
        btnBusqueda.TabIndex = 2
        btnBusqueda.Text = "Buscar"
        btnBusqueda.UseVisualStyleBackColor = True
        ' 
        ' btnDefault
        ' 
        btnDefault.BackColor = Color.Gainsboro
        btnDefault.Dock = DockStyle.Fill
        btnDefault.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDefault.Location = New Point(131, 3)
        btnDefault.Name = "btnDefault"
        btnDefault.Size = New Size(123, 33)
        btnDefault.TabIndex = 3
        btnDefault.Text = "TODOS"
        btnDefault.UseVisualStyleBackColor = False
        ' 
        ' dgvBusqueda
        ' 
        dgvBusqueda.BackgroundColor = Color.White
        dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBusqueda.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvBusqueda.Location = New Point(58, 158)
        dgvBusqueda.Name = "dgvBusqueda"
        dgvBusqueda.ReadOnly = True
        dgvBusqueda.RowTemplate.Height = 25
        dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvBusqueda.Size = New Size(672, 227)
        dgvBusqueda.TabIndex = 8
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        lblTitulo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitulo.Location = New Point(291, 33)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(203, 25)
        lblTitulo.TabIndex = 7
        lblTitulo.Text = "Busqueda por Nombre"
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(58, 71)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(672, 23)
        txtBusqueda.TabIndex = 6
        ' 
        ' FormBusquedaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(790, 444)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(dgvBusqueda)
        Controls.Add(lblTitulo)
        Controls.Add(txtBusqueda)
        MaximumSize = New Size(806, 483)
        MinimumSize = New Size(806, 483)
        Name = "FormBusquedaClientes"
        Text = "Busqueda de clientes"
        TableLayoutPanel1.ResumeLayout(False)
        CType(dgvBusqueda, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBusqueda As Button
    Friend WithEvents btnDefault As Button
    Friend WithEvents dgvBusqueda As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtBusqueda As TextBox
End Class
