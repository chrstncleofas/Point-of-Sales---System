Imports System.Drawing.Printing
Imports Npgsql
Public Class Cashier
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim pname As String
    Dim xUP As Double
    Dim xDesc As String
    Dim xtempq As String
    Dim xGTotal As Double
    Dim crit As Integer
    Dim xqty As Integer
    Dim xsn As String
    Dim vat As Double
    Dim xtotal As Integer
    Dim change As Double
    Dim cash As Double
    Dim inn As String
    Dim Tamount As Double
    Dim xtime As String
    Dim stocksqty As Integer
    Dim total_qty As Long
    Dim disc As Double
    Public XName As String
    Dim crits As Integer
    Dim transac As String
    Dim iduser As String
    Sub autotransid()
        Try
            OpenDatabase()
            tbltran = New NpgsqlDataAdapter("SELECT ""Trans ID"" FROM tbltran ORDER BY ""Trans ID"" DESC", conn)
            dbds = New DataSet
            tbltran.Fill(dbds, "tbltran")
            If (dbds.Tables(0).Rows.Count > 0) Then
                Dim tempID = dbds.Tables(0).Rows(0)("Trans ID").ToString().Substring(2, 2)
                Dim newID As Integer = CInt(tempID) + 1
                lblTrans.Text = "75" & newID.ToString("00")
            Else
                lblTrans.Text = "7501"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Sub invoiceid()
        Try
            OpenDatabase()
            tblinvoice = New NpgsqlDataAdapter("SELECT ""Invoice ID"" FROM tblinvoice ORDER BY ""Invoice ID"" DESC", conn)
            dbds = New DataSet
            tblinvoice.Fill(dbds, "tblinvoice")
            If (dbds.Tables(0).Rows.Count > 0) Then
                Dim tempID = dbds.Tables(0).Rows(0)("Invoice ID").ToString().Substring(3, 3)
                Dim newID As Integer = CInt(tempID) + 1
                lblInvoice.Text = "INV" & newID.ToString("000")
            Else
                lblInvoice.Text = "INV001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Sub qty()
        Dim countItem As Long = 0
        For rowitem As Long = 0 To dgtemp.RowCount - 1
            countItem = countItem + dgtemp.Rows(rowitem).Cells(3).Value
        Next
        total_qty = countItem
    End Sub
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgtemp.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 300
    End Sub
    Sub lock()
        txtQ.Enabled = False
        txtamt.Enabled = False
        'SaveToolStripMenuItem.Enabled = False
        cmbPayment.Enabled = False
        txtDiscount.Enabled = False
    End Sub
    Sub unlock()
        txtQ.Enabled = True
        txtamt.Enabled = True
    End Sub
    Sub clearing()
        txtSN.Text = ""
        txtDesc.Text = ""
        txtQ.Text = ""
        lblPName.Text = Nothing
        lblchange.Text = "0.00"
        txtamt.Text = "0.00"
        lblTotal.Text = "0.00"
        lblDisplay.Text = "0.00"
        lblVAT.Text = "0.00"
        txtDiscount.Text = "0.00"
        vat = "0.00"
        cmbPayment.Text = ""
    End Sub
    Sub subcritical()
        crits = dbds.Tables("tblstock").Rows(0).Item("Product Quantity")
        If crits <= 5 And crits >= 1 Then
            MsgBox("This item is in only " & crits, vbCritical, "WARNING.!!!!")
        ElseIf crits = 0 Then
            MsgBox("This item has been out of stock", vbCritical, "WARNING!!!!!")
            clearing()
            lock()
        End If
    End Sub
    Sub User()
        opendb()
        sqlquery()
        iduser = dbds.Tables("tbluser").Rows(0).Item("User ID")
    End Sub
    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changelongpaper()
        autotransid()
        invoiceid()
        lock()
        txtSN.Focus()
        'Date Function
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "dd/MM/yyyy"
        'Time Function
        t1.Format = DateTimePickerFormat.Time
        t1.CustomFormat = "HH:mm:ss tt"
        'End Codes
        xGTotal = 0
        Try
            opendb3()
            sqlquery3()
            OpenDatabase()
            dbcmd = New NpgsqlCommand("DELETE FROM tbltemp", conn)
            dbcmd.ExecuteNonQuery()
            dgtemp.DataSource = dbds.Tables("tbltemp")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub txtSN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                tblstock = New NpgsqlDataAdapter("SELECT * FROM tblstock WHERE ""Product ID"" like '" & txtSN.Text.Trim & "' ", conn)
                dbds = New DataSet()
                tblstock.Fill(dbds, "tblstock")
                txtQ.Enabled = True
                If dbds.Tables("tblstock").Rows.Count > 0 Then
                    xUP = dbds.Tables("tblstock").Rows(0).Item("Selling Price")
                    xUP = FormatCurrency(xUP)
                    'Critical Function
                    subcritical()
                    'End of Function
                    txtDesc.Text = dbds.Tables("tblstock").Rows(0).Item("Product Description")
                    lblPName.Text = dbds.Tables("tblstock").Rows(0).Item("Product Name")
                    tbltemp = New NpgsqlDataAdapter("SELECT * FROM tbltemp WHERE ""Stock No"" like '" & txtSN.Text.Trim & "'", conn)
                    dbds = New DataSet()
                    tbltemp.Fill(dbds, "tbltemp")
                    If dbds.Tables("tbltemp").Rows.Count > 0 Then
                        If MsgBox("This item is already on your list, Would you like to add this one?", vbQuestion + vbYesNo, "Cashier Form") = vbYes Then
                            xtempq = dbds.Tables("tbltemp").Rows(0).Item("Quantity")
                            xGTotal = dbds.Tables("tbltemp").Rows(0).Item("Total")
                            txtQ.Focus()
                            sw = False
                        Else
                            txtSN.Clear()
                            lblDisplay.Text = "0.00"
                            txtDesc.Text = ""
                            Exit Sub
                        End If
                        Exit Sub
                    Else
                        sw = True
                        txtQ.Focus()
                    End If
                Else
                    MsgBox("Please enter a valid a Stock No., Thank you!", vbCritical, "Undefined Stock No.")
                    txtSN.Clear()
                    txtSN.Focus()
                End If
            Catch err As Exception
                MsgBox(err.ToString, vbCritical, "Error")
            Finally
                CloseDatabase()
            End Try
        End If
    End Sub
    Private Sub txtQ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQ.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgtemp.DataSource = dbds.Tables("tbltemp")
            cmbPayment.Enabled = True
            If txtQ.Text = "" Then
                MsgBox("Kindly enter the no. of quantity for this Item(s)!, Thank you...", vbCritical, "oops")
                txtQ.Focus()
                Exit Sub
            End If
            If e.KeyCode = Keys.Enter Then
                xGTotal = CInt(xGTotal) + CDbl(lblTotal.Text)
                lblDisplay.Text = Format(xGTotal, "Standard")
                OpenDatabase()
                If sw = True Then
                    dbcmd = New NpgsqlCommand("INSERT INTO tbltemp(""Stock No"", ""Item Name"", ""Description"", ""Quantity"", ""Unit Price"", ""Total"", ""VAT"") VALUES ('" & txtSN.Text.Trim & "','" & lblPName.Text.Trim & "','" & txtDesc.Text.Trim & "','" & txtQ.Text.Trim & "','" & xUP & "','" & lblTotal.Text.Trim & "', '" & lblVAT.Text.Trim & "')", conn)
                    dbcmd.ExecuteNonQuery()
                Else
                    xtempq = xtempq + CInt(txtQ.Text)
                    xGTotal = CSng(xGTotal) + CSng(lblTotal.Text)
                    lblDisplay.Text = FormatCurrency(lblDisplay.Text)
                    dbcmd = New NpgsqlCommand("UPDATE tbltemp set ""Quantity""='" & xtempq & "', ""Total""='" & lblDisplay.Text & "' WHERE ""Stock No"" like '" & txtSN.Text & "'", conn)
                    dbcmd.ExecuteNonQuery()
                End If
                sqlquery3()
                dgtemp.DataSource = dbds.Tables("tbltemp")
                txtQ.Clear()
                txtSN.Clear()

                'Total funtion by Quantity
                tbltemp = New NpgsqlDataAdapter("SELECT sum(CAST(""Total"" AS numeric)) + sum(CAST(""VAT"" AS numeric)) as xt FROM tbltemp", conn)
                dbds = New DataSet()
                tbltemp.Fill(dbds, "tbltemp")
                If dbds.Tables("tbltemp").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
                End If
                lblDisplay.Text = dbds.Tables("tbltemp").Rows(0).Item("xt")
                lblDisplay.Text = FormatCurrency(lblDisplay.Text)

                'Computation of Vat by Quantity
                tbltemp = New NpgsqlDataAdapter("SELECT sum(CAST(""VAT"" AS numeric)) as v FROM tbltemp", conn)
                dbds = New DataSet()
                tbltemp.Fill(dbds, "tbltemp")
                If dbds.Tables("tbltemp").Rows.Count > 0 Then
                    recpointer = 0
                    trec = CInt(dbds.Tables("tbltemp").Rows.Count) - 1
                End If
                vat = dbds.Tables("tbltemp").Rows(0).Item("v")
                txtSN.Focus()
            End If
        End If
    End Sub
    Private Sub txtQ_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQ.TextChanged
        Try
            Dim cleanInput As String = txtQ.Text.Replace("₱", "").Trim()
            Console.WriteLine("Clean Input: " & cleanInput) ' I-output ang nililinis na input
            Dim inputValue As Double
            If Double.TryParse(cleanInput, inputValue) Then
                ' Kalkulahin ang halaga kung ang input ay totoong numeriko
                lblTotal.Text = inputValue * CDbl(xUP)
                lblVAT.Text = inputValue * 1.3
                lblTotal.Text = FormatCurrency(lblTotal.Text)
            Else
                ' I-handle ang kaso kung ang input ay hindi numeriko
                MsgBox("Invalid input. Please enter a valid numeric value.", vbCritical, "Error")
                txtQ.Clear()
            End If
        Catch err As Exception
            MsgBox(err.ToString, vbCritical, "Error")
        End Try
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("This action will close the the transaction window, the next user will be ask to log - in! Do you wish to continue?", vbQuestion + vbYesNo, "logging - off") = vbYes Then
            Dim counter As Integer
            For counter = 90 To 10 Step -20
                Me.Opacity = counter / 100
                Me.Refresh()
                Threading.Thread.Sleep(5)
            Next counter
            If LoginForm.xpriv = "Admin" Then
                MainForm.Show()
                Me.Close()
            Else
                LoginForm.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class