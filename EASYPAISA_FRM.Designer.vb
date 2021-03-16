<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EASYPAISA_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EASYPAISA_FRM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UPDATE_BTN = New System.Windows.Forms.Button()
        Me.MOBILENO_TXT = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AMOUNT_TXT = New System.Windows.Forms.TextBox()
        Me.TNO_TXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TID_TXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ERROR_LBL = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CUSTOMER_NAME_TXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.COPY_OPT = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER MOBILE NUMBER"
        '
        'UPDATE_BTN
        '
        Me.UPDATE_BTN.Enabled = False
        Me.UPDATE_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UPDATE_BTN.Location = New System.Drawing.Point(605, 490)
        Me.UPDATE_BTN.Name = "UPDATE_BTN"
        Me.UPDATE_BTN.Size = New System.Drawing.Size(132, 61)
        Me.UPDATE_BTN.TabIndex = 5
        Me.UPDATE_BTN.Text = "&Update"
        Me.UPDATE_BTN.UseVisualStyleBackColor = True
        '
        'MOBILENO_TXT
        '
        Me.MOBILENO_TXT.BackColor = System.Drawing.Color.White
        Me.MOBILENO_TXT.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold)
        Me.MOBILENO_TXT.ForeColor = System.Drawing.Color.Silver
        Me.MOBILENO_TXT.Location = New System.Drawing.Point(71, 71)
        Me.MOBILENO_TXT.Mask = "####-#######"
        Me.MOBILENO_TXT.Name = "MOBILENO_TXT"
        Me.MOBILENO_TXT.Size = New System.Drawing.Size(666, 118)
        Me.MOBILENO_TXT.TabIndex = 1
        Me.MOBILENO_TXT.Text = "03012345678"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(221, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AMOUNT:"
        '
        'AMOUNT_TXT
        '
        Me.AMOUNT_TXT.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold)
        Me.AMOUNT_TXT.ForeColor = System.Drawing.Color.Red
        Me.AMOUNT_TXT.Location = New System.Drawing.Point(227, 237)
        Me.AMOUNT_TXT.Name = "AMOUNT_TXT"
        Me.AMOUNT_TXT.Size = New System.Drawing.Size(510, 118)
        Me.AMOUNT_TXT.TabIndex = 2
        Me.AMOUNT_TXT.Text = "PKR 0"
        Me.AMOUNT_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TNO_TXT
        '
        Me.TNO_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.TNO_TXT.ForeColor = System.Drawing.Color.Red
        Me.TNO_TXT.Location = New System.Drawing.Point(287, 522)
        Me.TNO_TXT.Name = "TNO_TXT"
        Me.TNO_TXT.Size = New System.Drawing.Size(312, 29)
        Me.TNO_TXT.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(282, 490)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "T-NO:"
        '
        'TID_TXT
        '
        Me.TID_TXT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TID_TXT.ForeColor = System.Drawing.Color.Red
        Me.TID_TXT.Location = New System.Drawing.Point(71, 522)
        Me.TID_TXT.Name = "TID_TXT"
        Me.TID_TXT.Size = New System.Drawing.Size(210, 29)
        Me.TID_TXT.TabIndex = 50
        Me.TID_TXT.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(66, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "T-ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Easypaisa.My.Resources.Resources.Easy_paisa__2_
        Me.PictureBox1.Location = New System.Drawing.Point(71, 195)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ERROR_LBL
        '
        Me.ERROR_LBL.AutoSize = True
        Me.ERROR_LBL.BackColor = System.Drawing.Color.Maroon
        Me.ERROR_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERROR_LBL.ForeColor = System.Drawing.Color.White
        Me.ERROR_LBL.Location = New System.Drawing.Point(67, 562)
        Me.ERROR_LBL.Name = "ERROR_LBL"
        Me.ERROR_LBL.Size = New System.Drawing.Size(39, 20)
        Me.ERROR_LBL.TabIndex = 92
        Me.ERROR_LBL.Text = "Idle"
        Me.ERROR_LBL.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3500
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.COPY_OPT)
        Me.Panel1.Controls.Add(Me.CUSTOMER_NAME_TXT)
        Me.Panel1.Controls.Add(Me.Label5)
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
        Me.Panel1.Location = New System.Drawing.Point(8, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 589)
        Me.Panel1.TabIndex = 93
        '
        'CUSTOMER_NAME_TXT
        '
        Me.CUSTOMER_NAME_TXT.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMER_NAME_TXT.ForeColor = System.Drawing.Color.Silver
        Me.CUSTOMER_NAME_TXT.Location = New System.Drawing.Point(71, 403)
        Me.CUSTOMER_NAME_TXT.Name = "CUSTOMER_NAME_TXT"
        Me.CUSTOMER_NAME_TXT.Size = New System.Drawing.Size(666, 75)
        Me.CUSTOMER_NAME_TXT.TabIndex = 3
        Me.CUSTOMER_NAME_TXT.Text = "Customer Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(65, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 37)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Account Name:"
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
        'COPY_OPT
        '
        Me.COPY_OPT.AutoSize = True
        Me.COPY_OPT.BackColor = System.Drawing.Color.White
        Me.COPY_OPT.Checked = True
        Me.COPY_OPT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.COPY_OPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COPY_OPT.Location = New System.Drawing.Point(605, 557)
        Me.COPY_OPT.Name = "COPY_OPT"
        Me.COPY_OPT.Size = New System.Drawing.Size(112, 20)
        Me.COPY_OPT.TabIndex = 94
        Me.COPY_OPT.Text = "Copy Recipt"
        Me.COPY_OPT.UseVisualStyleBackColor = False
        '
        'EASYPAISA_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(839, 654)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EASYPAISA_FRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EASYPAISA "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UPDATE_BTN As Button
    Friend WithEvents MOBILENO_TXT As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AMOUNT_TXT As TextBox
    Friend WithEvents TNO_TXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TID_TXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ERROR_LBL As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents CUSTOMER_NAME_TXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents COPY_OPT As CheckBox
End Class
