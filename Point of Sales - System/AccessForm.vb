Imports Npgsql
Public Class AccessForm
    Public xname As String
    Public xpost As String
    Public xpriv As String
    Dim xtry As String
    Private Sub TextBoxesCleared()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Please type your username and password! ", vbCritical, "Error")
            Else
                OpenDatabase()
                Dim query As String = "SELECT * FROM tbluser WHERE ""User Name"" = @username AND ""Password"" = @password"
                Dim cmd As New NpgsqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                Dim reader As NpgsqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim userPrivileges As String = reader("Privileges").ToString()
                        If userPrivileges = "Admin" Then
                            xname = txtUsername.Text
                            xpost = reader("Position").ToString()
                            xpriv = userPrivileges
                            MsgBox("Welcome to Point of Sales " & xpriv, vbInformation, "Point of Sales Login Page")
                            TextBoxesCleared()
                            AccountCreation.Show()
                            LoginForm.Hide()
                            Me.Hide()
                        Else
                            MsgBox("You do not have admin privileges. Please log in as an admin.", vbCritical, "Error")
                            TextBoxesCleared()
                        End If
                    End While
                Else
                    MsgBox("The username and password do not match, please try again!", vbCritical, "Error")
                    xtry = xtry + 1
                    If xtry = 3 Then
                        Me.Close()
                    End If
                    TextBoxesCleared()
                    txtUsername.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure do want to close this window?", vbQuestion + vbYesNo, "Access Form") = vbYes Then
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