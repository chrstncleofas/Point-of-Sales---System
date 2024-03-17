Imports Npgsql
Module connectionToDatabase
    Private connString As String = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=myDatabase"

    Public conn As NpgsqlConnection
    Public tbluser As NpgsqlDataAdapter
    Public tblstock As NpgsqlDataAdapter
    Public tbltemp As NpgsqlDataAdapter
    Public tbltran As NpgsqlDataAdapter
    Public tblinvoice As NpgsqlDataAdapter

    Public dbcmd As NpgsqlCommand
    Public dbds As DataSet

    Public recpointer As Integer
    Public trec As Integer
    Public sw As Boolean
    Public Sub OpenDatabase()
        Try
            conn = New NpgsqlConnection(connString)
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Public Sub CloseDatabase()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Sub opendb()
        Try
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT * FROM tbluser ORDER BY ""User ID"" ASC", conn)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")

            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Public Sub sqlquery()
        Try
            OpenDatabase()
            tbluser = New NpgsqlDataAdapter("SELECT ""User ID"", ""User Name"", ""Position"", ""Privileges"", ""DateTime"" FROM tbluser ORDER BY ""User ID"" ASC", conn)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")

            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Public Sub opendb2()
        Try
            OpenDatabase()
            tblstock = New NpgsqlDataAdapter("SELECT * FROM tblstock", conn)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")
            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Public Sub sqlquery2()
        Try
            OpenDatabase()
            tblstock = New NpgsqlDataAdapter("SELECT * FROM tblstock", conn)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")

            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
End Module
