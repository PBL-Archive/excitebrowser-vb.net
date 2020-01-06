Public Class BrowserControls
    Private Sub BrowserControls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.History = HistoryListBox.Text
        HistoryListBox.Items.Add(My.Settings.History)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.HomePageName = TextBox1.Text
        My.Settings.HomePageUrl = TextBox2.Text
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        My.Settings.HomePageName = TextBox1.Text
        TextBox2.Text = ""
        My.Settings.HomePageUrl = TextBox2.Text
    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Label15.Text = My.Settings.HomePageName
    End Sub
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Label16.Text = My.Settings.HomePageUrl
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.NewTabPageName = TextBox3.Text
        My.Settings.NewTabPageUrl = TextBox4.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox3.Text = ""
        My.Settings.NewTabPageName = TextBox1.Text
        TextBox4.Text = ""
        My.Settings.NewTabPageUrl = TextBox2.Text
    End Sub
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Label17.Text = My.Settings.NewTabPageName
    End Sub
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Label18.Text = My.Settings.NewTabPageUrl
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles NavigateSelectedLink.Click
        TextBox5.Text = HistoryListBox.GetItemText(HistoryListBox.SelectedItem)
    End Sub
    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox6.Text = BookmarksList.GetItemText(BookmarksList.SelectedItem)
    End Sub
End Class