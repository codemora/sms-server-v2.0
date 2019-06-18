<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogsControl))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.Label1.Size = New System.Drawing.Size(202, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MANAGE LOGS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'panelMain
        '
        Me.panelMain.BackColor = System.Drawing.Color.White
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Controls.Add(Me.Panel3)
        Me.panelMain.Controls.Add(Me.Panel2)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.ForeColor = System.Drawing.Color.White
        Me.panelMain.Location = New System.Drawing.Point(30, 15)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(990, 470)
        Me.panelMain.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblCount)
        Me.Panel3.Controls.Add(Me.lblMsg)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(990, 30)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 435)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(990, 35)
        Me.Panel2.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
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
        'LogsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.panelMain)
        Me.Name = "LogsControl"
        Me.Padding = New System.Windows.Forms.Padding(30, 15, 30, 15)
        Me.Size = New System.Drawing.Size(1050, 500)
        Me.Panel1.ResumeLayout(False)
        Me.panelMain.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblCount As Label
    Friend WithEvents lblMsg As Label
End Class
