Imports System.Data.SqlClient
Imports System.DateTime
Imports System.Drawing.Printing
Imports ZXing
Public Class billing

    Dim con As New SqlConnection(Productconnection)
    Dim stock, cost, pq As New Integer
    Dim sp, ustocks, it, costee, ice As Integer
    Dim asp As New Integer
    Dim ra As New Random
    Dim pc As New DataGridViewRow
    Private Sub billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        loaddata()
        RadioButtoncash.Checked = False
        RadioButtonCard.Checked = False
        rsp()
        code()

        Panel2.Height = GvProduct.Height + 220

        gvsetting()
        GvReceipt.Columns(0).Name = "Product"
        GvReceipt.Columns(1).Name = "Qty"
        GvReceipt.Columns(2).Name = "Price"

        GvReceipt.Columns(0).Width = 50
        GvReceipt.Columns(1).Width = 15
        GvReceipt.Columns(2).Width = 50

    End Sub

    Private Sub gvsetting()
        GvReceipt.ScrollBars = ScrollBars.None
        GvReceipt.RowHeadersVisible = False
        GvReceipt.ColumnCount = 3
        GvReceipt.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GvReceipt.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = Format(Now, "dd-MM-yyyy hh:mm:ss")

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

    Private Sub Txt_Search_Click(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Txt_Search.Text = "" Then

            loaddata()

        Else

            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            Try

                con.Open()
                qry = "select * from FruVe where Product like '%' + '" & Txt_Search.Text & "' + '%'"
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

    Private Sub Txt_Qty_TextChanged(sender As Object, e As EventArgs) Handles Txt_Qty.TextChanged
        If Txt_ProdId.Text = "" Or Txt_Prod.Text = "" Then


        Else
            If Txt_Qty.Text = "" Then

                Txt_Price.Text = ""
            Else
                If ice = 1 Then
                    Dim p As Integer = Convert.ToInt32(Txt_Qty.Text)
                    If p <= stock Then
                        Dim s As Integer = p * cost
                        Txt_Price.Text = s.ToString
                    Else

                        Exit Sub
                    End If
                ElseIf ice = 2 Then
                    doit()
                    Dim p As Integer = Convert.ToInt32(Txt_Qty.Text)
                    If p <= ustocks Then
                        Dim s As Integer = p * costee
                        Txt_Price.Text = s.ToString
                    Else
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ProductDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductDataGrid.CellMouseClick

        If Txt_ProdId.Text = "" Then

        Else
            Txt_ProdId.Clear()
            Txt_Prod.Clear()
            Txt_Qty.Clear()
            Txt_Price.Clear()
        End If
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try
            con.Open()
            Dim dr As SqlDataReader
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "select * from FruVe where ProductCode like " & "(@P)"
            Dim ps As New SqlParameter("@P", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = ProductDataGrid.CurrentRow.Cells(0).Value
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read
                Txt_Prod.Text = dr("Product")
                stock = dr("StocksRemaining")
                cost = dr("Price")
                Txt_ProdId.Text = dr("ProductCode")
            Loop
            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
        ice = 1
    End Sub

    Private Sub pay()
        If RadioButtoncash.Checked = True Then
            RadioButtonCard.Checked = False
            Label_Payment.Text = "Cash"
        ElseIf RadioButtonCard.Checked = True Then
            RadioButtoncash.Checked = False
            Label_Payment.Text = "Card"
        End If
    End Sub

    Private Sub RadioButtoncash_Click(sender As Object, e As EventArgs) Handles RadioButtoncash.Click
        RadioButtoncash.Checked = True
        pay()
    End Sub

    Private Sub RadioButtonCard_Click(sender As Object, e As EventArgs) Handles RadioButtonCard.Click
        RadioButtonCard.Checked = True
        pay()
    End Sub

    Private Sub rsp()

        asp = ra.Next(100000, 999999)

        Randomize()

        Label17.Text = asp.ToString()
    End Sub

    Private Sub resizes()
        GvReceipt.Height = GvReceipt.ColumnHeadersHeight + GvReceipt.Rows.Cast(Of DataGridViewRow).Sum(Function(r) r.Height)
        Panel2.Height = GvReceipt.Height + 220
        GvReceipt.ClearSelection()
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            If Txt_Qty.Text <> "" And Txt_Qty.Text <> "0" And Txt_ProdId.Text <> "" Then
                If stock >= Convert.ToInt32(Txt_Qty.Text) Then
                    Dim s As Integer = GvReceipt.Rows.Add
                    GvReceipt.Rows.Item(s).Cells(0).Value = Txt_Prod.Text + " ( " + Txt_ProdId.Text + " ) "
                    GvReceipt.Rows.Item(s).Cells(1).Value = Txt_Qty.Text
                    GvReceipt.Rows.Item(s).Cells(2).Value = Txt_Price.Text

                    Dim s1 As Integer = GvProduct.Rows.Add
                    GvProduct.Rows.Item(s1).Cells(0).Value = Txt_ProdId.Text
                    GvProduct.Rows.Item(s1).Cells(1).Value = Txt_Prod.Text
                    GvProduct.Rows.Item(s1).Cells(2).Value = Txt_Qty.Text
                    GvProduct.Rows.Item(s1).Cells(3).Value = Txt_Price.Text

                    gvsetting()
                    calc()

                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    con.Open()
                    Try
                        qry = "update FruVe set StocksRemaining ='" & (stock - Convert.ToInt32(Txt_Qty.Text)).ToString & "' where  ProductCode = '" & Txt_ProdId.Text & "'"
                        i = insertproductdata(qry)
                        If i > 0 Then

                            loaddata()
                            con.Close()
                            Txt_ProdId.Clear()
                            Txt_Prod.Clear()
                            Txt_Qty.Clear()
                            Txt_Price.Clear()
                            Exit Sub
                        End If
                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try
                    con.Close()

                        Txt_ProdId.Clear()
                        Txt_Prod.Clear()
                        Txt_Qty.Clear()
                        Txt_Price.Clear()
                        Else
                        MsgBox("failed to add")
                        Exit Sub
            End If
                MsgBox("Enter Quantity")
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub code()
        Dim writ As New BarcodeWriter
        writ.Format = BarcodeFormat.CODE_128
        PictureBox2.Image = writ.Write(Label17.Text)
    End Sub

    Private Sub calc()
        Try
            Dim t As Integer = 0
            For i = 0 To GvReceipt.Rows.Count - 1
                t = t + GvReceipt.Rows(i).Cells(2).Value
            Next
            Label_total.Text = t.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GvReceipt_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles GvReceipt.RowsRemoved
        resizes()
    End Sub

    Private Sub GvReceipt_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GvReceipt.RowsAdded
        resizes()
    End Sub

    Private Sub Btn_Purchase_Click(sender As Object, e As EventArgs) Handles Btn_Purchase.Click

        If RadioButtoncash.Checked = True Then
            pri()
        ElseIf RadioButtoncard.Checked = True Then
            loadamount(Convert.ToInt32(Label_total.Text))
            PaymentPortal.Show()
        End If
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Try
            If Txt_ProdId.Text <> "" And Txt_Qty.Text = loadti(sp).ToString Then

                If con.State = ConnectionState.Open Then

                    con.Close()

                End If
                doit()
                Try
                    con.Open()
                    qry = "update FruVe set StocksRemaining ='" & (ustocks + Convert.ToInt32(Txt_Qty.Text)).ToString & "' where  ProductCode = '" & Txt_ProdId.Text & "'"
                    i = insertproductdata(qry)
                    If i > 0 Then

                        loaddata()
                        con.Close()

                    End If
                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try
                con.Close()
                GvProduct.Rows.RemoveAt(loadpq(pq))
                GvReceipt.Rows.RemoveAt(loadpq(pq))
                gvsetting()
                calc()
                Txt_ProdId.Clear()
                Txt_Prod.Clear()
                Txt_Qty.Clear()
                Txt_Price.Clear()
            Else
                MsgBox("failed to remove")
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Try
            Dim us As Integer
            Dim pqr As Integer = GvProduct.Rows.Count - 1
            If GvProduct.Rows.Count >= 0 Then
                While pqr >= 0
                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    Try

                        con.Open()
                        cmd.Connection = con
                        cmd.CommandText = "select StocksRemaining from FruVe where ProductCode= " & " (@Username)"
                        Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
                        ps.Direction = ParameterDirection.Input
                        ps.Value = (GvProduct.Rows(pqr).Cells(0).Value).ToString
                        cmd.Parameters.Add(ps)
                        dr = cmd.ExecuteReader
                        Do While dr.Read

                            us = dr("StocksRemaining")
                        Loop

                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try
                    con.Close()

                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    Try
                        con.Open()
                        qry = "update FruVe set StocksRemaining ='" & (us + GvProduct.Rows(pqr).Cells(2).Value) & "' where  ProductCode = '" & (GvProduct.Rows(pqr).Cells(0).Value).ToString & "'"
                        i = insertproductdata(qry)
                        If i > 0 Then

                            loaddata()
                            con.Close()

                            Dim ds As New DataSet
                            Dim da As New SqlDataAdapter
                            Dim cmd As New SqlCommand

                        End If

                        GvProduct.Rows.RemoveAt(pqr)
                        GvReceipt.Rows.RemoveAt(pqr)
                        gvsetting()
                        calc()
                        pqr = pqr - 1
                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try
                    con.Close()
                End While
            End If
            Txt_ProdId.Clear()
            Txt_Prod.Clear()
            Txt_Qty.Clear()
            Txt_Price.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim g As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)

        Panel2.DrawToBitmap(g, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))
        e.Graphics.DrawImage(g, 0, 0)
        Dim ps As New PageSetupDialog
        ps.Document = PrintDocument1
    End Sub


    Private Sub doit()
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try

            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select StocksRemaining,Price from FruVe where ProductCode= " & " (@Username)"
            Dim ps As New SqlParameter("@Username", SqlDbType.NVarChar)
            ps.Direction = ParameterDirection.Input
            ps.Value = Txt_ProdId.Text
            cmd.Parameters.Add(ps)
            dr = cmd.ExecuteReader
            Do While dr.Read

                ustocks = dr("StocksRemaining")
                costee = dr("Price")
            Loop

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
        con.Close()
    End Sub


    Private Sub Btn_Modify_Click(sender As Object, e As EventArgs) Handles Btn_Modify.Click
        Try
            If Txt_Qty.Text <> "0" And Txt_Qty.Text <> "" Then
                If con.State = ConnectionState.Open Then

                    con.Close()

                End If
                doit()
                If sp > Convert.ToInt32(Txt_Qty.Text) Then
                    Try

                        Dim p As Integer = loadti(sp) - Convert.ToInt32(Txt_Qty.Text)
                        con.Open()
                        qry = "update FruVe set StocksRemaining ='" & (ustocks + p).ToString & "' where  ProductCode = '" & Txt_ProdId.Text & "'"
                        i = insertproductdata(qry)
                        If i > 0 Then

                            loaddata()
                            con.Close()

                        End If
                    Catch ex As Exception

                        MsgBox(ex.Message)

                    End Try
                    con.Close()
                    GvProduct.Rows(loadpq(pq)).Cells(2).Value = Convert.ToInt32(Txt_Qty.Text)
                    GvProduct.Rows(loadpq(pq)).Cells(3).Value = Convert.ToInt32(Txt_Price.Text)
                    GvReceipt.Rows(loadpq(pq)).Cells(1).Value = Convert.ToInt32(Txt_Qty.Text)
                    GvReceipt.Rows(loadpq(pq)).Cells(2).Value = Convert.ToInt32(Txt_Price.Text)
                ElseIf sp < Convert.ToInt32(Txt_Qty.Text) Then
                    If ustocks > Convert.ToInt32(Txt_Qty.Text) Then
                        Try
                            Dim p As Integer = Convert.ToInt32(Txt_Qty.Text) - loadti(sp)
                            con.Open()
                            qry = "update FruVe set StocksRemaining ='" & (ustocks - p).ToString & "' where  ProductCode = '" & Txt_ProdId.Text & "'"
                            i = insertproductdata(qry)
                            If i > 0 Then

                                loaddata()
                                con.Close()

                            End If
                        Catch ex As Exception

                            MsgBox(ex.Message)

                        End Try
                        con.Close()
                        GvProduct.Rows(loadpq(pq)).Cells(2).Value = Convert.ToInt32(Txt_Qty.Text)
                        GvProduct.Rows(loadpq(pq)).Cells(3).Value = Convert.ToInt32(Txt_Price.Text)
                        GvReceipt.Rows(loadpq(pq)).Cells(1).Value = Convert.ToInt32(Txt_Qty.Text)
                        GvReceipt.Rows(loadpq(pq)).Cells(2).Value = Convert.ToInt32(Txt_Price.Text)
                    Else
                        MsgBox("insufficient stock")
                    End If
                End If
                gvsetting()
                calc()

                Txt_ProdId.Clear()
                Txt_Prod.Clear()
                Txt_Qty.Clear()
                Txt_Price.Clear()
                con.Close()
            Else
                MsgBox("U can remove the Product")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GvProduct_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GvProduct.CellMouseClick
        If Txt_ProdId.Text = "" Then

        Else
            Txt_ProdId.Clear()
            Txt_Prod.Clear()
            Txt_Qty.Clear()
            Txt_Price.Clear()
        End If
        If e.RowIndex >= 0 Then
            loadpq(e.RowIndex)
            Dim r As DataGridViewRow = GvProduct.Rows(e.RowIndex)
            Txt_ProdId.Text = r.Cells(0).Value.ToString
            Txt_Prod.Text = r.Cells(1).Value.ToString
            Txt_Qty.Text = r.Cells(2).Value.ToString
            loadti(r.Cells(2).Value)
            Txt_Price.Text = r.Cells(3).Value.ToString
        End If
        ice = 2
    End Sub

    Public Function loadti(ByVal ti As Integer) As Integer

        sp = ti

        Return sp

    End Function

    Public Function loadpq(ByVal dpq As Integer) As Integer

        pq = dpq

        Return pq

    End Function

    Public Sub pri()
        Label21.Text = Label2.Text
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog1_Closed(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Closed

        Dim pp As Integer = GvProduct.Rows.Count - 1
        If GvProduct.Rows.Count > 0 Then
            While pp >= 0
                Try
                    If con.State = ConnectionState.Open Then

                        con.Close()

                    End If
                    con.Open()
                    cmd.Parameters.Clear()
                    qry = " insert into Income(ProductId,Product,Stock,Price,Date,PurchaseId) values(@ips,@f,@l,@a,@d,@id)"
                    cmd.Connection = con
                    cmd.CommandText = qry
                    Dim pi As New SqlParameter("@ips", SqlDbType.NVarChar)
                    pi.Value = GvProduct.Rows(pp).Cells(0).Value
                    Dim pf As New SqlParameter("@f", SqlDbType.NVarChar)
                    pf.Value = GvProduct.Rows(pp).Cells(1).Value
                    Dim pl As New SqlParameter("@l", SqlDbType.BigInt)
                    pl.Value = GvProduct.Rows(pp).Cells(2).Value
                    Dim pa As New SqlParameter("@a", SqlDbType.BigInt)
                    pa.Value = GvProduct.Rows(pp).Cells(3).Value
                    Dim pd As New SqlParameter("@d", SqlDbType.Date)
                    pd.Value = Now.Date.ToString()
                    Dim pid As New SqlParameter("@id", SqlDbType.BigInt)
                    pid.Value = Convert.ToInt32(Label17.Text)
                    cmd.Parameters.Add(pi)
                    cmd.Parameters.Add(pf)
                    cmd.Parameters.Add(pl)
                    cmd.Parameters.Add(pa)
                    cmd.Parameters.Add(pd)
                    cmd.Parameters.Add(pid)
                    Dim da As New SqlDataAdapter
                    da.InsertCommand = cmd
                    da.InsertCommand.ExecuteNonQuery()
                    loaddata()
                    con.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                GvProduct.Rows.RemoveAt(pp)
                GvReceipt.Rows.RemoveAt(pp)
                gvsetting()
                calc()
                pp = pp - 1
            End While
        End If
        Label21.Text = "-----"
        Txt_Price.Text = ""
        Txt_Prod.Text = ""
        Txt_ProdId.Text = ""
        Txt_Qty.Text = ""
    End Sub

    Private Sub Txt_Qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Qty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class