Imports Excel = Microsoft.Office.Interop.Excel

Public Class UserInterface


    Private Sub btnClock_Click(sender As Object, e As EventArgs) Handles btnClock.Click

        Call frmclose()
        ' when clicked, opens instance of clock class

        Dim clock As clock
            clock = New clock
            clock.MdiParent = Me
            clock.Show()
            ' sets the clocks start location
            clock.Location = New Point((Me.Width - clock.Width) / 2, (Me.Height - clock.Height) / 2)

    End Sub



    Private Sub UserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' opens with clock tab
        btnClock.PerformClick()

    End Sub



    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        ' when clicked opens instance of customers class

        Call frmclose()

        Dim customers As customers
        customers = New customers
        customers.MdiParent = Me
        customers.Show()

        'sets the customers start location
        customers.Location = New Point((Me.Width - customers.Width) / 2, (Me.Height - customers.Height) / 2)


    End Sub

    Private Sub frmclose()
        ' closes open objects
        For Each frmClose As Object In Me.MdiChildren
            frmClose.Close()
        Next


    End Sub






End Class