Public Class frmwelcome
    Dim username As String
    Dim value As Integer
    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        Me.AcceptButton = btnsubmit     'if the user presses 'enter' on their keyboard then it is the same as if it clicked the button
        username = txtusername.Text     'makes the software understand that what the user put into the textbox is the user's name
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Me.Hide()                               'makes the welcome form close
        frminstructions.Show()                  'makes the instructions form appear
        frmeasygame.lblname.Text = "Player:  " + username      'makes the label on the game form state the user's name as the player
        frmmedgame.lblname.Text = "Player:  " + username      'makes the label on the game form state the user's name as the player
        frmhardgame.lblname.Text = "Player:  " + username      'makes the label on the game form state the user's name as the player
        frmcongrats.lblusername.Text = username    'states the username in the congratulations form
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End                              'closes the application
    End Sub

    Private Sub frmwelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Hi_lo_music, AudioPlayMode.BackgroundLoop)   'plays music in the background as the game is played
    End Sub
End Class
