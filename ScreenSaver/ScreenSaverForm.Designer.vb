<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScreenSaverForm
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
        Me.PaintTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RuleLabel = New System.Windows.Forms.Label()
        Me.GenerationLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PaintTimer
        '
        Me.PaintTimer.Interval = 50
        '
        'RuleLabel
        '
        Me.RuleLabel.AutoSize = True
        Me.RuleLabel.BackColor = System.Drawing.Color.Black
        Me.RuleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RuleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RuleLabel.ForeColor = System.Drawing.Color.White
        Me.RuleLabel.Location = New System.Drawing.Point(13, 13)
        Me.RuleLabel.Name = "RuleLabel"
        Me.RuleLabel.Size = New System.Drawing.Size(2, 39)
        Me.RuleLabel.TabIndex = 0
        '
        'GenerationLabel
        '
        Me.GenerationLabel.AutoSize = True
        Me.GenerationLabel.BackColor = System.Drawing.Color.Black
        Me.GenerationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenerationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerationLabel.ForeColor = System.Drawing.Color.Cyan
        Me.GenerationLabel.Location = New System.Drawing.Point(13, 64)
        Me.GenerationLabel.Name = "GenerationLabel"
        Me.GenerationLabel.Size = New System.Drawing.Size(2, 28)
        Me.GenerationLabel.TabIndex = 1
        '
        'ScreenSaverForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(512, 512)
        Me.Controls.Add(Me.GenerationLabel)
        Me.Controls.Add(Me.RuleLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ScreenSaverForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Screen Saver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PaintTimer As System.Windows.Forms.Timer
    Friend WithEvents RuleLabel As System.Windows.Forms.Label
    Friend WithEvents GenerationLabel As System.Windows.Forms.Label

End Class
