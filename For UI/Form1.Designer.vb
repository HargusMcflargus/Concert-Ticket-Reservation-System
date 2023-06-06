<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.SignOut = New FontAwesome.Sharp.IconButton()
        Me.Settings = New FontAwesome.Sharp.IconButton()
        Me.UpcomingConcert = New FontAwesome.Sharp.IconButton()
        Me.PastTransaction = New FontAwesome.Sharp.IconButton()
        Me.Seats = New FontAwesome.Sharp.IconButton()
        Me.Dashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.btnMinimized = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblClock2 = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.userField = New System.Windows.Forms.ComboBox()
        Me.btnUser = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.passwordFIeld = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.SignOut)
        Me.PanelMenu.Controls.Add(Me.Settings)
        Me.PanelMenu.Controls.Add(Me.UpcomingConcert)
        Me.PanelMenu.Controls.Add(Me.PastTransaction)
        Me.PanelMenu.Controls.Add(Me.Seats)
        Me.PanelMenu.Controls.Add(Me.Dashboard)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 561)
        Me.PanelMenu.TabIndex = 0
        '
        'SignOut
        '
        Me.SignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SignOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.SignOut.FlatAppearance.BorderSize = 0
        Me.SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOut.ForeColor = System.Drawing.Color.White
        Me.SignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.SignOut.IconColor = System.Drawing.Color.White
        Me.SignOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SignOut.IconSize = 32
        Me.SignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignOut.Location = New System.Drawing.Point(0, 475)
        Me.SignOut.Name = "SignOut"
        Me.SignOut.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.SignOut.Size = New System.Drawing.Size(220, 71)
        Me.SignOut.TabIndex = 6
        Me.SignOut.Text = "Sign Out"
        Me.SignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SignOut.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.Settings.AutoSize = True
        Me.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Settings.Dock = System.Windows.Forms.DockStyle.Top
        Me.Settings.FlatAppearance.BorderSize = 0
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Settings.ForeColor = System.Drawing.Color.White
        Me.Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.Settings.IconColor = System.Drawing.Color.White
        Me.Settings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Settings.IconSize = 32
        Me.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings.Location = New System.Drawing.Point(0, 404)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.Settings.Size = New System.Drawing.Size(220, 71)
        Me.Settings.TabIndex = 5
        Me.Settings.Text = "Settings"
        Me.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Settings.UseVisualStyleBackColor = True
        '
        'UpcomingConcert
        '
        Me.UpcomingConcert.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpcomingConcert.FlatAppearance.BorderSize = 0
        Me.UpcomingConcert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpcomingConcert.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpcomingConcert.ForeColor = System.Drawing.Color.White
        Me.UpcomingConcert.IconChar = FontAwesome.Sharp.IconChar.Archive
        Me.UpcomingConcert.IconColor = System.Drawing.Color.White
        Me.UpcomingConcert.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.UpcomingConcert.IconSize = 32
        Me.UpcomingConcert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpcomingConcert.Location = New System.Drawing.Point(0, 333)
        Me.UpcomingConcert.Name = "UpcomingConcert"
        Me.UpcomingConcert.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.UpcomingConcert.Size = New System.Drawing.Size(220, 71)
        Me.UpcomingConcert.TabIndex = 4
        Me.UpcomingConcert.Text = "Upcoming Concerts"
        Me.UpcomingConcert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpcomingConcert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpcomingConcert.UseVisualStyleBackColor = True
        '
        'PastTransaction
        '
        Me.PastTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.PastTransaction.FlatAppearance.BorderSize = 0
        Me.PastTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PastTransaction.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PastTransaction.ForeColor = System.Drawing.Color.White
        Me.PastTransaction.IconChar = FontAwesome.Sharp.IconChar.ClipboardList
        Me.PastTransaction.IconColor = System.Drawing.Color.White
        Me.PastTransaction.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PastTransaction.IconSize = 32
        Me.PastTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PastTransaction.Location = New System.Drawing.Point(0, 262)
        Me.PastTransaction.Name = "PastTransaction"
        Me.PastTransaction.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.PastTransaction.Size = New System.Drawing.Size(220, 71)
        Me.PastTransaction.TabIndex = 3
        Me.PastTransaction.Text = "Transactions"
        Me.PastTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PastTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PastTransaction.UseVisualStyleBackColor = True
        '
        'Seats
        '
        Me.Seats.Dock = System.Windows.Forms.DockStyle.Top
        Me.Seats.FlatAppearance.BorderSize = 0
        Me.Seats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Seats.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seats.ForeColor = System.Drawing.Color.White
        Me.Seats.IconChar = FontAwesome.Sharp.IconChar.Couch
        Me.Seats.IconColor = System.Drawing.Color.White
        Me.Seats.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Seats.IconSize = 32
        Me.Seats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Seats.Location = New System.Drawing.Point(0, 191)
        Me.Seats.Name = "Seats"
        Me.Seats.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.Seats.Size = New System.Drawing.Size(220, 71)
        Me.Seats.TabIndex = 2
        Me.Seats.Text = "Seats"
        Me.Seats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Seats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Seats.UseVisualStyleBackColor = True
        '
        'Dashboard
        '
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard.FlatAppearance.BorderSize = 0
        Me.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Dashboard.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.White
        Me.Dashboard.IconChar = FontAwesome.Sharp.IconChar.Flipboard
        Me.Dashboard.IconColor = System.Drawing.Color.White
        Me.Dashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Dashboard.IconSize = 32
        Me.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard.Location = New System.Drawing.Point(0, 120)
        Me.Dashboard.Margin = New System.Windows.Forms.Padding(10)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Padding = New System.Windows.Forms.Padding(20, 0, 40, 0)
        Me.Dashboard.Size = New System.Drawing.Size(220, 71)
        Me.Dashboard.TabIndex = 1
        Me.Dashboard.Text = "Dashboard"
        Me.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Dashboard.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureLogo)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 120)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = Global.For_UI.My.Resources.Resources.twice_4_lyp
        Me.PictureLogo.Location = New System.Drawing.Point(12, 12)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(195, 95)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 0
        Me.PictureLogo.TabStop = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.btnMinimized)
        Me.TitleBar.Controls.Add(Me.btnMaximize)
        Me.TitleBar.Controls.Add(Me.btnExit)
        Me.TitleBar.Controls.Add(Me.lblFormTitle)
        Me.TitleBar.Controls.Add(Me.IconCurrentForm)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(220, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(764, 80)
        Me.TitleBar.TabIndex = 1
        '
        'btnMinimized
        '
        Me.btnMinimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimized.FlatAppearance.BorderSize = 0
        Me.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimized.ForeColor = System.Drawing.Color.White
        Me.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimized.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimized.IconSize = 15
        Me.btnMinimized.Location = New System.Drawing.Point(674, 0)
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(26, 23)
        Me.btnMinimized.TabIndex = 4
        Me.btnMinimized.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 15
        Me.btnMaximize.Location = New System.Drawing.Point(706, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(26, 23)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 15
        Me.btnExit.Location = New System.Drawing.Point(738, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(26, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(56, 33)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(56, 20)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Sign In"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.SignInAlt
        Me.IconCurrentForm.IconColor = System.Drawing.Color.MediumPurple
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(19, 29)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(16, 45)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(126, 18)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "October 31 2020"
        '
        'lblClock2
        '
        Me.lblClock2.AutoSize = True
        Me.lblClock2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock2.ForeColor = System.Drawing.Color.White
        Me.lblClock2.Location = New System.Drawing.Point(16, 22)
        Me.lblClock2.Name = "lblClock2"
        Me.lblClock2.Size = New System.Drawing.Size(73, 18)
        Me.lblClock2.TabIndex = 9
        Me.lblClock2.Text = "12:00 AM"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.lblDay)
        Me.PanelDesktop.Controls.Add(Me.userField)
        Me.PanelDesktop.Controls.Add(Me.btnUser)
        Me.PanelDesktop.Controls.Add(Me.lblDate)
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.lblClock2)
        Me.PanelDesktop.Controls.Add(Me.LabelUser)
        Me.PanelDesktop.Controls.Add(Me.passwordFIeld)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(220, 80)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(764, 481)
        Me.PanelDesktop.TabIndex = 2
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.Color.White
        Me.lblDay.Location = New System.Drawing.Point(16, 68)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(49, 16)
        Me.lblDay.TabIndex = 11
        Me.lblDay.Text = "Friday"
        '
        'userField
        '
        Me.userField.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.userField.FormattingEnabled = True
        Me.userField.Location = New System.Drawing.Point(284, 171)
        Me.userField.Name = "userField"
        Me.userField.Size = New System.Drawing.Size(201, 21)
        Me.userField.TabIndex = 0
        '
        'btnUser
        '
        Me.btnUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnUser.IconColor = System.Drawing.Color.White
        Me.btnUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUser.IconSize = 20
        Me.btnUser.Location = New System.Drawing.Point(349, 265)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(76, 27)
        Me.btnUser.TabIndex = 2
        Me.btnUser.Text = "Login"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(280, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'LabelUser
        '
        Me.LabelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LabelUser.AutoSize = True
        Me.LabelUser.Font = New System.Drawing.Font("Century Gothic", 10.25!)
        Me.LabelUser.ForeColor = System.Drawing.Color.White
        Me.LabelUser.Location = New System.Drawing.Point(280, 149)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(77, 19)
        Me.LabelUser.TabIndex = 4
        Me.LabelUser.Text = "Username"
        '
        'passwordFIeld
        '
        Me.passwordFIeld.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.passwordFIeld.Location = New System.Drawing.Point(284, 229)
        Me.passwordFIeld.Name = "passwordFIeld"
        Me.passwordFIeld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.passwordFIeld.Size = New System.Drawing.Size(201, 20)
        Me.passwordFIeld.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tmrTimer
        '
        Me.tmrTimer.Enabled = True
        Me.tmrTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.MinimumSize = New System.Drawing.Size(980, 594)
        Me.Name = "Form1"
        Me.Text = "Concert and Events Ticketing System"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleBar.ResumeLayout(False)
        Me.TitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents SignOut As FontAwesome.Sharp.IconButton
    Friend WithEvents Settings As FontAwesome.Sharp.IconButton
    Friend WithEvents UpcomingConcert As FontAwesome.Sharp.IconButton
    Friend WithEvents Seats As FontAwesome.Sharp.IconButton
    Friend WithEvents Dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PastTransaction As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents btnMinimized As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents passwordFIeld As TextBox
    Friend WithEvents userField As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblClock2 As Label
    Friend WithEvents tmrTimer As Timer
    Friend WithEvents lblDay As Label
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
End Class
