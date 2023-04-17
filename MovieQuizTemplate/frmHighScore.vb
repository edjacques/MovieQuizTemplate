Public Class frmHighScore
    Public Sub doScore()
        If (playerScore < 1) Then
            Label1.Text = "Sorry your score was not good enough"
        Else
            Label1.Text = "Congratulations your score will be added to the Hall of Fame"
            LlstHighScore.Items.Add(playerName & vbTab & vbTab & playerScore)

        End If
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class