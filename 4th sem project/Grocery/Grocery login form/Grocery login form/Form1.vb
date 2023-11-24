Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Login

    Dim con As New SqlConnection(Loginconnection)
    Dim con1 As New SqlConnection(Dealerconnection)
    Dim i, j, k, p, u, l, w, s, phot, user As String
    Dim em As New MailMessage
    Dim r, a, c, d, x, o As New Integer
    Dim drag As Boolean
    Dim mm, mx As Integer
    Dim random As New Random()
    Dim td As DateTime
    Dim cd As TimeSpan = TimeSpan.FromMinutes(7)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuPanel1.BackgroundImage = Grocery_login_form.My.Resources.strawberries
        Panel1.BackgroundImage = Grocery_login_form.My.Resources.strawberries
        PictureBox1.Image = Grocery_login_form.My.Resources.login
        PictureBox2.Image = Grocery_login_form.My.Resources.login
        PictureBox3.Image = Grocery_login_form.My.Resources._1
        PictureBox4.Image = Grocery_login_form.My.Resources.key1
        Button_minimize.BackgroundImage = Grocery_login_form.My.Resources.minimize
        Button_close.BackgroundImage = Grocery_login_form.My.Resources.Close3
        Txtpassword.UseSystemPasswordChar = True
        Btn_Password_visible.BackgroundImage = Grocery_login_form.My.Resources.ph
        BunifuPanel1.Location = New Point(0, 35)
        Button2.BackColor = Color.Transparent

    End Sub

    Private Sub Button_minimize_MouseHover(sender As Object, e As EventArgs) Handles Button_minimize.MouseHover

        Button_minimize.FlatAppearance.BorderSize = 1

    End Sub

    Private Sub Button_close_MouseHover(sender As Object, e As EventArgs) Handles Button_close.MouseHover

        Button_close.FlatAppearance.BorderSize = 1

    End Sub

    Private Sub Button_close_MouseLeave(sender As Object, e As EventArgs) Handles Button_close.MouseLeave

        Button_close.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub Button_minimize_MouseLeave(sender As Object, e As EventArgs) Handles Button_minimize.MouseLeave

        Button_minimize.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub Button_minimize_Click(sender As Object, e As EventArgs) Handles Button_minimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button_close_Click(sender As Object, e As EventArgs) Handles Button_close.Click

        Application.Exit()

    End Sub

    Private Sub Btn_Password_visible_Click(sender As Object, e As EventArgs) Handles Btn_Password_visible.Click

        If Txtpassword.UseSystemPasswordChar = True Then

            Txtpassword.UseSystemPasswordChar = False
            Btn_Password_visible.BackgroundImage = Grocery_login_form.My.Resources.ps

        Else

            Txtpassword.UseSystemPasswordChar = True
            Btn_Password_visible.BackgroundImage = Grocery_login_form.My.Resources.ph

        End If

    End Sub

    Private Sub Button_sign_in_Click(sender As Object, e As EventArgs) Handles Button_sign_in.Click

        If Txtusername.Text = "" Then

            MessageBox.Show("Enter Username", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtusername.Clear()
            Exit Sub

        ElseIf Txtpassword.Text = "" Then

            MessageBox.Show("Enter Password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtpassword.Clear()
            Exit Sub

        ElseIf Txtusername.Text = "" And Txtpassword.Text = "" Then

            MessageBox.Show("Enter Username and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtusername.Clear()
            Txtpassword.Clear()
            Exit Sub

        Else
            Dim m As Integer = 0
            Dim d As String = ""
            m = Txtusername.Text.Length - 10
            While m <= Txtusername.Text.Length - 1
                d = d + Txtusername.Text.Substring(m, 1)
                m = m + 1
            End While
            If d = "@FruVe.com" Then
                logindataload()
                Exit Sub
            ElseIf d = "Dealer.com" Then
                dealerdataload()
                Exit Sub
            Else
                MsgBox("......")
                Exit Sub
            End If
        End If
    End Sub

    Public Sub dealerdataload()
        Dim cmd As New SqlCommand

        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If

        Try

            con1.Open()
            cmd.Connection = con1
            cmd.CommandText = "select Username,Password,First_Name,Last_Name,Photo from Dealer where Username= " & " (@Username)"
            Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = Txtusername.Text
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read
                i = dr("Password")
                k = dr("First_Name")
                w = dr("Last_Name")
                phot = dr("Photo")
                s = k + " " + w
                If Txtpassword.Text = i Then
                    loadprofile(Txtusername.Text)
                    loadname(s)
                    loadphoto(phot)
                    loadpassword(i)
                    o = 1
                    loadtim(o)
                    Me.Hide()
                    Loading1.Show()
                    Exit Sub
                Else

                    MessageBox.Show("Invalid Credientials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub

                End If
            Loop

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub logindataload()
        Dim cmd As New SqlCommand

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select Username,Password,Post,First_Name,Last_Name,Photo from Employee where Username= " & " (@Username)"
            Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = Txtusername.Text
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read
                i = dr("Password")
                j = dr("Post")
                k = dr("First_Name")
                w = dr("Last_Name")
                phot = dr("Photo")
                s = k + " " + w
                If Txtpassword.Text = i Then
                    loadprofile(Txtusername.Text)
                    loadname(s)
                    loadphoto(phot)
                    loadpassword(i)
                    If j = "Manager" Then

                        o = 2
                        loadtim(o)
                        Me.Hide()
                        Loading1.Show()
                        Exit Sub

                    ElseIf j = "Employee" Then

                        o = 3
                        loadtim(o)
                        Me.Hide()
                        Loading1.Show()

                        Exit Sub

                    End If

                Else

                    MessageBox.Show("Invalid Credientials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub

                End If
            Loop

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BunifuTextBox2_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox2.TextChanged
        Label5.Visible = False
    End Sub

    Private Sub BunifuTextBox4_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox4.TextChanged
        If BunifuTextBox4.Text = "" Then
            BunifuTextBox4.UseSystemPasswordChar = False
        Else
            BunifuTextBox4.UseSystemPasswordChar = True
        End If
        Label4.Visible = True
        If BunifuTextBox3.Text = BunifuTextBox4.Text Then
            Label4.Visible = False
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        BunifuTextBox1.Text = ""
        BunifuTextBox2.Text = ""
        BunifuTextBox3.Text = ""
        BunifuTextBox4.Text = ""
        BunifuButton2.Visible = False
        BunifuButton3.Visible = False
        BunifuTextBox2.Visible = False
        BunifuTextBox3.Visible = False
        BunifuTextBox4.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel1)
        BunifuTransition1.ShowSync(BunifuPanel1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(BunifuPanel1)
        BunifuTransition1.ShowSync(Panel1)
        BunifuButton1.Visible = True
        Timer1.Stop()

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click

        If Label3.Visible = False And Label4.Visible = False Then

            Try

                If BunifuTextBox3.Text = BunifuTextBox4.Text Then
                    Dim m As Integer = 0
                    Dim d As String = ""
                    m = BunifuTextBox1.Text.Length - 10
                    While m <= BunifuTextBox1.Text.Length - 1
                        d = d + BunifuTextBox1.Text.Substring(m, 1)
                        m = m + 1
                    End While
                    If d = "@FruVe.com" Then
                        If con.State = ConnectionState.Open Then

                            con.Close()

                        End If
                        Try
                            con.Open()
                            qry = "update Employee set Password ='" & BunifuTextBox3.Text & "' where Username = '" & BunifuTextBox1.Text & "'"
                            i = insertproductdata1(qry)
                            If i > 0 Then

                                MsgBox("Password Reset Successful", MsgBoxStyle.Information)
                                con.Close()
                                BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
                                BunifuTransition1.HideSync(BunifuPanel1)
                                BunifuTransition1.ShowSync(Panel1)
                                BunifuButton1.Visible = True
                            End If
                        Catch ex As Exception
                            MsgBox("Invalid User")
                        End Try

                    ElseIf d = "Dealer.com" Then
                        If con1.State = ConnectionState.Open Then

                            con1.Close()

                        End If
                        Try
                            con1.Open()
                            qry = "update Dealer set Password ='" & BunifuTextBox3.Text & "' where Username = '" & BunifuTextBox1.Text & "'"
                            i = insertproductdata2(qry)
                            If i > 0 Then

                                MsgBox("Password Reset Successful", MsgBoxStyle.Information)
                                con1.Close()
                                BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
                                BunifuTransition1.HideSync(BunifuPanel1)
                                BunifuTransition1.ShowSync(Panel1)
                                BunifuButton1.Visible = True
                            End If
                        Catch ex As Exception
                            MsgBox("Invalid User")
                        End Try
                    End If

                End If
            Catch ex As Exception
                MsgBox("Invalid User")
            End Try
        End If
    End Sub

    Private Sub BunifuTextBox3_TextChanged(sender As Object, e As EventArgs) Handles BunifuTextBox3.TextChanged
        If BunifuTextBox3.Text = "" Then
            BunifuTextBox3.UseSystemPasswordChar = False
        Else
            BunifuTextBox3.UseSystemPasswordChar = True
        End If
        a = 0
        d = 0
        c = 0
        Label3.Visible = True
        If BunifuTextBox3.Text.Length > 7 Then
            For x = 0 To BunifuTextBox3.Text.Length - 1

                If Char.IsDigit(BunifuTextBox3.Text.Substring(x, 1)) = True Then
                    a = a + 1
                ElseIf Char.IsLetter(BunifuTextBox3.Text.Substring(x, 1)) = True Then
                    c = c + 1
                Else
                    d = d + 1
                End If
            Next
            If a > 0 And c > 0 And d > 0 Then
                Label3.Visible = False

            End If
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try

            Timer1.Interval = 100
            td = DateTime.Now.Add(cd)

            Dim cmd As New SqlCommand
            Dim m As Integer = 0
            Dim d As String = ""
            m = BunifuTextBox1.Text.Length - 10
            While m <= BunifuTextBox1.Text.Length - 1
                d = d + BunifuTextBox1.Text.Substring(m, 1)
                m = m + 1
            End While
            If d = "@FruVe.com" Then
                If con.State = ConnectionState.Open Then

                    con.Close()

                End If

                Try

                    con.Open()
                    cmd.Connection = con
                    cmd.CommandText = "select Username,Email from Employee where Username= " & " (@U)"
                    Dim pq As New SqlParameter("@U", SqlDbType.NVarChar)
                    pq.Direction = ParameterDirection.Input
                    pq.Value = BunifuTextBox1.Text
                    cmd.Parameters.Add(pq)
                    dr = cmd.ExecuteReader
                    Do While dr.Read
                        p = dr("Email")
                    Loop
                    Try
                        em.From = New MailAddress("FruVe77@gmail.com")
                        em.To.Add(p)
                        em.Subject = "FruVe OTP for Password Reset"
                        em.Body = "Your OTP is " + rand().ToString + ""
                        Dim z As New SmtpClient("smtp.gmail.com")
                        Dim q As Integer = "587"
                        z.Port = q
                        z.EnableSsl = True
                        z.Credentials = New System.Net.NetworkCredential("FruVe77@gmail.com", "77@FruVe.com")
                        z.Send(em)
                        BunifuTextBox2.Visible = True
                        PictureBox6.Visible = True
                        BunifuButton3.Visible = True
                        BunifuButton1.Visible = False
                        Label7.Visible = True
                        Timer1.Start()
                    Catch ex As Exception
                        MsgBox("Invalid User")
                    End Try
                Catch ex As Exception
                    MsgBox("Invalid User")
                End Try
                con.Close()
            ElseIf d = "Dealer.com" Then
                If con1.State = ConnectionState.Open Then

                    con1.Close()

                End If

                Try

                    con1.Open()
                    cmd.Connection = con1
                    cmd.CommandText = "select Username,Email from Dealer where Username= " & " (@U)"
                    Dim pq As New SqlParameter("@U", SqlDbType.NVarChar)
                    pq.Direction = ParameterDirection.Input
                    pq.Value = BunifuTextBox1.Text
                    cmd.Parameters.Add(pq)
                    dr = cmd.ExecuteReader
                    Do While dr.Read
                        p = dr("Email")
                    Loop
                    Try
                        em.From = New MailAddress("FruVe77@gmail.com")
                        em.To.Add(p)
                        em.Subject = "FruVe OTP for Password Reset"
                        em.Body = "Your OTP is " + rand().ToString + ""
                        Dim z As New SmtpClient("smtp.gmail.com")
                        Dim q As Integer = "587"
                        z.Port = q
                        z.EnableSsl = True
                        z.Credentials = New System.Net.NetworkCredential("FruVe77@gmail.com", "77@FruVe.com")
                        z.Send(em)
                        BunifuTextBox2.Visible = True
                        PictureBox6.Visible = True
                        BunifuButton3.Visible = True
                        BunifuButton1.Visible = False
                        Label7.Visible = True
                        Timer1.Start()
                    Catch ex As Exception
                        MsgBox("Invalid User")
                    End Try
                Catch ex As Exception
                    MsgBox("Invalid User")
                End Try
                con1.Close()
            Else
                MsgBox("Wrong Username")
            End If
        Catch ex As Exception
            MsgBox("Invalid Username")
        End Try
    End Sub

    Public Function rand()

        Randomize()
        r = random.[Next](1000, 9999)
        Return r
    End Function

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click

        If BunifuTextBox2.Text = r.ToString Then
            Timer1.Stop()
            Label7.Text = "00:00"
            BunifuTextBox3.Visible = True
            BunifuTextBox4.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            Label3.Visible = True
            BunifuButton2.Visible = True
            Label7.Visible = False
            BunifuButton3.Visible = False
            PictureBox6.Visible = False
            Label5.Visible = False
            BunifuTextBox2.Visible = False
        Else

            Label5.Visible = True

        End If

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim cs As TimeSpan = td.Subtract(DateTime.Now)
        If cs.TotalMilliseconds > 0 Then

            Label7.Text = cs.ToString("mm\:ss")
        Else
            Label7.Text = "00:00"
            BunifuButton2.Visible = False
            BunifuButton1.Visible = True
            BunifuTextBox2.Visible = False
            PictureBox6.Visible = False
            BunifuButton3.Visible = False
            Timer1.Stop()

        End If

    End Sub

    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown
        drag = True
        mx = Cursor.Position.X - Me.Left
        mm = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mx
            Me.Top = Cursor.Position.Y - mm
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp
        drag = False
    End Sub

    Private Sub BunifuTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuTextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txtpassword_TextChanged(sender As Object, e As EventArgs) Handles Txtpassword.TextChanged
        If Txtpassword.Text = "" Then
            Txtpassword.UseSystemPasswordChar = False
        Else
            Txtpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
