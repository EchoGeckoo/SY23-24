Public Class ProductControl1
    Public Property ProductID As String
    Public Property Price As Decimal
    Public Property PCount As Integer
    Public Property Picture As Image

    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Picture
        IDLabel.Text = ProductID
        PriceLabel.Text = Price.ToString("C2")
    End Sub
    Public Sub Buy()
        If PCount > 0 Then
            PCount = PCount - 1
        End If
        If PCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class

