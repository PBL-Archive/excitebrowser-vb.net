Public Class HtmlEditorForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub HTMLEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HtmlRichTextViewer.DocumentText = HtmlRichTextEditor.Text
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles HtmlRichTextEditor.TextChanged
        HtmlRichTextViewer.DocumentText = HtmlRichTextEditor.Text
    End Sub
End Class