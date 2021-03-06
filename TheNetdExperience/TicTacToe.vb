﻿' Author: Kyle Chapman
' Created: February 9, 2020
' Modified: April 9, 2020
' Description:
'   It's a tic-tac-toe game! Is that supposed to be hypenated?
'   There are 9 buttons in a 2D array. When clicked, they are assigned
'   a letter based on whoever's turn it is and disabled.

Public Class frmTicTacToe

    ' This boolean value shows whether it's X's turn; otherwise it's O's turn
    Dim isTurnX As Boolean = True
    ' This boolean value represents the win condition
    Dim isWinner As Boolean = False
    ' Here's an array of buttons, representing squares on the board
    Dim squares As Button(,)

#Region "Event Handlers"

    ''' <summary>
    ''' On form load, assign the Buttons to the array
    ''' </summary>
    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        squares = {
    {btnRow0Column0, btnRow0Column1, btnRow0Column2},
    {btnRow1Column0, btnRow1Column1, btnRow1Column2},
    {btnRow2Column0, btnRow2Column1, btnRow2Column2}}
    End Sub

    ''' <summary>
    ''' When a button is clicked, assign it a letter, disable the button, and if there was no winner change the turn
    ''' </summary>
    Private Sub TicTacToeSquareClick(btnSender As Button, e As EventArgs) Handles btnRow0Column0.Click, btnRow0Column1.Click, btnRow0Column2.Click, btnRow1Column0.Click, btnRow1Column1.Click, btnRow1Column2.Click, btnRow2Column0.Click, btnRow2Column1.Click, btnRow2Column2.Click

        ' Set the text on the Button
        If isTurnX Then
            btnSender.Text = "X"
        Else
            btnSender.Text = "O"
        End If

        ' Disable the button
        btnSender.Enabled = False

        ' Evaluate win
        EvaluateWin()

        ' Don't swap turns if somebody has won!
        If Not isWinner Then
            ' Swap turns
            ChangeTurn()
        End If

        ' Put focus on the Reset button
        btnReset.Focus()

    End Sub

    ''' <summary>
    ''' The Reset button clears things and re-enables controls
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        SetDefaults()

    End Sub

#End Region

#Region "Procedures"

    ''' <summary>
    ''' This clears the text property of all controls in the array of controls that is passed in
    ''' </summary>
    ''' <param name="controlArray">An array of controls with a text property to clear</param>
    Sub ClearControls(controlArray As Control(,))

        ' For every control in the list that is passed in, empty its Text property
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next

    End Sub

    ''' <summary>
    ''' This enables or disables all controls in the array that is passed in
    ''' </summary>
    ''' <param name="controlArray">An array of controls to enable or disable</param>
    ''' <param name="enabledStatus">Boolean: set controls to enabled?</param>
    Sub SetControlsEnabled(controlArray As Control(,), enabledStatus As Boolean)

        ' For every textbox in the list that is passed in, set its Enabled property
        For Each controlToSet As Button In controlArray
            controlToSet.Enabled = enabledStatus
        Next

    End Sub

    ''' <summary>
    ''' This colors all controls in the array that is passed in
    ''' </summary>
    ''' <param name="controlArray">An array of controls to enable or disable</param>
    ''' <param name="setColor">it's a color</param>
    Sub SetControlsColor(controlArray As Control(,), setColor As Color)

        ' For every textbox in the list that is passed in, set its Enabled property
        For Each controlToSet As Button In controlArray
            controlToSet.BackColor = setColor
        Next

    End Sub
    ''' <summary>
    ''' Clears things and re-enables controls
    ''' </summary>
    Sub SetDefaults()

        ' Clear all buttons
        ClearControls(squares)
        ' Re-enable any controls that may be disabled
        SetControlsEnabled(squares, True)
        ' Set default colors
        SetControlsColor(squares, DefaultBackColor)
        ' Ensure there's no winner
        isWinner = False
        ' ChangeTurn resets the status label and gives the loser the first turn
        ChangeTurn()

    End Sub

    ''' <summary>
    ''' If it's currently X's turn, change it to O's turn, and vice-versa
    ''' </summary>
    Sub ChangeTurn()

        isTurnX = Not isTurnX

        If isTurnX Then
            lblGameStatus.Text = "X's Turn"
        Else
            lblGameStatus.Text = "O's Turn"
        End If

    End Sub

    ''' <summary>
    ''' Determine if the current player has won
    ''' </summary>
    Sub EvaluateWin()

        ' **************************************
        ' This is the part where you code stuff!
        ' **************************************

        ' Use a For loop to check if all boxes in the same dimension
        ' have the same value - doesn't even matter what the value is
        ' as long as it's the same!
        For count As Integer = 0 To squares.GetUpperBound(0)

            If squares(count, 0).Text <> String.Empty And
                    squares(count, 0).Text = squares(count, 1).Text And
                    squares(count, 0).Text = squares(count, 2).Text Then

                isWinner = True

                squares(count, 0).BackColor = Color.MistyRose
                squares(count, 1).BackColor = Color.MistyRose
                squares(count, 2).BackColor = Color.MistyRose

            ElseIf squares(0, count).Text <> String.Empty And
                squares(0, count).Text = squares(1, count).Text And
                squares(0, count).Text = squares(2, count).Text Then

                isWinner = True

                squares(0, count).BackColor = Color.MistyRose
                squares(1, count).BackColor = Color.MistyRose
                squares(2, count).BackColor = Color.MistyRose

            End If

        Next

        ' Finally, we have to check the two diagonals.
        ' It is not going to save us any work to use loops
        ' so let's just do it like this:
        If squares(0, 0).Text <> String.Empty And
            squares(0, 0).Text = squares(1, 1).Text And
            squares(0, 0).Text = squares(2, 2).Text Then
            isWinner = True

            squares(0, 0).BackColor = Color.MistyRose
            squares(1, 1).BackColor = Color.MistyRose
            squares(2, 2).BackColor = Color.MistyRose

        ElseIf squares(0, 2).Text <> String.Empty And
            squares(0, 2).Text = squares(1, 1).Text And
            squares(0, 2).Text = squares(2, 0).Text Then
            isWinner = True

            squares(0, 2).BackColor = Color.MistyRose
            squares(1, 1).BackColor = Color.MistyRose
            squares(2, 0).BackColor = Color.MistyRose
        End If

        ' If there's a winner, show who it is!
        If isWinner Then
            If isTurnX Then
                lblGameStatus.Text = "X wins!"
            Else
                lblGameStatus.Text = "O wins!"
            End If

            ' Disable all squares to prevent further play
            SetControlsEnabled(squares, False)
        End If

    End Sub

#End Region

End Class
