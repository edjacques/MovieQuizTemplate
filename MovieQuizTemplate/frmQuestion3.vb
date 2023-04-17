Public Class frmQuestion3
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (RadioButton1.Checked) Then
            playerScore = playerScore + 1
        End If

        frmHighScore.Show()
        frmHighScore.doScore()

        Me.Hide()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub frmQuestion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class