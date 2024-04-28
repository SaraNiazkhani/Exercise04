Public Class Form1

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Dim num As Integer
        num = Val(NumTextBox.Text)

        If (num > 0) Then
            OutputLabel.Text = num ^ 2
        Else
            OutputLabel.Text = "The number is not true..!!!"
        End If
    End Sub

    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        OutputLabel.Text = "End"
    End Sub
End Class
