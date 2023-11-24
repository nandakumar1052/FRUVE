Imports System.Data.SqlClient
Imports System.IO
Imports System.DateTime
Imports System.Net.Mail
Public Class Dealer
    Dim em As New MailMessage
    Dim con As New SqlConnection(Dealerconnection)
    Dim j As Integer
    Dim a, x As New Integer
    Dim img, p, v, k, o, s As String

    Private Sub Dealer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Id.Text = ""
        clears()
        Panel_Employee.Visible = True
        Txt_Id.ReadOnly = True
        readnotonlytext()
        Label15.Visible = False
        Label16.Visible = False
    End Sub
    Private Sub readonlytext()

        Txt_Address.ReadOnly = True
        Txt_City.ReadOnly = True
        Txt_State.ReadOnly = True
        Txt_Country.ReadOnly = True
        Txt_Mobile.ReadOnly = True
        Txt_Email.ReadOnly = True
        Txt_photo.ReadOnly = True

    End Sub

    Private Sub readnotonlytext()

        Txt_fname.ReadOnly = False
        Txt_lname.ReadOnly = False
        Txt_Address.ReadOnly = False
        Txt_City.ReadOnly = False
        Txt_State.ReadOnly = False
        Txt_Country.ReadOnly = False
        Txt_Mobile.ReadOnly = False
        Txt_Email.ReadOnly = False
        Txt_photo.ReadOnly = True

    End Sub

    Private Sub Btn_Upload_Image_Click(sender As Object, e As EventArgs) Handles Btn_Upload_Image.Click

        Try
            OpenFileDialog1.Filter = "image file (*.jpg *.png *.jpeg)|*.jpg;*.png;*.jpeg"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim imgpath As String = OpenFileDialog1.FileName
                PictureBox_image.ImageLocation = imgpath
                Txt_photo.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If Label15.Visible = True Or Label16.Visible = True Then
            MsgBox("Check the validations")
        Else
            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            If Txt_Id.Text = "" Or Txt_fname.Text = "" Or Txt_lname.Text = "" Or Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_photo.Text = "" Then

                MsgBox("column cannot be empty", MsgBoxStyle.Information)

            Else
                Try
                    con.Open()
                    cmd.Parameters.Clear()
                    qry = " insert into Dealer(Id,First_Name,Last_Name,Address,Mobile,Email,City,State,Country,Photo,Joindate,Username,Password) values(@i,@f,@l,@a,@m,@e,@ci,@s,@co,@ph,@j,@u,@p)"
                    cmd.Connection = con
                    cmd.CommandText = qry
                    Dim pi As New SqlParameter("@i", SqlDbType.NVarChar)
                    pi.Value = Txt_Id.Text
                    Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
                    pf.Value = Txt_fname.Text
                    Dim pl As New SqlParameter("@l", SqlDbType.NVarChar)
                    pl.Value = Txt_lname.Text
                    Dim pa As New SqlParameter("@a", SqlDbType.NVarChar)
                    pa.Value = Txt_Address.Text
                    Dim pm As New SqlParameter("@m", SqlDbType.BigInt)
                    pm.Value = Txt_Mobile.Text
                    Dim pe As New SqlParameter("@e", SqlDbType.NVarChar)
                    pe.Value = Txt_Email.Text
                    Dim pci As New SqlParameter("@ci", SqlDbType.NVarChar)
                    pci.Value = Txt_City.Text
                    Dim ps As New SqlParameter("@s", SqlDbType.NVarChar)
                    ps.Value = Txt_State.Text
                    Dim pco As New SqlParameter("@co", SqlDbType.NVarChar)
                    pco.Value = Txt_Country.Text
                    Dim pph As New SqlParameter("@ph", SqlDbType.NVarChar)
                    pph.Value = Txt_photo.Text
                    Dim pj As New SqlParameter("@j", SqlDbType.Date)
                    pj.Value = Now.Date.ToString
                    Dim pu As New SqlParameter("@u", SqlDbType.NVarChar)
                    pu.Value = Txt_Id.Text + "@Dealer.com"
                    Dim pp As New SqlParameter("@p", SqlDbType.NVarChar)
                    pp.Value = "12345"
                    cmd.Parameters.Add(pi)
                    cmd.Parameters.Add(pf)
                    cmd.Parameters.Add(pl)
                    cmd.Parameters.Add(pa)
                    cmd.Parameters.Add(pm)
                    cmd.Parameters.Add(pe)
                    cmd.Parameters.Add(pci)
                    cmd.Parameters.Add(ps)
                    cmd.Parameters.Add(pco)
                    cmd.Parameters.Add(pph)
                    cmd.Parameters.Add(pj)
                    cmd.Parameters.Add(pu)
                    cmd.Parameters.Add(pp)
                    Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                    MsgBox("Dealer added successfully", MsgBoxStyle.Information)
                    k = Txt_Id.Text + "@Dealer.com"
                    o = Txt_Email.Text
                    Txt_Id.Text = ""
                    clears()
                    Try
                        em.From = New MailAddress("FruVe77@gmail.com")
                        em.To.Add(o)
                        em.Subject = "Your Username and default password"
                        em.Body = "You Username is " + k + " and Password is 12345 "
                        Dim z As New SmtpClient("smtp.gmail.com")
                        Dim q As Integer = "587"
                        z.Port = q
                        z.EnableSsl = True
                        z.Credentials = New System.Net.NetworkCredential("FruVe77@gmail.com", "77@FruVe.com")
                        z.Send(em)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
            End If
        End If
    End Sub

    Private Sub Btn_Generate_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        If Txt_fname.Text = "" Or Txt_lname.Text = "" Or Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_photo.Text = "" Then

            MsgBox("Fill all columns before generating the id ", MsgBoxStyle.Information)

        Else
            p = Now.Year.ToString
            v = Txt_Mobile.Text.Substring(0, 5)
            Txt_Id.Text = p + Txt_fname.Text + v

        End If
    End Sub


    Private Sub clears()

        Txt_fname.Text = ""
        Txt_lname.Text = ""
        Txt_Address.Text = ""
        Txt_City.Text = ""
        Txt_State.Text = ""
        Txt_Country.Text = ""
        Txt_Mobile.Text = ""
        Txt_Email.Text = ""
        Txt_photo.Text = ""
        PictureBox_image.Image = Nothing

    End Sub



    Private Sub Btn_Capture_Click(sender As Object, e As EventArgs) Handles Btn_Capture.Click

        Grocery_login_form.Captures.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dealer_Load(sender, e)
    End Sub

    Private Sub Txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles Txt_Mobile.TextChanged
        A = 0
        x = 0
        Label15.Visible = True
        If Txt_Mobile.Text.Length > 9 And Txt_Mobile.Text.Length < 16 Then
            For x = 0 To Txt_Mobile.Text.Length - 1
                If Char.IsDigit(Txt_Mobile.Text.Substring(x, 1)) = True Then

                    A = A + 1

                End If
            Next
            If Txt_Mobile.Text.Length = A Then
                Label15.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Email_TextChanged(sender As Object, e As EventArgs) Handles Txt_Email.TextChanged
        x = 0
        Label16.Visible = True
        Try
            s = ""
            x = Txt_Email.Text.Length - 10
            Label16.Visible = True
            While x <= Txt_Email.Text.Length - 1
                s = s + Txt_Email.Text.Substring(x, 1)
                x = x + 1
            End While
            If s = "@gmail.com" Then
                Label16.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Txt_fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_fname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_lname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_City.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_State_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_State.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_Country_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Country.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_Mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Mobile.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class