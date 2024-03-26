<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.tcMenu = New System.Windows.Forms.TabControl()
        Me.tpDashboard = New System.Windows.Forms.TabPage()
        Me.tpTransaction = New System.Windows.Forms.TabPage()
        Me.tpArticles = New System.Windows.Forms.TabPage()
        Me.tpCategories = New System.Windows.Forms.TabPage()
        Me.tpCustomer = New System.Windows.Forms.TabPage()
        Me.tpReports = New System.Windows.Forms.TabPage()
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.pnTitlebar = New System.Windows.Forms.Panel()
        Me.btnfrmclose = New System.Windows.Forms.Button()
        Me.btnfrmmin = New System.Windows.Forms.Button()
        Me.btnMntReport = New System.Windows.Forms.Button()
        Me.btnMntCustomers = New System.Windows.Forms.Button()
        Me.btnMntCategories = New System.Windows.Forms.Button()
        Me.btnMntArticles = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.tcMenu.SuspendLayout()
        Me.pnMain.SuspendLayout()
        Me.pnTitlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcMenu
        '
        Me.tcMenu.Controls.Add(Me.tpDashboard)
        Me.tcMenu.Controls.Add(Me.tpTransaction)
        Me.tcMenu.Controls.Add(Me.tpArticles)
        Me.tcMenu.Controls.Add(Me.tpCategories)
        Me.tcMenu.Controls.Add(Me.tpCustomer)
        Me.tcMenu.Controls.Add(Me.tpReports)
        Me.tcMenu.Location = New System.Drawing.Point(-5, 14)
        Me.tcMenu.Name = "tcMenu"
        Me.tcMenu.SelectedIndex = 0
        Me.tcMenu.Size = New System.Drawing.Size(1059, 656)
        Me.tcMenu.TabIndex = 0
        Me.tcMenu.TabStop = False
        '
        'tpDashboard
        '
        Me.tpDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpDashboard.Location = New System.Drawing.Point(4, 22)
        Me.tpDashboard.Name = "tpDashboard"
        Me.tpDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDashboard.Size = New System.Drawing.Size(1051, 630)
        Me.tpDashboard.TabIndex = 0
        Me.tpDashboard.Text = "Dashboard"
        '
        'tpTransaction
        '
        Me.tpTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpTransaction.Location = New System.Drawing.Point(4, 22)
        Me.tpTransaction.Name = "tpTransaction"
        Me.tpTransaction.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTransaction.Size = New System.Drawing.Size(1051, 630)
        Me.tpTransaction.TabIndex = 1
        Me.tpTransaction.Text = "Transaction"
        '
        'tpArticles
        '
        Me.tpArticles.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpArticles.Location = New System.Drawing.Point(4, 22)
        Me.tpArticles.Name = "tpArticles"
        Me.tpArticles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpArticles.Size = New System.Drawing.Size(1051, 630)
        Me.tpArticles.TabIndex = 2
        Me.tpArticles.Text = "Articles"
        '
        'tpCategories
        '
        Me.tpCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpCategories.Location = New System.Drawing.Point(4, 22)
        Me.tpCategories.Name = "tpCategories"
        Me.tpCategories.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCategories.Size = New System.Drawing.Size(1051, 630)
        Me.tpCategories.TabIndex = 3
        Me.tpCategories.Text = "Categories"
        '
        'tpCustomer
        '
        Me.tpCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tpCustomer.Name = "tpCustomer"
        Me.tpCustomer.Size = New System.Drawing.Size(1051, 630)
        Me.tpCustomer.TabIndex = 6
        Me.tpCustomer.Text = "Customer"
        '
        'tpReports
        '
        Me.tpReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tpReports.Location = New System.Drawing.Point(4, 22)
        Me.tpReports.Name = "tpReports"
        Me.tpReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReports.Size = New System.Drawing.Size(1051, 630)
        Me.tpReports.TabIndex = 4
        Me.tpReports.Text = "Reports"
        '
        'pnMain
        '
        Me.pnMain.Controls.Add(Me.pnTitlebar)
        Me.pnMain.Controls.Add(Me.tcMenu)
        Me.pnMain.Location = New System.Drawing.Point(132, -1)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(984, 671)
        Me.pnMain.TabIndex = 2
        '
        'pnTitlebar
        '
        Me.pnTitlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnTitlebar.Controls.Add(Me.btnfrmmin)
        Me.pnTitlebar.Controls.Add(Me.btnfrmclose)
        Me.pnTitlebar.Location = New System.Drawing.Point(-1, -1)
        Me.pnTitlebar.Name = "pnTitlebar"
        Me.pnTitlebar.Size = New System.Drawing.Size(1055, 37)
        Me.pnTitlebar.TabIndex = 1
        '
        'btnfrmclose
        '
        Me.btnfrmclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfrmclose.FlatAppearance.BorderSize = 0
        Me.btnfrmclose.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnfrmclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnfrmclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnfrmclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfrmclose.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrmclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnfrmclose.Image = Global.MyTabs.My.Resources.Resources.frm_a_close
        Me.btnfrmclose.Location = New System.Drawing.Point(939, 0)
        Me.btnfrmclose.Name = "btnfrmclose"
        Me.btnfrmclose.Size = New System.Drawing.Size(38, 38)
        Me.btnfrmclose.TabIndex = 4
        Me.btnfrmclose.Tag = "close"
        Me.btnfrmclose.UseVisualStyleBackColor = True
        '
        'btnfrmmin
        '
        Me.btnfrmmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnfrmmin.FlatAppearance.BorderSize = 0
        Me.btnfrmmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnfrmmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnfrmmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnfrmmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfrmmin.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrmmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnfrmmin.Image = Global.MyTabs.My.Resources.Resources.frm_a_min
        Me.btnfrmmin.Location = New System.Drawing.Point(895, 1)
        Me.btnfrmmin.Name = "btnfrmmin"
        Me.btnfrmmin.Size = New System.Drawing.Size(38, 38)
        Me.btnfrmmin.TabIndex = 5
        Me.btnfrmmin.Tag = "min"
        Me.btnfrmmin.UseVisualStyleBackColor = True
        '
        'btnMntReport
        '
        Me.btnMntReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMntReport.FlatAppearance.BorderSize = 0
        Me.btnMntReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMntReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMntReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMntReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMntReport.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMntReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMntReport.Image = Global.MyTabs.My.Resources.Resources.menu_a_reports
        Me.btnMntReport.Location = New System.Drawing.Point(7, 501)
        Me.btnMntReport.Name = "btnMntReport"
        Me.btnMntReport.Size = New System.Drawing.Size(117, 87)
        Me.btnMntReport.TabIndex = 8
        Me.btnMntReport.Tag = "reports"
        Me.btnMntReport.Text = "Reports"
        Me.btnMntReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMntReport.UseVisualStyleBackColor = True
        '
        'btnMntCustomers
        '
        Me.btnMntCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMntCustomers.FlatAppearance.BorderSize = 0
        Me.btnMntCustomers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMntCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMntCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMntCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMntCustomers.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMntCustomers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMntCustomers.Image = Global.MyTabs.My.Resources.Resources.menu_a_customers
        Me.btnMntCustomers.Location = New System.Drawing.Point(7, 408)
        Me.btnMntCustomers.Name = "btnMntCustomers"
        Me.btnMntCustomers.Size = New System.Drawing.Size(117, 87)
        Me.btnMntCustomers.TabIndex = 7
        Me.btnMntCustomers.Tag = "customers"
        Me.btnMntCustomers.Text = "Customers"
        Me.btnMntCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMntCustomers.UseVisualStyleBackColor = True
        '
        'btnMntCategories
        '
        Me.btnMntCategories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMntCategories.FlatAppearance.BorderSize = 0
        Me.btnMntCategories.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMntCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMntCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMntCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMntCategories.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMntCategories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMntCategories.Image = Global.MyTabs.My.Resources.Resources.menu_a_category
        Me.btnMntCategories.Location = New System.Drawing.Point(7, 315)
        Me.btnMntCategories.Name = "btnMntCategories"
        Me.btnMntCategories.Size = New System.Drawing.Size(117, 87)
        Me.btnMntCategories.TabIndex = 6
        Me.btnMntCategories.Tag = "category"
        Me.btnMntCategories.Text = "Categories"
        Me.btnMntCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMntCategories.UseVisualStyleBackColor = True
        '
        'btnMntArticles
        '
        Me.btnMntArticles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMntArticles.FlatAppearance.BorderSize = 0
        Me.btnMntArticles.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnMntArticles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMntArticles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnMntArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMntArticles.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMntArticles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnMntArticles.Image = Global.MyTabs.My.Resources.Resources.menu_a_articles
        Me.btnMntArticles.Location = New System.Drawing.Point(7, 222)
        Me.btnMntArticles.Name = "btnMntArticles"
        Me.btnMntArticles.Size = New System.Drawing.Size(117, 87)
        Me.btnMntArticles.TabIndex = 5
        Me.btnMntArticles.Tag = "articles"
        Me.btnMntArticles.Text = "Articles"
        Me.btnMntArticles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMntArticles.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnTransaction.Image = Global.MyTabs.My.Resources.Resources.menu_a_transaction
        Me.btnTransaction.Location = New System.Drawing.Point(7, 129)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(117, 87)
        Me.btnTransaction.TabIndex = 4
        Me.btnTransaction.Tag = "transaction"
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Retroica", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnHome.Image = Global.MyTabs.My.Resources.Resources.menu_a_home
        Me.btnHome.Location = New System.Drawing.Point(7, 36)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(117, 87)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Tag = "home"
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1113, 662)
        Me.Controls.Add(Me.btnMntReport)
        Me.Controls.Add(Me.btnMntCustomers)
        Me.Controls.Add(Me.btnMntCategories)
        Me.Controls.Add(Me.btnMntArticles)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.pnMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Tabs"
        Me.tcMenu.ResumeLayout(False)
        Me.pnMain.ResumeLayout(False)
        Me.pnTitlebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcMenu As TabControl
    Friend WithEvents tpDashboard As TabPage
    Friend WithEvents tpTransaction As TabPage
    Friend WithEvents tpArticles As TabPage
    Friend WithEvents tpCategories As TabPage
    Friend WithEvents tpReports As TabPage
    Friend WithEvents pnMain As Panel
    Friend WithEvents pnTitlebar As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnMntArticles As Button
    Friend WithEvents tpCustomer As TabPage
    Friend WithEvents btnMntCategories As Button
    Friend WithEvents btnMntCustomers As Button
    Friend WithEvents btnMntReport As Button
    Friend WithEvents btnfrmmin As Button
    Friend WithEvents btnfrmclose As Button
End Class
