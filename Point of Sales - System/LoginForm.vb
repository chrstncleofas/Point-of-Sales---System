Imports Npgsql
Public Class LoginForm
    Public xname As String
    Public xpost As String
    Public xpriv As String
    Dim xtry As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" And txtPassword.Text = "" Then
            MsgBox("Please type your username and password! ", vbCritical, "Error")
        Else
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT * FROM tbluser WHERE ""User Name"" like '" & txtUsername.Text & "' and ""Password"" like '" & txtPassword.Text & "'", conn)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")
            trec = dbds.Tables("tbluser").Rows.Count
            If trec > 0 Then
                XName = txtUsername.Text
                'Cashier.txtCashier.Text = txtUsername.Text
                xpost = dbds.Tables("tbluser").Rows(0).Item("Position")
                xpriv = dbds.Tables("tbluser").Rows(0).Item("Privileges")
                XName = dbds.Tables("tbluser").Rows(0).Item("User Name")
                MsgBox("Welcome to Point of Sales " + xpriv, vbInformation, "Point of Sales Login Page")
                txtUsername.Clear()
                txtPassword.Clear()
                MainForm.Show()
                Me.Hide()
            Else
                MsgBox("The username and password not match, please try again!", vbCritical, "Error")
                xtry = xtry + 1
                If xtry = 3 Then
                    Me.Close()
                End If
                txtUsername.Clear()
                txtPassword.Clear()
                txtUsername.Focus()
            End If
        End If
    End Sub
    Private Sub linkLabelCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabelCreate.LinkClicked
        AccountCreation.Show()
        Me.Hide()
    End Sub
End Class
