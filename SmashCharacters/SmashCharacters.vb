' Author: Kyle Chapman
' Date: March 10, 2020
' Description:
'   This is a form allowing you to create a list of characters for Smash Bros. games.
'   Intended as part of a demo related to NETD 2202.
'   Some functionality is loosely adapted from CustomerList by Alfred/Paul Massardo
'   (pmassardo: https://github.com/pmassardo/CustomerList)

Public Class frmSmashCharacters

#Region "Variable Declarations"

    Dim selectedCharacter As Character            ' declare a Character class object
    Dim isCharacterSelected As Boolean = False
    Dim isAddingToListView As Boolean = False
    Dim characterList As New List(Of Character)

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' Attempt to enter a new Smash character and add them to the list.
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Validate the data in the form
        If IsValidInput() = True Then
            ' If a character is selected
            If Not isCharacterSelected Then

                ' Create a new character and add them to the list
                selectedCharacter = New Character(tbName.Text, tbSeries.Text, chkEchoFighter.Checked)
                characterList.Add(selectedCharacter)

                ' Else if currentCharacter exists, we will be editing it
            ElseIf selectedCharacter.IdentificationNumber.Trim.Length > 0 Then

                ' Update the existing character based on the entered values
                selectedCharacter.Name = tbName.Text
                selectedCharacter.Series = tbSeries.Text
                selectedCharacter.IsEcho = chkEchoFighter.Checked

            End If

        End If

        SetDefaults()

    End Sub

    ''' <summary>
    ''' Calls SetDefaults to put the form to its default state
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
    End Sub

    ''' <summary>
    ''' Me close form
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Event handler for the event that a character is selected in the ListView
    ''' </summary>
    Private Sub lvwCharacters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCharacters.SelectedIndexChanged

        If lvwCharacters.SelectedIndices.Count = 1 Then
            selectedCharacter = characterList(lvwCharacters.SelectedIndices(0))
            isCharacterSelected = True

            tbName.Text = selectedCharacter.Name
            tbSeries.Text = selectedCharacter.Series
            chkEchoFighter.Checked = selectedCharacter.IsEcho

        Else
            isCharacterSelected = False
        End If

    End Sub

    ''' <summary>
    ''' This thingie is supposed to stop you from checking a box
    ''' </summary>
    Private Sub lvwCharacters_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCharacters.ItemCheck

        ' If we're not currently adding characters to the list
        If Not isAddingToListView Then

            ' Maintain the old checkbox value
            e.NewValue = e.CurrentValue

        End If

    End Sub


#End Region

#Region "Procedures"

    ''' <summary>
    ''' Resets the forms as well as any required class-level variables to their default state
    ''' </summary>
    Private Sub SetDefaults()
        tbName.Clear()
        tbSeries.Clear()
        chkEchoFighter.Checked = False
        lbResult.Text = String.Empty

        PopulateList()

        isCharacterSelected = False

        tbName.Focus()

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the name has been entered
        If tbName.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the character's name." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the name has been entered
        If tbSeries.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the character's series." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS:" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Clears and re-populates the ListView control
    ''' </summary>
    Sub PopulateList()

        ' Clear the items from the listview control
        lvwCharacters.Items.Clear()

        ' This For loop re-populates the list
        For index As Integer = 0 To characterList.Count - 1

            ' instantiate a new ListViewItem
            Dim characterItem As New ListViewItem()

            ' assign the values to the checked control
            ' and the subitems
            characterItem.SubItems.Add(characterList(index).IdentificationNumber.ToString())
            characterItem.SubItems.Add(characterList(index).Name)
            characterItem.SubItems.Add(characterList(index).Series)
            characterItem.Checked = characterList(index).IsEcho

            ' Indicate that we are adding characters to the ListView
            isAddingToListView = True

            ' add the new instantiated and populated ListViewItem
            ' to the listview control
            lvwCharacters.Items.Add(characterItem)

            ' Indicate that we are done adding characters to the ListView
            isAddingToListView = False

        Next

    End Sub

#End Region

End Class
