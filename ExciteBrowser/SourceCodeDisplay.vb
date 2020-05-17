Imports System.Net

Public Class SourceCodeDisplay
    Public Property StringPass As String
    Private Sub SourceCodeDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim sourceString As String = New System.Net.WebClient().DownloadString(StringPass)
            SourceCodeRichTextBox.Text = sourceString
        Catch
            MessageBox.Show("The request was aborted: Could not create SSL/TLS secure channel.")
            Me.Close()
        End Try
    End Sub
End Class