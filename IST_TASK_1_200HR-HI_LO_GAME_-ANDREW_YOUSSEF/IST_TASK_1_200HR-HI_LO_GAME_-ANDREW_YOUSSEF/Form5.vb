Public Class frmmedgame
    Dim value As Integer
    Dim guess As Integer
    Dim count As Integer

    Private Sub frmmediumgame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        value = CInt(Int((50 * Rnd()) + 1))     'makes the computer generate a random number between 1 and 20
        frmcongrats.lblmedium.Visible = True
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End     'closes the application
    End Sub

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click

        'if the guess is more than the secret number then it shows the high picture
        If guess > value Then
            count = count + 1                   'adds 1 to the amount of tries
            pichigh.Visible = True
            piclow.Visible = False
        End If

        'if the guess is less than the secret number then it shows the low picture
        If guess < value Then
            count = count + 1                   'adds 1 to the amount of tries
            pichigh.Visible = False
            piclow.Visible = True
        End If

        'if the secret number is guessed then the user is shown the congrats form
        If guess = value Then
            count = count + 1                   'adds 1 to the amount of tries
            Me.Hide()                           'makes this form close
            frmcongrats.Show()                  'opens the congrats form
            frmcongrats.lblcount.Text = count   'states the amount of turns it took to figure out the secret number on the last form
            frmcongrats.lblvalue.Text = value   'states the secret number on the last form
            timmedgame.Enabled = False          'stops the timer
            frmcongrats.lbltime.Text = lblmedgametim.Text  'states the time it took the player to figure out the secret number on the last form
        End If

    End Sub

    Private Sub nudguess_ValueChanged(sender As Object, e As EventArgs) Handles nudguess.ValueChanged
        guess = nudguess.Text                   'makes the computer understand that what the number that the user puts into the numeric up down object is the user's guess
    End Sub

    Private Sub timmedgame_Tick(sender As Object, e As EventArgs) Handles timmedgame.Tick
        lblmedgametim.Text = Val(lblmedgametim.Text) + 1      'makes the timer work
    End Sub
End Class