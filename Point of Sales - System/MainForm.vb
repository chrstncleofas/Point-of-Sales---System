Public Class MainForm
    Private Sub AdminAccess()
        CashierMenu.Visible = True
        ReportMenu.Visible = True
        StockMenu.Visible = True
        UserMenu.Visible = True
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginAs.Text = LoginForm.xpriv
        If LoginForm.xpriv = "User" Then
            CashierMenu.Visible = True
        ElseIf LoginForm.xpriv = "Admin" Then
            AdminAccess()
        ElseIf LoginForm.xpost = "Cashier" And LoginForm.xname = "cashier" Then
            Cashier.Show()
            LoginForm.Hide()
            Me.Close()
        End If
        dtTime.Value = DateTime.Now
    End Sub
    Private Sub StocksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem1.Click
        Inventory.Show()
        Me.Hide()
    End Sub
    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        UsersLogs.Show()
        Me.Hide()
    End Sub
    Private Sub AccountCreationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountCreationToolStripMenuItem.Click
        AccountCreation.Show()
        Me.Hide()
    End Sub
    Private Sub TransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionToolStripMenuItem.Click
        SalesReport.Show()
        Me.Hide()
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierMenu.Click
        Cashier.Show()
        Me.Hide()
    End Sub
    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdersToolStripMenuItem.Click
        Order.Show()
        Me.Hide()
    End Sub
    Private Sub AddProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductsToolStripMenuItem.Click

    End Sub
    Private Sub UserLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLogsToolStripMenuItem.Click

    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Are you sure do want to close this window?", vbQuestion + vbYesNo, "Logout......") = vbYes Then
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            LoginForm.Show()
            Me.Close()
        End If
    End Sub
End Class