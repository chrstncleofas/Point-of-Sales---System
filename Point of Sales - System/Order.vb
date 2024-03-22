Imports Npgsql
Public Class Order
    Private Sub ComputationSales()
        Dim salesTotal As Double
        For i As Integer = 0 To dgList.RowCount - 1
            salesTotal += dgList.Rows(i).Cells(2).Value.ToString
        Next
        lblTotal.Text = FormatCurrency(salesTotal)
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Dim query As String = "SELECT ""Item Name"", ""Quantity"", ""Total"" FROM tbltran WHERE ""Trans ID"" LIKE '%" & searchText & "%' OR ""Stock No"" LIKE '%" & searchText & "%'"
            tbltran = New NpgsqlDataAdapter(query, conn)
            dbds = New DataSet()
            tbltran.Fill(dbds, "tbltran")
            If dbds.Tables.Count > 0 AndAlso dbds.Tables(0).Rows.Count > 0 Then
                dgList.DataSource = dbds.Tables(0)
                dgList.Columns("Item Name").HeaderText = "Item/s"
                dgList.Columns("Quantity").HeaderText = "Qty"
                dgList.Columns("Total").HeaderText = "Amount"
            Else
                MsgBox("No user logs found.")
            End If
            ComputationSales()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
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