<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxln = New System.Windows.Forms.TextBox()
        Me.TextBoxfn = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Labelfn = New System.Windows.Forms.Label()
        Me.Labelln = New System.Windows.Forms.Label()
        Me.Labelun = New System.Windows.Forms.Label()
        Me.Labelpass = New System.Windows.Forms.Label()
        Me.TextBoxun = New System.Windows.Forms.TextBox()
        Me.TextBoxpass = New System.Windows.Forms.TextBox()
        Me.Labelgen = New System.Windows.Forms.Label()
        Me.Labeloc = New System.Windows.Forms.Label()
        Me.Labeladd = New System.Windows.Forms.Label()
        Me.Labelage = New System.Windows.Forms.Label()
        Me.TextBoxadd = New System.Windows.Forms.TextBox()
        Me.TextBoxage = New System.Windows.Forms.TextBox()
        Me.TextBoxocc = New System.Windows.Forms.TextBox()
        Me.RadioButtonmale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonfemale = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.RadioButtonfemale)
        Me.Panel2.Controls.Add(Me.RadioButtonmale)
        Me.Panel2.Controls.Add(Me.TextBoxocc)
        Me.Panel2.Controls.Add(Me.TextBoxage)
        Me.Panel2.Controls.Add(Me.TextBoxadd)
        Me.Panel2.Controls.Add(Me.Labelage)
        Me.Panel2.Controls.Add(Me.Labeladd)
        Me.Panel2.Controls.Add(Me.Labeloc)
        Me.Panel2.Controls.Add(Me.Labelgen)
        Me.Panel2.Controls.Add(Me.TextBoxpass)
        Me.Panel2.Controls.Add(Me.TextBoxun)
        Me.Panel2.Controls.Add(Me.Labelpass)
        Me.Panel2.Controls.Add(Me.Labelun)
        Me.Panel2.Controls.Add(Me.Labelln)
        Me.Panel2.Controls.Add(Me.Labelfn)
        Me.Panel2.Controls.Add(Me.TextBoxln)
        Me.Panel2.Controls.Add(Me.TextBoxfn)
        Me.Panel2.Controls.Add(Me.ButtonRegister)
        Me.Panel2.Controls.Add(Me.ButtonClose)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(13, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 425)
        Me.Panel2.TabIndex = 0
        '
        'TextBoxln
        '
        Me.TextBoxln.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxln.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxln.Location = New System.Drawing.Point(123, 109)
        Me.TextBoxln.Name = "TextBoxln"
        Me.TextBoxln.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxln.TabIndex = 4
        '
        'TextBoxfn
        '
        Me.TextBoxfn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxfn.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxfn.Location = New System.Drawing.Point(123, 55)
        Me.TextBoxfn.Name = "TextBoxfn"
        Me.TextBoxfn.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxfn.TabIndex = 3
        '
        'ButtonRegister
        '
        Me.ButtonRegister.BackColor = System.Drawing.Color.DarkGreen
        Me.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRegister.Location = New System.Drawing.Point(288, 301)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(215, 45)
        Me.ButtonRegister.TabIndex = 2
        Me.ButtonRegister.Text = "SIGN UP"
        Me.ButtonRegister.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.Red
        Me.ButtonClose.Location = New System.Drawing.Point(728, 3)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(44, 37)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(719, 37)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Patient Registration"
        '
        'Labelfn
        '
        Me.Labelfn.AutoSize = True
        Me.Labelfn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfn.Location = New System.Drawing.Point(10, 67)
        Me.Labelfn.Name = "Labelfn"
        Me.Labelfn.Size = New System.Drawing.Size(96, 20)
        Me.Labelfn.TabIndex = 5
        Me.Labelfn.Text = "First Name"
        '
        'Labelln
        '
        Me.Labelln.AutoSize = True
        Me.Labelln.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelln.Location = New System.Drawing.Point(10, 118)
        Me.Labelln.Name = "Labelln"
        Me.Labelln.Size = New System.Drawing.Size(93, 20)
        Me.Labelln.TabIndex = 6
        Me.Labelln.Text = "Last name"
        '
        'Labelun
        '
        Me.Labelun.AutoSize = True
        Me.Labelun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelun.Location = New System.Drawing.Point(378, 67)
        Me.Labelun.Name = "Labelun"
        Me.Labelun.Size = New System.Drawing.Size(91, 20)
        Me.Labelun.TabIndex = 7
        Me.Labelun.Text = "Username"
        '
        'Labelpass
        '
        Me.Labelpass.AutoSize = True
        Me.Labelpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpass.Location = New System.Drawing.Point(378, 118)
        Me.Labelpass.Name = "Labelpass"
        Me.Labelpass.Size = New System.Drawing.Size(86, 20)
        Me.Labelpass.TabIndex = 8
        Me.Labelpass.Text = "Password"
        '
        'TextBoxun
        '
        Me.TextBoxun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxun.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxun.Location = New System.Drawing.Point(485, 55)
        Me.TextBoxun.Name = "TextBoxun"
        Me.TextBoxun.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxun.TabIndex = 9
        '
        'TextBoxpass
        '
        Me.TextBoxpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxpass.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxpass.Location = New System.Drawing.Point(485, 109)
        Me.TextBoxpass.Name = "TextBoxpass"
        Me.TextBoxpass.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxpass.TabIndex = 10
        '
        'Labelgen
        '
        Me.Labelgen.AutoSize = True
        Me.Labelgen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelgen.Location = New System.Drawing.Point(378, 224)
        Me.Labelgen.Name = "Labelgen"
        Me.Labelgen.Size = New System.Drawing.Size(69, 20)
        Me.Labelgen.TabIndex = 11
        Me.Labelgen.Text = "Gender"
        '
        'Labeloc
        '
        Me.Labeloc.AutoSize = True
        Me.Labeloc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeloc.Location = New System.Drawing.Point(10, 171)
        Me.Labeloc.Name = "Labeloc"
        Me.Labeloc.Size = New System.Drawing.Size(100, 20)
        Me.Labeloc.TabIndex = 12
        Me.Labeloc.Text = "Occupation"
        '
        'Labeladd
        '
        Me.Labeladd.AutoSize = True
        Me.Labeladd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeladd.Location = New System.Drawing.Point(378, 171)
        Me.Labeladd.Name = "Labeladd"
        Me.Labeladd.Size = New System.Drawing.Size(75, 20)
        Me.Labeladd.TabIndex = 13
        Me.Labeladd.Text = "Address"
        '
        'Labelage
        '
        Me.Labelage.AutoSize = True
        Me.Labelage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelage.Location = New System.Drawing.Point(10, 224)
        Me.Labelage.Name = "Labelage"
        Me.Labelage.Size = New System.Drawing.Size(41, 20)
        Me.Labelage.TabIndex = 14
        Me.Labelage.Text = "Age"
        '
        'TextBoxadd
        '
        Me.TextBoxadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxadd.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxadd.Location = New System.Drawing.Point(485, 162)
        Me.TextBoxadd.Name = "TextBoxadd"
        Me.TextBoxadd.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxadd.TabIndex = 16
        '
        'TextBoxage
        '
        Me.TextBoxage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxage.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxage.Location = New System.Drawing.Point(123, 215)
        Me.TextBoxage.Name = "TextBoxage"
        Me.TextBoxage.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxage.TabIndex = 17
        '
        'TextBoxocc
        '
        Me.TextBoxocc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxocc.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxocc.Location = New System.Drawing.Point(123, 162)
        Me.TextBoxocc.Name = "TextBoxocc"
        Me.TextBoxocc.Size = New System.Drawing.Size(215, 29)
        Me.TextBoxocc.TabIndex = 18
        '
        'RadioButtonmale
        '
        Me.RadioButtonmale.AutoSize = True
        Me.RadioButtonmale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonmale.Location = New System.Drawing.Point(485, 224)
        Me.RadioButtonmale.Name = "RadioButtonmale"
        Me.RadioButtonmale.Size = New System.Drawing.Size(56, 20)
        Me.RadioButtonmale.TabIndex = 19
        Me.RadioButtonmale.TabStop = True
        Me.RadioButtonmale.Text = "Male"
        Me.RadioButtonmale.UseVisualStyleBackColor = True
        '
        'RadioButtonfemale
        '
        Me.RadioButtonfemale.AutoSize = True
        Me.RadioButtonfemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonfemale.Location = New System.Drawing.Point(589, 224)
        Me.RadioButtonfemale.Name = "RadioButtonfemale"
        Me.RadioButtonfemale.Size = New System.Drawing.Size(72, 20)
        Me.RadioButtonfemale.TabIndex = 20
        Me.RadioButtonfemale.TabStop = True
        Me.RadioButtonfemale.Text = "Female"
        Me.RadioButtonfemale.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(256, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Already have an Account !! Sign In !!"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxln As TextBox
    Friend WithEvents TextBoxfn As TextBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonfemale As RadioButton
    Friend WithEvents RadioButtonmale As RadioButton
    Friend WithEvents TextBoxocc As TextBox
    Friend WithEvents TextBoxage As TextBox
    Friend WithEvents TextBoxadd As TextBox
    Friend WithEvents Labelage As Label
    Friend WithEvents Labeladd As Label
    Friend WithEvents Labeloc As Label
    Friend WithEvents Labelgen As Label
    Friend WithEvents TextBoxpass As TextBox
    Friend WithEvents TextBoxun As TextBox
    Friend WithEvents Labelpass As Label
    Friend WithEvents Labelun As Label
    Friend WithEvents Labelln As Label
    Friend WithEvents Labelfn As Label
    Friend WithEvents Label2 As Label
End Class
