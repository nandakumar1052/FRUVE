Imports System.Data.SqlClient

Public Class DeleteEmployee

    Dim con As New SqlConnection(Loginconnection)
    Private Sub DeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clears()
        loaddata()

    End Sub

    Private Sub clears()

        Txt_Id.Text = ""
        Txt_fname.Text = ""
        Txt_lname.Text = ""
        Txt_Email.Text = ""
        Txt_photo.Text = ""
        Txt_Salary.Text = ""
        PictureBox_image.Image = Nothing

    End Sub

    Private Sub loaddata()

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            qry = "select Id, First_Name, Last_Name, DOB, Post, Address, Mobile, Email, Salary, Joindate from Employee where Post='" & "Employee" & "'"
            con.Open()
            ds = fetchproductdata1(qry)
            If ds.Tables(0).Rows.Count >= 0 Then

                FDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()

    End Sub

    Private Sub FDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FDataGrid.CellMouseClick

        If con.State = ConnectionState.Open Then

            con.Close()

        End If


        Try
            con.Open()
            Dim dr As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select * from Employee where Id like " & "(@P)"
            Dim ps As New SqlParameter("@P", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = FDataGrid.CurrentRow.Cells(0).Value
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Txt_Id.Text = dr("Id")
                Txt_fname.Text = dr("First_Name")
                Txt_lname.Text = dr("Last_Name")
                DOB.Value = dr("DOB")
                Txt_Email.Text = dr("Email")
                Txt_photo.Text = dr("Photo")
                Txt_Salary.Text = dr("Salary")
                PictureBox_image.Load(Txt_photo.Text)
            Loop
            dr.Close()
            cmd.Connection.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub Button_sign_in_Click(sender As Object, e As EventArgs) Handles Button_sign_in.Click

        Try
            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            If Txt_Salary.Text = "" Or Txt_photo.Text = "" Or Txt_Id.Text = "" Or Txt_fname.Text = "" Or Txt_lname.Text = "" Or Txt_Email.Text = "" Then

                MsgBox("column cannot be empty", MsgBoxStyle.Information)

            Else
                con.Open()
                Dim l As Integer = MsgBox("Do You Want To Update The Row", MsgBoxStyle.YesNo, "Modify")
                If l = 6 Then
                    qry = "Delete from Employee where Id = '" & Txt_Id.Text & "'"
                    i = insertproductdata1(qry)
                    If i > 0 Then

                        MsgBox("Removed Successfully", MsgBoxStyle.Information)
                        loaddata()
                        con.Close()
                        clears()
                        Txt_Id.Text = ""
                        Exit Sub

                    End If
                ElseIf l = 7 Then

                    MsgBox("Failed To Remove", MsgBoxStyle.Critical)
                    con.Close()
                    Exit Sub

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Txt_Search_TextChange(sender As Object, e As EventArgs) Handles Txt_Search.TextChange

        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Try

            con.Open()
            qry = "Select * from Employee where First_Name like '%' + '" & Txt_Search.Text & "' + '%' and Post='" & "Employee" & "'"
            ds = fetchproductdata1(qry)
            If ds.Tables(0).Rows.Count >= 0 Then

                FDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()

    End Sub

    Private Sub DeleteEmployee_Click(sender As Object, e As EventArgs) Handles Me.Click

        loaddata()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteEmployee_Load(sender, e)
    End Sub
End Class