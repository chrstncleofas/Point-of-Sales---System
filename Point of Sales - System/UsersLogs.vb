Imports Npgsql
Public Class UsersLogs
    Private Sub showUserLogs()
        Try
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT ""User Name"", ""DateTime"" FROM tbluser ORDER BY ""DateTime"" DESC", conn)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")
            If dbds.Tables.Count > 0 AndAlso dbds.Tables(0).Rows.Count > 0 Then
                dgUsersLogs.DataSource = dbds.Tables(0)
                dgUsersLogs.Columns("User Name").HeaderText = "Username"
                dgUsersLogs.Columns("DateTime").HeaderText = "Date of Create Account"
            Else
                MsgBox("No user logs found.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub showUserList()
        Try
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT ""User ID"", ""User Name"", ""Position"", ""Privileges"" FROM tbluser ORDER BY ""User ID"" ASC", conn)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")
            dgUserList.DataSource = dbds.Tables("tbluser")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub UsersLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showUserLogs()
        showUserList()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure do want to close this window?", vbQuestion + vbYesNo, "Users......") = vbYes Then
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            MainForm.Show()
            Me.Close()
        End If
    End Sub
End Class