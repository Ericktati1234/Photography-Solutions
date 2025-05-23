<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagos
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
        Label9 = New Label()
        btnConfirmarOrden = New Button()
        lblCuantoDebe = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label9.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(218, 45)
        Label9.TabIndex = 34
        Label9.Text = "PAGO SESION"
        ' 
        ' btnConfirmarOrden
        ' 
        btnConfirmarOrden.BackColor = Color.FromArgb(CByte(166), CByte(185), CByte(205))
        btnConfirmarOrden.Dock = DockStyle.Fill
        btnConfirmarOrden.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirmarOrden.Location = New Point(3, 159)
        btnConfirmarOrden.Margin = New Padding(3, 2, 3, 2)
        btnConfirmarOrden.MaximumSize = New Size(301, 64)
        btnConfirmarOrden.MinimumSize = New Size(301, 64)
        btnConfirmarOrden.Name = "btnConfirmarOrden"
        btnConfirmarOrden.Size = New Size(301, 64)
        btnConfirmarOrden.TabIndex = 32
        btnConfirmarOrden.Text = "CONFIRMAR PAGO"
        btnConfirmarOrden.UseVisualStyleBackColor = False
        ' 
        ' lblCuantoDebe
        ' 
        lblCuantoDebe.AutoSize = True
        lblCuantoDebe.BackColor = Color.White
        lblCuantoDebe.Dock = DockStyle.Fill
        lblCuantoDebe.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblCuantoDebe.Location = New Point(3, 45)
        lblCuantoDebe.Name = "lblCuantoDebe"
        lblCuantoDebe.Size = New Size(301, 112)
        lblCuantoDebe.TabIndex = 35
        lblCuantoDebe.Text = "default"
        lblCuantoDebe.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Label9, 0, 0)
        TableLayoutPanel1.Controls.Add(btnConfirmarOrden, 0, 2)
        TableLayoutPanel1.Controls.Add(lblCuantoDebe, 0, 1)
        TableLayoutPanel1.Location = New Point(36, 34)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TableLayoutPanel1.Size = New Size(307, 225)
        TableLayoutPanel1.TabIndex = 36
        ' 
        ' FormPagos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(387, 312)
        Controls.Add(TableLayoutPanel1)
        Name = "FormPagos"
        Text = "Pagos"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents btnConfirmarOrden As Button
    Friend WithEvents lblCuantoDebe As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
