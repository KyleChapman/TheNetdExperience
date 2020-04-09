' Author: Kyle Chapman
' Date: April 2, 2020
' Description:
'   This is a form allowing you to create a list of cars, as a solution to
'   NETD 2202 Lab 4. Includes validation and the use of a listview to display
'   cars and allow the user to modify the list.

Option Strict On

Public Class frmCarInfo

#Region "Variable Declarations"

    Dim selectedCar As Car                      ' the selected Car class object
    Dim isCarSelected As Boolean = False        ' indicates whether a car is selected
    Dim isAddingToListView As Boolean = False   ' indicates whether the program is populating the ListView
    Dim carList As New List(Of Car)             ' the list of Car objects

    Private Shared carListInstance As frmCarInfo

    Const DefaultYear As Integer = 2000

#End Region
#Region "Event Handlers"

    ''' <summary>
    ''' Attempt to enter a new car and add it to the list.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Validate the input (and take no further action if input is invalid)
        If IsValidInput() Then

            ' If a car is selected, update that car using the car's properties
            If isCarSelected Then

                selectedCar = carList(lvwCarList.SelectedIndices(0))
                selectedCar.Make = cboMake.Text
                selectedCar.Model = tbModel.Text
                selectedCar.Year = CInt(nudYear.Value)
                selectedCar.Price = CDec(tbPrice.Text)
                selectedCar.IsNew = chkNew.Checked

                ' No car is selected; make a new car and add it to the list
            Else

                selectedCar = New Car(cboMake.Text, tbModel.Text, CInt(nudYear.Value), CDec(tbPrice.Text.Trim), chkNew.Checked)
                carList.Add(selectedCar)

            End If

            ' Set default to re-populate the ListView and empty form controls
            SetDefaults()

        End If

    End Sub

    ''' <summary>
    ''' Calls SetDefaults to set the default state of the form
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Closes the thing
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' When something is selected in the ListView, add its data to the input controls
    ''' </summary>
    Private Sub lvwCarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarList.SelectedIndexChanged

        ' Verify that a single element of the ListView has been selected
        If lvwCarList.SelectedIndices.Count = 1 AndAlso lvwCarList.SelectedIndices(0) >= 0 Then

            ' One car is selected! Indicate which car is the selected car.
            selectedCar = carList(lvwCarList.SelectedIndices(0))
            isCarSelected = True

            ' Populate the input fields with the selected car's data (from its properties)
            cboMake.Text = selectedCar.Make
            tbModel.Text = selectedCar.Model
            nudYear.Value = selectedCar.Year
            tbPrice.Text = selectedCar.Price.ToString()
            chkNew.Checked = selectedCar.IsNew

        End If

    End Sub

    ''' <summary>
    ''' When an item in the ListView is checked, set the new value equal to the old value so nothing is actually changed
    ''' </summary>
    Private Sub lvwCarList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarList.ItemCheck

        If Not isAddingToListView Then
            e.NewValue = e.CurrentValue
        End If

    End Sub

    ''' <summary>
    ''' When the form closes, ensure the instance is cleared so that any parent form can exit properly
    ''' </summary>
    Private Sub frmCarInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        carListInstance = Nothing

    End Sub


#End Region
#Region "Methods"

    ''' <summary>
    ''' Set the default state of the form
    ''' </summary>
    Private Sub SetDefaults()

        cboMake.SelectedIndex = -1
        tbModel.Clear()
        nudYear.Value = DefaultYear
        tbPrice.Clear()
        chkNew.Checked = True
        lblResult.Text = String.Empty

        RefreshList()

        isCarSelected = False

        cboMake.Focus()

    End Sub

    ''' <summary>
    ''' Populate the ListView's contents using the List declared in this form
    ''' </summary>
    Private Sub RefreshList()

        ' Clear the items from the listview control
        lvwCarList.Items.Clear()

        ' This For loop re-populates the list
        For Each carListItem As Car In carList

            ' Create a new ListViewItem to be added to the ListView
            Dim carListViewItem As New ListViewItem()

            ' Add SubItems to the ListViewItem based on the car's properties
            carListViewItem.SubItems.Add(carListItem.Id.ToString)
            carListViewItem.SubItems.Add(carListItem.Make)
            carListViewItem.SubItems.Add(carListItem.Model)
            carListViewItem.SubItems.Add(carListItem.Year.ToString)
            carListViewItem.SubItems.Add(carListItem.Price.ToString("c"))
            carListViewItem.Checked = carListItem.IsNew

            ' Indicate that we are adding cars to the ListView
            isAddingToListView = True

            ' Add the newly populated ListViewItem to the ListView control
            lvwCarList.Items.Add(carListViewItem)

            ' Indicate that we are done adding characters to the ListView
            isAddingToListView = False

        Next

    End Sub

    ''' <summary>
    ''' Validates all input
    ''' </summary>
    Private Function IsValidInput() As Boolean

        ' Variable Declarations
        Dim isValid As Boolean = True
        Dim errorMessage As String = "Errors: "
        Dim priceValue As Decimal = 0

        ' Validate the "Make" - can't be empty
        If cboMake.Text = String.Empty Then

            isValid = False
            errorMessage &= vbCrLf & "A make must be selected"

        End If

        ' Validate the "Model" - can't be empty
        If tbModel.Text.Trim = String.Empty Then

            isValid = False
            errorMessage &= vbCrLf & "A model must be entered"

        End If

        ' Validate the "Price" - several validations apply
        ' Check that the Price isn't empty
        If tbPrice.Text.Trim = String.Empty Then

            isValid = False
            errorMessage &= vbCrLf & "A price must be entered"

            ' Check that the Price is numeric
        ElseIf Not Decimal.TryParse(tbPrice.Text.Trim, priceValue) Then

            isValid = False
            errorMessage &= vbCrLf & "The price must be entered as a number"

            ' Check that the Price is non-negative
        ElseIf priceValue < 0 Then

            isValid = False
            errorMessage &= vbCrLf & "The price must be a positive number"

        End If

        ' If there were any errors above, print the error message
        If Not isValid Then
            lblResult.Text = errorMessage
        End If

        ' Return whether it's valid or not   
        Return isValid

    End Function

#End Region

#Region "Form Properties"

    Friend Shared ReadOnly Property Instance() As frmCarInfo
        Get
            If carListInstance Is Nothing Then
                carListInstance = New frmCarInfo
            End If
            Return carListInstance
        End Get
    End Property

#End Region

End Class
