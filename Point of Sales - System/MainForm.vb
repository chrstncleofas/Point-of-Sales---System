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
End Class