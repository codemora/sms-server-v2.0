<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Key
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lboxAccessibleTo = New System.Windows.Forms.ListBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblActive = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblBlock = New System.Windows.Forms.Label()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lboxAccessibleTo)
        Me.Panel1.Controls.Add(Me.lblQuantity)
        Me.Panel1.Controls.Add(Me.lblActive)
        Me.Panel1.Controls.Add(Me.lblType)
        Me.Panel1.Controls.Add(Me.lblLocation)
        Me.Panel1.Controls.Add(Me.lblBlock)
        Me.Panel1.Controls.Add(Me.lblTag)
        Me.Panel1.Location = New System.Drawing.Point(20, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 392)
        Me.Panel1.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 160)
        Me.Label3.MaximumSize = New System.Drawing.Size(400, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 19)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Accessible To:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lboxAccessibleTo
        '
        Me.lboxAccessibleTo.BackColor = System.Drawing.Color.SeaGreen
        Me.lboxAccessibleTo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxAccessibleTo.ForeColor = System.Drawing.Color.White
        Me.lboxAccessibleTo.FormattingEnabled = True
        Me.lboxAccessibleTo.ItemHeight = 21
        Me.lboxAccessibleTo.Location = New System.Drawing.Point(15, 182)
        Me.lboxAccessibleTo.Name = "lboxAccessibleTo"
        Me.lboxAccessibleTo.Size = New System.Drawing.Size(381, 193)
        Me.lboxAccessibleTo.TabIndex = 121
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Silver
        Me.lblQuantity.Location = New System.Drawing.Point(15, 82)
        Me.lblQuantity.MaximumSize = New System.Drawing.Size(380, 21)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(97, 21)
        Me.lblQuantity.TabIndex = 117
        Me.lblQuantity.Text = "Quantity: 3"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblActive
        '
        Me.lblActive.AutoSize = True
        Me.lblActive.BackColor = System.Drawing.Color.Red
        Me.lblActive.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActive.ForeColor = System.Drawing.Color.White
        Me.lblActive.Location = New System.Drawing.Point(15, 128)
        Me.lblActive.Name = "lblActive"
        Me.lblActive.Size = New System.Drawing.Size(41, 21)
        Me.lblActive.TabIndex = 116
        Me.lblActive.Text = "Out"
        Me.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Silver
        Me.lblType.Location = New System.Drawing.Point(15, 105)
        Me.lblType.MaximumSize = New System.Drawing.Size(380, 21)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(137, 21)
        Me.lblType.TabIndex = 107
        Me.lblType.Text = "Type: Washroom"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.ForeColor = System.Drawing.Color.Silver
        Me.lblLocation.Location = New System.Drawing.Point(15, 59)
        Me.lblLocation.MaximumSize = New System.Drawing.Size(380, 21)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(108, 21)
        Me.lblLocation.TabIndex = 106
        Me.lblLocation.Text = "Location: A1"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBlock
        '
        Me.lblBlock.AutoSize = True
        Me.lblBlock.BackColor = System.Drawing.Color.Transparent
        Me.lblBlock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlock.ForeColor = System.Drawing.Color.Silver
        Me.lblBlock.Location = New System.Drawing.Point(15, 36)
        Me.lblBlock.MaximumSize = New System.Drawing.Size(380, 21)
        Me.lblBlock.Name = "lblBlock"
        Me.lblBlock.Size = New System.Drawing.Size(124, 21)
        Me.lblBlock.TabIndex = 104
        Me.lblBlock.Text = "Administration"
        Me.lblBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTag
        '
        Me.lblTag.AutoEllipsis = True
        Me.lblTag.AutoSize = True
        Me.lblTag.BackColor = System.Drawing.Color.Transparent
        Me.lblTag.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.ForeColor = System.Drawing.Color.White
        Me.lblTag.Location = New System.Drawing.Point(15, 9)
        Me.lblTag.MaximumSize = New System.Drawing.Size(380, 28)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(116, 25)
        Me.lblTag.TabIndex = 102
        Me.lblTag.Text = "Tag [Lock]"
        Me.lblTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(171, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 28)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "VIEW KEY"
        '
        'View_Key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(461, 449)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "View_Key"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "View Key"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lboxAccessibleTo As ListBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblActive As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents lblBlock As Label
    Friend WithEvents lblTag As Label
    Friend WithEvents Label7 As Label
End Class
