Public Class Form1
    Dim currentWord, selectedWord As String 'getting, setting, and updating variables'
    Dim alphabets As Char() 'an array to store the alphabets'
    Dim i As Integer 'counter'

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click 'the command to iterate through the alphabets variable'
        i = i + 1 'incrementing the counter'
        alphabets = New Char() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"} 'an array to store the alphabets'
        If i <= 25 Then
            currentWord = alphabets(i) 'setting the value of the variable to current location of the alphabets'
        Else
            i = -1 'setting the counter to -1'
        End If
        txtCurrent.Text = currentWord 'setting the word'
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        txtCurrent.Text = "A" 'sets the value to A' 
        i = 0 'setting counter back to 0'
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        selectedWord = txtCurrent.Text 'the current letter is set to the current text box'
        txtSpeak.Text = txtSpeak.Text + selectedWord 'the letter is set in the main text box'
    End Sub

    Private Sub cmdAddSpace_Click(sender As Object, e As EventArgs) Handles cmdAddSpace.Click
        txtSpeak.Text = txtSpeak.Text + " " 'adding space'
    End Sub

    Private Sub cmdSpeak_Click(sender As Object, e As EventArgs) Handles cmdSpeak.Click 'main speaking function'
        Dim voice = CreateObject("SAPI.spvoice")
        voice.speak(txtSpeak.Text)
    End Sub
End Class
