' Title: Awesomeness App
' Name: Kyle Chapman
' Last Modified: May 16, 2018
' Description: This application is used to determine the user's level of awesomeness
'              or perhaps their confidence in their awesomeness. It works amazingly.
'              Try it on your parents!

Public Class frmAwesomeness

    ''' <summary>
    ''' Displays a positive message and closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

        ' Display a happy awesomeness-related message
        MessageBox.Show("Yes, you ARE awesome! Great job and thank you.")
        ' Close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' Hides the leftmost "no" button and shows the rightmost "no" button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNo1_Click(sender As Object, e As EventArgs) Handles btnNo1.Click, btnNo1.MouseEnter

        btnNo1.Hide()
        btnNo2.Show()

    End Sub

    ''' <summary>
    ''' Hides the rightmost "no" button and shows the leftmost "no" button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNo2_Click(sender As Object, e As EventArgs) Handles btnNo2.Click, btnNo2.MouseEnter

        btnNo2.Hide()
        btnNo1.Show()

    End Sub
End Class
