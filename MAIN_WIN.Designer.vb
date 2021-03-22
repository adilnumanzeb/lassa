<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAINWIN_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MAINWIN_FRM))
        Me.ERROR_LBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ONLINE_STATUS_LBL = New System.Windows.Forms.Label()
        Me.DB_ERR_PANNEL = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TIME_LBL = New System.Windows.Forms.Label()
        Me.DATE_LBL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.LOG_TXT = New System.Windows.Forms.TextBox()
        Me.LOG_PANNEL = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOADBAR_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CONTACTS_BTN = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SALES_BTN = New System.Windows.Forms.Button()
        Me.TIME_DATE = New System.Windows.Forms.Timer(Me.components)
        Me.LOGO_PIC_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.JAZZCASH_BTN = New System.Windows.Forms.Button()
        Me.EASYPAISA_BTN = New System.Windows.Forms.Button()
        Me.MOBILE_LOAD_BTN = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.DB_ERR_PANNEL.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LOG_PANNEL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGO_PIC_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ERROR_LBL
        '
        Me.ERROR_LBL.AutoSize = True
        Me.ERROR_LBL.BackColor = System.Drawing.Color.Maroon
        Me.ERROR_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERROR_LBL.ForeColor = System.Drawing.Color.White
        Me.ERROR_LBL.Location = New System.Drawing.Point(117, 629)
        Me.ERROR_LBL.Name = "ERROR_LBL"
        Me.ERROR_LBL.Size = New System.Drawing.Size(39, 20)
        Me.ERROR_LBL.TabIndex = 91
        Me.ERROR_LBL.Text = "Idle"
        Me.ERROR_LBL.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(643, 635)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 22)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "VERSION 2.0.1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(86, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "ADIL NUMAN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(87, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Admin"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaShell
        Me.Panel4.Controls.Add(Me.ONLINE_STATUS_LBL)
        Me.Panel4.Controls.Add(Me.DB_ERR_PANNEL)
        Me.Panel4.Controls.Add(Me.TIME_LBL)
        Me.Panel4.Controls.Add(Me.DATE_LBL)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 109)
        Me.Panel4.TabIndex = 84
        '
        'ONLINE_STATUS_LBL
        '
        Me.ONLINE_STATUS_LBL.AutoSize = True
        Me.ONLINE_STATUS_LBL.BackColor = System.Drawing.Color.Maroon
        Me.ONLINE_STATUS_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ONLINE_STATUS_LBL.ForeColor = System.Drawing.Color.White
        Me.ONLINE_STATUS_LBL.Location = New System.Drawing.Point(320, 80)
        Me.ONLINE_STATUS_LBL.Name = "ONLINE_STATUS_LBL"
        Me.ONLINE_STATUS_LBL.Size = New System.Drawing.Size(223, 31)
        Me.ONLINE_STATUS_LBL.TabIndex = 100
        Me.ONLINE_STATUS_LBL.Text = "BETA TESTING"
        '
        'DB_ERR_PANNEL
        '
        Me.DB_ERR_PANNEL.BackColor = System.Drawing.Color.Red
        Me.DB_ERR_PANNEL.Controls.Add(Me.PictureBox3)
        Me.DB_ERR_PANNEL.Controls.Add(Me.Label2)
        Me.DB_ERR_PANNEL.Location = New System.Drawing.Point(843, 47)
        Me.DB_ERR_PANNEL.Name = "DB_ERR_PANNEL"
        Me.DB_ERR_PANNEL.Size = New System.Drawing.Size(439, 62)
        Me.DB_ERR_PANNEL.TabIndex = 96
        Me.DB_ERR_PANNEL.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Easypaisa.My.Resources.Resources.warning
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(58, 57)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 97
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 22)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "DATABASE SERVER DISCONNECTED"
        '
        'TIME_LBL
        '
        Me.TIME_LBL.AutoSize = True
        Me.TIME_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIME_LBL.ForeColor = System.Drawing.Color.Black
        Me.TIME_LBL.Location = New System.Drawing.Point(346, 60)
        Me.TIME_LBL.Name = "TIME_LBL"
        Me.TIME_LBL.Size = New System.Drawing.Size(109, 20)
        Me.TIME_LBL.TabIndex = 78
        Me.TIME_LBL.Text = "11:00:00 PM"
        '
        'DATE_LBL
        '
        Me.DATE_LBL.AutoSize = True
        Me.DATE_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_LBL.ForeColor = System.Drawing.Color.Black
        Me.DATE_LBL.Location = New System.Drawing.Point(320, 29)
        Me.DATE_LBL.Name = "DATE_LBL"
        Me.DATE_LBL.Size = New System.Drawing.Size(159, 31)
        Me.DATE_LBL.TabIndex = 77
        Me.DATE_LBL.Text = "08-OCT-20"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(335, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 16)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "CURRENT DATE "
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel8.Controls.Add(Me.PictureBox7)
        Me.Panel8.Location = New System.Drawing.Point(679, -11)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(121, 122)
        Me.Panel8.TabIndex = 6
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(25, 28)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(75, 73)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 77
        Me.PictureBox7.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'PB1
        '
        Me.PB1.Location = New System.Drawing.Point(3, 498)
        Me.PB1.Maximum = 50
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(773, 18)
        Me.PB1.TabIndex = 93
        '
        'LOG_TXT
        '
        Me.LOG_TXT.BackColor = System.Drawing.Color.Black
        Me.LOG_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOG_TXT.ForeColor = System.Drawing.Color.GreenYellow
        Me.LOG_TXT.HideSelection = False
        Me.LOG_TXT.Location = New System.Drawing.Point(3, 96)
        Me.LOG_TXT.Multiline = True
        Me.LOG_TXT.Name = "LOG_TXT"
        Me.LOG_TXT.ReadOnly = True
        Me.LOG_TXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LOG_TXT.Size = New System.Drawing.Size(794, 370)
        Me.LOG_TXT.TabIndex = 92
        Me.LOG_TXT.Text = "LOADING...."
        '
        'LOG_PANNEL
        '
        Me.LOG_PANNEL.Controls.Add(Me.Label1)
        Me.LOG_PANNEL.Controls.Add(Me.PB1)
        Me.LOG_PANNEL.Controls.Add(Me.LOG_TXT)
        Me.LOG_PANNEL.Location = New System.Drawing.Point(843, 157)
        Me.LOG_PANNEL.Name = "LOG_PANNEL"
        Me.LOG_PANNEL.Size = New System.Drawing.Size(806, 661)
        Me.LOG_PANNEL.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(327, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "LOADING...."
        '
        'LOADBAR_TIMER
        '
        Me.LOADBAR_TIMER.Enabled = True
        Me.LOADBAR_TIMER.Interval = 3000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.CONTACTS_BTN)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.SALES_BTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(109, 557)
        Me.Panel1.TabIndex = 96
        '
        'CONTACTS_BTN
        '
        Me.CONTACTS_BTN.BackColor = System.Drawing.Color.Transparent
        Me.CONTACTS_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CONTACTS_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CONTACTS_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTACTS_BTN.ForeColor = System.Drawing.Color.Black
        Me.CONTACTS_BTN.Image = Global.Easypaisa.My.Resources.Resources.Contacts_513
        Me.CONTACTS_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CONTACTS_BTN.Location = New System.Drawing.Point(11, 37)
        Me.CONTACTS_BTN.Name = "CONTACTS_BTN"
        Me.CONTACTS_BTN.Size = New System.Drawing.Size(82, 72)
        Me.CONTACTS_BTN.TabIndex = 96
        Me.CONTACTS_BTN.Text = "CONTACTS"
        Me.CONTACTS_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CONTACTS_BTN.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 90
        Me.PictureBox1.TabStop = False
        '
        'SALES_BTN
        '
        Me.SALES_BTN.BackColor = System.Drawing.Color.Transparent
        Me.SALES_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SALES_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SALES_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALES_BTN.ForeColor = System.Drawing.Color.Black
        Me.SALES_BTN.Image = Global.Easypaisa.My.Resources.Resources._2
        Me.SALES_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SALES_BTN.Location = New System.Drawing.Point(11, 135)
        Me.SALES_BTN.Name = "SALES_BTN"
        Me.SALES_BTN.Size = New System.Drawing.Size(82, 72)
        Me.SALES_BTN.TabIndex = 95
        Me.SALES_BTN.Text = "SALES"
        Me.SALES_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SALES_BTN.UseVisualStyleBackColor = False
        '
        'TIME_DATE
        '
        Me.TIME_DATE.Enabled = True
        '
        'LOGO_PIC_2
        '
        Me.LOGO_PIC_2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LOGO_PIC_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LOGO_PIC_2.Image = CType(resources.GetObject("LOGO_PIC_2.Image"), System.Drawing.Image)
        Me.LOGO_PIC_2.Location = New System.Drawing.Point(640, 573)
        Me.LOGO_PIC_2.Name = "LOGO_PIC_2"
        Me.LOGO_PIC_2.Size = New System.Drawing.Size(155, 58)
        Me.LOGO_PIC_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LOGO_PIC_2.TabIndex = 89
        Me.LOGO_PIC_2.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 33)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'JAZZCASH_BTN
        '
        Me.JAZZCASH_BTN.BackColor = System.Drawing.Color.White
        Me.JAZZCASH_BTN.BackgroundImage = Global.Easypaisa.My.Resources.Resources.Jazz_cash
        Me.JAZZCASH_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.JAZZCASH_BTN.Location = New System.Drawing.Point(251, 126)
        Me.JAZZCASH_BTN.Name = "JAZZCASH_BTN"
        Me.JAZZCASH_BTN.Size = New System.Drawing.Size(168, 110)
        Me.JAZZCASH_BTN.TabIndex = 1
        Me.JAZZCASH_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.JAZZCASH_BTN.UseVisualStyleBackColor = False
        '
        'EASYPAISA_BTN
        '
        Me.EASYPAISA_BTN.BackColor = System.Drawing.Color.White
        Me.EASYPAISA_BTN.BackgroundImage = Global.Easypaisa.My.Resources.Resources.Easy_paisa__2_
        Me.EASYPAISA_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EASYPAISA_BTN.Location = New System.Drawing.Point(128, 126)
        Me.EASYPAISA_BTN.Name = "EASYPAISA_BTN"
        Me.EASYPAISA_BTN.Size = New System.Drawing.Size(103, 110)
        Me.EASYPAISA_BTN.TabIndex = 0
        Me.EASYPAISA_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EASYPAISA_BTN.UseVisualStyleBackColor = False
        '
        'MOBILE_LOAD_BTN
        '
        Me.MOBILE_LOAD_BTN.BackColor = System.Drawing.Color.White
        Me.MOBILE_LOAD_BTN.BackgroundImage = Global.Easypaisa.My.Resources.Resources.Mobile_Load_Inner_header
        Me.MOBILE_LOAD_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MOBILE_LOAD_BTN.Location = New System.Drawing.Point(439, 126)
        Me.MOBILE_LOAD_BTN.Name = "MOBILE_LOAD_BTN"
        Me.MOBILE_LOAD_BTN.Size = New System.Drawing.Size(121, 110)
        Me.MOBILE_LOAD_BTN.TabIndex = 99
        Me.MOBILE_LOAD_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MOBILE_LOAD_BTN.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(111, 109)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(692, 557)
        Me.PictureBox4.TabIndex = 98
        Me.PictureBox4.TabStop = False
        '
        'MAINWIN_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 666)
        Me.Controls.Add(Me.LOGO_PIC_2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LOG_PANNEL)
        Me.Controls.Add(Me.ERROR_LBL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.JAZZCASH_BTN)
        Me.Controls.Add(Me.EASYPAISA_BTN)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MOBILE_LOAD_BTN)
        Me.Controls.Add(Me.PictureBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(816, 705)
        Me.Name = "MAINWIN_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAIN_WIN"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.DB_ERR_PANNEL.ResumeLayout(False)
        Me.DB_ERR_PANNEL.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LOG_PANNEL.ResumeLayout(False)
        Me.LOG_PANNEL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGO_PIC_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EASYPAISA_BTN As Button
    Friend WithEvents JAZZCASH_BTN As Button
    Friend WithEvents ERROR_LBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LOGO_PIC_2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TIME_LBL As Label
    Friend WithEvents DATE_LBL As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PB1 As ProgressBar
    Friend WithEvents LOG_TXT As TextBox
    Friend WithEvents LOG_PANNEL As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LOADBAR_TIMER As Timer
    Friend WithEvents SALES_BTN As Button
    Friend WithEvents DB_ERR_PANNEL As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MOBILE_LOAD_BTN As Button
    Friend WithEvents TIME_DATE As Timer
    Friend WithEvents CONTACTS_BTN As Button
    Friend WithEvents ONLINE_STATUS_LBL As Label
End Class
