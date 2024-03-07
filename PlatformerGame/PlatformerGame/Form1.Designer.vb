<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2DPlatformer
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
        Me.components = New System.ComponentModel.Container()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lightPB = New System.Windows.Forms.PictureBox()
        Me.block1 = New System.Windows.Forms.PictureBox()
        Me.block4 = New System.Windows.Forms.PictureBox()
        Me.block3 = New System.Windows.Forms.PictureBox()
        Me.block2 = New System.Windows.Forms.PictureBox()
        Me.Mover1 = New PlatformerGame.mover()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lightPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.block1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.block4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.block3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.block2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Fuchsia
        Me.picPlayer.Location = New System.Drawing.Point(12, 334)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(53, 50)
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        Me.picPlayer.Tag = ""
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.picAir.Location = New System.Drawing.Point(-5, -11)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(808, 395)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.picGround.Location = New System.Drawing.Point(-5, 383)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(808, 72)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        '
        'tmrGravity
        '
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 8
        '
        'lightPB
        '
        Me.lightPB.BackColor = System.Drawing.Color.Yellow
        Me.lightPB.Location = New System.Drawing.Point(703, 50)
        Me.lightPB.Name = "lightPB"
        Me.lightPB.Size = New System.Drawing.Size(28, 28)
        Me.lightPB.TabIndex = 7
        Me.lightPB.TabStop = False
        '
        'block1
        '
        Me.block1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.block1.Location = New System.Drawing.Point(302, 308)
        Me.block1.Name = "block1"
        Me.block1.Size = New System.Drawing.Size(185, 29)
        Me.block1.TabIndex = 6
        Me.block1.TabStop = False
        Me.block1.Tag = "bound"
        '
        'block4
        '
        Me.block4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.block4.Location = New System.Drawing.Point(505, 73)
        Me.block4.Name = "block4"
        Me.block4.Size = New System.Drawing.Size(226, 36)
        Me.block4.TabIndex = 5
        Me.block4.TabStop = False
        Me.block4.Tag = "bound"
        '
        'block3
        '
        Me.block3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.block3.Location = New System.Drawing.Point(282, 134)
        Me.block3.Name = "block3"
        Me.block3.Size = New System.Drawing.Size(190, 36)
        Me.block3.TabIndex = 4
        Me.block3.TabStop = False
        Me.block3.Tag = "bound"
        '
        'block2
        '
        Me.block2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.block2.Location = New System.Drawing.Point(46, 217)
        Me.block2.Name = "block2"
        Me.block2.Size = New System.Drawing.Size(176, 28)
        Me.block2.TabIndex = 3
        Me.block2.TabStop = False
        Me.block2.Tag = "bound"
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(363, 405)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(150, 33)
        Me.Mover1.speed = 0
        Me.Mover1.sprite = Nothing
        Me.Mover1.TabIndex = 9
        '
        'frm2DPlatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lightPB)
        Me.Controls.Add(Me.block1)
        Me.Controls.Add(Me.block4)
        Me.Controls.Add(Me.block3)
        Me.Controls.Add(Me.block2)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.picAir)
        Me.Name = "frm2DPlatformer"
        Me.Text = "Platformer Game"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lightPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.block1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.block4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.block3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.block2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lightPB As PictureBox
    Friend WithEvents block1 As PictureBox
    Friend WithEvents block4 As PictureBox
    Friend WithEvents block3 As PictureBox
    Friend WithEvents block2 As PictureBox
    Friend WithEvents Mover1 As mover
End Class
