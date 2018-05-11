<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblInstruct = New System.Windows.Forms.Label()
        Me.picAnimation = New System.Windows.Forms.PictureBox()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(12, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(360, 47)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Welcome to Flappy Bird!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(94, 70)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(170, 60)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblInstruct
        '
        Me.lblInstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInstruct.Location = New System.Drawing.Point(13, 133)
        Me.lblInstruct.Name = "lblInstruct"
        Me.lblInstruct.Size = New System.Drawing.Size(225, 84)
        Me.lblInstruct.TabIndex = 2
        Me.lblInstruct.Text = "How to play:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press space to fly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Don't hit the pillars!"
        '
        'picAnimation
        '
        Me.picAnimation.Location = New System.Drawing.Point(17, 220)
        Me.picAnimation.Name = "picAnimation"
        Me.picAnimation.Size = New System.Drawing.Size(126, 115)
        Me.picAnimation.TabIndex = 3
        Me.picAnimation.TabStop = False
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(149, 259)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(223, 26)
        Me.txtPlayer.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(149, 220)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(223, 36)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Enter your name:"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(384, 434)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.picAnimation)
        Me.Controls.Add(Me.lblInstruct)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmStart"
        Me.Text = "Flappy Bird"
        CType(Me.picAnimation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblInstruct As System.Windows.Forms.Label
    Friend WithEvents picAnimation As System.Windows.Forms.PictureBox
    Friend WithEvents txtPlayer As System.Windows.Forms.TextBox
    Friend WithEvents lblName As Label
End Class
