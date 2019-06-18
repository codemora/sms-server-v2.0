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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Label1.Size = New System.Drawing.Size(196, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE KEYS"
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
        Me.block.Width = 106
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
        Me.created_at.Width = 74
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
        Me.panelButtons.Controls.Add(Me.Button5)
        Me.panelButtons.Controls.Add(Me.Button3)
        Me.panelButtons.Controls.Add(Me.Button1)
        Me.panelButtons.Controls.Add(Me.Button2)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelButtons.Location = New System.Drawing.Point(149, 0)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(641, 37)
        Me.panelButtons.TabIndex = 159
        '
        'Button5
        '
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button5.Image = Global.sms_server_master.My.Resources.Resources._035_add_2
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(3, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 35)
        Me.Button5.TabIndex = 226
        Me.Button5.Text = " Add Key"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button3.Image = Global.sms_server_master.My.Resources.Resources._021_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(145, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 35)
        Me.Button3.TabIndex = 225
        Me.Button3.Text = " Update Key"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button1.Image = Global.sms_server_master.My.Resources.Resources._027_eye
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(429, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 35)
        Me.Button1.TabIndex = 223
        Me.Button1.Text = " View Key"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Button2.Image = Global.sms_server_master.My.Resources.Resources._029_trash
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(287, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 35)
        Me.Button2.TabIndex = 224
        Me.Button2.Text = " Delete Key"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.Name = "KeysControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents panelButtons As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMsg As Label
End Class
