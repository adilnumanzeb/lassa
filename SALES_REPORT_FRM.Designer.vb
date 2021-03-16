<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SALES_REPORT_FRM
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
        Me.Label37 = New System.Windows.Forms.Label()
        Me.DAILY_BOOK_AMOUNT_TXT = New System.Windows.Forms.TextBox()
        Me.DGV_DAILY_BOOK = New System.Windows.Forms.DataGridView()
        Me.DAILY_BOOK_DATE_TXT = New System.Windows.Forms.MaskedTextBox()
        Me.DTP_DAILYBOOK = New System.Windows.Forms.DateTimePicker()
        Me.DAILYBOOK_NEXT_BTN = New System.Windows.Forms.Button()
        Me.DAILYBOOK_PRE_BTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TOTAL_SALE_TXT = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_DAILY_BOOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(5, 418)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 16)
        Me.Label37.TabIndex = 101
        Me.Label37.Text = "DAILY BOOK:"
        '
        'DAILY_BOOK_AMOUNT_TXT
        '
        Me.DAILY_BOOK_AMOUNT_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAILY_BOOK_AMOUNT_TXT.ForeColor = System.Drawing.Color.DarkRed
        Me.DAILY_BOOK_AMOUNT_TXT.Location = New System.Drawing.Point(8, 437)
        Me.DAILY_BOOK_AMOUNT_TXT.Name = "DAILY_BOOK_AMOUNT_TXT"
        Me.DAILY_BOOK_AMOUNT_TXT.Size = New System.Drawing.Size(277, 31)
        Me.DAILY_BOOK_AMOUNT_TXT.TabIndex = 107
        Me.DAILY_BOOK_AMOUNT_TXT.Text = "PKR"
        '
        'DGV_DAILY_BOOK
        '
        Me.DGV_DAILY_BOOK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DAILY_BOOK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_DAILY_BOOK.Location = New System.Drawing.Point(8, 44)
        Me.DGV_DAILY_BOOK.Name = "DGV_DAILY_BOOK"
        Me.DGV_DAILY_BOOK.ReadOnly = True
        Me.DGV_DAILY_BOOK.RowHeadersVisible = False
        Me.DGV_DAILY_BOOK.RowHeadersWidth = 51
        Me.DGV_DAILY_BOOK.Size = New System.Drawing.Size(577, 360)
        Me.DGV_DAILY_BOOK.TabIndex = 102
        '
        'DAILY_BOOK_DATE_TXT
        '
        Me.DAILY_BOOK_DATE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAILY_BOOK_DATE_TXT.Location = New System.Drawing.Point(321, 13)
        Me.DAILY_BOOK_DATE_TXT.Mask = "##-LLL-####"
        Me.DAILY_BOOK_DATE_TXT.Name = "DAILY_BOOK_DATE_TXT"
        Me.DAILY_BOOK_DATE_TXT.Size = New System.Drawing.Size(129, 26)
        Me.DAILY_BOOK_DATE_TXT.TabIndex = 106
        '
        'DTP_DAILYBOOK
        '
        Me.DTP_DAILYBOOK.Location = New System.Drawing.Point(8, 15)
        Me.DTP_DAILYBOOK.Name = "DTP_DAILYBOOK"
        Me.DTP_DAILYBOOK.Size = New System.Drawing.Size(200, 20)
        Me.DTP_DAILYBOOK.TabIndex = 103
        '
        'DAILYBOOK_NEXT_BTN
        '
        Me.DAILYBOOK_NEXT_BTN.Location = New System.Drawing.Point(271, 17)
        Me.DAILYBOOK_NEXT_BTN.Name = "DAILYBOOK_NEXT_BTN"
        Me.DAILYBOOK_NEXT_BTN.Size = New System.Drawing.Size(37, 21)
        Me.DAILYBOOK_NEXT_BTN.TabIndex = 104
        Me.DAILYBOOK_NEXT_BTN.Text = ">"
        Me.DAILYBOOK_NEXT_BTN.UseVisualStyleBackColor = True
        '
        'DAILYBOOK_PRE_BTN
        '
        Me.DAILYBOOK_PRE_BTN.Location = New System.Drawing.Point(231, 17)
        Me.DAILYBOOK_PRE_BTN.Name = "DAILYBOOK_PRE_BTN"
        Me.DAILYBOOK_PRE_BTN.Size = New System.Drawing.Size(37, 21)
        Me.DAILYBOOK_PRE_BTN.TabIndex = 105
        Me.DAILYBOOK_PRE_BTN.Text = "<"
        Me.DAILYBOOK_PRE_BTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(300, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "TOTAL SALE:"
        '
        'TOTAL_SALE_TXT
        '
        Me.TOTAL_SALE_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL_SALE_TXT.ForeColor = System.Drawing.Color.DarkRed
        Me.TOTAL_SALE_TXT.Location = New System.Drawing.Point(303, 437)
        Me.TOTAL_SALE_TXT.Name = "TOTAL_SALE_TXT"
        Me.TOTAL_SALE_TXT.Size = New System.Drawing.Size(282, 31)
        Me.TOTAL_SALE_TXT.TabIndex = 109
        Me.TOTAL_SALE_TXT.Text = "PKR"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(492, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(218, 179)
        Me.DataGridView1.TabIndex = 110
        Me.DataGridView1.Visible = False
        '
        'SALES_REPORT_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(601, 485)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TOTAL_SALE_TXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.DAILY_BOOK_AMOUNT_TXT)
        Me.Controls.Add(Me.DGV_DAILY_BOOK)
        Me.Controls.Add(Me.DAILY_BOOK_DATE_TXT)
        Me.Controls.Add(Me.DTP_DAILYBOOK)
        Me.Controls.Add(Me.DAILYBOOK_NEXT_BTN)
        Me.Controls.Add(Me.DAILYBOOK_PRE_BTN)
        Me.Name = "SALES_REPORT_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES_REPORT_FRM"
        CType(Me.DGV_DAILY_BOOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label37 As Label
    Friend WithEvents DAILY_BOOK_AMOUNT_TXT As TextBox
    Friend WithEvents DGV_DAILY_BOOK As DataGridView
    Friend WithEvents DAILY_BOOK_DATE_TXT As MaskedTextBox
    Friend WithEvents DTP_DAILYBOOK As DateTimePicker
    Friend WithEvents DAILYBOOK_NEXT_BTN As Button
    Friend WithEvents DAILYBOOK_PRE_BTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TOTAL_SALE_TXT As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
