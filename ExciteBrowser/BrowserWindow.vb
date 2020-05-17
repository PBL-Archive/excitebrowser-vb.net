Public Class BrowserWindow
    Private Sub BrowserWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New TabPage
        Dim newtab As New BrowserTab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Me.BrowserTab.TabPages.Add(t)
    End Sub
    Private Sub AddTabRightMouseClickMenu_Click(sender As Object, e As EventArgs) Handles AddTabRightMouseClickMenu.Click
        Dim t As New TabPage
        Dim newtab As New BrowserTab
        newtab.Show()
        newtab.TopLevel = False
        newtab.Dock = DockStyle.Fill
        t.Controls.Add(newtab)
        Me.BrowserTab.TabPages.Add(t)
    End Sub
    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabRightMouseClickMenu.Click
        Me.BrowserTab.TabPages.Remove(Me.BrowserTab.SelectedTab)
    End Sub
    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowRightMouseClickMenu.Click
        Dim f As New BrowserWindow
        f.Show()
    End Sub
End Class
