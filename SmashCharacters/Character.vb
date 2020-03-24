' Author: Kyle Chapman
' Date: March 10, 2020
' Description:
'   This is a class representing real or potential characters for Smash Bros. games.
'   This class doesn't do much. Intended as part of a demo related to NETD 2202.

Option Strict On

Public Class Character

#Region "Variable Declarations"

    Private Shared characterCount As Integer
    Private characterIdentificationNumber As String = String.Empty
    Private characterName As String = String.Empty      ' private variable to hold the character's name
    Private characterSeries As String = String.Empty    ' private variable to hold the character's series
    Private characterYear As Integer = 0    ' private variable to hold the character's year
    Private characterEchoFighter As Boolean = False     ' private variable to hold whether the character is an echo fighter

#End Region

#Region "Constructors"

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
    ''' <param name="yearValue"></param>
    ''' <param name="echoValue">True if the character is an echo fighter, False otherwise</param>
    Public Sub New(nameValue As String, seriesValue As String, yearValue As Integer, echoValue As Boolean)

        Me.New()

        characterName = nameValue
        characterSeries = seriesValue
        characterYear = yearValue
        characterEchoFighter = echoValue

    End Sub

#End Region

#Region "Property Procedures"

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
    ''' Year property - Gets and Sets the year that a character was created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public Property Year() As Integer
        Get
            Return characterYear
        End Get
        Set(ByVal value As Integer)
            characterYear = value
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' GetSalutation is a function that returns a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Hi! My name is " & characterName & " from " & characterSeries & " created in " & characterYear.ToString() & ", and " & IIf(characterEchoFighter = True, "I am an echo fighter", "I am not an echo fighter").ToString()

        'If characterEchoFighter Then
        '    Return "Hi! My name is " & characterName & " from " & characterSeries & " and I am an echo fighter"
        'Else
        '    Return "Hi! My name is " & characterName & " from " & characterSeries & " and I am not an echo fighter"
        'End If

    End Function


    ''' <summary>
    ''' WriteCharacter is a function that writes the character to a file concisely based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function WriteCharacter() As String

        Return characterName & vbTab & characterSeries & vbTab & characterYear.ToString() & IIf(characterEchoFighter = True, vbTab & "Echo fighter", String.Empty).ToString() & vbCrLf

    End Function


#End Region

End Class
