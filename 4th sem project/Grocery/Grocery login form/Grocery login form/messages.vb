Imports System.Drawing.Graphics

Public Class messages
    Private Sub messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As Integer = loadtim(t)
        Dim p As Integer = loadmess(mes)
        Dim q As Integer = loadmessy(messy)
        If s = 1 Then
            If p = 1 Then
                Label1.Text = loadmess(mes).ToString + " Order Pending"
            Else
                Label1.Text = loadmess(mes).ToString + " Orders Pending"
            End If
        ElseIf s = 2 Then
            If q = 1 Then
                Label1.Text = loadmessy(messy).ToString + " Item Delivered"
            Else
                Label1.Text = loadmessy(messy).ToString + " Items Delivered"
            End If
        Else
            Label1.Text = "Error"
        End If
        erd(Me)
        success()
    End Sub

    Private Sub erd(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Private Sub loc()

        Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, -78)
    End Sub

    Private Sub success()
        Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, -78)
        Me.ShowInTaskbar = False
        Opetimer.Enabled = True
        Opetimer.Start()
    End Sub

    Private Sub Opetimer_Tick(sender As Object, e As EventArgs) Handles Opetimer.Tick
        If Me.Location.Y = 0 Then
            Opetimer.Stop()
            Proxytimer.Enabled = True
            My.Computer.Audio.Play(My.Resources.done_for_you_612, AudioPlayMode.WaitToComplete)
            Proxytimer.Start()
        Else
            Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, Me.Location.Y + 1)
        End If
    End Sub

    Private Sub Closetimer_Tick(sender As Object, e As EventArgs) Handles Closetimer.Tick
        If Me.Location.Y = -155 Then
            Me.Close()
        Else
            Me.Location = New Point(My.Computer.Screen.Bounds.Width / 2 - 200, Me.Location.Y - 1)
        End If
    End Sub

    Private Sub Proxytimer_Tick(sender As Object, e As EventArgs) Handles Proxytimer.Tick
        Proxytimer.Stop()
        Closetimer.Enabled = True
        Closetimer.Start()
    End Sub
End Class