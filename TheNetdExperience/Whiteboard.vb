' Author: Kyle Chapman
' Created: March 31, 2020
' Modified: April 9, 2020
' Description:
'   This program is a simple whiteboard or paint application.
'   A user can draw freely on a surface using singular points
'   (not shapes), with a configurable size and colour.
'   Basically functionality to Save and some clipboard
'   functionality also exists.

Option Strict On

Public Class frmWhiteboard

    ' Is the mouse button down?
    Dim isPressed As Boolean = False
    Dim filePath As String = String.Empty

    ' Indicates the current position of the cursor
    Dim xValue As Integer = 0
    Dim yValue As Integer = 0

    ' The starting/current size and color of the paintbrush
    Dim brushSize As Integer = 5
    Dim brushColour As Color = Color.Black

    ' Indicates the current draw region based on the cursor's coordinates
    Dim drawRectangle As New Rectangle(xValue, yValue, brushSize, brushSize)

    ' This actually holds the image
    Dim bitmapInstance As Bitmap

    ' Used for access to the Graphics class
    Dim graphics As Drawing.Graphics

#Region "Mouse- and Paint-Related Event Handlers"

    ''' <summary>
    ''' When the mouse button is up on the form or the canvas, indicate that it is not pressed
    ''' </summary>
    Private Sub MouseButtonUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, pbxCanvas.MouseUp

        isPressed = False

    End Sub

    ''' <summary>
    ''' When the mouse button is down on the canvas, record that it is down; also draw this single space
    ''' </summary>
    Private Sub MouseButtonDown(sender As Object, e As MouseEventArgs) Handles pbxCanvas.MouseDown

        ' The button is pressed
        isPressed = True

        ' Set current coordinates
        xValue = e.X
        yValue = e.Y

        ' Set the space to draw
        drawRectangle = New Rectangle(xValue, yValue, brushSize, brushSize)

        ' Force the canvas to re-draw itself
        pbxCanvas.Invalidate(drawRectangle)

    End Sub

    ''' <summary>
    ''' When the mouse is moved, if button is down, draw this single space
    ''' </summary>
    Private Sub MouseIsMoved(sender As Object, e As MouseEventArgs) Handles pbxCanvas.MouseMove

        ' Check if it's pressed
        If isPressed Then

            ' Set current coordinates
            xValue = e.X
            yValue = e.Y

            ' Set the space to draw
            drawRectangle = New Rectangle(xValue, yValue, brushSize, brushSize)

            ' Force the canvas to re-draw itself
            pbxCanvas.Invalidate(drawRectangle)

        End If

    End Sub

    ' When the canvas is painted (i.e. re-loaded), draw an ellipse on the current draw area
    Private Sub Repaint(sender As Object, e As PaintEventArgs) Handles pbxCanvas.Paint

        ' Check if it's pressed
        If isPressed Then

            ' Declare a solid brush
            Dim myBrush As Brush = New SolidBrush(brushColour)

            ' Fill the current space!
            graphics.FillEllipse(myBrush, drawRectangle)

        End If

    End Sub

#End Region

#Region "mnuFile Event Handlers"

    ''' <summary>
    ''' When the application is opened or when New is selected, set the default image to a white background
    ''' and set the image to be the destination for the .Graphics / .Drawing class
    ''' </summary>
    Private Sub NewFile(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the background to white
        pbxCanvas.BackColor = Color.White
        ' Set the bitmap we're working on to the size of the pictureBox
        bitmapInstance = New Bitmap(pbxCanvas.Width, pbxCanvas.Height)
        ' Set the pictureBox's Image property equal to the bitmap we're working on
        pbxCanvas.Image = bitmapInstance
        ' Set the destination for the Graphics class to be the bitmap we're working on
        graphics = Graphics.FromImage(bitmapInstance)
        ' Ensure the white background is copied into the base image
        pbxCanvas.DrawToBitmap(bitmapInstance, pbxCanvas.ClientRectangle)

        ' Unset the saved file path and update the form title
        filePath = String.Empty
        UpdateFormTitle()

    End Sub

    ''' <summary>
    ''' Saves the current opened file, or saves via a dialog if there is no current file
    ''' </summary>
    Friend Sub FileSave()

        If filePath = String.Empty Then

            ' We don't have a file path
            ' This is effectively now a Save As...
            FileSaveAs()

        Else

            SaveImageFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Saves the canvas to a .bmp file.
    ''' </summary>
    Friend Sub FileSaveAs()

        ' Sets the filter for the save dialog.
        sfdSaveAs.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*"

        ' If the user selects a file...
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then

            ' Set the new filePath and update the form title
            filePath = sfdSaveAs.FileName
            UpdateFormTitle()

            ' Save the image
            SaveImageFile(filePath)

        End If

    End Sub

#End Region

#Region "mnuEdit Event Handlers"

    ''' <summary>
    ''' Sets the clipboard's contents equal to the canvas' image.
    ''' </summary>
    Friend Sub EditCopy()

        Clipboard.SetImage(pbxCanvas.Image)

    End Sub

    ''' <summary>
    ''' Attempts to paste in an image or text from the clipboard.
    ''' </summary>
    Friend Sub EditPaste()

        ' If there's an image on the clipboard, paste it.
        If Clipboard.ContainsImage Then

            pbxCanvas.Image = Clipboard.GetImage

            ' If there is text on the clipboard, write it.
        ElseIf Clipboard.ContainsText Then

            ' Draw the text to the last set cursor position
            graphics.DrawString(Clipboard.GetText, DefaultFont, Brushes.Black, xValue, yValue)
            ' Force the canvas to re-draw itself
            pbxCanvas.Invalidate(pbxCanvas.Region)

        End If

    End Sub

#End Region

#Region "mnuBrush Event Handlers"

    ''' <summary>
    ''' Increment the size of the brush
    ''' </summary>
    Friend Sub BrushIncrease()
        brushSize += 1
    End Sub

    ''' <summary>
    ''' Decrement the size of the brush, to a minimum of 1
    ''' </summary>
    Friend Sub BrushDecrease()

        If brushSize > 0 Then
            brushSize -= 1
        End If

    End Sub

    ''' <summary>
    ''' Set the color for the brush
    ''' </summary>
    ''' <param name="colorValue">The color to set for the brush</param>
    Friend Sub SetColor(colorValue As Color)
        brushColour = colorValue
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Saves the image file to a specified bitmap file locally
    ''' </summary>
    ''' <param name="path">A full file path as a string</param>
    Friend Sub SaveImageFile(path As String)

        pbxCanvas.Image.Save(path, Imaging.ImageFormat.Bmp)

    End Sub

    ''' <summary>
    ''' Updates the form's title text to include the open file path (or not)
    ''' </summary>
    Friend Sub UpdateFormTitle()

        Me.Text = "Kyle's Whiteboard"

        If Not filePath = String.Empty Then

            Me.Text &= " - " & filePath

        End If

    End Sub

#End Region

End Class
