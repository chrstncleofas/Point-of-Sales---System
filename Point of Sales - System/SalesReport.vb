Imports System.ComponentModel.Design
Imports Npgsql
Imports Excel = Microsoft.Office.Interop.Excel
Public Class SalesReport
    Private Sub ShowSales(query As String)
        Try
            OpenDatabase()
            Dim adapter As New NpgsqlDataAdapter(query, conn)
            Dim ds As New DataSet()
            adapter.Fill(ds)
            dgSales.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub ComputationSales()
        Dim salesTotal As Double
        For i As Integer = 0 To dgSales.RowCount - 1
            salesTotal += dgSales.Rows(i).Cells(6).Value.ToString
        Next
        lblTotalSales.Text = FormatCurrency(salesTotal)
    End Sub
    Private Sub FilterByDate()
        Dim date1 As DateTime = DateTime.Parse(d1.Value)
        Dim date2 As DateTime = DateTime.Parse(d2.Value)
        Try
            OpenDatabase()
            tbltran = New NpgsqlDataAdapter("SELECT * FROM tbltran WHERE ""Date Time""::date BETWEEN '" & date1.ToString("yyyy-MM-dd") & "' AND '" & date2.ToString("yyyy-MM-dd") & "' ORDER BY ""Date Time""::date DESC", conn)
            dbds = New DataSet()
            tbltran.Fill(dbds, "tbltran")
            If dbds.Tables("tbltran").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbltran").Rows.Count) - 1
                dgSales.DataSource = dbds.Tables("tbltran")
                ComputationSales()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "yyyy-MM-dd"
        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click
        Dim queryYesterday As String = "SELECT * FROM tbltran WHERE ""Date Time""::date = CURRENT_DATE"
        ShowSales(queryYesterday)
        ComputationSales()
    End Sub
    Private Sub btnYesterday_Click(sender As Object, e As EventArgs) Handles btnYesterday.Click
        Dim query As String = "SELECT * FROM tbltran WHERE ""Date Time""::date = CURRENT_DATE - INTERVAL '1 day'"
        ShowSales(query)
        ComputationSales()
    End Sub
    Private Sub btnWeek_Click(sender As Object, e As EventArgs) Handles btnWeek.Click
        Dim queryWeek As String = "SELECT * FROM tbltran WHERE ""Date Time""::date >= CURRENT_DATE - INTERVAL '1 week' AND ""Date Time""::date <= CURRENT_DATE"
        ShowSales(queryWeek)
        ComputationSales()
    End Sub
    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        Dim queryMonth As String = "SELECT * FROM tbltran WHERE EXTRACT(MONTH FROM ""Date Time"") = EXTRACT(MONTH FROM CURRENT_DATE)"
        ShowSales(queryMonth)
        ComputationSales()
    End Sub
    Private Sub d1_ValueChanged(sender As Object, e As EventArgs) Handles d1.ValueChanged
        FilterByDate()
    End Sub
    Private Sub d2_ValueChanged(sender As Object, e As EventArgs) Handles d2.ValueChanged
        FilterByDate()
    End Sub
    Private Sub t1_ValueChanged(sender As Object, e As EventArgs)
        FilterByDate()
    End Sub
    Private Sub t2_ValueChanged(sender As Object, e As EventArgs)
        FilterByDate()
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim sheetIndex As Integer
            Dim Ex As Object
            Dim Wb As Object
            Dim Ws As Object
            Ex = CreateObject("Excel.Application")
            Wb = Ex.workbooks.add
            Dim col, row As Integer
            Dim rawData(dgSales.Rows.Count, dgSales.Columns.Count - 1) As Object
            For col = 0 To dgSales.Columns.Count - 1
                rawData(0, col) = dgSales.Columns(col).HeaderText.ToUpper
            Next
            For col = 0 To dgSales.Columns.Count - 1
                For row = 0 To dgSales.Rows.Count - 1
                    rawData(row + 1, col) = dgSales.Rows(row).Cells(col).Value
                Next
            Next
            Dim finalColLetter As String = String.Empty
            finalColLetter = ExcelColName(dgSales.Columns.Count)
            sheetIndex += 1
            Ws = Wb.Worksheets(sheetIndex)
            Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, dgSales.Rows.Count + 1)
            Ws.Range(excelRange, Type.Missing).Value2 = rawData
            Ws = Nothing
            Wb.SaveAs(SaveFileDialog1.FileName, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            Wb.Close(True, Type.Missing, Type.Missing)
            Wb = Nothing
            ' Release the Application object
            Ex.Quit()
            Ex = Nothing
            ' Collect the unreferenced objects
            GC.Collect()
            MsgBox("Exported Successfully.", vbInformation, "Point of Sales, Exported Complete")
        End If
    End Sub
    Public Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", vbCritical, "Error Process")
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        SaveFileDialog1.Filter = "Excel Documents|*.xlsx"
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure do want to close this window?", vbQuestion + vbYesNo, "Sales Report") = vbYes Then
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