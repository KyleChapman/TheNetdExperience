<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile2Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile2SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColour = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourBrown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourGainsboro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourGray = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourMintCream = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourOrange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourPurple = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourSalmon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourWhite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushColourYellow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileHorizontally = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileVertically = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowNewWhiteboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowNewTicTacToe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripNewWhiteboard = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewTicTacToe = New System.Windows.Forms.ToolStripButton()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopMenu.SuspendLayout()
        Me.tsTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile2, Me.mnuEdit, Me.BrushToolStripMenuItem, Me.mnuWindow})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(784, 24)
        Me.mnuTopMenu.TabIndex = 1
        '
        'mnuFile2
        '
        Me.mnuFile2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile2Save, Me.mnuFile2SaveAs, Me.mnuFileClose})
        Me.mnuFile2.Name = "mnuFile2"
        Me.mnuFile2.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile2.Text = "&File"
        '
        'mnuFile2Save
        '
        Me.mnuFile2Save.Name = "mnuFile2Save"
        Me.mnuFile2Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFile2Save.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile2Save.Text = "&Save"
        '
        'mnuFile2SaveAs
        '
        Me.mnuFile2SaveAs.Name = "mnuFile2SaveAs"
        Me.mnuFile2SaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile2SaveAs.Text = "Save &As..."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'BrushToolStripMenuItem
        '
        Me.BrushToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseSizeToolStripMenuItem, Me.DecreaseSizeToolStripMenuItem, Me.mnuBrushColour})
        Me.BrushToolStripMenuItem.Name = "BrushToolStripMenuItem"
        Me.BrushToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BrushToolStripMenuItem.Text = "&Brush"
        '
        'IncreaseSizeToolStripMenuItem
        '
        Me.IncreaseSizeToolStripMenuItem.Name = "IncreaseSizeToolStripMenuItem"
        Me.IncreaseSizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IncreaseSizeToolStripMenuItem.Text = "Increase Size"
        '
        'DecreaseSizeToolStripMenuItem
        '
        Me.DecreaseSizeToolStripMenuItem.Name = "DecreaseSizeToolStripMenuItem"
        Me.DecreaseSizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DecreaseSizeToolStripMenuItem.Text = "Decrease Size"
        '
        'mnuBrushColour
        '
        Me.mnuBrushColour.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrushColourBlack, Me.mnuBrushColourBlue, Me.mnuBrushColourBrown, Me.mnuBrushColourGainsboro, Me.mnuBrushColourGray, Me.mnuBrushColourMintCream, Me.mnuBrushColourOrange, Me.mnuBrushColourPurple, Me.mnuBrushColourRed, Me.mnuBrushColourSalmon, Me.mnuBrushColourWhite, Me.mnuBrushColourYellow})
        Me.mnuBrushColour.Name = "mnuBrushColour"
        Me.mnuBrushColour.Size = New System.Drawing.Size(152, 22)
        Me.mnuBrushColour.Text = "&Colour"
        '
        'mnuBrushColourBlack
        '
        Me.mnuBrushColourBlack.Name = "mnuBrushColourBlack"
        Me.mnuBrushColourBlack.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBrushColourBlack.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourBlack.Text = "Black"
        '
        'mnuBrushColourBlue
        '
        Me.mnuBrushColourBlue.Name = "mnuBrushColourBlue"
        Me.mnuBrushColourBlue.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourBlue.Text = "Blue"
        '
        'mnuBrushColourBrown
        '
        Me.mnuBrushColourBrown.Name = "mnuBrushColourBrown"
        Me.mnuBrushColourBrown.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourBrown.Text = "Brown"
        '
        'mnuBrushColourGainsboro
        '
        Me.mnuBrushColourGainsboro.Name = "mnuBrushColourGainsboro"
        Me.mnuBrushColourGainsboro.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourGainsboro.Text = "Gainsboro"
        '
        'mnuBrushColourGray
        '
        Me.mnuBrushColourGray.Name = "mnuBrushColourGray"
        Me.mnuBrushColourGray.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourGray.Text = "Gray"
        '
        'mnuBrushColourMintCream
        '
        Me.mnuBrushColourMintCream.Name = "mnuBrushColourMintCream"
        Me.mnuBrushColourMintCream.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourMintCream.Text = "MintCream"
        '
        'mnuBrushColourOrange
        '
        Me.mnuBrushColourOrange.Name = "mnuBrushColourOrange"
        Me.mnuBrushColourOrange.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourOrange.Text = "Orange"
        '
        'mnuBrushColourPurple
        '
        Me.mnuBrushColourPurple.Name = "mnuBrushColourPurple"
        Me.mnuBrushColourPurple.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourPurple.Text = "Purple"
        '
        'mnuBrushColourRed
        '
        Me.mnuBrushColourRed.Name = "mnuBrushColourRed"
        Me.mnuBrushColourRed.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourRed.Text = "Red"
        '
        'mnuBrushColourSalmon
        '
        Me.mnuBrushColourSalmon.Name = "mnuBrushColourSalmon"
        Me.mnuBrushColourSalmon.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourSalmon.Text = "Salmon"
        '
        'mnuBrushColourWhite
        '
        Me.mnuBrushColourWhite.Name = "mnuBrushColourWhite"
        Me.mnuBrushColourWhite.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.mnuBrushColourWhite.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourWhite.Text = "White"
        '
        'mnuBrushColourYellow
        '
        Me.mnuBrushColourYellow.Name = "mnuBrushColourYellow"
        Me.mnuBrushColourYellow.Size = New System.Drawing.Size(150, 22)
        Me.mnuBrushColourYellow.Text = "Yellow"
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileHorizontally, Me.mnuWindowTileVertically, Me.ToolStripSeparator1, Me.mnuWindowNewWhiteboard, Me.mnuWindowNewTicTacToe})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(63, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(210, 22)
        Me.mnuWindowCascade.Text = "&Cascade"
        '
        'mnuWindowTileHorizontally
        '
        Me.mnuWindowTileHorizontally.Name = "mnuWindowTileHorizontally"
        Me.mnuWindowTileHorizontally.Size = New System.Drawing.Size(210, 22)
        Me.mnuWindowTileHorizontally.Text = "Tile &Horizontally"
        '
        'mnuWindowTileVertically
        '
        Me.mnuWindowTileVertically.Name = "mnuWindowTileVertically"
        Me.mnuWindowTileVertically.Size = New System.Drawing.Size(210, 22)
        Me.mnuWindowTileVertically.Text = "Tile &Vertically"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'mnuWindowNewWhiteboard
        '
        Me.mnuWindowNewWhiteboard.Image = Global.TheNetdExperience.My.Resources.Resources.Whiteboard
        Me.mnuWindowNewWhiteboard.Name = "mnuWindowNewWhiteboard"
        Me.mnuWindowNewWhiteboard.Size = New System.Drawing.Size(210, 22)
        Me.mnuWindowNewWhiteboard.Text = "New &Whiteboard Window"
        '
        'mnuWindowNewTicTacToe
        '
        Me.mnuWindowNewTicTacToe.Image = Global.TheNetdExperience.My.Resources.Resources.TacTacToe
        Me.mnuWindowNewTicTacToe.Name = "mnuWindowNewTicTacToe"
        Me.mnuWindowNewTicTacToe.Size = New System.Drawing.Size(210, 22)
        Me.mnuWindowNewTicTacToe.Text = "New &TicTacToe Window"
        '
        'tsTools
        '
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripNewWhiteboard, Me.btnToolStripNewTicTacToe})
        Me.tsTools.Location = New System.Drawing.Point(0, 24)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(784, 25)
        Me.tsTools.TabIndex = 2
        '
        'btnToolStripNewWhiteboard
        '
        Me.btnToolStripNewWhiteboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewWhiteboard.Image = Global.TheNetdExperience.My.Resources.Resources.Whiteboard
        Me.btnToolStripNewWhiteboard.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewWhiteboard.Name = "btnToolStripNewWhiteboard"
        Me.btnToolStripNewWhiteboard.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripNewWhiteboard.Text = "ToolStripButton1"
        '
        'btnToolStripNewTicTacToe
        '
        Me.btnToolStripNewTicTacToe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewTicTacToe.Image = Global.TheNetdExperience.My.Resources.Resources.TacTacToe
        Me.btnToolStripNewTicTacToe.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewTicTacToe.Name = "btnToolStripNewTicTacToe"
        Me.btnToolStripNewTicTacToe.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripNewTicTacToe.Text = "ToolStripButton1"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(32, 19)
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileSaveAs.Text = "Save &As..."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileClose.Text = "&Close"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.tsTools)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuTopMenu
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The NETD 2202 Experience"
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopMenu As MenuStrip
    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents mnuWindow As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontally As ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertically As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuWindowNewWhiteboard As ToolStripMenuItem
    Friend WithEvents mnuWindowNewTicTacToe As ToolStripMenuItem
    Friend WithEvents btnToolStripNewWhiteboard As ToolStripButton
    Friend WithEvents btnToolStripNewTicTacToe As ToolStripButton
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents BrushToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuFile2 As ToolStripMenuItem
    Friend WithEvents mnuFile2Save As ToolStripMenuItem
    Friend WithEvents mnuFile2SaveAs As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents IncreaseSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuBrushColour As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBlack As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBlue As ToolStripMenuItem
    Friend WithEvents mnuBrushColourBrown As ToolStripMenuItem
    Friend WithEvents mnuBrushColourGainsboro As ToolStripMenuItem
    Friend WithEvents mnuBrushColourGray As ToolStripMenuItem
    Friend WithEvents mnuBrushColourMintCream As ToolStripMenuItem
    Friend WithEvents mnuBrushColourOrange As ToolStripMenuItem
    Friend WithEvents mnuBrushColourPurple As ToolStripMenuItem
    Friend WithEvents mnuBrushColourRed As ToolStripMenuItem
    Friend WithEvents mnuBrushColourSalmon As ToolStripMenuItem
    Friend WithEvents mnuBrushColourWhite As ToolStripMenuItem
    Friend WithEvents mnuBrushColourYellow As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
End Class
