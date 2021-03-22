<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SALES_FRM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_PRICE_TXT = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QUANTITY_TXT = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ITEM_NAME_TXT = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ITEM_CODE_TXT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV_SEARCH = New System.Windows.Forms.DataGridView()
        Me.STOCK_SEARCH_COMBO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CASH_PANEL_2 = New System.Windows.Forms.Panel()
        Me.PAID_BTN = New System.Windows.Forms.Button()
        Me.CASH_TXT = New System.Windows.Forms.TextBox()
        Me.CHANGE_LBL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PAY_TOTAL_LBL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CASH_Panel = New System.Windows.Forms.Panel()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sale_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAIN_PANEL = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TOTAL_LBL = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TAX_LBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SUBTOTAL_LBL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PAYMENT_BTN = New System.Windows.Forms.Button()
        Me.SALES_BTN = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.STOCKS_BTN = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DGV_ITEMS = New System.Windows.Forms.DataGridView()
        Me.Serial_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        CType(Me.DGV_SEARCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CASH_PANEL_2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CASH_Panel.SuspendLayout()
        Me.MAIN_PANEL.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ITEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 150
        '
        'ITEM_PRICE_TXT
        '
        Me.ITEM_PRICE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM_PRICE_TXT.Location = New System.Drawing.Point(676, 25)
        Me.ITEM_PRICE_TXT.Name = "ITEM_PRICE_TXT"
        Me.ITEM_PRICE_TXT.Size = New System.Drawing.Size(99, 29)
        Me.ITEM_PRICE_TXT.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(677, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Price"
        '
        'QUANTITY_TXT
        '
        Me.QUANTITY_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QUANTITY_TXT.Location = New System.Drawing.Point(209, 25)
        Me.QUANTITY_TXT.Name = "QUANTITY_TXT"
        Me.QUANTITY_TXT.Size = New System.Drawing.Size(94, 29)
        Me.QUANTITY_TXT.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(207, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Quantity"
        '
        'ITEM_NAME_TXT
        '
        Me.ITEM_NAME_TXT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ITEM_NAME_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM_NAME_TXT.Location = New System.Drawing.Point(303, 25)
        Me.ITEM_NAME_TXT.Name = "ITEM_NAME_TXT"
        Me.ITEM_NAME_TXT.Size = New System.Drawing.Size(373, 29)
        Me.ITEM_NAME_TXT.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(300, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 20)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Item Name"
        '
        'ITEM_CODE_TXT
        '
        Me.ITEM_CODE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEM_CODE_TXT.Location = New System.Drawing.Point(2, 25)
        Me.ITEM_CODE_TXT.Name = "ITEM_CODE_TXT"
        Me.ITEM_CODE_TXT.Size = New System.Drawing.Size(207, 29)
        Me.ITEM_CODE_TXT.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Item Code"
        '
        'DGV_SEARCH
        '
        Me.DGV_SEARCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SEARCH.Enabled = False
        Me.DGV_SEARCH.Location = New System.Drawing.Point(374, 42)
        Me.DGV_SEARCH.Name = "DGV_SEARCH"
        Me.DGV_SEARCH.ReadOnly = True
        Me.DGV_SEARCH.RowHeadersVisible = False
        Me.DGV_SEARCH.Size = New System.Drawing.Size(377, 150)
        Me.DGV_SEARCH.TabIndex = 25
        Me.DGV_SEARCH.Visible = False
        '
        'STOCK_SEARCH_COMBO
        '
        Me.STOCK_SEARCH_COMBO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.STOCK_SEARCH_COMBO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.STOCK_SEARCH_COMBO.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.STOCK_SEARCH_COMBO.FormattingEnabled = True
        Me.STOCK_SEARCH_COMBO.Location = New System.Drawing.Point(374, 11)
        Me.STOCK_SEARCH_COMBO.Name = "STOCK_SEARCH_COMBO"
        Me.STOCK_SEARCH_COMBO.Size = New System.Drawing.Size(377, 32)
        Me.STOCK_SEARCH_COMBO.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(804, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Customer name"
        '
        'CASH_PANEL_2
        '
        Me.CASH_PANEL_2.BackColor = System.Drawing.Color.SteelBlue
        Me.CASH_PANEL_2.Controls.Add(Me.PAID_BTN)
        Me.CASH_PANEL_2.Controls.Add(Me.CASH_TXT)
        Me.CASH_PANEL_2.Controls.Add(Me.CHANGE_LBL)
        Me.CASH_PANEL_2.Controls.Add(Me.Label17)
        Me.CASH_PANEL_2.Controls.Add(Me.Label15)
        Me.CASH_PANEL_2.Controls.Add(Me.PAY_TOTAL_LBL)
        Me.CASH_PANEL_2.Controls.Add(Me.Label5)
        Me.CASH_PANEL_2.Controls.Add(Me.Label18)
        Me.CASH_PANEL_2.Location = New System.Drawing.Point(24, 20)
        Me.CASH_PANEL_2.Name = "CASH_PANEL_2"
        Me.CASH_PANEL_2.Size = New System.Drawing.Size(612, 331)
        Me.CASH_PANEL_2.TabIndex = 8
        '
        'PAID_BTN
        '
        Me.PAID_BTN.BackColor = System.Drawing.Color.SeaGreen
        Me.PAID_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAID_BTN.ForeColor = System.Drawing.Color.White
        Me.PAID_BTN.Location = New System.Drawing.Point(18, 269)
        Me.PAID_BTN.Name = "PAID_BTN"
        Me.PAID_BTN.Size = New System.Drawing.Size(574, 42)
        Me.PAID_BTN.TabIndex = 25
        Me.PAID_BTN.Text = "&PAID"
        Me.PAID_BTN.UseVisualStyleBackColor = False
        '
        'CASH_TXT
        '
        Me.CASH_TXT.BackColor = System.Drawing.Color.White
        Me.CASH_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CASH_TXT.ForeColor = System.Drawing.Color.DarkRed
        Me.CASH_TXT.Location = New System.Drawing.Point(130, 97)
        Me.CASH_TXT.Name = "CASH_TXT"
        Me.CASH_TXT.Size = New System.Drawing.Size(200, 29)
        Me.CASH_TXT.TabIndex = 12
        Me.CASH_TXT.Text = "PKR 000.00"
        '
        'CHANGE_LBL
        '
        Me.CHANGE_LBL.AutoSize = True
        Me.CHANGE_LBL.BackColor = System.Drawing.Color.DarkRed
        Me.CHANGE_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHANGE_LBL.ForeColor = System.Drawing.Color.White
        Me.CHANGE_LBL.Location = New System.Drawing.Point(191, 164)
        Me.CHANGE_LBL.Name = "CHANGE_LBL"
        Me.CHANGE_LBL.Size = New System.Drawing.Size(294, 55)
        Me.CHANGE_LBL.TabIndex = 11
        Me.CHANGE_LBL.Text = "PKR 000.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(13, 185)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 29)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "CHANGE:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(11, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 29)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "CASH:"
        '
        'PAY_TOTAL_LBL
        '
        Me.PAY_TOTAL_LBL.AutoSize = True
        Me.PAY_TOTAL_LBL.BackColor = System.Drawing.Color.White
        Me.PAY_TOTAL_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.PAY_TOTAL_LBL.ForeColor = System.Drawing.Color.DarkRed
        Me.PAY_TOTAL_LBL.Location = New System.Drawing.Point(131, 51)
        Me.PAY_TOTAL_LBL.Name = "PAY_TOTAL_LBL"
        Me.PAY_TOTAL_LBL.Size = New System.Drawing.Size(199, 37)
        Me.PAY_TOTAL_LBL.TabIndex = 7
        Me.PAY_TOTAL_LBL.Text = "PKR 000.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TOTAL:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(11, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(144, 29)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "PAYMENT:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.ITEM_PRICE_TXT)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.QUANTITY_TXT)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.ITEM_NAME_TXT)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.ITEM_CODE_TXT)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(14, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 56)
        Me.Panel2.TabIndex = 23
        '
        'CASH_Panel
        '
        Me.CASH_Panel.BackColor = System.Drawing.Color.Maroon
        Me.CASH_Panel.Controls.Add(Me.CASH_PANEL_2)
        Me.CASH_Panel.Enabled = False
        Me.CASH_Panel.Location = New System.Drawing.Point(54, 152)
        Me.CASH_Panel.Name = "CASH_Panel"
        Me.CASH_Panel.Size = New System.Drawing.Size(661, 375)
        Me.CASH_Panel.TabIndex = 24
        Me.CASH_Panel.Visible = False
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'Sale_Price
        '
        Me.Sale_Price.HeaderText = "Sale Price"
        Me.Sale_Price.Name = "Sale_Price"
        Me.Sale_Price.Width = 120
        '
        'MAIN_PANEL
        '
        Me.MAIN_PANEL.Controls.Add(Me.DGV_SEARCH)
        Me.MAIN_PANEL.Controls.Add(Me.STOCK_SEARCH_COMBO)
        Me.MAIN_PANEL.Controls.Add(Me.Panel2)
        Me.MAIN_PANEL.Controls.Add(Me.Button5)
        Me.MAIN_PANEL.Controls.Add(Me.Label9)
        Me.MAIN_PANEL.Controls.Add(Me.Panel1)
        Me.MAIN_PANEL.Controls.Add(Me.PAYMENT_BTN)
        Me.MAIN_PANEL.Controls.Add(Me.SALES_BTN)
        Me.MAIN_PANEL.Controls.Add(Me.Button2)
        Me.MAIN_PANEL.Controls.Add(Me.STOCKS_BTN)
        Me.MAIN_PANEL.Controls.Add(Me.Button3)
        Me.MAIN_PANEL.Controls.Add(Me.Button6)
        Me.MAIN_PANEL.Controls.Add(Me.Button4)
        Me.MAIN_PANEL.Controls.Add(Me.Label8)
        Me.MAIN_PANEL.Controls.Add(Me.Label10)
        Me.MAIN_PANEL.Controls.Add(Me.TextBox1)
        Me.MAIN_PANEL.Controls.Add(Me.CASH_Panel)
        Me.MAIN_PANEL.Controls.Add(Me.DGV_ITEMS)
        Me.MAIN_PANEL.Location = New System.Drawing.Point(12, 27)
        Me.MAIN_PANEL.Name = "MAIN_PANEL"
        Me.MAIN_PANEL.Size = New System.Drawing.Size(1165, 555)
        Me.MAIN_PANEL.TabIndex = 26
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(188, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 31)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TOTAL_LBL)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TAX_LBL)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.SUBTOTAL_LBL)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(802, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 184)
        Me.Panel1.TabIndex = 0
        '
        'TOTAL_LBL
        '
        Me.TOTAL_LBL.AutoSize = True
        Me.TOTAL_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_LBL.ForeColor = System.Drawing.Color.White
        Me.TOTAL_LBL.Location = New System.Drawing.Point(133, 140)
        Me.TOTAL_LBL.Name = "TOTAL_LBL"
        Me.TOTAL_LBL.Size = New System.Drawing.Size(90, 29)
        Me.TOTAL_LBL.TabIndex = 7
        Me.TOTAL_LBL.Text = "000.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOTAL:"
        '
        'TAX_LBL
        '
        Me.TAX_LBL.AutoSize = True
        Me.TAX_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAX_LBL.ForeColor = System.Drawing.Color.White
        Me.TAX_LBL.Location = New System.Drawing.Point(134, 100)
        Me.TAX_LBL.Name = "TAX_LBL"
        Me.TAX_LBL.Size = New System.Drawing.Size(60, 24)
        Me.TAX_LBL.TabIndex = 5
        Me.TAX_LBL.Text = "00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tax:"
        '
        'SUBTOTAL_LBL
        '
        Me.SUBTOTAL_LBL.AutoSize = True
        Me.SUBTOTAL_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBTOTAL_LBL.ForeColor = System.Drawing.Color.White
        Me.SUBTOTAL_LBL.Location = New System.Drawing.Point(135, 60)
        Me.SUBTOTAL_LBL.Name = "SUBTOTAL_LBL"
        Me.SUBTOTAL_LBL.Size = New System.Drawing.Size(44, 18)
        Me.SUBTOTAL_LBL.TabIndex = 3
        Me.SUBTOTAL_LBL.Text = "00.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SubTotal:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Summary"
        '
        'PAYMENT_BTN
        '
        Me.PAYMENT_BTN.BackColor = System.Drawing.Color.SeaGreen
        Me.PAYMENT_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAYMENT_BTN.ForeColor = System.Drawing.Color.White
        Me.PAYMENT_BTN.Location = New System.Drawing.Point(802, 265)
        Me.PAYMENT_BTN.Name = "PAYMENT_BTN"
        Me.PAYMENT_BTN.Size = New System.Drawing.Size(349, 45)
        Me.PAYMENT_BTN.TabIndex = 5
        Me.PAYMENT_BTN.Text = "&Payment F2"
        Me.PAYMENT_BTN.UseVisualStyleBackColor = False
        '
        'SALES_BTN
        '
        Me.SALES_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALES_BTN.Location = New System.Drawing.Point(915, 13)
        Me.SALES_BTN.Name = "SALES_BTN"
        Me.SALES_BTN.Size = New System.Drawing.Size(107, 31)
        Me.SALES_BTN.TabIndex = 20
        Me.SALES_BTN.Text = "SA&LES"
        Me.SALES_BTN.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(802, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(349, 45)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&ADD CUSTOMER DETAILS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'STOCKS_BTN
        '
        Me.STOCKS_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STOCKS_BTN.Location = New System.Drawing.Point(802, 13)
        Me.STOCKS_BTN.Name = "STOCKS_BTN"
        Me.STOCKS_BTN.Size = New System.Drawing.Size(107, 31)
        Me.STOCKS_BTN.TabIndex = 19
        Me.STOCKS_BTN.Text = "&STOCKS"
        Me.STOCKS_BTN.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkRed
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(802, 316)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 45)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Abort F4"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(761, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 31)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(955, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 45)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "NEW BILL F3"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "BAR CODE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(263, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Stock Search:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 29)
        Me.TextBox1.TabIndex = 13
        '
        'DGV_ITEMS
        '
        Me.DGV_ITEMS.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ITEMS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ITEMS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Serial_no, Me.Quantity, Me.Item_name, Me.Sale_Price, Me.Amount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_ITEMS.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_ITEMS.Location = New System.Drawing.Point(14, 135)
        Me.DGV_ITEMS.Name = "DGV_ITEMS"
        Me.DGV_ITEMS.RowHeadersVisible = False
        Me.DGV_ITEMS.Size = New System.Drawing.Size(777, 403)
        Me.DGV_ITEMS.TabIndex = 21
        '
        'Serial_no
        '
        Me.Serial_no.HeaderText = "Sr."
        Me.Serial_no.Name = "Serial_no"
        Me.Serial_no.Width = 50
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Width = 50
        '
        'Item_name
        '
        Me.Item_name.HeaderText = "Item"
        Me.Item_name.Name = "Item_name"
        Me.Item_name.Width = 380
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SALES_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 625)
        Me.Controls.Add(Me.MAIN_PANEL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "SALES_FRM"
        Me.Text = "SALES_FRM"
        CType(Me.DGV_SEARCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CASH_PANEL_2.ResumeLayout(False)
        Me.CASH_PANEL_2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CASH_Panel.ResumeLayout(False)
        Me.MAIN_PANEL.ResumeLayout(False)
        Me.MAIN_PANEL.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_ITEMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents ITEM_PRICE_TXT As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents QUANTITY_TXT As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ITEM_NAME_TXT As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ITEM_CODE_TXT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DGV_SEARCH As DataGridView
    Friend WithEvents STOCK_SEARCH_COMBO As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CASH_PANEL_2 As Panel
    Friend WithEvents PAID_BTN As Button
    Friend WithEvents CASH_TXT As TextBox
    Friend WithEvents CHANGE_LBL As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PAY_TOTAL_LBL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CASH_Panel As Panel
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sale_Price As DataGridViewTextBoxColumn
    Friend WithEvents MAIN_PANEL As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TOTAL_LBL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TAX_LBL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SUBTOTAL_LBL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PAYMENT_BTN As Button
    Friend WithEvents SALES_BTN As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents STOCKS_BTN As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DGV_ITEMS As DataGridView
    Friend WithEvents Serial_no As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Item_name As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
