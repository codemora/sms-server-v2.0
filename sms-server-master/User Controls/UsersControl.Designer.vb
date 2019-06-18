<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersControl))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.full_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.privilege = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.createdAt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updatedAt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.panelButtonTray = New System.Windows.Forms.Panel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnBlockUser = New System.Windows.Forms.Button()
        Me.btnViewUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelButtonTray.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE USERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.lvData)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Controls.Add(Me.Panel3)
        Me.panelMain.Controls.Add(Me.panelButtonTray)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.ForeColor = System.Drawing.Color.White
        Me.panelMain.Location = New System.Drawing.Point(30, 15)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(990, 470)
        Me.panelMain.TabIndex = 1
        '
        'lvData
        '
        Me.lvData.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvData.AllowColumnReorder = True
        Me.lvData.BackColor = System.Drawing.Color.White
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.full_name, Me.privilege, Me.username, Me.phone, Me.createdAt, Me.updatedAt})
        Me.lvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvData.ForeColor = System.Drawing.Color.Black
        Me.lvData.FullRowSelect = True
        Me.lvData.GridLines = True
        Me.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvData.HideSelection = False
        Me.lvData.Location = New System.Drawing.Point(0, 35)
        Me.lvData.MultiSelect = False
        Me.lvData.Name = "lvData"
        Me.lvData.ShowItemToolTips = True
        Me.lvData.Size = New System.Drawing.Size(990, 368)
        Me.lvData.TabIndex = 105
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 104
        '
        'full_name
        '
        Me.full_name.Text = "Name"
        Me.full_name.Width = 208
        '
        'privilege
        '
        Me.privilege.Text = "Privilege"
        Me.privilege.Width = 119
        '
        'username
        '
        Me.username.Text = "Username"
        Me.username.Width = 142
        '
        'phone
        '
        Me.phone.Text = "Phone"
        Me.phone.Width = 112
        '
        'createdAt
        '
        Me.createdAt.Text = "Created At"
        Me.createdAt.Width = 144
        '
        'updatedAt
        '
        Me.updatedAt.Text = "Updated At"
        Me.updatedAt.Width = 139
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblCount)
        Me.Panel3.Controls.Add(Me.lblMsg)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 403)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 30)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 30)
        Me.Panel4.TabIndex = 206
        '
        'lblCount
        '
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(740, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(250, 30)
        Me.lblCount.TabIndex = 207
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Lime
        Me.lblMsg.Location = New System.Drawing.Point(0, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(990, 30)
        Me.lblMsg.TabIndex = 208
        Me.lblMsg.Text = "Registeration Successful"
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblMsg.Visible = False
        '
        'panelButtonTray
        '
        Me.panelButtonTray.Controls.Add(Me.panelButtons)
        Me.panelButtonTray.Controls.Add(Me.Panel6)
        Me.panelButtonTray.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtonTray.Location = New System.Drawing.Point(0, 433)
        Me.panelButtonTray.Name = "panelButtonTray"
        Me.panelButtonTray.Size = New System.Drawing.Size(990, 37)
        Me.panelButtonTray.TabIndex = 0
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.btnBlockUser)
        Me.panelButtons.Controls.Add(Me.btnViewUser)
        Me.panelButtons.Controls.Add(Me.btnAddUser)
        Me.panelButtons.Controls.Add(Me.btnDeleteUser)
        Me.panelButtons.Controls.Add(Me.btnUpdateUser)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelButtons.Location = New System.Drawing.Point(117, 0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(737, 37)
        Me.panelButtons.TabIndex = 106
        '
        'btnBlockUser
        '
        Me.btnBlockUser.AutoSize = True
        Me.btnBlockUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBlockUser.Enabled = False
        Me.btnBlockUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBlockUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBlockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlockUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBlockUser.Image = Global.sms_server_master.My.Resources.Resources._016_padlock_1
        Me.btnBlockUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlockUser.Location = New System.Drawing.Point(589, 1)
        Me.btnBlockUser.Name = "btnBlockUser"
        Me.btnBlockUser.Size = New System.Drawing.Size(146, 35)
        Me.btnBlockUser.TabIndex = 211
        Me.btnBlockUser.Text = " Block User"
        Me.btnBlockUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlockUser.UseVisualStyleBackColor = True
        '
        'btnViewUser
        '
        Me.btnViewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewUser.Enabled = False
        Me.btnViewUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewUser.Image = Global.sms_server_master.My.Resources.Resources._027_eye
        Me.btnViewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewUser.Location = New System.Drawing.Point(443, 1)
        Me.btnViewUser.Name = "btnViewUser"
        Me.btnViewUser.Size = New System.Drawing.Size(137, 35)
        Me.btnViewUser.TabIndex = 210
        Me.btnViewUser.Text = " View User"
        Me.btnViewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddUser.Image = Global.sms_server_master.My.Resources.Resources._035_add_2
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(5, 1)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(137, 35)
        Me.btnAddUser.TabIndex = 207
        Me.btnAddUser.Text = " Add User"
        Me.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteUser.Enabled = False
        Me.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteUser.Image = Global.sms_server_master.My.Resources.Resources._029_trash
        Me.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Location = New System.Drawing.Point(297, 1)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(137, 35)
        Me.btnDeleteUser.TabIndex = 209
        Me.btnDeleteUser.Text = " Delete User"
        Me.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdateUser.Enabled = False
        Me.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnUpdateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnUpdateUser.Image = Global.sms_server_master.My.Resources.Resources._021_edit
        Me.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateUser.Location = New System.Drawing.Point(151, 1)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(137, 35)
        Me.btnUpdateUser.TabIndex = 208
        Me.btnUpdateUser.Text = "Update User"
        Me.btnUpdateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(117, 37)
        Me.Panel6.TabIndex = 157
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'UsersControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelMain)
        Me.Name = "UsersControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.Panel1.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panelButtonTray.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.panelButtons.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelButtonTray As Panel
    Friend WithEvents lvData As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents full_name As ColumnHeader
    Friend WithEvents privilege As ColumnHeader
    Friend WithEvents username As ColumnHeader
    Friend WithEvents phone As ColumnHeader
    Friend WithEvents createdAt As ColumnHeader
    Friend WithEvents updatedAt As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnBlockUser As Button
    Friend WithEvents btnViewUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnUpdateUser As Button
    Friend WithEvents panelButtons As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMsg As Label
End Class
