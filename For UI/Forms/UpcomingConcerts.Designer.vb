<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpcomingConcerts
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.eventView = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.eventDetails = New System.Windows.Forms.GroupBox()
        Me.removeEvent = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.eventIcon = New System.Windows.Forms.PictureBox()
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.editButton = New FontAwesome.Sharp.IconButton()
        Me.clearButton = New FontAwesome.Sharp.IconButton()
        Me.addButton = New FontAwesome.Sharp.IconButton()
        Me.prices = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.currentEvent = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.eventView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.eventDetails.SuspendLayout()
        CType(Me.eventIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.eventView)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(427, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 406)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search"
        '
        'eventView
        '
        Me.eventView.AllowUserToAddRows = False
        Me.eventView.AllowUserToDeleteRows = False
        Me.eventView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.eventView.BackgroundColor = System.Drawing.Color.White
        Me.eventView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.eventView.DefaultCellStyle = DataGridViewCellStyle1
        Me.eventView.Location = New System.Drawing.Point(25, 81)
        Me.eventView.MultiSelect = False
        Me.eventView.Name = "eventView"
        Me.eventView.ReadOnly = True
        Me.eventView.RowHeadersVisible = False
        Me.eventView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.eventView.Size = New System.Drawing.Size(253, 303)
        Me.eventView.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 2
        '
        'eventDetails
        '
        Me.eventDetails.Controls.Add(Me.removeEvent)
        Me.eventDetails.Controls.Add(Me.IconButton1)
        Me.eventDetails.Controls.Add(Me.eventIcon)
        Me.eventDetails.Controls.Add(Me.timePicker)
        Me.eventDetails.Controls.Add(Me.editButton)
        Me.eventDetails.Controls.Add(Me.clearButton)
        Me.eventDetails.Controls.Add(Me.addButton)
        Me.eventDetails.Controls.Add(Me.prices)
        Me.eventDetails.Controls.Add(Me.currentDate)
        Me.eventDetails.Controls.Add(Me.Label7)
        Me.eventDetails.Controls.Add(Me.Label5)
        Me.eventDetails.Controls.Add(Me.Label6)
        Me.eventDetails.Controls.Add(Me.Label2)
        Me.eventDetails.Controls.Add(Me.currentEvent)
        Me.eventDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventDetails.ForeColor = System.Drawing.Color.White
        Me.eventDetails.Location = New System.Drawing.Point(31, 11)
        Me.eventDetails.Name = "eventDetails"
        Me.eventDetails.Size = New System.Drawing.Size(369, 407)
        Me.eventDetails.TabIndex = 25
        Me.eventDetails.TabStop = False
        Me.eventDetails.Text = "Event Details"
        '
        'removeEvent
        '
        Me.removeEvent.FlatAppearance.BorderSize = 0
        Me.removeEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeEvent.ForeColor = System.Drawing.Color.White
        Me.removeEvent.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.removeEvent.IconColor = System.Drawing.Color.White
        Me.removeEvent.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.removeEvent.IconSize = 25
        Me.removeEvent.Location = New System.Drawing.Point(139, 339)
        Me.removeEvent.Name = "removeEvent"
        Me.removeEvent.Size = New System.Drawing.Size(95, 32)
        Me.removeEvent.TabIndex = 33
        Me.removeEvent.Text = "Remove"
        Me.removeEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.removeEvent.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 20
        Me.IconButton1.Location = New System.Drawing.Point(22, 140)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(80, 32)
        Me.IconButton1.TabIndex = 32
        Me.IconButton1.Text = "Browse"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'eventIcon
        '
        Me.eventIcon.Location = New System.Drawing.Point(6, 22)
        Me.eventIcon.Name = "eventIcon"
        Me.eventIcon.Size = New System.Drawing.Size(112, 112)
        Me.eventIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eventIcon.TabIndex = 26
        Me.eventIcon.TabStop = False
        '
        'timePicker
        '
        Me.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timePicker.Location = New System.Drawing.Point(185, 100)
        Me.timePicker.MinDate = New Date(2021, 1, 5, 0, 0, 0, 0)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.ShowUpDown = True
        Me.timePicker.Size = New System.Drawing.Size(121, 23)
        Me.timePicker.TabIndex = 28
        Me.timePicker.Value = New Date(2021, 1, 5, 0, 0, 0, 0)
        '
        'editButton
        '
        Me.editButton.FlatAppearance.BorderSize = 0
        Me.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editButton.ForeColor = System.Drawing.Color.White
        Me.editButton.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.editButton.IconColor = System.Drawing.Color.White
        Me.editButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.editButton.IconSize = 25
        Me.editButton.Location = New System.Drawing.Point(247, 300)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(80, 32)
        Me.editButton.TabIndex = 27
        Me.editButton.Text = "Save"
        Me.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.editButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.FlatAppearance.BorderSize = 0
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.ForeColor = System.Drawing.Color.White
        Me.clearButton.IconChar = FontAwesome.Sharp.IconChar.Soap
        Me.clearButton.IconColor = System.Drawing.Color.White
        Me.clearButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.clearButton.IconSize = 23
        Me.clearButton.Location = New System.Drawing.Point(146, 301)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(80, 32)
        Me.clearButton.TabIndex = 25
        Me.clearButton.Text = "Clear"
        Me.clearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.ForeColor = System.Drawing.Color.White
        Me.addButton.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.addButton.IconColor = System.Drawing.Color.White
        Me.addButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addButton.IconSize = 25
        Me.addButton.Location = New System.Drawing.Point(46, 300)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(79, 32)
        Me.addButton.TabIndex = 24
        Me.addButton.Text = "Add"
        Me.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addButton.UseVisualStyleBackColor = True
        '
        'prices
        '
        Me.prices.AllowUserToAddRows = False
        Me.prices.AllowUserToDeleteRows = False
        Me.prices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.prices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.prices.ColumnHeadersHeight = 30
        Me.prices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.prices.Location = New System.Drawing.Point(61, 215)
        Me.prices.MultiSelect = False
        Me.prices.Name = "prices"
        Me.prices.RowHeadersVisible = False
        Me.prices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.prices.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.prices.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.prices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.prices.Size = New System.Drawing.Size(251, 79)
        Me.prices.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "Upper Box"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Lower Box"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "VIP"
        Me.Column3.Name = "Column3"
        '
        'currentDate
        '
        Me.currentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.currentDate.Location = New System.Drawing.Point(185, 64)
        Me.currentDate.MinDate = New Date(2020, 12, 15, 0, 0, 0, 0)
        Me.currentDate.Name = "currentDate"
        Me.currentDate.Size = New System.Drawing.Size(120, 23)
        Me.currentDate.TabIndex = 22
        Me.currentDate.Value = New Date(2020, 12, 29, 10, 3, 16, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Time"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'currentEvent
        '
        Me.currentEvent.Location = New System.Drawing.Point(185, 28)
        Me.currentEvent.Name = "currentEvent"
        Me.currentEvent.Size = New System.Drawing.Size(121, 23)
        Me.currentEvent.TabIndex = 3
        '
        'UpcomingConcerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(748, 442)
        Me.Controls.Add(Me.eventDetails)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "UpcomingConcerts"
        Me.Text = "UpcomingConcerts"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.eventView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.eventDetails.ResumeLayout(False)
        Me.eventDetails.PerformLayout()
        CType(Me.eventIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents eventView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents eventDetails As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents currentEvent As TextBox
    Friend WithEvents clearButton As FontAwesome.Sharp.IconButton
    Friend WithEvents addButton As FontAwesome.Sharp.IconButton
    Friend WithEvents currentDate As DateTimePicker
    Friend WithEvents editButton As FontAwesome.Sharp.IconButton
    Friend WithEvents timePicker As DateTimePicker
    Friend WithEvents eventIcon As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents prices As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents removeEvent As FontAwesome.Sharp.IconButton
End Class
