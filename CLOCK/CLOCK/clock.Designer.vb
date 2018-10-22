<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class clock
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblfunction = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.lbljob = New System.Windows.Forms.Label()
        Me.lbloperation = New System.Windows.Forms.Label()
        Me.txtfunction = New System.Windows.Forms.TextBox()
        Me.txtemployee = New System.Windows.Forms.TextBox()
        Me.txtjob = New System.Windows.Forms.TextBox()
        Me.txtoperation = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.dgvresults = New System.Windows.Forms.DataGridView()
        CType(Me.dgvresults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblfunction
        '
        Me.lblfunction.AutoSize = True
        Me.lblfunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfunction.Location = New System.Drawing.Point(39, 35)
        Me.lblfunction.Name = "lblfunction"
        Me.lblfunction.Size = New System.Drawing.Size(87, 25)
        Me.lblfunction.TabIndex = 1
        Me.lblfunction.Text = "Function"
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployee.Location = New System.Drawing.Point(39, 127)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(115, 25)
        Me.lblemployee.TabIndex = 2
        Me.lblemployee.Text = "Employee #"
        '
        'lbljob
        '
        Me.lbljob.AutoSize = True
        Me.lbljob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljob.Location = New System.Drawing.Point(39, 236)
        Me.lbljob.Name = "lbljob"
        Me.lbljob.Size = New System.Drawing.Size(61, 25)
        Me.lbljob.TabIndex = 3
        Me.lbljob.Text = "Job #"
        '
        'lbloperation
        '
        Me.lbloperation.AutoSize = True
        Me.lbloperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperation.Location = New System.Drawing.Point(39, 349)
        Me.lbloperation.Name = "lbloperation"
        Me.lbloperation.Size = New System.Drawing.Size(98, 25)
        Me.lbloperation.TabIndex = 4
        Me.lbloperation.Text = "Operation"
        '
        'txtfunction
        '
        Me.txtfunction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfunction.Location = New System.Drawing.Point(44, 75)
        Me.txtfunction.Name = "txtfunction"
        Me.txtfunction.Size = New System.Drawing.Size(180, 30)
        Me.txtfunction.TabIndex = 5
        '
        'txtemployee
        '
        Me.txtemployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployee.Location = New System.Drawing.Point(44, 180)
        Me.txtemployee.Name = "txtemployee"
        Me.txtemployee.Size = New System.Drawing.Size(180, 30)
        Me.txtemployee.TabIndex = 6
        '
        'txtjob
        '
        Me.txtjob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjob.Location = New System.Drawing.Point(44, 288)
        Me.txtjob.Name = "txtjob"
        Me.txtjob.Size = New System.Drawing.Size(180, 30)
        Me.txtjob.TabIndex = 7
        '
        'txtoperation
        '
        Me.txtoperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoperation.Location = New System.Drawing.Point(44, 401)
        Me.txtoperation.Name = "txtoperation"
        Me.txtoperation.Size = New System.Drawing.Size(180, 30)
        Me.txtoperation.TabIndex = 8
        '
        'lbldate
        '
        Me.lbldate.BackColor = System.Drawing.Color.LightCoral
        Me.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(44, 473)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(388, 55)
        Me.lbldate.TabIndex = 9
        '
        'dgvresults
        '
        Me.dgvresults.AllowUserToAddRows = False
        Me.dgvresults.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvresults.Enabled = False
        Me.dgvresults.Location = New System.Drawing.Point(269, 35)
        Me.dgvresults.Name = "dgvresults"
        Me.dgvresults.RowTemplate.Height = 24
        Me.dgvresults.Size = New System.Drawing.Size(729, 415)
        Me.dgvresults.TabIndex = 10
        Me.dgvresults.Visible = False
        '
        'clock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 537)
        Me.Controls.Add(Me.dgvresults)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.txtoperation)
        Me.Controls.Add(Me.txtjob)
        Me.Controls.Add(Me.txtemployee)
        Me.Controls.Add(Me.txtfunction)
        Me.Controls.Add(Me.lbloperation)
        Me.Controls.Add(Me.lbljob)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblfunction)
        Me.Name = "clock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clock"
        CType(Me.dgvresults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblfunction As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents lbljob As System.Windows.Forms.Label
    Friend WithEvents lbloperation As System.Windows.Forms.Label
    Friend WithEvents txtfunction As System.Windows.Forms.TextBox
    Friend WithEvents txtemployee As System.Windows.Forms.TextBox
    Friend WithEvents txtjob As System.Windows.Forms.TextBox
    Friend WithEvents txtoperation As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents dgvresults As System.Windows.Forms.DataGridView

End Class
