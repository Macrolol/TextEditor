<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEdit
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
        Me.components = New System.ComponentModel.Container()
        Dim mnuNew As System.Windows.Forms.ToolStripMenuItem
        Me.txtMainBox = New System.Windows.Forms.TextBox()
        Me.mnuMainStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuNew
        '
        mnuNew.Name = "mnuNew"
        mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        mnuNew.Size = New System.Drawing.Size(216, 26)
        mnuNew.Text = "&New"
        mnuNew.ToolTipText = "Create a new document"
        AddHandler mnuNew.Click, AddressOf Me.mnuNew_Click
        '
        'txtMainBox
        '
        Me.txtMainBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMainBox.Location = New System.Drawing.Point(-1, 29)
        Me.txtMainBox.Multiline = True
        Me.txtMainBox.Name = "txtMainBox"
        Me.txtMainBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMainBox.Size = New System.Drawing.Size(803, 422)
        Me.txtMainBox.TabIndex = 0
        '
        'mnuMainStrip
        '
        Me.mnuMainStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuMainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMainStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainStrip.Name = "mnuMainStrip"
        Me.mnuMainStrip.Size = New System.Drawing.Size(800, 28)
        Me.mnuMainStrip.TabIndex = 1
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&FIle"
        Me.mnuFile.ToolTipText = "File menu"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(216, 26)
        Me.mnuOpen.Text = "&Open"
        Me.mnuOpen.ToolTipText = "Open an existing document"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(216, 26)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Save the current document"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(216, 26)
        Me.mnuSaveAs.Text = "Save &As..."
        Me.mnuSaveAs.ToolTipText = "Save the current document under a new name"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(216, 26)
        Me.mnuExit.Text = "E&xit"
        Me.mnuExit.ToolTipText = "Close the program"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Edit menu"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(216, 26)
        Me.mnuCopy.Text = "&Copy"
        Me.mnuCopy.ToolTipText = "Copy the selected text to the clipboard"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(216, 26)
        Me.mnuCut.Text = "Cu&t"
        Me.mnuCut.ToolTipText = "Remove the selected text from the document and save it to the clipboard"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(216, 26)
        Me.mnuPaste.Text = "&Paste"
        Me.mnuPaste.ToolTipText = "Paste the contents of the clipboad into the document"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Help menu"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(216, 26)
        Me.mnuHelpAbout.Text = "About"
        Me.mnuHelpAbout.ToolTipText = "About the program"
        '
        'opdOpen
        '
        Me.opdOpen.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'sfdSaveAs
        '
        Me.sfdSaveAs.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'frmTextEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMainBox)
        Me.Controls.Add(Me.mnuMainStrip)
        Me.MainMenuStrip = Me.mnuMainStrip
        Me.Name = "frmTextEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuMainStrip.ResumeLayout(False)
        Me.mnuMainStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMainBox As TextBox
    Friend WithEvents mnuMainStrip As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
