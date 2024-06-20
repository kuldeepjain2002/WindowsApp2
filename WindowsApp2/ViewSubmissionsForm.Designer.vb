<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        Me.lblViewsubmissions = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.lblGit = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtVname = New System.Windows.Forms.TextBox()
        Me.txtVemail = New System.Windows.Forms.TextBox()
        Me.txtVphone = New System.Windows.Forms.TextBox()
        Me.txtVgit = New System.Windows.Forms.TextBox()
        Me.txtVstopwatch = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblViewsubmissions
        '
        Me.lblViewsubmissions.AutoSize = True
        Me.lblViewsubmissions.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewsubmissions.Location = New System.Drawing.Point(111, 42)
        Me.lblViewsubmissions.Name = "lblViewsubmissions"
        Me.lblViewsubmissions.Size = New System.Drawing.Size(555, 28)
        Me.lblViewsubmissions.TabIndex = 12
        Me.lblViewsubmissions.Text = "Kuldeep Jain Dugar, Slidely Task 2 - View Submissions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Stopwatch Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "GitHub Link for task 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Phone Num"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name"
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.LightGray
        Me.lblName.Location = New System.Drawing.Point(371, 155)
        Me.lblName.Name = "lblName"
        Me.lblName.Padding = New System.Windows.Forms.Padding(2)
        Me.lblName.Size = New System.Drawing.Size(400, 30)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Label6"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(72, 556)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(247, 46)
        Me.btnPrevious.TabIndex = 23
        Me.btnPrevious.Text = "Previous (Ctrl + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(483, 556)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(247, 46)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "Next (Ctrl + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.LightGray
        Me.lblEmail.Location = New System.Drawing.Point(371, 222)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Padding = New System.Windows.Forms.Padding(2)
        Me.lblEmail.Size = New System.Drawing.Size(400, 30)
        Me.lblEmail.TabIndex = 25
        Me.lblEmail.Text = "Label6"
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.LightGray
        Me.lblPhone.Location = New System.Drawing.Point(371, 294)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Padding = New System.Windows.Forms.Padding(2)
        Me.lblPhone.Size = New System.Drawing.Size(400, 30)
        Me.lblPhone.TabIndex = 26
        Me.lblPhone.Text = "Label6"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BackColor = System.Drawing.Color.LightGray
        Me.lblStopwatch.Location = New System.Drawing.Point(371, 437)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Padding = New System.Windows.Forms.Padding(2)
        Me.lblStopwatch.Size = New System.Drawing.Size(400, 30)
        Me.lblStopwatch.TabIndex = 27
        Me.lblStopwatch.Text = "Label6"
        '
        'lblGit
        '
        Me.lblGit.BackColor = System.Drawing.Color.LightGray
        Me.lblGit.Location = New System.Drawing.Point(371, 367)
        Me.lblGit.Name = "lblGit"
        Me.lblGit.Padding = New System.Windows.Forms.Padding(2)
        Me.lblGit.Size = New System.Drawing.Size(400, 30)
        Me.lblGit.TabIndex = 28
        Me.lblGit.Text = "Label6"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Location = New System.Drawing.Point(619, 661)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 40)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.AllowDrop = True
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Info
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.Location = New System.Drawing.Point(72, 661)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(115, 40)
        Me.btnEdit.TabIndex = 30
        Me.btnEdit.Text = "Edit Submission"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtVname
        '
        Me.txtVname.Location = New System.Drawing.Point(357, 155)
        Me.txtVname.Name = "txtVname"
        Me.txtVname.Size = New System.Drawing.Size(395, 31)
        Me.txtVname.TabIndex = 31
        Me.txtVname.Visible = False
        '
        'txtVemail
        '
        Me.txtVemail.Location = New System.Drawing.Point(357, 219)
        Me.txtVemail.Name = "txtVemail"
        Me.txtVemail.Size = New System.Drawing.Size(395, 31)
        Me.txtVemail.TabIndex = 32
        Me.txtVemail.Visible = False
        '
        'txtVphone
        '
        Me.txtVphone.Location = New System.Drawing.Point(357, 291)
        Me.txtVphone.Name = "txtVphone"
        Me.txtVphone.Size = New System.Drawing.Size(395, 31)
        Me.txtVphone.TabIndex = 33
        Me.txtVphone.Visible = False
        '
        'txtVgit
        '
        Me.txtVgit.Location = New System.Drawing.Point(357, 364)
        Me.txtVgit.Name = "txtVgit"
        Me.txtVgit.Size = New System.Drawing.Size(395, 31)
        Me.txtVgit.TabIndex = 34
        Me.txtVgit.Visible = False
        '
        'txtVstopwatch
        '
        Me.txtVstopwatch.Location = New System.Drawing.Point(357, 437)
        Me.txtVstopwatch.Name = "txtVstopwatch"
        Me.txtVstopwatch.Size = New System.Drawing.Size(395, 31)
        Me.txtVstopwatch.TabIndex = 35
        Me.txtVstopwatch.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGreen
        Me.btnSave.Location = New System.Drawing.Point(376, 637)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 44)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 726)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtVstopwatch)
        Me.Controls.Add(Me.txtVgit)
        Me.Controls.Add(Me.txtVphone)
        Me.Controls.Add(Me.txtVemail)
        Me.Controls.Add(Me.txtVname)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblGit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblViewsubmissions)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "ViewSubmissionsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblViewsubmissions As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents lblGit As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtVname As TextBox
    Friend WithEvents txtVemail As TextBox
    Friend WithEvents txtVphone As TextBox
    Friend WithEvents txtVgit As TextBox
    Friend WithEvents txtVstopwatch As TextBox
    Friend WithEvents btnSave As Button
End Class
