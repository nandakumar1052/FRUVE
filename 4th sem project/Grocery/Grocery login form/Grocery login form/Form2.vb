Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Manager
    Dim p As Integer
    Dim i As Integer = 0
    Dim q As Integer = 0
    Public Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Btn_Graph.Visible = True
        Btn_Dealer.Visible = True
        Btn_Employee.Visible = True
        Btn_Product.Visible = True
        Btn_Logout.Visible = True
        Btn_Profile.Visible = True
        Btn_Product.Text = "Product"
        Label3.Visible = False
        Label4.Visible = False
        Label7.Visible = False
        Label6.Visible = False
        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        Loading1.Hide()
        Label2.Text = loadname(n)
        Label1.Text = loadname(n)
        PictureBox1.ImageLocation = loadphoto(ph)
        BunifuPictureBox1.ImageLocation = loadphoto(ph)
        p = loadtim(t)
        If p = 1 Then
            Me.Text = "Dealer"
            Btn_Product.Text = "Orders"
            Btn_Graph.Visible = False
            Btn_Dealer.Visible = False
            Btn_Employee.Visible = False
            delar()
            If loadmess(mes) > 0 Then
                Grocery_login_form.messages.Show()
                Label7.Visible = True
                Label7.Text = loadmess(mes).ToString()
            End If
        ElseIf p = 3 Then
            Me.Text = "Employee"
            Btn_Product.Text = "Billing"
            Btn_Graph.Visible = False
            Btn_Dealer.Visible = False
            Btn_Employee.Visible = False
        ElseIf p = 2 Then
            Me.Text = "Manager"
            mavea()
            If loadmessy(messy) > 0 Then
                Grocery_login_form.messages.Show()
                Label6.Visible = True
                Label6.Text = loadmessy(messy).ToString()
            End If
        Else
            MsgBox("error")
        End If
        Dim pq As String = loadpassword(pass)
        If pq = "12345" Then
            ResetPassworddata.Show()
        End If

    End Sub

    Private Sub Btn_Product_Click(sender As Object, e As EventArgs) Handles Btn_Product.Click
        If p = 1 Then
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Panel5)
            q = 0
            BunifuRadioButton1.Visible = False
            BunifuRadioButton2.Visible = True
            BunifuRadioButton3.Visible = False
            BunifuRadioButton2.Checked = True
            Label3.Visible = False
            Label4.Visible = False
            BunifuTransition1.HideSync(Loadpanel)
            BunifuTransition1.ShowSync(Loadpanel)
            Try

                Order.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(Order)
                Order.Refresh()
                Order.Show()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        ElseIf p = 3 Then
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Panel5)
            q = 0
            BunifuRadioButton1.Visible = False
            BunifuRadioButton2.Visible = True
            BunifuRadioButton3.Visible = False
            BunifuRadioButton2.Checked = True
            Label3.Visible = False
            Label4.Visible = False
            BunifuTransition1.HideSync(Loadpanel)
            BunifuTransition1.ShowSync(Loadpanel)
            Try

                billing.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(billing)
                billing.Refresh()
                billing.Show()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        Else
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            BunifuTransition1.HideSync(Panel5)
            q = 0
            BunifuRadioButton1.Visible = False
            BunifuRadioButton2.Visible = True
            BunifuRadioButton3.Visible = False
            BunifuRadioButton2.Checked = True
            Label3.Visible = False
            Label4.Visible = False
            BunifuTransition1.HideSync(Loadpanel)
            BunifuTransition1.ShowSync(Loadpanel)
            Try

                Product.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(Product)
                Product.Refresh()
                Product.Show()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If
    End Sub


    Private Sub Btn_Employee_Click(sender As Object, e As EventArgs) Handles Btn_Employee.Click
        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        BunifuTransition1.HideSync(Loadpanel)
        q = 0
        i = 2

        Try
            BunifuTransition1.ShowSync(Loadpanel)
            AddEmployee.TopLevel = False
            Loadpanel.Controls.Clear()
            Loadpanel.Controls.Add(AddEmployee)
            AddEmployee.Show()
            BunifuRadioButton1.Visible = True
            BunifuRadioButton2.Visible = True
            BunifuRadioButton3.Visible = True
            BunifuRadioButton1.Checked = True
            BunifuRadioButton2.Checked = False
            BunifuRadioButton3.Checked = False
            Label3.Visible = False
            Label4.Visible = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub



    Private Sub Manager_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        messages.Close()
        Login.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        If q = 0 Then
            BunifuTransition1.ShowSync(Panel5)
            q = 1
        ElseIf q = 1 Then
            BunifuTransition1.HideSync(Panel5)
            q = 0
        End If

    End Sub

    Private Sub Loadpanel_Click(sender As Object, e As EventArgs) Handles Loadpanel.Click

        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        q = 0
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If i = 2 Or i = 3 Then

            If BunifuRadioButton2.Checked = True Then

                BunifuRadioButton1.Checked = True
                BunifuRadioButton3.Checked = False
                BunifuRadioButton2.Checked = False
                loaad()
            ElseIf BunifuRadioButton3.Checked = True Then

                BunifuRadioButton1.Checked = False
                BunifuRadioButton2.Checked = True
                BunifuRadioButton3.Checked = False
                loaad()
            End If

        End If
    End Sub

    Private Sub loaad()
        If BunifuRadioButton1.Checked = True Then
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            If i = 2 Then

                BunifuRadioButton2.Checked = False
                BunifuRadioButton3.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = False
                Label4.Visible = True
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                AddEmployee.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(AddEmployee)
                AddEmployee.Show()
            ElseIf i = 3 Then
                BunifuRadioButton2.Checked = False
                BunifuRadioButton3.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = False
                Label4.Visible = True
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                Dealer.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(Dealer)
                Dealer.Show()
            End If
        ElseIf BunifuRadioButton2.Checked = True Then
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            If i = 2 Then

                BunifuRadioButton3.Checked = False
                BunifuRadioButton1.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = True
                Label4.Visible = True
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                UpdateEmployee.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(UpdateEmployee)
                UpdateEmployee.Show()
            ElseIf i = 3 Then
                BunifuRadioButton3.Checked = False
                BunifuRadioButton1.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = True
                Label4.Visible = True
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                UpdateDealer.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(UpdateDealer)
                UpdateDealer.Show()
            End If
        ElseIf BunifuRadioButton3.Checked = True Then
            BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
            If i = 2 Then

                BunifuRadioButton2.Checked = False
                BunifuRadioButton1.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = True
                Label4.Visible = False
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                DeleteEmployee.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(DeleteEmployee)
                DeleteEmployee.Refresh()
                DeleteEmployee.Show()
            ElseIf i = 3 Then
                BunifuRadioButton2.Checked = False
                BunifuRadioButton1.Checked = False
                BunifuTransition1.HideSync(Loadpanel)
                q = 0
                Label3.Visible = True
                Label4.Visible = False
                BunifuTransition1.ShowSync(Loadpanel)
                Loadpanel.Controls.Clear()
                Productadd.TopLevel = False
                Loadpanel.Controls.Clear()
                Loadpanel.Controls.Add(Productadd)
                Productadd.Show()
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If i = 2 Or i = 3 Then

            If BunifuRadioButton1.Checked = True Then

                BunifuRadioButton2.Checked = True
                BunifuRadioButton3.Checked = False
                BunifuRadioButton1.Checked = False
                loaad()
            ElseIf BunifuRadioButton2.Checked = True Then

                BunifuRadioButton1.Checked = False
                BunifuRadioButton3.Checked = True
                BunifuRadioButton2.Checked = False
                loaad()
            End If

        End If

    End Sub

    Private Sub Btn_Dealer_Click(sender As Object, e As EventArgs) Handles Btn_Dealer.Click
        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        BunifuTransition1.HideSync(Loadpanel)
        q = 0
        i = 3

        Try
            BunifuTransition1.ShowSync(Loadpanel)
            Dealer.TopLevel = False
            Loadpanel.Controls.Clear()
            Loadpanel.Controls.Add(Dealer)
            Dealer.Show()
            BunifuRadioButton1.Visible = True
            BunifuRadioButton2.Visible = True
            BunifuRadioButton3.Visible = True
            BunifuRadioButton1.Checked = True
            BunifuRadioButton2.Checked = False
            BunifuRadioButton3.Checked = False
            Label3.Visible = False
            Label4.Visible = True
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_Graph_Click(sender As Object, e As EventArgs) Handles Btn_Graph.Click

        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        q = 0
        BunifuRadioButton1.Visible = False
        BunifuRadioButton2.Visible = True
        BunifuRadioButton3.Visible = False
        BunifuRadioButton2.Checked = True
        Label3.Visible = False
        Label4.Visible = False
        BunifuTransition1.HideSync(Loadpanel)
        BunifuTransition1.ShowSync(Loadpanel)
        Try

            Report.TopLevel = False
            Loadpanel.Controls.Clear()
            Loadpanel.Controls.Add(Report)
            Report.Refresh()
            Report.Show()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Btn_Profile_Click(sender As Object, e As EventArgs) Handles Btn_Profile.Click

        BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide
        BunifuTransition1.HideSync(Panel5)
        q = 0
        BunifuRadioButton1.Visible = False
        BunifuRadioButton2.Visible = True
        BunifuRadioButton3.Visible = False
        BunifuRadioButton2.Checked = True
        Label3.Visible = False
        Label4.Visible = False
        BunifuTransition1.HideSync(Loadpanel)
        BunifuTransition1.ShowSync(Loadpanel)
        Try

            Profile.TopLevel = False
            Loadpanel.Controls.Clear()
            Loadpanel.Controls.Add(Profile)
            Profile.Refresh()
            Profile.Show()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label5.Text = Format(Now, "dd-MM-yyyy        hh:mm:ss")

    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        Dim l As Integer = MsgBox("Are You Sure You Want to logout", MsgBoxStyle.YesNo)
        If l = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub delar()
        Order.proddata()
        Dim k As Integer = 0
        If Order.DealerDataGrid.Rows.Count >= 0 Then

            For x = 0 To Order.DealerDataGrid.Rows.Count - 1
                If IsDBNull(Order.DealerDataGrid.Rows(x).Cells(4).Value) Then
                    k = k + 1
                Else

                End If
            Next
            loadmess(k)
        End If
    End Sub

    Public Sub mavea()
        Productadd.proddata()
        Dim m As Integer = 0
        If Productadd.DealerDataGrid.Rows.Count >= 0 Then
            For x = 0 To Productadd.DealerDataGrid.Rows.Count - 1
                If IsDBNull(Productadd.DealerDataGrid.Rows(x).Cells(4).Value) Then

                Else
                    m = m + 1
                End If
            Next
            loadmessy(m)
        End If
    End Sub

End Class