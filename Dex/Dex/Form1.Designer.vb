<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.healthLabel = New System.Windows.Forms.Label()
        Me.biomeLabel = New System.Windows.Forms.Label()
        Me.adLabel = New System.Windows.Forms.Label()
        Me.field1 = New System.Windows.Forms.TextBox()
        Me.field2 = New System.Windows.Forms.TextBox()
        Me.field3 = New System.Windows.Forms.TextBox()
        Me.field4 = New System.Windows.Forms.TextBox()
        Me.field5 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LeviathansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 2
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(12, 66)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(52, 20)
        Me.nameLabel.TabIndex = 3
        Me.nameLabel.Text = "Name:"
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(12, 126)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(57, 20)
        Me.lengthLabel.TabIndex = 4
        Me.lengthLabel.Text = "Length:"
        '
        'healthLabel
        '
        Me.healthLabel.AutoSize = True
        Me.healthLabel.Location = New System.Drawing.Point(12, 178)
        Me.healthLabel.Name = "healthLabel"
        Me.healthLabel.Size = New System.Drawing.Size(56, 20)
        Me.healthLabel.TabIndex = 5
        Me.healthLabel.Text = "Health:"
        '
        'biomeLabel
        '
        Me.biomeLabel.AutoSize = True
        Me.biomeLabel.Location = New System.Drawing.Point(12, 222)
        Me.biomeLabel.Name = "biomeLabel"
        Me.biomeLabel.Size = New System.Drawing.Size(55, 20)
        Me.biomeLabel.TabIndex = 6
        Me.biomeLabel.Text = "Biome:"
        '
        'adLabel
        '
        Me.adLabel.AutoSize = True
        Me.adLabel.Location = New System.Drawing.Point(12, 347)
        Me.adLabel.Name = "adLabel"
        Me.adLabel.Size = New System.Drawing.Size(102, 20)
        Me.adLabel.TabIndex = 7
        Me.adLabel.Text = "Active During:"
        '
        'field1
        '
        Me.field1.Location = New System.Drawing.Point(75, 63)
        Me.field1.Name = "field1"
        Me.field1.Size = New System.Drawing.Size(238, 27)
        Me.field1.TabIndex = 8
        '
        'field2
        '
        Me.field2.Location = New System.Drawing.Point(75, 119)
        Me.field2.Name = "field2"
        Me.field2.Size = New System.Drawing.Size(238, 27)
        Me.field2.TabIndex = 9
        '
        'field3
        '
        Me.field3.Location = New System.Drawing.Point(74, 171)
        Me.field3.Name = "field3"
        Me.field3.Size = New System.Drawing.Size(239, 27)
        Me.field3.TabIndex = 10
        '
        'field4
        '
        Me.field4.Location = New System.Drawing.Point(73, 222)
        Me.field4.Multiline = True
        Me.field4.Name = "field4"
        Me.field4.Size = New System.Drawing.Size(240, 92)
        Me.field4.TabIndex = 11
        '
        'field5
        '
        Me.field5.Location = New System.Drawing.Point(120, 344)
        Me.field5.Name = "field5"
        Me.field5.Size = New System.Drawing.Size(193, 27)
        Me.field5.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeviathansToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LeviathansToolStripMenuItem
        '
        Me.LeviathansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.LeviathansToolStripMenuItem.Name = "LeviathansToolStripMenuItem"
        Me.LeviathansToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.LeviathansToolStripMenuItem.Text = "Leviathans"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(366, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 341)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(79, 409)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(139, 29)
        Me.FirstButton.TabIndex = 15
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(251, 409)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(139, 29)
        Me.PrevButton.TabIndex = 16
        Me.PrevButton.Text = "Previous"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(423, 409)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(139, 29)
        Me.NextButton.TabIndex = 17
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(595, 409)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(139, 29)
        Me.LastButton.TabIndex = 18
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.field5)
        Me.Controls.Add(Me.field4)
        Me.Controls.Add(Me.field3)
        Me.Controls.Add(Me.field2)
        Me.Controls.Add(Me.field1)
        Me.Controls.Add(Me.adLabel)
        Me.Controls.Add(Me.biomeLabel)
        Me.Controls.Add(Me.healthLabel)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents lengthLabel As Label
    Friend WithEvents healthLabel As Label
    Friend WithEvents biomeLabel As Label
    Friend WithEvents adLabel As Label
    Friend WithEvents field1 As TextBox
    Friend WithEvents field2 As TextBox
    Friend WithEvents field3 As TextBox
    Friend WithEvents field4 As TextBox
    Friend WithEvents field5 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LeviathansToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FirstButton As Button
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents LastButton As Button
End Class
