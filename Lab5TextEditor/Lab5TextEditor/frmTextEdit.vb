Option Strict On
Imports System.IO


Public Class frmTextEdit
    'These are the variable declarations
    Dim openFilePath As String = String.Empty
    Dim fileChanged As Boolean = False


#Region "Event Handlers"

    ''' <summary>
    ''' This is the event that is called when the about button is pressed. It displays a helpful little message
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Text Editor" & vbCrLf & vbCrLf &
                         "By Michael Dormon" & vbCrLf & vbCrLf &
                         "April 2, 2020")  'Display a message box that says this
    End Sub

    ''' <summary>
    ''' This is the event that is called when teh "New" button is clicked
    ''' it first calls the ConfirmClose() function and then depending on the result it creates a new file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNew_Click(sender As Object, e As EventArgs)

        If ConfirmClose() Then 'Wanna close this?
            'make a new empty page
            txtMainBox.Text = String.Empty
            openFilePath = String.Empty
            fileChanged = False
            UpdateFormTitle()
        End If

    End Sub

    ''' <summary>
    ''' This is the event that is called when the open button is clicked. It calls the ConfirmClose()
    ''' function and depending on the result it opens a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

        If ConfirmClose() Then 'You really want to close what you've got?
            'diclare variables for the FileStream and FileWriter
            Dim openFile As FileStream
            Dim fileReader As StreamReader

            If opdOpen.ShowDialog() = 1 Then ' did you press cancel?
                openFilePath = opdOpen.FileName 'get the path from the dialog
                openFile = New FileStream(openFilePath, FileMode.Open, FileAccess.Read) 'instantiate the filestream
                fileReader = New StreamReader(openFile) 'instansiate the StreamReader

                txtMainBox.Text = fileReader.ReadToEnd 'read the file and set the text in the box to be the text of the file
                fileReader.Close() 'close the file
                fileChanged = False 'let everybody know this is fresh and if its closed right now it doesn't matter
                UpdateFormTitle() 'update the title
            End If

        End If

    End Sub

    ''' <summary>
    ''' Boring old copy event. Quite simple it just sets the clipboard text to the selected text
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs)
        Clipboard.SetText(txtMainBox.SelectedText) 'copy to clipboard
    End Sub

    ''' <summary>
    ''' This is the cut event, it is slightly more involved than the copy event. First it stores the cursor 
    ''' location, then sets the text in the textbox to be the text that was in the textbox - the selected text.
    ''' It then puts the cursor back to were it was. The cursor part probably wasn't needed but it felt weird that
    ''' it would reset it to the beginning.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        'storing the posision of the cursor
        Dim cursorLocation As Integer = txtMainBox.SelectionStart

        Clipboard.SetText(txtMainBox.SelectedText) 'copy
        txtMainBox.Text = txtMainBox.Text.Remove(txtMainBox.SelectionStart, txtMainBox.SelectionLength) 'remove selected
        txtMainBox.SelectionStart = cursorLocation 'put cursor back just to make me feel more at home
    End Sub

    ''' <summary>
    ''' This is the paste event, slightly more involved than cut. Saves cursor position,
    ''' removes the selected text and inserts the clipboard text. Then it puts the cursor at the end of
    ''' the pasted text. Once again the cursor stuff wasn't nessisary but it makes me feel good.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If Clipboard.GetText.Length <> 0 Then 'just checking that there is something to paste

            Dim cursorLocation As Integer = txtMainBox.SelectionStart 'storing the cursor position
            txtMainBox.Text = txtMainBox.Text.Remove(cursorLocation, txtMainBox.SelectionLength).Insert(cursorLocation, Clipboard.GetText) 'doing some switcherooing with the selected text and the clipboard text
            txtMainBox.SelectionStart = cursorLocation + Clipboard.GetText.Length 'putting the cursor where it should be
        End If
    End Sub

    ''' <summary>
    ''' This is the save button event, but it is also a function. If there is a file open just save to the same file, if not
    ''' use the save as button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns>True if it saves, false if it does not</returns>
    Private Function mnuSave_Click(sender As Object, e As EventArgs) As Boolean Handles mnuSave.Click
        If openFilePath <> String.Empty Then 'checking if it has a path
            SaveFile(openFilePath) ' Save at the old path
            Return True 'Yep it saved
        Else
            Return mnuSaveAs_Click(sender, e) 'return the save as event which will save on a specified path
        End If
        Return False 'Nope it did not save
    End Function

    ''' <summary>
    ''' This is the save as button event, but like the save event/function it is also a function.
    ''' This event/function opens a save file dialog and saves the file in the specified location.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <returns>True if it saves, false if it does not</returns>
    Private Function mnuSaveAs_Click(sender As Object, e As EventArgs) As Boolean Handles mnuSaveAs.Click
        If sfdSaveAs.ShowDialog() = 1 Then 'check if you hit cancel on the dialog
            openFilePath = sfdSaveAs.FileName 'gets the path from the dialog
            UpdateFormTitle() 'update the title of the form to reflect the file that is open
            SaveFile(openFilePath) 'calls the SaveFile() Subroutine on the given path
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' This is the exit button event handler, it will first call the ConfirmClose() function and then maybe 
    ''' close depending on the result
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        If ConfirmClose() Then 'Are you sure you wanna close?
            Me.Close() ' Close the form
        End If
    End Sub

    ''' <summary>
    ''' This is the event handler for when the user changes the contents of the text box.
    ''' All it does is let everyone know that things have changed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtMainBox_TextChanged(sender As Object, e As EventArgs) Handles txtMainBox.TextChanged
        fileChanged = True 'the file is different, you might want to save it
    End Sub

#End Region

#Region "Subs"

    ''' <summary>
    ''' This is the sub that saves the file it is called in the save and save as event handlers.
    ''' </summary>
    ''' <param name="path"> the path to write to </param>
    Private Sub SaveFile(path As String)
        'declare the stream and the writer
        Dim saveFile As FileStream
        Dim fileWriter As StreamWriter

        saveFile = New FileStream(path, FileMode.Create, FileAccess.Write) 'instantiate the FileStream
        fileWriter = New StreamWriter(saveFile) 'instantiate the StreamWriter

        fileWriter.Write(txtMainBox.Text) 'write the contents of the textbox to the file
        fileWriter.Close() 'close the file
        fileChanged = False 'let everyone know you saved

    End Sub

    ''' <summary>
    ''' This is the sub that updates the title. if the file has a name the title reflects that
    ''' </summary>
    Private Sub UpdateFormTitle()
        Me.Text = "Text Editor" 'the default title

        If openFilePath <> String.Empty Then 'does the file have a name?
            Me.Text += " - " & openFilePath 'add the name
        End If
    End Sub

