Imports System.Data.SqlClient
Imports System.IO
Imports System.DateTime

Public Class UpdateDealer

    Dim con As New SqlConnection(Dealerconnection)
    Dim con1 As New SqlConnection(Dealerconnection)
    Dim j As Integer
    Dim a, x As New Integer
    Dim img, p, v, k, o As String
    Dim path, s As String
    Dim dr1 As SqlDataReader
    Dim cmd1 As New SqlCommand
    Dim d As New Date

    Private Sub UpdateDealer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Id.Text = ""
        clears()
        loaddata()
        Panel_Employee.Visible = True
        FDataGrid.Visible = True
        Label17.Visible = False
        Label16.Visible = False
    End Sub
    Private Sub loaddata()

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            qry = "select Id,First_Name,Last_Name,Address,City,State,Country,Mobile,Email,Photo,Joindate from Dealer"
            con.Open()
            ds = fetchproductdata2(qry)
            If ds.Tables(0).Rows.Count >= 0 Then

                FDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()

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

    Private Sub Txt_Address_Click(sender As Object, e As EventArgs) Handles Txt_Address.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_Address.ReadOnly = False
        End If
    End Sub

    Private Sub Txt_City_Click(sender As Object, e As EventArgs) Handles Txt_City.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_City.ReadOnly = False

        End If
    End Sub

    Private Sub Txt_State_Click(sender As Object, e As EventArgs) Handles Txt_State.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_State.ReadOnly = False

        End If
    End Sub

    Private Sub Txt_Country_Click(sender As Object, e As EventArgs) Handles Txt_Country.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_Country.ReadOnly = False

        End If
    End Sub

    Private Sub Txt_Mobile_Click(sender As Object, e As EventArgs) Handles Txt_Mobile.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_Mobile.ReadOnly = False

        End If
    End Sub

    Private Sub Txt_Email_Click(sender As Object, e As EventArgs) Handles Txt_Email.Click
        readonlytext()
        Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then

            Txt_Email.ReadOnly = False

        End If
    End Sub

    Private Sub Btn_Upload_Image_Click(sender As Object, e As EventArgs) Handles Btn_Upload_Image.Click
        Try
            Dim l As Integer = MsgBox("Do You Want To Update ", MsgBoxStyle.YesNo, "Modify")
            If l = 6 Then
                OpenFileDialog1.Filter = "image file (*.jpg *.png *.jpeg)|*.jpg;*.png;*.jpeg"
                If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                    Dim imgpath As String = OpenFileDialog1.FileName
                    PictureBox_image.ImageLocation = imgpath
                    Txt_photo.Text = OpenFileDialog1.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If Label16.Visible = True Or Label17.Visible = True Then

            MsgBox("check validation")

        Else
            Try
                If con.State = ConnectionState.Open Then

                    con.Close()

                End If
                If Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_photo.Text = "" Then

                    MsgBox("column cannot be empty", MsgBoxStyle.Information)

                Else
                    con.Open()
                    Dim l As Integer = MsgBox("Do You Want To Update The Row", MsgBoxStyle.YesNo, "Modify")
                    If l = 6 Then
                        qry = "update Dealer set Address ='" & Txt_Address.Text & "',City ='" & Txt_City.Text & "',State ='" & Txt_State.Text & "',Country ='" & Txt_Country.Text & "',Mobile ='" & Txt_Mobile.Text & "',Email ='" & Txt_Email.Text & "',Photo ='" & Txt_photo.Text & "' where Id = '" & Txt_Id.Text & "'"
                        i = insertproductdata2(qry)
                        If i > 0 Then

                            MsgBox("Updated Successfully", MsgBoxStyle.Information)
                            clears()
                            loaddata()
                            con.Close()
                            Txt_Id.Text = ""
                            Exit Sub

                        End If
                    ElseIf l = 7 Then

                        MsgBox("Update Failed", MsgBoxStyle.Critical)
                        con.Close()
                        Exit Sub

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FDataGrid.CellMouseClick

        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If

        Try
            con1.Open()
            cmd1.Connection = con1
            cmd1.Parameters.Clear()
            cmd1.CommandText = "select * from Dealer where Id like " & "(@AP)"
            Dim pq As New SqlParameter("@AP", SqlDbType.NVarChar)
            pq.Direction = ParameterDirection.Input
            pq.Value = FDataGrid.CurrentRow.Cells(0).Value
            cmd1.Parameters.Add(pq)
            dr1 = cmd1.ExecuteReader
            Do While dr1.Read
                Txt_Id.Text = dr1("Id")
                Txt_fname.Text = dr1("First_Name")
                Txt_lname.Text = dr1("Last_Name")
                Txt_Address.Text = dr1("Address")
                Txt_Mobile.Text = dr1("Mobile")
                Txt_City.Text = dr1("City")
                Txt_State.Text = dr1("State")
                Txt_Country.Text = dr1("Country")
                Txt_Email.Text = dr1("Email")
                Txt_photo.Text = dr1("Photo")
                PictureBox_image.Load(Txt_photo.Text)
            Loop
            dr1.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con1.Close()
        loaddata()
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

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Try
            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            If Txt_Address.Text = "" Or Txt_City.Text = "" Or Txt_Country.Text = "" Or Txt_State.Text = "" Or Txt_Mobile.Text = "" Or Txt_photo.Text = "" Then

                MsgBox("column cannot be empty", MsgBoxStyle.Information)

            Else
                con.Open()
                Dim l As Integer = MsgBox("Do You Want To Remove The Dealer", MsgBoxStyle.YesNo, "Modify")
                If l = 6 Then
                    qry = "Delete from Dealer where Id = '" & Txt_Id.Text & "'"
                    i = insertproductdata2(qry)
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

    Private Sub Txt_fname_Click(sender As Object, e As EventArgs) Handles Txt_fname.Click

        MsgBox("first name cannot be edited", MsgBoxStyle.Information)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateDealer_Load(sender, e)
    End Sub

    Private Sub Txt_lname_Click(sender As Object, e As EventArgs) Handles Txt_lname.Click

        MsgBox("last name cannot be edited", MsgBoxStyle.Information)

    End Sub

    Private Sub Txt_Search_TextChange(sender As Object, e As EventArgs) Handles Txt_Search.TextChange

        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Try

            con.Open()
            qry = "Select * from Dealer where Id Like '%' + '" & Txt_Search.Text & "' + '%' or First_Name like '%' + '" & Txt_Search.Text & "' + '%'"
            ds = fetchproductdata2(qry)
            If ds.Tables(0).Rows.Count >= 0 Then

                FDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()

    End Sub

    Private Sub Txt_Mobile_TextChanged(sender As Object, e As EventArgs) Handles Txt_Mobile.TextChanged
        a = 0
        x = 0
        Label16.Visible = True
        If Txt_Mobile.Text.Length > 9 And Txt_Mobile.Text.Length < 16 Then
            For x = 0 To Txt_Mobile.Text.Length - 1
                If Char.IsDigit(Txt_Mobile.Text.Substring(x, 1)) = True Then

                    a = a + 1

                End If
            Next
            If Txt_Mobile.Text.Length = a Then
                Label16.Visible = False
            End If
        End If
    End Sub

    Private Sub Txt_Email_TextChanged(sender As Object, e As EventArgs) Handles Txt_Email.TextChanged
        x = 0
        Label17.Visible = True
        Try
            s = ""
            x = Txt_Email.Text.Length - 10
            Label17.Visible = True
            While x <= Txt_Email.Text.Length - 1
                s = s + Txt_Email.Text.Substring(x, 1)
                x = x + 1
            End While
            If s = "@gmail.com" Then
                Label17.Visible = False
            End If
        Catch ex As Exception

        End Try
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

End Class