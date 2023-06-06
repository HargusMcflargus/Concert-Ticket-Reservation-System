Public Class UpcomingConcerts
    Dim started = True
    Dim changes = False
    Dim connection As New OleDb.OleDbConnection
    Dim file As New OpenFileDialog

    'refresh eventview kasi nakakahaba ng code
    Private Sub Represh()
        Dim command As New OleDb.OleDbCommand("SELECT eventName,eventDate,eventTime FROM events ORDER BY eventName ASC", connection)
        Dim table As New DataTable()
        table.Load(command.ExecuteReader())
        eventView.DataSource = table
    End Sub

    'clear everthing
    Private Sub clearEverything()
        started = True
        currentEvent.Clear()
        currentDate.Value = Today
        timePicker.Value = Now
        prices.Rows(0).SetValues(New String() {"0", "0", "0"})
        removeEvent.Enabled = False
        addButton.Enabled = True
        editButton.Enabled = False
        eventIcon.Image = Image.FromFile("Resources\InsertImage.png")
        changes = False
    End Sub

    Private Sub UpcomingConcerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get connection string from form1
        connection.ConnectionString = Form1.connectionString
        connection.Open()

        If Form1.userLogged Then
            'if user is logged, disable editing and adding
            eventDetails.Enabled = False
        End If
        'disable editing since nothing is selected in eventView
        editButton.Enabled = False

        'set date of date time picker on startup
        currentDate.Value = Today
        timePicker.Value = Now

        'set values of another datagridview prices
        prices.Rows.Add(New String() {"0", "0", "0"})

        'preps image
        eventIcon.Image = Image.FromFile("Resources\InsertImage.png")

        'refresh event view
        Represh()
    End Sub

    Private Sub UpcomingConcerts_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'removes selection for the first time loading
        If started Then
            eventView.ClearSelection()
            started = False
            removeEvent.Enabled = False
        End If
    End Sub

    Private Sub eventView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles eventView.CellClick
        Dim command As New OleDb.OleDbCommand("SELECT Top 1 * FROM events WHERE eventName='" & eventView.SelectedRows(0).Cells(0).Value & "' AND eventDate='" & eventView.SelectedRows(0).Cells(1).Value & "' AND eventTime='" & eventView.SelectedRows(0).Cells(2).Value & "'", connection)
        Dim reader As OleDb.OleDbDataReader = command.ExecuteReader()
        reader.Read()
        currentEvent.Text = reader.GetString(0)
        currentDate.Value = Date.Parse(reader.GetString(1))
        timePicker.Value = Date.Parse(reader.GetString(2))
        eventIcon.Image = Image.FromFile(reader.GetString(8))
        For i = 0 To 2
            prices.Rows(0).Cells(i).Value = reader.GetDecimal(i + 3)
        Next
        addButton.Enabled = False
        editButton.Enabled = True
        removeEvent.Enabled = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'para sa search
        Dim command As New OleDb.OleDbCommand("SELECT eventName, eventDate, eventTime FROM events WHERE eventName like '%" & TextBox1.Text & "%' OR eventDate like '%" & TextBox1.Text & "%' OR eventTime like '%" & TextBox1.Text & "%'", connection)
        Dim table As New DataTable
        table.Load(command.ExecuteReader())
        If table.Rows.Count > 0 Then
            eventView.DataSource = table
            started = True
        Else
            MessageBox.Show("No Matches")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If file.ShowDialog() = DialogResult.OK Then
            eventIcon.Image = Image.FromFile(file.FileName)
        End If
        'para malaman kung editing or adding a new entry
        If eventView.SelectedRows.Count > 0 Then
            changes = True
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        If Not currentEvent.Text = "" And Not file.FileName = "" Then
            Dim match = False

            'checks in db
            Dim command As New OleDb.OleDbCommand("SELECT eventDate, eventTime FROM events WHERE eventDate='" & currentDate.Value.ToShortDateString() & "'", connection)
            Dim table As New DataTable
            table.Load(command.ExecuteReader())
            For Each item In table.Rows
                For i = 0 To 3
                    If Date.Parse(item.Item(1)) <= timePicker.Value.AddHours(i) And timePicker.Value.AddHours(i) < Date.Parse(item.Item(1)).AddHours(3) Then
                        match = True
                        Exit For
                    End If
                Next
            Next

            If timePicker.Value > Date.Parse("9:00 pm") Or timePicker.Value < Date.Parse("05:00 am") Then
                'Restricts times frames to not overshoot
                MessageBox.Show("Unable to reserve that time")

            ElseIf currentDate.Value < Today Then
                'date parameters
                MessageBox.Show("Invalid Date")

            ElseIf Not match Then
                'finalizes changes in adding time
                Try
                    My.Computer.FileSystem.CopyFile(file.FileName, "Resources\" & file.SafeFileName)
                    command = New OleDb.OleDbCommand("INSERT INTO events values('" & currentEvent.Text & "', '" & currentDate.Value.ToShortDateString() & "', '" & timePicker.Value.ToShortTimeString() & "', " & Val(prices.Rows(0).Cells(0).Value()) & " , " & Val(prices.Rows(0).Cells(1).Value()) & " , " & Val(prices.Rows(0).Cells(2).Value()) & " , '', 50, 'Resources\" & file.SafeFileName & "')", connection)
                    If command.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("ADDED")
                        Represh()
                    End If
                Catch ex As Exception
                    MessageBox.Show("please Change file name first")
                End Try
            Else
                MessageBox.Show("Time and date overlaps with other events")
            End If
        Else
            MessageBox.Show("Missing fields must be filled up")
        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        If changes Then
            Dim command As New OleDb.OleDbCommand("SELECT picture FROM events WHERE eventName='" & eventView.SelectedRows(0).Cells(0).Value & "' AND eventDate='" & eventView.SelectedRows(0).Cells(1).Value & "' AND eventTime='" & eventView.SelectedRows(0).Cells(2).Value & "'", connection)
            Dim reader = command.ExecuteReader()
            reader.Read()
            My.Computer.FileSystem.DeleteFile(reader.GetString(0))
            reader.Close()
            My.Computer.FileSystem.CopyFile(file.FileName, "Resources\" & file.SafeFileName)
            command = New OleDb.OleDbCommand("UPDATE events SET eventName='" & currentEvent.Text & "', eventDate='" & currentDate.Value.ToShortDateString() & "', eventTime='" & timePicker.Value.ToShortTimeString() & "', price1=" & Val(prices.Rows(0).Cells(0).Value) & ", price2=" & Val(prices.Rows(0).Cells(1).Value) & ", price3=" & Val(prices.Rows(0).Cells(2).Value) & ", picture='Resources\" & file.SafeFileName & "' WHERE eventName='" & eventView.SelectedRows(0).Cells(0).Value & "' AND eventDate='" & eventView.SelectedRows(0).Cells(1).Value & "' AND eventTime='" & eventView.SelectedRows(0).Cells(2).Value & "'", connection)
            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Changes saved")
            End If
        Else
            Dim command As New OleDb.OleDbCommand("UPDATE events SET eventName='" & currentEvent.Text & "', eventDate='" & currentDate.Value.ToShortDateString() & "', eventTime='" & timePicker.Value.ToShortTimeString() & "', price1=" & prices.Rows(0).Cells(0).Value() & ", price2=" & prices.Rows(0).Cells(1).Value() & ", price3=" & prices.Rows(0).Cells(2).Value() & " WHERE eventName='" & eventView.SelectedRows(0).Cells(0).Value & "' AND eventDate='" & eventView.SelectedRows(0).Cells(1).Value & "' AND eventTime='" & eventView.SelectedRows(0).Cells(2).Value & "'", connection)
            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Changes saved")
            End If
        End If
        clearEverything()
        Represh()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearEverything()
    End Sub

    Private Sub eventDetails_MouseMove(sender As Object, e As MouseEventArgs) Handles eventDetails.MouseMove
        'removes selection for the first time loading
        If started Then
            eventView.ClearSelection()
            started = False
        End If
    End Sub

    Private Sub eventView_MouseMove(sender As Object, e As MouseEventArgs) Handles eventView.MouseMove
        If started Then
            eventView.ClearSelection()
            started = False
        End If
    End Sub

    Private Sub removeEvent_Click(sender As Object, e As EventArgs) Handles removeEvent.Click
        Dim command As New OleDb.OleDbCommand("DELETE FROM events WHERE eventName='" & eventView.SelectedRows(0).Cells(0).Value() & "' AND eventDate='" & eventView.SelectedRows(0).Cells(1).Value() & "' AND eventTime='" & eventView.SelectedRows(0).Cells(2).Value() & "'", connection)
        command.ExecuteNonQuery()
        Represh()
        clearEverything()
    End Sub
End Class