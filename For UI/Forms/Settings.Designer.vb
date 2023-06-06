<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.userControl = New System.Windows.Forms.GroupBox()
        Me.activeStatus = New System.Windows.Forms.CheckBox()
        Me.saveChanges = New FontAwesome.Sharp.IconButton()
        Me.addUser = New FontAwesome.Sharp.IconButton()
        Me.checkUsername = New FontAwesome.Sharp.IconButton()
        Me.userMatches = New System.Windows.Forms.DataGridView()
        Me.response = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordField2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passwordFIeld = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userField = New System.Windows.Forms.TextBox()
        Me.PanelDesktop.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.userControl.SuspendLayout()
        CType(Me.userMatches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.GroupBox1)
        Me.PanelDesktop.Controls.Add(Me.userControl)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(0, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(952, 483)
        Me.PanelDesktop.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(386, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 332)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(317, 147)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Our Concert & Event Ticketing System will certainly provide expedient and trouble" &
    "-free process" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ticket purchase. Our tickets will surely give you twice the fun!"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(6, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(317, 35)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "★★ About Us ★★"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'userControl
        '
        Me.userControl.Controls.Add(Me.activeStatus)
        Me.userControl.Controls.Add(Me.saveChanges)
        Me.userControl.Controls.Add(Me.addUser)
        Me.userControl.Controls.Add(Me.checkUsername)
        Me.userControl.Controls.Add(Me.userMatches)
        Me.userControl.Controls.Add(Me.response)
        Me.userControl.Controls.Add(Me.Label3)
        Me.userControl.Controls.Add(Me.passwordField2)
        Me.userControl.Controls.Add(Me.Label2)
        Me.userControl.Controls.Add(Me.passwordFIeld)
        Me.userControl.Controls.Add(Me.Label1)
        Me.userControl.Controls.Add(Me.userField)
        Me.userControl.ForeColor = System.Drawing.Color.White
        Me.userControl.Location = New System.Drawing.Point(38, 32)
        Me.userControl.Name = "userControl"
        Me.userControl.Size = New System.Drawing.Size(337, 332)
        Me.userControl.TabIndex = 1
        Me.userControl.TabStop = False
        Me.userControl.Text = "User Control"
        '
        'activeStatus
        '
        Me.activeStatus.AutoSize = True
        Me.activeStatus.Location = New System.Drawing.Point(178, 111)
        Me.activeStatus.Name = "activeStatus"
        Me.activeStatus.Size = New System.Drawing.Size(56, 17)
        Me.activeStatus.TabIndex = 13
        Me.activeStatus.Text = "Status"
        Me.activeStatus.UseVisualStyleBackColor = True
        '
        'saveChanges
        '
        Me.saveChanges.FlatAppearance.BorderSize = 0
        Me.saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveChanges.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveChanges.ForeColor = System.Drawing.Color.White
        Me.saveChanges.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.saveChanges.IconColor = System.Drawing.Color.White
        Me.saveChanges.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.saveChanges.IconSize = 23
        Me.saveChanges.Location = New System.Drawing.Point(249, 292)
        Me.saveChanges.Name = "saveChanges"
        Me.saveChanges.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.saveChanges.Size = New System.Drawing.Size(76, 28)
        Me.saveChanges.TabIndex = 11
        Me.saveChanges.Text = "Save"
        Me.saveChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.saveChanges.UseVisualStyleBackColor = True
        '
        'addUser
        '
        Me.addUser.FlatAppearance.BorderSize = 0
        Me.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser.ForeColor = System.Drawing.Color.White
        Me.addUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus
        Me.addUser.IconColor = System.Drawing.Color.White
        Me.addUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.addUser.IconSize = 23
        Me.addUser.Location = New System.Drawing.Point(192, 233)
        Me.addUser.Name = "addUser"
        Me.addUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.addUser.Size = New System.Drawing.Size(86, 32)
        Me.addUser.TabIndex = 6
        Me.addUser.Text = "Add User"
        Me.addUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.addUser.UseVisualStyleBackColor = True
        '
        'checkUsername
        '
        Me.checkUsername.FlatAppearance.BorderSize = 0
        Me.checkUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkUsername.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkUsername.ForeColor = System.Drawing.Color.White
        Me.checkUsername.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.checkUsername.IconColor = System.Drawing.Color.White
        Me.checkUsername.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.checkUsername.IconSize = 23
        Me.checkUsername.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkUsername.Location = New System.Drawing.Point(63, 233)
        Me.checkUsername.Name = "checkUsername"
        Me.checkUsername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.checkUsername.Size = New System.Drawing.Size(86, 32)
        Me.checkUsername.TabIndex = 10
        Me.checkUsername.Text = "     Check"
        Me.checkUsername.UseVisualStyleBackColor = True
        '
        'userMatches
        '
        Me.userMatches.AllowUserToAddRows = False
        Me.userMatches.AllowUserToDeleteRows = False
        Me.userMatches.AllowUserToOrderColumns = True
        Me.userMatches.AllowUserToResizeColumns = False
        Me.userMatches.AllowUserToResizeRows = False
        Me.userMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.userMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.userMatches.DefaultCellStyle = DataGridViewCellStyle1
        Me.userMatches.GridColor = System.Drawing.Color.White
        Me.userMatches.Location = New System.Drawing.Point(23, 143)
        Me.userMatches.MultiSelect = False
        Me.userMatches.Name = "userMatches"
        Me.userMatches.ReadOnly = True
        Me.userMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userMatches.Size = New System.Drawing.Size(290, 84)
        Me.userMatches.TabIndex = 9
        '
        'response
        '
        Me.response.AutoSize = True
        Me.response.Location = New System.Drawing.Point(152, 51)
        Me.response.Name = "response"
        Me.response.Size = New System.Drawing.Size(0, 13)
        Me.response.TabIndex = 8
        Me.response.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Retype Password"
        '
        'passwordField2
        '
        Me.passwordField2.Location = New System.Drawing.Point(155, 85)
        Me.passwordField2.Name = "passwordField2"
        Me.passwordField2.Size = New System.Drawing.Size(100, 20)
        Me.passwordField2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password"
        '
        'passwordFIeld
        '
        Me.passwordFIeld.Location = New System.Drawing.Point(155, 59)
        Me.passwordFIeld.Name = "passwordFIeld"
        Me.passwordFIeld.Size = New System.Drawing.Size(100, 20)
        Me.passwordFIeld.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'userField
        '
        Me.userField.Location = New System.Drawing.Point(155, 33)
        Me.userField.Name = "userField"
        Me.userField.Size = New System.Drawing.Size(100, 20)
        Me.userField.TabIndex = 0
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 483)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.PanelDesktop.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.userControl.ResumeLayout(False)
        Me.userControl.PerformLayout()
        CType(Me.userMatches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents userControl As GroupBox
    Friend WithEvents addUser As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordField2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents passwordFIeld As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents userField As TextBox
    Friend WithEvents response As Label
    Friend WithEvents userMatches As DataGridView
    Friend WithEvents checkUsername As FontAwesome.Sharp.IconButton
    Friend WithEvents saveChanges As FontAwesome.Sharp.IconButton
    Friend WithEvents activeStatus As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
