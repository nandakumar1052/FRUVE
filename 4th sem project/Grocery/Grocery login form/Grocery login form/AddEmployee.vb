Imports System.Data.SqlClient
Imports System.IO
Imports System.DateTime
Imports System.Net.Mail

Public Class AddEmployee
    Dim em As New MailMessage
    Dim con As New SqlConnection(Loginconnection)
    Dim j As Integer
    Dim a, x As New Integer
    Dim img, p, v, k, o, s As String
    Dim path As String

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Id.Text = ""
        clears()
        LinkLabel1.Visible = False
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
        Txt_Salary.ReadOnly = True
        Txt_path.ReadOnly = True
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
        Txt_Salary.ReadOnly = False
        Txt_path.ReadOnly = True
        Txt_photo.ReadOnly = True

    End Sub

    Private Sub Btn_Upload_Certificate_Click(sender As Object, e As EventArgs) Handles Btn_Upload_Certificate.Click
        Try
            OpenFileDialog1.Filter = "Pdf file (*.pdf *.doc *.docx)|*.pdf;*.doc;*.docx"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Txt_path.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            If Txt_Id.Text = "" Or Txt_fname.Text = "" Or Txt_lname.Text = "" Or Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_Salary.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_path.Text = "" Or Txt_photo.Text = "" Then

                MsgBox("column cannot be empty", MsgBoxStyle.Information)

            Else
                Try
                    con.Open()
                    cmd.Parameters.Clear()
                    qry = " insert into Employee(Id,First_Name,Last_Name,DOB,Username,Password,Post,Certificate,Address,Mobile,Email,City,State,Country,Salary,Joindate,Photo) values(@i,@f,@l,@d,@u,@p,@po,@c,@a,@m,@e,@ci,@s,@co,@sa,@j,@ph)"
                    cmd.Connection = con
                    cmd.CommandText = qry
                    Dim pi As New SqlParameter("@i", SqlDbType.NVarChar)
                    pi.Value = Txt_Id.Text
                    Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
                    pf.Value = Txt_fname.Text
                    Dim pl As New SqlParameter("@l", SqlDbType.NVarChar)
                    pl.Value = Txt_lname.Text
                    Dim pd As New SqlParameter("@d", SqlDbType.Date)
                    pd.Value = DOB.Value
                    Dim pu As New SqlParameter("@u", SqlDbType.NVarChar)
                    pu.Value = Txt_Id.Text + "@FruVe.com"
                    Dim pp As New SqlParameter("@p", SqlDbType.NVarChar)
                    pp.Value = "12345"
                    Dim ppo As New SqlParameter("@po", SqlDbType.NVarChar)
                    ppo.Value = "Employee"
                    Dim pc As New SqlParameter("@c", SqlDbType.NVarChar)
                    pc.Value = Txt_path.Text
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
                    Dim psa As New SqlParameter("@sa", SqlDbType.BigInt)
                    psa.Value = Txt_Salary.Text
                    Dim pj As New SqlParameter("@j", SqlDbType.Date)
                    pj.Value = Now.Date.ToString
                    Dim pph As New SqlParameter("@ph", SqlDbType.NVarChar)
                    pph.Value = Txt_photo.Text
                    cmd.Parameters.Add(pi)
                    cmd.Parameters.Add(pf)
                    cmd.Parameters.Add(pl)
                    cmd.Parameters.Add(pd)
                    cmd.Parameters.Add(pu)
                    cmd.Parameters.Add(pp)
                    cmd.Parameters.Add(ppo)
                    cmd.Parameters.Add(pc)
                    cmd.Parameters.Add(pa)
                    cmd.Parameters.Add(pm)
                    cmd.Parameters.Add(pe)
                    cmd.Parameters.Add(pci)
                    cmd.Parameters.Add(ps)
                    cmd.Parameters.Add(pco)
                    cmd.Parameters.Add(psa)
                    cmd.Parameters.Add(pj)
                    cmd.Parameters.Add(pph)
                    Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                    MsgBox("Employee added successfully", MsgBoxStyle.Information)
                    k = Txt_Id.Text + "@FruVi.com"
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

        If Txt_fname.Text = "" Or Txt_lname.Text = "" Or Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_Salary.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_path.Text = "" Or Txt_photo.Text = "" Then

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
        Txt_path.Text = ""
        Txt_photo.Text = ""
        Txt_Salary.Text = ""
        PictureBox_image.Image = Nothing

    End Sub


    Private Sub Txt_path_TextChanged(sender As Object, e As EventArgs) Handles Txt_path.TextChanged

        If Txt_path.Text = "" Then

            LinkLabel1.Visible = False

        Else

            LinkLabel1.Visible = True

        End If

    End Sub

    Private Sub Btn_Capture_Click(sender As Object, e As EventArgs) Handles Btn_Capture.Click

        Grocery_login_form.Captures.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddEmployee_Load(sender, e)
    End Sub

    Private Sub Txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles Txt_Mobile.TextChanged
        a = 0
        x = 0
        Label15.Visible = True
        If Txt_Mobile.Text.Length > 9 And Txt_Mobile.Text.Length < 16 Then
            For x = 0 To Txt_Mobile.Text.Length - 1
                If Char.IsDigit(Txt_Mobile.Text.Substring(x, 1)) = True Then

                    a = a + 1

                End If
            Next
            If Txt_Mobile.Text.Length = a Then
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        loadfile(Txt_path.Text)
        Pdf.Show()

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

    Private Sub Txt_Salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Salary.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
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