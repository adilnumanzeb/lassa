Imports MySql.Data.MySqlClient
Public Class CONTACTS_FRM
    Private Sub CONTACTS_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call RESIZE_ME_PANEL()
        If MAINWIN_FRM.Label1.Text = "ERROR LOADING" Then
            Exit Sub
        End If
        Call GET_CUS_ID()
        Call GET_CREDITORS_HISTORY()
        Call GET_CREDITORS_HISTORY()
        Call GET_CONTACT_LIST()
        CUSTOMER_NAME_TXT.Select()
    End Sub
    Sub RESIZE_ME_PANEL()
        Panel1.Location = New Point((Me.Width - Panel1.Width) \ 2, (Me.Height - Panel1.Height) \ 2)
    End Sub
    Sub GET_CONTACT_LIST()
        Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
        Dim cmd As New MySqlCommand("Select * from `CONTACTS`;", CON)
        Dim da As New MySqlDataAdapter("Select * from `CONTACTS`;", CON)
        Dim dT As New DataTable
        CON.Open()
        da.SelectCommand = cmd
        da.Fill(dT)
        DGV_CONTACT_LIST.DataSource = dT
        CON.Close()
        DGV_CONTACT_LIST.Columns(0).Width = 30
        DGV_CONTACT_LIST.Columns(0).HeaderText = "ID"
    End Sub
    Sub GET_CREDITORS_HISTORY()

        Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
        Dim cmd As New MySqlCommand("Select * from `CREDIT_HISTORY`;", CON)
        Dim da As New MySqlDataAdapter("Select * from `CREDIT_HISTORY`;", CON)
        Dim dT As New DataTable
        CON.Open()
        da.SelectCommand = cmd
        da.Fill(dT)
        DGV_CREDIT.DataSource = dT
        CON.Close()
    End Sub
    Private Sub ADD_BTN_Click(sender As Object, e As EventArgs) Handles ADD_BTN.Click

        Call ADD_CONTACT_CMD()
        CUS_ID_TXT.Text = ""
        MOBILENO_TXT.Text = ""
        CUSTOMER_NAME_TXT.Text = ""
        Call GET_CUS_ID()
        CUSTOMER_NAME_TXT.Select()
    End Sub
    Sub GET_CUS_ID()
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("SELECT * FROM `CONTACTS` ORDER BY `CID` desc LIMIT 1; ", con)
                Using da As New MySqlDataAdapter
                    Dim DR As MySqlDataReader
                    Dim DB_CUS_ID As Integer
                    con.Open()
                    da.SelectCommand = cmd
                    DR = cmd.ExecuteReader
                    If DR.HasRows Then
                        DR.Read()
                        DB_CUS_ID = Int(DR("CID").ToString) + 1
                    Else
                        DB_CUS_ID = 1
                    End If
                    CUS_ID_TXT.Text = DB_CUS_ID
                    con.Close()
                End Using
            End Using
        End Using
    End Sub



    Sub ADD_CONTACT_CMD()
        'Using DR USING DATA CONNECTION
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("SELECT * FROM `CONTACTS` WHERE 'MOBILE'='" & MOBILENO_TXT.Text & "'; ", con)
                Using da As New MySqlDataAdapter
                    Dim DR As MySqlDataReader
                    con.Open()
                    da.SelectCommand = cmd
                    DR = cmd.ExecuteReader
                    If DR.HasRows Then
                        MOB_ERR_LBL.Text = "MOBILE-NO ALREADY IN RECORDS"
                    Else
                        Call ADD_NEW_CONTACT()
                    End If


                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Sub ADD_NEW_CONTACT()
        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("INSERT INTO `CONTACTS` VALUES (NULL,'" & MOBILENO_TXT.Text & "','" & CUSTOMER_NAME_TXT.Text & "','0','" & MOBILENO_TXT.Text & "','" & Date.Today.ToString("dd-MM-yyyy") & "','N/A');", con)
                Using da As New MySqlDataAdapter
                    con.Open()
                    da.SelectCommand = cmd
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Sub UPDATE_EXISTING_CONTACT()

    End Sub

    Private Sub ERR_TIMER_Tick(sender As Object, e As EventArgs) Handles ERR_TIMER.Tick
        With MOB_ERR_LBL
            .Visible = False
            .Text = ""
        End With
        ERR_TIMER.Enabled = False



    End Sub


    Private Sub MOB_ERR_LBL_TextChanged(sender As Object, e As EventArgs) Handles MOB_ERR_LBL.TextChanged
        With MOB_ERR_LBL
            .Visible = True
            ERR_TIMER.Enabled = True
        End With
    End Sub

    Private Sub NAME_TXT_TextChanged(sender As Object, e As EventArgs) Handles CUSTOMER_NAME_TXT.TextChanged

    End Sub

    Private Sub NAME_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CUSTOMER_NAME_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub MOBILENO_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MOBILENO_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub NAME_TXT_GotFocus(sender As Object, e As EventArgs) Handles CUSTOMER_NAME_TXT.GotFocus

        With CUSTOMER_NAME_TXT
            .BackColor = Color.NavajoWhite
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub NAME_TXT_LostFocus(sender As Object, e As EventArgs) Handles CUSTOMER_NAME_TXT.LostFocus
        With CUSTOMER_NAME_TXT
            .BackColor = Color.White
            .ForeColor = Color.Black
        End With
    End Sub

    Private Sub MOBILENO_TXT_TextChanged(sender As Object, e As EventArgs) Handles MOBILENO_TXT.TextChanged

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

    Private Sub CONTACTS_FRM_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub CONTACTS_FRM_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call RESIZE_ME_PANEL()
    End Sub

    Private Sub CLOSE_BTN_Click(sender As Object, e As EventArgs) Handles CLOSE_BTN.Click
        Me.Close()
    End Sub

    Private Sub NAME_LBL_Click(sender As Object, e As EventArgs) Handles NAME_LBL.Click

    End Sub

    Private Sub NAME_LBL_TextChanged(sender As Object, e As EventArgs) Handles NAME_LBL.TextChanged
        NAME_LBL.Visible = True
    End Sub

    Private Sub MOBILE_NO_LBL_Click(sender As Object, e As EventArgs) Handles MOBILE_NO_LBL.Click

    End Sub

    Private Sub MOBILE_NO_LBL_TextChanged(sender As Object, e As EventArgs) Handles MOBILE_NO_LBL.TextChanged
        MOBILE_NO_LBL.Visible = True
    End Sub

    Private Sub BALANCE_LBL_Click(sender As Object, e As EventArgs) Handles BALANCE_LBL.Click

    End Sub

    Private Sub BALANCE_LBL_TextChanged(sender As Object, e As EventArgs) Handles BALANCE_LBL.TextChanged
        BALANCE_LBL.Visible = True
    End Sub

    Private Sub SEARCH_BTN_Click(sender As Object, e As EventArgs) Handles SEARCH_BTN.Click

        If UCase(SEARCH_TYPE_COMBO.Text) = "CUSTOMER ID" Then
            SEARCH_QUERY_CMD("CID", SEARCH_TXT.Text)
        ElseIf UCase(SEARCH_TYPE_COMBO.Text) = "MOBILE NO" Then
            SEARCH_QUERY_CMD("MOBILE", SEARCH_TXT.Text)
        ElseIf UCase(SEARCH_TYPE_COMBO.Text) = "NAME" Then
            SEARCH_QUERY_CMD("NAME", SEARCH_TXT.Text)

            'ElseIf UCase(SEARCH_TYPE_COMBO.Text) <> "CUSTOMER ID" Or SEARCH_TYPE_COMBO.Text <> "MOBILE" Or SEARCH_TYPE_COMBO.Text <> "NAME" Then
            'MsgBox("PLEASE SELECT CORRECT SEARCH TEXT")
        End If
    End Sub
    Sub SEARCH_QUERY_CMD(SERACH_TYPE As String, SEARCH_QUERY_STRING As String)
        If SERACH_TYPE = "CONTACT_LIST_SEARCH" Then
            Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Dim cmd As New MySqlCommand("Select * from `CONTACTS`WHERE `NAME` LIKE '" & SEARCH_QUERY_STRING & "%';", CON)
            Dim da As New MySqlDataAdapter("Select * from `CONTACTS`WHERE `NAME` LIKE '" & SEARCH_QUERY_STRING & "%';", CON)
            Dim dT As New DataTable
            CON.Open()
            da.SelectCommand = cmd
            da.Fill(dT)
            DGV_CONTACT_LIST.DataSource = dT
            CON.Close()
            DGV_CONTACT_LIST.Columns(0).Width = 30
            DGV_CONTACT_LIST.Columns(0).HeaderText = "ID"
            Exit Sub
        End If


        Using con As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            Using cmd As New MySqlCommand("SELECT * FROM `CONTACTS` WHERE `" & LCase(SERACH_TYPE) & "` LIKE '" & LCase(SEARCH_QUERY_STRING) & "%'; ", con)
                Using da As New MySqlDataAdapter
                    Dim DR As MySqlDataReader, dt As New DataTable
                    con.Open()
                    da.SelectCommand = cmd
                    da.Fill(dt)
                    DR = cmd.ExecuteReader
                    If dt.Rows.Count > 1 Then
                        Do While DR.Read = True
                            NAME_LIST.Items.Add(DR("MOBILE").ToString)
                            LIST_Panel.Enabled = True
                            LIST_Panel.Visible = True
                            LIST_NAME_LBL.Text = SEARCH_TXT.Text
                        Loop
                        NAME_LIST.Visible = True
                    End If

                    If DR.HasRows Then
                        DR.Read()
                        NAME_LBL.Text = DR("NAME").ToString

                        MOBILE_NO_LBL.Text = DR("MOBILE").ToString

                        BALANCE_LBL.Text = DR("BALANCE").ToString
                    Else
                        NAME_LBL.Text = "NO RECORDS"

                        MOBILE_NO_LBL.Text = "NO RECORDS"

                        BALANCE_LBL.Text = "NO RECORDS"
                    End If
                    con.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub SEARCH_TXT_TextChanged(sender As Object, e As EventArgs) Handles SEARCH_TXT.TextChanged

    End Sub

    Private Sub SEARCH_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SEARCH_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SEARCH_BTN.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub CUS_ID_TXT_TextChanged(sender As Object, e As EventArgs) Handles CUS_ID_TXT.TextChanged

    End Sub

    Private Sub NAME_LIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NAME_LIST.SelectedIndexChanged
        LIST_NAME_LBL.Text = SEARCH_TXT.Text
    End Sub

    Private Sub NAME_LIST_DoubleClick(sender As Object, e As EventArgs) Handles NAME_LIST.DoubleClick
        SEARCH_QUERY_CMD("NAME", SEARCH_TXT.Text)
        LIST_Panel.Visible = False
        LIST_Panel.Enabled = False
    End Sub

    Private Sub CONTACT_LIST_SEARCH_BTN_Click(sender As Object, e As EventArgs) Handles CONTACT_LIST_SEARCH_BTN.Click
        SEARCH_QUERY_CMD("CONTACT_LIST_SEARCH", CONTACT_LIST_SEARCH_TXT.Text)
    End Sub

    Private Sub CONTACT_LIST_SEARCH_TXT_TextChanged(sender As Object, e As EventArgs) Handles CONTACT_LIST_SEARCH_TXT.TextChanged
        If CONTACT_LIST_SEARCH_TXT.Text = "" Then
            Call GET_CONTACT_LIST()
        Else
            Call SEARCH_QUERY_CMD("CONTACT_LIST_SEARCH", CONTACT_LIST_SEARCH_TXT.Text)
        End If
    End Sub
End Class