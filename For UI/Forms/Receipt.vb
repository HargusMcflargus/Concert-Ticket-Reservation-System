Public Class Receipt
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dispose()
        Form1.Enabled = True
        Form1.TopMost = True
    End Sub
    Public Sub clear()
        nem.Clear()
        det.Clear()
        taym.Clear()
        det.Clear()
        ebentnem.Clear()
        ListBox1.Items.Clear()
        tototal.Clear()
        kakashi.Clear()
        chenji.Clear()
    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub
End Class