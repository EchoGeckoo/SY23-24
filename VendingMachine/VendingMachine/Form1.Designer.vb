<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DimeB = New System.Windows.Forms.Button()
        Me.NickleB = New System.Windows.Forms.Button()
        Me.QuarterB = New System.Windows.Forms.Button()
        Me.DollarB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DimeB
        '
        Me.DimeB.BackgroundImage = Global.VendingMachine.My.Resources.Resources._2023_roosevelt_dime_uncirculated_obverse_denver_768x768
        Me.DimeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DimeB.Location = New System.Drawing.Point(249, 12)
        Me.DimeB.Name = "DimeB"
        Me.DimeB.Size = New System.Drawing.Size(111, 101)
        Me.DimeB.TabIndex = 3
        Me.DimeB.Text = "Dime"
        Me.DimeB.UseVisualStyleBackColor = True
        '
        'NickleB
        '
        Me.NickleB.BackgroundImage = Global.VendingMachine.My.Resources.Resources._1024px_Jefferson_Nickel_Unc_Obv
        Me.NickleB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NickleB.Location = New System.Drawing.Point(366, 12)
        Me.NickleB.Name = "NickleB"
        Me.NickleB.Size = New System.Drawing.Size(111, 101)
        Me.NickleB.TabIndex = 2
        Me.NickleB.Text = "Nickle"
        Me.NickleB.UseVisualStyleBackColor = True
        '
        'QuarterB
        '
        Me.QuarterB.BackgroundImage = Global.VendingMachine.My.Resources.Resources._51chNpYUTPL__AC_UF1000_1000_QL80_
        Me.QuarterB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuarterB.Location = New System.Drawing.Point(132, 12)
        Me.QuarterB.Name = "QuarterB"
        Me.QuarterB.Size = New System.Drawing.Size(111, 101)
        Me.QuarterB.TabIndex = 1
        Me.QuarterB.Text = "Quarter"
        Me.QuarterB.UseVisualStyleBackColor = True
        '
        'DollarB
        '
        Me.DollarB.BackgroundImage = Global.VendingMachine.My.Resources.Resources._2000_native_american_one_dollar_uncirculated_obverse_768x768
        Me.DollarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DollarB.Location = New System.Drawing.Point(15, 12)
        Me.DollarB.Name = "DollarB"
        Me.DollarB.Size = New System.Drawing.Size(111, 101)
        Me.DollarB.TabIndex = 0
        Me.DollarB.Text = "Dollar"
        Me.DollarB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total: $"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DimeB)
        Me.Controls.Add(Me.NickleB)
        Me.Controls.Add(Me.QuarterB)
        Me.Controls.Add(Me.DollarB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DollarB As Button
    Friend WithEvents QuarterB As Button
    Friend WithEvents NickleB As Button
    Friend WithEvents DimeB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
