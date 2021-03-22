<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTACTS_FRM
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
        Me.components = New System.ComponentModel.Container()
        Me.CUSTOMER_NAME_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MOBILENO_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CUS_ID_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MOB_ERR_LBL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ADD_BTN = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LIST_Panel = New System.Windows.Forms.Panel()
        Me.LIST_NAME_LBL = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NAME_LIST = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BALANCE_LBL = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MOBILE_NO_LBL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NAME_LBL = New System.Windows.Forms.Label()
        Me.SEARCH_TXT = New System.Windows.Forms.TextBox()
        Me.SEARCH_TYPE_COMBO = New System.Windows.Forms.ComboBox()
        Me.SEARCH_BTN = New System.Windows.Forms.Button()
        Me.PAYMENT_BTN = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HISTORY_BTN = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CONTACT_LIST_SEARCH_TXT = New System.Windows.Forms.TextBox()
        Me.CONTACT_LIST_SEARCH_BTN = New System.Windows.Forms.Button()
        Me.DGV_CONTACT_LIST = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGV_CREDIT = New System.Windows.Forms.DataGridView()
        Me.ERR_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.CLOSE_BTN = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.LIST_Panel.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGV_CONTACT_LIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_CREDIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUSTOMER_NAME_TXT
        '
        Me.CUSTOMER_NAME_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMER_NAME_TXT.ForeColor = System.Drawing.Color.Red
        Me.CUSTOMER_NAME_TXT.Location = New System.Drawing.Point(117, 125)
        Me.CUSTOMER_NAME_TXT.Name = "CUSTOMER_NAME_TXT"
        Me.CUSTOMER_NAME_TXT.Size = New System.Drawing.Size(315, 29)
        Me.CUSTOMER_NAME_TXT.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "NAME:"
        '
        'MOBILENO_TXT
        '
        Me.MOBILENO_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MOBILENO_TXT.ForeColor = System.Drawing.Color.Red
        Me.MOBILENO_TXT.Location = New System.Drawing.Point(184, 195)
        Me.MOBILENO_TXT.Name = "MOBILENO_TXT"
        Me.MOBILENO_TXT.Size = New System.Drawing.Size(248, 29)
        Me.MOBILENO_TXT.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "MOBILE NO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Customer ID:"
        '
        'CUS_ID_TXT
        '
        Me.CUS_ID_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CUS_ID_TXT.ForeColor = System.Drawing.Color.Red
        Me.CUS_ID_TXT.Location = New System.Drawing.Point(184, 59)
        Me.CUS_ID_TXT.Name = "CUS_ID_TXT"
        Me.CUS_ID_TXT.Size = New System.Drawing.Size(248, 29)
        Me.CUS_ID_TXT.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(360, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Customer Info"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MOB_ERR_LBL)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.ADD_BTN)
        Me.Panel3.Controls.Add(Me.CUS_ID_TXT)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CUSTOMER_NAME_TXT)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.MOBILENO_TXT)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(9, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 357)
        Me.Panel3.TabIndex = 16
        '
        'MOB_ERR_LBL
        '
        Me.MOB_ERR_LBL.AutoSize = True
        Me.MOB_ERR_LBL.BackColor = System.Drawing.Color.DarkRed
        Me.MOB_ERR_LBL.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOB_ERR_LBL.ForeColor = System.Drawing.Color.Yellow
        Me.MOB_ERR_LBL.Location = New System.Drawing.Point(191, 176)
        Me.MOB_ERR_LBL.Name = "MOB_ERR_LBL"
        Me.MOB_ERR_LBL.Size = New System.Drawing.Size(64, 17)
        Me.MOB_ERR_LBL.TabIndex = 17
        Me.MOB_ERR_LBL.Text = "ERR LBL"
        Me.MOB_ERR_LBL.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(131, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "New Registration"
        '
        'ADD_BTN
        '
        Me.ADD_BTN.Location = New System.Drawing.Point(357, 247)
        Me.ADD_BTN.Name = "ADD_BTN"
        Me.ADD_BTN.Size = New System.Drawing.Size(75, 23)
        Me.ADD_BTN.TabIndex = 3
        Me.ADD_BTN.Text = "&Add"
        Me.ADD_BTN.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(517, 61)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(461, 357)
        Me.Panel2.TabIndex = 17
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(454, 348)
        Me.TabControl1.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LIST_Panel)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.BALANCE_LBL)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.MOBILE_NO_LBL)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.NAME_LBL)
        Me.TabPage1.Controls.Add(Me.SEARCH_TXT)
        Me.TabPage1.Controls.Add(Me.SEARCH_TYPE_COMBO)
        Me.TabPage1.Controls.Add(Me.SEARCH_BTN)
        Me.TabPage1.Controls.Add(Me.PAYMENT_BTN)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.HISTORY_BTN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(446, 319)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "    Find Contact    "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LIST_Panel
        '
        Me.LIST_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LIST_Panel.Controls.Add(Me.LIST_NAME_LBL)
        Me.LIST_Panel.Controls.Add(Me.Button2)
        Me.LIST_Panel.Controls.Add(Me.NAME_LIST)
        Me.LIST_Panel.Enabled = False
        Me.LIST_Panel.Location = New System.Drawing.Point(166, 116)
        Me.LIST_Panel.Name = "LIST_Panel"
        Me.LIST_Panel.Size = New System.Drawing.Size(269, 167)
        Me.LIST_Panel.TabIndex = 29
        Me.LIST_Panel.Visible = False
        '
        'LIST_NAME_LBL
        '
        Me.LIST_NAME_LBL.AutoSize = True
        Me.LIST_NAME_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIST_NAME_LBL.ForeColor = System.Drawing.Color.Black
        Me.LIST_NAME_LBL.Location = New System.Drawing.Point(3, 6)
        Me.LIST_NAME_LBL.Name = "LIST_NAME_LBL"
        Me.LIST_NAME_LBL.Size = New System.Drawing.Size(60, 20)
        Me.LIST_NAME_LBL.TabIndex = 18
        Me.LIST_NAME_LBL.Text = "Select"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(238, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 24)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NAME_LIST
        '
        Me.NAME_LIST.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NAME_LIST.FormattingEnabled = True
        Me.NAME_LIST.ItemHeight = 16
        Me.NAME_LIST.Location = New System.Drawing.Point(0, 33)
        Me.NAME_LIST.Name = "NAME_LIST"
        Me.NAME_LIST.Size = New System.Drawing.Size(267, 132)
        Me.NAME_LIST.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(151, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 29)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Find Contact"
        '
        'BALANCE_LBL
        '
        Me.BALANCE_LBL.AutoSize = True
        Me.BALANCE_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BALANCE_LBL.ForeColor = System.Drawing.Color.Black
        Me.BALANCE_LBL.Location = New System.Drawing.Point(163, 244)
        Me.BALANCE_LBL.Name = "BALANCE_LBL"
        Me.BALANCE_LBL.Size = New System.Drawing.Size(93, 29)
        Me.BALANCE_LBL.TabIndex = 27
        Me.BALANCE_LBL.Text = "NAME:"
        Me.BALANCE_LBL.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 29)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "MOBILE NO:"
        '
        'MOBILE_NO_LBL
        '
        Me.MOBILE_NO_LBL.AutoSize = True
        Me.MOBILE_NO_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOBILE_NO_LBL.ForeColor = System.Drawing.Color.Black
        Me.MOBILE_NO_LBL.Location = New System.Drawing.Point(163, 177)
        Me.MOBILE_NO_LBL.Name = "MOBILE_NO_LBL"
        Me.MOBILE_NO_LBL.Size = New System.Drawing.Size(93, 29)
        Me.MOBILE_NO_LBL.TabIndex = 26
        Me.MOBILE_NO_LBL.Text = "NAME:"
        Me.MOBILE_NO_LBL.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "NAME:"
        '
        'NAME_LBL
        '
        Me.NAME_LBL.AutoSize = True
        Me.NAME_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAME_LBL.ForeColor = System.Drawing.Color.Black
        Me.NAME_LBL.Location = New System.Drawing.Point(163, 121)
        Me.NAME_LBL.Name = "NAME_LBL"
        Me.NAME_LBL.Size = New System.Drawing.Size(93, 29)
        Me.NAME_LBL.TabIndex = 25
        Me.NAME_LBL.Text = "NAME:"
        Me.NAME_LBL.Visible = False
        '
        'SEARCH_TXT
        '
        Me.SEARCH_TXT.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_TXT.ForeColor = System.Drawing.Color.Red
        Me.SEARCH_TXT.Location = New System.Drawing.Point(187, 56)
        Me.SEARCH_TXT.Name = "SEARCH_TXT"
        Me.SEARCH_TXT.Size = New System.Drawing.Size(248, 25)
        Me.SEARCH_TXT.TabIndex = 14
        '
        'SEARCH_TYPE_COMBO
        '
        Me.SEARCH_TYPE_COMBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_TYPE_COMBO.FormattingEnabled = True
        Me.SEARCH_TYPE_COMBO.Items.AddRange(New Object() {"Customer ID", "Mobile No", "NAME"})
        Me.SEARCH_TYPE_COMBO.Location = New System.Drawing.Point(13, 57)
        Me.SEARCH_TYPE_COMBO.Name = "SEARCH_TYPE_COMBO"
        Me.SEARCH_TYPE_COMBO.Size = New System.Drawing.Size(168, 24)
        Me.SEARCH_TYPE_COMBO.TabIndex = 24
        Me.SEARCH_TYPE_COMBO.Text = "Mobile No"
        '
        'SEARCH_BTN
        '
        Me.SEARCH_BTN.Location = New System.Drawing.Point(360, 87)
        Me.SEARCH_BTN.Name = "SEARCH_BTN"
        Me.SEARCH_BTN.Size = New System.Drawing.Size(75, 23)
        Me.SEARCH_BTN.TabIndex = 15
        Me.SEARCH_BTN.Text = "&Search"
        Me.SEARCH_BTN.UseVisualStyleBackColor = True
        '
        'PAYMENT_BTN
        '
        Me.PAYMENT_BTN.Location = New System.Drawing.Point(279, 289)
        Me.PAYMENT_BTN.Name = "PAYMENT_BTN"
        Me.PAYMENT_BTN.Size = New System.Drawing.Size(75, 23)
        Me.PAYMENT_BTN.TabIndex = 23
        Me.PAYMENT_BTN.Text = "&Payment"
        Me.PAYMENT_BTN.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 29)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "BALANCE:"
        '
        'HISTORY_BTN
        '
        Me.HISTORY_BTN.Location = New System.Drawing.Point(360, 289)
        Me.HISTORY_BTN.Name = "HISTORY_BTN"
        Me.HISTORY_BTN.Size = New System.Drawing.Size(75, 23)
        Me.HISTORY_BTN.TabIndex = 22
        Me.HISTORY_BTN.Text = "&History"
        Me.HISTORY_BTN.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CONTACT_LIST_SEARCH_TXT)
        Me.TabPage3.Controls.Add(Me.CONTACT_LIST_SEARCH_BTN)
        Me.TabPage3.Controls.Add(Me.DGV_CONTACT_LIST)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(446, 319)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "    Contact List    "
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CONTACT_LIST_SEARCH_TXT
        '
        Me.CONTACT_LIST_SEARCH_TXT.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CONTACT_LIST_SEARCH_TXT.ForeColor = System.Drawing.Color.Red
        Me.CONTACT_LIST_SEARCH_TXT.Location = New System.Drawing.Point(6, 14)
        Me.CONTACT_LIST_SEARCH_TXT.Name = "CONTACT_LIST_SEARCH_TXT"
        Me.CONTACT_LIST_SEARCH_TXT.Size = New System.Drawing.Size(340, 25)
        Me.CONTACT_LIST_SEARCH_TXT.TabIndex = 16
        '
        'CONTACT_LIST_SEARCH_BTN
        '
        Me.CONTACT_LIST_SEARCH_BTN.Location = New System.Drawing.Point(352, 14)
        Me.CONTACT_LIST_SEARCH_BTN.Name = "CONTACT_LIST_SEARCH_BTN"
        Me.CONTACT_LIST_SEARCH_BTN.Size = New System.Drawing.Size(75, 25)
        Me.CONTACT_LIST_SEARCH_BTN.TabIndex = 17
        Me.CONTACT_LIST_SEARCH_BTN.Text = "&Search"
        Me.CONTACT_LIST_SEARCH_BTN.UseVisualStyleBackColor = True
        '
        'DGV_CONTACT_LIST
        '
        Me.DGV_CONTACT_LIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CONTACT_LIST.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_CONTACT_LIST.Location = New System.Drawing.Point(3, 47)
        Me.DGV_CONTACT_LIST.Name = "DGV_CONTACT_LIST"
        Me.DGV_CONTACT_LIST.ReadOnly = True
        Me.DGV_CONTACT_LIST.RowHeadersVisible = False
        Me.DGV_CONTACT_LIST.Size = New System.Drawing.Size(440, 269)
        Me.DGV_CONTACT_LIST.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV_CREDIT)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(446, 319)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "    HISTORY    "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGV_CREDIT
        '
        Me.DGV_CREDIT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CREDIT.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_CREDIT.Location = New System.Drawing.Point(3, 3)
        Me.DGV_CREDIT.Name = "DGV_CREDIT"
        Me.DGV_CREDIT.ReadOnly = True
        Me.DGV_CREDIT.RowHeadersVisible = False
        Me.DGV_CREDIT.Size = New System.Drawing.Size(440, 315)
        Me.DGV_CREDIT.TabIndex = 0
        '
        'ERR_TIMER
        '
        Me.ERR_TIMER.Interval = 3500
        '
        'CLOSE_BTN
        '
        Me.CLOSE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSE_BTN.Location = New System.Drawing.Point(875, 432)
        Me.CLOSE_BTN.Name = "CLOSE_BTN"
        Me.CLOSE_BTN.Size = New System.Drawing.Size(105, 58)
        Me.CLOSE_BTN.TabIndex = 24
        Me.CLOSE_BTN.Text = "&Close"
        Me.CLOSE_BTN.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CLOSE_BTN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(989, 518)
        Me.Panel1.TabIndex = 25
        '
        'CONTACTS_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(990, 575)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CONTACTS_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACTS"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.LIST_Panel.ResumeLayout(False)
        Me.LIST_Panel.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DGV_CONTACT_LIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV_CREDIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CUSTOMER_NAME_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MOBILENO_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CUS_ID_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ADD_BTN As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PAYMENT_BTN As Button
    Friend WithEvents HISTORY_BTN As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SEARCH_BTN As Button
    Friend WithEvents SEARCH_TXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MOB_ERR_LBL As Label
    Friend WithEvents ERR_TIMER As Timer
    Friend WithEvents CLOSE_BTN As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BALANCE_LBL As Label
    Friend WithEvents MOBILE_NO_LBL As Label
    Friend WithEvents NAME_LBL As Label
    Protected WithEvents SEARCH_TYPE_COMBO As ComboBox
    Friend WithEvents NAME_LIST As ListBox
    Friend WithEvents LIST_Panel As Panel
    Friend WithEvents LIST_NAME_LBL As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGV_CREDIT As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents CONTACT_LIST_SEARCH_TXT As TextBox
    Friend WithEvents CONTACT_LIST_SEARCH_BTN As Button
    Friend WithEvents DGV_CONTACT_LIST As DataGridView
End Class
