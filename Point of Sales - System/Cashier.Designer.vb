<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.txtSN = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t1 = New System.Windows.Forms.DateTimePicker()
        Me.d1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.Label()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgtemp = New System.Windows.Forms.DataGridView()
        Me.lblPName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblchange = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblVAT = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtQ)
        Me.GroupBox4.Controls.Add(Me.txtSN)
        Me.GroupBox4.Controls.Add(Me.txtDesc)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 122)
        Me.GroupBox4.TabIndex = 78
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock and Quantity Description"
        '
        'txtQ
        '
        Me.txtQ.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQ.Location = New System.Drawing.Point(392, 39)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(81, 27)
        Me.txtQ.TabIndex = 82
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(123, 39)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(215, 27)
        Me.txtSN.TabIndex = 79
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDesc.Location = New System.Drawing.Point(123, 75)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(350, 31)
        Me.txtDesc.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Stock No : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(344, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Qty :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.t1)
        Me.GroupBox2.Controls.Add(Me.d1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(498, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 122)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date and Time "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Time : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Date : "
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.t1.Location = New System.Drawing.Point(84, 73)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(160, 27)
        Me.t1.TabIndex = 72
        '
        'd1
        '
        Me.d1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d1.Location = New System.Drawing.Point(84, 38)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(160, 27)
        Me.d1.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblInvoice)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCashier)
        Me.GroupBox1.Controls.Add(Me.lblCashierName)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(763, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 122)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cashier Name and Other"
        '
        'lblInvoice
        '
        Me.lblInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInvoice.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.ForeColor = System.Drawing.Color.White
        Me.lblInvoice.Location = New System.Drawing.Point(155, 78)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(423, 31)
        Me.lblInvoice.TabIndex = 79
        Me.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(67, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 17)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "Invoice No :"
        '
        'txtCashier
        '
        Me.txtCashier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashier.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashier.ForeColor = System.Drawing.Color.White
        Me.txtCashier.Location = New System.Drawing.Point(155, 33)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(423, 31)
        Me.txtCashier.TabIndex = 76
        Me.txtCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashierName.ForeColor = System.Drawing.Color.White
        Me.lblCashierName.Location = New System.Drawing.Point(48, 39)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(101, 17)
        Me.lblCashierName.TabIndex = 54
        Me.lblCashierName.Text = "Cashier Name :"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 232)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(850, 524)
        Me.TabControl1.TabIndex = 89
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgtemp)
        Me.TabPage1.Controls.Add(Me.lblPName)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 491)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ITEM PAGE"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgtemp
        '
        Me.dgtemp.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgtemp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgtemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtemp.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgtemp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgtemp.ColumnHeadersHeight = 35
        Me.dgtemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgtemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtemp.EnableHeadersVisualStyles = False
        Me.dgtemp.GridColor = System.Drawing.Color.White
        Me.dgtemp.Location = New System.Drawing.Point(3, 3)
        Me.dgtemp.Name = "dgtemp"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgtemp.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgtemp.RowHeadersVisible = False
        Me.dgtemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgtemp.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgtemp.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgtemp.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Maroon
        Me.dgtemp.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgtemp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgtemp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Maroon
        Me.dgtemp.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgtemp.RowTemplate.DividerHeight = 1
        Me.dgtemp.RowTemplate.Height = 25
        Me.dgtemp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgtemp.Size = New System.Drawing.Size(836, 485)
        Me.dgtemp.TabIndex = 71
        '
        'lblPName
        '
        Me.lblPName.BackColor = System.Drawing.Color.White
        Me.lblPName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPName.Location = New System.Drawing.Point(169, 29)
        Me.lblPName.Name = "lblPName"
        Me.lblPName.Size = New System.Drawing.Size(265, 31)
        Me.lblPName.TabIndex = 82
        Me.lblPName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(23, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "PRODUCT NAME  :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PrintPreviewControl1)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 491)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECIEPT PAGE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(3, 3)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(836, 485)
        Me.PrintPreviewControl1.TabIndex = 0
        Me.PrintPreviewControl1.Zoom = 1.4563636363636363R
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmbPayment)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(763, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 62)
        Me.GroupBox3.TabIndex = 97
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Option"
        '
        'cmbPayment
        '
        Me.cmbPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Items.AddRange(New Object() {"Cash", "Debit / Credit Card"})
        Me.cmbPayment.Location = New System.Drawing.Point(11, 24)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(222, 26)
        Me.cmbPayment.TabIndex = 78
        '
        'lblTrans
        '
        Me.lblTrans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrans.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrans.ForeColor = System.Drawing.Color.White
        Me.lblTrans.Location = New System.Drawing.Point(165, 161)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(592, 53)
        Me.lblTrans.TabIndex = 96
        Me.lblTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 20)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "TRANSACTION NO :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.txtDiscount)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(1009, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 62)
        Me.GroupBox5.TabIndex = 98
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(17, 22)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(315, 27)
        Me.txtDiscount.TabIndex = 83
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpDetails
        '
        Me.grpDetails.BackColor = System.Drawing.SystemColors.Control
        Me.grpDetails.Controls.Add(Me.txtamt)
        Me.grpDetails.Controls.Add(Me.Label9)
        Me.grpDetails.Controls.Add(Me.lblchange)
        Me.grpDetails.Controls.Add(Me.Panel5)
        Me.grpDetails.Controls.Add(Me.Label7)
        Me.grpDetails.Controls.Add(Me.Label11)
        Me.grpDetails.Controls.Add(Me.lblVAT)
        Me.grpDetails.Controls.Add(Me.Label5)
        Me.grpDetails.Controls.Add(Me.lblTotal)
        Me.grpDetails.Controls.Add(Me.Panel2)
        Me.grpDetails.Controls.Add(Me.Label6)
        Me.grpDetails.Controls.Add(Me.lblDisplay)
        Me.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpDetails.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDetails.ForeColor = System.Drawing.Color.White
        Me.grpDetails.Location = New System.Drawing.Point(859, 232)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(494, 523)
        Me.grpDetails.TabIndex = 99
        Me.grpDetails.TabStop = False
        '
        'txtamt
        '
        Me.txtamt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamt.Location = New System.Drawing.Point(240, 90)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(161, 29)
        Me.txtamt.TabIndex = 84
        Me.txtamt.Text = "0.00"
        Me.txtamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(104, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "TOTAL CHANGE :"
        '
        'lblchange
        '
        Me.lblchange.BackColor = System.Drawing.SystemColors.Control
        Me.lblchange.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblchange.Location = New System.Drawing.Point(236, 273)
        Me.lblchange.Name = "lblchange"
        Me.lblchange.Size = New System.Drawing.Size(159, 39)
        Me.lblchange.TabIndex = 96
        Me.lblchange.Text = "0.00"
        Me.lblchange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(31, 152)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(430, 1)
        Me.Panel5.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(100, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "CASH AMOUNT :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(183, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "VAT :"
        '
        'lblVAT
        '
        Me.lblVAT.BackColor = System.Drawing.SystemColors.Control
        Me.lblVAT.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblVAT.Location = New System.Drawing.Point(236, 231)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(159, 38)
        Me.lblVAT.TabIndex = 73
        Me.lblVAT.Text = "0.00"
        Me.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(98, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "TOTAL AMOUNT :"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(236, 187)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(159, 38)
        Me.lblTotal.TabIndex = 71
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(31, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 1)
        Me.Panel2.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(135, 374)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "SUB-TOTAL :"
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.lblDisplay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDisplay.Location = New System.Drawing.Point(236, 366)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(159, 38)
        Me.lblDisplay.TabIndex = 67
        Me.lblDisplay.Text = "0.00"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblTrans)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgtemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDesc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQ As TextBox
    Friend WithEvents txtSN As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t1 As DateTimePicker
    Friend WithEvents d1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblInvoice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCashier As Label
    Friend WithEvents lblCashierName As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgtemp As DataGridView
    Friend WithEvents lblPName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents lblTrans As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblchange As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblVAT As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtamt As TextBox
End Class
