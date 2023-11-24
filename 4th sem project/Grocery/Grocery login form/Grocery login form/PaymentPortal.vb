Imports System.Data.SqlClient

Public Class PaymentPortal

    Dim con As New SqlConnection(Productconnection)
    Dim i, cv As String
    Dim am As Integer
    Private Sub PaymentPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = loadamount(amt)
        Panel1.Visible = True

    End Sub

    Private Sub Txt_CardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CardNumber.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Txt_holder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_holder.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Txt_CardNumber_TextChanged(sender As Object, e As EventArgs) Handles Txt_CardNumber.TextChanged

        PictureBox2.Image = Nothing
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        If Txt_CardNumber.Text.Length > 12 Then
            MsgBox("Card Number should be 12 digits only ")
            Txt_CardNumber.Text = ""
        End If
        If Txt_CardNumber.Text.Length = 12 Then

            Dim cmd As New SqlCommand

            If con.State = ConnectionState.Open Then

                con.Close()

            End If

            Try

                con.Open()
                cmd.Connection = con
                cmd.CommandText = "select * from Card where Cnum= " & " (@Username)"
                Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
                ps.Direction = ParameterDirection.Input
                ps.Value = Convert.ToInt64(Txt_CardNumber.Text)
                cmd.Parameters.Add(ps)
                dr = cmd.ExecuteReader
                Do While dr.Read
                    i = dr("Ctype")
                    If i = "Visa" Then

                        PictureBox2.Image = My.Resources.visa

                    ElseIf i = "Maestro" Then

                        PictureBox2.Image = My.Resources.Maestro

                    ElseIf i = "Master" Then

                        PictureBox2.Image = My.Resources.master

                    ElseIf i = "Rupay" Then

                        PictureBox2.Image = My.Resources.Rupay

                    Else

                        Exit Sub

                    End If
                Loop
                dr.Close()
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
            con.Close()
        End If
    End Sub

    Private Sub Btn_modify_Click(sender As Object, e As EventArgs) Handles Btn_modify.Click

        Dim cmd As New SqlCommand

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from Card where Cnum= " & " (@Username)"
            Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = Convert.ToInt64(Txt_CardNumber.Text)
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read

                cv = dr("Cname")
                am = dr("Amount")

            Loop
            If cv = Txt_holder.Text Then
                If am > Convert.ToInt32(Label2.Text) Then

                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    con.Open()
                    Try
                        qry = "update Card set Amount ='" & (am - Convert.ToInt32(Label2.Text)) & "' where  Cnum = '" & Txt_CardNumber.Text & "'"
                        i = insertproductdata(qry)
                        If i > 0 Then
                            dr.Close()
                            con.Close()
                            Panel1.Visible = False
                            Timer1.Interval = 7000
                            PictureBox1.Image = My.Resources.Success
                            Timer1.Start()
                        End If
                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try
                    con.Close()
                Else
                    MsgBox("Insufficient amount in card")
                End If
            End If
            dr.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        PictureBox1.Image = Nothing
        Me.Close()
        billing.Show()
        billing.pri()
    End Sub
End Class