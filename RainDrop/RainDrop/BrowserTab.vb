Public Class BrowserTab
    Private Sub BrowserTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Menu.Hide()
        SiteLoadIndicatorLoading.Hide()
        MenuClose.Hide()
        Me.BackColor = Color.White
        SearchEngineSelector.Items.Add("Google")
        SearchEngineSelector.Items.Add("Yahoo")
        SearchEngineSelector.Items.Add("Ask")
        SearchEngineSelector.Items.Add("Bing")
        SearchEngineSelector.Items.Add("Youtube")
        SearchEngineSelector.Items.Add("Blinkx")
        SearchEngineSelector.Items.Add("Amazon")
        SearchEngineSelector.Items.Add("Hulu")
        SearchEngineSelector.Items.Add("AskKids")
        SearchEngineSelector.Items.Add("FactMonster")
        SearchEngineSelector.Items.Add("Craigslist")
        SearchEngineSelector.Items.Add("Wikipedia")
        SearchEngineSelector.Items.Add("eBay")
        SearchEngineSelector.Items.Add("Comcast Toolbar Search")
        SearchEngineSelector.Items.Add("Baidu (Chinese)")
        SearchEngineSelector.Items.Add("Sogou (Chinese)")
        SearchEngineSelector.Items.Add("T-Online (German)")
        SearchEngineSelector.Items.Add("Orange (French)")
        SearchEngineSelector.Items.Add("Naver (Korean)")
    End Sub
    Private Sub AddressBar_KeyDown(sender As Object, e As KeyEventArgs) Handles AddressBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrowsingWindowPanel.Navigate(AddressBar.Text)
        End If
    End Sub

    Private Sub PreviousLink_Click(sender As Object, e As EventArgs) Handles PreviousLink.Click
        BrowsingWindowPanel.GoBack()
    End Sub
    Private Sub NextLink_Click(sender As Object, e As EventArgs) Handles NextLink.Click
        BrowsingWindowPanel.GoForward()
    End Sub
    Private Sub GoToLink_Click(sender As Object, e As EventArgs) Handles GoToLink.Click
        BrowsingWindowPanel.Navigate(AddressBar.Text)
    End Sub
    Private Sub CancelLoading_Click(sender As Object, e As EventArgs) Handles CancelLoading.Click
        BrowsingWindowPanel.Stop()
    End Sub
    Private Sub RefreshSite_Click(sender As Object, e As EventArgs) Handles RefreshSite.Click
        BrowsingWindowPanel.Refresh()
    End Sub
    Private Sub GoToHome_Click(sender As Object, e As EventArgs) Handles GoToHome.Click
        BrowsingWindowPanel.Navigate(My.Settings.HomePageUrl)
    End Sub
    Private Sub DownloadsToolBar_Click(sender As Object, e As EventArgs) Handles BookmarksToolBar.Click
        BrowserControls.BookmarksList.Items.Add(AddressBar.Text)
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        BrowsingWindowPanel.Navigate(SearchBar.Text)
        SearchBar.Items.Add(SearchBar.Text)
    End Sub
    Private Sub MenuClose_Click(sender As Object, e As EventArgs) Handles MenuOpen.Click
        Menu.Show()
        MenuClose.Show()
        MenuOpen.Hide()
    End Sub
    Private Sub MenuOpen_Click(sender As Object, e As EventArgs) Handles MenuClose.Click
        Menu.Hide()
        MenuOpen.Show()
        MenuClose.Hide()
    End Sub
    Private Sub BrowsingWindowPanel_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles BrowsingWindowPanel.Navigating
        SiteLoadIndicatorLoading.Show()
        Menu.Hide()
        SiteLoadIndicatorSuccessfull.Hide()
        NavigationPanel.BackColor = My.Settings.PanelColorNavigating
        Me.Parent.Text = "Loading..."
    End Sub
    Private Sub BrowsingWindowPanel_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles BrowsingWindowPanel.Navigated
        SiteLoadIndicatorLoading.Hide()
        SiteLoadIndicatorSuccessfull.Show()
        AddressBar.Text = BrowsingWindowPanel.Url.ToString
        BrowserControls.HistoryListBox.Items.Add(AddressBar.Text)
        AddressBar.Items.Add(AddressBar.Text)
        NavigationPanel.BackColor = My.Settings.PanelColorNavigated
    End Sub
    Private Sub BrowsingWindowPanel_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles BrowsingWindowPanel.DocumentCompleted
        Me.Parent.Text = BrowsingWindowPanel.DocumentTitle
        SourceCodeDisplay.SourceCodeRichTextBox.Text = BrowsingWindowPanel.DocumentText
    End Sub
    Private Sub AddTabMenu_Click(sender As Object, e As EventArgs) Handles AddTabMenu.Click
        Dim t As New TabPage
        Dim newtab As New BrowserTab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        BrowserWindow.BrowserTab.TabPages.Add(t)
    End Sub
    Private Sub RemoveTabMenu_Click(sender As Object, e As EventArgs) Handles RemoveTabMenu.Click
        BrowserWindow.BrowserTab.TabPages.Remove(BrowserWindow.BrowserTab.SelectedTab)
    End Sub
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs)
        BrowserControls.Show()
        Menu.Hide()
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub CustomizeBackGroundColor_Click(sender As Object, e As EventArgs) Handles CustomizeBackGroundColor.Click
        Menu.Hide()
        ColorDialog1.ShowDialog()
        BrowserWindow.BackColor = ColorDialog1.Color
        PreviousLink.BackColor = ColorDialog1.Color
        NextLink.BackColor = ColorDialog1.Color
        GoToLink.BackColor = ColorDialog1.Color
        CancelLoading.BackColor = ColorDialog1.Color
        RefreshSite.BackColor = ColorDialog1.Color
        GoToHome.BackColor = ColorDialog1.Color
        BookmarksToolBar.BackColor = ColorDialog1.Color
        Search.BackColor = ColorDialog1.Color
        MenuOpen.BackColor = ColorDialog1.Color
        AddressLabel.ForeColor = ColorDialog1.Color
    End Sub
    Private Sub CustomizeMenuBackGroundColor_Click(sender As Object, e As EventArgs) Handles CustomizeMenuBackGroundColor.Click
        ColorDialog2.ShowDialog()
        NavigationPanel.BackColor = ColorDialog2.Color
    End Sub
    Private Sub CustomizeNavigatingPanelColor_Click(sender As Object, e As EventArgs) Handles CustomizeNavigatingPanelColor.Click
        ColorDialog3.ShowDialog()
        My.Settings.PanelColorNavigating = ColorDialog3.Color
    End Sub
    Private Sub CustomizeNavigatedPanelColor_Click(sender As Object, e As EventArgs) Handles CustomizeNavigatedPanelColor.Click
        ColorDialog4.ShowDialog()
        My.Settings.PanelColorNavigated = ColorDialog4.Color
    End Sub
    Private Sub NewWindowMenu_Click(sender As Object, e As EventArgs) Handles NewWindowMenu.Click
        Dim f As New BrowserWindow
        f.Show()
    End Sub
    Private Sub HistoryMenu_Click(sender As Object, e As EventArgs) Handles HistoryMenu.Click
        BrowserControls.Show()
    End Sub
    Private Sub DownloadsMenu_Click(sender As Object, e As EventArgs) Handles DownloadsMenu.Click
        Dim userRoot As String
        Dim downloadFolder As String
        userRoot = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        downloadFolder = userRoot + "\Downloads"
        Process.Start(downloadFolder)
    End Sub
    Private Sub BookmarksMenu_Click(sender As Object, e As EventArgs) Handles BookmarksMenu.Click
        BrowserControls.Show()
    End Sub
    Private Sub HtmlEditor_Click(sender As Object, e As EventArgs) Handles HtmlEditor.Click
        HtmlEditorForm.Show()
    End Sub
    Private Sub AddPrivateWindowMenu_Click(sender As Object, e As EventArgs) Handles AddPrivateWindowMenu.Click
        PrivateWindow.Show()
    End Sub
    Private Sub CloseWindow_Click(sender As Object, e As EventArgs) Handles CloseWindow.Click
        BrowserWindow.Close()
    End Sub
    Private Sub SourceCode_Click(sender As Object, e As EventArgs) Handles SourceCode.Click
        SourceCodeDisplay.Show()
    End Sub
    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        AboutRainDrop.Show()
    End Sub
End Class