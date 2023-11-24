Public Class Pdf
    Dim s As String
    Private Sub Pdf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s = loadfile(f)
        s = s.Replace("\", "/")
        AxAcroPDF1.src = s
    End Sub
End Class