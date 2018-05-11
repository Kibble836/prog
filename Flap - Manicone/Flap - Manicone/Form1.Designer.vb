<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.tmrPillar = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrFlapDelay = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picBird = New System.Windows.Forms.PictureBox()
        Me.pillarBottom2 = New System.Windows.Forms.PictureBox()
        Me.pillarTop2 = New System.Windows.Forms.PictureBox()
        Me.pillarBottom1 = New System.Windows.Forms.PictureBox()
        Me.pillarTop1 = New System.Windows.Forms.PictureBox()
        Me.picGrass = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuMenu.SuspendLayout()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pillarBottom2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pillarTop2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pillarBottom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pillarTop1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrPillar
        '
        Me.tmrPillar.Enabled = True
        Me.tmrPillar.Interval = 1
        '
        'tmrGravity
        '
        Me.tmrGravity.Enabled = True
        Me.tmrGravity.Interval = 1
        '
        'mnuMenu
        '
        Me.mnuMenu.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.HighScoresToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(464, 24)
        Me.mnuMenu.TabIndex = 7
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'HighScoresToolStripMenuItem
        '
        Me.HighScoresToolStripMenuItem.Name = "HighScoresToolStripMenuItem"
        Me.HighScoresToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.HighScoresToolStripMenuItem.Text = "High Scores"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.EndToolStripMenuItem.Text = "End Game"
        '
        'tmrFlapDelay
        '
        Me.tmrFlapDelay.Interval = 20
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(394, 43)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(58, 49)
        Me.lblScore.TabIndex = 10
        Me.lblScore.Text = "0"
        '
        'picBird
        '
        Me.picBird.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picBird.BackColor = System.Drawing.Color.Transparent
        Me.picBird.Image = Global.FlappyBird.My.Resources.Resources.bird
        Me.picBird.Location = New System.Drawing.Point(145, 43)
        Me.picBird.Name = "picBird"
        Me.picBird.Size = New System.Drawing.Size(51, 50)
        Me.picBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBird.TabIndex = 6
        Me.picBird.TabStop = False
        '
        'pillarBottom2
        '
        Me.pillarBottom2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pillarBottom2.BackColor = System.Drawing.Color.Transparent
        Me.pillarBottom2.Image = CType(resources.GetObject("pillarBottom2.Image"), System.Drawing.Image)
        Me.pillarBottom2.Location = New System.Drawing.Point(27, 410)
        Me.pillarBottom2.Name = "pillarBottom2"
        Me.pillarBottom2.Size = New System.Drawing.Size(96, 288)
        Me.pillarBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pillarBottom2.TabIndex = 5
        Me.pillarBottom2.TabStop = False
        '
        'pillarTop2
        '
        Me.pillarTop2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pillarTop2.BackColor = System.Drawing.Color.Transparent
        Me.pillarTop2.Image = CType(resources.GetObject("pillarTop2.Image"), System.Drawing.Image)
        Me.pillarTop2.Location = New System.Drawing.Point(27, -137)
        Me.pillarTop2.Name = "pillarTop2"
        Me.pillarTop2.Size = New System.Drawing.Size(96, 288)
        Me.pillarTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pillarTop2.TabIndex = 4
        Me.pillarTop2.TabStop = False
        '
        'pillarBottom1
        '
        Me.pillarBottom1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pillarBottom1.BackColor = System.Drawing.Color.Transparent
        Me.pillarBottom1.Image = CType(resources.GetObject("pillarBottom1.Image"), System.Drawing.Image)
        Me.pillarBottom1.Location = New System.Drawing.Point(223, 410)
        Me.pillarBottom1.Name = "pillarBottom1"
        Me.pillarBottom1.Size = New System.Drawing.Size(96, 288)
        Me.pillarBottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pillarBottom1.TabIndex = 3
        Me.pillarBottom1.TabStop = False
        '
        'pillarTop1
        '
        Me.pillarTop1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pillarTop1.BackColor = System.Drawing.Color.Transparent
        Me.pillarTop1.Image = CType(resources.GetObject("pillarTop1.Image"), System.Drawing.Image)
        Me.pillarTop1.Location = New System.Drawing.Point(223, -137)
        Me.pillarTop1.Name = "pillarTop1"
        Me.pillarTop1.Size = New System.Drawing.Size(96, 288)
        Me.pillarTop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pillarTop1.TabIndex = 2
        Me.pillarTop1.TabStop = False
        '
        'picGrass
        '
        Me.picGrass.Image = Global.FlappyBird.My.Resources.Resources.grass_Sheet
        Me.picGrass.Location = New System.Drawing.Point(244, 410)
        Me.picGrass.Name = "picGrass"
        Me.picGrass.Size = New System.Drawing.Size(220, 62)
        Me.picGrass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGrass.TabIndex = 8
        Me.picGrass.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FlappyBird.My.Resources.Resources.grass_Sheet
        Me.PictureBox1.Location = New System.Drawing.Point(12, 410)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 471)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.picBird)
        Me.Controls.Add(Me.pillarBottom2)
        Me.Controls.Add(Me.pillarTop2)
        Me.Controls.Add(Me.pillarBottom1)
        Me.Controls.Add(Me.pillarTop1)
        Me.Controls.Add(Me.picGrass)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmGame"
        Me.Text = "Flappy Bird"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        CType(Me.picBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pillarBottom2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pillarTop2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pillarBottom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pillarTop1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pillarBottom1 As System.Windows.Forms.PictureBox
    Friend WithEvents pillarTop1 As System.Windows.Forms.PictureBox
    Friend WithEvents pillarBottom2 As System.Windows.Forms.PictureBox
    Friend WithEvents pillarTop2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrPillar As System.Windows.Forms.Timer
    Friend WithEvents tmrGravity As System.Windows.Forms.Timer
    Friend WithEvents picBird As System.Windows.Forms.PictureBox
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picGrass As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFlapDelay As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
End Class
