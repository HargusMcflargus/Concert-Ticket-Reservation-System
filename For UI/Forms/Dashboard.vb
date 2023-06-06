Public Class Dashboard
    Dim boxes As Object()
    Dim current = 0
    Dim connection As New OleDb.OleDbConnection()
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = Form1.connectionString
        connection.Open()
        refreshDisplay()
    End Sub
End Class