<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaClientes
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
        TableLayoutPanel4 = New TableLayoutPanel()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Unidades = New Label()
        ClienteTxBx = New TextBox()
        UnidadesTxBx = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Cliente = New Label()
        TableLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel4.ColumnCount = 4
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.Controls.Add(TextBox1, 0, 1)
        TableLayoutPanel4.Controls.Add(TextBox2, 1, 1)
        TableLayoutPanel4.Controls.Add(Unidades, 3, 0)
        TableLayoutPanel4.Controls.Add(ClienteTxBx, 2, 1)
        TableLayoutPanel4.Controls.Add(UnidadesTxBx, 3, 1)
        TableLayoutPanel4.Controls.Add(Label3, 0, 0)
        TableLayoutPanel4.Controls.Add(Label4, 1, 0)
        TableLayoutPanel4.Controls.Add(Cliente, 2, 0)
        TableLayoutPanel4.Location = New Point(92, 133)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(845, 50)
        TableLayoutPanel4.TabIndex = 25
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 27)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(78, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Location = New Point(87, 27)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 23)
        TextBox2.TabIndex = 7
        ' 
        ' Unidades
        ' 
        Unidades.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Unidades.AutoSize = True
        Unidades.Location = New Point(678, 0)
        Unidades.Name = "Unidades"
        Unidades.Size = New Size(164, 25)
        Unidades.TabIndex = 12
        Unidades.Text = "Unidades"
        Unidades.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ClienteTxBx
        ' 
        ClienteTxBx.Dock = DockStyle.Fill
        ClienteTxBx.Location = New Point(298, 27)
        ClienteTxBx.Margin = New Padding(3, 2, 3, 2)
        ClienteTxBx.Name = "ClienteTxBx"
        ClienteTxBx.Size = New Size(374, 23)
        ClienteTxBx.TabIndex = 9
        ' 
        ' UnidadesTxBx
        ' 
        UnidadesTxBx.Dock = DockStyle.Fill
        UnidadesTxBx.Location = New Point(678, 27)
        UnidadesTxBx.Margin = New Padding(3, 2, 3, 2)
        UnidadesTxBx.Name = "UnidadesTxBx"
        UnidadesTxBx.Size = New Size(164, 23)
        UnidadesTxBx.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 6
        Label3.Text = "ID"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(87, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 25)
        Label4.TabIndex = 8
        Label4.Text = "Nombre"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Cliente
        ' 
        Cliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Cliente.AutoSize = True
        Cliente.Location = New Point(298, 0)
        Cliente.Name = "Cliente"
        Cliente.Size = New Size(374, 25)
        Cliente.TabIndex = 10
        Cliente.Text = "Fecha de nacimiento"
        Cliente.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AltaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel4)
        Name = "AltaClientes"
        Text = "AltaClientes"
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Unidades As Label
    Friend WithEvents ClienteTxBx As TextBox
    Friend WithEvents UnidadesTxBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cliente As Label
End Class
