<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Key
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLock = New System.Windows.Forms.TextBox()
        Me.cmbBlock = New System.Windows.Forms.ComboBox()
        Me.cmbKeyType = New System.Windows.Forms.ComboBox()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtLocation)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(489, 445)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtLock)
        Me.Panel2.Controls.Add(Me.cmbBlock)
        Me.Panel2.Controls.Add(Me.cmbKeyType)
        Me.Panel2.Controls.Add(Me.txtTag)
        Me.Panel2.Location = New System.Drawing.Point(61, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(366, 318)
        Me.Panel2.TabIndex = 27
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(108, 246)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(71, 29)
        Me.NumericUpDown1.TabIndex = 5
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 29)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Lock"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Block"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuantity
        '
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(21, 246)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 29)
        Me.lblQuantity.TabIndex = 15
        Me.lblQuantity.Text = "Quantity"
        Me.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tag"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLock
        '
        Me.txtLock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLock.Location = New System.Drawing.Point(108, 122)
        Me.txtLock.Multiline = True
        Me.txtLock.Name = "txtLock"
        Me.txtLock.Size = New System.Drawing.Size(230, 29)
        Me.txtLock.TabIndex = 2
        '
        'cmbBlock
        '
        Me.cmbBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBlock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBlock.FormattingEnabled = True
        Me.cmbBlock.Items.AddRange(New Object() {"-----SELECT KEY LOCATION-----", "3CGS", "ADMINISTRATION BLOCK", "APEL BLOCK", "APP LAB", "AUDITORIUM ", "BASIC SCHOOL", "CAFETERIA", "EORIC", "ESTATE ", "FINANCE DIRECTORATE", "GETFUND HOSTEL", "HUMAN RESOURCES ", "IT DIRECTORATE", "LABORATORY", "LIBRARY BLOCK", "MAIN BLOCK (LTS)", "MAIN ENTRANCE", "OPPOSITE HOSTEL ENTRANCE", "SAWMILL", "SECURITY", "SOUTH ENTRANCE", "UNIVERSITY CLINIC", "OTHERS"})
        Me.cmbBlock.Location = New System.Drawing.Point(108, 167)
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.Size = New System.Drawing.Size(230, 29)
        Me.cmbBlock.TabIndex = 3
        '
        'cmbKeyType
        '
        Me.cmbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKeyType.FormattingEnabled = True
        Me.cmbKeyType.Items.AddRange(New Object() {"-----SELECT KEY TYPE-----", "ENTRANCE", "LABORATORY", "STORAGE", "OFFICE", "WASHROOM", "OTHERS"})
        Me.cmbKeyType.Location = New System.Drawing.Point(108, 74)
        Me.cmbKeyType.Name = "cmbKeyType"
        Me.cmbKeyType.Size = New System.Drawing.Size(230, 29)
        Me.cmbKeyType.TabIndex = 1
        '
        'txtTag
        '
        Me.txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTag.Location = New System.Drawing.Point(108, 26)
        Me.txtTag.Multiline = True
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(230, 29)
        Me.txtTag.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(84, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 29)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Location"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLocation
        '
        Me.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(169, 270)
        Me.txtLocation.Multiline = True
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(230, 29)
        Me.txtLocation.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(181, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 32)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "ADD KEYS"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.LightBlue
        Me.btnReset.Location = New System.Drawing.Point(257, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 37)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.LightBlue
        Me.btnSave.Location = New System.Drawing.Point(142, 390)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 37)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Location"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 202)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 29)
        Me.TextBox1.TabIndex = 27
        '
        'Add_Key
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 475)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Key"
        Me.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Add Key"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLock As TextBox
    Friend WithEvents cmbBlock As ComboBox
    Friend WithEvents cmbKeyType As ComboBox
    Friend WithEvents txtTag As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
End Class