#End Region

#Region "Functions"

    ''' <summary>
    ''' This is the function that confirms if the user wants to close file or open a new file. If the file has been modified since
    ''' it was last saved it will ask if the user wishes to save and bring up the coresponding save menu. 
    ''' There is also a fancy little bit of recursion
    ''' </summary>
    ''' <returns>True if the user wishes to close, false otherwise </returns>
    Private Function ConfirmClose() As Boolean

        If fileChanged Then 'has the file been changed since last save?
            'declaring some needed variables
            Dim response As MsgBoxResult
            Dim filename As String

            If openFilePath = String.Empty Then 'is there an open file?
                filename = "'untitled'" 'call it untitled
            Else
                Try
                    filename = "'" & openFilePath.Substring(openFilePath.LastIndexOf("\") + 1) & "'" 'try to extract the filename from the path
                Catch
                    filename = "'" & openFilePath & "'" 'just call it the path if that fails
                End Try

            End If
            response = MsgBox("You have unsaved changes to " & filename & "." & vbCrLf & "Would you like to save your changes?", vbYesNoCancel, "Confirm")
            '^^^^^ display the message box asking about saving

            If response = vbYes Then ' what did they choose?
                If Not mnuSave_Click(sender:=Me, e:=New EventArgs) Then 'did they press cancel on the save dialog?
                    Return ConfirmClose() 'try again
                End If
                Return True 'proceed with closing
            ElseIf response = vbCancel Then
                Return False 'wait don't close my cat walked on the keyboard and pressed the exit button
            End If
        End If
        Return True 'close because its already been saved
    End Function
#End Region


End Class