Public Class MainForm
    Private Sub AdminAccess()
        grpCashier.Visible = True
        grpSales.Visible = True
        grpInventory.Visible = True
        grpUsers.Visible = True
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginAs.Text = LoginForm.xpriv
        If LoginForm.xpriv = "User" Then
            grpCashier.Visible = True
        ElseIf LoginForm.xpriv = "Admin" Then
            AdminAccess()
        ElseIf LoginForm.xpost = "Cashier" And LoginForm.xname = "cashier" Then
            Cashier.Show()
            LoginForm.Hide()
            Me.Close()
        End If
        dtTime.Value = DateTime.Now
    End Sub
    Private Sub picCashier_Click(sender As Object, e As EventArgs) Handles picCashier.Click
        Cashier.Show()
        Me.Hide()
    End Sub
    Private Sub picInventory_Click(sender As Object, e As EventArgs) Handles picInventory.Click
        Inventory.Show()
        Me.Hide()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure do want to close this window?", vbQuestion + vbYesNo, "Closing Form......") = vbYes Then
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