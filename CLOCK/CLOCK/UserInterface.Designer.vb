<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInterface
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
        Me.panHome = New System.Windows.Forms.Panel()
        Me.btnQuotes = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnJobOrders = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnClock = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.panHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'panHome
        '
        Me.panHome.Controls.Add(Me.btnCustomers)
        Me.panHome.Controls.Add(Me.btnQuotes)
        Me.panHome.Controls.Add(Me.btnReports)
        Me.panHome.Controls.Add(Me.btnJobOrders)
        Me.panHome.Controls.Add(Me.btnSales)
        Me.panHome.Controls.Add(Me.btnInventory)
        Me.panHome.Controls.Add(Me.btnClock)
        Me.panHome.Location = New System.Drawing.Point(-1, -1)
        Me.panHome.Name = "panHome"
        Me.panHome.Size = New System.Drawing.Size(632, 69)
        Me.panHome.TabIndex = 0
        '
        'btnQuotes
        '
        Me.btnQuotes.Location = New System.Drawing.Point(449, 4)
        Me.btnQuotes.Name = "btnQuotes"
        Me.btnQuotes.Size = New System.Drawing.Size(83, 62)
        Me.btnQuotes.TabIndex = 5
        Me.btnQuotes.Text = "Quotes"
        Me.btnQuotes.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(538, 4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(83, 62)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnJobOrders
        '
        Me.btnJobOrders.Location = New System.Drawing.Point(360, 4)
        Me.btnJobOrders.Name = "btnJobOrders"
        Me.btnJobOrders.Size = New System.Drawing.Size(83, 62)
        Me.btnJobOrders.TabIndex = 3
        Me.btnJobOrders.Text = "Job Orders"
        Me.btnJobOrders.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(271, 4)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(83, 62)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(182, 4)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(83, 62)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnClock
        '
        Me.btnClock.Location = New System.Drawing.Point(4, 4)
        Me.btnClock.Name = "btnClock"
        Me.btnClock.Size = New System.Drawing.Size(83, 62)
        Me.btnClock.TabIndex = 0
        Me.btnClock.Text = "Clock"
        Me.btnClock.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(93, 4)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(83, 62)
        Me.btnCustomers.TabIndex = 6
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 733)
        Me.Controls.Add(Me.panHome)
        Me.IsMdiContainer = True
        Me.Name = "UserInterface"
        Me.Text = "UserInterface"
        Me.TopMost = True
        Me.panHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panHome As System.Windows.Forms.Panel
    Friend WithEvents btnClock As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnJobOrders As System.Windows.Forms.Button
    Friend WithEvents btnQuotes As System.Windows.Forms.Button
    Friend WithEvents btnCustomers As System.Windows.Forms.Button
End Class
