Imports Npgsql
Imports System.Data
Public Class AccountCreation
    Sub txtclear()
        txtid.Text = ""
        txtun.Text = ""
        txtpw.Text = ""
        txtrpw.Text = ""
        txtpost.Text = Nothing
        'idpict.Image = Nothing
        cbopv.Text = Nothing
    End Sub
    Sub autouseridnumber()
        Try
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT ""User ID"" FROM tbluser ORDER BY ""User ID"" DESC", conn)
            dbds = New DataSet
            tbluser.Fill(dbds, "tbluser")
            If (dbds.Tables(0).Rows.Count > 0) Then
                Dim tempID = dbds.Tables(0).Rows(0)("User ID").ToString().Substring(3, 3)
                Dim newID As Integer = CInt(tempID) + 1
                txtid.Text = "EMP" & newID.ToString("000")
            Else
                txtid.Text = "EMP001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub AccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autouseridnumber()
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtpw.Text.Trim = txtrpw.Text.Trim Then
            If sw = False Then
                If cbopv.Text = "" And txtun.Text = "" And txtpw.Text = "" And txtpost.Text = "" And txtrpw.Text = "" Then
                    MsgBox("Please fill up all fields", vbCritical, "Reminder..")
                ElseIf MsgBox("Creating account successfully", vbInformation + vbYesNo, "Creating Account") = MsgBoxResult.Yes Then
                    OpenDatabase()
                    dbcmd = New NpgsqlCommand("INSERT INTO tbluser(""User ID"", ""User Name"", ""Password"", ""Position"", ""Privileges"", ""DateTime"") VALUES ('" & txtid.Text.Trim & "','" & txtun.Text.Trim & "','" & txtpw.Text.Trim & "','" & txtpost.Text.Trim & "','" & cbopv.Text.Trim & "','" & d1.Value & "')", conn)
                    dbcmd.ExecuteNonQuery()
                    sqlquery()
                    txtclear()
                    'dgList.DataSource = dbds.Tables("tbluser")
                Else
                    txtid.Focus()
                End If
            End If
        Else
            MsgBox("Your password not match !!!", vbCritical, "Password Inccorrect")
            txtpw.Focus()
            txtpw.Clear()
            txtrpw.Clear()
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        autouseridnumber()
    End Sub
End Class