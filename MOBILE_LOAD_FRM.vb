Imports MySql.Data.MySqlClient
Public Class MOBILE_LOAD_FRM
    Public MySource As New AutoCompleteStringCollection()
    Private Sub MOBILE_LOAD_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LOGIN_USER
        LOGIN_USER = My.Computer.Registry.CurrentUser.GetValue(Application.ProductName & "\COPYRECIPT")

        If LOGIN_USER = "YES" Then
            COPY_OPT.Checked = True
        Else
            COPY_OPT.Checked = False
        End If



        'MsgBox(LOGIN_PASSKEY)
        Me.WindowState = FormWindowState.Maximized
        Call RESIZE_ME_PANEL()
        If MAINWIN_FRM.Label1.Text = "ERROR LOADING" Then
            Exit Sub
        End If
        Call GET_TID_NUMBER()
        Call GET_CREDITORS_LIST()

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
            Using cmd As New MySqlCommand("INSERT INTO `TRANS_ID` VALUES (NULL,'" & MOBILENO_TXT.Text & "','N/A','0','0','" & Date.Today.ToString("dd-MM-yyyy") & "','N/A');", con)
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
        If CREDIT_OPT.Checked = True Then
            'GET BALANCE
            Dim GET_BALANCE As Integer, SET_BALANCE As Integer
            Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
                Using cmd As New MySqlCommand("SELECT * FROM `CONTACTS` WHERE `MOBILE` = '" & GET_ONLY_MOBNO(MOBILENO_TXT.Text) & "'; ", con)
                    Using da As New MySqlDataAdapter
                        Dim DR As MySqlDataReader
                        con.Open()
                        da.SelectCommand = cmd
                        DR = cmd.ExecuteReader
                        If DR.HasRows Then
                            DR.Read()
                            GET_BALANCE = DR("BALANCE").ToString
                        End If
                        con.Close()
                    End Using
                End Using
            End Using


            'SET BALANCE
            If GET_BALANCE = 0 Then
                If IsNumeric(AMOUNT_TXT.Text) = False Then
                    MsgBox("ENTER VALID AMOUNT")
                    AMOUNT_TXT.Select()
                    Exit Sub
                End If

                SET_BALANCE = Int(0 - AMOUNT_TXT.Text)
            Else
                SET_BALANCE = Int(GET_BALANCE - AMOUNT_TXT.Text)
            End If

            'ACCOUNT HISTORY / STATEMENT

            Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
                Using cmd As New MySqlCommand("INSERT INTO `CREDIT_HISTORY` VALUES (NULL,'" & GET_ONLY_MOBNO(MOBILENO_TXT.Text) & "','N/A','" & SET_BALANCE & "','" & TNO_TXT.Text & "','" & Date.Today.ToString("dd-MM-yyyy") & "','MOBILE LOAD');", con)
                    Using da As New MySqlDataAdapter
                        con.Open()
                        da.SelectCommand = cmd
                        cmd.ExecuteNonQuery()
                        con.Close()
                    End Using
                End Using
            End Using

            'UPDATE CREDIT BALANCE
            Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
                Using cmd As New MySqlCommand("UPDATE `contacts` SET `BALANCE` = '" & SET_BALANCE & "' WHERE (`MOBILE` = '" & GET_ONLY_MOBNO(MOBILENO_TXT.Text) & "');", con)
                    Using da As New MySqlDataAdapter
                        Dim DR As MySqlDataReader, dt As New DataTable
                        con.Open()
                        da.SelectCommand = cmd
                        DR = cmd.ExecuteReader
                        If DR.HasRows Then
                            DR.Read()
                            CREDITOR_TXT.Text = DR("NAME").ToString
                        End If
                        con.Close()
                    End Using
                End Using
            End Using
        End If

        'TRANSECTION HISTORY
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("INSERT INTO `TRANS_ID` VALUES (NULL,'" & GET_ONLY_MOBNO(MOBILENO_TXT.Text) & "','N/A','" & AMOUNT_TXT.Text & "','" & TNO_TXT.Text & "','" & Date.Today.ToString("dd-MM-yyyy") & "','MOBILE LOAD');", con)
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
        CREDITOR_TXT.Text = ""
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
    Private Sub MOBILE_LOAD_FRM_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub MOBILE_LOAD_FRM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub MOBILENO_TXT_GotFocus(sender As Object, e As EventArgs) Handles MOBILENO_TXT.GotFocus
        With MOBILENO_TXT
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

        If UFONE_OPT.Checked = True Then
            e.Graphics.DrawString("UFONE RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf JAZZ_OPT.Checked = True Then
            e.Graphics.DrawString("JAZZ RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf ZONG_OPT.Checked = True Then
            e.Graphics.DrawString("ZONG RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf TELENOR_OPT.Checked = True Then
            e.Graphics.DrawString("TELENOR RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        End If


        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 170)
        e.Graphics.DrawString("CASH RECEIPT", H2_fnt, Brushes.Black, 70, 185)
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 215)

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
        e.Graphics.DrawString("AMOUNT: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(AMOUNT_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("TRANS NO: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TNO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 40
        YAXIS2 += 40

        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS)
        YAXIS += 15
        YAXIS2 += 15

        e.Graphics.DrawString("DATE:", H2_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        e.Graphics.DrawString(Date.Today.ToString("dd-MM-yyyy"), H2_fnt, Brushes.Black, 170, YAXIS)

        YAXIS += 30
        YAXIS2 += 30
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS2)


        YAXIS += 40
        YAXIS2 += 40
        e.Graphics.DrawString("THANK YOU", H2_fnt, Brushes.Black, 85, YAXIS)


        YAXIS += 55
        YAXIS2 += 55
        e.Graphics.DrawString("EASYPAISA    JAZZ CASH    OMINI", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)


        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("GOOGLE PAY    PAYPAL    PLAYSTORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("APPLE WALLET    XBOX      PS STORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
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

        If MOBILENO_TXT.Text = "033 -" Then
            UFONE_OPT.Checked = True
        End If
        If MOBILENO_TXT.Text = "031 -" Then
            ZONG_OPT.Checked = True
        End If
        If MOBILENO_TXT.Text = "030 -" Then
            JAZZ_OPT.Checked = True
        End If
        If MOBILENO_TXT.Text = "032 -" Then
            JAZZ_OPT.Checked = True
        End If
        If MOBILENO_TXT.Text = "034 -" Then
            TELENOR_OPT.Checked = True
        End If

        Try
            Dim ONLY_MOBILE_NUMBER = ""
            Dim mytext As String = MOBILENO_TXT.Text
            Dim myChars() As Char = mytext.ToCharArray()
            For Each ch As Char In myChars
                If Char.IsDigit(ch) Then
                    ONLY_MOBILE_NUMBER += ch
                End If
            Next
            Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
                Using cmd As New MySqlCommand("SELECT * FROM `CONTACTS` WHERE `MOBILE` = '" & ONLY_MOBILE_NUMBER & "'; ", con)
                    Using da As New MySqlDataAdapter
                        Dim DR As MySqlDataReader, dt As New DataTable
                        con.Open()
                        da.SelectCommand = cmd
                        DR = cmd.ExecuteReader
                        If DR.HasRows Then
                            DR.Read()
                            CREDITOR_TXT.Text = DR("NAME").ToString
                        End If
                        con.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ERROR_LBL_TextChanged(sender As Object, e As EventArgs) Handles ERROR_LBL.TextChanged
        ERROR_LBL.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub TELENOR_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles TELENOR_OPT.CheckedChanged

    End Sub

    Private Sub TELENOR_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TELENOR_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ZONG_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles ZONG_OPT.CheckedChanged

    End Sub

    Private Sub ZONG_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ZONG_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub JAZZ_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles JAZZ_OPT.CheckedChanged

    End Sub

    Private Sub JAZZ_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles JAZZ_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub UFONE_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles UFONE_OPT.CheckedChanged

    End Sub

    Private Sub UFONE_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UFONE_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
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

        If UFONE_OPT.Checked = True Then
            e.Graphics.DrawString("UFONE RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf JAZZ_OPT.Checked = True Then
            e.Graphics.DrawString("JAZZ RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf ZONG_OPT.Checked = True Then
            e.Graphics.DrawString("ZONG RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        ElseIf TELENOR_OPT.Checked = True Then
            e.Graphics.DrawString("TELENOR RECHARGE", H5_fnt, Brushes.Black, 55, 120)
        End If


        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 170)
        e.Graphics.DrawString("Copy Receipt", H2_fnt, Brushes.Black, 70, 185)
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, 215)

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
        e.Graphics.DrawString("AMOUNT: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(AMOUNT_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 20
        YAXIS2 += 20
        e.Graphics.DrawString("TRANS NO: ", T2_fnt, Brushes.Black, XAXIS, YAXIS)
        e.Graphics.DrawString(TNO_TXT.Text, T2_fnt, Brushes.Black, XAXIS2, YAXIS2)

        YAXIS += 40
        YAXIS2 += 40

        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS)
        YAXIS += 15
        YAXIS2 += 15

        e.Graphics.DrawString("DATE:", H2_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        e.Graphics.DrawString(Date.Today.ToString("dd-MM-yyyy"), H2_fnt, Brushes.Black, 170, YAXIS)

        YAXIS += 30
        YAXIS2 += 30
        e.Graphics.DrawString("**********************************************************", H3_fnt, Brushes.Black, 10, YAXIS2)


        YAXIS += 40
        YAXIS2 += 40
        e.Graphics.DrawString("THANK YOU", H2_fnt, Brushes.Black, 85, YAXIS)


        YAXIS += 55
        YAXIS2 += 55
        e.Graphics.DrawString("EASYPAISA    JAZZ CASH    OMINI", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)


        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("GOOGLE PAY    PAYPAL    PLAYSTORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
        e.Graphics.DrawString("APPLE WALLET    XBOX      PS STORE", H4_fnt, Brushes.Black, XAXIS - 20, YAXIS)
        YAXIS += 25
        YAXIS2 += 25
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

    Private Sub CASH_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles CASH_OPT.CheckedChanged
        CREDITOR_PANEL.BackColor = Color.OldLace

    End Sub

    Private Sub CREDIT_OPT_CheckedChanged(sender As Object, e As EventArgs) Handles CREDIT_OPT.CheckedChanged
        CREDITOR_PANEL.BackColor = Color.OldLace
    End Sub

    Private Sub CREDITORS_BTN_Click(sender As Object, e As EventArgs) Handles CREDITORS_BTN.Click
        CONTACTS_FRM.ShowDialog()
        'CONTACTS_FRM.CLOSE_BTN.Text = "Select"
        Call GET_CREDITORS_LIST()


    End Sub
    Sub GET_CREDITORS_LIST()
        Dim CUSTOMER_ARRAY As String = ""
        Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
        Dim cmd As New MySqlCommand("Select * from `CONTACTS`;", CON)
        Dim da As New MySqlDataAdapter("Select * from `CONTACTS`;", CON)
        Dim dr As MySqlDataReader
        CON.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read() = True
            If ListBox1.Items.Contains(dr("Name").ToString()) = False Then
                ListBox1.Items.Add(dr("Name").ToString())
            End If

        Loop

        Dim elements(ListBox1.Items.Count - 1) As String
        ListBox1.Items.CopyTo(elements, 0)
        Dim stringNames As String = String.Join(",", elements)


        'MsgBox(stringNames & " " & UBound(elements))

        CON.Close()



        'SORUCE FOR WORK TYPE NEW BILL
        MySource.AddRange(New String() {"CONSTRUCTION", "STEEL PATI", "BINDING WIRE", "BRICKS", "CEMENT", "CRUSH", "IRON ROD", "TRANSFER SET", "ELECTRICAL WORKS", "PLUMBING WORKS", "CEILING WORKS", "CARPENTARY WORKS", "PAINT WORKS", "TILE WORKS"})

        With CREDITOR_TXT
            .AutoCompleteCustomSource = MySource
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
        End With

    End Sub

    Private Sub CREDIT_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CREDIT_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            TNO_TXT.Select()
            e.Handled = True
        End If
    End Sub

    Private Sub CASH_OPT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CASH_OPT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            TNO_TXT.Select()
            e.Handled = True
        End If
    End Sub
End Class