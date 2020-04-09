' Author: Kyle
' Date: March 12, 2020
' Description:
'   This class represents a car object, holding properties of the car
'   such as make, model, year, etc. Used as part of a Lab for NETD 2202.

Option Strict On

Public Class Car

#Region "Variable Declarations"

    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = True

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor: just increments the car count
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    ''' <summary>
    ''' Parametrized constructor: sets all private variables based on arguments passed in
    ''' </summary>
    ''' <param name="makeValue">a car's manufacturer</param>
    ''' <param name="modelValue">a car's model</param>
    ''' <param name="yearValue">a car's year of manufacture</param>
    ''' <param name="priceValue">a car's price</param>
    ''' <param name="newValue">True if the car is new; False if the car is used</param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, newValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue

    End Sub

#End Region

#Region "Property Procedures"

    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns>the number of car objects</returns>
    Friend Shared ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Returns a car's unique identifcation number
    ''' </summary>
    ''' <returns>an integer specifying this car</returns>
    Friend ReadOnly Property Id() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets a car's manufacturer
    ''' </summary>
    ''' <returns>a car's manufacturer</returns>
    Friend Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's model name
    ''' </summary>
    ''' <returns>a car's model name</returns>
    Friend Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's year of manufacture
    ''' </summary>
    ''' <returns>a car's year of manufacture</returns>
    Friend Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car's price
    ''' </summary>
    ''' <returns>a car's price</returns>
    Friend Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a flag indicating whether the car is new or not
    ''' </summary>
    ''' <returns>True if the car is new; False if the car is used</returns>
    Friend Property IsNew() As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Returns a string describing the car
    ''' </summary>
    ''' <returns>a string describing the car</returns>
    Friend Function GetCarData() As String

        'If carIsNew Then
        '    Return "New " & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        'Else
        '    Return "Used " & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        'End If

        Return IIf(carIsNew, "New ", "Used ").ToString & carYear & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")

    End Function

#End Region

End Class
