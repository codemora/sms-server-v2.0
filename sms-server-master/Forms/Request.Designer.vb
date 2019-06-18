<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Request
    Inherits MetroFramework.Forms.MetroForm

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
        Me.lvRequestedKeys = New System.Windows.Forms.ListView()
        Me.keyTag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.key_location = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.lvRequestedKeys)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnDeny)
        Me.Panel1.Controls.Add(Me.btnApprove)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblAction)
        Me.Panel1.Controls.Add(Me.lblInfo)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 494)
        Me.Panel1.TabIndex = 0
        '
        'lvRequestedKeys
        '
        Me.lvRequestedKeys.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvRequestedKeys.BackColor = System.Drawing.Color.SeaGreen
        Me.lvRequestedKeys.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRequestedKeys.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.keyTag, Me.key_location})
        Me.lvRequestedKeys.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvRequestedKeys.ForeColor = System.Drawing.Color.White
        Me.lvRequestedKeys.FullRowSelect = True
        Me.lvRequestedKeys.GridLines = True
        Me.lvRequestedKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRequestedKeys.Location = New System.Drawing.Point(274, 84)
        Me.lvRequestedKeys.MultiSelect = False
        Me.lvRequestedKeys.Name = "lvRequestedKeys"
        Me.lvRequestedKeys.ShowItemToolTips = True
        Me.lvRequestedKeys.Size = New System.Drawing.Size(269, 275)
        Me.lvRequestedKeys.TabIndex = 219
        Me.lvRequestedKeys.UseCompatibleStateImageBehavior = False
        Me.lvRequestedKeys.View = System.Windows.Forms.View.Details
        '
        'keyTag
        '
        Me.keyTag.Text = "Key Tag"
        Me.keyTag.Width = 131
        '
        'key_location
        '
        Me.key_location.Text = "Location"
        Me.key_location.Width = 138
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(56, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 217
        Me.PictureBox1.TabStop = False
        '
        'btnDeny
        '
        Me.btnDeny.BackColor = System.Drawing.Color.Maroon
        Me.btnDeny.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeny.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeny.ForeColor = System.Drawing.Color.White
        Me.btnDeny.Location = New System.Drawing.Point(291, 409)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(174, 46)
        Me.btnDeny.TabIndex = 218
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(71, 409)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(174, 46)
        Me.btnApprove.TabIndex = 216
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDate.Location = New System.Drawing.Point(0, 43)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(578, 16)
        Me.lblDate.TabIndex = 223
        Me.lblDate.Text = "Label4"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAction
        '
        Me.lblAction.AutoEllipsis = True
        Me.lblAction.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAction.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.White
        Me.lblAction.Location = New System.Drawing.Point(0, 0)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(578, 43)
        Me.lblAction.TabIndex = 222
        Me.lblAction.Text = "CheckIn Request"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblInfo
        '
        Me.lblInfo.AutoEllipsis = True
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(17, 282)
        Me.lblInfo.MaximumSize = New System.Drawing.Size(250, 350)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(249, 85)
        Me.lblInfo.TabIndex = 221
        Me.lblInfo.Text = "Male" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Department: Computer Science and Informatics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Position: Lecturer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(16, 259)
        Me.lblName.MaximumSize = New System.Drawing.Size(250, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(250, 21)
        Me.lblName.TabIndex = 220
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Request
        '
        Me.AcceptButton = Me.btnApprove
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnDeny
        Me.ClientSize = New System.Drawing.Size(578, 524)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Request"
        Me.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Request"
        Me.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lvRequestedKeys As ListView
    Friend WithEvents keyTag As ColumnHeader
    Friend WithEvents key_location As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeny As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAction As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblName As Label
End Class
