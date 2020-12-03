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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2wall = New System.Windows.Forms.PictureBox()
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox10win = New System.Windows.Forms.PictureBox()
        Me.PictureBox9wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox8wall = New System.Windows.Forms.PictureBox()
        Me.bullet2win = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.bullet1win = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet2win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet1win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'PictureBox2wall
        '
        Me.PictureBox2wall.Location = New System.Drawing.Point(-5, 379)
        Me.PictureBox2wall.Name = "PictureBox2wall"
        Me.PictureBox2wall.Size = New System.Drawing.Size(792, 10)
        Me.PictureBox2wall.TabIndex = 11
        Me.PictureBox2wall.TabStop = False
        '
        'wall
        '
        Me.wall.Location = New System.Drawing.Point(0, -14)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(787, 18)
        Me.wall.TabIndex = 10
        Me.wall.TabStop = False
        '
        'PictureBox10win
        '
        Me.PictureBox10win.Image = Global.mygame.My.Resources.Resources.bulet_shot__1___1_1
        Me.PictureBox10win.Location = New System.Drawing.Point(610, 313)
        Me.PictureBox10win.Name = "PictureBox10win"
        Me.PictureBox10win.Size = New System.Drawing.Size(39, 22)
        Me.PictureBox10win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10win.TabIndex = 9
        Me.PictureBox10win.TabStop = False
        Me.PictureBox10win.Visible = False
        '
        'PictureBox9wall
        '
        Me.PictureBox9wall.Image = Global.mygame.My.Resources.Resources.pixil_frame_0__2_
        Me.PictureBox9wall.Location = New System.Drawing.Point(667, 302)
        Me.PictureBox9wall.Name = "PictureBox9wall"
        Me.PictureBox9wall.Size = New System.Drawing.Size(100, 59)
        Me.PictureBox9wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9wall.TabIndex = 8
        Me.PictureBox9wall.TabStop = False
        '
        'PictureBox8wall
        '
        Me.PictureBox8wall.Image = Global.mygame.My.Resources.Resources.pixil_frame_0__2_
        Me.PictureBox8wall.Location = New System.Drawing.Point(610, 138)
        Me.PictureBox8wall.Name = "PictureBox8wall"
        Me.PictureBox8wall.Size = New System.Drawing.Size(157, 105)
        Me.PictureBox8wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8wall.TabIndex = 7
        Me.PictureBox8wall.TabStop = False
        '
        'bullet2win
        '
        Me.bullet2win.Image = Global.mygame.My.Resources.Resources.pixil_frame_0__5_
        Me.bullet2win.Location = New System.Drawing.Point(304, 56)
        Me.bullet2win.Name = "bullet2win"
        Me.bullet2win.Size = New System.Drawing.Size(30, 13)
        Me.bullet2win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet2win.TabIndex = 6
        Me.bullet2win.TabStop = False
        Me.bullet2win.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.mygame.My.Resources.Resources.ammo__1_
        Me.PictureBox6.Location = New System.Drawing.Point(12, 184)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(18, 29)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.mygame.My.Resources.Resources.tank_destroy__1_
        Me.PictureBox5.Location = New System.Drawing.Point(525, 164)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 79)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'bullet1win
        '
        Me.bullet1win.Image = Global.mygame.My.Resources.Resources.pixil_frame_0__4_
        Me.bullet1win.Location = New System.Drawing.Point(587, 58)
        Me.bullet1win.Name = "bullet1win"
        Me.bullet1win.Size = New System.Drawing.Size(17, 11)
        Me.bullet1win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet1win.TabIndex = 3
        Me.bullet1win.TabStop = False
        Me.bullet1win.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.mygame.My.Resources.Resources.health_item
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.Transparent
        Me.enemy1.Image = Global.mygame.My.Resources.Resources.pixil_frame_0__2_
        Me.enemy1.Location = New System.Drawing.Point(610, 26)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(157, 106)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 1
        Me.enemy1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mygame.My.Resources.Resources.pixil_frame_0
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 385)
        Me.Controls.Add(Me.PictureBox2wall)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.PictureBox10win)
        Me.Controls.Add(Me.PictureBox9wall)
        Me.Controls.Add(Me.PictureBox8wall)
        Me.Controls.Add(Me.bullet2win)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.bullet1win)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "soviet windows game: defend the motherland"
        CType(Me.PictureBox2wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet2win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet1win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents bullet1win As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents bullet2win As PictureBox
    Friend WithEvents PictureBox8wall As PictureBox
    Friend WithEvents PictureBox9wall As PictureBox
    Friend WithEvents PictureBox10win As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wall As PictureBox
    Friend WithEvents PictureBox2wall As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox3 As PictureBox
End Class
