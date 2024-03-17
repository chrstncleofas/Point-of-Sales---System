Imports Npgsql
Public Class Inventory
    Sub txtclear()
        txtProductID.Text = ""
        txtProductName.Text = ""
        txtCategory.Text = ""
        txtDescription.Text = ""
        txtProductQuan.Text = ""
        txtDescription.Text = ""
    End Sub
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb2()
        sqlquery2()
        dgStock.DataSource = dbds.Tables("tblstock")
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"
    End Sub
    Sub Criticals()
        If txtProductQuan.Text <= "5" And txtProductQuan.Text >= "1" Then
            MsgBox("Your Stock is " & txtProductQuan.Text, vbCritical, "Please Re-Stock")
        ElseIf txtProductQuan.Text = "0" Then
            MsgBox("Out of Stock", vbCritical, "Please Re-Stock")
        End If
    End Sub
    Sub display()
        Try
            txtProductID.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product ID")
            txtProductName.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Name")
            txtCategory.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Category")
            txtDescription.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Description")
            txtProductQuan.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Product Quantity")
            txtBuyingPrice.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Buying Price")
            txtSellingPrice.Text = dbds.Tables("tblstock").Rows(recpointer).Item("Selling Price")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProductID.Text = "" And txtProductName.Text = "" And txtCategory.Text = "" And txtDescription.Text = "" And txtProductQuan.Text And txtBuyingPrice.Text = "" And txtSellingPrice.Text = "" Then
            MsgBox("Please fill up all field before click add button", vbCritical, "Invalid Add Item")
        ElseIf MsgBox("The data are now successfuly save into database...", vbQuestion + vbYesNo, "Saving file into database...") = MsgBoxResult.Yes Then
            OpenDatabase()
            dbcmd = New NpgsqlCommand("INSERT INTO tblstock(""Product ID"", ""Product Name"", ""Product Category"", ""Product Description"", ""Product Quantity"", ""Buying Price"", ""Selling Price"", ""Date and Time"") VALUES ('" & txtProductID.Text.Trim & "','" & txtProductName.Text.Trim & "','" & txtCategory.Text.Trim & "','" & txtDescription.Text.Trim & "','" & txtProductQuan.Text & "','" & txtBuyingPrice.Text.Trim & "','" & txtSellingPrice.Text.Trim & "','" & d1.Value & "')", conn)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            txtclear()
            dgStock.DataSource = dbds.Tables("tblstock")
        Else
            MsgBox("Error", vbCritical, "Warning!!1!")
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtProductID.Text = "" And txtProductQuan.Text And txtBuyingPrice.Text = "" And txtSellingPrice.Text = "" And txtDescription.Text = "" Then
            MsgBox("Please select from stock page list of item that update", vbCritical, "Invalid Update")
        ElseIf MsgBox("Do you want to save the changes you made to its database?", vbQuestion + vbYesNo, "Updating...") = MsgBoxResult.Yes Then
            OpenDatabase()
            dbcmd = New NpgsqlCommand("UPDATE tblstock SET ""Product ID""= '" & txtProductID.Text.Trim & "', ""Product Description""= '" & txtDescription.Text.Trim & "', ""Product Quantity""= '" & txtProductQuan.Text & "', ""Buying Price""= '" & txtBuyingPrice.Text.Trim & "', ""Selling Price""= '" & txtSellingPrice.Text.Trim & "' WHERE ""Product ID"" like '" & txtProductID.Text.Trim & "'", conn)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            dgStock.DataSource = dbds.Tables("tblstock")
            txtclear()
        Else
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure do want to delete this from database?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Delete....") = MsgBoxResult.Yes Then
            OpenDatabase()
            dbcmd = New NpgsqlCommand("DELETE FROM tblstock WHERE ""Product ID"" like '" & txtProductID.Text.Trim & "'", conn)
            dbcmd.ExecuteNonQuery()
            sqlquery2()
            dgStock.DataSource = dbds.Tables("tblstock")
            txtclear()
        End If
    End Sub
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        If txtProductID.Text.Trim.Length > 0 Then
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\products\" & Trim(txtProductID.Text) & ".jpg", True)
                    idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
                    idPict.Load()
                Catch err As Exception
                    MsgBox(err.Message, vbCritical, "Error")
                End Try
            End If
        Else
            MsgBox("Please type the Product ID before browsing for images...", MsgBoxStyle.Information, "Upload Image")
        End If
    End Sub
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        dgStock.Rows(recpointer).Selected = False
        recpointer = 0
        dgStock.Rows(recpointer).Selected = True
        display()
        Criticals()
        Try
            idPict.ImageLocation = ""
            idPict.Refresh()
            idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
            idPict.Load()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        dgStock.Rows(recpointer).Selected = False
        recpointer = trec
        dgStock.Rows(recpointer).Selected = True
        display()
        Criticals()
        Try
            idPict.ImageLocation = ""
            idPict.Refresh()
            idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
            idPict.Load()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If recpointer < trec Then
            dgStock.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgStock.Rows(recpointer).Selected = True
            display()
            Criticals()
            Try
                idPict.ImageLocation = ""
                idPict.Refresh()
                idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
                idPict.Load()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If recpointer > 0 Then
            dgStock.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgStock.Rows(recpointer).Selected = True
            display()
            Criticals()
            Try
                idPict.ImageLocation = ""
                idPict.Refresh()
                idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
                idPict.Load()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Dim searchText As String = txtSearch.Text.Trim()
        Try
            Dim query As String = "SELECT * FROM tblstock WHERE ""Product ID"" LIKE '%" & searchText & "%' OR ""Product Category"" LIKE '%" & searchText & "%'"
            tblstock = New NpgsqlDataAdapter(query, conn)
            dbds = New DataSet()
            tblstock.Fill(dbds, "tblstock")
            If dbds.Tables("tblstock").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tblstock").Rows.Count) - 1
                dgStock.DataSource = dbds.Tables("tblstock")
                display()
                idPict.ImageLocation = ""
                idPict.Refresh()
                idPict.ImageLocation = Application.StartupPath & "\products\" & txtProductID.Text.Trim & ".jpg"
                idPict.Load()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            CloseDatabase()
        End Try
    End Sub
End Class