<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class job_orders
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
        Me.lbljob_order_num = New System.Windows.Forms.Label()
        Me.lblsales_order_num = New System.Windows.Forms.Label()
        Me.lblcust_name = New System.Windows.Forms.Label()
        Me.lblpart_num = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblmemo = New System.Windows.Forms.Label()
        Me.txtjob_num = New System.Windows.Forms.TextBox()
        Me.txtsales_num = New System.Windows.Forms.TextBox()
        Me.txtcust_name = New System.Windows.Forms.TextBox()
        Me.txtpart_num = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtmemo = New System.Windows.Forms.TextBox()
        Me.lbljob_status = New System.Windows.Forms.Label()
        Me.lblopen_date = New System.Windows.Forms.Label()
        Me.lbldue_date = New System.Windows.Forms.Label()
        Me.lblrout_hrs = New System.Windows.Forms.Label()
        Me.lblmake_qty = New System.Windows.Forms.Label()
        Me.txtjob_status = New System.Windows.Forms.TextBox()
        Me.txtopen_date = New System.Windows.Forms.TextBox()
        Me.txtdue_date = New System.Windows.Forms.TextBox()
        Me.txtrout_hrs = New System.Windows.Forms.TextBox()
        Me.txtmake_qty = New System.Windows.Forms.TextBox()
        Me.gbjob_orders = New System.Windows.Forms.GroupBox()
        Me.btncost = New System.Windows.Forms.Button()
        Me.btnpacket = New System.Windows.Forms.Button()
        Me.btnrouting = New System.Windows.Forms.Button()
        Me.btnbom = New System.Windows.Forms.Button()
        Me.lblcost = New System.Windows.Forms.Label()
        Me.lblpacket = New System.Windows.Forms.Label()
        Me.lblrouting = New System.Windows.Forms.Label()
        Me.lblbom = New System.Windows.Forms.Label()
        Me.gbjob_orders.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbljob_order_num
        '
        Me.lbljob_order_num.AutoSize = True
        Me.lbljob_order_num.Location = New System.Drawing.Point(12, 84)
        Me.lbljob_order_num.Name = "lbljob_order_num"
        Me.lbljob_order_num.Size = New System.Drawing.Size(84, 17)
        Me.lbljob_order_num.TabIndex = 0
        Me.lbljob_order_num.Text = "Job Order #"
        '
        'lblsales_order_num
        '
        Me.lblsales_order_num.AutoSize = True
        Me.lblsales_order_num.Location = New System.Drawing.Point(12, 122)
        Me.lblsales_order_num.Name = "lblsales_order_num"
        Me.lblsales_order_num.Size = New System.Drawing.Size(96, 17)
        Me.lblsales_order_num.TabIndex = 1
        Me.lblsales_order_num.Text = "Sales Order #"
        '
        'lblcust_name
        '
        Me.lblcust_name.AutoSize = True
        Me.lblcust_name.Location = New System.Drawing.Point(12, 155)
        Me.lblcust_name.Name = "lblcust_name"
        Me.lblcust_name.Size = New System.Drawing.Size(109, 17)
        Me.lblcust_name.TabIndex = 2
        Me.lblcust_name.Text = "Customer Name"
        '
        'lblpart_num
        '
        Me.lblpart_num.AutoSize = True
        Me.lblpart_num.Location = New System.Drawing.Point(12, 193)
        Me.lblpart_num.Name = "lblpart_num"
        Me.lblpart_num.Size = New System.Drawing.Size(46, 17)
        Me.lblpart_num.TabIndex = 3
        Me.lblpart_num.Text = "Part #"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Location = New System.Drawing.Point(12, 238)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(79, 17)
        Me.lbldesc.TabIndex = 4
        Me.lbldesc.Text = "Description"
        '
        'lblmemo
        '
        Me.lblmemo.AutoSize = True
        Me.lblmemo.Location = New System.Drawing.Point(12, 271)
        Me.lblmemo.Name = "lblmemo"
        Me.lblmemo.Size = New System.Drawing.Size(46, 17)
        Me.lblmemo.TabIndex = 5
        Me.lblmemo.Text = "Memo"
        '
        'txtjob_num
        '
        Me.txtjob_num.Location = New System.Drawing.Point(143, 79)
        Me.txtjob_num.Name = "txtjob_num"
        Me.txtjob_num.Size = New System.Drawing.Size(144, 22)
        Me.txtjob_num.TabIndex = 6
        '
        'txtsales_num
        '
        Me.txtsales_num.Location = New System.Drawing.Point(143, 117)
        Me.txtsales_num.Name = "txtsales_num"
        Me.txtsales_num.Size = New System.Drawing.Size(144, 22)
        Me.txtsales_num.TabIndex = 7
        '
        'txtcust_name
        '
        Me.txtcust_name.Location = New System.Drawing.Point(143, 150)
        Me.txtcust_name.Name = "txtcust_name"
        Me.txtcust_name.Size = New System.Drawing.Size(276, 22)
        Me.txtcust_name.TabIndex = 8
        '
        'txtpart_num
        '
        Me.txtpart_num.Location = New System.Drawing.Point(143, 188)
        Me.txtpart_num.Name = "txtpart_num"
        Me.txtpart_num.Size = New System.Drawing.Size(144, 22)
        Me.txtpart_num.TabIndex = 9
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(143, 233)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(276, 22)
        Me.txtdesc.TabIndex = 10
        '
        'txtmemo
        '
        Me.txtmemo.Location = New System.Drawing.Point(143, 266)
        Me.txtmemo.Name = "txtmemo"
        Me.txtmemo.Size = New System.Drawing.Size(276, 22)
        Me.txtmemo.TabIndex = 11
        '
        'lbljob_status
        '
        Me.lbljob_status.AutoSize = True
        Me.lbljob_status.Location = New System.Drawing.Point(457, 84)
        Me.lbljob_status.Name = "lbljob_status"
        Me.lbljob_status.Size = New System.Drawing.Size(75, 17)
        Me.lbljob_status.TabIndex = 12
        Me.lbljob_status.Text = "Job Status"
        '
        'lblopen_date
        '
        Me.lblopen_date.AutoSize = True
        Me.lblopen_date.Location = New System.Drawing.Point(457, 140)
        Me.lblopen_date.Name = "lblopen_date"
        Me.lblopen_date.Size = New System.Drawing.Size(77, 17)
        Me.lblopen_date.TabIndex = 13
        Me.lblopen_date.Text = "Open Date"
        '
        'lbldue_date
        '
        Me.lbldue_date.AutoSize = True
        Me.lbldue_date.Location = New System.Drawing.Point(457, 174)
        Me.lbldue_date.Name = "lbldue_date"
        Me.lbldue_date.Size = New System.Drawing.Size(68, 17)
        Me.lbldue_date.TabIndex = 14
        Me.lbldue_date.Text = "Due Date"
        '
        'lblrout_hrs
        '
        Me.lblrout_hrs.AutoSize = True
        Me.lblrout_hrs.Location = New System.Drawing.Point(457, 238)
        Me.lblrout_hrs.Name = "lblrout_hrs"
        Me.lblrout_hrs.Size = New System.Drawing.Size(96, 17)
        Me.lblrout_hrs.TabIndex = 15
        Me.lblrout_hrs.Text = "Routed Hours"
        '
        'lblmake_qty
        '
        Me.lblmake_qty.AutoSize = True
        Me.lblmake_qty.Location = New System.Drawing.Point(457, 271)
        Me.lblmake_qty.Name = "lblmake_qty"
        Me.lblmake_qty.Size = New System.Drawing.Size(99, 17)
        Me.lblmake_qty.TabIndex = 16
        Me.lblmake_qty.Text = "Make Quantity"
        '
        'txtjob_status
        '
        Me.txtjob_status.Location = New System.Drawing.Point(566, 79)
        Me.txtjob_status.Name = "txtjob_status"
        Me.txtjob_status.Size = New System.Drawing.Size(100, 22)
        Me.txtjob_status.TabIndex = 17
        '
        'txtopen_date
        '
        Me.txtopen_date.Location = New System.Drawing.Point(566, 135)
        Me.txtopen_date.Name = "txtopen_date"
        Me.txtopen_date.Size = New System.Drawing.Size(100, 22)
        Me.txtopen_date.TabIndex = 18
        '
        'txtdue_date
        '
        Me.txtdue_date.Location = New System.Drawing.Point(566, 169)
        Me.txtdue_date.Name = "txtdue_date"
        Me.txtdue_date.Size = New System.Drawing.Size(100, 22)
        Me.txtdue_date.TabIndex = 19
        '
        'txtrout_hrs
        '
        Me.txtrout_hrs.Location = New System.Drawing.Point(566, 233)
        Me.txtrout_hrs.Name = "txtrout_hrs"
        Me.txtrout_hrs.Size = New System.Drawing.Size(100, 22)
        Me.txtrout_hrs.TabIndex = 20
        '
        'txtmake_qty
        '
        Me.txtmake_qty.Location = New System.Drawing.Point(566, 266)
        Me.txtmake_qty.Name = "txtmake_qty"
        Me.txtmake_qty.Size = New System.Drawing.Size(100, 22)
        Me.txtmake_qty.TabIndex = 21
        '
        'gbjob_orders
        '
        Me.gbjob_orders.Controls.Add(Me.btncost)
        Me.gbjob_orders.Controls.Add(Me.btnpacket)
        Me.gbjob_orders.Controls.Add(Me.btnrouting)
        Me.gbjob_orders.Controls.Add(Me.btnbom)
        Me.gbjob_orders.Controls.Add(Me.lblcost)
        Me.gbjob_orders.Controls.Add(Me.lblpacket)
        Me.gbjob_orders.Controls.Add(Me.lblrouting)
        Me.gbjob_orders.Controls.Add(Me.lblbom)
        Me.gbjob_orders.Location = New System.Drawing.Point(15, 338)
        Me.gbjob_orders.Name = "gbjob_orders"
        Me.gbjob_orders.Size = New System.Drawing.Size(538, 100)
        Me.gbjob_orders.TabIndex = 23
        Me.gbjob_orders.TabStop = False
        '
        'btncost
        '
        Me.btncost.Location = New System.Drawing.Point(299, 59)
        Me.btncost.Name = "btncost"
        Me.btncost.Size = New System.Drawing.Size(131, 35)
        Me.btncost.TabIndex = 7
        Me.btncost.Text = "Summary"
        Me.btncost.UseVisualStyleBackColor = True
        '
        'btnpacket
        '
        Me.btnpacket.Location = New System.Drawing.Point(299, 15)
        Me.btnpacket.Name = "btnpacket"
        Me.btnpacket.Size = New System.Drawing.Size(131, 35)
        Me.btnpacket.TabIndex = 6
        Me.btnpacket.Text = "Detail"
        Me.btnpacket.UseVisualStyleBackColor = True
        '
        'btnrouting
        '
        Me.btnrouting.Location = New System.Drawing.Point(72, 59)
        Me.btnrouting.Name = "btnrouting"
        Me.btnrouting.Size = New System.Drawing.Size(131, 35)
        Me.btnrouting.TabIndex = 5
        Me.btnrouting.Text = "Detail"
        Me.btnrouting.UseVisualStyleBackColor = True
        '
        'btnbom
        '
        Me.btnbom.Location = New System.Drawing.Point(72, 15)
        Me.btnbom.Name = "btnbom"
        Me.btnbom.Size = New System.Drawing.Size(131, 35)
        Me.btnbom.TabIndex = 4
        Me.btnbom.Text = "Detail"
        Me.btnbom.UseVisualStyleBackColor = True
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Location = New System.Drawing.Point(236, 68)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(36, 17)
        Me.lblcost.TabIndex = 3
        Me.lblcost.Text = "Cost"
        '
        'lblpacket
        '
        Me.lblpacket.AutoSize = True
        Me.lblpacket.Location = New System.Drawing.Point(236, 24)
        Me.lblpacket.Name = "lblpacket"
        Me.lblpacket.Size = New System.Drawing.Size(51, 17)
        Me.lblpacket.TabIndex = 2
        Me.lblpacket.Text = "Packet"
        '
        'lblrouting
        '
        Me.lblrouting.AutoSize = True
        Me.lblrouting.Location = New System.Drawing.Point(6, 68)
        Me.lblrouting.Name = "lblrouting"
        Me.lblrouting.Size = New System.Drawing.Size(57, 17)
        Me.lblrouting.TabIndex = 1
        Me.lblrouting.Text = "Routing"
        '
        'lblbom
        '
        Me.lblbom.AutoSize = True
        Me.lblbom.Location = New System.Drawing.Point(6, 24)
        Me.lblbom.Name = "lblbom"
        Me.lblbom.Size = New System.Drawing.Size(39, 17)
        Me.lblbom.TabIndex = 0
        Me.lblbom.Text = "BOM"
        '
        'job_orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 441)
        Me.Controls.Add(Me.gbjob_orders)
        Me.Controls.Add(Me.txtmake_qty)
        Me.Controls.Add(Me.txtrout_hrs)
        Me.Controls.Add(Me.txtdue_date)
        Me.Controls.Add(Me.txtopen_date)
        Me.Controls.Add(Me.txtjob_status)
        Me.Controls.Add(Me.lblmake_qty)
        Me.Controls.Add(Me.lblrout_hrs)
        Me.Controls.Add(Me.lbldue_date)
        Me.Controls.Add(Me.lblopen_date)
        Me.Controls.Add(Me.lbljob_status)
        Me.Controls.Add(Me.txtmemo)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtpart_num)
        Me.Controls.Add(Me.txtcust_name)
        Me.Controls.Add(Me.txtsales_num)
        Me.Controls.Add(Me.txtjob_num)
        Me.Controls.Add(Me.lblmemo)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.lblpart_num)
        Me.Controls.Add(Me.lblcust_name)
        Me.Controls.Add(Me.lblsales_order_num)
        Me.Controls.Add(Me.lbljob_order_num)
        Me.Name = "job_orders"
        Me.Text = "Job Orders"
        Me.gbjob_orders.ResumeLayout(False)
        Me.gbjob_orders.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljob_order_num As System.Windows.Forms.Label
    Friend WithEvents lblsales_order_num As System.Windows.Forms.Label
    Friend WithEvents lblcust_name As System.Windows.Forms.Label
    Friend WithEvents lblpart_num As System.Windows.Forms.Label
    Friend WithEvents lbldesc As System.Windows.Forms.Label
    Friend WithEvents lblmemo As System.Windows.Forms.Label
    Friend WithEvents txtjob_num As System.Windows.Forms.TextBox
    Friend WithEvents txtsales_num As System.Windows.Forms.TextBox
    Friend WithEvents txtcust_name As System.Windows.Forms.TextBox
    Friend WithEvents txtpart_num As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtmemo As System.Windows.Forms.TextBox
    Friend WithEvents lbljob_status As System.Windows.Forms.Label
    Friend WithEvents lblopen_date As System.Windows.Forms.Label
    Friend WithEvents lbldue_date As System.Windows.Forms.Label
    Friend WithEvents lblrout_hrs As System.Windows.Forms.Label
    Friend WithEvents lblmake_qty As System.Windows.Forms.Label
    Friend WithEvents txtjob_status As System.Windows.Forms.TextBox
    Friend WithEvents txtopen_date As System.Windows.Forms.TextBox
    Friend WithEvents txtdue_date As System.Windows.Forms.TextBox
    Friend WithEvents txtrout_hrs As System.Windows.Forms.TextBox
    Friend WithEvents txtmake_qty As System.Windows.Forms.TextBox
    Friend WithEvents gbjob_orders As System.Windows.Forms.GroupBox
    Friend WithEvents btncost As System.Windows.Forms.Button
    Friend WithEvents btnpacket As System.Windows.Forms.Button
    Friend WithEvents btnrouting As System.Windows.Forms.Button
    Friend WithEvents btnbom As System.Windows.Forms.Button
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents lblpacket As System.Windows.Forms.Label
    Friend WithEvents lblrouting As System.Windows.Forms.Label
    Friend WithEvents lblbom As System.Windows.Forms.Label
End Class
