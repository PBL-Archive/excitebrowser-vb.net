<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrowserTab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserTab))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NavigationPanel = New System.Windows.Forms.Panel()
        Me.AddressBar = New System.Windows.Forms.ComboBox()
        Me.SearchBar = New System.Windows.Forms.ComboBox()
        Me.SearchEngineSelector = New System.Windows.Forms.ComboBox()
        Me.MenuClose = New System.Windows.Forms.Button()
        Me.SiteLoadIndicatorSuccessfull = New System.Windows.Forms.PictureBox()
        Me.SiteLoadIndicatorLoading = New System.Windows.Forms.PictureBox()
        Me.MenuOpen = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Button()
        Me.CancelLoading = New System.Windows.Forms.Button()
        Me.GoToLink = New System.Windows.Forms.Button()
        Me.RefreshSite = New System.Windows.Forms.Button()
        Me.BookmarksToolBar = New System.Windows.Forms.Button()
        Me.GoToHome = New System.Windows.Forms.Button()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.NextLink = New System.Windows.Forms.Button()
        Me.PreviousLink = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeMenuBackGroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowsingWindowPanel = New System.Windows.Forms.WebBrowser()
        Me.BrowserMenu = New System.Windows.Forms.ToolStrip()
        Me.AddTabMenu = New System.Windows.Forms.ToolStripButton()
        Me.RemoveTabMenu = New System.Windows.Forms.ToolStripButton()
        Me.AddPrivateWindowMenu = New System.Windows.Forms.ToolStripButton()
        Me.NewWindowMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.HistoryMenu = New System.Windows.Forms.ToolStripButton()
        Me.BookmarksMenu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomizeMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CustomizeColors = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeBackGroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeMenuBackGroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeNavigatingPanelColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeNavigatedPanelColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HtmlEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperToolsMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SourceCode = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseWindow = New System.Windows.Forms.ToolStripButton()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog4 = New System.Windows.Forms.ColorDialog()
        Me.NavigationPanel.SuspendLayout()
        CType(Me.SiteLoadIndicatorSuccessfull, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteLoadIndicatorLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrowserMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 150)
        '
        'NavigationPanel
        '
        Me.NavigationPanel.BackColor = System.Drawing.Color.White
        Me.NavigationPanel.Controls.Add(Me.AddressBar)
        Me.NavigationPanel.Controls.Add(Me.SearchBar)
        Me.NavigationPanel.Controls.Add(Me.SearchEngineSelector)
        Me.NavigationPanel.Controls.Add(Me.MenuClose)
        Me.NavigationPanel.Controls.Add(Me.SiteLoadIndicatorSuccessfull)
        Me.NavigationPanel.Controls.Add(Me.SiteLoadIndicatorLoading)
        Me.NavigationPanel.Controls.Add(Me.MenuOpen)
        Me.NavigationPanel.Controls.Add(Me.Search)
        Me.NavigationPanel.Controls.Add(Me.CancelLoading)
        Me.NavigationPanel.Controls.Add(Me.GoToLink)
        Me.NavigationPanel.Controls.Add(Me.RefreshSite)
        Me.NavigationPanel.Controls.Add(Me.BookmarksToolBar)
        Me.NavigationPanel.Controls.Add(Me.GoToHome)
        Me.NavigationPanel.Controls.Add(Me.AddressLabel)
        Me.NavigationPanel.Controls.Add(Me.NextLink)
        Me.NavigationPanel.Controls.Add(Me.PreviousLink)
        Me.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavigationPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavigationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPanel.Name = "NavigationPanel"
        Me.NavigationPanel.Size = New System.Drawing.Size(1213, 30)
        Me.NavigationPanel.TabIndex = 22
        '
        'AddressBar
        '
        Me.AddressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressBar.FormattingEnabled = True
        Me.AddressBar.ItemHeight = 16
        Me.AddressBar.Location = New System.Drawing.Point(129, 2)
        Me.AddressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressBar.Name = "AddressBar"
        Me.AddressBar.Size = New System.Drawing.Size(415, 24)
        Me.AddressBar.TabIndex = 56
        '
        'SearchBar
        '
        Me.SearchBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBar.FormattingEnabled = True
        Me.SearchBar.Location = New System.Drawing.Point(843, 2)
        Me.SearchBar.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(289, 24)
        Me.SearchBar.TabIndex = 55
        '
        'SearchEngineSelector
        '
        Me.SearchEngineSelector.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchEngineSelector.AutoCompleteCustomSource.AddRange(New String() {"Google", "Yahoo", "Ask", "Bing", "YouTube", "Blinkx", "Amazon", "Hulu", "AskKids", "FactMonster", "Craigslist", "Wikipedia", "eBay", "Comcast Toolbar Search", "Baidu (Chinese)", "Sogou (Chinese)", "T-Online Sites (German)", "Orange (French)", "Naver (Korean)"})
        Me.SearchEngineSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchEngineSelector.BackColor = System.Drawing.Color.White
        Me.SearchEngineSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SearchEngineSelector.ForeColor = System.Drawing.Color.Black
        Me.SearchEngineSelector.FormattingEnabled = True
        Me.SearchEngineSelector.Location = New System.Drawing.Point(680, 2)
        Me.SearchEngineSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchEngineSelector.Name = "SearchEngineSelector"
        Me.SearchEngineSelector.Size = New System.Drawing.Size(160, 24)
        Me.SearchEngineSelector.TabIndex = 54
        '
        'MenuClose
        '
        Me.MenuClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuClose.BackColor = System.Drawing.Color.White
        Me.MenuClose.BackgroundImage = CType(resources.GetObject("MenuClose.BackgroundImage"), System.Drawing.Image)
        Me.MenuClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuClose.FlatAppearance.BorderSize = 0
        Me.MenuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuClose.Location = New System.Drawing.Point(1187, 2)
        Me.MenuClose.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuClose.Name = "MenuClose"
        Me.MenuClose.Size = New System.Drawing.Size(24, 25)
        Me.MenuClose.TabIndex = 52
        Me.MenuClose.UseVisualStyleBackColor = False
        '
        'SiteLoadIndicatorSuccessfull
        '
        Me.SiteLoadIndicatorSuccessfull.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiteLoadIndicatorSuccessfull.BackColor = System.Drawing.Color.White
        Me.SiteLoadIndicatorSuccessfull.BackgroundImage = CType(resources.GetObject("SiteLoadIndicatorSuccessfull.BackgroundImage"), System.Drawing.Image)
        Me.SiteLoadIndicatorSuccessfull.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SiteLoadIndicatorSuccessfull.ErrorImage = Nothing
        Me.SiteLoadIndicatorSuccessfull.InitialImage = Nothing
        Me.SiteLoadIndicatorSuccessfull.Location = New System.Drawing.Point(1161, 2)
        Me.SiteLoadIndicatorSuccessfull.Margin = New System.Windows.Forms.Padding(4)
        Me.SiteLoadIndicatorSuccessfull.Name = "SiteLoadIndicatorSuccessfull"
        Me.SiteLoadIndicatorSuccessfull.Size = New System.Drawing.Size(24, 25)
        Me.SiteLoadIndicatorSuccessfull.TabIndex = 51
        Me.SiteLoadIndicatorSuccessfull.TabStop = False
        '
        'SiteLoadIndicatorLoading
        '
        Me.SiteLoadIndicatorLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiteLoadIndicatorLoading.BackgroundImage = CType(resources.GetObject("SiteLoadIndicatorLoading.BackgroundImage"), System.Drawing.Image)
        Me.SiteLoadIndicatorLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SiteLoadIndicatorLoading.ErrorImage = Nothing
        Me.SiteLoadIndicatorLoading.Image = CType(resources.GetObject("SiteLoadIndicatorLoading.Image"), System.Drawing.Image)
        Me.SiteLoadIndicatorLoading.InitialImage = Nothing
        Me.SiteLoadIndicatorLoading.Location = New System.Drawing.Point(1161, 2)
        Me.SiteLoadIndicatorLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.SiteLoadIndicatorLoading.Name = "SiteLoadIndicatorLoading"
        Me.SiteLoadIndicatorLoading.Size = New System.Drawing.Size(24, 25)
        Me.SiteLoadIndicatorLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiteLoadIndicatorLoading.TabIndex = 50
        Me.SiteLoadIndicatorLoading.TabStop = False
        '
        'MenuOpen
        '
        Me.MenuOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuOpen.BackColor = System.Drawing.Color.White
        Me.MenuOpen.BackgroundImage = CType(resources.GetObject("MenuOpen.BackgroundImage"), System.Drawing.Image)
        Me.MenuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuOpen.FlatAppearance.BorderSize = 0
        Me.MenuOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuOpen.Location = New System.Drawing.Point(1187, 2)
        Me.MenuOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.MenuOpen.Name = "MenuOpen"
        Me.MenuOpen.Size = New System.Drawing.Size(24, 25)
        Me.MenuOpen.TabIndex = 49
        Me.MenuOpen.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Search.BackColor = System.Drawing.Color.White
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search.FlatAppearance.BorderSize = 0
        Me.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search.Location = New System.Drawing.Point(1135, 2)
        Me.Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(24, 25)
        Me.Search.TabIndex = 48
        Me.Search.UseVisualStyleBackColor = False
        '
        'CancelLoading
        '
        Me.CancelLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelLoading.BackColor = System.Drawing.Color.White
        Me.CancelLoading.BackgroundImage = CType(resources.GetObject("CancelLoading.BackgroundImage"), System.Drawing.Image)
        Me.CancelLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelLoading.FlatAppearance.BorderSize = 0
        Me.CancelLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelLoading.Location = New System.Drawing.Point(573, 2)
        Me.CancelLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelLoading.Name = "CancelLoading"
        Me.CancelLoading.Size = New System.Drawing.Size(24, 25)
        Me.CancelLoading.TabIndex = 47
        Me.CancelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelLoading.UseVisualStyleBackColor = False
        '
        'GoToLink
        '
        Me.GoToLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoToLink.BackColor = System.Drawing.Color.White
        Me.GoToLink.BackgroundImage = CType(resources.GetObject("GoToLink.BackgroundImage"), System.Drawing.Image)
        Me.GoToLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GoToLink.FlatAppearance.BorderSize = 0
        Me.GoToLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToLink.Location = New System.Drawing.Point(547, 2)
        Me.GoToLink.Margin = New System.Windows.Forms.Padding(0)
        Me.GoToLink.Name = "GoToLink"
        Me.GoToLink.Size = New System.Drawing.Size(24, 25)
        Me.GoToLink.TabIndex = 46
        Me.GoToLink.UseVisualStyleBackColor = False
        '
        'RefreshSite
        '
        Me.RefreshSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshSite.BackColor = System.Drawing.Color.White
        Me.RefreshSite.BackgroundImage = CType(resources.GetObject("RefreshSite.BackgroundImage"), System.Drawing.Image)
        Me.RefreshSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RefreshSite.FlatAppearance.BorderSize = 0
        Me.RefreshSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshSite.Location = New System.Drawing.Point(600, 2)
        Me.RefreshSite.Margin = New System.Windows.Forms.Padding(4)
        Me.RefreshSite.Name = "RefreshSite"
        Me.RefreshSite.Size = New System.Drawing.Size(24, 25)
        Me.RefreshSite.TabIndex = 43
        Me.RefreshSite.UseVisualStyleBackColor = False
        '
        'BookmarksToolBar
        '
        Me.BookmarksToolBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookmarksToolBar.BackColor = System.Drawing.Color.White
        Me.BookmarksToolBar.BackgroundImage = CType(resources.GetObject("BookmarksToolBar.BackgroundImage"), System.Drawing.Image)
        Me.BookmarksToolBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BookmarksToolBar.FlatAppearance.BorderSize = 0
        Me.BookmarksToolBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookmarksToolBar.Location = New System.Drawing.Point(653, 2)
        Me.BookmarksToolBar.Margin = New System.Windows.Forms.Padding(4)
        Me.BookmarksToolBar.Name = "BookmarksToolBar"
        Me.BookmarksToolBar.Size = New System.Drawing.Size(24, 25)
        Me.BookmarksToolBar.TabIndex = 45
        Me.BookmarksToolBar.UseVisualStyleBackColor = False
        '
        'GoToHome
        '
        Me.GoToHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoToHome.BackColor = System.Drawing.Color.White
        Me.GoToHome.BackgroundImage = CType(resources.GetObject("GoToHome.BackgroundImage"), System.Drawing.Image)
        Me.GoToHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GoToHome.FlatAppearance.BorderSize = 0
        Me.GoToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GoToHome.Location = New System.Drawing.Point(627, 2)
        Me.GoToHome.Margin = New System.Windows.Forms.Padding(4)
        Me.GoToHome.Name = "GoToHome"
        Me.GoToHome.Size = New System.Drawing.Size(24, 25)
        Me.GoToHome.TabIndex = 44
        Me.GoToHome.UseVisualStyleBackColor = False
        '
        'AddressLabel
        '
        Me.AddressLabel.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(56, 2)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(93, 25)
        Me.AddressLabel.TabIndex = 42
        Me.AddressLabel.Text = "Address"
        Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NextLink
        '
        Me.NextLink.BackColor = System.Drawing.Color.White
        Me.NextLink.BackgroundImage = CType(resources.GetObject("NextLink.BackgroundImage"), System.Drawing.Image)
        Me.NextLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextLink.FlatAppearance.BorderSize = 0
        Me.NextLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextLink.Location = New System.Drawing.Point(29, 2)
        Me.NextLink.Margin = New System.Windows.Forms.Padding(4)
        Me.NextLink.Name = "NextLink"
        Me.NextLink.Size = New System.Drawing.Size(24, 25)
        Me.NextLink.TabIndex = 40
        Me.NextLink.UseVisualStyleBackColor = False
        '
        'PreviousLink
        '
        Me.PreviousLink.BackColor = System.Drawing.Color.White
        Me.PreviousLink.BackgroundImage = CType(resources.GetObject("PreviousLink.BackgroundImage"), System.Drawing.Image)
        Me.PreviousLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PreviousLink.FlatAppearance.BorderSize = 0
        Me.PreviousLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PreviousLink.Location = New System.Drawing.Point(3, 2)
        Me.PreviousLink.Margin = New System.Windows.Forms.Padding(4)
        Me.PreviousLink.Name = "PreviousLink"
        Me.PreviousLink.Size = New System.Drawing.Size(24, 25)
        Me.PreviousLink.TabIndex = 29
        Me.PreviousLink.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(35, 35)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(138, 6)
        '
        'ChangeMenuBackGroundToolStripMenuItem
        '
        Me.ChangeMenuBackGroundToolStripMenuItem.Name = "ChangeMenuBackGroundToolStripMenuItem"
        Me.ChangeMenuBackGroundToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ChangeMenuBackGroundToolStripMenuItem.Text = "Change Menu BackGround"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(138, 6)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(138, 6)
        '
        'BrowsingWindowPanel
        '
        Me.BrowsingWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowsingWindowPanel.Location = New System.Drawing.Point(0, 30)
        Me.BrowsingWindowPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowsingWindowPanel.MinimumSize = New System.Drawing.Size(27, 25)
        Me.BrowsingWindowPanel.Name = "BrowsingWindowPanel"
        Me.BrowsingWindowPanel.ScriptErrorsSuppressed = True
        Me.BrowsingWindowPanel.Size = New System.Drawing.Size(1213, 600)
        Me.BrowsingWindowPanel.TabIndex = 23
        '
        'BrowserMenu
        '
        Me.BrowserMenu.AutoSize = False
        Me.BrowserMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.BrowserMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BrowserMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BrowserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTabMenu, Me.RemoveTabMenu, Me.AddPrivateWindowMenu, Me.NewWindowMenu, Me.ToolStripSeparator9, Me.HistoryMenu, Me.BookmarksMenu, Me.ToolStripSeparator5, Me.CustomizeMenu, Me.ToolStripSeparator6, Me.ToolsMenu, Me.DeveloperToolsMenu, Me.ToolStripSeparator7, Me.CloseWindow})
        Me.BrowserMenu.Location = New System.Drawing.Point(1013, 30)
        Me.BrowserMenu.Name = "BrowserMenu"
        Me.BrowserMenu.Size = New System.Drawing.Size(200, 600)
        Me.BrowserMenu.TabIndex = 25
        Me.BrowserMenu.Text = "BrowserMenu"
        '
        'AddTabMenu
        '
        Me.AddTabMenu.Image = CType(resources.GetObject("AddTabMenu.Image"), System.Drawing.Image)
        Me.AddTabMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddTabMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddTabMenu.Name = "AddTabMenu"
        Me.AddTabMenu.Size = New System.Drawing.Size(198, 24)
        Me.AddTabMenu.Text = "Add Tab"
        Me.AddTabMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RemoveTabMenu
        '
        Me.RemoveTabMenu.Image = CType(resources.GetObject("RemoveTabMenu.Image"), System.Drawing.Image)
        Me.RemoveTabMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RemoveTabMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveTabMenu.Name = "RemoveTabMenu"
        Me.RemoveTabMenu.Size = New System.Drawing.Size(198, 24)
        Me.RemoveTabMenu.Text = "Remove Tab"
        Me.RemoveTabMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddPrivateWindowMenu
        '
        Me.AddPrivateWindowMenu.Image = CType(resources.GetObject("AddPrivateWindowMenu.Image"), System.Drawing.Image)
        Me.AddPrivateWindowMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPrivateWindowMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddPrivateWindowMenu.Name = "AddPrivateWindowMenu"
        Me.AddPrivateWindowMenu.Size = New System.Drawing.Size(198, 24)
        Me.AddPrivateWindowMenu.Text = "Add Private Window"
        '
        'NewWindowMenu
        '
        Me.NewWindowMenu.Image = CType(resources.GetObject("NewWindowMenu.Image"), System.Drawing.Image)
        Me.NewWindowMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewWindowMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWindowMenu.Name = "NewWindowMenu"
        Me.NewWindowMenu.Size = New System.Drawing.Size(198, 24)
        Me.NewWindowMenu.Text = "New Window"
        Me.NewWindowMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(198, 6)
        '
        'HistoryMenu
        '
        Me.HistoryMenu.Image = CType(resources.GetObject("HistoryMenu.Image"), System.Drawing.Image)
        Me.HistoryMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HistoryMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HistoryMenu.Name = "HistoryMenu"
        Me.HistoryMenu.Size = New System.Drawing.Size(198, 24)
        Me.HistoryMenu.Text = "History"
        '
        'BookmarksMenu
        '
        Me.BookmarksMenu.Image = CType(resources.GetObject("BookmarksMenu.Image"), System.Drawing.Image)
        Me.BookmarksMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookmarksMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BookmarksMenu.Name = "BookmarksMenu"
        Me.BookmarksMenu.Size = New System.Drawing.Size(198, 24)
        Me.BookmarksMenu.Text = "Bookmarks"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(198, 6)
        '
        'CustomizeMenu
        '
        Me.CustomizeMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeColors})
        Me.CustomizeMenu.Image = CType(resources.GetObject("CustomizeMenu.Image"), System.Drawing.Image)
        Me.CustomizeMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomizeMenu.Name = "CustomizeMenu"
        Me.CustomizeMenu.Size = New System.Drawing.Size(198, 24)
        Me.CustomizeMenu.Text = "Customize"
        Me.CustomizeMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomizeColors
        '
        Me.CustomizeColors.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeBackGroundColor, Me.CustomizeMenuBackGroundColor, Me.CustomizeNavigatingPanelColor, Me.CustomizeNavigatedPanelColor})
        Me.CustomizeColors.Image = CType(resources.GetObject("CustomizeColors.Image"), System.Drawing.Image)
        Me.CustomizeColors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeColors.Name = "CustomizeColors"
        Me.CustomizeColors.Size = New System.Drawing.Size(207, 26)
        Me.CustomizeColors.Text = "Customize Colors"
        '
        'CustomizeBackGroundColor
        '
        Me.CustomizeBackGroundColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeBackGroundColor.Name = "CustomizeBackGroundColor"
        Me.CustomizeBackGroundColor.Size = New System.Drawing.Size(209, 26)
        Me.CustomizeBackGroundColor.Text = "BackGround"
        '
        'CustomizeMenuBackGroundColor
        '
        Me.CustomizeMenuBackGroundColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeMenuBackGroundColor.Name = "CustomizeMenuBackGroundColor"
        Me.CustomizeMenuBackGroundColor.Size = New System.Drawing.Size(209, 26)
        Me.CustomizeMenuBackGroundColor.Text = "MenuBackGround"
        '
        'CustomizeNavigatingPanelColor
        '
        Me.CustomizeNavigatingPanelColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeNavigatingPanelColor.Name = "CustomizeNavigatingPanelColor"
        Me.CustomizeNavigatingPanelColor.Size = New System.Drawing.Size(209, 26)
        Me.CustomizeNavigatingPanelColor.Text = "NavigatingPanel"
        '
        'CustomizeNavigatedPanelColor
        '
        Me.CustomizeNavigatedPanelColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomizeNavigatedPanelColor.Name = "CustomizeNavigatedPanelColor"
        Me.CustomizeNavigatedPanelColor.Size = New System.Drawing.Size(209, 26)
        Me.CustomizeNavigatedPanelColor.Text = "NavigatedPanel"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(198, 6)
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HtmlEditor})
        Me.ToolsMenu.Image = CType(resources.GetObject("ToolsMenu.Image"), System.Drawing.Image)
        Me.ToolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(198, 24)
        Me.ToolsMenu.Text = "Tools"
        '
        'HtmlEditor
        '
        Me.HtmlEditor.Image = CType(resources.GetObject("HtmlEditor.Image"), System.Drawing.Image)
        Me.HtmlEditor.Name = "HtmlEditor"
        Me.HtmlEditor.Size = New System.Drawing.Size(175, 26)
        Me.HtmlEditor.Text = "HTML Editor"
        '
        'DeveloperToolsMenu
        '
        Me.DeveloperToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceCode})
        Me.DeveloperToolsMenu.Image = CType(resources.GetObject("DeveloperToolsMenu.Image"), System.Drawing.Image)
        Me.DeveloperToolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeveloperToolsMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeveloperToolsMenu.Name = "DeveloperToolsMenu"
        Me.DeveloperToolsMenu.Size = New System.Drawing.Size(198, 24)
        Me.DeveloperToolsMenu.Text = "Developer Tools"
        '
        'SourceCode
        '
        Me.SourceCode.Image = CType(resources.GetObject("SourceCode.Image"), System.Drawing.Image)
        Me.SourceCode.Name = "SourceCode"
        Me.SourceCode.Size = New System.Drawing.Size(176, 26)
        Me.SourceCode.Text = "Source Code"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(198, 6)
        '
        'CloseWindow
        '
        Me.CloseWindow.Image = CType(resources.GetObject("CloseWindow.Image"), System.Drawing.Image)
        Me.CloseWindow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseWindow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseWindow.Name = "CloseWindow"
        Me.CloseWindow.Size = New System.Drawing.Size(198, 24)
        Me.CloseWindow.Text = "Close"
        Me.CloseWindow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BrowserTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 630)
        Me.Controls.Add(Me.BrowserMenu)
        Me.Controls.Add(Me.BrowsingWindowPanel)
        Me.Controls.Add(Me.NavigationPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BrowserTab"
        Me.Text = "BrowserTab"
        Me.NavigationPanel.ResumeLayout(False)
        CType(Me.SiteLoadIndicatorSuccessfull, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteLoadIndicatorLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrowserMenu.ResumeLayout(False)
        Me.BrowserMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NavigationPanel As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BottomToolStripPanel As ToolStripPanel
    Friend WithEvents TopToolStripPanel As ToolStripPanel
    Friend WithEvents RightToolStripPanel As ToolStripPanel
    Friend WithEvents LeftToolStripPanel As ToolStripPanel
    Friend WithEvents ContentPanel As ToolStripContentPanel
    Friend WithEvents PreviousLink As Button
    Friend WithEvents AddressLabel As Label
    Friend WithEvents NextLink As Button
    Friend WithEvents CancelLoading As Button
    Friend WithEvents GoToLink As Button
    Friend WithEvents RefreshSite As Button
    Friend WithEvents BookmarksToolBar As Button
    Friend WithEvents GoToHome As Button
    Friend WithEvents SiteLoadIndicatorLoading As PictureBox
    Friend WithEvents MenuOpen As Button
    Friend WithEvents Search As Button
    Friend WithEvents MenuClose As Button
    Friend WithEvents SiteLoadIndicatorSuccessfull As PictureBox
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents SearchEngineSelector As ComboBox
    Friend WithEvents SearchBar As ComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChangeMenuBackGroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BrowsingWindowPanel As WebBrowser
    Friend WithEvents BrowserMenu As ToolStrip
    Friend WithEvents AddTabMenu As ToolStripButton
    Friend WithEvents RemoveTabMenu As ToolStripButton
    Friend WithEvents NewWindowMenu As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CustomizeMenu As ToolStripDropDownButton
    Friend WithEvents CustomizeColors As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents CloseWindow As ToolStripButton
    Friend WithEvents CustomizeBackGroundColor As ToolStripMenuItem
    Friend WithEvents CustomizeMenuBackGroundColor As ToolStripMenuItem
    Friend WithEvents ColorDialog3 As ColorDialog
    Friend WithEvents ColorDialog4 As ColorDialog
    Friend WithEvents CustomizeNavigatingPanelColor As ToolStripMenuItem
    Friend WithEvents CustomizeNavigatedPanelColor As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents HistoryMenu As ToolStripButton
    Friend WithEvents BookmarksMenu As ToolStripButton
    Friend WithEvents ToolsMenu As ToolStripDropDownButton
    Friend WithEvents HtmlEditor As ToolStripMenuItem
    Friend WithEvents DeveloperToolsMenu As ToolStripDropDownButton
    Friend WithEvents SourceCode As ToolStripMenuItem
    Friend WithEvents AddressBar As ComboBox
    Friend WithEvents AddPrivateWindowMenu As ToolStripButton
End Class
