
Public Class Loading1

    Private Sub Loading1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ProgressBar1.Value = 0
        Timer1.Start()
        PictureBox1.Image = Grocery_login_form.My.Resources.login
        ProgressBar1.Animated = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= 200 Then
            ProgressBar1.Increment(10)
        Else
            ProgressBar1.Increment(3)
            If ProgressBar1.Value = 300 Then
                Timer1.Stop()
                Manager.Show()
                Me.Close()
            End If
        End If
    End Sub


End Class