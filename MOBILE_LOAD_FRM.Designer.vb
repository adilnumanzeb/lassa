<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MOBILE_LOAD_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MOBILE_LOAD_FRM))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CREDITOR_PANEL = New System.Windows.Forms.Panel()
        Me.CREDITORS_BTN = New System.Windows.Forms.Button()
        Me.CREDIT_OPT = New System.Windows.Forms.RadioButton()
        Me.CASH_OPT = New System.Windows.Forms.RadioButton()
        Me.CREDITOR_TXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COPY_OPT = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TELENOR_OPT = New System.Windows.Forms.RadioButton()
        Me.ZONG_OPT = New System.Windows.Forms.RadioButton()
        Me.JAZZ_OPT = New System.Windows.Forms.RadioButton()
        Me.UFONE_OPT = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ERROR_LBL = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TID_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TNO_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AMOUNT_TXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MOBILENO_TXT = New System.Windows.Forms.MaskedTextBox()
        Me.UPDATE_BTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.CREDITOR_PANEL.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.CREDITOR_PANEL)
        Me.Panel1.Controls.Add(Me.COPY_OPT)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ERROR_LBL)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TID_TXT)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TNO_TXT)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.AMOUNT_TXT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MOBILENO_TXT)
        Me.Panel1.Controls.Add(Me.UPDATE_BTN)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 660)
        Me.Panel1.TabIndex = 94
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(754, 148)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(55, 173)
        Me.ListBox1.TabIndex = 14
        Me.ListBox1.Visible = False
        '
        'CREDITOR_PANEL
        '
        Me.CREDITOR_PANEL.BackColor = System.Drawing.Color.OldLace
        Me.CREDITOR_PANEL.Controls.Add(Me.CREDITORS_BTN)
        Me.CREDITOR_PANEL.Controls.Add(Me.CREDIT_OPT)
        Me.CREDITOR_PANEL.Controls.Add(Me.CASH_OPT)
        Me.CREDITOR_PANEL.Controls.Add(Me.CREDITOR_TXT)
        Me.CREDITOR_PANEL.Controls.Add(Me.Label5)
        Me.CREDITOR_PANEL.Location = New System.Drawing.Point(72, 434)
        Me.CREDITOR_PANEL.Name = "CREDITOR_PANEL"
        Me.CREDITOR_PANEL.Size = New System.Drawing.Size(663, 105)
        Me.CREDITOR_PANEL.TabIndex = 3
        '
        'CREDITORS_BTN
        '
        Me.CREDITORS_BTN.Location = New System.Drawing.Point(506, 53)
        Me.CREDITORS_BTN.Name = "CREDITORS_BTN"
        Me.CREDITORS_BTN.Size = New System.Drawing.Size(147, 27)
        Me.CREDITORS_BTN.TabIndex = 3
        Me.CREDITORS_BTN.Text = "CREDITORS"
        Me.CREDITORS_BTN.UseVisualStyleBackColor = True
        '
        'CREDIT_OPT
        '
        Me.CREDIT_OPT.AutoSize = True
        Me.CREDIT_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREDIT_OPT.Location = New System.Drawing.Point(135, 12)
        Me.CREDIT_OPT.Name = "CREDIT_OPT"
        Me.CREDIT_OPT.Size = New System.Drawing.Size(67, 20)
        Me.CREDIT_OPT.TabIndex = 2
        Me.CREDIT_OPT.Text = "Credit"
        Me.CREDIT_OPT.UseVisualStyleBackColor = True
        '
        'CASH_OPT
        '
        Me.CASH_OPT.AutoSize = True
        Me.CASH_OPT.Checked = True
        Me.CASH_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CASH_OPT.Location = New System.Drawing.Point(8, 12)
        Me.CASH_OPT.Name = "CASH_OPT"
        Me.CASH_OPT.Size = New System.Drawing.Size(61, 20)
        Me.CASH_OPT.TabIndex = 1
        Me.CASH_OPT.TabStop = True
        Me.CASH_OPT.Text = "Cash"
        Me.CASH_OPT.UseVisualStyleBackColor = True
        '
        'CREDITOR_TXT
        '
        Me.CREDITOR_TXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CREDITOR_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CREDITOR_TXT.ForeColor = System.Drawing.Color.Black
        Me.CREDITOR_TXT.Location = New System.Drawing.Point(164, 52)
        Me.CREDITOR_TXT.Name = "CREDITOR_TXT"
        Me.CREDITOR_TXT.Size = New System.Drawing.Size(336, 29)
        Me.CREDITOR_TXT.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CREDIT TO:"
        '
        'COPY_OPT
        '
        Me.COPY_OPT.AutoSize = True
        Me.COPY_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COPY_OPT.Location = New System.Drawing.Point(616, 621)
        Me.COPY_OPT.Name = "COPY_OPT"
        Me.COPY_OPT.Size = New System.Drawing.Size(112, 20)
        Me.COPY_OPT.TabIndex = 6
        Me.COPY_OPT.Text = "Copy Recipt"
        Me.COPY_OPT.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TELENOR_OPT)
        Me.Panel2.Controls.Add(Me.ZONG_OPT)
        Me.Panel2.Controls.Add(Me.JAZZ_OPT)
        Me.Panel2.Controls.Add(Me.UFONE_OPT)
        Me.Panel2.Location = New System.Drawing.Point(74, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(662, 35)
        Me.Panel2.TabIndex = 1
        '
        'TELENOR_OPT
        '
        Me.TELENOR_OPT.AutoSize = True
        Me.TELENOR_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TELENOR_OPT.Location = New System.Drawing.Point(473, 7)
        Me.TELENOR_OPT.Name = "TELENOR_OPT"
        Me.TELENOR_OPT.Size = New System.Drawing.Size(109, 24)
        Me.TELENOR_OPT.TabIndex = 4
        Me.TELENOR_OPT.Text = "TELENOR"
        Me.TELENOR_OPT.UseVisualStyleBackColor = True
        '
        'ZONG_OPT
        '
        Me.ZONG_OPT.AutoSize = True
        Me.ZONG_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZONG_OPT.Location = New System.Drawing.Point(329, 7)
        Me.ZONG_OPT.Name = "ZONG_OPT"
        Me.ZONG_OPT.Size = New System.Drawing.Size(77, 24)
        Me.ZONG_OPT.TabIndex = 3
        Me.ZONG_OPT.Text = "ZONG"
        Me.ZONG_OPT.UseVisualStyleBackColor = True
        '
        'JAZZ_OPT
        '
        Me.JAZZ_OPT.AutoSize = True
        Me.JAZZ_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JAZZ_OPT.Location = New System.Drawing.Point(182, 7)
        Me.JAZZ_OPT.Name = "JAZZ_OPT"
        Me.JAZZ_OPT.Size = New System.Drawing.Size(70, 24)
        Me.JAZZ_OPT.TabIndex = 2
        Me.JAZZ_OPT.Text = "JAZZ"
        Me.JAZZ_OPT.UseVisualStyleBackColor = True
        '
        'UFONE_OPT
        '
        Me.UFONE_OPT.AutoSize = True
        Me.UFONE_OPT.Checked = True
        Me.UFONE_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UFONE_OPT.Location = New System.Drawing.Point(40, 7)
        Me.UFONE_OPT.Name = "UFONE_OPT"
        Me.UFONE_OPT.Size = New System.Drawing.Size(88, 24)
        Me.UFONE_OPT.TabIndex = 1
        Me.UFONE_OPT.TabStop = True
        Me.UFONE_OPT.Text = "UFONE"
        Me.UFONE_OPT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER MOBILE NUMBER"
        '
        'ERROR_LBL
        '
        Me.ERROR_LBL.AutoSize = True
        Me.ERROR_LBL.BackColor = System.Drawing.Color.Maroon
        Me.ERROR_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERROR_LBL.ForeColor = System.Drawing.Color.White
        Me.ERROR_LBL.Location = New System.Drawing.Point(67, 622)
        Me.ERROR_LBL.Name = "ERROR_LBL"
        Me.ERROR_LBL.Size = New System.Drawing.Size(39, 20)
        Me.ERROR_LBL.TabIndex = 92
        Me.ERROR_LBL.Text = "Idle"
        Me.ERROR_LBL.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Easypaisa.My.Resources.Resources.Mobile_Load_Inner_header
        Me.PictureBox1.Location = New System.Drawing.Point(71, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TID_TXT
        '
        Me.TID_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TID_TXT.ForeColor = System.Drawing.Color.Red
        Me.TID_TXT.Location = New System.Drawing.Point(66, 586)
        Me.TID_TXT.Name = "TID_TXT"
        Me.TID_TXT.Size = New System.Drawing.Size(210, 29)
        Me.TID_TXT.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(61, 554)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "T-ID:"
        '
        'TNO_TXT
        '
        Me.TNO_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TNO_TXT.ForeColor = System.Drawing.Color.Red
        Me.TNO_TXT.Location = New System.Drawing.Point(287, 586)
        Me.TNO_TXT.Name = "TNO_TXT"
        Me.TNO_TXT.Size = New System.Drawing.Size(312, 29)
        Me.TNO_TXT.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(282, 554)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "T-NO:"
        '
        'AMOUNT_TXT
        '
        Me.AMOUNT_TXT.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold)
        Me.AMOUNT_TXT.ForeColor = System.Drawing.Color.Red
        Me.AMOUNT_TXT.Location = New System.Drawing.Point(269, 299)
        Me.AMOUNT_TXT.Name = "AMOUNT_TXT"
        Me.AMOUNT_TXT.Size = New System.Drawing.Size(468, 118)
        Me.AMOUNT_TXT.TabIndex = 2
        Me.AMOUNT_TXT.Text = "PKR 0"
        Me.AMOUNT_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(262, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AMOUNT:"
        '
        'MOBILENO_TXT
        '
        Me.MOBILENO_TXT.BackColor = System.Drawing.Color.White
        Me.MOBILENO_TXT.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold)
        Me.MOBILENO_TXT.Location = New System.Drawing.Point(71, 80)
        Me.MOBILENO_TXT.Mask = "####-#######"
        Me.MOBILENO_TXT.Name = "MOBILENO_TXT"
        Me.MOBILENO_TXT.Size = New System.Drawing.Size(666, 118)
        Me.MOBILENO_TXT.TabIndex = 0
        '
        'UPDATE_BTN
        '
        Me.UPDATE_BTN.Enabled = False
        Me.UPDATE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_BTN.Location = New System.Drawing.Point(605, 554)
        Me.UPDATE_BTN.Name = "UPDATE_BTN"
        Me.UPDATE_BTN.Size = New System.Drawing.Size(132, 61)
        Me.UPDATE_BTN.TabIndex = 5
        Me.UPDATE_BTN.Text = "&Update"
        Me.UPDATE_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3500
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument2
        '
        '
        'MOBILE_LOAD_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(847, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MOBILE_LOAD_FRM"
        Me.Text = "MOBILE_LOAD_FRM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CREDITOR_PANEL.ResumeLayout(False)
        Me.CREDITOR_PANEL.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ERROR_LBL As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TNO_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AMOUNT_TXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MOBILENO_TXT As MaskedTextBox
    Friend WithEvents UPDATE_BTN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents TELENOR_OPT As RadioButton
    Friend WithEvents ZONG_OPT As RadioButton
    Friend WithEvents JAZZ_OPT As RadioButton
    Friend WithEvents UFONE_OPT As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TID_TXT As TextBox
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents COPY_OPT As CheckBox
    Friend WithEvents CREDITOR_PANEL As Panel
    Friend WithEvents CREDIT_OPT As RadioButton
    Friend WithEvents CASH_OPT As RadioButton
    Friend WithEvents CREDITOR_TXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CREDITORS_BTN As Button
    Friend WithEvents ListBox1 As ListBox
End Class
