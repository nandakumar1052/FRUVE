Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Report

    Dim con As New SqlConnection(Productconnection)
    Dim p, pc As String
    Dim Pric As Integer

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        Chart1.Series("Income").Points.Clear()
        Chart1.Series("Expense").Points.Clear()
        If com1.Text = "Line Graph" Then
            If Txt_Search.Text <> "" Then
                Chart1.ChartAreas(0).AxisX.ScaleView.Size = Convert.ToInt32(Txt_Search.Text)
                Chart1.Series("Income").ChartType = SeriesChartType.Line
                Chart1.Series("Expense").ChartType = SeriesChartType.Line
                income()
                exp()
            Else
                MsgBox("Enter rows to display")
            End If
        ElseIf com1.Text = "Bar Graph" Then
            If Txt_Search.Text <> "" Then
                Chart1.ChartAreas(0).AxisX.ScaleView.Size = Convert.ToInt32(Txt_Search.Text)
                Chart1.Series("Income").ChartType = SeriesChartType.Column
                Chart1.Series("Expense").ChartType = SeriesChartType.Column
                income()
                exp()
            Else
                MsgBox("Enter rows to display")
            End If
        ElseIf com1.Text = "Pie Graph" Then
            If Txt_Search.Text <> "" Then
                Chart1.ChartAreas(0).AxisX.ScaleView.Size = Convert.ToInt32(Txt_Search.Text)
                Chart1.Series("Income").ChartType = SeriesChartType.Pie
                Chart1.Series("Expense").ChartType = SeriesChartType.Pie
                income()
                exp()
            Else
                MsgBox("Enter rows to display")
            End If
        Else
                MsgBox("Select Chart Type First")
        End If
    End Sub

    Private Sub income()
        Dim cmd As New SqlCommand

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try

            con.Open()
            cmd.CommandText = "Select ProductId, Product, Price from Income "
            cmd.Connection = con
            dr = cmd.ExecuteReader
            While dr.Read()
                p = dr("ProductId")
                pc = dr("Product")
                Pric = dr("Price")
                Chart1.Series("Income").Points.AddXY(pc + " ( " + p + " )", Pric)
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub exp()
        Dim cmd As New SqlCommand

        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        Try

            con.Open()
            cmd.CommandText = "Select ProductId, Product, Price from Expense "
            cmd.Connection = con
            dr = cmd.ExecuteReader
            While dr.Read()
                p = dr("ProductId")
                pc = dr("Product")
                Pric = dr("Price")
                Chart1.Series("Expense").Points.AddXY(pc + " ( " + p + " )", Pric)
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Search.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class