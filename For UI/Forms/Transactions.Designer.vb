<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.matches = New System.Windows.Forms.DataGridView()
        Me.searchBar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.currentChange = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.currentCash = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.currentPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.currentSeat = New System.Windows.Forms.TextBox()
        Me.currentTime = New System.Windows.Forms.TextBox()
        Me.currentDate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentEvent = New System.Windows.Forms.TextBox()
        Me.currentName = New System.Windows.Forms.TextBox()
        Me.currentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDesktop.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.matches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.GroupBox2)
        Me.PanelDesktop.Controls.Add(Me.GroupBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(778, 474)
        Me.PanelDesktop.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.matches)
        Me.GroupBox2.Controls.Add(Me.searchBar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(280, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 410)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'matches
        '
        Me.matches.AllowUserToAddRows = False
        Me.matches.AllowUserToDeleteRows = False
        Me.matches.AllowUserToOrderColumns = True
        Me.matches.AllowUserToResizeRows = False
        Me.matches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.matches.BackgroundColor = System.Drawing.Color.White
        Me.matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.matches.DefaultCellStyle = DataGridViewCellStyle1
        Me.matches.GridColor = System.Drawing.Color.Black
        Me.matches.Location = New System.Drawing.Point(16, 77)
        Me.matches.MultiSelect = False
        Me.matches.Name = "matches"
        Me.matches.ReadOnly = True
        Me.matches.RowHeadersVisible = False
        Me.matches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.matches.Size = New System.Drawing.Size(410, 314)
        Me.matches.TabIndex = 4
        '
        'searchBar
        '
        Me.searchBar.Location = New System.Drawing.Point(40, 34)
        Me.searchBar.Name = "searchBar"
        Me.searchBar.Size = New System.Drawing.Size(155, 20)
        Me.searchBar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.user)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.currentChange)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.currentCash)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.currentPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.currentSeat)
        Me.GroupBox1.Controls.Add(Me.currentTime)
        Me.GroupBox1.Controls.Add(Me.currentDate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.currentEvent)
        Me.GroupBox1.Controls.Add(Me.currentName)
        Me.GroupBox1.Controls.Add(Me.currentID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(36, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 412)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Search"
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(82, 35)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(98, 23)
        Me.user.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(33, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "User"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(61, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Change"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentChange
        '
        Me.currentChange.Location = New System.Drawing.Point(82, 368)
        Me.currentChange.Name = "currentChange"
        Me.currentChange.Size = New System.Drawing.Size(61, 23)
        Me.currentChange.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cash"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentCash
        '
        Me.currentCash.Location = New System.Drawing.Point(82, 331)
        Me.currentCash.Name = "currentCash"
        Me.currentCash.Size = New System.Drawing.Size(61, 23)
        Me.currentCash.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Price"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentPrice
        '
        Me.currentPrice.Location = New System.Drawing.Point(82, 294)
        Me.currentPrice.Name = "currentPrice"
        Me.currentPrice.Size = New System.Drawing.Size(61, 23)
        Me.currentPrice.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Seat"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentSeat
        '
        Me.currentSeat.Location = New System.Drawing.Point(82, 258)
        Me.currentSeat.Name = "currentSeat"
        Me.currentSeat.Size = New System.Drawing.Size(61, 23)
        Me.currentSeat.TabIndex = 11
        '
        'currentTime
        '
        Me.currentTime.Location = New System.Drawing.Point(82, 221)
        Me.currentTime.Name = "currentTime"
        Me.currentTime.Size = New System.Drawing.Size(114, 23)
        Me.currentTime.TabIndex = 10
        '
        'currentDate
        '
        Me.currentDate.Location = New System.Drawing.Point(82, 183)
        Me.currentDate.Name = "currentDate"
        Me.currentDate.Size = New System.Drawing.Size(114, 23)
        Me.currentDate.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Event"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentEvent
        '
        Me.currentEvent.Location = New System.Drawing.Point(82, 145)
        Me.currentEvent.Name = "currentEvent"
        Me.currentEvent.Size = New System.Drawing.Size(114, 23)
        Me.currentEvent.TabIndex = 5
        '
        'currentName
        '
        Me.currentName.Location = New System.Drawing.Point(82, 108)
        Me.currentName.Name = "currentName"
        Me.currentName.Size = New System.Drawing.Size(114, 23)
        Me.currentName.TabIndex = 3
        '
        'currentID
        '
        Me.currentID.Location = New System.Drawing.Point(82, 71)
        Me.currentID.Name = "currentID"
        Me.currentID.Size = New System.Drawing.Size(61, 23)
        Me.currentID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ticket ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 474)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        Me.PanelDesktop.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.matches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents searchBar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents currentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents currentEvent As TextBox
    Friend WithEvents currentName As TextBox
    Friend WithEvents matches As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents currentChange As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents currentCash As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents currentPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents currentSeat As TextBox
    Friend WithEvents currentTime As TextBox
    Friend WithEvents currentDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents user As TextBox
    Friend WithEvents Label11 As Label
End Class
