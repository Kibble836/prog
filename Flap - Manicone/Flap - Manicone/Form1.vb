Public Class frmGame
    'Dominick Manicone    

    Private pillar(1, 1) As PictureBox                                      'pillars
    Private dblVelocity As Double = 0                                       'gravity
    Private intCanJump As Integer = 2                                       'jump delays
    Public intScore As Integer = 0                                          'the player's score
    Public strPlayer As String                                              'player's name for scores
    Private blnPillarCounted As Boolean                                     'flag to count score of pillar if true

    Public Structure Attributes
        Public Const intYGap As Integer = 150                               'vertical gap between pillars
        Public Const intXGap As Integer = 287                               'horizontal gap between pillars
        Public Const intOffset As Integer = 75                              'vertical offset between the form and pillar generation
        Public Const intSpeed As Integer = 2                                'speed at which the pillars move each tick
        Public Const intTermVel As Integer = 7                              'clamping velocity for fallspeed of bird
        Public Const dblGravFactor As Double = 0.5                              'magnitude to add to gravity
        Public Const intJumpStrength As Integer = -15                           'force to add to a jump
        Public Const intJumpDelay As Integer = 10                               'delay between jumps
        Public Const intBirdX As Integer = 100                                  'X position to place the bird
        Public Const intDetectionRadius As Integer = 2                          'radius to detect pillars

        Public Const intFrmWidth As Integer = 500                               'width of the form
        Public Const intFrmHeight As Integer = 500                              'height of the form
        Public Const intMaxH As Integer = intFrmHeight - intOffset              'maximum height for the pillars to generate
        Public Const intMinH As Integer = intFrmHeight - intOffset - intYGap    'minimum height for the pillars to generate 
    End Structure

    Private Sub frmGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then 'check if space is down
            'Jump
            If intCanJump >= 2 Then
                tmrFlapDelay.Enabled = True
                intCanJump = 0
                dblVelocity += Attributes.intJumpStrength
                Debugger.lblJumps.Text += 1
            End If
        End If
    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debugger.Show()
        'Initialization
        Debugger.lblJumps.Text = 0
        tmrPillar.Enabled = True
        tmrGravity.Enabled = True
        Me.Size = New Size(Attributes.intFrmWidth, Attributes.intFrmHeight)
        mnuMenu.Visible = False
        Randomize()
        'first pair of pillars
        pillar(0, 0) = pillarTop1
        pillar(0, 1) = pillarBottom1
        '2nd pair of pillars
        pillar(1, 0) = pillarTop2
        pillar(1, 1) = pillarBottom2
        picBird.Location = New Point(Attributes.intBirdX, Attributes.intFrmHeight / 2)
        '1st pair of pillars
        Call SetPillar(0)
        '2nd pair of pillars      
        Dim intRand As Integer = Rand(Attributes.intMinH, Attributes.intMaxH)
        With pillar(1, 1)                                                   'sets the location to be a random height and to appear off the form
            .Left = pillar(0, 1).Left + Attributes.intXGap
            .Top = intRand
        End With
        With pillar(1, 0)                                                   'sets the location to be a random height minus the gap and to appear off the form
            .Left = pillar(0, 0).Left + Attributes.intXGap
            .Top = intRand - Attributes.intYGap - .Size.Height
        End With
    End Sub

    Private Sub SetPillar(ByVal intPillar As Integer)
        Dim intRand As Integer = Rand(Attributes.intMinH, Attributes.intMaxH)       'dimming the random number
        With pillar(intPillar, 1)                                                   'sets the location to be a random height and to appear off the form
            .Left = Me.ClientRectangle.Right
            .Top = intRand
        End With
        blnPillarCounted = True
        With pillar(intPillar, 0)                                                   'sets the location to be a random height minus the gap and to appear off the form
            .Left = Me.ClientRectangle.Right
            .Top = intRand - Attributes.intYGap - .Size.Height
        End With
    End Sub

    'Function which returns a random value between intLow and intHigh
    Public Function Rand(ByVal intLow As Integer, ByVal intHigh As Integer) As Integer
        Return Rnd() * (intHigh - intLow + 1) + intLow
    End Function

    Public Sub Tween(ByRef obj As Object, ByVal xdest As Integer, ByVal ydest As Integer)
        With obj
            Dim newX = (.Location.X + xdest) / 2
            Dim newY = (.Location.Y + ydest) / 2
            .Location = New Point(newX, newY)
        End With
    End Sub

    Public Function Clamp(ByVal dblVal As Double, ByVal dblMin As Double, ByVal dblMax As Double) 'Clamps a value between two numbers.
        If dblVal > dblMax Then
            dblVal = dblMax
        ElseIf dblVal < dblMin Then
            dblVal = dblMin
        End If
        Return dblVal
    End Function

    Private Sub tmrPillar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPillar.Tick
        Static intBirdMid As Integer
        Static intPillarMid As Integer
        intBirdMid = picBird.Left - picBird.Size.Width / 2
        'Update the pillars
        For x = 0 To 1
            For y = 0 To 1
                pillar(x, y).Left -= Attributes.intSpeed
            Next
            intPillarMid = pillar(x, 0).Left - pillar(x, 0).Size.Width / 2
            If Math.Abs(intPillarMid - intBirdMid) <= Attributes.intDetectionRadius And blnPillarCounted = True Then
                blnPillarCounted = False
                intScore += 1
                lblScore.Text = intScore
            End If
            'Reset pillar location when offscreen
            If pillar(x, 0).Right <= Me.ClientRectangle.Left Then
                Call SetPillar(x)
            End If
        Next
        'Update the Debugger
        Debugger.lblPillars1.Text = "Top: (" + pillar(0, 0).Left.ToString + ", " + pillar(0, 0).Bottom.ToString + ") Bottom: (" + pillar(0, 1).Left.ToString + ", " + pillar(0, 1).Top.ToString + ")"
        Debugger.lblPillars2.Text = "Top: (" + pillar(1, 0).Left.ToString + ", " + pillar(1, 0).Bottom.ToString + ") Bottom: (" + pillar(1, 1).Left.ToString + ", " + pillar(1, 1).Top.ToString + ")"
        Debugger.lblPillars3.Text = "Distance: " + (pillar(0, 0).Left - pillar(1, 0).Left).ToString
    End Sub

    Private Sub tmrGravity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGravity.Tick
        Static dblGravity As Double
        With picBird
            dblVelocity += Attributes.dblGravFactor 'increase gravity by the factor
            dblVelocity = Clamp(dblVelocity, -Attributes.intTermVel, Attributes.intTermVel) 'clamp the velocity to a terminal velocity

            .Top += dblVelocity 'change the height
            Debugger.lblVelocity.Text = "Velocity: " + dblVelocity.ToString + " Gravity: " + dblGravity.ToString 'output to debugger
        End With
        Call Collision(picBird, pillar(0, 0))
        Call Collision(picBird, pillar(0, 1))
        Call Collision(picBird, pillar(1, 0))
        Call Collision(picBird, pillar(1, 1))
        Call SkyBox(picBird)
    End Sub

    Sub EndGame()
        tmrPillar.Enabled = False
        mnuMenu.Visible = True

        Dim intFile As Integer
        If intScore > HighScores.intHScore Then                 'if score is higher than the default high score
            intFile = FreeFile()
            FileOpen(intFile, "HighScore.txt", OpenMode.Output)
            PrintLine(intFile, strPlayer)
            PrintLine(intFile, intScore)
            FileClose()
        End If
    End Sub

    Sub SkyBox(ByRef picBird As PictureBox)
        '/////SETUP CLIENT RECTANGLE FOR SKYBOX
    End Sub

    Sub Collision(ByRef picBird As PictureBox, ByRef picPillar As PictureBox)
        Static blnHit As Boolean

        If blnHit = False Then  'if the bird hasn't hit the pillar yet, stops running if the bird hit
            If picBird.Bounds.IntersectsWith(picPillar.Bounds) Then
                blnHit = True                
                'MsgBox("You hit a pillar", MsgBoxStyle.OkOnly, "Loser")
                Call EndGame()
            End If
        End If
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        frmStart.Show()
        Me.Hide()
        Call frmGame_Load(sender, e)
    End Sub

    Private Sub tmrFlapDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlapDelay.Tick
        intCanJump += 1
        If intCanJump >= 2 Then
            tmrFlapDelay.Enabled = False
        End If
    End Sub

    Private Sub HighScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoresToolStripMenuItem.Click
        HighScores.Show()
    End Sub
End Class
