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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblloader = New System.Windows.Forms.Label()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ref = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.full_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.department = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.position = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.phone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updated_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBlockStaff = New System.Windows.Forms.Button()
        Me.btnEditStaff = New System.Windows.Forms.Button()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.btnViewStaff = New System.Windows.Forms.Button()
        Me.btnDeleteStaff = New System.Windows.Forms.Button()
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
        Me.panelButtons.Controls.Add(Me.btnBlockStaff)
        Me.panelButtons.Controls.Add(Me.btnEditStaff)
        Me.panelButtons.Controls.Add(Me.btnAddStaff)
        Me.panelButtons.Controls.Add(Me.btnViewStaff)
        Me.panelButtons.Controls.Add(Me.btnDeleteStaff)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelButtons.Location = New System.Drawing.Point(103, 0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(740, 37)
        Me.panelButtons.TabIndex = 168
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
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(764, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(829, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 26)
        Me.txtSearch.TabIndex = 206
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
        Me.panelMain.Controls.Add(Me.lblloader)
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
        'lblloader
        '
        Me.lblloader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblloader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblloader.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblloader.Location = New System.Drawing.Point(0, 35)
        Me.lblloader.Name = "lblloader"
        Me.lblloader.Size = New System.Drawing.Size(990, 368)
        Me.lblloader.TabIndex = 209
        Me.lblloader.Text = "Loading..."
        Me.lblloader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvData
        '
        Me.lvData.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvData.AllowColumnReorder = True
        Me.lvData.BackColor = System.Drawing.Color.White
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.ref, Me.full_name, Me.gender, Me.department, Me.position, Me.phone, Me.email, Me.created_at, Me.updated_at})
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
        Me.full_name.Width = 164
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
        Me.phone.Width = 103
        '
        'email
        '
        Me.email.Text = "Email"
        Me.email.Width = 102
        '
        'created_at
        '
        Me.created_at.Text = "Created At"
        Me.created_at.Width = 87
        '
        'updated_at
        '
        Me.updated_at.Text = "Updated At"
        Me.updated_at.Width = 99
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
        Me.btnBlockStaff.Location = New System.Drawing.Point(441, 1)
        Me.btnBlockStaff.Name = "btnBlockStaff"
        Me.btnBlockStaff.Size = New System.Drawing.Size(146, 35)
        Me.btnBlockStaff.TabIndex = 212
        Me.btnBlockStaff.Text = " Block Staff"
        Me.btnBlockStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBlockStaff.UseVisualStyleBackColor = True
        '
        'btnEditStaff
        '
        Me.btnEditStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditStaff.Enabled = False
        Me.btnEditStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditStaff.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStaff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditStaff.Image = Global.sms_server_master.My.Resources.Resources._021_edit
        Me.btnEditStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditStaff.Location = New System.Drawing.Point(149, 1)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnEditStaff.TabIndex = 211
        Me.btnEditStaff.Text = " Edit Staff"
        Me.btnEditStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditStaff.UseVisualStyleBackColor = True
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
        Me.btnViewStaff.Location = New System.Drawing.Point(593, 0)
        Me.btnViewStaff.Name = "btnViewStaff"
        Me.btnViewStaff.Size = New System.Drawing.Size(140, 35)
        Me.btnViewStaff.TabIndex = 209
        Me.btnViewStaff.Text = " View Staff"
        Me.btnViewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewStaff.UseVisualStyleBackColor = True
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
        'StaffControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelMain)
        Me.Location = New System.Drawing.Point(280, 160)
        Me.Name = "StaffControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.panelButtonTray.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.panelButtons.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelButtonTray As Panel
    Friend WithEvents panelButtons As Panel
    Friend WithEvents btnEditStaff As Button
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
    Friend WithEvents email As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblloader As Label
End Class
