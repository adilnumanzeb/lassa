Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class SALES_FRM
    Dim SALE_AMOUNT As Decimal, TOTAL_AM0UNT As Decimal
    Dim VALIDATION_CHK_ERROR_SALES As Boolean, RESET_CALL As Boolean
    Dim SALE_SERIAL As Integer, DGV_CALL As Boolean
    Private Sub SALES_FRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        ITEM_CODE_TXT.Select()
        Call GET_STOCK_SEARCH_LIST()
    End Sub
    Sub GET_STOCK_SEARCH_LIST()
        Dim CON As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
        Dim cmd As New MySqlCommand("Select * from `STOCK` ;", CON)
        Dim da As New MySqlDataAdapter("Select * from `STOCK`;", CON)
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        CON.Open()
        da.Fill(ds, "STYLE")
        dr = cmd.ExecuteReader
        Do While dr.Read() = True
            If dr.HasRows Then
                '        ITEM_NAME_DB = dr("ITEM_NAME").ToString()
            End If
        Loop

        For I = 0 To UBound(GET_ITEM_NAME_FOR_SEARCH_LIST)
            STOCK_SEARCH_COMBO.Items.Add(GET_ITEM_NAME_FOR_SEARCH_LIST(I))
        Next
        STOCK_SEARCH_COMBO.AutoCompleteSource = AutoCompleteSource.ListItems
        STOCK_SEARCH_COMBO.AutoCompleteMode = AutoCompleteMode.Append
    End Sub
    Private Sub ITEM_CODE_TXT_TextChanged(sender As Object, e As EventArgs) Handles ITEM_CODE_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        ITEM_CODE_TXT.Text = digitsOnly.Replace(ITEM_CODE_TXT.Text, "")
        If ITEM_CODE_TXT.Text <> "" Then
            Call GET_ITEM_NAME_BY_CODE(ITEM_CODE_TXT.Text)
        End If
    End Sub

    Private Sub ITEM_CODE_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ITEM_CODE_TXT.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            If ITEM_CODE_TXT.Text = "" Then
                STOCK_SEARCH_COMBO.Select()
            Else
                SendKeys.Send("{TAB}")
            End If
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

    Private Sub PRICE_TXT_TextChanged(sender As Object, e As EventArgs) Handles ITEM_PRICE_TXT.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        ITEM_PRICE_TXT.Text = digitsOnly.Replace(ITEM_PRICE_TXT.Text, "")
    End Sub

    Private Sub PRICE_TXT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ITEM_PRICE_TXT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" Then
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True
            Call ADD_ITEM_CMD()
            ITEM_CODE_TXT.Select()
        End If

    End Sub
    Sub ADD_ITEM_CMD()
        SALE_SERIAL += 1
        Call VALIDATION_CHK_SALES()
        If VALIDATION_CHK_ERROR_SALES = True Then Exit Sub
        With DGV_ITEMS
            SALE_AMOUNT = (QUANTITY_TXT.Text * ITEM_PRICE_TXT.Text)
            .Rows.Add(SALE_SERIAL, QUANTITY_TXT.Text, ITEM_NAME_TXT.Text, ITEM_PRICE_TXT.Text, SALE_AMOUNT)
        End With
        TOTAL_AM0UNT += SALE_AMOUNT
        TOTAL_LBL.Text = "PKR " & FormatNumber(TOTAL_AM0UNT, 0, TriState.False, , TriState.True)
        SUBTOTAL_LBL.Text = "PKR " & FormatNumber(TOTAL_AM0UNT, 0, TriState.False, , TriState.True)
        ITEM_CODE_TXT.Text = ""
        ITEM_NAME_TXT.Text = ""
        QUANTITY_TXT.Text = ""
        ITEM_PRICE_TXT.Text = ""
        STOCK_SEARCH_COMBO.Text = ""
        DGV_SEARCH.Enabled = False
        DGV_SEARCH.Visible = False
        VALIDATION_CHK_ERROR_SALES = False
    End Sub
    Sub VALIDATION_CHK_SALES()
        If IsNumeric(ITEM_PRICE_TXT.Text) = False Then
            MsgBox("Please enter valid price")
            VALIDATION_CHK_ERROR_SALES = True
            ITEM_PRICE_TXT.Select()
        End If

        If IsNumeric(QUANTITY_TXT.Text) = False Then
            MsgBox("Please enter valid quantity")
            VALIDATION_CHK_ERROR_SALES = True
            QUANTITY_TXT.Select()
        End If


    End Sub

    Private Sub PAID_BTN_Click(sender As Object, e As EventArgs) Handles PAID_BTN.Click
        CASH_Panel.Visible = False
        CASH_Panel.Enabled = False
        TOTAL_LBL.Text = ""
        SUBTOTAL_LBL.Text = ""
        TAX_LBL.Text = ""
        STOCK_SEARCH_COMBO.Text = ""
        TextBox1.Text = ""
        DGV_ITEMS.Rows.Clear()
    End Sub

    Private Sub STOCKS_BTN_Click(sender As Object, e As EventArgs) Handles STOCKS_BTN.Click
        STOCK_SALE_FRM.TopMost = True
        STOCK_SALE_FRM.Show()

    End Sub

    Private Sub PAYMENT_BTN_Click(sender As Object, e As EventArgs) Handles PAYMENT_BTN.Click
        CASH_Panel.Visible = True
        CASH_Panel.Enabled = True
        PAY_TOTAL_LBL.Text = TOTAL_LBL.Text
        CASH_TXT.Select()
        Exit Sub
        ADD_DATA_TO_DB_CMD()
    End Sub

    Private Sub CASH_TXT_TextChanged(sender As Object, e As EventArgs) Handles CASH_TXT.TextChanged
        Try
            Dim digitsOnly As Regex = New Regex("[^\d]")
            Dim CASH_AMT2 As Decimal
            CASH_AMT2 = digitsOnly.Replace(CASH_TXT.Text, "")
            CASH_TXT.Text = "PKR " & FormatNumber(CASH_AMT2, 0, TriState.False, , TriState.True)
            With CASH_TXT
                .SelectionStart = .Text.Length
                .ScrollToCaret()
            End With

            Dim CASH_AMT As Decimal, TOTAL_AMT As Decimal, CHANGE_AMT As Decimal
            CASH_AMT = digitsOnly.Replace(CASH_TXT.Text, "")
            TOTAL_AMT = digitsOnly.Replace(PAY_TOTAL_LBL.Text, "")
            CHANGE_AMT = CASH_AMT - TOTAL_AMT
            CHANGE_LBL.Text = CHANGE_AMT
        Catch ex As Exception

        End Try
    End Sub

    Sub ADD_DATA_TO_DB_CMD()
        ' For Each row As DataGridViewRow In ALL_BILL_FRM.DataGridView1.Rows
        'If row.Cells(1).Value <> "" Then
        'Dim constring As String = "server=localhost; user=root; password=Masoom1; database=airtech_db; convert zero datetime=true;"
        'Using con As New MySqlConnection(constring)
        'Using cmd As New MySqlCommand("Insert into `all_bills` values(null,@Supplier_Name,@Bill_Details,@Bill_No,@Bill_Type,@Bill_Amount,@Bill_Date,@Project);", con)
        'cmd.Parameters.AddWithValue("@Supplier_Name", row.Cells(1).Value)
        'cmd.Parameters.AddWithValue("@Bill_Details", row.Cells(2).Value)
        'cmd.Parameters.AddWithValue("@Bill_No", row.Cells(3).Value)
        'cmd.Parameters.AddWithValue("@Bill_Type", row.Cells(4).Value)
        'cmd.Parameters.AddWithValue("@Bill_Amount", Int(row.Cells(5).Value))
        'cmd.Parameters.AddWithValue("@Bill_Date", row.Cells(6).Value)
        'cmd.Parameters.AddWithValue("@Project", ALL_BILLS_PROJECT)
        'con.Open()
        'cmd.ExecuteNonQuery()
        'con.Close()
        'End Using
        'End Using
        ''ALL_BILL_FRM.STATUS_LBL.Text = "Records inserted."
        'End If
        'Next
    End Sub

    Private Sub STOCK_SEARCH_COMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles STOCK_SEARCH_COMBO.SelectedIndexChanged

    End Sub
    Private Sub STOCK_SEARCH_COMBO_TextChanged(sender As Object, e As EventArgs) Handles STOCK_SEARCH_COMBO.TextChanged
        If DGV_CALL = True Then
            'MsgBox("NOTHING")
            Exit Sub
        End If
        If STOCK_SEARCH_COMBO.Text = "" Then
            With DGV_SEARCH
                .Enabled = True
                .Visible = True
                Call STOCK_SEARCH_CMD("DEFUALT")
            End With
        Else
            With DGV_SEARCH
                .Enabled = True
                .Visible = True
                Call STOCK_SEARCH_CMD(STOCK_SEARCH_COMBO.Text)
            End With
        End If
    End Sub

    Sub GET_ITEM_NAME_BY_CODE(ITEM_CODE As Double)
        'RETRIVE QUANTITY TO ADD
        Dim ITEM_NAME_DB As String, ITEM_PRICE_DB As String
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
                ITEM_PRICE_DB = dr("ITEM_PRICE").ToString()
                ITEM_NAME_TXT.Text = ITEM_NAME_DB
                ITEM_PRICE_TXT.Text = ITEM_PRICE_DB
            End If
        Loop
        CON.Close()
    End Sub
    Sub GET_ITEM_NAME_BY_NAME(ITEM_NAME As String)
        'RETRIVE QUANTITY TO ADD
        Dim ITEM_NAME_DB As String, ITEM_PRICE_DB As String
        Dim CON As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
        Dim cmd As New MySqlCommand("Select * from `STOCK` WHERE `ITEM_NAME`='" & ITEM_NAME & "';", CON)
        Dim da As New MySqlDataAdapter("Select * from `STOCK` WHERE `ITEM_NAME`='" & ITEM_NAME & "';", CON)
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        CON.Open()
        da.Fill(ds)
        dr = cmd.ExecuteReader
        Do While dr.Read() = True
            If dr.HasRows Then
                ITEM_NAME_DB = dr("ITEM_NAME").ToString()
                ITEM_PRICE_DB = dr("ITEM_PRICE").ToString()
                ITEM_CODE_TXT.Text = dr("ITEM_CODE").ToString()
                ITEM_NAME_TXT.Text = ITEM_NAME_DB
                ITEM_PRICE_TXT.Text = ITEM_PRICE_DB
            End If
        Loop
        CON.Close()
    End Sub
    Function GET_ITEM_NAME_FOR_SEARCH_LIST()
        'RETRIVE QUANTITY TO ADD
        Dim CON As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
        Dim cmd As New MySqlCommand("Select * from `STOCK`;", CON)
        Dim da As New MySqlDataAdapter("Select * from `STOCK`;", CON)
        Dim ds As New DataSet
        Dim dr As MySqlDataReader
        CON.Open()
        da.Fill(ds)
        dr = cmd.ExecuteReader
        Dim ITEM_NAME_DB(ds.Tables(0).Rows.Count - 1) As String
        Dim INDEX As Integer
        Do While dr.Read() = True
            If dr.HasRows Then
                ITEM_NAME_DB(INDEX) = dr("ITEM_NAME").ToString()
                INDEX += 1
            End If
        Loop
        CON.Close()
        Return ITEM_NAME_DB
    End Function



    Private Sub DGV_SEARCH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_SEARCH.CellContentClick
        Dim row As DataGridViewRow = DGV_SEARCH.Rows(e.RowIndex)
        DGV_CALL = True
        ITEM_NAME_TXT.Text = row.Cells(2).Value.ToString
        ITEM_CODE_TXT.Text = row.Cells(1).Value.ToString
        STOCK_SEARCH_COMBO.Text = row.Cells(2).Value.ToString
        With DGV_SEARCH
            .Visible = False
            .Enabled = False
        End With
        DGV_CALL = False
        QUANTITY_TXT.Select()


    End Sub

    Private Sub SALES_BTN_Click(sender As Object, e As EventArgs) Handles SALES_BTN.Click

    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Sub STOCK_SEARCH_CMD(INPUT As String)
        If INPUT = "DEFUALT" Then
            Dim CON2 As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
            Dim da2 As New MySqlDataAdapter("Select * from `STOCK`;", CON2)
            Dim ds2 As New DataSet
            CON2.Open()
            da2.Fill(ds2)
            DGV_SEARCH.DataSource = ds2.Tables(0)
            CON2.Close()
            With DGV_SEARCH
                .Columns(0).Width = 50
                .Columns(1).Width = 100
                .Columns(2).Width = 200
            End With
        Else
            Dim CON1 As New MySqlConnection("server=localhost; username=root; password=Masoom1; database=airtech_db;")
            Dim da1 As New MySqlDataAdapter("Select * from `STOCK` where `ITEM_NAME` LIKE '%" & INPUT & "%';", CON1)
            Dim dT1 As New DataTable
            CON1.Open()
            da1.Fill(dT1)
            DGV_SEARCH.DataSource = dT1
            CON1.Close()
            With DGV_SEARCH
                .Columns(0).Width = 50
                .Columns(1).Width = 100
                .Columns(2).Width = 200
            End With
        End If

    End Sub

    Private Sub STOCK_SEARCH_COMBO_LostFocus(sender As Object, e As EventArgs) Handles STOCK_SEARCH_COMBO.LostFocus
        With DGV_SEARCH
            .Enabled = False
            .Visible = False
        End With
    End Sub

    Private Sub STOCK_SEARCH_COMBO_KeyDown(sender As Object, e As KeyEventArgs) Handles STOCK_SEARCH_COMBO.KeyDown
        If e.KeyCode = Keys.Escape Then
            With DGV_SEARCH
                .Enabled = False
                .Visible = False
            End With
        End If
        If e.KeyCode = Keys.Enter Then
            GET_ITEM_NAME_BY_NAME(STOCK_SEARCH_COMBO.Text)
            QUANTITY_TXT.Select()
        End If
    End Sub

    Private Sub CASH_TXT_KeyDown(sender As Object, e As KeyEventArgs) Handles CASH_TXT.KeyDown
        If e.KeyCode = Keys.Enter Then
            PAID_BTN.Select()
            e.Handled = True
        End If
    End Sub
End Class