<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeysControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeysControl))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.lblloader = New System.Windows.Forms.Label()
        Me.lvData = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.key_tag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.key_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.block = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.key_location = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.updated_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.panelButtonTray = New System.Windows.Forms.Panel()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnAddKey = New System.Windows.Forms.Button()
        Me.btnEditKey = New System.Windows.Forms.Button()
        Me.btnViewKey = New System.Windows.Forms.Button()
        Me.btnDeleteKey = New System.Windows.Forms.Button()
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
        Me.Label2.Location = New System.Drawing.Point(764, 6)
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
        Me.txtSearch.Location = New System.Drawing.Point(829, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(160, 26)
        Me.txtSearch.TabIndex = 206
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE KEYS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.lblloader)
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
        'lblloader
        '
        Me.lblloader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblloader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblloader.Font = New System.Drawing.Font("Century Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblloader.Location = New System.Drawing.Point(0, 35)
        Me.lblloader.Name = "lblloader"
        Me.lblloader.Size = New System.Drawing.Size(990, 368)
        Me.lblloader.TabIndex = 208
        Me.lblloader.Text = "Loading..."
        Me.lblloader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvData
        '
        Me.lvData.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvData.AllowColumnReorder = True
        Me.lvData.BackColor = System.Drawing.Color.White
        Me.lvData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.key_tag, Me.key_type, Me.lock, Me.block, Me.key_location, Me.quantity, Me.status, Me.created_at, Me.updated_at})
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
        Me.lvData.TabIndex = 151
        Me.lvData.UseCompatibleStateImageBehavior = False
        Me.lvData.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 64
        '
        'key_tag
        '
        Me.key_tag.Text = "Tag"
        Me.key_tag.Width = 111
        '
        'key_type
        '
        Me.key_type.Text = "Type"
        Me.key_type.Width = 102
        '
        'lock
        '
        Me.lock.Text = "Lock "
        Me.lock.Width = 128
        '
        'block
        '
        Me.block.Text = "Block"
        Me.block.Width = 124
        '
        'key_location
        '
        Me.key_location.Text = "Location"
        Me.key_location.Width = 73
        '
        'quantity
        '
        Me.quantity.Text = "Quantity"
        Me.quantity.Width = 74
        '
        'status
        '
        Me.status.Text = "Status"
        '
        'created_at
        '
        Me.created_at.Text = "Date Created"
        Me.created_at.Width = 106
        '
        'updated_at
        '
        Me.updated_at.Text = "Date Updated"
        Me.updated_at.Width = 144
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
        Me.panelButtons.Controls.Add(Me.btnAddKey)
        Me.panelButtons.Controls.Add(Me.btnEditKey)
        Me.panelButtons.Controls.Add(Me.btnViewKey)
        Me.panelButtons.Controls.Add(Me.btnDeleteKey)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelButtons.Location = New System.Drawing.Point(149, 0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(641, 37)
        Me.panelButtons.TabIndex = 159
        '
        'btnAddKey
        '
        Me.btnAddKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddKey.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnAddKey.Image = Global.sms_server_master.My.Resources.Resources._035_add_2
        Me.btnAddKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddKey.Location = New System.Drawing.Point(3, 1)
        Me.btnAddKey.Name = "btnAddKey"
        Me.btnAddKey.Size = New System.Drawing.Size(134, 35)
        Me.btnAddKey.TabIndex = 226
        Me.btnAddKey.Text = " Add Key"
        Me.btnAddKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddKey.UseVisualStyleBackColor = True
        '
        'btnEditKey
        '
        Me.btnEditKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditKey.Enabled = False
        Me.btnEditKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditKey.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnEditKey.Image = Global.sms_server_master.My.Resources.Resources._021_edit
        Me.btnEditKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditKey.Location = New System.Drawing.Point(145, 1)
        Me.btnEditKey.Name = "btnEditKey"
        Me.btnEditKey.Size = New System.Drawing.Size(134, 35)
        Me.btnEditKey.TabIndex = 225
        Me.btnEditKey.Text = " Edit Key"
        Me.btnEditKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditKey.UseVisualStyleBackColor = True
        '
        'btnViewKey
        '
        Me.btnViewKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnViewKey.Enabled = False
        Me.btnViewKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnViewKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewKey.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnViewKey.Image = Global.sms_server_master.My.Resources.Resources._027_eye
        Me.btnViewKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewKey.Location = New System.Drawing.Point(429, 1)
        Me.btnViewKey.Name = "btnViewKey"
        Me.btnViewKey.Size = New System.Drawing.Size(134, 35)
        Me.btnViewKey.TabIndex = 223
        Me.btnViewKey.Text = " View Key"
        Me.btnViewKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewKey.UseVisualStyleBackColor = True
        '
        'btnDeleteKey
        '
        Me.btnDeleteKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDeleteKey.Enabled = False
        Me.btnDeleteKey.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnDeleteKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteKey.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeleteKey.Image = Global.sms_server_master.My.Resources.Resources._029_trash
        Me.btnDeleteKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteKey.Location = New System.Drawing.Point(287, 1)
        Me.btnDeleteKey.Name = "btnDeleteKey"
        Me.btnDeleteKey.Size = New System.Drawing.Size(134, 35)
        Me.btnDeleteKey.TabIndex = 224
        Me.btnDeleteKey.Text = " Delete Key"
        Me.btnDeleteKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteKey.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(149, 37)
        Me.Panel6.TabIndex = 160
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'KeysControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelMain)
        Me.Location = New System.Drawing.Point(280, 160)
        Me.Name = "KeysControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panelButtonTray.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lvData As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents key_tag As ColumnHeader
    Friend WithEvents key_type As ColumnHeader
    Friend WithEvents lock As ColumnHeader
    Friend WithEvents block As ColumnHeader
    Friend WithEvents key_location As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents status As ColumnHeader
    Friend WithEvents created_at As ColumnHeader
    Friend WithEvents updated_at As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelButtonTray As Panel
    Friend WithEvents btnAddKey As Button
    Friend WithEvents btnEditKey As Button
    Friend WithEvents btnDeleteKey As Button
    Friend WithEvents btnViewKey As Button
    Friend WithEvents panelButtons As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblloader As Label
End Class
