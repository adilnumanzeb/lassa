Imports MySql.Data.MySqlClient
Public Class JAZZ_CASH_FRM
    Private Sub JAZZ_CASH_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LOGIN_USER
        LOGIN_USER = My.Computer.Registry.CurrentUser.GetValue(Application.ProductName & "\COPYRECIPT")

        If LOGIN_USER = "YES" Then
            COPY_OPT.Checked = True
        Else
            COPY_OPT.Checked = False
        End If

        Me.WindowState = FormWindowState.Maximized
        Call RESIZE_ME_PANEL()
        If MAINWIN_FRM.Label1.Text = "ERROR LOADING" Then
            Exit Sub
        End If
        Call GET_TID_NUMBER()

    End Sub

    Sub RESIZE_ME_PANEL()
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
    End Sub
    Sub GET_TID_NUMBER()
        'TO CHECK IF DB IS NEW

        Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
        Dim DA As New MySqlDataAdapter("SELECT * FROM `TRANS_ID`;", CON)
        Dim CMD As New MySqlCommand("SELECT * FROM `TRANS_ID`;", CON)
        Dim dt As New DataTable
        Dim DR As MySqlDataReader
        CON.Open()
        dt.Clear()
        DA.Fill(dt)
        With dt
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                'DR.Read()
                ' = DR("STATUS").ToString()
                Call TID_UPDATER()
            Else
                Call NEW_DB_TID()
                ERROR_LBL.Text = "NEW DB UPDATED"
                Call GET_TID_NUMBER()
            End If

        End With
    End Sub


    Sub TID_UPDATER()
        Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
        Dim DA As New MySqlDataAdapter("SELECT * FROM `TRANS_ID` ORDER BY `TID` DESC LIMIT 1;", CON)
        Dim CMD As New MySqlCommand("SELECT * FROM `TRANS_ID` ORDER BY `TID` DESC LIMIT 1;", CON)
        Dim dt As New DataTable, DR As MySqlDataReader, TID_DB_VALUE As String

        CON.Open()
        dt.Clear()
        DA.Fill(dt)
        With dt
            DR = CMD.ExecuteReader
            If DR.HasRows = True Then
                DR.Read()
                TID_DB_VALUE = DR("TID").ToString()
                TID_TXT.Text = TID_DB_VALUE + 1
            End If
        End With

    End Sub
    Sub NEW_DB_TID()
        'Using DR USING DATA CONNECTION
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            'Using cmd As New sqlCommand("INSERT INTO `TRANS_ID` VALUES NULL,'N/A','" & AMOUNT_TXT.Text & "','" & TNO_TXT.Text & "','" & Date.Today.ToString("dd-MM-yyyy") & "','N/A';", con)
            Using cmd As New MySqlCommand("INSERT INTO `TRANS_ID` VALUES (NULL,'N/A','0','0','" & Date.Today.ToString("dd-MM-yyyy") & "','N/A');", con)
                Using da As New MySqlDataAdapter
                    con.Open()
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Sub UPDATE_TRANS_CMD()
        'Using DR USING DATA CONNECTION
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("INSERT INTO `TRANS_ID` VALUES (NULL,'" & GET_ONLY_MOBNO(MOBILENO_TXT.Text) & "','" & CUSTOMER_NAME_TXT.Text & "','" & AMOUNT_TXT.Text & "','" & TNO_TXT.Text & "','" & Date.Today.ToString("dd-MM-yyyy") & "','JAZZ CASH');", con)
                Using da As New MySqlDataAdapter
                    con.Open()
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub AMOUNT_TXT_TextChanged(sender As Object, e As EventArgs) Handles AMOUNT_TXT.TextChanged
        Try
            If MOBILENO_TXT.Text <> "" And AMOUNT_TXT.Text <> "PKR 0" Then
                UPDATE_BTN.Enabled = True
            Else
                UPDATE_BTN.Enabled = False
            End If
            If AMOUNT_TXT.Text <> "PKR 0" Then
                AMOUNT_TXT.Text = FormatNumber(AMOUNT_TXT.Text, 0, TriState.False, , TriState.True)
                With AMOUNT_TXT
                    .SelectionStart = .Text.Length
                    .ScrollToCaret()
                End With
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub AMOUNT_TXT_GotFocus(sender As Object, e As EventArgs) Handles AMOUNT_TXT.GotFocus
        If AMOUNT_TXT.Text = "PKR 0" Then
            AMOUNT_TXT.Text = ""
        End If
        With AMOUNT_TXT
            .BackColor = Color.NavajoWhite
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub AMOUNT_TXT_LostFocus(sender As Object, e As EventArgs) Handles AMOUNT_TXT.LostFocus
        If AMOUNT_TXT.Text = "" Then
            AMOUNT_TXT.Text = "PKR 0"
        End If
        With AMOUNT_TXT
            .BackColor = Color.White
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub AMOUNT_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AMOUNT_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            With AMOUNT_TXT
                If AMOUNT_TXT.Text = "" Then
                    .BackColor = Color.Red
                    .ForeColor = Color.White
                    Beep()
                    Exit Sub
                Else
                    .BackColor = Color.White
                    .ForeColor = Color.Black
                End If
            End With
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MOBILENO_TXT_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MOBILENO_TXT.MaskInputRejected

    End Sub

    Private Sub MOBILENO_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MOBILENO_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub UPDATE_BTN_Click(sender As Object, e As EventArgs) Handles UPDATE_BTN.Click
        If MAINWIN_FRM.Label1.Text = "ERROR LOADING" Then
            Beep()
            Exit Sub
        End If
        If MOBILENO_TXT.Text.Count < 11 Then
            MsgBox("MOBILE NUMBER NOT VALID")
            MOBILENO_TXT.Select()
            Exit Sub
        End If
        If AMOUNT_TXT.Text = "" Then
            MsgBox("AMOUNT NOT VALID")
            AMOUNT_TXT.Select()
            Exit Sub
        End If

        UPDATE_TRANS_CMD()




        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        PrintDialog1.PrinterSettings.Copies = 1

        'PrintPreviewDialog1.WindowState = FormWindowState.Normal
        'PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        'PrintPreviewDialog1.ClientSize = New Size(600, 600)




        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            'PrintPreviewDialog1.Document = PrintDocument1
            'PrintPreviewDialog1.ShowDialog()
            PrintDocument1.Print()
            PrintDialog1.Document = PrintDocument2
            PrintDialog1.PrinterSettings = PrintDocument2.PrinterSettings
            PrintDialog1.AllowSomePages = True
            PrintDialog1.PrinterSettings.Copies = 1

            If COPY_OPT.Checked = True Then
                PrintDocument2.Print()
            End If

        End If



        'FORM RESET
        MOBILENO_TXT.Text = ""
        AMOUNT_TXT.Text = ""
        TNO_TXT.Text = ""
        CUSTOMER_NAME_TXT.Text = "Customer Name"
        CUSTOMER_NAME_TXT.ForeColor = Color.Silver
        UPDATE_BTN.Enabled = False
        Call GET_TID_NUMBER()
        MOBILENO_TXT.Select()

    End Sub

    Private Sub TNO_TXT_TextChanged(sender As Object, e As EventArgs) Handles TNO_TXT.TextChanged

    End Sub

    Private Sub TNO_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNO_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            With TNO_TXT
                If TNO_TXT.Text = "" Then
                    .BackColor = Color.Red
                    .ForeColor = Color.White
                    Beep()
                    Exit Sub
                Else
                    .BackColor = Color.White
                    .ForeColor = Color.Black
                End If
            End With
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        With ERROR_LBL
            .Visible = False
        End With
    End Sub

    Private Sub JAZZ_CASH_FRM_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub JAZZ_CASH_FRM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub MOBILENO_TXT_GotFocus(sender As Object, e As EventArgs) Handles MOBILENO_TXT.GotFocus
        With MOBILENO_TXT
            If .Text = "0301-2345678" Then .Text = ""
            .BackColor = Color.NavajoWhite
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub MOBILENO_TXT_LostFocus(sender As Object, e As EventArgs) Handles MOBILENO_TXT.LostFocus
        With MOBILENO_TXT
            .BackColor = Color.White
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub TNO_TXT_GotFocus(sender As Object, e As EventArgs) Handles TNO_TXT.GotFocus
        With TNO_TXT
            .BackColor = Color.NavajoWhite
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub TNO_TXT_LostFocus(sender As Object, e As EventArgs) Handles TNO_TXT.LostFocus
        With TNO_TXT
            .BackColor = Color.White
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        Dim H1_fnt As New Font("Arial", 35, FontStyle.Bold, GraphicsUnit.Point)
        Dim H2_fnt As New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point)
        Dim H3_fnt As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim H4_fnt As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim H5_fnt As New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Point)


        Dim T1_fnt As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim T2_fnt As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point)
        Dim T3_fnt As New Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point)
        Dim XAXIS As Integer, YAXIS As Integer, XAXIS2 As Integer, YAXIS2 As Integer

        e.Graphics.DrawString("IT HUB", H1_fnt, Brushes.Black, 60, 10)
        e.Graphics.DrawString("Add: Main PWD road oppsite to Faisal Bank", H3_fnt, Brushes.Black, 0, 65)
        e.Graphics.DrawString("TEL: 0333-3171787", H3_fnt, Brushes.Black, 75, 85)

        e.Graphics.DrawString("JAZZ CASH", H5_fnt, Brushes.Black, 80, 120)


        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 150)
        e.Graphics.DrawString("CASH RECEIPT", H2_fnt, Brushes.Black, 70, 165)
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 195)

        e.Graphics.DrawString("DISCRIPTION: ", T1_fnt, Brushes.Black, 30, 230)
        e.Graphics.DrawString("DETAILS", T1_fnt, Brushes.Black, 200, 230)

        XAXIS = 30
        XAXIS2 = 200

        YAXIS = 260
        YAXIS2 = YAXIS

        e.Graphics.DrawString("TRANS ID: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TID_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("MOBILE No: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(MOBILENO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("ACC NAME: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(CUSTOMER_NAME_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("AMOUNT: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(AMOUNT_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("TRANS NO: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TNO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20

        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS)
        YAXIS += 15
        YAXIS2 += 15

        e.Graphics.DrawString("DATE:", H2_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        e.Graphics.DrawString(Date.Today.ToString("dd-MM-yyyy"), H2_fnt, Brushes.Black, 170, YAXIS)

        YAXIS += 30
        YAXIS2 += 30
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS2)


        YAXIS += 35
        YAXIS2 += 35
        e.Graphics.DrawString("THANK YOU", H2_fnt, Brushes.Black, 85, YAXIS)


        YAXIS += 45
        YAXIS2 += 45
        e.Graphics.DrawString("EASYPAISA    JAZZ CASH    OMINI", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)


        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("GOOGLE PAY    PAYPAL    PLAYSTORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("APPLE WALLET    XBOX      PS STORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 35
        YAXIS2 += 35
        e.Graphics.DrawString("ALL TYPE OF ONLINE PAYMENTS & TRANSFERS", T3_fnt, Brushes.Black, XAXIS - 20, YAXIS)

    End Sub

    Private Sub JAZZ_CASH_FRM_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        MAINWIN_FRM.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MOBILENO_TXT_TextChanged(sender As Object, e As EventArgs) Handles MOBILENO_TXT.TextChanged
        If MOBILENO_TXT.Text <> "" And AMOUNT_TXT.Text <> "PKR 0" Then
            UPDATE_BTN.Enabled = True
        Else
            UPDATE_BTN.Enabled = False
        End If
    End Sub

    Private Sub ERROR_LBL_TextChanged(sender As Object, e As EventArgs) Handles ERROR_LBL.TextChanged
        ERROR_LBL.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub CUSTOMER_NAME_TXT_TextChanged(sender As Object, e As EventArgs) Handles CUSTOMER_NAME_TXT.TextChanged

    End Sub

    Private Sub CUSTOMER_NAME_TXT_GotFocus(sender As Object, e As EventArgs) Handles CUSTOMER_NAME_TXT.GotFocus
        With CUSTOMER_NAME_TXT
            If .Text = "Customer Name" Then .Text = ""
            .BackColor = Color.NavajoWhite
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub CUSTOMER_NAME_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CUSTOMER_NAME_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            With CUSTOMER_NAME_TXT
                If CUSTOMER_NAME_TXT.Text = "" Then
                    .BackColor = Color.Red
                    .ForeColor = Color.White
                    Beep()
                    Exit Sub
                Else
                    .BackColor = Color.White
                    .ForeColor = Color.Black
                End If
            End With
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage


        Dim H1_fnt As New Font("Arial", 35, FontStyle.Bold, GraphicsUnit.Point)
        Dim H2_fnt As New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point)
        Dim H3_fnt As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim H4_fnt As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim H5_fnt As New Font("Arial", 15, FontStyle.Bold, GraphicsUnit.Point)


        Dim T1_fnt As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim T2_fnt As New Font("Arial", 8, FontStyle.Regular, GraphicsUnit.Point)
        Dim T3_fnt As New Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Point)
        Dim XAXIS As Integer, YAXIS As Integer, XAXIS2 As Integer, YAXIS2 As Integer

        e.Graphics.DrawString("IT HUB", H1_fnt, Brushes.Black, 60, 10)
        e.Graphics.DrawString("Add: Main PWD road oppsite to Faisal Bank", H3_fnt, Brushes.Black, 0, 65)
        e.Graphics.DrawString("TEL: 0333-3171787", H3_fnt, Brushes.Black, 75, 85)

        e.Graphics.DrawString("JAZZ CASH", H5_fnt, Brushes.Black, 80, 120)


        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 150)
        e.Graphics.DrawString("Copy Receipt", H2_fnt, Brushes.Black, 70, 165)
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 195)

        e.Graphics.DrawString("DISCRIPTION: ", T1_fnt, Brushes.Black, 30, 230)
        e.Graphics.DrawString("DETAILS", T1_fnt, Brushes.Black, 200, 230)

        XAXIS = 30
        XAXIS2 = 200

        YAXIS = 260
        YAXIS2 = YAXIS

        e.Graphics.DrawString("TRANS ID: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TID_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("MOBILE No: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(MOBILENO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("ACC NAME: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(CUSTOMER_NAME_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("AMOUNT: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(AMOUNT_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("TRANS NO: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TNO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20

        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS)
        YAXIS += 15
        YAXIS2 += 15

        e.Graphics.DrawString("DATE:", H2_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        e.Graphics.DrawString(Date.Today.ToString("dd-MM-yyyy"), H2_fnt, Brushes.Black, 170, YAXIS)

        YAXIS += 30
        YAXIS2 += 30
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS2)


        YAXIS += 35
        YAXIS2 += 35
        e.Graphics.DrawString("THANK YOU", H2_fnt, Brushes.Black, 85, YAXIS)


        YAXIS += 45
        YAXIS2 += 45
        e.Graphics.DrawString("EASYPAISA    JAZZ CASH    OMINI", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)


        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("GOOGLE PAY    PAYPAL    PLAYSTORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("APPLE WALLET    XBOX      PS STORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 35
        YAXIS2 += 35
        e.Graphics.DrawString("ALL TYPE OF ONLINE PAYMENTS & TRANSFERS", T3_fnt, Brushes.Black, XAXIS - 20, YAXIS)

    End Sub

    Private Sub COPY_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles COPY_OPT.CheckedChanged
        If COPY_OPT.Checked = True Then
            My.Computer.Registry.CurrentUser.SetValue(Application.ProductName & "\COPYRECIPT", "YES")
        Else
            My.Computer.Registry.CurrentUser.SetValue(Application.ProductName & "\COPYRECIPT", "NO")

        End If
    End Sub

    Private Sub MOBILENO_TXT_Click(sender As Object, e As EventArgs) Handles MOBILENO_TXT.Click
        If Trim(MOBILENO_TXT.Text) = "-" Then
            MOBILENO_TXT.Select(0, 0)
        End If
    End Sub
End Class