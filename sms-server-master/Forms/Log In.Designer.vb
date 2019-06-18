<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log_In
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log_In))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.pboxEye = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pboxEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Controls.Add(Me.pboxEye)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(477, 423)
        Me.Panel1.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.Color.Transparent
        Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(184, 305)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(212, 32)
        Me.lblError.TabIndex = 19
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pboxEye
        '
        Me.pboxEye.BackColor = System.Drawing.SystemColors.Window
        Me.pboxEye.Image = Global.sms_server_master.My.Resources.Resources.eye_1
        Me.pboxEye.Location = New System.Drawing.Point(368, 270)
        Me.pboxEye.Name = "pboxEye"
        Me.pboxEye.Padding = New System.Windows.Forms.Padding(2)
        Me.pboxEye.Size = New System.Drawing.Size(28, 31)
        Me.pboxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pboxEye.TabIndex = 18
        Me.pboxEye.TabStop = False
        Me.pboxEye.Visible = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(187, 269)
        Me.txtPassword.MaxLength = 16
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(210, 33)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(141, 269)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(141, 218)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(217, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LOGIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.sms_server_master.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(220, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.LightBlue
        Me.btnCancel.Location = New System.Drawing.Point(302, 340)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 37)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.LightBlue
        Me.btnOk.Location = New System.Drawing.Point(187, 340)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(95, 37)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Maroon
        Me.txtUsername.Location = New System.Drawing.Point(187, 218)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(210, 33)
        Me.txtUsername.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 41)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Log_In
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(477, 423)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Log_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pboxEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents pboxEye As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
