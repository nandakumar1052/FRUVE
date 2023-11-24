Imports System.Data.SqlClient

Public Class Order
    Dim con1 As New SqlConnection(Dealerconnection)

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        proddata()
        Txt_Search.Text = ""
        Txt_Pcode.Text = ""
        Txt_Product.Text = ""
        Txt_Stocks.Text = ""
        Label2.Text = ""
    End Sub

    Public Sub proddata()
        If con1.State = ConnectionState.Open Then

            con1.Close()

        End If

        Try
            qry = "select * from Prodadd where DealerName='" & loadname(n) & "'"
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

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Txt_Search.Text = "" Then

            proddata()

        Else

            If con1.State = ConnectionState.Open Then

                con1.Close()

            End If
            Try

                con1.Open()
                qry = "select * from Prodadd where Product like '%' + '" & Txt_Search.Text & "' + '%' and DealerName='" & loadname(n) & "'"
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
        End If
    End Sub

    Private Sub Btn_modify_Click(sender As Object, e As EventArgs) Handles Btn_modify.Click
        Try
            If con1.State = ConnectionState.Open Then

                con1.Close()

            End If
            con1.Open()
            qry = "update Prodadd set Price ='" & Txt_Pcode.Text & "' where Product = '" & Txt_Product.Text & "' and ProductId = '" & Label2.Text & "' and DealerName='" & loadname(n) & "'"
            cmd = New SqlCommand(qry, con1)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then

                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                proddata()
                con1.Close()
                maie()
                Txt_Search.Text = ""
                Txt_Pcode.Text = ""
                Txt_Product.Text = ""
                Txt_Stocks.Text = ""
                Label2.Text = ""
                Exit Sub

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con1.Close()
    End Sub

    Private Sub DealerDataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DealerDataGrid.CellMouseClick

        If DealerDataGrid.Rows.Count > 0 Then
            Label2.Text = DealerDataGrid.CurrentRow.Cells(2).Value
            Txt_Product.Text = DealerDataGrid.CurrentRow.Cells(1).Value
            Txt_Stocks.Text = DealerDataGrid.CurrentRow.Cells(3).Value
        End If

    End Sub

    Private Sub Txt_Pcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Pcode.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Order_Load(sender, e)
    End Sub

    Private Sub maie()
        proddata()
        Dim k As Integer = 0
        If DealerDataGrid.Rows.Count >= 0 Then

            For x = 0 To DealerDataGrid.Rows.Count - 1
                If IsDBNull(DealerDataGrid.Rows(x).Cells(4).Value) Then
                    k = k + 1
                Else

                End If
            Next
            If k = 0 Then
                Manager.Label7.Visible = False
            Else
                Manager.Label7.Text = k.ToString
            End If
        End If
    End Sub
End Class