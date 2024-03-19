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
            lblTotal.Text = CInt(txtQ.Text) * CInt(xUP)
            lblVAT.Text = CInt(txtQ.Text) * 1.3
            'lblTotal.Text = FormatCurrency(lblTotal.Text)
            lblTotal.Text = CDec(lblTotal.Text)
        Catch err As Exception
            'MsgBox(err.ToString)
        End Try
    End Sub
    Private Sub cmbPayment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPayment.SelectedIndexChanged
        If cmbPayment.Text = "Cash" Then
            txtamt.Enabled = True
            txtDiscount.Enabled = True
        ElseIf cmbPayment.Text = "Debit / Credit Card" Then
            txtamt.Enabled = True
            txtDiscount.Enabled = True
        End If
    End Sub
    Private Sub txtamt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyDown
        xDesc = txtDesc.Text
        xsn = txtSN.Text
        xtotal = lblDisplay.Text
        transac = lblTrans.Text
        If e.KeyCode = Keys.Enter Then
            txtDesc.Text = ""
            lblTotal.Text = "0.00"
            'SaveToolStripMenuItem.Enabled = True
            If CSng(txtamt.Text) < CSng(lblDisplay.Text) Then
                MsgBox("Oops, but you have an insufficiecnt money to make this transaction!", vbInformation, "wait a minute..")
                txtamt.Text = ""
                Exit Sub
            End If
            lblchange.Text = CSng(txtamt.Text) - CSng(lblDisplay.Text)
            txtamt.Text = FormatCurrency(txtamt.Text)
            lblchange.Text = FormatCurrency(lblchange.Text)
            tbltemp = New NpgsqlDataAdapter("SELECT * FROM tbltemp", conn)
            dbds = New DataSet()
            tbltemp.Fill(dbds, "tbltemp")
            trec = dbds.Tables("tbltemp").Rows.Count - 1
            recpointer = 0
            For recpointer As Integer = 0 To trec
                OpenDatabase()
                pname = dbds.Tables("tbltemp").Rows(recpointer).Item("Item Name")
                xDesc = dbds.Tables("tbltemp").Rows(recpointer).Item("Description")
                xUP = dbds.Tables("tbltemp").Rows(recpointer).Item("Unit Price")
                xqty = dbds.Tables("tbltemp").Rows(recpointer).Item("Quantity")
                xsn = dbds.Tables("tbltemp").Rows(recpointer).Item("Stock No")
                xtotal = dbds.Tables("tbltemp").Rows(recpointer).Item("Total")
                dbcmd = New NpgsqlCommand("INSERT INTO tbltran(""Trans ID"", ""Stock No"", ""Item Name"", ""Description"", ""Quantity"", ""Unit Price"", ""Total"", ""Date Time"", ""Cashier Name"", ""Payment Method"") VALUES ('" & transac & "', '" & xsn & "', '" & pname & "','" & xDesc & "','" & xqty & "','" & FormatCurrency(xUP) & "','" & FormatCurrency(xtotal) & "','" & d1.Value & "','" & txtCashier.Text & "', '" & cmbPayment.Text & "')", conn)
                dbcmd.ExecuteNonQuery()
                CloseDatabase()
                '
                OpenDatabase()
                tblstock = New NpgsqlDataAdapter("SELECT * FROM tblstock WHERE ""Product ID"" like '" & xsn & "' ", conn)
                dbds = New DataSet()
                tblstock.Fill(dbds, "tblstock")
                stocksqty = dbds.Tables("tblstock").Rows(0).Item("Product Quantity")
                stocksqty = stocksqty - xqty
                dbcmd = New NpgsqlCommand("UPDATE tblstock set ""Product Quantity"" = '" & stocksqty & "' WHERE ""Product ID"" like '" & xsn & "'", conn)
                dbcmd.ExecuteNonQuery()
                sqlquery3()
                CloseDatabase()
            Next
        End If
    End Sub
    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PrintDocument1.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Sub Function Object
        changelongpaper()
        qty()
        User()
        'Variable
        Dim time As DateTime = DateTime.Parse(t1.Value)
        'font Variable
        Dim f5 As New Font("Segoe UI", 6, FontStyle.Regular)
        Dim f8 As New Font("Segoe UI", 8, FontStyle.Regular)
        Dim f10 As New Font("Segoe UI", 9, FontStyle.Regular)
        Dim f10b As New Font("Segoe UI", 10, FontStyle.Bold)
        Dim f14 As New Font("Segoe UI", 12, FontStyle.Bold)
        'Margin Variable
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        ' Line Design Variable
        Dim line As String
        line = "============================================================================"

        'range from top
        e.Graphics.DrawString("POS Cashier", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Palanginan Iba Zambales PH", f8, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Contact No. 09610090120", f8, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("Trans ID", f5, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 60)
        e.Graphics.DrawString(lblTrans.Text, f5, Brushes.Black, 70, 60)

        e.Graphics.DrawString("Cashier", f5, Brushes.Black, 0, 75)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 75)
        e.Graphics.DrawString(iduser + " " + " " + txtCashier.Text, f5, Brushes.Black, 70, 75)

        e.Graphics.DrawString("Trans Date", f5, Brushes.Black, 0, 90)
        e.Graphics.DrawString(":", f5, Brushes.Black, 50, 90)
        e.Graphics.DrawString(d1.Value.Date + "  Time  :  " + time.ToString("hhh:mm:ss tt"), f5, Brushes.Black, 70, 90)


        e.Graphics.DrawString("Item Name", f8, Brushes.Black, 0, 105)
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 110, 105)
        e.Graphics.DrawString("Price", f8, Brushes.Black, 220, 105)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 114)

        Dim height As Integer 'Data Grid View Position
        Dim i As Long
        For row As Integer = 0 To dgtemp.RowCount - 1
            height += 15
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(1).Value.ToString, f5, Brushes.Black, 0, 114 + height)
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(3).Value.ToString, f5, Brushes.Black, 116, 114 + height)

            i = dgtemp.Rows(row).Cells(5).Value
            dgtemp.Rows(row).Cells(5).Value = FormatCurrency(i)
            e.Graphics.DrawString(dgtemp.Rows(row).Cells(5).Value.ToString, f5, Brushes.Black, rightmargin, 114 + height, right)
        Next
        Dim height2 As Integer
        height2 = 110 + height
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 14 + height2)
        e.Graphics.DrawString("Total: " & lblDisplay.Text, f10b, Brushes.Black, rightmargin, 25 + height2, right)
        e.Graphics.DrawString("Amount: " & txtamt.Text, f10b, Brushes.Black, rightmargin, 40 + height2, right)
        e.Graphics.DrawString("Change: " & lblchange.Text, f10b, Brushes.Black, rightmargin, 55 + height2, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 70 + height2)
        e.Graphics.DrawString("Total Item : " & total_qty, f8, Brushes.Black, 0, 80 + height2)
        e.Graphics.DrawString("VAT: " & FormatCurrency(vat), f8, Brushes.Black, rightmargin, 80 + height2, right)
        e.Graphics.DrawString("Sales Invoice ID : " & lblInvoice.Text, f5, Brushes.Black, 0, 95 + height2)

        e.Graphics.DrawString("~ Exchange of Item for reason other than ~", f5, Brushes.Black, centermargin, 145 + height2, center)
        e.Graphics.DrawString("~ those provided under the customer act ~", f5, Brushes.Black, centermargin, 160 + height2, center)
        e.Graphics.DrawString("~ will only be allowed within 7 days from date of purchase ~", f5, Brushes.Black, centermargin, 175 + height2, center)
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        changelongpaper()
        PrintPreviewControl1.Document = PrintDocument1
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
                MainForm.Close()
                Me.Close()
            End If
        End If
    End Sub
End Class