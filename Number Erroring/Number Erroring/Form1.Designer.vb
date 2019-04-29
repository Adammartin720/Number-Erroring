<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfirstnumber = New System.Windows.Forms.TextBox()
        Me.txtsecondnumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncal = New System.Windows.Forms.Button()
        Me.lblerrormsg = New System.Windows.Forms.Label()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Second Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "/"
        '
        'txtfirstnumber
        '
        Me.txtfirstnumber.Location = New System.Drawing.Point(117, 9)
        Me.txtfirstnumber.Name = "txtfirstnumber"
        Me.txtfirstnumber.Size = New System.Drawing.Size(134, 20)
        Me.txtfirstnumber.TabIndex = 5
        '
        'txtsecondnumber
        '
        Me.txtsecondnumber.Location = New System.Drawing.Point(117, 59)
        Me.txtsecondnumber.Name = "txtsecondnumber"
        Me.txtsecondnumber.Size = New System.Drawing.Size(134, 20)
        Me.txtsecondnumber.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "="
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(269, 128)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(104, 23)
        Me.btncal.TabIndex = 9
        Me.btncal.Text = "Calculate"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'lblerrormsg
        '
        Me.lblerrormsg.AutoSize = True
        Me.lblerrormsg.Location = New System.Drawing.Point(10, 133)
        Me.lblerrormsg.Name = "lblerrormsg"
        Me.lblerrormsg.Size = New System.Drawing.Size(220, 13)
        Me.lblerrormsg.TabIndex = 10
        Me.lblerrormsg.Text = "One of the entries is not a number! Try Again!"
        Me.lblerrormsg.Visible = False
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(278, 96)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(42, 13)
        Me.lblanswer.TabIndex = 11
        Me.lblanswer.Text = "Answer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 160)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblerrormsg)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsecondnumber)
        Me.Controls.Add(Me.txtfirstnumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtfirstnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtsecondnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents lblerrormsg As System.Windows.Forms.Label
    Friend WithEvents lblanswer As System.Windows.Forms.Label

End Class
