Public Class frminstructions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneasy.Click
        Me.Hide()           'closes this form
        frmeasygame.Show()      'makes the easy game form appear
        frmeasygame.timeasygame.Enabled = True  'starts the timer on the easy game form
    End Sub

    Private Sub btnmedium_Click(sender As Object, e As EventArgs) Handles btnmedium.Click
        Me.Hide()               'closes this form
        frmmedgame.Show()    'makes the medium game form appear
        frmmedgame.timmedgame.Enabled = True  'starts the timer on the medium game form
    End Sub

    Private Sub btnhard_Click(sender As Object, e As EventArgs) Handles btnhard.Click
        Me.Hide()               'closes the form
        frmhardgame.Show()      'makes the hard game form appear
        frmhardgame.timhardgame.Enabled = True  'starts the timer on the hard game form
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End                 'closes the program
    End Sub
End Class