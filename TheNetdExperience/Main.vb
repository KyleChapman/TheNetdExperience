Public Class frmMain

    ''' <summary>
    ''' Create and display a new whiteboard form instance
    ''' </summary>
    Private Sub ShowNewWhiteboard(sender As Object, e As EventArgs) Handles btnToolStripNewWhiteboard.Click, mnuWindowNewWhiteboard.Click

        Dim myWhiteboard As New frmWhiteboard
        myWhiteboard.MdiParent = Me
        myWhiteboard.Show()

    End Sub

    ''' <summary>
    ''' Create and display a new Tic Tac Toe form instance
    ''' </summary>
    Private Sub ShowNewTicTacToe(sender As Object, e As EventArgs) Handles btnToolStripNewTicTacToe.Click, mnuWindowNewTicTacToe.Click

        Dim myTicTacToe As New frmTicTacToe
        myTicTacToe.MdiParent = Me
        myTicTacToe.Show()

    End Sub

    ''' <summary>
    ''' Create and display a Car List form instance; only one can be shown at a time
    ''' </summary>
    Private Sub ShowCarList(sender As Object, e As EventArgs) Handles btnToolStripNewCarList.Click, mnuWindowNewCarList.Click

        ' Get the current instance of the CarInfo form, if it exists, otherwise make a new one
        Dim myCarList As frmCarInfo = frmCarInfo.Instance

        myCarList.MdiParent = Me    ' Make the new form a child form
        myCarList.Show()            ' Show the new form
        myCarList.Focus()           ' Put focus on the new form

    End Sub

    Private Sub mnuFile2Save_Click(sender As Object, e As EventArgs) Handles mnuFile2Save.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).FileSave()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub

    Private Sub mnuFile2SaveAs_Click(sender As Object, e As EventArgs) Handles mnuFile2SaveAs.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).FileSaveAs()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).EditCopy()
        Else
            MessageBox.Show("Cannot copy from the current selected window")
        End If

    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        If MdiChildren.Count > 0 Then
            ActiveMdiChild.Close()
        Else
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).EditPaste()
        Else
            MessageBox.Show("Cannot paste into the current selected window")
        End If

    End Sub

    Private Sub IncreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseSizeToolStripMenuItem.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).BrushIncrease()
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

    Private Sub DecreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseSizeToolStripMenuItem.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).BrushDecrease()
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub mnuWindowTileHorizontally_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontally.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub mnuWindowTileVertically_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertically.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    ''' <summary>
    ''' Sets the brush in an active whiteboard window to Black
    ''' </summary>
    Private Sub mnuBrushColourBlack_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBlack.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).SetColor(Color.Black)
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

    ''' <summary>
    ''' Sets the brush in an active whiteboard window to Blue
    ''' </summary>
    Private Sub mnuBrushColourBlue_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBlue.Click

        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).SetColor(Color.Blue)
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub
End Class
