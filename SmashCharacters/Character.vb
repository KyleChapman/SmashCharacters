' Author: Kyle Chapman
' Date: March 10, 2020
' Description:
'   This is a class representing real or potential characters for Smash Bros. games.
'   This class doesn't do much. Intended as part of a demo related to NETD 2202.

Option Strict On

Public Class Character

    Private Shared characterCount As Integer
    Private characterIdentificationNumber As String = String.Empty
    Private characterName As String = String.Empty      ' private variable to hold the character's name
    Private characterSeries As String = String.Empty    ' private variable to hold the character's series
    Private characterEchoFighter As Boolean = False     ' private variable to hold whether the character is an echo fighter

    ''' <summary>
    ''' Constructor - Default - creates a new character object
    ''' </summary>
    Public Sub New()

        characterCount += 1
        characterIdentificationNumber = characterCount.ToString

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new character object
    ''' </summary>
    ''' <param name="nameValue"></param>
    ''' <param name="seriesValue"></param>
    ''' <param name="echoValue"></param>
    Public Sub New(nameValue As String, seriesValue As String, echoValue As Boolean)

        Me.New()

        characterName = nameValue
        characterSeries = seriesValue
        characterEchoFighter = echoValue

    End Sub

    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of characters that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Shared ReadOnly Property Count() As Integer
        Get
            Return characterCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific character identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As String
        Get
            Return characterIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' IsEcho Property - >Gets and Sets the echo fighter status of a character
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property IsEcho() As Boolean
        Get
            Return characterEchoFighter
        End Get
        Set(ByVal value As Boolean)
            characterEchoFighter = value
        End Set
    End Property

    ''' <summary>
    ''' Name property - Gets and Sets the  name of a character
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Name() As String
        Get
            Return characterName
        End Get
        Set(ByVal value As String)
            characterName = value
        End Set
    End Property

    ''' <summary>
    ''' Series property - Gets and Sets the series a character represents
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Series() As String
        Get
            Return characterSeries
        End Get
        Set(ByVal value As String)
            characterSeries = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Hi! My name is " & characterName & " from " & characterSeries & " and " & IIf(characterEchoFighter = True, "I am an echo fighter", "I am not an echo fighter").ToString()

    End Function

End Class
