<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgSales = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMonth = New System.Windows.Forms.Button()
        Me.btnWeek = New System.Windows.Forms.Button()
        Me.btnYesterday = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.d2 = New System.Windows.Forms.DateTimePicker()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSales
        '
        Me.dgSales.AllowUserToAddRows = False
        Me.dgSales.AllowUserToDeleteRows = False
        Me.dgSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSales.Location = New System.Drawing.Point(0, 151)
        Me.dgSales.Name = "dgSales"
        Me.dgSales.ReadOnly = True
        Me.dgSales.Size = New System.Drawing.Size(907, 284)
        Me.dgSales.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(359, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 40)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "Sales Report"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnMonth)
        Me.Panel1.Controls.Add(Me.btnWeek)
        Me.Panel1.Controls.Add(Me.btnYesterday)
        Me.Panel1.Controls.Add(Me.btnToday)
        Me.Panel1.Location = New System.Drawing.Point(197, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 46)
        Me.Panel1.TabIndex = 85
        '
        'btnMonth
        '
        Me.btnMonth.FlatAppearance.BorderSize = 0
        Me.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonth.Location = New System.Drawing.Point(246, 11)
        Me.btnMonth.Name = "btnMonth"
        Me.btnMonth.Size = New System.Drawing.Size(75, 23)
        Me.btnMonth.TabIndex = 89
        Me.btnMonth.Text = "Month"
        Me.btnMonth.UseVisualStyleBackColor = True
        '
        'btnWeek
        '
        Me.btnWeek.FlatAppearance.BorderSize = 0
        Me.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeek.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeek.Location = New System.Drawing.Point(165, 11)
        Me.btnWeek.Name = "btnWeek"
        Me.btnWeek.Size = New System.Drawing.Size(75, 23)
        Me.btnWeek.TabIndex = 88
        Me.btnWeek.Text = "Week"
        Me.btnWeek.UseVisualStyleBackColor = True
        '
        'btnYesterday
        '
        Me.btnYesterday.FlatAppearance.BorderSize = 0
        Me.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYesterday.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYesterday.Location = New System.Drawing.Point(84, 11)
        Me.btnYesterday.Name = "btnYesterday"
        Me.btnYesterday.Size = New System.Drawing.Size(75, 23)
        Me.btnYesterday.TabIndex = 87
        Me.btnYesterday.Text = "Yesterday"
        Me.btnYesterday.UseVisualStyleBackColor = True
        '
        'btnToday
        '
        Me.btnToday.FlatAppearance.BorderSize = 0
        Me.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToday.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToday.Location = New System.Drawing.Point(3, 11)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(75, 23)
        Me.btnToday.TabIndex = 86
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(530, 104)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(165, 35)
        Me.d1.TabIndex = 86
        '
        'd2
        '
        Me.d2.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(701, 104)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(165, 35)
        Me.d2.TabIndex = 87
        '
        'btnExcel
        '
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.Location = New System.Drawing.Point(56, 99)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(138, 46)
        Me.btnExcel.TabIndex = 90
        Me.btnExcel.Text = "Convert to Excel"
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotalSales)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(909, 56)
        Me.Panel2.TabIndex = 91
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalSales.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.White
        Me.lblTotalSales.Location = New System.Drawing.Point(767, 12)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(128, 35)
        Me.lblTotalSales.TabIndex = 3
        Me.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(683, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Sales :"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(822, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 90
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 492)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dgSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SalesReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesReport"
        CType(Me.dgSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSales As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnToday As Button
    Friend WithEvents btnMonth As Button
    Friend WithEvents btnWeek As Button
    Friend WithEvents btnYesterday As Button
    Friend WithEvents d1 As DateTimePicker
    Friend WithEvents d2 As DateTimePicker
    Friend WithEvents btnExcel As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
End Class
