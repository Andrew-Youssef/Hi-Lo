Public Class frmcongrats
    Public value As Integer
    Public count As Integer
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End         'closes the application
    End Sub

    Private Sub btnrestart_Click(sender As Object, e As EventArgs) Handles btnrestart.Click
        Application.Restart()       'restarts the application
    End Sub
End Class