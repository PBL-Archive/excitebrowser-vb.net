<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HtmlEditorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HtmlEditorForm))
        Me.HtmlRichTextEditor = New System.Windows.Forms.RichTextBox()
        Me.HtmlRichTextViewer = New System.Windows.Forms.WebBrowser()
        Me.HtmlFormIcon = New System.Windows.Forms.Button()
        Me.HtmlEditorTitleBar = New System.Windows.Forms.Panel()
        Me.InstructionLabel = New System.Windows.Forms.Label()
        Me.HtmlEditorTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'HtmlRichTextEditor
        '
        Me.HtmlRichTextEditor.Location = New System.Drawing.Point(0, 30)
        Me.HtmlRichTextEditor.Margin = New System.Windows.Forms.Padding(4)
        Me.HtmlRichTextEditor.Name = "HtmlRichTextEditor"
        Me.HtmlRichTextEditor.Size = New System.Drawing.Size(400, 800)
        Me.HtmlRichTextEditor.TabIndex = 6
        Me.HtmlRichTextEditor.Text = ""
        '
        'HtmlRichTextViewer
        '
        Me.HtmlRichTextViewer.Location = New System.Drawing.Point(400, 30)
        Me.HtmlRichTextViewer.Margin = New System.Windows.Forms.Padding(4)
        Me.HtmlRichTextViewer.MinimumSize = New System.Drawing.Size(27, 25)
        Me.HtmlRichTextViewer.Name = "HtmlRichTextViewer"
        Me.HtmlRichTextViewer.Size = New System.Drawing.Size(400, 800)
        Me.HtmlRichTextViewer.TabIndex = 7
        '
        'HtmlFormIcon
        '
        Me.HtmlFormIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HtmlFormIcon.BackgroundImage = CType(resources.GetObject("HtmlFormIcon.BackgroundImage"), System.Drawing.Image)
        Me.HtmlFormIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HtmlFormIcon.FlatAppearance.BorderSize = 0
        Me.HtmlFormIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HtmlFormIcon.Location = New System.Drawing.Point(4, 3)
        Me.HtmlFormIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.HtmlFormIcon.Name = "HtmlFormIcon"
        Me.HtmlFormIcon.Size = New System.Drawing.Size(24, 24)
        Me.HtmlFormIcon.TabIndex = 3
        Me.HtmlFormIcon.UseVisualStyleBackColor = True
        '
        'HtmlEditorTitleBar
        '
        Me.HtmlEditorTitleBar.Controls.Add(Me.InstructionLabel)
        Me.HtmlEditorTitleBar.Controls.Add(Me.HtmlFormIcon)
        Me.HtmlEditorTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.HtmlEditorTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.HtmlEditorTitleBar.Margin = New System.Windows.Forms.Padding(4)
        Me.HtmlEditorTitleBar.Name = "HtmlEditorTitleBar"
        Me.HtmlEditorTitleBar.Size = New System.Drawing.Size(800, 30)
        Me.HtmlEditorTitleBar.TabIndex = 5
        '
        'InstructionLabel
        '
        Me.InstructionLabel.Location = New System.Drawing.Point(35, 0)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(762, 30)
        Me.InstructionLabel.TabIndex = 4
        Me.InstructionLabel.Text = "Type your HTML Code on left panel and see output on right panel."
        '
        'HtmlEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 830)
        Me.Controls.Add(Me.HtmlRichTextViewer)
        Me.Controls.Add(Me.HtmlRichTextEditor)
        Me.Controls.Add(Me.HtmlEditorTitleBar)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HtmlEditorForm"
        Me.Text = "HTML Editor"
        Me.HtmlEditorTitleBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HtmlRichTextEditor As RichTextBox
    Friend WithEvents HtmlRichTextViewer As WebBrowser
    Friend WithEvents HtmlFormIcon As Button
    Friend WithEvents HtmlEditorTitleBar As Panel
    Friend WithEvents InstructionLabel As Label
End Class
