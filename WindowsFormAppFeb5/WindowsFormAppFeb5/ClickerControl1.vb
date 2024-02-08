Public Class ClickerControl1
    Dim C As New Clicker
    Private Sub Click_Click(sender As Object, e As EventArgs) Handles Click.Click
        C.click()
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        C.reset()
    End Sub
End Class
