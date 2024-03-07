Public Class frm2DPlatformer
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isjumping = True
        End Select
    End Sub
    Private Sub timerRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += 15
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isjumping = False
        End Select
    End Sub
    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= movespeed
    End Sub
    Private Sub timerUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= movespeed
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub
    Private Sub timerGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isjumping = False Then
                tmrGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "win" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        lightPB.Visible = False
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub timerGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += movespeed
    End Sub
End Class
