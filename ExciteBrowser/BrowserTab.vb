Public Class BrowserTab
    Private Sub BrowserTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BrowserMenu.Hide()
        SiteLoadIndicatorLoading.Hide()
        MenuClose.Hide()
        Me.BackColor = Color.White
        SearchEngineSelector.Items.Add("Google")
        SearchEngineSelector.Items.Add("Bing")
        SearchEngineSelector.Items.Add("DuckDuckGo")
        SearchEngineSelector.Items.Add("YouTube")
        SearchEngineSelector.SelectedItem = "Google"
        'SearchEngineSelector.Items.Add("Yahoo")
        'SearchEngineSelector.Items.Add("Ask")
        'SearchEngineSelector.Items.Add("Blinkx")
        'SearchEngineSelector.Items.Add("Amazon")
        'SearchEngineSelector.Items.Add("Hulu")
        'SearchEngineSelector.Items.Add("AskKids")
        'SearchEngineSelector.Items.Add("FactMonster")
        'SearchEngineSelector.Items.Add("Craigslist")
        'SearchEngineSelector.Items.Add("Wikipedia")
        'SearchEngineSelector.Items.Add("eBay")
        'SearchEngineSelector.Items.Add("Comcast Toolbar Search")
        'SearchEngineSelector.Items.Add("Baidu (Chinese)")
        'SearchEngineSelector.Items.Add("Sogou (Chinese)")
        'SearchEngineSelector.Items.Add("T-Online (German)")
        'SearchEngineSelector.Items.Add("Orange (French)")
        'SearchEngineSelector.Items.Add("Naver (Korean)")
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
    Private Sub BookmarksToolBar_Click(sender As Object, e As EventArgs) Handles BookmarksToolBar.Click
        If AddressBar.Text = "about:blank" Or AddressBar.Text = "" Then
            MessageBox.Show("Can't add blank link to Bookmarks!")
        Else
            BrowserControls.BookmarksList.Items.Add(AddressBar.Text)
        End If
    End Sub
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Dim prestring As String
        prestring = ""
        If SearchEngineSelector.SelectedItem = "Google" Then
            prestring = "https://www.google.com/search?q="
        ElseIf SearchEngineSelector.SelectedItem = "Bing" Then
            prestring = "https://www.bing.com/search?q="
        ElseIf SearchEngineSelector.SelectedItem = "DuckDuckGo" Then
            prestring = "https://duckduckgo.com/?q="
        ElseIf SearchEngineSelector.SelectedItem = "YouTube" Then
            prestring = "https://www.youtube.com/results?search_query="
        ElseIf SearchEngineSelector.SelectedItem = "" Then
            prestring = ""
        End If
        If prestring = "" Then
            MessageBox.Show("Please select any search engine before using direct Search")
        Else
            BrowsingWindowPanel.Navigate(prestring + SearchBar.Text)
        End If
        SearchBar.Items.Add(SearchBar.Text)
    End Sub
    Private Sub SearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim prestring As String
            prestring = ""
            If SearchEngineSelector.SelectedItem = "Google" Then
                prestring = "https://www.google.com/search?q="
            ElseIf SearchEngineSelector.SelectedItem = "Bing" Then
                prestring = "https://www.bing.com/search?q="
            ElseIf SearchEngineSelector.SelectedItem = "DuckDuckGo" Then
                prestring = "https://duckduckgo.com/?q="
            ElseIf SearchEngineSelector.SelectedItem = "YouTube" Then
                prestring = "https://www.youtube.com/results?search_query="
            ElseIf SearchEngineSelector.SelectedItem = "" Then
                prestring = ""
            End If
            If prestring = "" Then
                MessageBox.Show("Please select any search engine before using direct Search")
            Else
                BrowsingWindowPanel.Navigate(prestring + SearchBar.Text)
            End If
            SearchBar.Items.Add(SearchBar.Text)
        End If
    End Sub
    Private Sub MenuClose_Click(sender As Object, e As EventArgs) Handles MenuOpen.Click
        BrowserMenu.Show()
        MenuClose.Show()
        MenuOpen.Hide()
    End Sub
    Private Sub MenuOpen_Click(sender As Object, e As EventArgs) Handles MenuClose.Click
        BrowserMenu.Hide()
        MenuOpen.Show()
        MenuClose.Hide()
    End Sub
    Private Sub BrowsingWindowPanel_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles BrowsingWindowPanel.Navigating
        SiteLoadIndicatorLoading.Show()
        BrowserMenu.Hide()
        SiteLoadIndicatorSuccessfull.Hide()
        NavigationPanel.BackColor = My.Settings.PanelColorNavigating
        Me.Parent.Text = My.Resources.Strings.Loading
    End Sub
    Private Sub BrowsingWindowPanel_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles BrowsingWindowPanel.Navigated
        SiteLoadIndicatorLoading.Hide()
        SiteLoadIndicatorSuccessfull.Show()
        AddressBar.Text = BrowsingWindowPanel.Url.ToString
        If AddressBar.Text = "about:blank" Or AddressBar.Text = "" Then

        Else
            BrowserControls.HistoryListBox.Items.Add(AddressBar.Text)
            AddressBar.Items.Add(AddressBar.Text)
        End If
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
        BrowserMenu.Hide()
    End Sub
    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Private Sub CustomizeBackGroundColor_Click(sender As Object, e As EventArgs) Handles CustomizeBackGroundColor.Click
        BrowserMenu.Hide()
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
        Dim newWindow As BrowserWindow
        newWindow = BrowserWindow
        newWindow.Show()
    End Sub
    Private Sub HistoryMenu_Click(sender As Object, e As EventArgs) Handles HistoryMenu.Click
        BrowserControls.Show()
    End Sub
    Private Sub DownloadsMenu_Click(sender As Object, e As EventArgs)
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
        Dim scdf As New SourceCodeDisplay
        scdf.StringPass = AddressBar.Text
        scdf.Show()
    End Sub
End Class
