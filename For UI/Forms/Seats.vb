Imports System.ComponentModel

Public Class Seats

	Dim connection As New OleDb.OleDbConnection
	Dim reservations As Dictionary(Of Object, String) = New Dictionary(Of Object, String)
	Dim prices As List(Of Double) = New List(Of Double)()
	Private Sub Seats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		connection.ConnectionString = Form1.connectionString
		connection.Open()
		Dim command As New OleDb.OleDbCommand("SELECT * FROM events", connection)
		Dim table As New DataTable
		table.Load(command.ExecuteReader())
		table.Rows(0).Item(0).ToString()
		For Each row In table.Rows
			If Today < Date.Parse(row.Item(1)) And Not eventsList.Items.Contains(row.Item(0).ToString()) Then
				eventsList.Items.Add(row.Item(0).ToString())
			End If
		Next
		seatLayoutGroup.Enabled = False
		confirmButton.Enabled = False
		dateList.Enabled = False
		timeLIst.Enabled = False
		confirmButton.Enabled = False
		totalField.Enabled = False
	End Sub

	Private Sub eventsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventsList.SelectedIndexChanged
		If eventsList.SelectedIndex >= 0 Then
			Dim command As New OleDb.OleDbCommand("SELECT * FROM events WHERE eventName='" & eventsList.Text.ToString() & "'", connection)
			Dim table As New DataTable
			table.Load(command.ExecuteReader())
			dateList.Items.Clear()
			For Each row In table.Rows
				If Today < Date.Parse(row.Item(1)) And Not dateList.Items.Contains(row.Item(1).ToString()) Then
					dateList.Items.Add(row.Item(1).ToString())
				End If
			Next
			dateList.Enabled = True
		Else
			timeLIst.Enabled = False
		End If
		timeLIst.Enabled = False
	End Sub

	Private Sub dateList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dateList.SelectedIndexChanged
		If dateList.SelectedIndex >= 0 Then
			Dim command As New OleDb.OleDbCommand("SELECT * FROM events WHERE eventName='" & eventsList.Text.ToString() & "' AND eventDate='" & dateList.Text & "'", connection)
			Dim table As New DataTable
			table.Load(command.ExecuteReader())
			timeLIst.Items.Clear()
			For Each row In table.Rows
				If Not timeLIst.Items.Contains(row.Item(2).ToString()) And Today < Date.Parse(row.Item(2)) Then
					timeLIst.Items.Add(row.Item(2).ToString())
				End If
			Next
			timeLIst.Enabled = True
		Else
			timeLIst.Enabled = False
		End If
	End Sub

	Private Sub timeLIst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles timeLIst.SelectedIndexChanged
		If timeLIst.SelectedIndex >= 0 Then
			Dim command As New OleDb.OleDbCommand("SELECT * FROM events WHERE eventName='" & eventsList.Text & "' AND eventDate='" & dateList.Text & "' AND eventTime='" & timeLIst.Text & "'", connection)
			Dim table As New DataTable
			table.Load(command.ExecuteReader())
			Dim unavailable() = Split(table.Rows(0).Item(6).ToString, " ")
			For Each thing In seatLayoutGroup.Controls
				If TypeOf thing Is CheckBox Then
					thing.Checked = False
				End If
			Next
			seatLayoutGroup.Enabled = True
			For Each item In seatLayoutGroup.Controls
				If unavailable.Contains(item.Text) Then
					item.Enabled = False
				Else
					item.Enabled = True
				End If
			Next
			prices = New List(Of Double)()
			For i = 3 To 5
				prices.Add(Val(table.Rows(0).Item(i)))
			Next
			cashField.Enabled = True
			totalField.Text = 0
		Else
			seatLayoutGroup.Enabled = False
		End If
	End Sub

	Private Sub cashField_TextChanged(sender As Object, e As EventArgs) Handles cashField.TextChanged
		If Val(totalField.Text) > 0 And Val(cashField.Text) - Val(totalField.Text) >= 0 And Not nameField.Text = "" Then
			confirmButton.Enabled = True
		Else
			confirmButton.Enabled = False
		End If
	End Sub

	Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
		If Not nameField.Text = "" Then
			Dim totalTempCuzImtooLazyToFindBugs = Val(totalField.Text)
			Dim command As OleDb.OleDbCommand
			For Each seat In reservations.Keys
				command = New OleDb.OleDbCommand("INSERT INTO history ([customerName], [DT], [price], [seat], [time], [cash], [eventName], [user], [dateOfTransaction]) values('" & nameField.Text & "', '" & dateList.Text & "', " & totalField.Text & " , '" & reservations(seat) & "', '" & timeLIst.Text & "'," & Val(cashField.Text) & ", '" & eventsList.Text & "', '" & Form1.currentUser & "', '" & Now.ToLongDateString() & "')", connection)
				command.ExecuteNonQuery()
			Next
			command = New OleDb.OleDbCommand("SELECT seats,seatNumber FROM events WHERE eventName='" & eventsList.Text & "' AND eventDate='" & dateList.Text & "' AND eventTime='" & timeLIst.Text & "'", connection)
			Dim table As New DataTable
			table.Load(command.ExecuteReader())
			Dim newSeats = table.Rows(0).Item(0).ToString
			For Each seat In reservations.Keys
				newSeats &= " " & reservations(seat)
			Next
			command.CommandText = "UPDATE events SET seats='" & newSeats & "' WHERE eventName='" & eventsList.Text() & "' AND eventDate='" & dateList.Text & "' AND eventTime='" & timeLIst.Text & "'"
			If command.ExecuteNonQuery() > 0 Then
				For Each thing In seatLayoutGroup.Controls
					If TypeOf thing Is CheckBox Then
						thing.Checked = False
					End If
				Next
				'show receipt
				Receipt.clear()
				Receipt.nem.Text = nameField.Text
				Receipt.ebentnem.Text = eventsList.Text
				Receipt.det.Text = dateList.Text
				Receipt.taym.Text = timeLIst.Text
				Dim sits() = Split(newSeats, " ")
				Dim kalang = 0
				For Each item In sits
					If Not item = "" Then
						Receipt.ListBox1.Items.Add(item)
						kalang += 1
					End If
				Next
				command.CommandText = "UPDATE events SET seatNumber=" & Val(table.Rows(0).Item(1)) - kalang & " WHERE eventName='" & eventsList.Text() & "' AND eventDate='" & dateList.Text & "' AND eventTime='" & timeLIst.Text & "'"
				command.ExecuteNonQuery()
				Receipt.tototal.Text = totalTempCuzImtooLazyToFindBugs
				Receipt.kakashi.Text = cashField.Text
				Receipt.chenji.Text = Val(cashField.Text) - Val(totalField.Text)
				Receipt.Show()
				'clear everything
				seatLayoutGroup.Enabled = False
				confirmButton.Enabled = False
				timeLIst.ResetText()
				timeLIst.Enabled = False
				timeLIst.Items.Clear()
				dateList.ResetText()
				dateList.Enabled = False
				dateList.Items.Clear()
				eventsList.ResetText()
				nameField.Clear()
				totalField.Clear()
				cashField.Enabled = False
				cashField.Clear()
			End If
		End If
	End Sub

	Private Sub F1_CheckedChanged(sender As Object, e As EventArgs) Handles F1.CheckedChanged
		If F1.Checked Then
			reservations.Add(F1, CheckBox60.Text)
			adjustUp(F1.Text)
		Else
			adjustDown(F1.Text)
			reservations.Remove(F1)
		End If
	End Sub

	Private Sub adjustUp(ByVal letter)
		Dim pricesAsText As String
		Select Case letter(0)
			Case "M"
				totalField.Text = Val(totalField.Text) + prices.Item(1)
				pricesAsText = prices.Item(1).ToString()
			Case "F"
				totalField.Text = Val(totalField.Text) + prices.Item(0)
				pricesAsText = prices.Item(0).ToString()
			Case Else
				totalField.Text = Val(totalField.Text) + prices.Item(2)
				pricesAsText = prices.Item(2).ToString()
		End Select
		If TreeView1.Nodes.ContainsKey(eventsList.Text) Then
			TreeView1.Nodes(eventsList.Text).Nodes.Add(letter, letter)
		Else
			TreeView1.Nodes.Add(eventsList.Text, eventsList.Text)
			If TreeView1.Nodes.ContainsKey(eventsList.Text) Then
				TreeView1.Nodes(eventsList.Text).Nodes.Add(letter, letter)
			End If
		End If
	End Sub

	Private Sub adjustDown(ByVal letter)
		Dim pricesAsText As String
		Select Case letter(0)
			Case "M"
				totalField.Text = Val(totalField.Text) - prices.Item(1)
				pricesAsText = prices.Item(1).ToString()
			Case "F"
				totalField.Text = Val(totalField.Text) - prices.Item(0)
				pricesAsText = prices.Item(0).ToString()
			Case Else
				totalField.Text = Val(totalField.Text) - prices.Item(2)
				pricesAsText = prices.Item(2).ToString()
		End Select
		TreeView1.Nodes(eventsList.Text).Nodes().RemoveByKey(letter)
		If TreeView1.Nodes(eventsList.Text).Nodes.Count = 0 Then
			TreeView1.Nodes().RemoveByKey(eventsList.Text)
		End If
	End Sub

	Private Sub Checkbox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
		If CheckBox2.Checked Then
			reservations.Add(CheckBox2, CheckBox2.Text)
			adjustUp(CheckBox2.Text)
		Else
			adjustDown(CheckBox2.Text)
			reservations.Remove(CheckBox2)
		End If
	End Sub

	Private Sub Checkbox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
		If CheckBox3.Checked Then
			reservations.Add(CheckBox3, CheckBox3.Text)
			adjustUp(CheckBox3.Text)
		Else
			adjustDown(CheckBox3.Text)
			reservations.Remove(CheckBox3)
		End If
	End Sub

	Private Sub Checkbox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
		If CheckBox4.Checked Then
			reservations.Add(CheckBox4, CheckBox4.Text)
			adjustUp(CheckBox4.Text)
		Else
			adjustDown(CheckBox4.Text)
			reservations.Remove(CheckBox4)
		End If
	End Sub

	Private Sub Checkbox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
		If CheckBox5.Checked Then
			reservations.Add(CheckBox5, CheckBox5.Text)
			adjustUp(CheckBox5.Text)
		Else
			adjustDown(CheckBox5.Text)
			reservations.Remove(CheckBox5)
		End If
	End Sub

	Private Sub Checkbox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
		If CheckBox6.Checked Then
			reservations.Add(CheckBox6, CheckBox6.Text)
			adjustUp(CheckBox6.Text)
		Else
			adjustDown(CheckBox6.Text)
			reservations.Remove(CheckBox6)
		End If
	End Sub

	Private Sub Checkbox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
		If CheckBox7.Checked Then
			reservations.Add(CheckBox7, CheckBox7.Text)
			adjustUp(CheckBox7.Text)
		Else
			adjustDown(CheckBox7.Text)
			reservations.Remove(CheckBox7)
		End If
	End Sub

	Private Sub Checkbox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
		If CheckBox8.Checked Then
			reservations.Add(CheckBox8, CheckBox8.Text)
			adjustUp(CheckBox8.Text)
		Else
			adjustDown(CheckBox8.Text)
			reservations.Remove(CheckBox8)
		End If
	End Sub

	Private Sub Checkbox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
		If CheckBox9.Checked Then
			reservations.Add(CheckBox9, CheckBox9.Text)
			adjustUp(CheckBox9.Text)
		Else
			adjustDown(CheckBox9.Text)
			reservations.Remove(CheckBox9)
		End If
	End Sub

	Private Sub Checkbox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
		If CheckBox10.Checked Then
			reservations.Add(CheckBox10, CheckBox10.Text)
			adjustUp(CheckBox10.Text)
		Else
			adjustDown(CheckBox10.Text)
			reservations.Remove(CheckBox10)
		End If
	End Sub

	Private Sub Checkbox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
		If CheckBox11.Checked Then
			reservations.Add(CheckBox11, CheckBox11.Text)
			adjustUp(CheckBox11.Text)
		Else
			adjustDown(CheckBox11.Text)
			reservations.Remove(CheckBox11)
		End If
	End Sub

	Private Sub Checkbox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
		If CheckBox12.Checked Then
			reservations.Add(CheckBox12, CheckBox12.Text)
			adjustUp(CheckBox12.Text)
		Else
			adjustDown(CheckBox12.Text)
			reservations.Remove(CheckBox12)
		End If
	End Sub

	Private Sub Checkbox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
		If CheckBox13.Checked Then
			reservations.Add(CheckBox13, CheckBox13.Text)
			adjustUp(CheckBox13.Text)
		Else
			adjustDown(CheckBox13.Text)
			reservations.Remove(CheckBox13)
		End If
	End Sub

	Private Sub Checkbox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
		If CheckBox14.Checked Then
			reservations.Add(CheckBox14, CheckBox14.Text)
			adjustUp(CheckBox14.Text)
		Else
			adjustDown(CheckBox14.Text)
			reservations.Remove(CheckBox14)
		End If
	End Sub

	Private Sub Checkbox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
		If CheckBox15.Checked Then
			reservations.Add(CheckBox15, CheckBox15.Text)
			adjustUp(CheckBox15.Text)
		Else
			adjustDown(CheckBox15.Text)
			reservations.Remove(CheckBox15)
		End If
	End Sub

	Private Sub Checkbox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
		If CheckBox16.Checked Then
			reservations.Add(CheckBox16, CheckBox16.Text)
			adjustUp(CheckBox16.Text)
		Else
			adjustDown(CheckBox16.Text)
			reservations.Remove(CheckBox16)
		End If
	End Sub

	Private Sub Checkbox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
		If CheckBox17.Checked Then
			reservations.Add(CheckBox17, CheckBox17.Text)
			adjustUp(CheckBox17.Text)
		Else
			adjustDown(CheckBox17.Text)
			reservations.Remove(CheckBox17)
		End If
	End Sub

	Private Sub Checkbox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
		If CheckBox18.Checked Then
			reservations.Add(CheckBox18, CheckBox18.Text)
			adjustUp(CheckBox18.Text)
		Else
			adjustDown(CheckBox18.Text)
			reservations.Remove(CheckBox18)
		End If
	End Sub

	Private Sub Checkbox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
		If CheckBox19.Checked Then
			reservations.Add(CheckBox19, CheckBox19.Text)
			adjustUp(CheckBox19.Text)
		Else
			adjustDown(CheckBox19.Text)
			reservations.Remove(CheckBox19)
		End If
	End Sub

	Private Sub Checkbox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
		If CheckBox20.Checked Then
			reservations.Add(CheckBox20, CheckBox20.Text)
			adjustUp(CheckBox20.Text)
		Else
			adjustDown(CheckBox20.Text)
			reservations.Remove(CheckBox20)
		End If
	End Sub

	'21

	Private Sub Checkbox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
		If CheckBox22.Checked Then
			reservations.Add(CheckBox22, CheckBox22.Text)
			adjustUp(CheckBox22.Text)
		Else
			adjustDown(CheckBox22.Text)
			reservations.Remove(CheckBox22)
		End If
	End Sub

	Private Sub Checkbox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
		If CheckBox23.Checked Then
			reservations.Add(CheckBox23, CheckBox23.Text)
			adjustUp(CheckBox23.Text)
		Else
			adjustDown(CheckBox23.Text)
			reservations.Remove(CheckBox23)
		End If
	End Sub

	Private Sub Checkbox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
		If CheckBox24.Checked Then
			reservations.Add(CheckBox24, CheckBox24.Text)
			adjustUp(CheckBox24.Text)
		Else
			adjustDown(CheckBox24.Text)
			reservations.Remove(CheckBox24)
		End If
	End Sub

	Private Sub Checkbox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
		If CheckBox25.Checked Then
			reservations.Add(CheckBox25, CheckBox25.Text)
			adjustUp(CheckBox25.Text)
		Else
			adjustDown(CheckBox25.Text)
			reservations.Remove(CheckBox25)
		End If
	End Sub

	Private Sub Checkbox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
		If CheckBox26.Checked Then
			reservations.Add(CheckBox26, CheckBox26.Text)
			adjustUp(CheckBox26.Text)
		Else
			adjustDown(CheckBox26.Text)
			reservations.Remove(CheckBox26)
		End If
	End Sub

	Private Sub Checkbox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
		If CheckBox27.Checked Then
			reservations.Add(CheckBox27, CheckBox27.Text)
			adjustUp(CheckBox27.Text)
		Else
			adjustDown(CheckBox27.Text)
			reservations.Remove(CheckBox27)
		End If
	End Sub

	Private Sub Checkbox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
		If CheckBox28.Checked Then
			reservations.Add(CheckBox28, CheckBox28.Text)
			adjustUp(CheckBox28.Text)
		Else
			adjustDown(CheckBox28.Text)
			reservations.Remove(CheckBox28)
		End If
	End Sub

	Private Sub Checkbox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
		If CheckBox29.Checked Then
			reservations.Add(CheckBox29, CheckBox29.Text)
			adjustUp(CheckBox29.Text)
		Else
			adjustDown(CheckBox29.Text)
			reservations.Remove(CheckBox29)
		End If
	End Sub

	Private Sub Checkbox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
		If CheckBox30.Checked Then
			reservations.Add(CheckBox30, CheckBox30.Text)
			adjustUp(CheckBox30.Text)
		Else
			adjustDown(CheckBox30.Text)
			reservations.Remove(CheckBox30)
		End If
	End Sub

	Private Sub Checkbox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
		If CheckBox31.Checked Then
			reservations.Add(CheckBox31, CheckBox31.Text)
			adjustUp(CheckBox31.Text)
		Else
			adjustDown(CheckBox31.Text)
			reservations.Remove(CheckBox31)
		End If
	End Sub

	Private Sub Checkbox32_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox32.CheckedChanged
		If CheckBox32.Checked Then
			reservations.Add(CheckBox32, CheckBox32.Text)
			adjustUp(CheckBox32.Text)
		Else
			adjustDown(CheckBox32.Text)
			reservations.Remove(CheckBox32)
		End If
	End Sub

	Private Sub Checkbox33_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
		If CheckBox33.Checked Then
			reservations.Add(CheckBox33, CheckBox33.Text)
			adjustUp(CheckBox33.Text)
		Else
			adjustDown(CheckBox33.Text)
			reservations.Remove(CheckBox33)
		End If
	End Sub

	Private Sub Checkbox34_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox34.CheckedChanged
		If CheckBox34.Checked Then
			reservations.Add(CheckBox34, CheckBox34.Text)
			adjustUp(CheckBox34.Text)
		Else
			adjustDown(CheckBox34.Text)
			reservations.Remove(CheckBox34)
		End If
	End Sub

	Private Sub Checkbox35_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox35.CheckedChanged
		If CheckBox35.Checked Then
			reservations.Add(CheckBox35, CheckBox35.Text)
			adjustUp(CheckBox35.Text)
		Else
			adjustDown(CheckBox35.Text)
			reservations.Remove(CheckBox35)
		End If
	End Sub

	Private Sub Checkbox36_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox36.CheckedChanged
		If CheckBox36.Checked Then
			reservations.Add(CheckBox36, CheckBox36.Text)
			adjustUp(CheckBox36.Text)
		Else
			adjustDown(CheckBox36.Text)
			reservations.Remove(CheckBox36)
		End If
	End Sub

	Private Sub Checkbox37_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox37.CheckedChanged
		If CheckBox37.Checked Then
			reservations.Add(CheckBox37, CheckBox37.Text)
			adjustUp(CheckBox37.Text)
		Else
			adjustDown(CheckBox37.Text)
			reservations.Remove(CheckBox37)
		End If
	End Sub

	Private Sub Checkbox38_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox38.CheckedChanged
		If CheckBox38.Checked Then
			reservations.Add(CheckBox38, CheckBox38.Text)
			adjustUp(CheckBox38.Text)
		Else
			adjustDown(CheckBox38.Text)
			reservations.Remove(CheckBox38)
		End If
	End Sub

	Private Sub Checkbox39_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox39.CheckedChanged
		If CheckBox39.Checked Then
			reservations.Add(CheckBox39, CheckBox39.Text)
			adjustUp(CheckBox39.Text)
		Else
			adjustDown(CheckBox39.Text)
			reservations.Remove(CheckBox39)
		End If
	End Sub

	Private Sub Checkbox40_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40.CheckedChanged
		If CheckBox40.Checked Then
			reservations.Add(CheckBox40, CheckBox40.Text)
			adjustUp(CheckBox40.Text)
		Else
			adjustDown(CheckBox40.Text)
			reservations.Remove(CheckBox40)
		End If
	End Sub

	Private Sub Checkbox41_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox41.CheckedChanged
		If CheckBox41.Checked Then
			reservations.Add(CheckBox41, CheckBox41.Text)
			adjustUp(CheckBox41.Text)
		Else
			adjustDown(CheckBox41.Text)
			reservations.Remove(CheckBox41)
		End If
	End Sub

	Private Sub Checkbox42_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox42.CheckedChanged
		If CheckBox42.Checked Then
			reservations.Add(CheckBox42, CheckBox42.Text)
			adjustUp(CheckBox42.Text)
		Else
			adjustDown(CheckBox42.Text)
			reservations.Remove(CheckBox42)
		End If
	End Sub

	Private Sub Checkbox43_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox43.CheckedChanged
		If CheckBox43.Checked Then
			reservations.Add(CheckBox43, CheckBox43.Text)
			adjustUp(CheckBox43.Text)
		Else
			adjustDown(CheckBox43.Text)
			reservations.Remove(CheckBox43)
		End If
	End Sub

	Private Sub Checkbox44_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox44.CheckedChanged
		If CheckBox44.Checked Then
			reservations.Add(CheckBox44, CheckBox44.Text)
			adjustUp(CheckBox44.Text)
		Else
			adjustDown(CheckBox44.Text)
			reservations.Remove(CheckBox44)
		End If
	End Sub

	Private Sub Checkbox45_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox45.CheckedChanged
		If CheckBox45.Checked Then
			reservations.Add(CheckBox45, CheckBox45.Text)
			adjustUp(CheckBox45.Text)
		Else
			adjustDown(CheckBox45.Text)
			reservations.Remove(CheckBox45)
		End If
	End Sub

	Private Sub Checkbox46_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox46.CheckedChanged
		If CheckBox46.Checked Then
			reservations.Add(CheckBox46, CheckBox46.Text)
			adjustUp(CheckBox46.Text)
		Else
			adjustDown(CheckBox46.Text)
			reservations.Remove(CheckBox46)
		End If
	End Sub

	Private Sub Checkbox47_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox47.CheckedChanged
		If CheckBox47.Checked Then
			reservations.Add(CheckBox47, CheckBox47.Text)
			adjustUp(CheckBox47.Text)
		Else
			adjustDown(CheckBox47.Text)
			reservations.Remove(CheckBox47)
		End If
	End Sub

	'48
	'49

	Private Sub Checkbox50_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox50.CheckedChanged
		If CheckBox50.Checked Then
			reservations.Add(CheckBox50, CheckBox50.Text)
			adjustUp(CheckBox50.Text)
		Else
			adjustDown(CheckBox50.Text)
			reservations.Remove(CheckBox50)
		End If
	End Sub

	Private Sub Checkbox51_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox51.CheckedChanged
		If CheckBox51.Checked Then
			reservations.Add(CheckBox51, CheckBox51.Text)
			adjustUp(CheckBox51.Text)
		Else
			adjustDown(CheckBox51.Text)
			reservations.Remove(CheckBox51)
		End If
	End Sub

	Private Sub Checkbox52_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox52.CheckedChanged
		If CheckBox52.Checked Then
			reservations.Add(CheckBox52, CheckBox52.Text)
			adjustUp(CheckBox52.Text)
		Else
			adjustDown(CheckBox52.Text)
			reservations.Remove(CheckBox52)
		End If
	End Sub

	Private Sub Checkbox53_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox53.CheckedChanged
		If CheckBox53.Checked Then
			reservations.Add(CheckBox53, CheckBox53.Text)
			adjustUp(CheckBox53.Text)
		Else
			adjustDown(CheckBox53.Text)
			reservations.Remove(CheckBox53)
		End If
	End Sub

	Private Sub Checkbox54_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox54.CheckedChanged
		If CheckBox54.Checked Then
			reservations.Add(CheckBox54, CheckBox54.Text)
			adjustUp(CheckBox54.Text)
		Else
			adjustDown(CheckBox54.Text)
			reservations.Remove(CheckBox54)
		End If
	End Sub

	Private Sub Checkbox55_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox55.CheckedChanged
		If CheckBox55.Checked Then
			reservations.Add(CheckBox55, CheckBox55.Text)
			adjustUp(CheckBox55.Text)
		Else
			adjustDown(CheckBox55.Text)
			reservations.Remove(CheckBox55)
		End If
	End Sub

	'56

	Private Sub Checkbox57_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox57.CheckedChanged
		If CheckBox57.Checked Then
			reservations.Add(CheckBox57, CheckBox57.Text)
			adjustUp(CheckBox57.Text)
		Else
			adjustDown(CheckBox57.Text)
			reservations.Remove(CheckBox57)
		End If
	End Sub

	Private Sub Checkbox58_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox58.CheckedChanged
		If CheckBox58.Checked Then
			reservations.Add(CheckBox58, CheckBox58.Text)
			adjustUp(CheckBox58.Text)
		Else
			adjustDown(CheckBox58.Text)
			reservations.Remove(CheckBox58)
		End If
	End Sub

	Private Sub Checkbox59_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox59.CheckedChanged
		If CheckBox59.Checked Then
			reservations.Add(CheckBox59, CheckBox59.Text)
			adjustUp(CheckBox59.Text)
		Else
			adjustDown(CheckBox59.Text)
			reservations.Remove(CheckBox59)
		End If
	End Sub

	Private Sub Checkbox60_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox60.CheckedChanged
		If CheckBox60.Checked Then
			reservations.Add(CheckBox60, CheckBox60.Text)
			adjustUp(CheckBox60.Text)
		Else
			adjustDown(CheckBox60.Text)
			reservations.Remove(CheckBox60)
		End If
	End Sub

	Private Sub Checkbox61_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox61.CheckedChanged
		If CheckBox61.Checked Then
			reservations.Add(CheckBox61, CheckBox61.Text)
			adjustUp(CheckBox61.Text)
		Else
			adjustDown(CheckBox61.Text)
			reservations.Remove(CheckBox61)
		End If
	End Sub

	Private Sub Checkbox62_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox62.CheckedChanged
		If CheckBox62.Checked Then
			reservations.Add(CheckBox62, CheckBox62.Text)
			adjustUp(CheckBox62.Text)
		Else
			adjustDown(CheckBox62.Text)
			reservations.Remove(CheckBox62)
		End If
	End Sub

	Private Sub Checkbox63_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox63.CheckedChanged
		If CheckBox63.Checked Then
			reservations.Add(CheckBox63, CheckBox63.Text)
			adjustUp(CheckBox63.Text)
		Else
			adjustDown(CheckBox63.Text)
			reservations.Remove(CheckBox63)
		End If
	End Sub

	Private Sub Checkbox64_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox64.CheckedChanged
		If CheckBox64.Checked Then
			reservations.Add(CheckBox64, CheckBox64.Text)
			adjustUp(CheckBox64.Text)
		Else
			adjustDown(CheckBox64.Text)
			reservations.Remove(CheckBox64)
		End If
	End Sub

	Private Sub Checkbox65_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox65.CheckedChanged
		If CheckBox65.Checked Then
			reservations.Add(CheckBox65, CheckBox65.Text)
			adjustUp(CheckBox65.Text)
		Else
			adjustDown(CheckBox65.Text)
			reservations.Remove(CheckBox65)
		End If
	End Sub

	Private Sub Checkbox66_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox66.CheckedChanged
		If CheckBox66.Checked Then
			reservations.Add(CheckBox66, CheckBox66.Text)
			adjustUp(CheckBox66.Text)
		Else
			adjustDown(CheckBox66.Text)
			reservations.Remove(CheckBox66)
		End If
	End Sub

	Private Sub Checkbox67_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox67.CheckedChanged
		If CheckBox67.Checked Then
			reservations.Add(CheckBox67, CheckBox67.Text)
			adjustUp(CheckBox67.Text)
		Else
			adjustDown(CheckBox67.Text)
			reservations.Remove(CheckBox67)
		End If
	End Sub

	Private Sub Checkbox68_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox68.CheckedChanged
		If CheckBox68.Checked Then
			reservations.Add(CheckBox68, CheckBox68.Text)
			adjustUp(CheckBox68.Text)
		Else
			adjustDown(CheckBox68.Text)
			reservations.Remove(CheckBox68)
		End If
	End Sub

	Private Sub Checkbox69_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox69.CheckedChanged
		If CheckBox69.Checked Then
			reservations.Add(CheckBox69, CheckBox69.Text)
			adjustUp(CheckBox69.Text)
		Else
			adjustDown(CheckBox69.Text)
			reservations.Remove(CheckBox69)
		End If
	End Sub

	Private Sub Checkbox70_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox70.CheckedChanged
		If CheckBox70.Checked Then
			reservations.Add(CheckBox70, CheckBox70.Text)
			adjustUp(CheckBox70.Text)
		Else
			adjustDown(CheckBox70.Text)
			reservations.Remove(CheckBox70)
		End If
	End Sub

	Private Sub Checkbox71_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox71.CheckedChanged
		If CheckBox71.Checked Then
			reservations.Add(CheckBox71, CheckBox71.Text)
			adjustUp(CheckBox71.Text)
		Else
			adjustDown(CheckBox71.Text)
			reservations.Remove(CheckBox71)
		End If
	End Sub

	'72
	'73
	'74

	Private Sub Checkbox75_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox75.CheckedChanged
		If CheckBox75.Checked Then
			reservations.Add(CheckBox75, CheckBox75.Text)
			adjustUp(CheckBox75.Text)
		Else
			adjustDown(CheckBox75.Text)
			reservations.Remove(CheckBox75)
		End If
	End Sub

	Private Sub Checkbox76_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox76.CheckedChanged
		If CheckBox76.Checked Then
			reservations.Add(CheckBox76, CheckBox76.Text)
			adjustUp(CheckBox76.Text)
		Else
			adjustDown(CheckBox76.Text)
			reservations.Remove(CheckBox76)
		End If
	End Sub

	Private Sub Checkbox77_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox77.CheckedChanged
		If CheckBox77.Checked Then
			reservations.Add(CheckBox77, CheckBox77.Text)
			adjustUp(CheckBox77.Text)
		Else
			adjustDown(CheckBox77.Text)
			reservations.Remove(CheckBox77)
		End If
	End Sub

	Private Sub Checkbox78_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox78.CheckedChanged
		If CheckBox78.Checked Then
			reservations.Add(CheckBox78, CheckBox78.Text)
			adjustUp(CheckBox78.Text)
		Else
			adjustDown(CheckBox78.Text)
			reservations.Remove(CheckBox78)
		End If
	End Sub

	Private Sub Checkbox79_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox79.CheckedChanged
		If CheckBox79.Checked Then
			reservations.Add(CheckBox79, CheckBox79.Text)
			adjustUp(CheckBox79.Text)
		Else
			adjustDown(CheckBox79.Text)
			reservations.Remove(CheckBox79)
		End If
	End Sub

	Private Sub Checkbox80_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox80.CheckedChanged
		If CheckBox80.Checked Then
			reservations.Add(CheckBox80, CheckBox80.Text)
			adjustUp(CheckBox80.Text)
		Else
			adjustDown(CheckBox80.Text)
			reservations.Remove(CheckBox80)
		End If
	End Sub

	Private Sub Checkbox81_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox81.CheckedChanged
		If CheckBox81.Checked Then
			reservations.Add(CheckBox81, CheckBox81.Text)
			adjustUp(CheckBox81.Text)
		Else
			adjustDown(CheckBox81.Text)
			reservations.Remove(CheckBox81)
		End If
	End Sub

	Private Sub Checkbox82_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox82.CheckedChanged
		If CheckBox82.Checked Then
			reservations.Add(CheckBox82, CheckBox82.Text)
			adjustUp(CheckBox82.Text)
		Else
			adjustDown(CheckBox82.Text)
			reservations.Remove(CheckBox82)
		End If
	End Sub

	Private Sub Checkbox83_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox83.CheckedChanged
		If CheckBox83.Checked Then
			reservations.Add(CheckBox83, CheckBox83.Text)
			adjustUp(CheckBox83.Text)
		Else
			adjustDown(CheckBox83.Text)
			reservations.Remove(CheckBox83)
		End If
	End Sub

	Private Sub Checkbox84_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox84.CheckedChanged
		If CheckBox84.Checked Then
			reservations.Add(CheckBox84, CheckBox84.Text)
			adjustUp(CheckBox84.Text)
		Else
			adjustDown(CheckBox84.Text)
			reservations.Remove(CheckBox84)
		End If
	End Sub

	Private Sub Checkbox85_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox85.CheckedChanged
		If CheckBox85.Checked Then
			reservations.Add(CheckBox85, CheckBox85.Text)
			adjustUp(CheckBox85.Text)
		Else
			adjustDown(CheckBox85.Text)
			reservations.Remove(CheckBox85)
		End If
	End Sub

	Private Sub Checkbox86_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox86.CheckedChanged
		If CheckBox86.Checked Then
			reservations.Add(CheckBox86, CheckBox86.Text)
			adjustUp(CheckBox86.Text)
		Else
			adjustDown(CheckBox86.Text)
			reservations.Remove(CheckBox86)
		End If
	End Sub

	Private Sub Checkbox87_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox87.CheckedChanged
		If CheckBox87.Checked Then
			reservations.Add(CheckBox87, CheckBox87.Text)
			adjustUp(CheckBox87.Text)
		Else
			adjustDown(CheckBox87.Text)
			reservations.Remove(CheckBox87)
		End If
	End Sub

	Private Sub Checkbox88_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox88.CheckedChanged
		If CheckBox88.Checked Then
			reservations.Add(CheckBox88, CheckBox88.Text)
			adjustUp(CheckBox88.Text)
		Else
			adjustDown(CheckBox88.Text)
			reservations.Remove(CheckBox88)
		End If
	End Sub

	Private Sub Checkbox89_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox89.CheckedChanged
		If CheckBox89.Checked Then
			reservations.Add(CheckBox89, CheckBox89.Text)
			adjustUp(CheckBox89.Text)
		Else
			adjustDown(CheckBox89.Text)
			reservations.Remove(CheckBox89)
		End If
	End Sub

	'90

	Private Sub Checkbox91_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox91.CheckedChanged
		If CheckBox91.Checked Then
			reservations.Add(CheckBox91, CheckBox91.Text)
			adjustUp(CheckBox91.Text)
		Else
			adjustDown(CheckBox91.Text)
			reservations.Remove(CheckBox91)
		End If
	End Sub

	Private Sub Checkbox92_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox92.CheckedChanged
		If CheckBox92.Checked Then
			reservations.Add(CheckBox92, CheckBox92.Text)
			adjustUp(CheckBox92.Text)
		Else
			adjustDown(CheckBox92.Text)
			reservations.Remove(CheckBox92)
		End If
	End Sub

	Private Sub Checkbox93_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox93.CheckedChanged
		If CheckBox93.Checked Then
			reservations.Add(CheckBox93, CheckBox93.Text)
			adjustUp(CheckBox93.Text)
		Else
			adjustDown(CheckBox93.Text)
			reservations.Remove(CheckBox93)
		End If
	End Sub

	Private Sub Checkbox94_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox94.CheckedChanged
		If CheckBox94.Checked Then
			reservations.Add(CheckBox94, CheckBox94.Text)
			adjustUp(CheckBox94.Text)
		Else
			adjustDown(CheckBox94.Text)
			reservations.Remove(CheckBox94)
		End If
	End Sub

	Private Sub Checkbox95_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox95.CheckedChanged
		If CheckBox95.Checked Then
			reservations.Add(CheckBox95, CheckBox95.Text)
			adjustUp(CheckBox95.Text)
		Else
			adjustDown(CheckBox95.Text)
			reservations.Remove(CheckBox95)
		End If
	End Sub

	Private Sub Checkbox96_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox96.CheckedChanged
		If CheckBox96.Checked Then
			reservations.Add(CheckBox96, CheckBox96.Text)
			adjustUp(CheckBox96.Text)
		Else
			adjustDown(CheckBox96.Text)
			reservations.Remove(CheckBox96)
		End If
	End Sub

	Private Sub Checkbox97_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox97.CheckedChanged
		If CheckBox97.Checked Then
			reservations.Add(CheckBox97, CheckBox97.Text)
			adjustUp(CheckBox97.Text)
		Else
			adjustDown(CheckBox97.Text)
			reservations.Remove(CheckBox97)
		End If
	End Sub

	Private Sub Checkbox98_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox98.CheckedChanged
		If CheckBox98.Checked Then
			reservations.Add(CheckBox98, CheckBox98.Text)
			adjustUp(CheckBox98.Text)
		Else
			adjustDown(CheckBox98.Text)
			reservations.Remove(CheckBox98)
		End If
	End Sub

	Private Sub Checkbox99_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox99.CheckedChanged
		If CheckBox99.Checked Then
			reservations.Add(CheckBox99, CheckBox99.Text)
			adjustUp(CheckBox99.Text)
		Else
			adjustDown(CheckBox99.Text)
			reservations.Remove(CheckBox99)
		End If
	End Sub

	Private Sub Checkbox100_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox100.CheckedChanged
		If CheckBox100.Checked Then
			reservations.Add(CheckBox100, CheckBox100.Text)
			adjustUp(CheckBox100.Text)
		Else
			adjustDown(CheckBox100.Text)
			reservations.Remove(CheckBox100)
		End If
	End Sub

	Private Sub Checkbox101_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox101.CheckedChanged
		If CheckBox101.Checked Then
			reservations.Add(CheckBox101, CheckBox101.Text)
			adjustUp(CheckBox101.Text)
		Else
			adjustDown(CheckBox101.Text)
			reservations.Remove(CheckBox101)
		End If
	End Sub

	Private Sub Checkbox102_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox102.CheckedChanged
		If CheckBox102.Checked Then
			reservations.Add(CheckBox102, CheckBox102.Text)
			adjustUp(CheckBox102.Text)
		Else
			adjustDown(CheckBox102.Text)
			reservations.Remove(CheckBox102)
		End If
	End Sub

	Private Sub Checkbox103_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox103.CheckedChanged
		If CheckBox103.Checked Then
			reservations.Add(CheckBox103, CheckBox103.Text)
			adjustUp(CheckBox103.Text)
		Else
			adjustDown(CheckBox103.Text)
			reservations.Remove(CheckBox103)
		End If
	End Sub

	Private Sub Checkbox104_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox104.CheckedChanged
		If CheckBox104.Checked Then
			reservations.Add(CheckBox104, CheckBox104.Text)
			adjustUp(CheckBox104.Text)
		Else
			adjustDown(CheckBox104.Text)
			reservations.Remove(CheckBox104)
		End If
	End Sub

	Private Sub Checkbox105_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox105.CheckedChanged
		If CheckBox105.Checked Then
			reservations.Add(CheckBox105, CheckBox105.Text)
			adjustUp(CheckBox105.Text)
		Else
			adjustDown(CheckBox105.Text)
			reservations.Remove(CheckBox105)
		End If
	End Sub

	Private Sub Checkbox106_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox106.CheckedChanged
		If CheckBox106.Checked Then
			reservations.Add(CheckBox106, CheckBox106.Text)
			adjustUp(CheckBox106.Text)
		Else
			adjustDown(CheckBox106.Text)
			reservations.Remove(CheckBox106)
		End If
	End Sub

	Private Sub Checkbox107_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox107.CheckedChanged
		If CheckBox107.Checked Then
			reservations.Add(CheckBox107, CheckBox107.Text)
			adjustUp(CheckBox107.Text)
		Else
			adjustDown(CheckBox107.Text)
			reservations.Remove(CheckBox107)
		End If
	End Sub

	Private Sub Checkbox108_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox108.CheckedChanged
		If CheckBox108.Checked Then
			reservations.Add(CheckBox108, CheckBox108.Text)
			adjustUp(CheckBox108.Text)
		Else
			adjustDown(CheckBox108.Text)
			reservations.Remove(CheckBox108)
		End If
	End Sub

	Private Sub Checkbox109_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox109.CheckedChanged
		If CheckBox109.Checked Then
			reservations.Add(CheckBox109, CheckBox109.Text)
			adjustUp(CheckBox109.Text)
		Else
			adjustDown(CheckBox109.Text)
			reservations.Remove(CheckBox109)
		End If
	End Sub

	Private Sub Checkbox110_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox110.CheckedChanged
		If CheckBox110.Checked Then
			reservations.Add(CheckBox110, CheckBox110.Text)
			adjustUp(CheckBox110.Text)
		Else
			adjustDown(CheckBox110.Text)
			reservations.Remove(CheckBox110)
		End If
	End Sub

	Private Sub Checkbox111_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox111.CheckedChanged
		If CheckBox111.Checked Then
			reservations.Add(CheckBox111, CheckBox111.Text)
			adjustUp(CheckBox111.Text)
		Else
			adjustDown(CheckBox111.Text)
			reservations.Remove(CheckBox111)
		End If
	End Sub

	Private Sub Checkbox112_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox112.CheckedChanged
		If CheckBox112.Checked Then
			reservations.Add(CheckBox112, CheckBox112.Text)
			adjustUp(CheckBox112.Text)
		Else
			adjustDown(CheckBox112.Text)
			reservations.Remove(CheckBox112)
		End If
	End Sub

	Private Sub Checkbox113_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox113.CheckedChanged
		If CheckBox113.Checked Then
			reservations.Add(CheckBox113, CheckBox113.Text)
			adjustUp(CheckBox113.Text)
		Else
			adjustDown(CheckBox113.Text)
			reservations.Remove(CheckBox113)
		End If
	End Sub

	Private Sub Checkbox114_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox114.CheckedChanged
		If CheckBox114.Checked Then
			reservations.Add(CheckBox114, CheckBox114.Text)
			adjustUp(CheckBox114.Text)
		Else
			adjustDown(CheckBox114.Text)
			reservations.Remove(CheckBox114)
		End If
	End Sub

	Private Sub Checkbox115_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox115.CheckedChanged
		If CheckBox115.Checked Then
			reservations.Add(CheckBox115, CheckBox115.Text)
			adjustUp(CheckBox115.Text)
		Else
			adjustDown(CheckBox115.Text)
			reservations.Remove(CheckBox115)
		End If
	End Sub

	Private Sub Checkbox116_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox116.CheckedChanged
		If CheckBox116.Checked Then
			reservations.Add(CheckBox116, CheckBox116.Text)
			adjustUp(CheckBox116.Text)
		Else
			adjustDown(CheckBox116.Text)
			reservations.Remove(CheckBox116)
		End If
	End Sub

	Private Sub Checkbox117_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox117.CheckedChanged
		If CheckBox117.Checked Then
			reservations.Add(CheckBox117, CheckBox117.Text)
			adjustUp(CheckBox117.Text)
		Else
			adjustDown(CheckBox117.Text)
			reservations.Remove(CheckBox117)
		End If
	End Sub

	Private Sub Checkbox118_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox118.CheckedChanged
		If CheckBox118.Checked Then
			reservations.Add(CheckBox118, CheckBox118.Text)
			adjustUp(CheckBox118.Text)
		Else
			adjustDown(CheckBox118.Text)
			reservations.Remove(CheckBox118)
		End If
	End Sub

	Private Sub Checkbox119_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox119.CheckedChanged
		If CheckBox119.Checked Then
			reservations.Add(CheckBox119, CheckBox119.Text)
			adjustUp(CheckBox119.Text)
		Else
			adjustDown(CheckBox119.Text)
			reservations.Remove(CheckBox119)
		End If
	End Sub

	Private Sub Checkbox120_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox120.CheckedChanged
		If CheckBox120.Checked Then
			reservations.Add(CheckBox120, CheckBox120.Text)
			adjustUp(CheckBox120.Text)
		Else
			adjustDown(CheckBox120.Text)
			reservations.Remove(CheckBox120)
		End If
	End Sub

	Private Sub Checkbox121_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox121.CheckedChanged
		If CheckBox121.Checked Then
			reservations.Add(CheckBox121, CheckBox121.Text)
			adjustUp(CheckBox121.Text)
		Else
			adjustDown(CheckBox121.Text)
			reservations.Remove(CheckBox121)
		End If
	End Sub

	Private Sub Checkbox122_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox122.CheckedChanged
		If CheckBox122.Checked Then
			reservations.Add(CheckBox122, CheckBox122.Text)
			adjustUp(CheckBox122.Text)
		Else
			adjustDown(CheckBox122.Text)
			reservations.Remove(CheckBox122)
		End If
	End Sub

	Private Sub Checkbox123_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox123.CheckedChanged
		If CheckBox123.Checked Then
			reservations.Add(CheckBox123, CheckBox123.Text)
			adjustUp(CheckBox123.Text)
		Else
			adjustDown(CheckBox123.Text)
			reservations.Remove(CheckBox123)
		End If
	End Sub

	Private Sub Checkbox124_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox124.CheckedChanged
		If CheckBox124.Checked Then
			reservations.Add(CheckBox124, CheckBox124.Text)
			adjustUp(CheckBox124.Text)
		Else
			adjustDown(CheckBox124.Text)
			reservations.Remove(CheckBox124)
		End If
	End Sub

	Private Sub Checkbox125_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox125.CheckedChanged
		If CheckBox125.Checked Then
			reservations.Add(CheckBox125, CheckBox125.Text)
			adjustUp(CheckBox125.Text)
		Else
			adjustDown(CheckBox125.Text)
			reservations.Remove(CheckBox125)
		End If
	End Sub

	Private Sub Checkbox126_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox126.CheckedChanged
		If CheckBox126.Checked Then
			reservations.Add(CheckBox126, CheckBox126.Text)
			adjustUp(CheckBox126.Text)
		Else
			adjustDown(CheckBox126.Text)
			reservations.Remove(CheckBox126)
		End If
	End Sub

	Private Sub Checkbox127_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox127.CheckedChanged
		If CheckBox127.Checked Then
			reservations.Add(CheckBox127, CheckBox127.Text)
			adjustUp(CheckBox127.Text)
		Else
			adjustDown(CheckBox127.Text)
			reservations.Remove(CheckBox127)
		End If
	End Sub

	Private Sub Checkbox128_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox128.CheckedChanged
		If CheckBox128.Checked Then
			reservations.Add(CheckBox128, CheckBox128.Text)
			adjustUp(CheckBox128.Text)
		Else
			adjustDown(CheckBox128.Text)
			reservations.Remove(CheckBox128)
		End If
	End Sub

	'129
	'130

	Private Sub Checkbox131_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox131.CheckedChanged
		If CheckBox131.Checked Then
			reservations.Add(CheckBox131, CheckBox131.Text)
			adjustUp(CheckBox131.Text)
		Else
			adjustDown(CheckBox131.Text)
			reservations.Remove(CheckBox131)
		End If
	End Sub

	Private Sub Checkbox132_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox132.CheckedChanged
		If CheckBox132.Checked Then
			reservations.Add(CheckBox132, CheckBox132.Text)
			adjustUp(CheckBox132.Text)
		Else
			adjustDown(CheckBox132.Text)
			reservations.Remove(CheckBox132)
		End If
	End Sub

	'133

	Private Sub Checkbox134_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox134.CheckedChanged
		If CheckBox134.Checked Then
			reservations.Add(CheckBox134, CheckBox134.Text)
			adjustUp(CheckBox134.Text)
		Else
			adjustDown(CheckBox134.Text)
			reservations.Remove(CheckBox134)
		End If
	End Sub

	Private Sub Checkbox135_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox135.CheckedChanged
		If CheckBox135.Checked Then
			reservations.Add(CheckBox135, CheckBox135.Text)
			adjustUp(CheckBox135.Text)
		Else
			adjustDown(CheckBox135.Text)
			reservations.Remove(CheckBox135)
		End If
	End Sub

	Private Sub Checkbox136_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox136.CheckedChanged
		If CheckBox136.Checked Then
			reservations.Add(CheckBox136, CheckBox136.Text)
			adjustUp(CheckBox136.Text)
		Else
			adjustDown(CheckBox136.Text)
			reservations.Remove(CheckBox136)
		End If
	End Sub

	Private Sub Checkbox137_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox137.CheckedChanged
		If CheckBox137.Checked Then
			reservations.Add(CheckBox137, CheckBox137.Text)
			adjustUp(CheckBox137.Text)
		Else
			adjustDown(CheckBox137.Text)
			reservations.Remove(CheckBox137)
		End If
	End Sub

	Private Sub Checkbox138_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox138.CheckedChanged
		If CheckBox138.Checked Then
			reservations.Add(CheckBox138, CheckBox138.Text)
			adjustUp(CheckBox138.Text)
		Else
			adjustDown(CheckBox138.Text)
			reservations.Remove(CheckBox138)
		End If
	End Sub

	Private Sub Checkbox139_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox139.CheckedChanged
		If CheckBox139.Checked Then
			reservations.Add(CheckBox139, CheckBox139.Text)
			adjustUp(CheckBox139.Text)
		Else
			adjustDown(CheckBox139.Text)
			reservations.Remove(CheckBox139)
		End If
	End Sub

	Private Sub Checkbox140_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox140.CheckedChanged
		If CheckBox140.Checked Then
			reservations.Add(CheckBox140, CheckBox140.Text)
			adjustUp(CheckBox140.Text)
		Else
			adjustDown(CheckBox140.Text)
			reservations.Remove(CheckBox140)
		End If
	End Sub

	Private Sub Checkbox141_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox141.CheckedChanged
		If CheckBox141.Checked Then
			reservations.Add(CheckBox141, CheckBox141.Text)
			adjustUp(CheckBox141.Text)
		Else
			adjustDown(CheckBox141.Text)
			reservations.Remove(CheckBox141)
		End If
	End Sub

	Private Sub Checkbox142_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox142.CheckedChanged
		If CheckBox142.Checked Then
			reservations.Add(CheckBox142, CheckBox142.Text)
			adjustUp(CheckBox142.Text)
		Else
			adjustDown(CheckBox142.Text)
			reservations.Remove(CheckBox142)
		End If
	End Sub

	Private Sub Checkbox143_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox143.CheckedChanged
		If CheckBox143.Checked Then
			reservations.Add(CheckBox143, CheckBox143.Text)
			adjustUp(CheckBox143.Text)
		Else
			adjustDown(CheckBox143.Text)
			reservations.Remove(CheckBox143)
		End If
	End Sub

	Private Sub Checkbox144_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox144.CheckedChanged
		If CheckBox144.Checked Then
			reservations.Add(CheckBox144, CheckBox144.Text)
			adjustUp(CheckBox144.Text)
		Else
			adjustDown(CheckBox144.Text)
			reservations.Remove(CheckBox144)
		End If
	End Sub

	Private Sub Checkbox145_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox145.CheckedChanged
		If CheckBox145.Checked Then
			reservations.Add(CheckBox145, CheckBox145.Text)
			adjustUp(CheckBox145.Text)
		Else
			adjustDown(CheckBox145.Text)
			reservations.Remove(CheckBox145)
		End If
	End Sub

	Private Sub Checkbox146_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox146.CheckedChanged
		If CheckBox146.Checked Then
			reservations.Add(CheckBox146, CheckBox146.Text)
			adjustUp(CheckBox146.Text)
		Else
			adjustDown(CheckBox146.Text)
			reservations.Remove(CheckBox146)
		End If
	End Sub

	Private Sub Checkbox147_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox147.CheckedChanged
		If CheckBox147.Checked Then
			reservations.Add(CheckBox147, CheckBox147.Text)
			adjustUp(CheckBox147.Text)
		Else
			adjustDown(CheckBox147.Text)
			reservations.Remove(CheckBox147)
		End If
	End Sub

	Private Sub Checkbox148_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox148.CheckedChanged
		If CheckBox148.Checked Then
			reservations.Add(CheckBox148, CheckBox148.Text)
			adjustUp(CheckBox148.Text)
		Else
			adjustDown(CheckBox148.Text)
			reservations.Remove(CheckBox148)
		End If
	End Sub

	Private Sub Checkbox149_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox149.CheckedChanged
		If CheckBox149.Checked Then
			reservations.Add(CheckBox149, CheckBox149.Text)
			adjustUp(CheckBox149.Text)
		Else
			adjustDown(CheckBox149.Text)
			reservations.Remove(CheckBox149)
		End If
	End Sub

	Private Sub Checkbox150_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox150.CheckedChanged
		If CheckBox150.Checked Then
			reservations.Add(CheckBox150, CheckBox150.Text)
			adjustUp(CheckBox150.Text)
		Else
			adjustDown(CheckBox150.Text)
			reservations.Remove(CheckBox150)
		End If
	End Sub

	Private Sub Checkbox151_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox151.CheckedChanged
		If CheckBox151.Checked Then
			reservations.Add(CheckBox151, CheckBox151.Text)
			adjustUp(CheckBox151.Text)
		Else
			adjustDown(CheckBox151.Text)
			reservations.Remove(CheckBox151)
		End If
	End Sub

	Private Sub Checkbox152_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox152.CheckedChanged
		If CheckBox152.Checked Then
			reservations.Add(CheckBox152, CheckBox152.Text)
			adjustUp(CheckBox152.Text)
		Else
			adjustDown(CheckBox152.Text)
			reservations.Remove(CheckBox152)
		End If
	End Sub

	Private Sub Checkbox153_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox153.CheckedChanged
		If CheckBox153.Checked Then
			reservations.Add(CheckBox153, CheckBox153.Text)
			adjustUp(CheckBox153.Text)
		Else
			adjustDown(CheckBox153.Text)
			reservations.Remove(CheckBox153)
		End If
	End Sub

	Private Sub Checkbox154_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox154.CheckedChanged
		If CheckBox154.Checked Then
			reservations.Add(CheckBox154, CheckBox154.Text)
			adjustUp(CheckBox154.Text)
		Else
			adjustDown(CheckBox154.Text)
			reservations.Remove(CheckBox154)
		End If
	End Sub

	Private Sub Checkbox155_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox155.CheckedChanged
		If CheckBox155.Checked Then
			reservations.Add(CheckBox155, CheckBox155.Text)
			adjustUp(CheckBox155.Text)
		Else
			adjustDown(CheckBox155.Text)
			reservations.Remove(CheckBox155)
		End If
	End Sub

	Private Sub Checkbox156_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox156.CheckedChanged
		If CheckBox156.Checked Then
			reservations.Add(CheckBox156, CheckBox156.Text)
			adjustUp(CheckBox156.Text)
		Else
			adjustDown(CheckBox156.Text)
			reservations.Remove(CheckBox156)
		End If
	End Sub

	Private Sub Checkbox157_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox157.CheckedChanged
		If CheckBox157.Checked Then
			reservations.Add(CheckBox157, CheckBox157.Text)
			adjustUp(CheckBox157.Text)
		Else
			adjustDown(CheckBox157.Text)
			reservations.Remove(CheckBox157)
		End If
	End Sub

	Private Sub Checkbox158_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox158.CheckedChanged
		If CheckBox158.Checked Then
			reservations.Add(CheckBox158, CheckBox158.Text)
			adjustUp(CheckBox158.Text)
		Else
			adjustDown(CheckBox158.Text)
			reservations.Remove(CheckBox158)
		End If
	End Sub

	Private Sub Checkbox159_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox159.CheckedChanged
		If CheckBox159.Checked Then
			reservations.Add(CheckBox159, CheckBox159.Text)
			adjustUp(CheckBox159.Text)
		Else
			adjustDown(CheckBox159.Text)
			reservations.Remove(CheckBox159)
		End If
	End Sub

	Private Sub Checkbox160_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox160.CheckedChanged
		If CheckBox160.Checked Then
			reservations.Add(CheckBox160, CheckBox160.Text)
			adjustUp(CheckBox160.Text)
		Else
			adjustDown(CheckBox160.Text)
			reservations.Remove(CheckBox160)
		End If
	End Sub

	Private Sub Checkbox161_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox161.CheckedChanged
		If CheckBox161.Checked Then
			reservations.Add(CheckBox161, CheckBox161.Text)
			adjustUp(CheckBox161.Text)
		Else
			adjustDown(CheckBox161.Text)
			reservations.Remove(CheckBox161)
		End If
	End Sub

	Private Sub Checkbox162_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox162.CheckedChanged
		If CheckBox162.Checked Then
			reservations.Add(CheckBox162, CheckBox162.Text)
			adjustUp(CheckBox162.Text)
		Else
			adjustDown(CheckBox162.Text)
			reservations.Remove(CheckBox162)
		End If
	End Sub

	Private Sub Checkbox163_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox163.CheckedChanged
		If CheckBox163.Checked Then
			reservations.Add(CheckBox163, CheckBox163.Text)
			adjustUp(CheckBox163.Text)
		Else
			adjustDown(CheckBox163.Text)
			reservations.Remove(CheckBox163)
		End If
	End Sub

	Private Sub Checkbox164_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox164.CheckedChanged
		If CheckBox164.Checked Then
			reservations.Add(CheckBox164, CheckBox164.Text)
			adjustUp(CheckBox164.Text)
		Else
			adjustDown(CheckBox164.Text)
			reservations.Remove(CheckBox164)
		End If
	End Sub

	Private Sub Checkbox165_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox165.CheckedChanged
		If CheckBox165.Checked Then
			reservations.Add(CheckBox165, CheckBox165.Text)
			adjustUp(CheckBox165.Text)
		Else
			adjustDown(CheckBox165.Text)
			reservations.Remove(CheckBox165)
		End If
	End Sub

	Private Sub Checkbox166_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox166.CheckedChanged
		If CheckBox166.Checked Then
			reservations.Add(CheckBox166, CheckBox166.Text)
			adjustUp(CheckBox166.Text)
		Else
			adjustDown(CheckBox166.Text)
			reservations.Remove(CheckBox166)
		End If
	End Sub

	Private Sub Checkbox167_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox167.CheckedChanged
		If CheckBox167.Checked Then
			reservations.Add(CheckBox167, CheckBox167.Text)
			adjustUp(CheckBox167.Text)
		Else
			adjustDown(CheckBox167.Text)
			reservations.Remove(CheckBox167)
		End If
	End Sub

	Private Sub Checkbox168_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox168.CheckedChanged
		If CheckBox168.Checked Then
			reservations.Add(CheckBox168, CheckBox168.Text)
			adjustUp(CheckBox168.Text)
		Else
			adjustDown(CheckBox168.Text)
			reservations.Remove(CheckBox168)
		End If
	End Sub

	Private Sub Checkbox169_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox169.CheckedChanged
		If CheckBox169.Checked Then
			reservations.Add(CheckBox169, CheckBox169.Text)
			adjustUp(CheckBox169.Text)
		Else
			adjustDown(CheckBox169.Text)
			reservations.Remove(CheckBox169)
		End If
	End Sub

	Private Sub Checkbox170_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox170.CheckedChanged
		If CheckBox170.Checked Then
			reservations.Add(CheckBox170, CheckBox170.Text)
			adjustUp(CheckBox170.Text)
		Else
			adjustDown(CheckBox170.Text)
			reservations.Remove(CheckBox170)
		End If
	End Sub

	Private Sub Checkbox171_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox171.CheckedChanged
		If CheckBox171.Checked Then
			reservations.Add(CheckBox171, CheckBox171.Text)
			adjustUp(CheckBox171.Text)
		Else
			adjustDown(CheckBox171.Text)
			reservations.Remove(CheckBox171)
		End If
	End Sub

	Private Sub Checkbox172_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox172.CheckedChanged
		If CheckBox172.Checked Then
			reservations.Add(CheckBox172, CheckBox172.Text)
			adjustUp(CheckBox172.Text)
		Else
			adjustDown(CheckBox172.Text)
			reservations.Remove(CheckBox172)
		End If
	End Sub

	Private Sub Checkbox173_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox173.CheckedChanged
		If CheckBox173.Checked Then
			reservations.Add(CheckBox173, CheckBox173.Text)
			adjustUp(CheckBox173.Text)
		Else
			adjustDown(CheckBox173.Text)
			reservations.Remove(CheckBox173)
		End If
	End Sub

	Private Sub Checkbox174_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox174.CheckedChanged
		If CheckBox174.Checked Then
			reservations.Add(CheckBox174, CheckBox174.Text)
			adjustUp(CheckBox174.Text)
		Else
			adjustDown(CheckBox174.Text)
			reservations.Remove(CheckBox174)
		End If
	End Sub

	Private Sub Checkbox175_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox175.CheckedChanged
		If CheckBox175.Checked Then
			reservations.Add(CheckBox175, CheckBox175.Text)
			adjustUp(CheckBox175.Text)
		Else
			adjustDown(CheckBox175.Text)
			reservations.Remove(CheckBox175)
		End If
	End Sub

	Private Sub Checkbox176_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox176.CheckedChanged
		If CheckBox176.Checked Then
			reservations.Add(CheckBox176, CheckBox176.Text)
			adjustUp(CheckBox176.Text)
		Else
			adjustDown(CheckBox176.Text)
			reservations.Remove(CheckBox176)
		End If
	End Sub

	Private Sub Checkbox177_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox177.CheckedChanged
		If CheckBox177.Checked Then
			reservations.Add(CheckBox177, CheckBox177.Text)
			adjustUp(CheckBox177.Text)
		Else
			adjustDown(CheckBox177.Text)
			reservations.Remove(CheckBox177)
		End If
	End Sub

	Private Sub Checkbox178_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox178.CheckedChanged
		If CheckBox178.Checked Then
			reservations.Add(CheckBox178, CheckBox178.Text)
			adjustUp(CheckBox178.Text)
		Else
			adjustDown(CheckBox178.Text)
			reservations.Remove(CheckBox178)
		End If
	End Sub

	Private Sub Checkbox179_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox179.CheckedChanged
		If CheckBox179.Checked Then
			reservations.Add(CheckBox179, CheckBox179.Text)
			adjustUp(CheckBox179.Text)
		Else
			adjustDown(CheckBox179.Text)
			reservations.Remove(CheckBox179)
		End If
	End Sub

	Private Sub Checkbox180_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox180.CheckedChanged
		If CheckBox180.Checked Then
			reservations.Add(CheckBox180, CheckBox180.Text)
			adjustUp(CheckBox180.Text)
		Else
			adjustDown(CheckBox180.Text)
			reservations.Remove(CheckBox180)
		End If
	End Sub

	Private Sub Checkbox181_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox181.CheckedChanged
		If CheckBox181.Checked Then
			reservations.Add(CheckBox181, CheckBox181.Text)
			adjustUp(CheckBox181.Text)
		Else
			adjustDown(CheckBox181.Text)
			reservations.Remove(CheckBox181)
		End If
	End Sub

	Private Sub Checkbox182_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox182.CheckedChanged
		If CheckBox182.Checked Then
			reservations.Add(CheckBox182, CheckBox182.Text)
			adjustUp(CheckBox182.Text)
		Else
			adjustDown(CheckBox182.Text)
			reservations.Remove(CheckBox182)
		End If
	End Sub

	Private Sub Checkbox183_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox183.CheckedChanged
		If CheckBox183.Checked Then
			reservations.Add(CheckBox183, CheckBox183.Text)
			adjustUp(CheckBox183.Text)
		Else
			adjustDown(CheckBox183.Text)
			reservations.Remove(CheckBox183)
		End If
	End Sub

	Private Sub Checkbox184_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox184.CheckedChanged
		If CheckBox184.Checked Then
			reservations.Add(CheckBox184, CheckBox184.Text)
			adjustUp(CheckBox184.Text)
		Else
			adjustDown(CheckBox184.Text)
			reservations.Remove(CheckBox184)
		End If
	End Sub

	Private Sub Checkbox185_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox185.CheckedChanged
		If CheckBox185.Checked Then
			reservations.Add(CheckBox185, CheckBox185.Text)
			adjustUp(CheckBox185.Text)
		Else
			adjustDown(CheckBox185.Text)
			reservations.Remove(CheckBox185)
		End If
	End Sub

	Private Sub Checkbox186_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox186.CheckedChanged
		If CheckBox186.Checked Then
			reservations.Add(CheckBox186, CheckBox186.Text)
			adjustUp(CheckBox186.Text)
		Else
			adjustDown(CheckBox186.Text)
			reservations.Remove(CheckBox186)
		End If
	End Sub

	Private Sub Checkbox187_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox187.CheckedChanged
		If CheckBox187.Checked Then
			reservations.Add(CheckBox187, CheckBox187.Text)
			adjustUp(CheckBox187.Text)
		Else
			adjustDown(CheckBox187.Text)
			reservations.Remove(CheckBox187)
		End If
	End Sub

	Private Sub Checkbox188_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox188.CheckedChanged
		If CheckBox188.Checked Then
			reservations.Add(CheckBox188, CheckBox188.Text)
			adjustUp(CheckBox188.Text)
		Else
			adjustDown(CheckBox188.Text)
			reservations.Remove(CheckBox188)
		End If
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		If CheckBox1.Checked Then
			reservations.Add(CheckBox1, CheckBox1.Text)
			adjustUp(CheckBox1.Text)
		Else
			adjustDown(CheckBox1.Text)
			reservations.Remove(CheckBox1)
		End If
	End Sub

	Private Sub cashField_Validating(sender As Object, e As CancelEventArgs) Handles cashField.Validating
		For Each letter In cashField.Text
			If Not IsNumeric(letter) Then
				e.Cancel = True
				MessageBox.Show("Invalid Cash Input, Please Try Again")
				cashField.Clear()
			End If
		Next
	End Sub

	Private Sub nameField_Validating(sender As Object, e As CancelEventArgs) Handles nameField.Validating
		Dim lettersBecauseImToolazt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ, ."
		For Each letter In nameField.Text
			If Not lettersBecauseImToolazt.Contains(letter.ToString.ToUpper()) Or nameField.Text = " " Then
				e.Cancel = True
				MessageBox.Show("Invalid Name Input, Please Try Again")
				nameField.Clear()
			End If
		Next
	End Sub

	Private Sub seatLayoutGroup_MouseUp(sender As Object, e As MouseEventArgs) Handles seatLayoutGroup.MouseUp
		If TypeOf seatLayoutGroup.GetChildAtPoint(e.Location) Is CheckBox Then
			Dim command As New OleDb.OleDbCommand("SELECT TOP 1 customerName FROM history WHERE eventName='" & eventsList.Text & "' AND DT='" & dateList.Text & "' AND time='" & timeLIst.Text & "' AND seat='" & seatLayoutGroup.GetChildAtPoint(e.Location).Text() & "'", connection)
			Dim reader = command.ExecuteReader()
			reader.Read()
			Dim tempName = reader.GetString(0)
			MessageBox.Show(tempName)
			command = New OleDb.OleDbCommand("SELECT * FROM history WHERE customerName='" & tempName & "' AND eventName='" & eventsList.Text & "' AND DT='" & dateList.Text & "' AND time='" & timeLIst.Text & "'", connection)
			Dim table As New DataTable()
			table.Load(command.ExecuteReader())
			Receipt.clear()
			Receipt.nem.Text = tempName
			Receipt.ebentnem.Text = eventsList.Text
			Receipt.det.Text = dateList.Text
			Receipt.taym.Text = timeLIst.Text
			For Each row In table.Rows
				Receipt.ListBox1.Items.Add(row.Item(4))
			Next
			Receipt.tototal.Text = table.Rows(0).Item(3)
			Receipt.kakashi.Text = table.Rows(0).Item(6)
			Receipt.chenji.Text = Val(table.Rows(0).Item(6)) - Val(table.Rows(0).Item(3))
			Receipt.Show()
		End If
	End Sub
End Class