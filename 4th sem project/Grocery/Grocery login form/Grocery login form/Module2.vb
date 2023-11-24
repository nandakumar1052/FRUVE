Imports System.Data.SqlClient


Module Module2

    Public Productconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\4th sem project\Grocery\Grocery login form\Grocery login form\FruVe.mdf;Integrated Security=True"
    Public Loginconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\4th sem project\Grocery\Grocery login form\Grocery login form\Employee.mdf;Integrated Security=True"
    Public Dealerconnection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\4th sem project\Grocery\Grocery login form\Grocery login form\Dealer.mdf;Integrated Security=True"
    Public da As New SqlDataAdapter
    Public ps As New SqlParameter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public i As Integer = 0
    Public qry As String = ""
    Public amt, t, mes, messy As Integer
    Public l, f, d, m, n, pro, ph, pass As String


    Public Function fetchproductdata(ByVal qry As String) As DataSet

        Dim con As New SqlConnection(Productconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()

    End Function

    Public Function insertproductdata(ByVal qry As String) As Integer

        Dim con As New SqlConnection(Productconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        cmd = New SqlCommand(qry, con)
        i = cmd.ExecuteNonQuery()
        Return i
        con.Close()

    End Function

    Public Function insertproductdata1(ByVal qry As String) As Integer

        Dim con As New SqlConnection(Loginconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        cmd = New SqlCommand(qry, con)
        i = cmd.ExecuteNonQuery()
        Return i
        con.Close()

    End Function
    Public Function insertproductdata2(ByVal qry As String) As Integer

        Dim con As New SqlConnection(Dealerconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        cmd = New SqlCommand(qry, con)
        i = cmd.ExecuteNonQuery()
        Return i
        con.Close()

    End Function

    Public Function fetchproductdata1(ByVal qry As String) As DataSet

        Dim con As New SqlConnection(Loginconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()

    End Function
    Public Function fetchproductdata2(ByVal qry As String) As DataSet

        Dim con As New SqlConnection(Dealerconnection)
        If con.State = ConnectionState.Open Then

            con.Close()

        End If

        con.Open()
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()

    End Function

    Public Function loadname(ByVal name As String) As String

        n = name

        Return n

    End Function

    Public Function loadfile(ByVal file As String) As String

        f = file

        Return f

    End Function

    Public Function loadtim(ByVal tim As Integer) As Integer

        t = tim

        Return t

    End Function

    Public Function loadamount(ByVal amount As Integer) As Integer

        amt = amount

        Return amt

    End Function

    Public Function loadphoto(ByVal photo As String) As String

        ph = photo

        Return ph

    End Function

    Public Function loadprofile(ByVal profile As String) As String

        pro = profile

        Return pro

    End Function

    Public Function loadpassword(ByVal password As String) As String

        pass = password

        Return pass

    End Function

    Public Function loadmess(ByVal mess As Integer) As Integer

        mes = mess

        Return mes

    End Function

    Public Function loadmessy(ByVal messes As Integer) As Integer

        messy = messes

        Return messy

    End Function
End Module
