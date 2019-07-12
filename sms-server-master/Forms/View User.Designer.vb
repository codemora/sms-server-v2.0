<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_User
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
        Me.components = New System.ComponentModel.Container()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.upload = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPrivilege = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(137, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 32)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "VIEW USER DETAILS"
        '
        'upload
        '
        Me.upload.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblActive)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.lblPrivilege)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.lblFullname)
        Me.Panel1.Location = New System.Drawing.Point(15, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 184)
        Me.Panel1.TabIndex = 93
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.BackColor = System.Drawing.Color.Red
        Me.lblActive.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.White
        Me.lblActive.Location = New System.Drawing.Point(160, 136)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(112, 21)
        Me.lblActive.TabIndex = 116
        Me.lblActive.Text = "Deactivated"
        Me.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sms_server_master.My.Resources.Resources.Profile_Image
        Me.PictureBox1.Location = New System.Drawing.Point(13, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.Silver
        Me.lblPhone.Location = New System.Drawing.Point(160, 110)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 21)
        Me.lblPhone.TabIndex = 107
        Me.lblPhone.Text = "0573235605"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrivilege
        '
        Me.lblPrivilege.AutoSize = True
        Me.lblPrivilege.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrivilege.ForeColor = System.Drawing.Color.Silver
        Me.lblPrivilege.Location = New System.Drawing.Point(160, 84)
        Me.lblPrivilege.Name = "lblPrivilege"
        Me.lblPrivilege.Size = New System.Drawing.Size(62, 21)
        Me.lblPrivilege.TabIndex = 106
        Me.lblPrivilege.Text = "Admin"
        Me.lblPrivilege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Silver
        Me.lblUsername.Location = New System.Drawing.Point(160, 58)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(59, 21)
        Me.lblUsername.TabIndex = 104
        Me.lblUsername.Text = "@PJ45"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullname
        '
        Me.lblFullname.AutoEllipsis = True
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.White
        Me.lblFullname.Location = New System.Drawing.Point(160, 25)
        Me.lblFullname.MaximumSize = New System.Drawing.Size(300, 28)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(118, 28)
        Me.lblFullname.TabIndex = 102
        Me.lblFullname.Text = "Fullname"
        Me.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_User
        '
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(510, 258)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "View_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View User"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents upload As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblPrivilege As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblFullname As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblActive As Label
End Class
