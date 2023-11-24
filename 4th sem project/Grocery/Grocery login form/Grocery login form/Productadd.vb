Imports System.Data.SqlClient
Imports System.DateTime
Public Class Productadd

    Dim con As New SqlConnection(Productconnection)
    Dim con1 As New SqlConnection(Dealerconnection)
    Dim f, l As String
    Dim p As Integer
    Private Sub Productadd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If
        loaddata()
        proddata()
        con1.Open()
        com1.Items.Clear()
        Try
            cmd.CommandText = "Select First_Name, Last_Name from Dealer "
            cmd.Connection = con1
            dr = cmd.ExecuteReader
            While dr.Read()
                f = dr("First_Name")
                l = dr("Last_Name")
                com1.Items.Add(f + " " + l)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con1.Close()
        com1.Text = ""
        Txt_Pcode.Text = ""
        Txt_percent.Text = ""
        Txt_Product.Text = ""
        Txt_Stocks.Text = ""
        Txt_Search.Text = ""

    End Sub
    Public Sub proddata()
        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If

        Try
            qry = "select * from Prodadd"
            con1.Open()
            da = New SqlDataAdapter(qry, con1)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count >= 0 Then

                DealerDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con1.Close()
    End Sub
    Private Sub loaddata()

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            qry = "select * from FruVe"
            con.Open()
            ds = fetchproductdata(qry)
            If ds.Tables(0).Rows.Count >= 0 Then

                ProductDataGrid.DataSource = ds.Tables(0)

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Txt_Search.Text = "" Then

            loaddata()

        Else

            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            Try

                con.Open()
                qry = "select * from FruVe where Product like '%' + '" & Txt_search.Text & "' + '%'"
                ds = fetchproductdata(qry)
                If ds.Tables(0).Rows.Count >= 0 Then

                    ProductDataGrid.DataSource = ds.Tables(0)

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
            con.Close()
        End If
    End Sub

    Private Sub Btn_modify_Click(sender As Object, e As EventArgs) Handles Btn_modify.Click

        If com1.Text = "" Or Txt_Product.Text = "" Or Txt_Pcode.Text = "" Or Txt_Stocks.Text = "" Then
            MsgBox("column empty")

        Else
            Try
                If con.State = ConnectionState.Open Then

                    con.Close()

                End If
                con1.Open()
                qry = " insert into Prodadd(DealerName,Product,ProductId,Stock) values(@i,@f,@l,@d)"
                cmd.Connection = con1
                cmd.CommandText = qry
                cmd.Parameters.Clear()
                Dim pi As New SqlParameter("@i", SqlDbType.NVarChar)
                pi.Value = com1.Text
                Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
                pf.Value = Txt_Product.Text
                Dim pl As New SqlParameter("@l", SqlDbType.NVarChar)
                pl.Value = Txt_Pcode.Text
                Dim pd As New SqlParameter("@d", SqlDbType.BigInt)
                pd.Value = Txt_Stocks.Text
                cmd.Parameters.Add(pi)
                cmd.Parameters.Add(pf)
                cmd.Parameters.Add(pl)
                cmd.Parameters.Add(pd)
                Dim da As New SqlDataAdapter
                da.InsertCommand = cmd
                da.InsertCommand.ExecuteNonQuery()
                MsgBox("Order Sent", MsgBoxStyle.Information)
                com1.Text = ""
                Txt_Pcode.Text = ""
                Txt_percent.Text = ""
                Txt_Product.Text = ""
                Txt_Stocks.Text = ""
                Txt_Search.Text = ""
            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If
        con1.Close()
        proddata()

    End Sub


    Private Sub ProductDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductDataGrid.CellMouseClick

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            con.Open()
            Dim dr As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select Product,StocksRemaining,ProductCode from FruVe where ProductCode like " & "(@P)"
            Dim ps As New SqlParameter("@P", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = ProductDataGrid.CurrentRow.Cells(0).Value
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Txt_Product.Text = dr("Product")
                Txt_Stocks.Text = dr("StocksRemaining")
                Txt_Pcode.Text = dr("ProductCode")
            Loop
            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub

    Private Sub Btn_Purchase_Click(sender As Object, e As EventArgs) Handles Btn_Purchase.Click
        Try
            If IsDBNull(DealerDataGrid.CurrentRow.Cells(4).Value) Then
                MsgBox("Price yet not given")
            Else
                Dim l As Integer = MsgBox("Do You Want To Purchase", MsgBoxStyle.YesNo, "Modify")
                If l = 6 Then
                    Try
                        Dim s As New Integer
                        For s = 0 To ProductDataGrid.Rows.Count - 1
                            If ProductDataGrid.Rows(s).Cells(0).Value = DealerDataGrid.CurrentRow.Cells(2).Value Then
                                p = ProductDataGrid.Rows(s).Cells(2).Value
                                modi()
                                expense()
                                loed()
                                Exit Sub
                            End If
                        Next
                        Try
                            Dim sp As New Integer
                            For sp = 0 To ProductDataGrid.Rows.Count - 1
                                If ProductDataGrid.Rows(sp).Cells(0).Value <> DealerDataGrid.CurrentRow.Cells(2).Value Then
                                    If con.State = ConnectionState.Open Then

                                        con.Close()

                                    End If
                                    con.Open()
                                    cmd.Parameters.Clear()
                                    qry = " insert into FruVe(ProductCode,Product,StocksRemaining,Price) values(@i,@f,@l,@a)"
                                    cmd.Connection = con
                                    cmd.CommandText = qry
                                    Dim pi As New SqlParameter("@i", SqlDbType.NVarChar)
                                    pi.Value = DealerDataGrid.CurrentRow.Cells(2).Value
                                    Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
                                    pf.Value = DealerDataGrid.CurrentRow.Cells(1).Value
                                    Dim pl As New SqlParameter("@l", SqlDbType.BigInt)
                                    pl.Value = DealerDataGrid.CurrentRow.Cells(3).Value
                                    Dim pa As New SqlParameter("@a", SqlDbType.BigInt)
                                    pa.Value = loadPrice(DealerDataGrid.CurrentRow.Cells(4).Value)
                                    cmd.Parameters.Add(pi)
                                    cmd.Parameters.Add(pf)
                                    cmd.Parameters.Add(pl)
                                    cmd.Parameters.Add(pa)
                                    Dim da As New SqlDataAdapter
                                    da.InsertCommand = cmd
                                    da.InsertCommand.ExecuteNonQuery()
                                    MsgBox("Purchase success ", MsgBoxStyle.Information)
                                    loaddata()
                                    con.Close()
                                    expense()
                                    loed()
                                    Exit Sub
                                End If
                            Next

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf l = 7 Then
                    MsgBox("Purchase Failed", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loed()
        proddata()
        If DealerDataGrid.Rows.Count >= 0 Then
            Dim m As Integer = 0
            For x = 0 To DealerDataGrid.Rows.Count - 1
                If IsDBNull(DealerDataGrid.Rows(x).Cells(4).Value) Then

                Else
                    m = m + 1
                End If
            Next
            If m = 0 Then
                Manager.Label6.Visible = False
            Else
                Manager.Label6.Text = m.ToString
            End If
        End If
    End Sub

    Public Function loadPrice(ByVal Price As Integer) As Integer
        Dim k, o As Integer
        k = Price
        o = 0
        If Txt_percent.Text <> "" Then
            o = (Convert.ToInt32(Txt_percent.Text) / 100) * k
        End If

        Return (k + o)

    End Function

    Private Sub modi()
        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Try
            con.Open()
            qry = "update FruVe set StocksRemaining ='" & p + DealerDataGrid.CurrentRow.Cells(3).Value & "',Price ='" & loadPrice(DealerDataGrid.CurrentRow.Cells(4).Value) & "' where ProductCode = '" & DealerDataGrid.CurrentRow.Cells(2).Value & "'"
            i = insertproductdata(qry)
            If i > 0 Then

                MsgBox("item added", MsgBoxStyle.Information)
                loaddata()
                con.Close()
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub DealerDataGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DealerDataGrid.CellMouseDoubleClick

        Dim l As Integer = MsgBox("Do You Want To Cancel The Order", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then
            del()
            MsgBox("Order cancelled", MsgBoxStyle.Information)
        ElseIf l = 7 Then

            MsgBox("Failed To Remove", MsgBoxStyle.Critical)
            Exit Sub

        End If
        loed()
    End Sub
    Private Sub del()
        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If
        Try
            con1.Open()
            qry = "Delete from Prodadd where DealerName = '" & DealerDataGrid.CurrentRow.Cells(0).Value.ToString & "' and Product = '" & DealerDataGrid.CurrentRow.Cells(1).Value.ToString & "' and ProductId = '" & DealerDataGrid.CurrentRow.Cells(2).Value.ToString & "' and Stock = '" & DealerDataGrid.CurrentRow.Cells(3).Value.ToString & "'"
            cmd = New SqlCommand(qry, con1)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then

                proddata()
                con.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con1.Close()
    End Sub

    Private Sub expense()
        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        Try
            con.Open()
            cmd.Parameters.Clear()
            qry = " insert into Expense(ProductId,Product,Stock,Price,Date) values(@i,@f,@l,@a,@d)"
            cmd.Connection = con
            cmd.CommandText = qry
            Dim pi As New SqlParameter("@i", SqlDbType.NVarChar)
            pi.Value = DealerDataGrid.CurrentRow.Cells(2).Value
            Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
            pf.Value = DealerDataGrid.CurrentRow.Cells(1).Value
            Dim pl As New SqlParameter("@l", SqlDbType.BigInt)
            pl.Value = DealerDataGrid.CurrentRow.Cells(3).Value
            Dim pa As New SqlParameter("@a", SqlDbType.BigInt)
            pa.Value = DealerDataGrid.CurrentRow.Cells(3).Value * DealerDataGrid.CurrentRow.Cells(4).Value
            Dim pd As New SqlParameter("@d", SqlDbType.Date)
            pd.Value = Now.Date.ToString()
            cmd.Parameters.Add(pi)
            cmd.Parameters.Add(pf)
            cmd.Parameters.Add(pl)
            cmd.Parameters.Add(pa)
            cmd.Parameters.Add(pd)
            Dim da As New SqlDataAdapter
            da.InsertCommand = cmd
            da.InsertCommand.ExecuteNonQuery()
            del()
            loaddata()
            proddata()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Stocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Stocks.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Txt_percent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_percent.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Txt_Product_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Product.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Productadd_Load(sender, e)

    End Sub

    Private Sub Txt_Pcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pcode.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

End Class
