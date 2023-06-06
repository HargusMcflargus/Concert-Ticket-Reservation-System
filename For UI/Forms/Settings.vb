Public Class Settings
    Dim connection As New OleDb.OleDbConnection
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = Form1.connectionString
        connection.Open()
        If Form1.adminLogged Then
            userField.Enabled = True
            passwordFIeld.Enabled = False
            passwordField2.Enabled = False
            addUser.Enabled = False
            userMatches.Enabled = False
            saveChanges.Enabled = False
            activeStatus.Enabled = False
        Else
            userControl.Enabled = False
        End If
    End Sub

    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        Dim command As OleDb.OleDbCommand = New OleDb.OleDbCommand("INSERT INTO users ([username], [password], [status]) values ('" & userField.Text & "', '" & passwordFIeld.Text & "', True);", connection)
        If command.ExecuteNonQuery() > 0 And passwordFIeld.Text = passwordField2.Text And Not passwordFIeld.Text = "" Then
            MessageBox.Show("User added")
            addUser.Enabled = False
            passwordFIeld.Enabled = False
            passwordField2.Enabled = False
            passwordFIeld.ResetText()
            passwordField2.ResetText()
            addUser.Enabled = False
            userMatches.DataSource = Nothing
            userMatches.Enabled = False
            saveChanges.Enabled = False
            response.ResetText()
            response.Visible = False
            activeStatus.Enabled = False
            activeStatus.Checked = False
        Else
            command.CommandText = "DELETE FROM users WHERE username='" & userField.Text & "'"
            command.ExecuteNonQuery()
            MessageBox.Show("Indexing error")
            addUser.Enabled = False
            passwordFIeld.Enabled = False
            passwordField2.Enabled = False
            passwordFIeld.ResetText()
            passwordField2.ResetText()
            addUser.Enabled = False
            userMatches.DataSource = Nothing
            userMatches.Enabled = False
            saveChanges.Enabled = False
            response.ResetText()
            response.Visible = False
            activeStatus.Enabled = False
            activeStatus.Checked = False
        End If
    End Sub

    Private Sub checkUsername_Click(sender As Object, e As EventArgs) Handles checkUsername.Click
        Dim command As New OleDb.OleDbCommand("SELECT * FROM users WHERE username like '%" & userField.Text & "%'", connection)
        Dim table As New DataTable()
        table.Load(command.ExecuteReader())
        If table.Rows.Count > 0 Then
            userMatches.Enabled = True
            userMatches.DataSource = table
            saveChanges.Enabled = True
            passwordFIeld.Enabled = True
            passwordField2.Enabled = True
            activeStatus.Enabled = True
            passwordFIeld.Clear()
            passwordField2.Clear()
            userField.Text = userMatches.Rows(0).Cells(0).Value
            activeStatus.Checked = userMatches.Rows(0).Cells(2).Value
            saveChanges.Enabled = True
            userMatches.Rows(0).Selected = True
            If userMatches.Rows(0).Cells(3).Value Then
                activeStatus.Enabled = False
            Else
                activeStatus.Enabled = True
            End If
        Else
            response.Text = "Username Available"
            response.Visible = True
            response.ForeColor = Color.Lime
            userControl.Enabled = True
            passwordFIeld.Enabled = True
            passwordField2.Enabled = True
            addUser.Enabled = True
        End If
    End Sub

    Private Sub saveChanges_Click(sender As Object, e As EventArgs) Handles saveChanges.Click
        If Not userField.Text = "" And passwordFIeld.Text = "" And passwordField2.Text = "" Then
            Dim Command = New OleDb.OleDbCommand("UPDATE users SET username='" & userField.Text & "', status=" & activeStatus.Checked & " WHERE username='" & userMatches.SelectedRows(0).Cells(0).Value() & "'", connection)
            Command.ExecuteNonQuery()
            userField.ResetText()
            passwordFIeld.Enabled = False
            passwordField2.Enabled = False
            passwordFIeld.ResetText()
            passwordField2.ResetText()
            addUser.Enabled = False
            userMatches.DataSource = Nothing
            userMatches.Enabled = False
            saveChanges.Enabled = False
            response.ResetText()
            response.Visible = False
            activeStatus.Enabled = False
            activeStatus.Checked = False
            MessageBox.Show("Saved")
        ElseIf Not userField.Text = "" And Not passwordFIeld.Text = "" And Not passwordField2.Text = "" And passwordFIeld.Text = passwordField2.Text Then
            If passwordFIeld.Text = passwordField2.Text Then
                Dim Command = New OleDb.OleDbCommand("DELETE FROM users WHERE username='" & userMatches.SelectedRows(0).Cells(0).Value() & "'", connection)
                Command.ExecuteNonQuery()
                Command = New OleDb.OleDbCommand("INSERT INTO users ([username], [password], [status]) values('" & userField.Text & "', '" & passwordFIeld.Text & "', " & activeStatus.Checked & ")", connection)
                Command.ExecuteNonQuery()
                userField.ResetText()
                passwordFIeld.Enabled = False
                passwordField2.Enabled = False
                passwordFIeld.ResetText()
                passwordField2.ResetText()
                addUser.Enabled = False
                userMatches.DataSource = Nothing
                userMatches.Enabled = False
                saveChanges.Enabled = False
                response.ResetText()
                response.Visible = False
                activeStatus.Enabled = False
                activeStatus.Checked = False
                MessageBox.Show("Saved")
            Else
                MessageBox.Show("Re-typed passwords do not match")
                passwordFIeld.Clear()
                passwordField2.Clear()
            End If
        End If
    End Sub

    Private Sub userMatches_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles userMatches.CellClick
        passwordFIeld.Enabled = True
        passwordFIeld.Clear()
        passwordField2.Clear()
        passwordField2.Enabled = True
        userField.Text = userMatches.SelectedRows(0).Cells(0).Value
        activeStatus.Checked = userMatches.SelectedRows(0).Cells(2).Value
        saveChanges.Enabled = True
        If userMatches.SelectedRows(0).Cells(3).Value Then
            activeStatus.Enabled = False
        Else
            activeStatus.Enabled = True
        End If
    End Sub
End Class