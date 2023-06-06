Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1
    'fields
    Private currentBtn As IconButton
    Private leftBoarderBtn As Panel
    Private currentChildForm As Form

    'other shit
    Public userLogged As Boolean
    Public adminLogged As Boolean
    Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hargus\Desktop\db.mdb"
    '"C:\Users\hargus\Desktop\db.mdb"
    Public currentUser As String
    Dim connection As New OleDb.OleDbConnection()

    'Constructor
    Public Sub New()
        'this call is req by the designer
        InitializeComponent()

        'Add any Init. after the InitComponent().
        leftBoarderBtn = New Panel()
        leftBoarderBtn.Size = New Size(7, 71)
        PanelMenu.Controls.Add(leftBoarderBtn)

        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            'left Border
            leftBoarderBtn.BackColor = customColor
            leftBoarderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBoarderBtn.Visible = True
            leftBoarderBtn.BringToFront()

            'Current Form Icon
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only Form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.BackColor = Color.FromArgb(34, 33, 74)
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text


    End Sub

    'Events 
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        If userLogged Or adminLogged Then
            ActivateButton(sender, RGBColors.color1)
            OpenChildForm(New Dashboard)
        Else
            MessageBox.Show("Please Log-in First")
        End If
    End Sub

    Private Sub Seats_Click(sender As Object, e As EventArgs) Handles Seats.Click
        If userLogged Or adminLogged Then
            ActivateButton(sender, RGBColors.color2)
            OpenChildForm(New Seats)
        Else
            MessageBox.Show("Please Log-in First")
        End If
    End Sub

    Private Sub PastTransaction_Click(sender As Object, e As EventArgs) Handles PastTransaction.Click
        If userLogged Or adminLogged Then
            ActivateButton(sender, RGBColors.color3)
            OpenChildForm(New Transactions)
        Else
            MessageBox.Show("Please Log-in First")
        End If
    End Sub

    Private Sub UpConcert_Click(sender As Object, e As EventArgs) Handles UpcomingConcert.Click
        If userLogged Or adminLogged Then
            ActivateButton(sender, RGBColors.color4)
            OpenChildForm(New UpcomingConcerts)
        Else
            MessageBox.Show("Please Log-in as administrator First")
        End If
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        If adminLogged Or userLogged Then
            ActivateButton(sender, RGBColors.color5)
            OpenChildForm(New Settings)
        Else
            MessageBox.Show("Please Log-in First")
        End If
    End Sub

    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        If adminLogged Or userLogged Then
            ActivateButton(sender, RGBColors.color6)
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
            End If
            userLogged = False
            adminLogged = False
            Reset()
        Else
            MessageBox.Show("Please Log-in First")
        End If
    End Sub


    Private Sub Reset()
        DisableButton()
        leftBoarderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Flipboard
        IconCurrentForm.IconColor = Color.MediumPurple
        lblFormTitle.Text = "Dashboard"
    End Sub

    'Drag form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Private Sub PictureLogo_Click(sender As Object, e As EventArgs) Handles PictureLogo.Click
    '    If currentChildForm IsNot Nothing Then
    '        currentChildForm.Close()
    '    End If
    '    Reset()
    'End Sub

    Private Sub tmrTimer_Tick(sender As Object, e As EventArgs) Handles tmrTimer.Tick
        'with Am/pm
        lblClock2.Text = DateTime.Now.ToString("hh:mm tt")
        lblDate.Text = DateTime.Now.ToString("MMMM dd yyyy")
        lblDay.Text = DateTime.Now.ToString("dddd")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = connectionString
        connection.Open()
        userLogged = False
        adminLogged = False
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        If userField.Text = "" Then
            MessageBox.Show("Missing User Name")
        ElseIf passwordFIeld.Text = "" Then
            MessageBox.Show("Missing Password")
        Else
            Dim command As New OleDb.OleDbCommand("SELECT * FROM users WHERE username='" & userField.Text & "'", connection)
            Dim reader As OleDb.OleDbDataReader = command.ExecuteReader()
            If reader.Read() Then
                If reader.GetBoolean(3) And passwordFIeld.Text = reader.GetString(1) Then
                    'admin
                    adminLogged = True
                ElseIf Not reader.GetBoolean(3) And passwordFIeld.Text = reader.GetString(1) And reader.GetBoolean(2) Then
                    'user
                    If Not userField.Items.Contains(userField.Text) Then
                        userField.Items.Add(userField.Text)
                    End If
                    userLogged = True
                End If
                userField.ResetText()
                passwordFIeld.ResetText()
                currentUser = userField.Text
                Dashboard_Click(sender, e)
            Else
                MessageBox.Show("User [" & userField.Text & "] not found")
                userField.ResetText()
                passwordFIeld.ResetText()
            End If
        End If
    End Sub

    Private Sub passwordFIeld_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordFIeld.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUser_Click(btnUser, e)
        End If
    End Sub

    Private Sub userField_KeyDown(sender As Object, e As KeyEventArgs) Handles userField.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUser_Click(btnUser, e)
        End If
    End Sub
End Class
