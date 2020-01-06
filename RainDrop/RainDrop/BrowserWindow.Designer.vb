<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BrowserWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BrowserWindow))
        Me.rightMouseClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddTabRightMouseClickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveTabRightMouseClickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowRightMouseClickMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserTab = New System.Windows.Forms.TabControl()
        Me.rightMouseClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'rightMouseClickMenu
        '
        Me.rightMouseClickMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rightMouseClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTabRightMouseClickMenu, Me.RemoveTabRightMouseClickMenu, Me.NewWindowRightMouseClickMenu})
        Me.rightMouseClickMenu.Name = "ContextMenuStrip1"
        Me.rightMouseClickMenu.Size = New System.Drawing.Size(225, 82)
        '
        'AddTabRightMouseClickMenu
        '
        Me.AddTabRightMouseClickMenu.Image = CType(resources.GetObject("AddTabRightMouseClickMenu.Image"), System.Drawing.Image)
        Me.AddTabRightMouseClickMenu.Name = "AddTabRightMouseClickMenu"
        Me.AddTabRightMouseClickMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AddTabRightMouseClickMenu.Size = New System.Drawing.Size(224, 26)
        Me.AddTabRightMouseClickMenu.Text = "Add Tab"
        '
        'RemoveTabRightMouseClickMenu
        '
        Me.RemoveTabRightMouseClickMenu.Image = CType(resources.GetObject("RemoveTabRightMouseClickMenu.Image"), System.Drawing.Image)
        Me.RemoveTabRightMouseClickMenu.Name = "RemoveTabRightMouseClickMenu"
        Me.RemoveTabRightMouseClickMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.RemoveTabRightMouseClickMenu.Size = New System.Drawing.Size(224, 26)
        Me.RemoveTabRightMouseClickMenu.Text = "Remove Tab"
        '
        'NewWindowRightMouseClickMenu
        '
        Me.NewWindowRightMouseClickMenu.Image = CType(resources.GetObject("NewWindowRightMouseClickMenu.Image"), System.Drawing.Image)
        Me.NewWindowRightMouseClickMenu.Name = "NewWindowRightMouseClickMenu"
        Me.NewWindowRightMouseClickMenu.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWindowRightMouseClickMenu.Size = New System.Drawing.Size(224, 26)
        Me.NewWindowRightMouseClickMenu.Text = "New Window"
        '
        'BrowserTab
        '
        Me.BrowserTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserTab.Location = New System.Drawing.Point(0, 0)
        Me.BrowserTab.Name = "BrowserTab"
        Me.BrowserTab.SelectedIndex = 0
        Me.BrowserTab.Size = New System.Drawing.Size(952, 572)
        Me.BrowserTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.BrowserTab.TabIndex = 1
        '
        'BrowserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 572)
        Me.ContextMenuStrip = Me.rightMouseClickMenu
        Me.Controls.Add(Me.BrowserTab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(951, 570)
        Me.Name = "BrowserWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RainDrop Browser"
        Me.rightMouseClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rightMouseClickMenu As ContextMenuStrip
    Friend WithEvents AddTabRightMouseClickMenu As ToolStripMenuItem
    Friend WithEvents RemoveTabRightMouseClickMenu As ToolStripMenuItem
    Friend WithEvents BrowserTab As TabControl
    Friend WithEvents NewWindowRightMouseClickMenu As ToolStripMenuItem
End Class
