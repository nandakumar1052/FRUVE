Imports System.Data.SqlClient

Public Class ResetPassworddata

    Dim A, c, d As Integer
    Dim con As New SqlConnection(Loginconnection)
    Dim con1 As New SqlConnection(Dealerconnection)
    Private Sub Txt_holder_TextChanged(sender As Object, e As EventArgs) Handles Txt_holder.TextChanged
        Label4.Visible = True
        If Txt_holder.Text = "" Then
            Txt_holder.UseSystemPasswordChar = False
        Else
            Txt_holder.UseSystemPasswordChar = True
        End If
        If Txt_holder.Text = Txt_CardNumber.Text Then
            Label4.Visible = False
        End If
    End Sub

    Private Sub Btn_modify_Click(sender As Object, e As EventArgs) Handles Btn_modify.Click
        If Label3.Visible = False And Label4.Visible = False Then
            Dim p As Integer = loadtim(t)

            If Txt_CardNumber.Text = Txt_holder.Text Then
                If p = 2 Or p = 3 Then
                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    Try
                        con.Open()
                        qry = "update Employee set Password ='" & Txt_CardNumber.Text & "' where Username = '" & loadprofile(pro) & "'"
                        i = insertproductdata1(qry)
                        If i > 0 Then

                            MsgBox("Password Reset Successful", MsgBoxStyle.Information)
                            con.Close()
                            Manager.Enabled = True
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Invalid User")
                    End Try
                ElseIf p = 1 Then
                    If con1.State = ConnectionState.Open Then

                        con1.Close()

                    End If
                    Try
                        con1.Open()
                        qry = "update Dealer set Password ='" & Txt_CardNumber.Text & "' where Username = '" & loadprofile(pro) & "'"
                        i = insertproductdata2(qry)
                        If i > 0 Then

                            MsgBox("Password Reset Successful", MsgBoxStyle.Information)
                            con1.Close()
                            Manager.Enabled = True
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Invalid User")
                    End Try
                End If
            Else
                MsgBox("Failed")
            End If
        End If
    End Sub

    Private Sub Txt_CardNumber_TextChanged(sender As Object, e As EventArgs) Handles Txt_CardNumber.TextChanged
        If Txt_CardNumber.Text = "" Then
            Txt_CardNumber.UseSystemPasswordChar = False
        Else
            Txt_CardNumber.UseSystemPasswordChar = True
        End If
        A = 0
        d = 0
        c = 0
        Label3.Visible = True
        If Txt_CardNumber.Text.Length > 7 Then
            For x = 0 To Txt_CardNumber.Text.Length - 1

                If Char.IsDigit(Txt_CardNumber.Text.Substring(x, 1)) = True Then
                    A = A + 1
                ElseIf Char.IsLetter(Txt_CardNumber.Text.Substring(x, 1)) = True Then
                    c = c + 1
                Else
                    d = d + 1
                End If
            Next
            If A > 0 And c > 0 And d > 0 Then
                Label3.Visible = False

            End If
        End If
    End Sub

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Manager.Enabled = False
        Txt_CardNumber.Text = ""
        Txt_holder.Text = ""
        Label3.Visible = False
        Label4.Visible = False
    End Sub
End Class