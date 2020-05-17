<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SourceCodeDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SourceCodeDisplay))
        Me.SourceCodeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'SourceCodeRichTextBox
        '
        Me.SourceCodeRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceCodeRichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.SourceCodeRichTextBox.Name = "SourceCodeRichTextBox"
        Me.SourceCodeRichTextBox.Size = New System.Drawing.Size(782, 953)
        Me.SourceCodeRichTextBox.TabIndex = 0
        Me.SourceCodeRichTextBox.Text = ""
        '
        'SourceCodeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 953)
        Me.Controls.Add(Me.SourceCodeRichTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SourceCodeDisplay"
        Me.Text = "Source Code"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SourceCodeRichTextBox As RichTextBox
End Class
