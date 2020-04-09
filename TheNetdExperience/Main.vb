' Author:   Kyle Chapman
' Created:  April 8, 2020
' Modified: April 9, 2020
' Description:
'   A container form for several applications developed in the course of NETD 2202 in Winter 2020.
'   Thus far, it includes:
'   Whiteboard - Week 13 demo
'   TicTacToe - In-Class Exercise 2
'   CarList - Lab 4 solution

Public Class frmMain

#Region "mnuFile Event Handlers"

    ''' <summary>
    ''' If a Whiteboard form is active, saves the current Whiteboard image
    ''' </summary>
    Private Sub SaveFile(sender As Object, e As EventArgs) Handles mnuFile2Save.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).FileSave()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub

    ''' <summary>
    ''' If a Whiteboard form is active, saves the current Whiteboard image
    ''' </summary>
    Private Sub mnuFile2SaveAs_Click(sender As Object, e As EventArgs) Handles mnuFile2SaveAs.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).FileSaveAs()
        Else
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub

    ''' <summary>
    ''' Closes the active MdiChild window or requests to exit the application
    ''' </summary>
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        ' If there are child form open, close the active child forms
        If MdiChildren.Count > 0 Then
            ActiveMdiChild.Close()
        Else
            ' There are no child forms open; ask the user if they would like to exit
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then
                ' User wants to exit; let's do that.
                Me.Close()
            End If
        End If

    End Sub

#End Region
#Region "mnuEdit Event Handlers"

    ''' <summary>
    ''' If a Whiteboard form is active, copies the current Whiteboard image to the clipboard
    ''' </summary>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).EditCopy()
        Else
            MessageBox.Show("Cannot copy from the current selected window")
        End If

    End Sub

    ''' <summary>
    ''' If a Whiteboard form is active, attempts to paste into it from the clipboard
    ''' </summary>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).EditPaste()
        Else
            MessageBox.Show("Cannot paste into the current selected window")
        End If

    End Sub

#End Region

#Region "mnuBrush Event Handlers"

    ''' <summary>
    ''' If a Whiteboard form is active, increase the brush size
    ''' </summary>
    Private Sub IncreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBrushIncreaseSize.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).BrushIncrease()
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

    ''' <summary>
    ''' If a Whiteboard form is active, decrease the brush size
    ''' </summary>
    Private Sub DecreaseSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuBrushDecreaseSize.Click

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).BrushDecrease()
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

    ''' <summary>
    ''' Sets the brush in an active whiteboard window to Black
    ''' </summary>
    Private Sub mnuBrushColourBlack_Click(sender As Object, e As EventArgs) Handles mnuBrushColourBlack.Click

        ' This operation can only be performed on Whiteboard forms
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

        ' This operation can only be performed on Whiteboard forms
        If TypeOf (ActiveMdiChild) Is frmWhiteboard Then
            CType(ActiveMdiChild, frmWhiteboard).SetColor(Color.Blue)
        Else
            MessageBox.Show("Current selected window doesn't feature a brush")
        End If

    End Sub

#End Region

#Region "mnuWindow Event Handlers"

    ''' <summary>
    ''' Cascade all child windows
    ''' </summary>
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    ''' <summary>
    ''' Tile all child windows horizontally
    ''' </summary>
    Private Sub mnuWindowTileHorizontally_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontally.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    ''' <summary>
    ''' Tile all child windows vertically
    ''' </summary>
    Private Sub mnuWindowTileVertically_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertically.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    ''' <summary>
    ''' Create and display a new whiteboard form instance
    ''' </summary>
    Private Sub ShowNewWhiteboard(sender As Object, e As EventArgs) Handles btnToolStripNewWhiteboard.Click, mnuWindowNewWhiteboard.Click

        Dim myWhiteboard As New frmWhiteboard   ' Create a new instance of the Whiteboard form
        myWhiteboard.MdiParent = Me             ' Set the new instance to be an MdiChild
        myWhiteboard.Show()                     ' Display the instance of the Whiteboard form

    End Sub

    ''' <summary>
    ''' Create and display a new Tic Tac Toe form instance
    ''' </summary>
    Private Sub ShowNewTicTacToe(sender As Object, e As EventArgs) Handles btnToolStripNewTicTacToe.Click, mnuWindowNewTicTacToe.Click

        Dim myTicTacToe As New frmTicTacToe    ' Create a new instance of the TicTacToe form
        myTicTacToe.MdiParent = Me             ' Set the new instance to be an MdiChild
        myTicTacToe.Show()                     ' Display the instance of the Whiteboard form

    End Sub

    ''' <summary>
    ''' Create and display a Car List form instance; only one can be shown at a time
    ''' </summary>
    Private Sub ShowCarList(sender As Object, e As EventArgs) Handles btnToolStripNewCarList.Click, mnuWindowNewCarList.Click

        ' Get the current instance of the CarInfo form, if it exists, otherwise make a new one
        Dim myCarList As frmCarInfo = frmCarInfo.Instance

        myCarList.MdiParent = Me    ' Make the new form a child form
        myCarList.Show()            ' Display the instance of the Car List form
        myCarList.Focus()           ' Put focus on the new form

    End Sub

#End Region

End Class
