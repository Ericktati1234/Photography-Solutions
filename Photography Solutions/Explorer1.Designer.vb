<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorer1
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

    Friend WithEvents ToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TreeNodeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents BackToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForwardToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FoldersToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListViewToolStripButton As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SmallIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FoldersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ListViewLargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ListViewSmallImageList As System.Windows.Forms.ImageList

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explorer1))
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        TreeNodeImageList = New ImageList(components)
        ToolStrip = New ToolStrip()
        BackToolStripButton = New ToolStripButton()
        ForwardToolStripButton = New ToolStripButton()
        ToolStripSeparator7 = New ToolStripSeparator()
        FoldersToolStripButton = New ToolStripButton()
        ToolStripSeparator8 = New ToolStripSeparator()
        ListViewToolStripButton = New ToolStripDropDownButton()
        ListToolStripMenuItem = New ToolStripMenuItem()
        DetailsToolStripMenuItem = New ToolStripMenuItem()
        LargeIconsToolStripMenuItem = New ToolStripMenuItem()
        SmallIconsToolStripMenuItem = New ToolStripMenuItem()
        TileToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ToolBarToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        FoldersToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        ToolStripContainer = New ToolStripContainer()
        SplitContainer = New SplitContainer()
        TreeView = New TreeView()
        ListView = New ListView()
        ListViewLargeImageList = New ImageList(components)
        ListViewSmallImageList = New ImageList(components)
        StatusStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        MenuStrip.SuspendLayout()
        ToolStripContainer.BottomToolStripPanel.SuspendLayout()
        ToolStripContainer.ContentPanel.SuspendLayout()
        ToolStripContainer.TopToolStripPanel.SuspendLayout()
        ToolStripContainer.SuspendLayout()
        CType(SplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Dock = DockStyle.None
        StatusStrip.ImageScalingSize = New Size(20, 20)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 0)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Size = New Size(843, 26)
        StatusStrip.TabIndex = 6
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(54, 20)
        ToolStripStatusLabel.Text = "Estado"
        ' 
        ' TreeNodeImageList
        ' 
        TreeNodeImageList.ColorDepth = ColorDepth.Depth8Bit
        TreeNodeImageList.ImageStream = CType(resources.GetObject("TreeNodeImageList.ImageStream"), ImageListStreamer)
        TreeNodeImageList.TransparentColor = Color.Transparent
        TreeNodeImageList.Images.SetKeyName(0, "ClosedFolder")
        TreeNodeImageList.Images.SetKeyName(1, "OpenFolder")
        ' 
        ' ToolStrip
        ' 
        ToolStrip.Anchor = AnchorStyles.Right
        ToolStrip.Dock = DockStyle.None
        ToolStrip.ImageScalingSize = New Size(20, 20)
        ToolStrip.Items.AddRange(New ToolStripItem() {BackToolStripButton, ForwardToolStripButton, ToolStripSeparator7, FoldersToolStripButton, ToolStripSeparator8, ListViewToolStripButton})
        ToolStrip.Location = New Point(4, 0)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Size = New Size(310, 27)
        ToolStrip.TabIndex = 0
        ToolStrip.Text = "ToolStrip1"
        ' 
        ' BackToolStripButton
        ' 
        BackToolStripButton.Enabled = False
        BackToolStripButton.Image = CType(resources.GetObject("BackToolStripButton.Image"), Image)
        BackToolStripButton.ImageTransparentColor = Color.Black
        BackToolStripButton.Name = "BackToolStripButton"
        BackToolStripButton.Size = New Size(67, 24)
        BackToolStripButton.Text = "Atrás"
        BackToolStripButton.ToolTipText = "Volver al elemento anterior"
        ' 
        ' ForwardToolStripButton
        ' 
        ForwardToolStripButton.Enabled = False
        ForwardToolStripButton.Image = CType(resources.GetObject("ForwardToolStripButton.Image"), Image)
        ForwardToolStripButton.ImageTransparentColor = Color.Black
        ForwardToolStripButton.Name = "ForwardToolStripButton"
        ForwardToolStripButton.Size = New Size(93, 24)
        ForwardToolStripButton.Text = "Adelante"
        ForwardToolStripButton.ToolTipText = "Avanzar hasta el siguiente elemento"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(6, 27)
        ' 
        ' FoldersToolStripButton
        ' 
        FoldersToolStripButton.Checked = True
        FoldersToolStripButton.CheckState = CheckState.Checked
        FoldersToolStripButton.Image = CType(resources.GetObject("FoldersToolStripButton.Image"), Image)
        FoldersToolStripButton.ImageTransparentColor = Color.Black
        FoldersToolStripButton.Name = "FoldersToolStripButton"
        FoldersToolStripButton.Size = New Size(91, 24)
        FoldersToolStripButton.Text = "Carpetas"
        FoldersToolStripButton.ToolTipText = "Alternar Vista de carpetas"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(6, 27)
        ' 
        ' ListViewToolStripButton
        ' 
        ListViewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ListViewToolStripButton.DropDownItems.AddRange(New ToolStripItem() {ListToolStripMenuItem, DetailsToolStripMenuItem, LargeIconsToolStripMenuItem, SmallIconsToolStripMenuItem, TileToolStripMenuItem})
        ListViewToolStripButton.Image = CType(resources.GetObject("ListViewToolStripButton.Image"), Image)
        ListViewToolStripButton.ImageTransparentColor = Color.Black
        ListViewToolStripButton.Name = "ListViewToolStripButton"
        ListViewToolStripButton.Size = New Size(34, 24)
        ListViewToolStripButton.Text = "Vistas"
        ' 
        ' ListToolStripMenuItem
        ' 
        ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        ListToolStripMenuItem.Size = New Size(204, 26)
        ListToolStripMenuItem.Text = "Lista"
        ' 
        ' DetailsToolStripMenuItem
        ' 
        DetailsToolStripMenuItem.Checked = True
        DetailsToolStripMenuItem.CheckState = CheckState.Checked
        DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        DetailsToolStripMenuItem.Size = New Size(204, 26)
        DetailsToolStripMenuItem.Text = "Detalles"
        ' 
        ' LargeIconsToolStripMenuItem
        ' 
        LargeIconsToolStripMenuItem.Name = "LargeIconsToolStripMenuItem"
        LargeIconsToolStripMenuItem.Size = New Size(204, 26)
        LargeIconsToolStripMenuItem.Text = "Iconos grandes"
        ' 
        ' SmallIconsToolStripMenuItem
        ' 
        SmallIconsToolStripMenuItem.Name = "SmallIconsToolStripMenuItem"
        SmallIconsToolStripMenuItem.Size = New Size(204, 26)
        SmallIconsToolStripMenuItem.Text = "Iconos pequeños"
        ' 
        ' TileToolStripMenuItem
        ' 
        TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        TileToolStripMenuItem.Size = New Size(204, 26)
        TileToolStripMenuItem.Text = "Mosaico"
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Dock = DockStyle.None
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip.Location = New Point(0, 27)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(843, 28)
        MenuStrip.TabIndex = 0
        MenuStrip.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator1, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator2, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, ToolStripSeparator3, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(73, 24)
        FileToolStripMenuItem.Text = "&Archivo"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Black
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(260, 26)
        NewToolStripMenuItem.Text = "&Nuevo"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Black
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(260, 26)
        OpenToolStripMenuItem.Text = "&Abrir"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(257, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Black
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(260, 26)
        SaveToolStripMenuItem.Text = "&Guardar"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(260, 26)
        SaveAsToolStripMenuItem.Text = "Guardar &como"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(257, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(260, 26)
        PrintToolStripMenuItem.Text = "&Imprimir"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Black
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(260, 26)
        PrintPreviewToolStripMenuItem.Text = "&Vista previa de impresión"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(257, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(260, 26)
        ExitToolStripMenuItem.Text = "&Salir"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator4, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(62, 24)
        EditToolStripMenuItem.Text = "&Editar"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Image = CType(resources.GetObject("UndoToolStripMenuItem.Image"), Image)
        UndoToolStripMenuItem.ImageTransparentColor = Color.Black
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(256, 26)
        UndoToolStripMenuItem.Text = "&Deshacer"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Image = CType(resources.GetObject("RedoToolStripMenuItem.Image"), Image)
        RedoToolStripMenuItem.ImageTransparentColor = Color.Black
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(256, 26)
        RedoToolStripMenuItem.Text = "&Rehacer"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(253, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), Image)
        CutToolStripMenuItem.ImageTransparentColor = Color.Black
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.X
        CutToolStripMenuItem.Size = New Size(256, 26)
        CutToolStripMenuItem.Text = "Cor&tar"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), Image)
        CopyToolStripMenuItem.ImageTransparentColor = Color.Black
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
        CopyToolStripMenuItem.Size = New Size(256, 26)
        CopyToolStripMenuItem.Text = "&Copiar"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), Image)
        PasteToolStripMenuItem.ImageTransparentColor = Color.Black
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.V
        PasteToolStripMenuItem.Size = New Size(256, 26)
        PasteToolStripMenuItem.Text = "&Pegar"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(253, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.A
        SelectAllToolStripMenuItem.Size = New Size(256, 26)
        SelectAllToolStripMenuItem.Text = "Seleccionar &todo"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolBarToolStripMenuItem, StatusBarToolStripMenuItem, FoldersToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 24)
        ViewToolStripMenuItem.Text = "&Ver"
        ' 
        ' ToolBarToolStripMenuItem
        ' 
        ToolBarToolStripMenuItem.Checked = True
        ToolBarToolStripMenuItem.CheckState = CheckState.Checked
        ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        ToolBarToolStripMenuItem.Size = New Size(238, 26)
        ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Checked = True
        StatusBarToolStripMenuItem.CheckState = CheckState.Checked
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(238, 26)
        StatusBarToolStripMenuItem.Text = "&Barra de estado"
        ' 
        ' FoldersToolStripMenuItem
        ' 
        FoldersToolStripMenuItem.Checked = True
        FoldersToolStripMenuItem.CheckState = CheckState.Checked
        FoldersToolStripMenuItem.Name = "FoldersToolStripMenuItem"
        FoldersToolStripMenuItem.Size = New Size(238, 26)
        FoldersToolStripMenuItem.Text = "&Carpetas"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OptionsToolStripMenuItem})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(112, 24)
        ToolsToolStripMenuItem.Text = "&Herramientas"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(154, 26)
        OptionsToolStripMenuItem.Text = "&Opciones"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, ToolStripSeparator6, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 24)
        HelpToolStripMenuItem.Text = "Ay&uda"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.F1
        ContentsToolStripMenuItem.Size = New Size(218, 26)
        ContentsToolStripMenuItem.Text = "&Contenido"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), Image)
        IndexToolStripMenuItem.ImageTransparentColor = Color.Black
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(218, 26)
        IndexToolStripMenuItem.Text = "&Índice"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), Image)
        SearchToolStripMenuItem.ImageTransparentColor = Color.Black
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(218, 26)
        SearchToolStripMenuItem.Text = "&Buscar"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(215, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(218, 26)
        AboutToolStripMenuItem.Text = "&Acerca de ..."
        ' 
        ' ToolStripContainer
        ' 
        ' 
        ' ToolStripContainer.BottomToolStripPanel
        ' 
        ToolStripContainer.BottomToolStripPanel.Controls.Add(StatusStrip)
        ' 
        ' ToolStripContainer.ContentPanel
        ' 
        ToolStripContainer.ContentPanel.Controls.Add(SplitContainer)
        ToolStripContainer.ContentPanel.Margin = New Padding(4, 5, 4, 5)
        ToolStripContainer.ContentPanel.Size = New Size(843, 616)
        ToolStripContainer.Dock = DockStyle.Fill
        ToolStripContainer.Location = New Point(0, 0)
        ToolStripContainer.Margin = New Padding(4, 5, 4, 5)
        ToolStripContainer.Name = "ToolStripContainer"
        ToolStripContainer.Size = New Size(843, 697)
        ToolStripContainer.TabIndex = 7
        ToolStripContainer.Text = "ToolStripContainer1"
        ' 
        ' ToolStripContainer.TopToolStripPanel
        ' 
        ToolStripContainer.TopToolStripPanel.Controls.Add(MenuStrip)
        ToolStripContainer.TopToolStripPanel.Controls.Add(ToolStrip)
        ' 
        ' SplitContainer
        ' 
        SplitContainer.Dock = DockStyle.Fill
        SplitContainer.Location = New Point(0, 0)
        SplitContainer.Margin = New Padding(4, 5, 4, 5)
        SplitContainer.Name = "SplitContainer"
        ' 
        ' SplitContainer.Panel1
        ' 
        SplitContainer.Panel1.Controls.Add(TreeView)
        ' 
        ' SplitContainer.Panel2
        ' 
        SplitContainer.Panel2.Controls.Add(ListView)
        SplitContainer.Size = New Size(843, 616)
        SplitContainer.SplitterDistance = 281
        SplitContainer.SplitterWidth = 5
        SplitContainer.TabIndex = 0
        SplitContainer.Text = "SplitContainer1"
        ' 
        ' TreeView
        ' 
        TreeView.Dock = DockStyle.Fill
        TreeView.ImageIndex = 0
        TreeView.ImageList = TreeNodeImageList
        TreeView.Location = New Point(0, 0)
        TreeView.Margin = New Padding(4, 5, 4, 5)
        TreeView.Name = "TreeView"
        TreeView.SelectedImageIndex = 1
        TreeView.ShowLines = False
        TreeView.Size = New Size(281, 616)
        TreeView.TabIndex = 0
        ' 
        ' ListView
        ' 
        ListView.Dock = DockStyle.Fill
        ListView.LargeImageList = ListViewLargeImageList
        ListView.Location = New Point(0, 0)
        ListView.Margin = New Padding(4, 5, 4, 5)
        ListView.Name = "ListView"
        ListView.Size = New Size(557, 616)
        ListView.SmallImageList = ListViewSmallImageList
        ListView.TabIndex = 0
        ListView.UseCompatibleStateImageBehavior = False
        ' 
        ' ListViewLargeImageList
        ' 
        ListViewLargeImageList.ColorDepth = ColorDepth.Depth8Bit
        ListViewLargeImageList.ImageStream = CType(resources.GetObject("ListViewLargeImageList.ImageStream"), ImageListStreamer)
        ListViewLargeImageList.TransparentColor = Color.Transparent
        ListViewLargeImageList.Images.SetKeyName(0, "Graph1")
        ListViewLargeImageList.Images.SetKeyName(1, "Graph2")
        ListViewLargeImageList.Images.SetKeyName(2, "Graph3")
        ' 
        ' ListViewSmallImageList
        ' 
        ListViewSmallImageList.ColorDepth = ColorDepth.Depth8Bit
        ListViewSmallImageList.ImageStream = CType(resources.GetObject("ListViewSmallImageList.ImageStream"), ImageListStreamer)
        ListViewSmallImageList.TransparentColor = Color.Transparent
        ListViewSmallImageList.Images.SetKeyName(0, "Graph1")
        ListViewSmallImageList.Images.SetKeyName(1, "Graph2")
        ListViewSmallImageList.Images.SetKeyName(2, "Graph3")
        ' 
        ' Explorer1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(843, 697)
        Controls.Add(ToolStripContainer)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Explorer1"
        Text = "Archivos"
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStripContainer.BottomToolStripPanel.ResumeLayout(False)
        ToolStripContainer.BottomToolStripPanel.PerformLayout()
        ToolStripContainer.ContentPanel.ResumeLayout(False)
        ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer.TopToolStripPanel.PerformLayout()
        ToolStripContainer.ResumeLayout(False)
        ToolStripContainer.PerformLayout()
        SplitContainer.Panel1.ResumeLayout(False)
        SplitContainer.Panel2.ResumeLayout(False)
        CType(SplitContainer, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

End Class
