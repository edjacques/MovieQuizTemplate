Public Class frmHighScore
    Private Sub LlstHighScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LlstHighScore.SelectedIndexChanged
        playerScore = 0
        playerName = txtName.Text
        frmQuestion1.Show()

        Me.Hide()
    End Sub
End Class