Public Class frmMain


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerScore = 0
        playerName = txtName.Text
        frmQuestion1.Show()
    End Sub
End Class