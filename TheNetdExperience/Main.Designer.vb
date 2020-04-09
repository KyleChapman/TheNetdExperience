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
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrush = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushIncreaseSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrushDecreaseSize = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuWindowNewAwesomness = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowNewTicTacToe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowNewCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowNewWhiteboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripSave = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnToolStripCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripPaste = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnToolStripAwesomness = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewTicTacToe = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewCarList = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewWhiteboard = New System.Windows.Forms.ToolStripButton()
        Me.mnuTopMenu.SuspendLayout()
        Me.tsTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuBrush, Me.mnuWindow})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(784, 24)
        Me.mnuTopMenu.TabIndex = 1
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = Global.TheNetdExperience.My.Resources.Resources.Save
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(138, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(138, 22)
        Me.mnuFileSaveAs.Text = "Save &As..."
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Image = Global.TheNetdExperience.My.Resources.Resources.Close
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(138, 22)
        Me.mnuFileClose.Text = "&Close"
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
        Me.mnuEditCopy.Image = Global.TheNetdExperience.My.Resources.Resources.Copy
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditCopy.Text = "&Copy"
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = Global.TheNetdExperience.My.Resources.Resources.Paste
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.mnuEditPaste.Text = "&Paste"
        '
        'mnuBrush
        '
        Me.mnuBrush.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrushIncreaseSize, Me.mnuBrushDecreaseSize, Me.mnuBrushColour})
        Me.mnuBrush.Name = "mnuBrush"
        Me.mnuBrush.Size = New System.Drawing.Size(49, 20)
        Me.mnuBrush.Text = "&Brush"
        '
        'mnuBrushIncreaseSize
        '
        Me.mnuBrushIncreaseSize.Name = "mnuBrushIncreaseSize"
        Me.mnuBrushIncreaseSize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.mnuBrushIncreaseSize.Size = New System.Drawing.Size(209, 22)
        Me.mnuBrushIncreaseSize.Text = "Increase Size"
        '
        'mnuBrushDecreaseSize
        '
        Me.mnuBrushDecreaseSize.Name = "mnuBrushDecreaseSize"
        Me.mnuBrushDecreaseSize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.mnuBrushDecreaseSize.Size = New System.Drawing.Size(209, 22)
        Me.mnuBrushDecreaseSize.Text = "Decrease Size"
        '
        'mnuBrushColour
        '
        Me.mnuBrushColour.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrushColourBlack, Me.mnuBrushColourBlue, Me.mnuBrushColourBrown, Me.mnuBrushColourGainsboro, Me.mnuBrushColourGray, Me.mnuBrushColourMintCream, Me.mnuBrushColourOrange, Me.mnuBrushColourPurple, Me.mnuBrushColourRed, Me.mnuBrushColourSalmon, Me.mnuBrushColourWhite, Me.mnuBrushColourYellow})
        Me.mnuBrushColour.Name = "mnuBrushColour"
        Me.mnuBrushColour.Size = New System.Drawing.Size(209, 22)
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
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileHorizontally, Me.mnuWindowTileVertically, Me.ToolStripSeparator1, Me.mnuWindowNewAwesomness, Me.mnuWindowNewTicTacToe, Me.mnuWindowNewCarList, Me.mnuWindowNewWhiteboard})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(63, 20)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Image = Global.TheNetdExperience.My.Resources.Resources.Cascade
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowCascade.Text = "&Cascade"
        '
        'mnuWindowTileHorizontally
        '
        Me.mnuWindowTileHorizontally.Image = Global.TheNetdExperience.My.Resources.Resources.TileHorizontal
        Me.mnuWindowTileHorizontally.Name = "mnuWindowTileHorizontally"
        Me.mnuWindowTileHorizontally.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowTileHorizontally.Text = "Tile &Horizontally"
        '
        'mnuWindowTileVertically
        '
        Me.mnuWindowTileVertically.Image = Global.TheNetdExperience.My.Resources.Resources.TileVertical
        Me.mnuWindowTileVertically.Name = "mnuWindowTileVertically"
        Me.mnuWindowTileVertically.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowTileVertically.Text = "Tile &Vertically"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'mnuWindowNewAwesomness
        '
        Me.mnuWindowNewAwesomness.Image = Global.TheNetdExperience.My.Resources.Resources.You
        Me.mnuWindowNewAwesomness.Name = "mnuWindowNewAwesomness"
        Me.mnuWindowNewAwesomness.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowNewAwesomness.Text = "New &Awesomeness Window"
        Me.mnuWindowNewAwesomness.ToolTipText = "Open a new Awesomeness window"
        '
        'mnuWindowNewTicTacToe
        '
        Me.mnuWindowNewTicTacToe.Image = Global.TheNetdExperience.My.Resources.Resources.TacTacToe
        Me.mnuWindowNewTicTacToe.Name = "mnuWindowNewTicTacToe"
        Me.mnuWindowNewTicTacToe.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowNewTicTacToe.Text = "New &Tic Tac Toe Window"
        Me.mnuWindowNewTicTacToe.ToolTipText = "Open a new Tic Tac Toe window"
        '
        'mnuWindowNewCarList
        '
        Me.mnuWindowNewCarList.Image = Global.TheNetdExperience.My.Resources.Resources.CarInfo
        Me.mnuWindowNewCarList.Name = "mnuWindowNewCarList"
        Me.mnuWindowNewCarList.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowNewCarList.Text = "Open Car &List Window"
        Me.mnuWindowNewCarList.ToolTipText = "Open Car List Window"
        '
        'mnuWindowNewWhiteboard
        '
        Me.mnuWindowNewWhiteboard.Image = Global.TheNetdExperience.My.Resources.Resources.Whiteboard
        Me.mnuWindowNewWhiteboard.Name = "mnuWindowNewWhiteboard"
        Me.mnuWindowNewWhiteboard.Size = New System.Drawing.Size(223, 22)
        Me.mnuWindowNewWhiteboard.Text = "New &Whiteboard Window"
        Me.mnuWindowNewWhiteboard.ToolTipText = "Open a new Whiteboard window"
        '
        'tsTools
        '
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripSave, Me.btnToolStripClose, Me.ToolStripSeparator2, Me.btnToolStripCopy, Me.btnToolStripPaste, Me.ToolStripSeparator3, Me.btnToolStripAwesomness, Me.btnToolStripNewTicTacToe, Me.btnToolStripNewCarList, Me.btnToolStripNewWhiteboard})
        Me.tsTools.Location = New System.Drawing.Point(0, 24)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(784, 25)
        Me.tsTools.TabIndex = 2
        '
        'btnToolStripSave
        '
        Me.btnToolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripSave.Image = Global.TheNetdExperience.My.Resources.Resources.Save
        Me.btnToolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripSave.Name = "btnToolStripSave"
        Me.btnToolStripSave.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripSave.Text = "Save"
        '
        'btnToolStripClose
        '
        Me.btnToolStripClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripClose.Image = Global.TheNetdExperience.My.Resources.Resources.Close
        Me.btnToolStripClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripClose.Name = "btnToolStripClose"
        Me.btnToolStripClose.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripClose.Text = "Close"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnToolStripCopy
        '
        Me.btnToolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripCopy.Image = Global.TheNetdExperience.My.Resources.Resources.Copy
        Me.btnToolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripCopy.Name = "btnToolStripCopy"
        Me.btnToolStripCopy.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripCopy.Text = "Copy"
        '
        'btnToolStripPaste
        '
        Me.btnToolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripPaste.Image = Global.TheNetdExperience.My.Resources.Resources.Paste
        Me.btnToolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripPaste.Name = "btnToolStripPaste"
        Me.btnToolStripPaste.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripPaste.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnToolStripAwesomness
        '
        Me.btnToolStripAwesomness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripAwesomness.Image = Global.TheNetdExperience.My.Resources.Resources.You
        Me.btnToolStripAwesomness.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripAwesomness.Name = "btnToolStripAwesomness"
        Me.btnToolStripAwesomness.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripAwesomness.Text = "Awesomeness"
        Me.btnToolStripAwesomness.ToolTipText = "Click to open a new Awesomeness window"
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
        'btnToolStripNewCarList
        '
        Me.btnToolStripNewCarList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewCarList.Image = Global.TheNetdExperience.My.Resources.Resources.CarInfo
        Me.btnToolStripNewCarList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewCarList.Name = "btnToolStripNewCarList"
        Me.btnToolStripNewCarList.Size = New System.Drawing.Size(23, 22)
        Me.btnToolStripNewCarList.Text = "ToolStripButton1"
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
    Friend WithEvents mnuBrush As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuBrushIncreaseSize As ToolStripMenuItem
    Friend WithEvents mnuBrushDecreaseSize As ToolStripMenuItem
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
    Friend WithEvents mnuWindowNewCarList As ToolStripMenuItem
    Friend WithEvents btnToolStripNewCarList As ToolStripButton
    Friend WithEvents mnuWindowNewAwesomness As ToolStripMenuItem
    Friend WithEvents btnToolStripSave As ToolStripButton
    Friend WithEvents btnToolStripClose As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnToolStripCopy As ToolStripButton
    Friend WithEvents btnToolStripPaste As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnToolStripAwesomness As ToolStripButton
End Class
