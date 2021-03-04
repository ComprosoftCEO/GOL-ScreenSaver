<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.GOLLabel = New System.Windows.Forms.Label()
        Me.CreatedByLabel = New System.Windows.Forms.Label()
        Me.LifeColorPanel = New System.Windows.Forms.Panel()
        Me.LifeRandomRadioButton = New System.Windows.Forms.RadioButton()
        Me.LifeColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.LifeColorBtn = New System.Windows.Forms.Button()
        Me.LifeColorLabel = New System.Windows.Forms.Label()
        Me.BackgroundColorLabel = New System.Windows.Forms.Label()
        Me.BGColorPanel = New System.Windows.Forms.Panel()
        Me.BGColorBtn = New System.Windows.Forms.Button()
        Me.BGColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.BGRandomRadioButton = New System.Windows.Forms.RadioButton()
        Me.DelayLabel = New System.Windows.Forms.Label()
        Me.DelayNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SecLabel = New System.Windows.Forms.Label()
        Me.ColorPickerDialog = New System.Windows.Forms.ColorDialog()
        Me.LifeColorPanel.SuspendLayout()
        Me.BGColorPanel.SuspendLayout()
        CType(Me.DelayNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OkBtn.Location = New System.Drawing.Point(52, 470)
        Me.OkBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(112, 35)
        Me.OkBtn.TabIndex = 8
        Me.OkBtn.Text = "&Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(228, 470)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(112, 35)
        Me.CancelBtn.TabIndex = 9
        Me.CancelBtn.Text = "&Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'GOLLabel
        '
        Me.GOLLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GOLLabel.AutoSize = True
        Me.GOLLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOLLabel.ForeColor = System.Drawing.Color.Red
        Me.GOLLabel.Location = New System.Drawing.Point(18, 14)
        Me.GOLLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GOLLabel.Name = "GOLLabel"
        Me.GOLLabel.Size = New System.Drawing.Size(358, 33)
        Me.GOLLabel.TabIndex = 2
        Me.GOLLabel.Text = "Game of Life ScreenSaver"
        Me.GOLLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CreatedByLabel
        '
        Me.CreatedByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CreatedByLabel.AutoSize = True
        Me.CreatedByLabel.Location = New System.Drawing.Point(96, 62)
        Me.CreatedByLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CreatedByLabel.Name = "CreatedByLabel"
        Me.CreatedByLabel.Size = New System.Drawing.Size(197, 20)
        Me.CreatedByLabel.TabIndex = 3
        Me.CreatedByLabel.Text = "Created By: Bryan McClain"
        Me.CreatedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LifeColorPanel
        '
        Me.LifeColorPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LifeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LifeColorPanel.Controls.Add(Me.LifeColorBtn)
        Me.LifeColorPanel.Controls.Add(Me.LifeColorRadioButton)
        Me.LifeColorPanel.Controls.Add(Me.LifeRandomRadioButton)
        Me.LifeColorPanel.Location = New System.Drawing.Point(25, 146)
        Me.LifeColorPanel.Name = "LifeColorPanel"
        Me.LifeColorPanel.Size = New System.Drawing.Size(341, 42)
        Me.LifeColorPanel.TabIndex = 1
        '
        'LifeRandomRadioButton
        '
        Me.LifeRandomRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeRandomRadioButton.AutoSize = True
        Me.LifeRandomRadioButton.Checked = True
        Me.LifeRandomRadioButton.Location = New System.Drawing.Point(26, 8)
        Me.LifeRandomRadioButton.Name = "LifeRandomRadioButton"
        Me.LifeRandomRadioButton.Size = New System.Drawing.Size(95, 24)
        Me.LifeRandomRadioButton.TabIndex = 1
        Me.LifeRandomRadioButton.TabStop = True
        Me.LifeRandomRadioButton.Text = "Random"
        Me.LifeRandomRadioButton.UseVisualStyleBackColor = True
        '
        'LifeColorRadioButton
        '
        Me.LifeColorRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeColorRadioButton.AutoSize = True
        Me.LifeColorRadioButton.Location = New System.Drawing.Point(145, 8)
        Me.LifeColorRadioButton.Name = "LifeColorRadioButton"
        Me.LifeColorRadioButton.Size = New System.Drawing.Size(131, 24)
        Me.LifeColorRadioButton.TabIndex = 2
        Me.LifeColorRadioButton.Text = "Specific Color"
        Me.LifeColorRadioButton.UseVisualStyleBackColor = True
        '
        'LifeColorBtn
        '
        Me.LifeColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeColorBtn.BackColor = System.Drawing.Color.White
        Me.LifeColorBtn.Location = New System.Drawing.Point(282, 5)
        Me.LifeColorBtn.Name = "LifeColorBtn"
        Me.LifeColorBtn.Size = New System.Drawing.Size(32, 32)
        Me.LifeColorBtn.TabIndex = 3
        Me.LifeColorBtn.UseVisualStyleBackColor = False
        '
        'LifeColorLabel
        '
        Me.LifeColorLabel.AutoSize = True
        Me.LifeColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LifeColorLabel.Location = New System.Drawing.Point(152, 120)
        Me.LifeColorLabel.Name = "LifeColorLabel"
        Me.LifeColorLabel.Size = New System.Drawing.Size(86, 20)
        Me.LifeColorLabel.TabIndex = 6
        Me.LifeColorLabel.Text = "Life Color"
        Me.LifeColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BackgroundColorLabel
        '
        Me.BackgroundColorLabel.AutoSize = True
        Me.BackgroundColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundColorLabel.Location = New System.Drawing.Point(119, 239)
        Me.BackgroundColorLabel.Name = "BackgroundColorLabel"
        Me.BackgroundColorLabel.Size = New System.Drawing.Size(152, 20)
        Me.BackgroundColorLabel.TabIndex = 8
        Me.BackgroundColorLabel.Text = "Background Color"
        Me.BackgroundColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BGColorPanel
        '
        Me.BGColorPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BGColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BGColorPanel.Controls.Add(Me.BGColorBtn)
        Me.BGColorPanel.Controls.Add(Me.BGColorRadioButton)
        Me.BGColorPanel.Controls.Add(Me.BGRandomRadioButton)
        Me.BGColorPanel.Location = New System.Drawing.Point(25, 265)
        Me.BGColorPanel.Name = "BGColorPanel"
        Me.BGColorPanel.Size = New System.Drawing.Size(341, 42)
        Me.BGColorPanel.TabIndex = 2
        '
        'BGColorBtn
        '
        Me.BGColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGColorBtn.BackColor = System.Drawing.Color.Black
        Me.BGColorBtn.Location = New System.Drawing.Point(282, 5)
        Me.BGColorBtn.Name = "BGColorBtn"
        Me.BGColorBtn.Size = New System.Drawing.Size(32, 32)
        Me.BGColorBtn.TabIndex = 3
        Me.BGColorBtn.UseVisualStyleBackColor = False
        '
        'BGColorRadioButton
        '
        Me.BGColorRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGColorRadioButton.AutoSize = True
        Me.BGColorRadioButton.Location = New System.Drawing.Point(145, 8)
        Me.BGColorRadioButton.Name = "BGColorRadioButton"
        Me.BGColorRadioButton.Size = New System.Drawing.Size(131, 24)
        Me.BGColorRadioButton.TabIndex = 2
        Me.BGColorRadioButton.Text = "Specific Color"
        Me.BGColorRadioButton.UseVisualStyleBackColor = True
        '
        'BGRandomRadioButton
        '
        Me.BGRandomRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGRandomRadioButton.AutoSize = True
        Me.BGRandomRadioButton.Checked = True
        Me.BGRandomRadioButton.Location = New System.Drawing.Point(26, 8)
        Me.BGRandomRadioButton.Name = "BGRandomRadioButton"
        Me.BGRandomRadioButton.Size = New System.Drawing.Size(95, 24)
        Me.BGRandomRadioButton.TabIndex = 1
        Me.BGRandomRadioButton.TabStop = True
        Me.BGRandomRadioButton.Text = "Random"
        Me.BGRandomRadioButton.UseVisualStyleBackColor = True
        '
        'DelayLabel
        '
        Me.DelayLabel.AutoSize = True
        Me.DelayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelayLabel.Location = New System.Drawing.Point(109, 349)
        Me.DelayLabel.Name = "DelayLabel"
        Me.DelayLabel.Size = New System.Drawing.Size(172, 20)
        Me.DelayLabel.TabIndex = 9
        Me.DelayLabel.Text = "Pick New Rule Every"
        Me.DelayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DelayNumericUpDown
        '
        Me.DelayNumericUpDown.Location = New System.Drawing.Point(70, 381)
        Me.DelayNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DelayNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DelayNumericUpDown.Name = "DelayNumericUpDown"
        Me.DelayNumericUpDown.Size = New System.Drawing.Size(141, 26)
        Me.DelayNumericUpDown.TabIndex = 3
        Me.DelayNumericUpDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'SecLabel
        '
        Me.SecLabel.AutoSize = True
        Me.SecLabel.Location = New System.Drawing.Point(224, 384)
        Me.SecLabel.Name = "SecLabel"
        Me.SecLabel.Size = New System.Drawing.Size(97, 20)
        Me.SecLabel.TabIndex = 11
        Me.SecLabel.Text = "Generations"
        Me.SecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(390, 524)
        Me.Controls.Add(Me.SecLabel)
        Me.Controls.Add(Me.DelayNumericUpDown)
        Me.Controls.Add(Me.DelayLabel)
        Me.Controls.Add(Me.BackgroundColorLabel)
        Me.Controls.Add(Me.BGColorPanel)
        Me.Controls.Add(Me.LifeColorLabel)
        Me.Controls.Add(Me.LifeColorPanel)
        Me.Controls.Add(Me.CreatedByLabel)
        Me.Controls.Add(Me.GOLLabel)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.OkBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.LifeColorPanel.ResumeLayout(False)
        Me.LifeColorPanel.PerformLayout()
        Me.BGColorPanel.ResumeLayout(False)
        Me.BGColorPanel.PerformLayout()
        CType(Me.DelayNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents GOLLabel As System.Windows.Forms.Label
    Friend WithEvents CreatedByLabel As System.Windows.Forms.Label
    Friend WithEvents LifeColorPanel As System.Windows.Forms.Panel
    Friend WithEvents LifeRandomRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LifeColorBtn As System.Windows.Forms.Button
    Friend WithEvents LifeColorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LifeColorLabel As System.Windows.Forms.Label
    Friend WithEvents BackgroundColorLabel As System.Windows.Forms.Label
    Friend WithEvents BGColorPanel As System.Windows.Forms.Panel
    Friend WithEvents BGColorBtn As System.Windows.Forms.Button
    Friend WithEvents BGColorRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents BGRandomRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DelayLabel As System.Windows.Forms.Label
    Friend WithEvents DelayNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SecLabel As System.Windows.Forms.Label
    Friend WithEvents ColorPickerDialog As System.Windows.Forms.ColorDialog
End Class
