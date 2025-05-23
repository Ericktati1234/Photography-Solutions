<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportes
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
        DatosPersonales = New Label()
        Label3 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnExportar = New Button()
        btnPaquetes = New Button()
        btnClientes = New Button()
        btnUsuarios = New Button()
        btnCotizaciones = New Button()
        btnPagos = New Button()
        btnAnticipos = New Button()
        dgvReportes = New DataGridView()
        btnSalir = New Button()
        TableLayoutPanel2.SuspendLayout()
        CType(dgvReportes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DatosPersonales
        ' 
        DatosPersonales.AutoSize = True
        DatosPersonales.BackColor = Color.FromArgb(CByte(238), CByte(243), CByte(248))
        DatosPersonales.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DatosPersonales.Location = New Point(583, 47)
        DatosPersonales.Name = "DatosPersonales"
        DatosPersonales.Size = New Size(287, 25)
        DatosPersonales.TabIndex = 37
        DatosPersonales.Text = "Favor de seleccionar una opcion:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(130), CByte(151), CByte(176))
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(41, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(267, 32)
        Label3.TabIndex = 36
        Label3.Text = "GESTOR DE REPORTES"
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Controls.Add(btnExportar, 0, 6)
        TableLayoutPanel2.Controls.Add(btnPaquetes, 0, 2)
        TableLayoutPanel2.Controls.Add(btnClientes, 0, 0)
        TableLayoutPanel2.Controls.Add(btnUsuarios, 0, 1)
        TableLayoutPanel2.Controls.Add(btnCotizaciones, 0, 3)
        TableLayoutPanel2.Controls.Add(btnPagos, 0, 4)
        TableLayoutPanel2.Controls.Add(btnAnticipos, 0, 5)
        TableLayoutPanel2.Location = New Point(38, 87)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 7
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857132F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857151F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857132F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(158, 492)
        TableLayoutPanel2.TabIndex = 35
        ' 
        ' btnExportar
        ' 
        btnExportar.BackColor = Color.Gainsboro
        btnExportar.Dock = DockStyle.Fill
        btnExportar.Enabled = False
        btnExportar.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnExportar.Location = New Point(3, 422)
        btnExportar.Margin = New Padding(3, 2, 3, 2)
        btnExportar.Name = "btnExportar"
        btnExportar.Size = New Size(152, 68)
        btnExportar.TabIndex = 38
        btnExportar.Text = "Exportar"
        btnExportar.UseVisualStyleBackColor = False
        ' 
        ' btnPaquetes
        ' 
        btnPaquetes.BackColor = Color.White
        btnPaquetes.Dock = DockStyle.Fill
        btnPaquetes.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPaquetes.Location = New Point(3, 142)
        btnPaquetes.Margin = New Padding(3, 2, 3, 2)
        btnPaquetes.Name = "btnPaquetes"
        btnPaquetes.Size = New Size(152, 66)
        btnPaquetes.TabIndex = 34
        btnPaquetes.Text = "Paquetes"
        btnPaquetes.UseVisualStyleBackColor = False
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.White
        btnClientes.Dock = DockStyle.Fill
        btnClientes.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnClientes.Location = New Point(3, 2)
        btnClientes.Margin = New Padding(3, 2, 3, 2)
        btnClientes.Name = "btnClientes"
        btnClientes.Size = New Size(152, 66)
        btnClientes.TabIndex = 0
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.White
        btnUsuarios.Dock = DockStyle.Fill
        btnUsuarios.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnUsuarios.Location = New Point(3, 72)
        btnUsuarios.Margin = New Padding(3, 2, 3, 2)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(152, 66)
        btnUsuarios.TabIndex = 2
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btnCotizaciones
        ' 
        btnCotizaciones.BackColor = Color.White
        btnCotizaciones.Dock = DockStyle.Fill
        btnCotizaciones.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnCotizaciones.Location = New Point(3, 212)
        btnCotizaciones.Margin = New Padding(3, 2, 3, 2)
        btnCotizaciones.Name = "btnCotizaciones"
        btnCotizaciones.Size = New Size(152, 66)
        btnCotizaciones.TabIndex = 3
        btnCotizaciones.Text = "Cotizaciones"
        btnCotizaciones.UseVisualStyleBackColor = False
        ' 
        ' btnPagos
        ' 
        btnPagos.BackColor = Color.White
        btnPagos.Dock = DockStyle.Fill
        btnPagos.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnPagos.Location = New Point(3, 282)
        btnPagos.Margin = New Padding(3, 2, 3, 2)
        btnPagos.Name = "btnPagos"
        btnPagos.Size = New Size(152, 66)
        btnPagos.TabIndex = 4
        btnPagos.Text = "Pagos"
        btnPagos.UseVisualStyleBackColor = False
        ' 
        ' btnAnticipos
        ' 
        btnAnticipos.BackColor = Color.White
        btnAnticipos.Dock = DockStyle.Fill
        btnAnticipos.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btnAnticipos.Location = New Point(3, 352)
        btnAnticipos.Margin = New Padding(3, 2, 3, 2)
        btnAnticipos.Name = "btnAnticipos"
        btnAnticipos.Size = New Size(152, 66)
        btnAnticipos.TabIndex = 35
        btnAnticipos.Text = "Anticipos"
        btnAnticipos.UseVisualStyleBackColor = False
        ' 
        ' dgvReportes
        ' 
        dgvReportes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvReportes.BackgroundColor = Color.White
        dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReportes.Location = New Point(212, 87)
        dgvReportes.Margin = New Padding(3, 2, 3, 2)
        dgvReportes.Name = "dgvReportes"
        dgvReportes.RowHeadersWidth = 51
        dgvReportes.RowTemplate.Height = 29
        dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReportes.Size = New Size(1043, 492)
        dgvReportes.TabIndex = 34
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnSalir.Location = New Point(1106, 30)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(133, 32)
        btnSalir.TabIndex = 38
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' FormReportes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(205), CByte(221), CByte(237))
        ClientSize = New Size(1290, 625)
        Controls.Add(btnSalir)
        Controls.Add(DatosPersonales)
        Controls.Add(Label3)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(dgvReportes)
        Name = "FormReportes"
        Text = "Reportes"
        TableLayoutPanel2.ResumeLayout(False)
        CType(dgvReportes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DatosPersonales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnAnticipos As Button
    Friend WithEvents btnPaquetes As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnCotizaciones As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents dgvReportes As DataGridView
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnSalir As Button
End Class
