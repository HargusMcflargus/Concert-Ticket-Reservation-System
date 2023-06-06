<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.chenji = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.taym = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.kakashi = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tototal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ebentnem = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.det = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nem = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Controls.Add(Me.IconButton1)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.chenji)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.taym)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.kakashi)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tototal)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ebentnem)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.det)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.nem)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 395)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Information"
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.Color.Black
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Location = New System.Drawing.Point(8, 189)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(250, 80)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 18
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 23
        Me.IconButton1.Location = New System.Drawing.Point(142, 345)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(109, 33)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.Text = "Confirm"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Change"
        '
        'chenji
        '
        Me.chenji.BackColor = System.Drawing.Color.White
        Me.chenji.ForeColor = System.Drawing.Color.Black
        Me.chenji.Location = New System.Drawing.Point(9, 352)
        Me.chenji.Name = "chenji"
        Me.chenji.ReadOnly = True
        Me.chenji.Size = New System.Drawing.Size(121, 24)
        Me.chenji.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(143, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 19)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Time"
        '
        'taym
        '
        Me.taym.BackColor = System.Drawing.Color.White
        Me.taym.ForeColor = System.Drawing.Color.Black
        Me.taym.Location = New System.Drawing.Point(136, 140)
        Me.taym.Name = "taym"
        Me.taym.ReadOnly = True
        Me.taym.Size = New System.Drawing.Size(122, 24)
        Me.taym.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(143, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 19)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cash"
        '
        'kakashi
        '
        Me.kakashi.BackColor = System.Drawing.Color.White
        Me.kakashi.ForeColor = System.Drawing.Color.Black
        Me.kakashi.Location = New System.Drawing.Point(136, 303)
        Me.kakashi.Name = "kakashi"
        Me.kakashi.ReadOnly = True
        Me.kakashi.Size = New System.Drawing.Size(122, 24)
        Me.kakashi.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 19)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Total"
        '
        'tototal
        '
        Me.tototal.BackColor = System.Drawing.Color.White
        Me.tototal.ForeColor = System.Drawing.Color.Black
        Me.tototal.Location = New System.Drawing.Point(8, 303)
        Me.tototal.Name = "tototal"
        Me.tototal.ReadOnly = True
        Me.tototal.Size = New System.Drawing.Size(122, 24)
        Me.tototal.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 19)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Seats"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Event"
        '
        'ebentnem
        '
        Me.ebentnem.BackColor = System.Drawing.Color.White
        Me.ebentnem.ForeColor = System.Drawing.Color.Black
        Me.ebentnem.Location = New System.Drawing.Point(8, 91)
        Me.ebentnem.Name = "ebentnem"
        Me.ebentnem.ReadOnly = True
        Me.ebentnem.Size = New System.Drawing.Size(250, 24)
        Me.ebentnem.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Date"
        '
        'det
        '
        Me.det.BackColor = System.Drawing.Color.White
        Me.det.ForeColor = System.Drawing.Color.Black
        Me.det.Location = New System.Drawing.Point(8, 140)
        Me.det.Name = "det"
        Me.det.ReadOnly = True
        Me.det.Size = New System.Drawing.Size(122, 24)
        Me.det.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Name"
        '
        'nem
        '
        Me.nem.BackColor = System.Drawing.Color.White
        Me.nem.ForeColor = System.Drawing.Color.Black
        Me.nem.Location = New System.Drawing.Point(8, 43)
        Me.nem.Name = "nem"
        Me.nem.ReadOnly = True
        Me.nem.Size = New System.Drawing.Size(250, 24)
        Me.nem.TabIndex = 0
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(293, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GroupBox3 As GroupBox
    Public WithEvents ListBox1 As ListBox
    Public WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Public WithEvents Label10 As Label
    Public WithEvents chenji As TextBox
    Public WithEvents Label14 As Label
    Public WithEvents taym As TextBox
    Public WithEvents Label13 As Label
    Public WithEvents kakashi As TextBox
    Public WithEvents Label12 As Label
    Public WithEvents tototal As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents Label9 As Label
    Public WithEvents ebentnem As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents det As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents nem As TextBox
End Class
