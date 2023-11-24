Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.ComponentModel
Imports System.IO
Public Class Captures

    Dim c As VideoCaptureDevice
    Dim m As Bitmap

    Private Sub Captures_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim cam As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
            If cam.ShowDialog = Windows.Forms.DialogResult.OK Then
                c = cam.VideoDevice
                AddHandler c.NewFrame, New NewFrameEventHandler(AddressOf Ca)
                c.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ca(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            m = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        SaveFileDialog1.DefaultExt = ".png"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
            UpdateEmployee.Txt_photo.Text = SaveFileDialog1.FileName
            UpdateEmployee.PictureBox_image.ImageLocation = SaveFileDialog1.FileName
            AddEmployee.Txt_photo.Text = SaveFileDialog1.FileName
            AddEmployee.PictureBox_image.ImageLocation = SaveFileDialog1.FileName
            Dealer.Txt_photo.Text = SaveFileDialog1.FileName
            Dealer.PictureBox_image.ImageLocation = SaveFileDialog1.FileName
            UpdateDealer.Txt_photo.Text = SaveFileDialog1.FileName
            UpdateDealer.PictureBox_image.ImageLocation = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub Captures_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            c.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class