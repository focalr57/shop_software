Imports Excel = Microsoft.Office.Interop.Excel



Public Class clock

    ' const
    Const randall_jarrett As String = "001"

    ' variables
    Private dtable As DataTable = Nothing
    Private daterow As Date = Nothing

    Private employee_first As String = Nothing
    Private employee_last As String = Nothing
    Private rownum As Integer = Nothing
    Private rownum_2 As Integer = Nothing

    Private xlApp As Excel.Application
    Private xlApp_2 As Excel.Application
    Private xlWorkbook As Excel.Workbook
    Private xlWorkbook_2 As Excel.Workbook
    Private xlWorksheet As Excel.Worksheet
    Private xlWorksheet_2 As Excel.Worksheet
    Private xlRange As Excel.Range
    Private xlRange_2 As Excel.Range
    Private file_location As String = "C:\Users\rjarrett\Documents\Documents\Personal\CLOCK\CLOCK\bin\Debug\worksheets"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'enables timer
        Timer1.Enabled = True

        ' txtbox function has initial focus
        txtfunction.Focus()

        ' opens clock tab


        Call dtabledata()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' gets time and day every tick
        Dim day As Integer = Date.Today.DayOfWeek
        lbldate.Text = Format(Now, "  hh:mm:ss   ") + WeekdayName(day)

    End Sub


    ' clocking in workday
    Private Sub timeclock_excel_clockin_data()

        Dim day As Date = Date.Today
        Dim time As Date = TimeOfDay

        ' opens excel workbooks and worksheets
        Call open_excel("\timeclock.xlsx", MonthName(Now.Date.Month(), False))
        'Call open_excel_2("\clockoutjob.xlsx", "singlejob")

        ' searchs worksheet for last row
        ' returns with rownum and adds 1 for next row
        rownum = xlWorksheet.UsedRange.Rows.Count + 1

        ' adds cell data
        xlWorksheet.Cells(rownum, 1).Value = day
        xlWorksheet.Cells(rownum, 2).Value = txtemployee.Text
        xlWorksheet.Cells(rownum, 3).Value = time

        ' searchs worksheet for last row
        ' returns with rownum and adds 1 for next row
        'rownum_2 = xlWorksheet_2.UsedRange.Rows.Count + 1

        ' adds cell data
        'xlWorksheet_2.Cells(rownum_2, 1).Value = day
        'xlWorksheet_2.Cells(rownum_2, 2).Value = employee_first
        'xlWorksheet_2.Cells(rownum_2, 3).Value = employee_last
        'xlWorksheet_2.Cells(rownum_2, 5).Value = time


        Call close_excel()
        'Call close_excel_2()

    End Sub

    ' clocking out workday
    Private Sub timeclock_excel_clockout_data()

        Dim time As Date = TimeOfDay

        ' opens excel workbook and worksheet
        Call open_excel("\timeclock.xlsx", MonthName(Now.Date.Month(), False))

        ' searchs worksheet for last row
        ' returns with rownum
        rownum = xlWorksheet.UsedRange.Rows.Count

        ' checks to see if zero entries
        'If rownum < 2 Then
        'rownum = 2
        'End If

        ' searchs last row to determine if name of employee is correct
        ' if not, moves back a row until finds last row of correct employee
        Dim index = rownum
        Do Until index = 1

            If xlWorksheet.Cells(index, 2).value = txtemployee.Text Then
                Exit Do
            End If
            index -= 1
        Loop

        rownum = index

        'If rownum < 2 Then
        'rownum = 2
        'End If

        ' adds stop time to cell
        ' checks to make sure start time available
        ' if not, input is used for start time
        'If String.IsNullOrEmpty(xlWorksheet.Cells(rownum, 3).value) Then
        'beginning:
        'Dim time_input = Microsoft.VisualBasic.Interaction.InputBox("What time did you start today?", "Start Time", "06:00:00")
        ' If time_input = String.Empty Then GoTo beginning


        'xlWorksheet.Cells(rownum, 1).Value = Date.Today
        'xlWorksheet.Cells(rownum, 2).Value = txtemployee.Text
        'xlWorksheet.Cells(rownum, 3).value = time_input
        'xlWorksheet.Cells(rownum, 4).value = time

        'Else
        xlWorksheet.Cells(rownum, 4).Value = time
        'End If

        ' subtracts stop time from start time to give total for entry
        xlWorksheet.Cells(rownum, 5) = xlWorksheet.Cells(rownum, 4).value - xlWorksheet.Cells(rownum, 3).value

        Call close_excel()


    End Sub

    ' clocking out single job

    Private Sub saveclocksinglejobdata()

        ' saves data into appropriate database

        ' returns first,last name of employee
        'employee_first = employee_excel_data("first")
        'employee_last = employee_excel_data("last")

        Dim day As Date = Date.Today
        Dim time As Date = TimeOfDay
        Dim joborder As String = txtjob.Text
        Dim starttime As String
        Dim operation As String = txtoperation.Text

        ' opens excel workbook and worksheet
        Call open_excel("\clockoutjob.xlsx", "singlejob")

        ' searchs worksheet for last row
        ' returns with rownum and adds 1 for next row
        rownum = xlWorksheet.UsedRange.Rows.Count

        ' searches for row with current employee names
        Dim index = rownum + 1
        Do Until index = 1

            If xlWorksheet.Cells(index, 2).value = txtemployee.Text Then
                Exit Do
            End If
            index -= 1
        Loop
        ' sets row number
        rownum = index + 1

        If xlWorksheet.Cells(index, 1).value = day.ToString Then
            ' sets start time to end time of last entry
            starttime = xlWorksheet.Cells(index, 6).value
        Else
            starttime = get_start_time()
        End If

        ' adds cell data
        xlWorksheet.Cells(rownum, 1).value = day
        xlWorksheet.Cells(rownum, 2).value = txtemployee.Text
        xlWorksheet.Cells(rownum, 3).Value = joborder
        xlWorksheet.Cells(rownum, 4).value = operation
        xlWorksheet.Cells(rownum, 5).value = starttime
        xlWorksheet.Cells(rownum, 6).value = time
        xlWorksheet.Cells(rownum, 7).value = xlWorksheet.Cells(rownum, 6).value - xlWorksheet.Cells(rownum, 5).value

        Call close_excel()



    End Sub

    Private Function get_start_time()

        ' opens employee workbook to retrieve start time
        Call open_excel_2("\timeclock.xlsx", MonthName(Now.Date.Month(), False))
        rownum_2 = xlWorksheet_2.UsedRange.Rows.Count + 1

        ' searches for row with current employee names
        Dim index = rownum_2
        Do Until index = 1
            ' checks for name and date
            If (xlWorksheet_2.Cells(index, 2).value = txtemployee.Text And _
                xlWorksheet_2.Cells(index, 1).value = Date.Today) Then
                Exit Do
            End If
            index -= 1
        Loop
        ' sets row number
        rownum_2 = index
        ' sets start time
        Dim starttime As String = xlWorksheet_2.Cells(rownum_2, 3).value

        Call close_excel_2()

        ' returns starttime
        Return starttime


    End Function

    ' clocking out multiple jobs

    Private Sub saveclockmultiplejobdata()

        ' saves data into appropriate database


        Dim day As Date = Date.Today
        Dim time As DateTime = TimeOfDay
        Dim joborder As String = txtjob.Text
        Dim starttime As String
        Dim operation As String = txtoperation.Text

        ' opens excel workbook and worksheet
        Call open_excel("\clockoutjob.xlsx", "singlejob")

        ' searchs worksheet for last row
        ' returns with rownum and adds 1 for next row
        rownum = xlWorksheet.UsedRange.Rows.Count

        ' searches for row with current employee names
        Dim index = rownum + 1
        Do Until index = 1

            If xlWorksheet.Cells(index, 2).value = txtemployee.Text Then
                Exit Do
            End If
            index -= 1
        Loop
        ' sets row number
        rownum = index + 1

        If xlWorksheet.Cells(index, 1).value = day.ToString Then
            ' sets start time to end time of last entry
            starttime = xlWorksheet.Cells(index, 6).value
        Else
            starttime = get_start_time()
        End If

        ' sets start time to first multiple entry
        xlWorksheet.Cells(rownum, 5).value = starttime
        Dim rownum_adj = rownum

        ' populates the worksheet with datatable data
        For i = 1 To dtable.Rows.Count
            For j = 0 To dtable.Columns.Count - 1
                xlWorksheet.Cells(rownum_adj, j + 1) = _
                    dtable.Rows(i - 1)(j).ToString()
            Next
            rownum_adj = rownum_adj + 1
        Next

        ' sets end time to last entry
        xlWorksheet.Cells(rownum_adj - 1, 6).value = time

        ' sets totals for multiple entries
        Dim total_time = xlWorksheet.Cells(rownum_adj - 1, 6).value - xlWorksheet.Cells(rownum, 5).value
        Dim num = dtable.Rows.Count
        Dim total_adj = total_time / num

        ' populate total column
        rownum_adj = rownum_adj - 1
        For k = 1 To num
            xlWorksheet.Cells(rownum_adj, 7) = total_time
            xlWorksheet.Cells(rownum_adj, 8) = total_adj
            rownum_adj = rownum_adj - 1
        Next

        ' clear boxes and move focus
        txtfunction.Text = Nothing
        txtemployee.Text = Nothing
        txtjob.Text = Nothing
        txtoperation.Text = Nothing

        txtfunction.Focus()

        ' clear datatable and close datatable
        dgvresults.DataSource = Nothing
        dgvresults.Enabled = False
        dgvresults.Visible = False

        Call close_excel()



    End Sub

    Private Sub clockmultiplejobsdata()
        ' code for when enter or scan happens in operation txtbox when clocking off single job
        ' add rows with data entered
        dtable.Rows.Add(daterow.ToString("MM/dd/yyyy"), txtemployee.Text, txtjob.Text, txtoperation.Text)

        ' shows datagridview and applys datasource
        dgvresults.Enabled = True
        dgvresults.Visible = True
        dgvresults.DataSource = dtable

        ' set column width for all columns
        For Each c As DataGridViewColumn In dgvresults.Columns
            c.Width = (dgvresults.Size.Width - dgvresults.RowHeadersWidth) / dgvresults.ColumnCount
        Next

        txtjob.Clear()
        txtoperation.Clear()
        txtjob.Focus()

    End Sub






    Private Sub dtabledata()

        ' applys column names to datatable
        dtable = New DataTable
        dtable.Columns.Add("Date")
        dtable.Columns.Add("Employee")
        dtable.Columns.Add("Job")
        dtable.Columns.Add("Operation")

        ' sets date
        daterow = Date.Today

    End Sub



    ' keyup functions

    Private Sub txtfunction_keyup(sender As Object, e As KeyEventArgs) Handles txtfunction.KeyUp

        ' check for clock multiple jobs
        If (e.KeyCode = Keys.Enter) Then
            GetNextControl(ActiveControl, True).Focus()
        End If

    End Sub

    Private Sub txtemployee_KeyUp(sender As Object, e As KeyEventArgs) Handles txtemployee.KeyUp

        ' when enter  or scanned, tests what was entered or scanned
        Dim enter As String = e.KeyCode = Keys.Enter
        Select Case True

            Case enter And txtfunction.Text = "clockinday"
                Call timeclock_excel_clockin_data()

                ' clears the txtboxes and focus back to function
                txtfunction.Text = Nothing
                txtemployee.Text = Nothing
                txtfunction.Focus()

            Case enter And txtfunction.Text = "clockoutday"
                Call timeclock_excel_clockout_data()

                ' clears the txtboxes and focus back to function
                txtfunction.Text = Nothing
                txtemployee.Text = Nothing
                txtfunction.Focus()

            Case enter And txtfunction.Text = "clocksinglejob"
                ' moves to next txtbox after enter or scan
                If (e.KeyCode = Keys.Enter) Then
                    GetNextControl(ActiveControl, True).Focus()
                End If

            Case enter And txtfunction.Text = "clockmultiplejob"

                GetNextControl(ActiveControl, True).Focus()

        End Select



    End Sub

    Private Sub txtjob_KeyUp(sender As Object, e As KeyEventArgs) Handles txtjob.KeyUp

        If (e.KeyCode = Keys.Enter) And txtjob.Text = "savemultiple" Then
            ' saves the data table and enters into appropriate excel sheet
            Call saveclockmultiplejobdata()

        ElseIf (e.KeyCode = Keys.Enter) Then
            GetNextControl(ActiveControl, True).Focus()
        End If


    End Sub

    Private Sub txtoperation_keyup(sender As Object, e As KeyEventArgs) Handles txtoperation.KeyUp

        ' code for when enter or scan happens in operation txtbox when clocking off
        Dim enter As String = e.KeyCode = Keys.Enter
        Select Case True

            Case enter And txtfunction.Text = "clocksinglejob"

                Call saveclocksinglejobdata()

                ' clears txtboxes and moves back to txtfunction after scanner or enter
                txtfunction.Text = Nothing
                txtemployee.Text = Nothing
                txtjob.Text = Nothing
                txtoperation.Text = Nothing
                txtfunction.Focus()

            Case enter And txtfunction.Text = "clockmultiplejob"
                ' calls method
                Call clockmultiplejobsdata()


        End Select

    End Sub








    Private Sub savemultiplejobsdata()

        ' saves data into appropriate database

    End Sub


    ' excel functions: ranging, opening, closing, and releasing

    Private Function GetSpecifiedRange(ByVal matchStr As String, ByVal objWs As Excel.Worksheet) As Excel.Range

        ' looks into open workbook for specific text
        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing
        currentFind = objWs.Range("A1:C50").Find(matchStr, , _
Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart, _
Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, False)
        Return currentFind

    End Function

    Private Sub open_excel(ByVal wbLocation As String, ByVal wsLocation As String)

        ' opens excel employee workbook
        xlApp = New Excel.Application
        xlWorkbook = xlApp.Workbooks.Open(file_location + wbLocation, Notify:=False, [ReadOnly]:=False)
        xlWorksheet = xlWorkbook.Worksheets(wsLocation)

    End Sub

    Private Sub open_excel_2(ByVal wbLocation_2 As String, ByVal wsLocation_2 As String)

        ' opens excel employee workbook
        xlApp_2 = New Excel.Application
        xlWorkbook_2 = xlApp_2.Workbooks.Open(file_location + wbLocation_2, Notify:=False, [ReadOnly]:=False)
        xlWorksheet_2 = xlWorkbook_2.Worksheets(wsLocation_2)

    End Sub

    Private Sub close_excel()

        xlWorkbook.Save()
        xlWorkbook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkbook)
        releaseObject(xlWorksheet)

        rownum = Nothing

    End Sub

    Private Sub close_excel_2()

        xlWorkbook_2.Save()
        xlWorkbook_2.Close()
        xlApp_2.Quit()

        releaseObject(xlApp_2)
        releaseObject(xlWorkbook_2)
        releaseObject(xlWorksheet_2)

        rownum_2 = Nothing

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



End Class
