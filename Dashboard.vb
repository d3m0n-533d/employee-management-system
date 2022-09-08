Public Class Dashboard

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Try
            Dim exitStatus As DialogResult = MessageBox.Show("Are You Sure You Want To Quit Program ?", "QUIT PROGRAM", MessageBoxButtons.YesNo)
            ' check if user clicked yes
            If exitStatus = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Sorry, failed to Exit program.", "EXIT ERROR")
        End Try
    End Sub
End Class
