<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CashierMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLoginAs = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Point of Sales System"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 124)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dtTime)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 41)
        Me.Panel2.TabIndex = 2
        '
        'dtTime
        '
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTime.Location = New System.Drawing.Point(703, 11)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.Size = New System.Drawing.Size(85, 20)
        Me.dtTime.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashierMenu, Me.ReportMenu, Me.StockMenu, Me.UserMenu, Me.WindowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 41)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CashierMenu
        '
        Me.CashierMenu.Name = "CashierMenu"
        Me.CashierMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CashierMenu.Size = New System.Drawing.Size(58, 37)
        Me.CashierMenu.Text = "Cashier"
        Me.CashierMenu.Visible = False
        '
        'ReportMenu
        '
        Me.ReportMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdersToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.ReportMenu.Name = "ReportMenu"
        Me.ReportMenu.Size = New System.Drawing.Size(59, 37)
        Me.ReportMenu.Text = "Reports"
        Me.ReportMenu.Visible = False
        '
        'OrdersToolStripMenuItem
        '
        Me.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem"
        Me.OrdersToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OrdersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OrdersToolStripMenuItem.Text = "Orders"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'StockMenu
        '
        Me.StockMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddProductsToolStripMenuItem, Me.StocksToolStripMenuItem1})
        Me.StockMenu.Name = "StockMenu"
        Me.StockMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.StockMenu.Size = New System.Drawing.Size(122, 37)
        Me.StockMenu.Text = "Stock Management"
        Me.StockMenu.Visible = False
        '
        'AddProductsToolStripMenuItem
        '
        Me.AddProductsToolStripMenuItem.Name = "AddProductsToolStripMenuItem"
        Me.AddProductsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddProductsToolStripMenuItem.Text = "Add Products"
        '
        'StocksToolStripMenuItem1
        '
        Me.StocksToolStripMenuItem1.Name = "StocksToolStripMenuItem1"
        Me.StocksToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StocksToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.StocksToolStripMenuItem1.Text = "Stocks List"
        '
        'UserMenu
        '
        Me.UserMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserLogsToolStripMenuItem, Me.UserListToolStripMenuItem, Me.AccountCreationToolStripMenuItem})
        Me.UserMenu.Name = "UserMenu"
        Me.UserMenu.Size = New System.Drawing.Size(47, 37)
        Me.UserMenu.Text = "Users"
        Me.UserMenu.Visible = False
        '
        'UserLogsToolStripMenuItem
        '
        Me.UserLogsToolStripMenuItem.Name = "UserLogsToolStripMenuItem"
        Me.UserLogsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UserLogsToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.UserLogsToolStripMenuItem.Text = "User Logs"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'AccountCreationToolStripMenuItem
        '
        Me.AccountCreationToolStripMenuItem.Name = "AccountCreationToolStripMenuItem"
        Me.AccountCreationToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.AccountCreationToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AccountCreationToolStripMenuItem.Text = "Account Creation"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 37)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(75, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Welcome :)"
        '
        'lblLoginAs
        '
        Me.lblLoginAs.AutoSize = True
        Me.lblLoginAs.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginAs.Location = New System.Drawing.Point(186, 185)
        Me.lblLoginAs.Name = "lblLoginAs"
        Me.lblLoginAs.Size = New System.Drawing.Size(0, 30)
        Me.lblLoginAs.TabIndex = 9
        Me.lblLoginAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Point_of_Sales___System.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(410, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 147)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLoginAs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CashierMenu As ToolStripMenuItem
    Friend WithEvents ReportMenu As ToolStripMenuItem
    Friend WithEvents StockMenu As ToolStripMenuItem
    Friend WithEvents OrdersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserMenu As ToolStripMenuItem
    Friend WithEvents UserLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountCreationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLoginAs As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
