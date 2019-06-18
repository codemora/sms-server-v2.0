<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_User
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.upload = New System.Windows.Forms.OpenFileDialog()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtOtherNames = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbPrivilege = New System.Windows.Forms.ComboBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(329, 318)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 37)
        Me.btnReset.TabIndex = 90
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(243, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 28)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "ADD USER"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(183, 318)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 37)
        Me.btnSave.TabIndex = 89
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'upload
        '
        Me.upload.FileName = "OpenFileDialog1"
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(551, 227)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(68, 34)
        Me.btnRemove.TabIndex = 97
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.White
        Me.btnUpload.Location = New System.Drawing.Point(460, 227)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(85, 34)
        Me.btnUpload.TabIndex = 96
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.sms_server_master.My.Resources.Resources._001_user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(460, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhone.Location = New System.Drawing.Point(183, 232)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(245, 29)
        Me.txtPhone.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Phone"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(183, 96)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(245, 29)
        Me.txtLastName.TabIndex = 79
        '
        'txtOtherNames
        '
        Me.txtOtherNames.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherNames.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOtherNames.Location = New System.Drawing.Point(183, 142)
        Me.txtOtherNames.Name = "txtOtherNames"
        Me.txtOtherNames.Size = New System.Drawing.Size(245, 29)
        Me.txtOtherNames.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 21)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Other Names"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 21)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "Privilege Level"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPrivilege
        '
        Me.cmbPrivilege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrivilege.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrivilege.FormattingEnabled = True
        Me.cmbPrivilege.Items.AddRange(New Object() {"----SELECT LEVEL----", "ADMIN", "USER"})
        Me.cmbPrivilege.Location = New System.Drawing.Point(183, 50)
        Me.cmbPrivilege.Name = "cmbPrivilege"
        Me.cmbPrivilege.Size = New System.Drawing.Size(244, 29)
        Me.cmbPrivilege.TabIndex = 78
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(183, 188)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(245, 29)
        Me.txtUsername.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 21)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "User Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 21)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Last Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Lime
        Me.lblMsg.Location = New System.Drawing.Point(26, 268)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(593, 34)
        Me.lblMsg.TabIndex = 99
        Me.lblMsg.Text = "Registeration Successful"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMsg.Visible = False
        '
        'Add_User
        '
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(653, 376)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtOtherNames)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbPrivilege)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Add_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtOtherNames As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbPrivilege As ComboBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents upload As OpenFileDialog
    Friend WithEvents Timer1 As Timer
End Class
