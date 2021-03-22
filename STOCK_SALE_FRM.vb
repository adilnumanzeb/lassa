Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class STOCK_SALE_FRM

    Public SALE_AMOUNT As Decimal, TOTAL_AM0UNT As Decimal
    Public VALIDATION_CHK_ERROR_SALES As Boolean, RESET_CALL As Boolean
    Dim SALE_SERIAL As Integer
    Private Sub SALES_FRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        ITEM_CODE_TXT.Select()
    End Sub
    Private Sub ITEM_CODE_TXT_TextChanged(sender As Object, e As EventArgs) Handles ITEM_CODE_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        ITEM_CODE_TXT.Text = digitsOnly.Replace(ITEM_CODE_TXT.Text, "")

        If ITEM_CODE_TXT.Text <> "" Then
            ITEM_NAME_TXT.Text = GET_ITEM_NAME_BY_CODE(ITEM_CODE_TXT.Text)
        End If

    End Sub
    Function GET_ITEM_NAME_BY_CODE(ITEM_CODE As Double)
        'RETRIVE QUANTITY TO ADD
        Dim ITEM_NAME_DB As String
        Dim CON As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
        Dim cmd As New MySqlCommand("Select * from `STOCK` WHERE `ITEM_CODE`=" & ITEM_CODE & ";", CON)
        Dim da As New MySqlDataAdapter("Select * from `STOCK`WHERE `ITEM_CODE`=" & ITEM_CODE & ";", CON)
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        CON.Open()
        da.Fill(ds)
        dr = cmd.ExecuteReader
        Do While dr.Read() = True
            If dr.HasRows Then
                ITEM_NAME_DB = dr("ITEM_NAME").ToString()

            End If
        Loop
        CON.Close()
        Return ITEM_NAME_DB
    End Function
    Private Sub ITEM_CODE_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ITEM_CODE_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ITEM_NAME_TXT_TextChanged(sender As Object, e As EventArgs) Handles ITEM_NAME_TXT.TextChanged

    End Sub

    Private Sub ITEM_NAME_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ITEM_NAME_TXT.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub QUANTITY_TXT_TextChanged(sender As Object, e As EventArgs) Handles QUANTITY_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        QUANTITY_TXT.Text = digitsOnly.Replace(QUANTITY_TXT.Text, "")
    End Sub

    Private Sub QUANTITY_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QUANTITY_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub PRICE_TXT_TextChanged(sender As Object, e As EventArgs) Handles PRICE_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        PRICE_TXT.Text = digitsOnly.Replace(PRICE_TXT.Text, "")
    End Sub

    Private Sub PRICE_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PRICE_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            Call ADD_ITEM_CMD()
            ADD_TO_STOCK_BTN.Enabled = True
            ITEM_CODE_TXT.Select()
        End If

    End Sub
    Sub ADD_ITEM_CMD()
        Dim DATE1 As Date = Date.Today
        SALE_SERIAL += 1
        Call VALIDATION_CHK_SALES()
        If VALIDATION_CHK_ERROR_SALES = True Then Exit Sub
        With DGV_ITEMS
            .Rows.Add(SALE_SERIAL, ITEM_CODE_TXT.Text, QUANTITY_TXT.Text, ITEM_NAME_TXT.Text, PRICE_TXT.Text, DATE1.ToString("dd/MM/yyyy"))
        End With
        TOTAL_AM0UNT += SALE_AMOUNT
        'TOTAL_LBL.Text = TOTAL_AM0UNT
        'SUBTOTAL_LBL.Text = TOTAL_AM0UNT
        ITEM_CODE_TXT.Text = ""
        ITEM_NAME_TXT.Text = ""
        QUANTITY_TXT.Text = ""
        PRICE_TXT.Text = ""
        VALIDATION_CHK_ERROR_SALES = False
    End Sub

    Private Sub ADD_TO_STOCK_BTN_Click(sender As Object, e As EventArgs) Handles ADD_TO_STOCK_BTN.Click
        'DO WHAT EVER U WANT
        Call ADD_DATA_TO_DB_CMD()
        DGV_ITEMS.Rows.Clear()
        ADD_TO_STOCK_BTN.Enabled = False
    End Sub

    Sub VALIDATION_CHK_SALES()
        If IsNumeric(PRICE_TXT.Text) = False Then
            MsgBox("Please enter valid price")
            VALIDATION_CHK_ERROR_SALES = True
            PRICE_TXT.Select()
        End If

        If IsNumeric(QUANTITY_TXT.Text) = False Then
            MsgBox("Please enter valid quantity")
            VALIDATION_CHK_ERROR_SALES = True
            QUANTITY_TXT.Select()
        End If


    End Sub



    Sub ADD_DATA_TO_DB_CMD()
        For Each row As DataGridViewRow In DGV_ITEMS.Rows
            Dim ITEM_CODE_VAL = row.Cells(1).Value
            Dim ITEM_QUANTITY_VAL = row.Cells(2).Value
            Dim ITEM_NAME_VAL = row.Cells(3).Value
            Dim ITEM_PRICE_VAL = row.Cells(4).Value
            Dim ITEM_DATE_VAL = row.Cells(5).Value
            If row.Cells(1).Value <> "" Then
                'FOR CHECK IF SUPPLIER ALL READY EXISTS
                Dim CON1 As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
                Dim CMD1 As New MySqlCommand("SELECT * FROM `STOCK` where `ITEM_CODE`='" & row.Cells(1).Value & "';", CON1)
                Dim dt1 As New DataTable
                Dim DR1 As MySqlDataReader
                CON1.Open()
                dt1.Clear()
                With dt1
                    DR1 = CMD1.ExecuteReader
                    If DR1.HasRows = True Then
                        MsgBox("Supplier already exists")
                        Call ADD_DATA_TO_EXISTING_RECORD(ITEM_CODE_VAL, ITEM_QUANTITY_VAL)
                        Exit Sub
                    Else
                        Dim constring As String = "server=localhost; user=root; password=Masoom1; database=airtech_db; convert zero datetime=true;"
                        Using con As New MySqlConnection(constring)
                            Using cmd As New MySqlCommand("Insert into `stock` values(null,@ITEM_CODE,@ITEM_NAME,@ITEM_PRICE,@ITEM_QUANTITY,@STOCK_DATE);", con)
                                cmd.Parameters.AddWithValue("@ITEM_CODE", row.Cells(1).Value)
                                cmd.Parameters.AddWithValue("@ITEM_NAME", row.Cells(3).Value)
                                cmd.Parameters.AddWithValue("@ITEM_PRICE", row.Cells(4).Value)
                                cmd.Parameters.AddWithValue("@ITEM_QUANTITY", row.Cells(2).Value)
                                cmd.Parameters.AddWithValue("@STOCK_DATE", row.Cells(5).Value)
                                con.Open()
                                cmd.ExecuteNonQuery()
                                con.Close()
                            End Using
                        End Using
                        MsgBox("New Record inserted.")
                    End If
                End With
            End If
        Next
    End Sub


    Sub ADD_DATA_TO_EXISTING_RECORD(ITEM_CODE As Integer, ITEM_QUANTITY As Integer)
        Dim DB_QUANTITY As Integer, NEW_QUANTITY As Integer
        'RETRIVE QUANTITY TO ADD
        Dim CON As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
        Dim cmd As New MySqlCommand("Select * from `STOCK` WHERE `ITEM_CODE`=" & ITEM_CODE & ";", CON)
        Dim da As New MySqlDataAdapter("Select * from `STOCK`WHERE `ITEM_CODE`=" & ITEM_CODE & ";", CON)
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        CON.Open()
        da.Fill(ds)
        dr = cmd.ExecuteReader
        Do While dr.Read() = True
            DB_QUANTITY = dr("ITEM_QUANTITY").ToString()
        Loop
        CON.Close()
        NEW_QUANTITY = ITEM_QUANTITY + DB_QUANTITY
        Using con2 As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
            Using cmd2 As New MySqlCommand("UPDATE `STOCK` SET `ITEM_QUANTITY` = '" & NEW_QUANTITY & "' WHERE (`ITEM_CODE` = '" & ITEM_CODE & "');", con2)
                con2.Open()
                cmd2.ExecuteNonQuery()
                con2.Close()
            End Using
        End Using
    End Sub


End Class