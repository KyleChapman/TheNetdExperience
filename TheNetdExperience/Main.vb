Public Class frmMain

    Private Sub ShowNewWhiteboard(sender As Object, e As EventArgs) Handles btnToolStripNewWhiteboard.Click, mnuWindowNewWhiteboard.Click

        Dim myWhiteboard As New frmWhiteboard
        myWhiteboard.MdiParent = Me
        myWhiteboard.Show()

    End Sub

    Private Sub btnToolStripNewTicTacToe_Click(sender As Object, e As EventArgs) Handles btnToolStripNewTicTacToe.Click, mnuWindowNewTicTacToe.Click

        Dim myTicTacToe As New frmTicTacToe
        myTicTacToe.MdiParent = Me
        myTicTacToe.Show()

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
            Me.Close()
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
End Class
