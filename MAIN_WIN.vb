Imports MySql.Data.MySqlClient
Public Class MAINWIN_FRM

    Private Sub MAINWIN_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim MySQLConnection = New MySqlConnection
            MySQLConnection.ConnectionString = "server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;"
            MySQLConnection.Open()
            ONLINE_STATUS_LBL.Text = "Online!"
        Catch ex As Exception
            ONLINE_STATUS_LBL.Text = "Failed!- " & ex.Message
        End Try

        Try
            LOG_PANNEL.Location = New Point(0, 0)
            LOG_PANNEL.Size = New Size(806, 674)
            LOG_TXT.Size = New Size(794, 370)

            PB1.Value += 10
            LOG_TXT.Text = "Loading...."
            DATABASE_CHK()
            Dim CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
            CON.Open()



        Catch myerror As MySqlException
            LOADBAR_TIMER.Enabled = False
            Label1.Text = "ERROR LOADING"
            DB_ERR_PANNEL.Location = New Point(208, 29)
            DB_ERR_PANNEL.Visible = True


            Timer1.Enabled = True
            LOG_TXT.Text &= Environment.NewLine & "> MYSQL SERVER NOT FOUND OR NOT CONFIGURE PROPERLY PLEASE INSTALL LATEST MYSQL SERVER OR CONTACT VENDOR FOR ASSISTANCE " & Environment.NewLine & "> Vendor: Adil numan - Airtech IT HUB" _
                & Environment.NewLine & "> Mob:0333-3171787" & Environment.NewLine & myerror.Message
            'Dim MSGB = MessageBox.Show("MYSQL SERVER NOT FOUND OR NOT CONFIGURE PROPERLY PLEASE INSTALL LATEST MYSQL SERVER OR CONTACT VENDOR FOR ASSISTANCE " & Environment.NewLine & "Adil numan - Airtech IT HUB" & Environment.NewLine & "Mob:0333-3171787" & Environment.NewLine & myerror.Message, "DATABASE SERVER NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    Sub LOAD_EVENTS()

        PB1.Value += 10
        TABLES_CHK_TRANS_ID()
        PB1.Value += 10
        TABLES_CHK_CONTACTS()
        PB1.Value += 10
        Call TABLES_CHK_CREDIT_HISTORY()
        PB1.Value += 10
        Timer1.Enabled = True
    End Sub


    Private Sub EASYPAISA_BTN_Click(sender As Object, e As EventArgs) Handles EASYPAISA_BTN.Click
        With EASYPAISA_FRM
            .Show()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        With LOG_PANNEL
            .Visible = False
            .Enabled = False
        End With

        If DB_ERR_PANNEL.Visible = True Then
            LOG_PANNEL.Location = New Point(3, 252)
            LOG_PANNEL.Size = New Size(806, 324)
            LOG_TXT.Size = New Size(794, 216)
            LOG_PANNEL.Visible = True
            LOG_PANNEL.Enabled = True
            LOG_PANNEL.BackColor = Color.Red
        End If
    End Sub

    Private Sub LOGO_PIC_2_Click(sender As Object, e As EventArgs) Handles LOGO_PIC_2.Click
        If LOG_PANNEL.Visible = False Then
            LOG_PANNEL.Visible = True
            LOG_PANNEL.Enabled = True
        Else
            LOG_PANNEL.Visible = False
            LOG_PANNEL.Enabled = False
        End If
    End Sub



    Function DoesDBExist(DBConnectionString As String) As Boolean
        Dim IDK As Boolean
        Try
            Dim conn As MySqlConnection = New MySqlConnection(DBConnectionString)
            Dim cmd As MySqlCommand = New MySqlCommand("Select If(EXISTS(SELECT SCHEMA_NAME " &
            "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @DbName), 'Y','N')", conn)
            cmd.Parameters.AddWithValue("@DbName", "e9Vjw3hs9v")
            conn.Open()
            Dim exists As String = cmd.ExecuteScalar().ToString()
            Console.WriteLine(exists)
            conn.Close()
            IDK = If(exists = "Y", True, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return IDK
    End Function
    Public Function DoesTABLEExist(DBConnectionString As String, TABLE_NAME As String) As Boolean
        Dim aRet As Boolean
        Try
            Dim conn As MySqlConnection = New MySqlConnection(DBConnectionString)
            Dim cmd As New MySqlCommand("Select * From information_schema.tables Where table_schema = 'e9Vjw3hs9v' And table_name ='" & TABLE_NAME & "' LIMIT 1;", conn)


            conn.Open()
            Dim bRet As Boolean = False
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            bRet = reader.HasRows
            If (bRet = True) Then
                'MsgBox("Table Exists")
            Else
                ' MsgBox("No more records")
            End If
            conn.Close()
            aRet = bRet

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return aRet
    End Function
    Sub DATABASE_CHK()
        Dim DB_POST_CREATION As Boolean
        DB_POST_CREATION = False
        Try
            LOG_TXT.Text &= Environment.NewLine & Environment.NewLine & ">" & "DATABASE EXISTS: " & DoesDBExist("server=localhost; username=root; password=Masoom1;")
            If DoesDBExist("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;") = False Then
                Using CON As New MySqlConnection("server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;")
                    Using adapter As New MySqlDataAdapter("CREATE SCHEMA `e9Vjw3hs9v` ;", CON)
                        CON.Open()
                        Dim dt As New DataTable
                        adapter.Fill(dt)
                        DB_POST_CREATION = True
                        CON.Close()
                    End Using
                End Using
            End If
            LOG_TXT.Text &= Environment.NewLine & ">" & "DATABASE CREATED: " & DB_POST_CREATION & Environment.NewLine
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub TABLES_CHK_TRANS_ID()
        Dim CON_STRING As String
        Dim CUR_TABLE As String = "TRANS_ID"
        CON_STRING = "server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;"
        Try
            LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " TABLES EXISTS: " & DoesTABLEExist(CON_STRING, CUR_TABLE)
            If DoesTABLEExist(CON_STRING, CUR_TABLE) = False Then
                Using CON As New MySqlConnection(CON_STRING)
                    Using adapter As New MySqlDataAdapter("CREATE TABLE `e9Vjw3hs9v`.`" & CUR_TABLE & "`(" &
                "`TID` INT Not NULL AUTO_INCREMENT,`MOBILE` VARCHAR(255) NULL,`NAME` VARCHAR(255) NULL,`AMOUNT` VARCHAR(255) NULL," &
                "`TRAN_NO` VARCHAR(255) NULL,`DATE` VARCHAR(255) NULL,`REMARKS` VARCHAR(255) NULL," &
                "PRIMARY KEY(`TID`))", CON)
                        CON.Open()
                        Dim dt As New DataTable
                        adapter.Fill(dt)
                        CON.Close()
                    End Using
                End Using
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: " & DoesTABLEExist(CON_STRING, CUR_TABLE) & Environment.NewLine
            Else
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: False" & Environment.NewLine
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TABLES_CHK_CONTACTS()
        Dim CON_STRING As String
        Dim CUR_TABLE As String = "CONTACTS"
        CON_STRING = "server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;"
        Try
            LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " TABLES EXISTS: " & DoesTABLEExist(CON_STRING, CUR_TABLE)
            If DoesTABLEExist(CON_STRING, CUR_TABLE) = False Then
                Using CON As New MySqlConnection(CON_STRING)
                    Using adapter As New MySqlDataAdapter("CREATE TABLE `e9Vjw3hs9v`.`" & CUR_TABLE & "`(" &
                "`CID` INT Not NULL AUTO_INCREMENT,`MOBILE` VARCHAR(255) NULL,`NAME` VARCHAR(255) NULL,`BALANCE` VARCHAR(255) NULL," &
                "`OTHERS` VARCHAR(255) NULL,`DATE` VARCHAR(255) NULL,`REMARKS` VARCHAR(255) NULL," &
                "PRIMARY KEY(`CID`))", CON)
                        CON.Open()
                        Dim dt As New DataTable
                        adapter.Fill(dt)
                        CON.Close()
                    End Using
                End Using
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: " & DoesTABLEExist(CON_STRING, CUR_TABLE) & Environment.NewLine
            Else
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: False" & Environment.NewLine
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub TABLES_CHK_CREDIT_HISTORY()
        Dim CON_STRING As String
        Dim CUR_TABLE As String = "CREDIT_HISTORY"
        CON_STRING = "server=remotemysql.com; port=3306; username=e9Vjw3hs9v; password=Wlu4PLbgfy; database = e9Vjw3hs9v;"
        Try
            LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " TABLES EXISTS: " & DoesTABLEExist(CON_STRING, CUR_TABLE)
            If DoesTABLEExist(CON_STRING, CUR_TABLE) = False Then
                Using CON As New MySqlConnection(CON_STRING)
                    Using adapter As New MySqlDataAdapter("CREATE TABLE `e9Vjw3hs9v`.`" & CUR_TABLE & "`(" &
                "`ID` INT Not NULL AUTO_INCREMENT,`MOBILE` VARCHAR(255) NULL,`NAME` VARCHAR(255) NULL,`BALANCE` VARCHAR(255) NULL," &
                "`AMOUNT` VARCHAR(255) NULL,`DATE` VARCHAR(255) NULL,`REMARKS` VARCHAR(255) NULL," &
                "PRIMARY KEY(`ID`))", CON)
                        CON.Open()
                        Dim dt As New DataTable
                        adapter.Fill(dt)
                        CON.Close()
                    End Using
                End Using
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: " & DoesTABLEExist(CON_STRING, CUR_TABLE) & Environment.NewLine
            Else
                LOG_TXT.Text &= Environment.NewLine & ">" & UCase(CUR_TABLE) & " -TABLES CREATED: False" & Environment.NewLine
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub LOADBAR_TIMER_Tick(sender As Object, e As EventArgs) Handles LOADBAR_TIMER.Tick
        LOADBAR_TIMER.Enabled = False
        Call LOAD_EVENTS()
    End Sub

    Private Sub SALES_BTN_Click(sender As Object, e As EventArgs) Handles SALES_BTN.Click
        SALES_REPORT_FRM.Show()
    End Sub

    Private Sub JAZZCASH_BTN_Click(sender As Object, e As EventArgs) Handles JAZZCASH_BTN.Click
        JAZZ_CASH_FRM.Show()
    End Sub

    Private Sub MOBILE_LOAD_BTN_Click(sender As Object, e As EventArgs) Handles MOBILE_LOAD_BTN.Click
        MOBILE_LOAD_FRM.Show()
    End Sub

    Private Sub TIME_DATE_Tick(sender As Object, e As EventArgs) Handles TIME_DATE.Tick
        TIME_LBL.Text = Now.ToString("hh:mm:ss")
        DATE_LBL.Text = Today.ToString("dd-MMM-yyyy")

    End Sub

    Private Sub CONTACTS_BTN_Click(sender As Object, e As EventArgs) Handles CONTACTS_BTN.Click
        CONTACTS_FRM.Show()
    End Sub

End Class
