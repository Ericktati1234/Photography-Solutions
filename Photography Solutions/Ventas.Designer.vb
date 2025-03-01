<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        LeAtiende = New Label()
        ClienteV = New Label()
        LeAtiendeTxBx = New TextBox()
        ClienteVTxBx = New TextBox()
        Logo = New PictureBox()
        NombreSearch = New Button()
        EliminarSelección = New Button()
        IDSearch = New Button()
        Total = New Label()
        Pago = New Label()
        Cambio = New Label()
        SplitContainer1 = New SplitContainer()
        Totallbl = New Label()
        Cambiolbl = New Label()
        PagoTxBx = New TextBox()
        MXN = New Label()
        MXN2 = New Label()
        MXN3 = New Label()
        TerminarVenta = New Button()
        DataGridView1 = New DataGridView()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LeAtiende
        ' 
        LeAtiende.AutoSize = True
        LeAtiende.Location = New Point(12, 28)
        LeAtiende.Name = "LeAtiende"
        LeAtiende.Size = New Size(81, 20)
        LeAtiende.TabIndex = 0
        LeAtiende.Text = "Le atiende:"
        ' 
        ' ClienteV
        ' 
        ClienteV.AutoSize = True
        ClienteV.Location = New Point(12, 76)
        ClienteV.Name = "ClienteV"
        ClienteV.Size = New Size(58, 20)
        ClienteV.TabIndex = 1
        ClienteV.Text = "Cliente:"
        ' 
        ' LeAtiendeTxBx
        ' 
        LeAtiendeTxBx.Location = New Point(99, 28)
        LeAtiendeTxBx.Name = "LeAtiendeTxBx"
        LeAtiendeTxBx.Size = New Size(125, 27)
        LeAtiendeTxBx.TabIndex = 2
        ' 
        ' ClienteVTxBx
        ' 
        ClienteVTxBx.Location = New Point(99, 73)
        ClienteVTxBx.Name = "ClienteVTxBx"
        ClienteVTxBx.Size = New Size(125, 27)
        ClienteVTxBx.TabIndex = 3
        ' 
        ' Logo
        ' 
        Logo.Location = New Point(624, 38)
        Logo.Name = "Logo"
        Logo.Size = New Size(125, 62)
        Logo.TabIndex = 4
        Logo.TabStop = False
        ' 
        ' NombreSearch
        ' 
        NombreSearch.Location = New Point(12, 154)
        NombreSearch.Name = "NombreSearch"
        NombreSearch.Size = New Size(121, 57)
        NombreSearch.TabIndex = 5
        NombreSearch.Text = "Buscar por nombre"
        NombreSearch.UseVisualStyleBackColor = True
        ' 
        ' EliminarSelección
        ' 
        EliminarSelección.Location = New Point(12, 231)
        EliminarSelección.Name = "EliminarSelección"
        EliminarSelección.Size = New Size(121, 57)
        EliminarSelección.TabIndex = 6
        EliminarSelección.Text = "Eliminar selección"
        EliminarSelección.UseVisualStyleBackColor = True
        ' 
        ' IDSearch
        ' 
        IDSearch.Location = New Point(22, 306)
        IDSearch.Name = "IDSearch"
        IDSearch.Size = New Size(121, 57)
        IDSearch.TabIndex = 7
        IDSearch.Text = "ID"
        IDSearch.UseVisualStyleBackColor = True
        ' 
        ' Total
        ' 
        Total.AutoSize = True
        Total.Location = New Point(8, 23)
        Total.Name = "Total"
        Total.Size = New Size(42, 20)
        Total.TabIndex = 8
        Total.Text = "Total"
        ' 
        ' Pago
        ' 
        Pago.AutoSize = True
        Pago.Location = New Point(-3, 64)
        Pago.Name = "Pago"
        Pago.Size = New Size(42, 20)
        Pago.TabIndex = 9
        Pago.Text = "Pago"
        ' 
        ' Cambio
        ' 
        Cambio.AutoSize = True
        Cambio.Location = New Point(8, 93)
        Cambio.Name = "Cambio"
        Cambio.Size = New Size(61, 20)
        Cambio.TabIndex = 10
        Cambio.Text = "Cambio"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(469, 231)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Pago)
        SplitContainer1.Panel1.Controls.Add(Cambio)
        SplitContainer1.Panel1.Controls.Add(Total)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(PagoTxBx)
        SplitContainer1.Panel2.Controls.Add(Cambiolbl)
        SplitContainer1.Panel2.Controls.Add(Totallbl)
        SplitContainer1.Size = New Size(239, 139)
        SplitContainer1.SplitterDistance = 79
        SplitContainer1.TabIndex = 11
        ' 
        ' Totallbl
        ' 
        Totallbl.AutoSize = True
        Totallbl.Location = New Point(42, 18)
        Totallbl.Name = "Totallbl"
        Totallbl.Size = New Size(17, 20)
        Totallbl.TabIndex = 12
        Totallbl.Text = "0"
        ' 
        ' Cambiolbl
        ' 
        Cambiolbl.AutoSize = True
        Cambiolbl.Location = New Point(26, 103)
        Cambiolbl.Name = "Cambiolbl"
        Cambiolbl.Size = New Size(17, 20)
        Cambiolbl.TabIndex = 12
        Cambiolbl.Text = "0"
        ' 
        ' PagoTxBx
        ' 
        PagoTxBx.Location = New Point(3, 61)
        PagoTxBx.Name = "PagoTxBx"
        PagoTxBx.Size = New Size(125, 27)
        PagoTxBx.TabIndex = 12
        ' 
        ' MXN
        ' 
        MXN.AutoSize = True
        MXN.Location = New Point(714, 249)
        MXN.Name = "MXN"
        MXN.Size = New Size(42, 20)
        MXN.TabIndex = 12
        MXN.Text = "MXN"
        ' 
        ' MXN2
        ' 
        MXN2.AutoSize = True
        MXN2.Location = New Point(714, 292)
        MXN2.Name = "MXN2"
        MXN2.Size = New Size(42, 20)
        MXN2.TabIndex = 13
        MXN2.Text = "MXN"
        ' 
        ' MXN3
        ' 
        MXN3.AutoSize = True
        MXN3.Location = New Point(714, 334)
        MXN3.Name = "MXN3"
        MXN3.Size = New Size(42, 20)
        MXN3.TabIndex = 14
        MXN3.Text = "MXN"
        ' 
        ' TerminarVenta
        ' 
        TerminarVenta.Location = New Point(568, 376)
        TerminarVenta.Name = "TerminarVenta"
        TerminarVenta.Size = New Size(121, 57)
        TerminarVenta.TabIndex = 15
        TerminarVenta.Text = "Terminar Venta"
        TerminarVenta.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(216, 182)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(224, 188)
        DataGridView1.TabIndex = 16
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 471)
        Controls.Add(DataGridView1)
        Controls.Add(TerminarVenta)
        Controls.Add(MXN3)
        Controls.Add(MXN2)
        Controls.Add(MXN)
        Controls.Add(SplitContainer1)
        Controls.Add(IDSearch)
        Controls.Add(EliminarSelección)
        Controls.Add(NombreSearch)
        Controls.Add(Logo)
        Controls.Add(ClienteVTxBx)
        Controls.Add(LeAtiendeTxBx)
        Controls.Add(ClienteV)
        Controls.Add(LeAtiende)
        Name = "Ventas"
        Text = "Ventas"
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LeAtiende As Label
    Friend WithEvents ClienteV As Label
    Friend WithEvents LeAtiendeTxBx As TextBox
    Friend WithEvents ClienteVTxBx As TextBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents NombreSearch As Button
    Friend WithEvents EliminarSelección As Button
    Friend WithEvents IDSearch As Button
    Friend WithEvents Total As Label
    Friend WithEvents Pago As Label
    Friend WithEvents Cambio As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Totallbl As Label
    Friend WithEvents PagoTxBx As TextBox
    Friend WithEvents Cambiolbl As Label
    Friend WithEvents MXN As Label
    Friend WithEvents MXN2 As Label
    Friend WithEvents MXN3 As Label
    Friend WithEvents TerminarVenta As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
