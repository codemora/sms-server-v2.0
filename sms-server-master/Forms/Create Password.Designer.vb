<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Create_Password
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSecurityQuestion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pboxEye = New System.Windows.Forms.PictureBox()
        CType(Me.pboxEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(325, 252)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 37)
        Me.btnReset.TabIndex = 97
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 28)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Create Password"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(179, 252)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 37)
        Me.btnSave.TabIndex = 96
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecurityAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(177, 106)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(370, 29)
        Me.txtSecurityAnswer.TabIndex = 94
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(20, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 21)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Security Question"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSecurityQuestion
        '
        Me.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSecurityQuestion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecurityQuestion.FormattingEnabled = True
        Me.cmbSecurityQuestion.Items.AddRange(New Object() {"-----------------SELECT QUESTION-----------------", "Where did you go to high school?", "Which city were you born in?", "What is your favorite food?", "What was the first company you worked for?", "What is your mother's maiden name?", "What is your favorite color?", "What is the first name of your first child?", "What are the last 4 digits of your phone number?", "What is the maiden name of your spouse?", "What is the name of your favorite childhood friend?"})
        Me.cmbSecurityQuestion.Location = New System.Drawing.Point(177, 64)
        Me.cmbSecurityQuestion.Name = "cmbSecurityQuestion"
        Me.cmbSecurityQuestion.Size = New System.Drawing.Size(370, 29)
        Me.cmbSecurityQuestion.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 21)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Question Answer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(177, 190)
        Me.txtConfirmPassword.MaxLength = 16
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(243, 29)
        Me.txtConfirmPassword.TabIndex = 103
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(177, 148)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(243, 29)
        Me.txtPassword.TabIndex = 101
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 21)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Comfirm Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pboxEye
        '
        Me.pboxEye.BackColor = System.Drawing.SystemColors.Window
        Me.pboxEye.Image = Global.sms_server_master.My.Resources.Resources.eye_1
        Me.pboxEye.Location = New System.Drawing.Point(390, 191)
        Me.pboxEye.Name = "pboxEye"
        Me.pboxEye.Padding = New System.Windows.Forms.Padding(2)
        Me.pboxEye.Size = New System.Drawing.Size(28, 27)
        Me.pboxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxEye.TabIndex = 104
        Me.pboxEye.TabStop = False
        Me.pboxEye.Visible = False
        '
        'Create_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(571, 325)
        Me.Controls.Add(Me.pboxEye)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSecurityAnswer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSecurityQuestion)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Create_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Password"
        CType(Me.pboxEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSecurityQuestion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pboxEye As PictureBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
