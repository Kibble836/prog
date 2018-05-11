<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHighScore
        '
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(12, 9)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(260, 26)
        Me.lblHighScore.TabIndex = 1
        Me.lblHighScore.Text = "High Scores"
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 35)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(260, 217)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "homosexual, gay"
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblHighScore)
        Me.Name = "HighScores"
        Me.Text = "HighScores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents lblScore As Label
End Class
