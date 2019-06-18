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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.listkeys = New System.Windows.Forms.ListBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(302, 423)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 34)
        Me.btnEdit.TabIndex = 105
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblName, 2)
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(3, 0)
        Me.lblName.MaximumSize = New System.Drawing.Size(330, 50)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(312, 30)
        Me.lblName.TabIndex = 114
        Me.lblName.Text = "Emmanuel Eugene Ofori"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'listkeys
        '
        Me.listkeys.FormattingEnabled = True
        Me.listkeys.Location = New System.Drawing.Point(355, 35)
        Me.listkeys.Name = "listkeys"
        Me.listkeys.Size = New System.Drawing.Size(197, 160)
        Me.listkeys.TabIndex = 113
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.BackColor = System.Drawing.Color.Transparent
        Me.lblDept.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.White
        Me.lblDept.Location = New System.Drawing.Point(352, 208)
        Me.lblDept.MaximumSize = New System.Drawing.Size(200, 84)
        Me.lblDept.MinimumSize = New System.Drawing.Size(200, 0)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(200, 18)
        Me.lblDept.TabIndex = 109
        Me.lblDept.Text = "Dept: Computer Science"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(354, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Keys Accessible "
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(52, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 160)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblName, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(185, 257)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(318, 100)
        Me.TableLayoutPanel1.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "ID PJ24"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(107, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "0573235605"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(107, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "0573235605"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "0573235605"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(673, 508)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.listkeys)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "View_Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Staff"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents listkeys As ListBox
    Friend WithEvents lblDept As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
