<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Staff
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lboxKeysAccessible = New System.Windows.Forms.ListBox()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblFullname = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblDepartment)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.lboxKeysAccessible)
        Me.Panel1.Controls.Add(Me.lblActive)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.lblGender)
        Me.Panel1.Controls.Add(Me.lblRef)
        Me.Panel1.Controls.Add(Me.lblFullname)
        Me.Panel1.Location = New System.Drawing.Point(21, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 467)
        Me.Panel1.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 211)
        Me.Label3.MaximumSize = New System.Drawing.Size(400, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "Keys Accessible"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoEllipsis = True
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.Silver
        Me.lblDepartment.Location = New System.Drawing.Point(9, 164)
        Me.lblDepartment.MaximumSize = New System.Drawing.Size(540, 21)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(243, 21)
        Me.lblDepartment.TabIndex = 119
        Me.lblDepartment.Text = "Department: Security Services"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPosition
        '
        Me.lblPosition.AutoEllipsis = True
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ForeColor = System.Drawing.Color.Silver
        Me.lblPosition.Location = New System.Drawing.Point(9, 188)
        Me.lblPosition.MaximumSize = New System.Drawing.Size(540, 21)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(203, 21)
        Me.lblPosition.TabIndex = 118
        Me.lblPosition.Text = "Position: National Service"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lboxKeysAccessible
        '
        Me.lboxKeysAccessible.BackColor = System.Drawing.Color.SeaGreen
        Me.lboxKeysAccessible.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxKeysAccessible.ForeColor = System.Drawing.Color.White
        Me.lboxKeysAccessible.FormattingEnabled = True
        Me.lboxKeysAccessible.ItemHeight = 21
        Me.lboxKeysAccessible.Location = New System.Drawing.Point(13, 232)
        Me.lboxKeysAccessible.Name = "lboxKeysAccessible"
        Me.lboxKeysAccessible.Size = New System.Drawing.Size(541, 214)
        Me.lboxKeysAccessible.TabIndex = 117
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
        'lblContact
        '
        Me.lblContact.AutoEllipsis = True
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.ForeColor = System.Drawing.Color.Silver
        Me.lblContact.Location = New System.Drawing.Point(160, 110)
        Me.lblContact.MaximumSize = New System.Drawing.Size(400, 21)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(376, 21)
        Me.lblContact.TabIndex = 107
        Me.lblContact.Text = "0573235605 | emmanuel.ofori.stu@uenr.edu.gh"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Silver
        Me.lblGender.Location = New System.Drawing.Point(160, 84)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(49, 21)
        Me.lblGender.TabIndex = 106
        Me.lblGender.Text = "Male"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.BackColor = System.Drawing.Color.Transparent
        Me.lblRef.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.ForeColor = System.Drawing.Color.Silver
        Me.lblRef.Location = New System.Drawing.Point(160, 58)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(59, 21)
        Me.lblRef.TabIndex = 104
        Me.lblRef.Text = "@PJ45"
        Me.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullname
        '
        Me.lblFullname.AutoEllipsis = True
        Me.lblFullname.AutoSize = True
        Me.lblFullname.BackColor = System.Drawing.Color.Transparent
        Me.lblFullname.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullname.ForeColor = System.Drawing.Color.White
        Me.lblFullname.Location = New System.Drawing.Point(160, 25)
        Me.lblFullname.MaximumSize = New System.Drawing.Size(400, 28)
        Me.lblFullname.Name = "lblFullname"
        Me.lblFullname.Size = New System.Drawing.Size(118, 28)
        Me.lblFullname.TabIndex = 102
        Me.lblFullname.Text = "Fullname"
        Me.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(190, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 32)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "VIEW STAFF DETAILS"
        '
        'View_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(619, 531)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "View_Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblActive As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblRef As Label
    Friend WithEvents lblFullname As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lboxKeysAccessible As ListBox
End Class
