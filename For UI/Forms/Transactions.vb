Public Class Transactions
    Dim connection As new OleDb.OleDbConnection
    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = Form1.connectionString
        connection.Open()
        searchBar_TextChanged(searchBar, e)
    End Sub

    Private Sub searchBar_TextChanged(sender As Object, e As EventArgs) Handles searchBar.TextChanged
        Dim command As New OleDb.OleDbCommand("SELECT ID,eventName,customerName,seat,DT,time FROM history WHERE eventName like '%" & searchBar.Text & "%' OR customerName like '%" & searchBar.Text & "%' OR DT like '%" & searchBar.Text & "%' OR seat like '%" & searchBar.Text & "%'", connection)
        Dim table As New DataTable()
        table.Load(command.ExecuteReader())
        matches.DataSource = table
    End Sub

    Private Sub matches_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles matches.CellClick
        Dim command As New OleDb.OleDbCommand("SELECT * FROM history WHERE ID=" & matches.SelectedRows(0).Cells(0).Value.ToString(), connection)
        Dim reader As OleDb.OleDbDataReader = command.ExecuteReader()
        reader.Read()
        currentID.Text = reader.GetValue(0)
        currentEvent.Text = reader.GetString(7)
        currentName.Text = reader.GetString(1)
        currentSeat.Text = reader.GetString(4)
        currentDate.Text = reader.GetString(2)
        currentTime.Text = reader.GetString(5)
        currentPrice.Text = reader.GetValue(3)
        currentCash.Text = reader.GetValue(6)
        currentChange.Text = reader.GetValue(6) - reader.GetValue(3)
        user.Text = reader.GetString(8)
    End Sub
End Class