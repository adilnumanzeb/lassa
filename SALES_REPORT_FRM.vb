Imports MySql.Data.MySqlClient

Public Class SALES_REPORT_FRM
    Private Sub SALES_REPORT_FRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call GET_DATE_WISE_RECORD()
        Call GET_TOTAL_SALE_REPORT()
    End Sub
    Private Sub DTP_DAILYBOOK_ValueChanged(sender As Object, e As EventArgs) Handles DTP_DAILYBOOK.ValueChanged
        Call GET_DATE_WISE_RECORD()
        Call GET_TOTAL_SALE_REPORT()
    End Sub


    Sub GET_TOTAL_SALE_REPORT()
        Using con As New mySqlConnection("server=localhost; user=root; password=Masoom1; database=easypaisa_db;")
            Using cmd As New MySqlCommand("select * from `TRANS_ID` where `date` <= NOW() AND '" & DTP_DAILYBOOK.Value.ToString("dd-MMM-yyyy") & "' order by `date` desc;", con)
                Using dt As New DataTable
                    Using DA As New MySqlDataAdapter
                        con.Open()
                        DA.SelectCommand = cmd
                        DA.Fill(dt)
                        DataGridView1.DataSource = dt
                        Dim a_int As Integer = 0

                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If row.Cells(2).Value <> "" Then
                                a_int += Int(row.Cells(2).Value)
                            End If
                        Next
                        TOTAL_SALE_TXT.Text = a_int
                        con.Close()
                    End Using
                End Using
            End Using
        End Using


    End Sub

    Private Sub DAILYBOOK_PRE_BTN_Click(sender As Object, e As EventArgs) Handles DAILYBOOK_PRE_BTN.Click
        DTP_DAILYBOOK.Value = DTP_DAILYBOOK.Value.AddDays(-1)
    End Sub

    Private Sub DAILYBOOK_NEXT_BTN_Click(sender As Object, e As EventArgs) Handles DAILYBOOK_NEXT_BTN.Click
        DTP_DAILYBOOK.Value = DTP_DAILYBOOK.Value.AddDays(1)
    End Sub


    Sub GET_DATE_WISE_RECORD()
        Try


            DAILY_BOOK_DATE_TXT.Text = DTP_DAILYBOOK.Value.ToString("dd-MMM-yyyy")
            Using con As New mySqlConnection("server=localhost; user=root; password=Masoom1; database=easypaisa_db;")
                Using cmd As New MySqlCommand("select *  from `TRANS_ID` where `date`='" & DTP_DAILYBOOK.Value.ToString("dd-MM-yyyy") & "' order by `date` desc;", con)
                    Using dt As New DataTable
                        Using DA As New MySqlDataAdapter
                            con.Open()
                            DA.SelectCommand = cmd
                            DA.Fill(dt)
                            DGV_DAILY_BOOK.DataSource = dt
                            con.Close()
                            Dim a_int As Integer = 0

                            For Each row As DataGridViewRow In DGV_DAILY_BOOK.Rows
                                If row.Cells(2).Value <> "" Then
                                    a_int += Int(row.Cells(2).Value)
                                End If
                            Next
                            DAILY_BOOK_AMOUNT_TXT.Text = a_int
                        End Using
                    End Using
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DAILY_BOOK_AMOUNT_TXT_TextChanged(sender As Object, e As EventArgs) Handles DAILY_BOOK_AMOUNT_TXT.TextChanged
        Try
            If DAILY_BOOK_AMOUNT_TXT.Text <> "" Then
                DAILY_BOOK_AMOUNT_TXT.Text = "PKR " & FormatNumber(DAILY_BOOK_AMOUNT_TXT.Text, 0, TriState.False, , TriState.True)
                With DAILY_BOOK_AMOUNT_TXT
                    .SelectionStart = .Text.Length
                    .ScrollToCaret()
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TOTAL_SALE_TXT_TextChanged(sender As Object, e As EventArgs) Handles TOTAL_SALE_TXT.TextChanged
        Try
            If TOTAL_SALE_TXT.Text <> "" Then
                TOTAL_SALE_TXT.Text = "PKR " & FormatNumber(TOTAL_SALE_TXT.Text, 0, TriState.False, , TriState.True)
                With TOTAL_SALE_TXT
                    .SelectionStart = .Text.Length
                    .ScrollToCaret()
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class