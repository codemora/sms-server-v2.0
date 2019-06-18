<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffControl))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelButtonTray = New System.Windows.Forms.Panel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnUpdateStaff = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.btnBlockStaff = New System.Windows.Forms.Button()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ref = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.full_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.department = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updated_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelButtonTray.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'panelButtonTray
        '
        Me.panelButtonTray.Controls.Add(Me.panelButtons)
        Me.panelButtonTray.Controls.Add(Me.Panel6)
        Me.panelButtonTray.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtonTray.Location = New System.Drawing.Point(0, 433)
        Me.panelButtonTray.Name = "panelButtonTray"
        Me.panelButtonTray.Size = New System.Drawing.Size(990, 37)
        Me.panelButtonTray.TabIndex = 2
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.btnUpdateStaff)
        Me.panelButtons.Controls.Add(Me.btnAddStaff)
        Me.panelButtons.Controls.Add(Me.btnViewStaff)
        Me.panelButtons.Controls.Add(Me.btnBlockStaff)
        Me.panelButtons.Controls.Add(Me.btnDeleteStaff)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelButtons.Location = New System.Drawing.Point(103, 0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(740, 37)
        Me.panelButtons.TabIndex = 168
        '
        'btnUpdateStaff
        '
        Me.btnUpdateStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUpdateStaff.Enabled = False
        Me.btnUpdateStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnUpdateStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnUpdateStaff.Image = Global.sms_server_master.My.Resources.Resources._021_edit
        Me.btnUpdateStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateStaff.Location = New System.Drawing.Point(149, 1)
        Me.btnUpdateStaff.Name = "btnUpdateStaff"
        Me.btnUpdateStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnUpdateStaff.TabIndex = 211
        Me.btnUpdateStaff.Text = " Update Staff"
        Me.btnUpdateStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdateStaff.UseVisualStyleBackColor = True
        '
        'btnAddStaff
        '
        Me.btnAddStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddStaff.Image = Global.sms_server_master.My.Resources.Resources._035_add_2
        Me.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStaff.Location = New System.Drawing.Point(3, 1)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnAddStaff.TabIndex = 213
        Me.btnAddStaff.Text = " Add Staff"
        Me.btnAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'btnViewStaff
        '
        Me.btnViewStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewStaff.Enabled = False
        Me.btnViewStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewStaff.Image = Global.sms_server_master.My.Resources.Resources._027_eye
        Me.btnViewStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewStaff.Location = New System.Drawing.Point(441, 1)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnViewStaff.TabIndex = 209
        Me.btnViewStaff.Text = " View Staff"
        Me.btnViewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewStaff.UseVisualStyleBackColor = True
        '
        'btnBlockStaff
        '
        Me.btnBlockStaff.AutoSize = True
        Me.btnBlockStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBlockStaff.Enabled = False
        Me.btnBlockStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBlockStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBlockStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBlockStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlockStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnBlockStaff.Image = Global.sms_server_master.My.Resources.Resources._016_padlock_1
        Me.btnBlockStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBlockStaff.Location = New System.Drawing.Point(587, 1)
        Me.btnBlockStaff.Name = "btnBlockStaff"
        Me.btnBlockStaff.Size = New System.Drawing.Size(146, 35)
        Me.btnBlockStaff.TabIndex = 212
        Me.btnBlockStaff.Text = " Block Staff"
        Me.btnBlockStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlockStaff.UseVisualStyleBackColor = True
        '
        'btnDeleteStaff
        '
        Me.btnDeleteStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteStaff.Enabled = False
        Me.btnDeleteStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteStaff.Image = Global.sms_server_master.My.Resources.Resources._029_trash
        Me.btnDeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteStaff.Location = New System.Drawing.Point(295, 1)
        Me.btnDeleteStaff.Name = "btnDeleteStaff"
        Me.btnDeleteStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnDeleteStaff.TabIndex = 210
        Me.btnDeleteStaff.Text = " Delete Staff"
        Me.btnDeleteStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteStaff.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(103, 37)
        Me.Panel6.TabIndex = 169
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
        Me.Label1.Size = New System.Drawing.Size(205, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE STAFF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel3.TabIndex = 0
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
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.lvData)
        Me.panelMain.Controls.Add(Me.Panel3)
        Me.panelMain.Controls.Add(Me.Panel1)
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
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.ref, Me.full_name, Me.gender, Me.department, Me.position, Me.phone, Me.created_at, Me.updated_at})
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
        Me.lvData.TabIndex = 153
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 51
        '
        'ref
        '
        Me.ref.Text = "Staff Ref"
        Me.ref.Width = 79
        '
        'full_name
        '
        Me.full_name.Text = "Name"
        Me.full_name.Width = 182
        '
        'gender
        '
        Me.gender.Text = "Gender"
        Me.gender.Width = 65
        '
        'department
        '
        Me.department.Text = "Department"
        Me.department.Width = 146
        '
        'position
        '
        Me.position.Text = "Position"
        Me.position.Width = 127
        '
        'phone
        '
        Me.phone.Text = "Phone"
        Me.phone.Width = 130
        '
        'created_at
        '
        Me.created_at.Text = "Created At"
        Me.created_at.Width = 110
        '
        'updated_at
        '
        Me.updated_at.Text = "Updated At"
        Me.updated_at.Width = 99
        '
        'StaffControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelMain)
        Me.Name = "StaffControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.panelButtonTray.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.panelButtons.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelButtonTray As Panel
    Friend WithEvents panelButtons As Panel
    Friend WithEvents btnUpdateStaff As Button
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnViewStaff As Button
    Friend WithEvents btnBlockStaff As Button
    Friend WithEvents btnDeleteStaff As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents lvData As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents ref As ColumnHeader
    Friend WithEvents full_name As ColumnHeader
    Friend WithEvents gender As ColumnHeader
    Friend WithEvents department As ColumnHeader
    Friend WithEvents position As ColumnHeader
    Friend WithEvents phone As ColumnHeader
    Friend WithEvents created_at As ColumnHeader
    Friend WithEvents updated_at As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMsg As Label
End Class
