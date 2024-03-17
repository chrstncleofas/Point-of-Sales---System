﻿Imports Npgsql
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
    Sub lock()
        txtid.ReadOnly = True
        txtun.ReadOnly = True
        txtpw.ReadOnly = True
        txtrpw.ReadOnly = True
        txtpost.Enabled = False
        cbopv.Enabled = False
        btnSave.Enabled = False
    End Sub
    Sub unlock()
        txtid.ReadOnly = False
        txtun.ReadOnly = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpost.Enabled = True
        cbopv.Enabled = True
        btnSave.Enabled = True
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
        lock()
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"
        opendb()
        sqlquery()
        dgList.DataSource = dbds.Tables("tbluser")
    End Sub
    Sub display()
        Try
            txtid.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User ID")
            txtun.Text = dbds.Tables("tbluser").Rows(recpointer).Item("User Name")
            txtpost.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Position")
            cbopv.Text = dbds.Tables("tbluser").Rows(recpointer).Item("Privileges")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
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
                    dgList.DataSource = dbds.Tables("tbluser")
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
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If MsgBox("Are you sure do want to change your details", vbQuestion + vbYesNo, "Updating...") = MsgBoxResult.Yes Then
            OpenDatabase()
            dbcmd = New NpgsqlCommand("UPDATE tbluser SET ""User ID""= '" & txtid.Text.Trim & "', ""User Name""= '" & txtun.Text.Trim & "', ""Password""= '" & txtpw.Text.Trim & "', ""Position""= '" & txtpost.Text.Trim & "', ""Privileges""= '" & cbopv.Text.Trim & "' WHERE ""User ID"" like '" & txtid.Text.Trim & "'", conn)
            dbcmd.ExecuteNonQuery()
            sqlquery()
            dgList.DataSource = dbds.Tables("tbluser")
            txtclear()
        Else
            MsgBox("Error", vbCritical, "Warning!!1!")
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        autouseridnumber()
        unlock()
    End Sub
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        If txtid.Text.Trim.Length > 0 Then
            OpenFileDialog1.FileName = ""
            'OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\images\" & Trim(txtid.Text) & ".jpg", True)
                    idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                    idpict.Load()
                Catch err As Exception
                    MsgBox(err.Message)
                End Try
            End If
        Else
            MsgBox("Please type your User ID first before uploading image", MsgBoxStyle.Information, "Upload Image")
        End If
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        dgList.Rows(recpointer).Selected = False
        recpointer = 0
        dgList.Rows(recpointer).Selected = True
        display()
        Try
            idpict.ImageLocation = ""
            idpict.Refresh()
            idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
            idpict.Load()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        dgList.Rows(recpointer).Selected = False
        recpointer = trec
        dgList.Rows(recpointer).Selected = True
        display()
        Try
            idpict.ImageLocation = ""
            idpict.Refresh()
            idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
            idpict.Load()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If recpointer < trec Then
            dgList.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgList.Rows(recpointer).Selected = True
            display()
            Try
                idpict.ImageLocation = ""
                idpict.Refresh()
                idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                idpict.Load()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If recpointer > 0 Then
            dgList.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgList.Rows(recpointer).Selected = True
            display()
            Try
                idpict.ImageLocation = ""
                idpict.Refresh()
                idpict.ImageLocation = Application.StartupPath & "\images\" & txtid.Text.Trim & ".jpg"
                idpict.Load()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
End Class