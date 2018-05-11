<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debugger
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPillars1 = New System.Windows.Forms.Label()
        Me.lblPillars2 = New System.Windows.Forms.Label()
        Me.lblPillars3 = New System.Windows.Forms.Label()
        Me.lblVelocity = New System.Windows.Forms.Label()
        Me.lblJumps = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Consolas", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(282, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Pillars:"
        '
        'lblPillars1
        '
        Me.lblPillars1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPillars1.Location = New System.Drawing.Point(12, 48)
        Me.lblPillars1.Name = "lblPillars1"
        Me.lblPillars1.Size = New System.Drawing.Size(436, 39)
        Me.lblPillars1.TabIndex = 1
        '
        'lblPillars2
        '
        Me.lblPillars2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPillars2.Location = New System.Drawing.Point(12, 87)
        Me.lblPillars2.Name = "lblPillars2"
        Me.lblPillars2.Size = New System.Drawing.Size(436, 39)
        Me.lblPillars2.TabIndex = 2
        '
        'lblPillars3
        '
        Me.lblPillars3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPillars3.Location = New System.Drawing.Point(12, 126)
        Me.lblPillars3.Name = "lblPillars3"
        Me.lblPillars3.Size = New System.Drawing.Size(436, 39)
        Me.lblPillars3.TabIndex = 3
        '
        'lblVelocity
        '
        Me.lblVelocity.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVelocity.Location = New System.Drawing.Point(12, 165)
        Me.lblVelocity.Name = "lblVelocity"
        Me.lblVelocity.Size = New System.Drawing.Size(436, 39)
        Me.lblVelocity.TabIndex = 4
        '
        'lblJumps
        '
        Me.lblJumps.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumps.Location = New System.Drawing.Point(12, 204)
        Me.lblJumps.Name = "lblJumps"
        Me.lblJumps.Size = New System.Drawing.Size(436, 39)
        Me.lblJumps.TabIndex = 5
        '
        'Debugger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 305)
        Me.Controls.Add(Me.lblJumps)
        Me.Controls.Add(Me.lblVelocity)
        Me.Controls.Add(Me.lblPillars3)
        Me.Controls.Add(Me.lblPillars2)
        Me.Controls.Add(Me.lblPillars1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Debugger"
        Me.Text = "Debugger"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPillars1 As System.Windows.Forms.Label
    Friend WithEvents lblPillars2 As System.Windows.Forms.Label
    Friend WithEvents lblPillars3 As System.Windows.Forms.Label
    Friend WithEvents lblVelocity As System.Windows.Forms.Label
    Friend WithEvents lblJumps As System.Windows.Forms.Label
End Class
