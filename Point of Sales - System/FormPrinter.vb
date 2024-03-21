Public Class FormPrinter
    Private Sub FormPrinter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.printer = txtPrinterNameDevice.Text
        My.Settings.Save()
    End Sub
    Private Sub FormPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrinterNameDevice.Text = My.Settings.printer
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        txtPrinterNameDevice.Text = PrintDialog1.PrinterSettings.PrinterName
    End Sub
End Class