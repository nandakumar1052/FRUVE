Imports System.Data.SqlClient

Public Class Profile

    Dim con As New SqlConnection(Loginconnection)
    Dim con1 As New SqlConnection(Dealerconnection)

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As Integer = 0
        Dim d As String = ""
        m = loadprofile(pro).Length - 10
        While m <= loadprofile(pro).Length - 1
            d = d + loadprofile(pro).Substring(m, 1)
            m = m + 1
        End While
        If d = "@FruVe.com" Then
            epro()
        ElseIf d = "Dealer.com" Then
            depro()
        Else
            MsgBox("Failed")
        End If

    End Sub

    Private Sub depro()
        Txt_Salary.Visible = False
        Txt_path.Visible = False
        LinkLabel1.Visible = False
        Label4.Visible = False
        Label13.Visible = False
        Label11.Visible = False
        DOB.Visible = False
        Dim cmd1 As New SqlCommand
        Dim dr1 As SqlDataReader
        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If

        Try
            con1.Open()
            cmd1.Connection = con1
            cmd1.Parameters.Clear()
            cmd1.CommandText = "select * from Dealer where Username = " & "(@AP)"
            Dim pq As New SqlParameter("@AP", SqlDbType.NVarChar)
            pq.Direction = ParameterDirection.Input
            pq.Value = loadprofile(pro)
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
    End Sub

    Private Sub epro()
        Txt_Salary.Visible = True
        Txt_path.Visible = False
        LinkLabel1.Visible = True
        Label4.Visible = True
        Label13.Visible = True
        Label11.Visible = True
        DOB.Visible = True
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            con.Open()
            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.CommandText = "select * from Employee where Username = " & "(@AP)"
            Dim pq As New SqlParameter("@AP", SqlDbType.NVarChar)
            pq.Direction = ParameterDirection.Input
            pq.Value = loadprofile(pro)
            cmd.Parameters.Add(pq)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Txt_Id.Text = dr("Id")
                Txt_fname.Text = dr("First_Name")
                Txt_lname.Text = dr("Last_Name")
                DOB.Value = dr("DOB")
                Txt_path.Text = dr("Certificate")
                Txt_Address.Text = dr("Address")
                Txt_Mobile.Text = dr("Mobile")
                Txt_City.Text = dr("City")
                Txt_State.Text = dr("State")
                Txt_Country.Text = dr("Country")
                Txt_Email.Text = dr("Email")
                Txt_photo.Text = dr("Photo")
                Txt_Salary.Text = dr("Salary")
                PictureBox_image.Load(Txt_photo.Text)
            Loop
            dr.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con1.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        loadfile(Txt_path.Text)
        Pdf.Show()
    End Sub
End Class