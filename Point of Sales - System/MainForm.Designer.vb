<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpCashier = New System.Windows.Forms.GroupBox()
        Me.picCashier = New System.Windows.Forms.PictureBox()
        Me.grpSales = New System.Windows.Forms.GroupBox()
        Me.picSales = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpInventory = New System.Windows.Forms.GroupBox()
        Me.picInventory = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpUsers = New System.Windows.Forms.GroupBox()
        Me.picUsers = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLoginAs = New System.Windows.Forms.Label()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpCashier.SuspendLayout()
        CType(Me.picCashier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInventory.SuspendLayout()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUsers.SuspendLayout()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(204, 15)
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
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 41)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cashier"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpCashier
        '
        Me.grpCashier.Controls.Add(Me.picCashier)
        Me.grpCashier.Controls.Add(Me.Label2)
        Me.grpCashier.Location = New System.Drawing.Point(23, 187)
        Me.grpCashier.Name = "grpCashier"
        Me.grpCashier.Size = New System.Drawing.Size(141, 173)
        Me.grpCashier.TabIndex = 4
        Me.grpCashier.TabStop = False
        Me.grpCashier.Visible = False
        '
        'picCashier
        '
        Me.picCashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCashier.Image = Global.Point_of_Sales___System.My.Resources.Resources.icons8_add_shopping_cart_96
        Me.picCashier.Location = New System.Drawing.Point(23, 23)
        Me.picCashier.Name = "picCashier"
        Me.picCashier.Size = New System.Drawing.Size(95, 94)
        Me.picCashier.TabIndex = 2
        Me.picCashier.TabStop = False
        '
        'grpSales
        '
        Me.grpSales.Controls.Add(Me.picSales)
        Me.grpSales.Controls.Add(Me.Label3)
        Me.grpSales.Location = New System.Drawing.Point(231, 187)
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(141, 173)
        Me.grpSales.TabIndex = 5
        Me.grpSales.TabStop = False
        Me.grpSales.Visible = False
        '
        'picSales
        '
        Me.picSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picSales.Image = Global.Point_of_Sales___System.My.Resources.Resources.icons8_graph_report_100
        Me.picSales.Location = New System.Drawing.Point(23, 23)
        Me.picSales.Name = "picSales"
        Me.picSales.Size = New System.Drawing.Size(95, 94)
        Me.picSales.TabIndex = 2
        Me.picSales.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpInventory
        '
        Me.grpInventory.Controls.Add(Me.picInventory)
        Me.grpInventory.Controls.Add(Me.Label4)
        Me.grpInventory.Location = New System.Drawing.Point(435, 187)
        Me.grpInventory.Name = "grpInventory"
        Me.grpInventory.Size = New System.Drawing.Size(141, 173)
        Me.grpInventory.TabIndex = 6
        Me.grpInventory.TabStop = False
        Me.grpInventory.Visible = False
        '
        'picInventory
        '
        Me.picInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picInventory.Image = Global.Point_of_Sales___System.My.Resources.Resources.icons8_move_stock_64
        Me.picInventory.Location = New System.Drawing.Point(35, 23)
        Me.picInventory.Name = "picInventory"
        Me.picInventory.Size = New System.Drawing.Size(90, 94)
        Me.picInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInventory.TabIndex = 2
        Me.picInventory.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stocks"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpUsers
        '
        Me.grpUsers.Controls.Add(Me.picUsers)
        Me.grpUsers.Controls.Add(Me.Label5)
        Me.grpUsers.Location = New System.Drawing.Point(634, 187)
        Me.grpUsers.Name = "grpUsers"
        Me.grpUsers.Size = New System.Drawing.Size(141, 173)
        Me.grpUsers.TabIndex = 7
        Me.grpUsers.TabStop = False
        Me.grpUsers.Visible = False
        '
        'picUsers
        '
        Me.picUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUsers.Image = Global.Point_of_Sales___System.My.Resources.Resources.icons8_user_male_128
        Me.picUsers.Location = New System.Drawing.Point(23, 23)
        Me.picUsers.Name = "picUsers"
        Me.picUsers.Size = New System.Drawing.Size(95, 94)
        Me.picUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUsers.TabIndex = 2
        Me.picUsers.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Users"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Login As:"
        '
        'lblLoginAs
        '
        Me.lblLoginAs.AutoSize = True
        Me.lblLoginAs.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginAs.Location = New System.Drawing.Point(112, 404)
        Me.lblLoginAs.Name = "lblLoginAs"
        Me.lblLoginAs.Size = New System.Drawing.Size(0, 30)
        Me.lblLoginAs.TabIndex = 9
        Me.lblLoginAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtTime
        '
        Me.dtTime.Location = New System.Drawing.Point(574, 411)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.Size = New System.Drawing.Size(200, 20)
        Me.dtTime.TabIndex = 10
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(710, 9)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(80, 23)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtTime)
        Me.Controls.Add(Me.lblLoginAs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpUsers)
        Me.Controls.Add(Me.grpInventory)
        Me.Controls.Add(Me.grpSales)
        Me.Controls.Add(Me.grpCashier)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.grpCashier.ResumeLayout(False)
        Me.grpCashier.PerformLayout()
        CType(Me.picCashier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        CType(Me.picSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInventory.ResumeLayout(False)
        Me.grpInventory.PerformLayout()
        CType(Me.picInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUsers.ResumeLayout(False)
        Me.grpUsers.PerformLayout()
        CType(Me.picUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picCashier As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpCashier As GroupBox
    Friend WithEvents grpSales As GroupBox
    Friend WithEvents picSales As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grpInventory As GroupBox
    Friend WithEvents picInventory As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpUsers As GroupBox
    Friend WithEvents picUsers As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLoginAs As Label
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents btnLogout As Button
End Class
