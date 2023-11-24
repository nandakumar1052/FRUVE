Imports System.Data.SqlClient

Public Class Product

    Dim con As New SqlConnection(Productconnection)

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddata()
        Txt_Search.Text = ""
        Txt_Pcode.Text = ""
        Txt_Product.Text = ""
        Txt_Stocks.Text = ""
        Txt_Price.Text = ""

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



    Private Sub Btn_modify_Click(sender As Object, e As EventArgs) Handles Btn_modify.Click

        If con.State = ConnectionState.Open Then

            con.Close()

        End If
        If Txt_Stocks.Text = "" Or Txt_Product.Text = "" Or Txt_Price.Text = "" Then

        Else
            Try
                con.Open()
                Dim l As Integer = MsgBox("Do You Want To Update The Row", MsgBoxStyle.YesNo, "Modify")
                If l = 6 Then
                    qry = "update FruVe set Price ='" & Txt_Price.Text & "' where  ProductCode = '" & Txt_Pcode.Text & "'"
                    i = insertproductdata(qry)
                    If i > 0 Then

                        MsgBox("Updated Successfully", MsgBoxStyle.Information)
                        loaddata()
                        con.Close()
                        Exit Sub

                    End If
                ElseIf l = 7 Then

                    MsgBox("Update Failed", MsgBoxStyle.Critical)
                    con.Close()
                    Exit Sub

                End If

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try
        End If
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

    Private Sub ProductDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProductDataGrid.CellMouseClick

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
                Txt_Product.Text = dr("Product")
                Txt_Stocks.Text = dr("StocksRemaining")
                Txt_Price.Text = dr("Price")
                Txt_Pcode.Text = dr("ProductCode")
            Loop
            dr.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Product_Load(sender, e)
    End Sub

    Private Sub ProductDataGrid_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ProductDataGrid.MouseDoubleClick
        Dim l As Integer = MsgBox("Do You Want To Cancel The Order", MsgBoxStyle.YesNo, "Modify")
        If l = 6 Then
            If con.State = ConnectionState.Open Then

                con.Close()

            End If
            Try
                con.Open()
                qry = "Delete from FruVe where ProductCode = '" & ProductDataGrid.CurrentRow.Cells(0).Value.ToString & "'"
                cmd = New SqlCommand(qry, con)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then

                    loaddata()
                    con.Close()
                    MsgBox("Product Removed", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf l = 7 Then

            MsgBox("Failed To Remove", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Private Sub Txt_Price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class