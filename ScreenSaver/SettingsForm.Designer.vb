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
        Me.LifeColorBtn = New System.Windows.Forms.Button()
        Me.LifeColorRadioButton = New System.Windows.Forms.RadioButton()
        Me.LifeRandomRadioButton = New System.Windows.Forms.RadioButton()
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
        Me.NewRuleButton = New System.Windows.Forms.Button()
        Me.DeleteRuleButton = New System.Windows.Forms.Button()
        Me.EditRuleButton = New System.Windows.Forms.Button()
        Me.ManageRulesLabel = New System.Windows.Forms.Label()
        Me.RuleCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.LifeColorPanel.SuspendLayout()
        Me.BGColorPanel.SuspendLayout()
        CType(Me.DelayNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OkBtn
        '
        Me.OkBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OkBtn.Location = New System.Drawing.Point(129, 305)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 8
        Me.OkBtn.Text = "&Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(246, 305)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
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
        Me.GOLLabel.Location = New System.Drawing.Point(106, 9)
        Me.GOLLabel.Name = "GOLLabel"
        Me.GOLLabel.Size = New System.Drawing.Size(229, 24)
        Me.GOLLabel.TabIndex = 2
        Me.GOLLabel.Text = "Game of Life ScreenSaver"
        Me.GOLLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CreatedByLabel
        '
        Me.CreatedByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CreatedByLabel.AutoSize = True
        Me.CreatedByLabel.Location = New System.Drawing.Point(158, 40)
        Me.CreatedByLabel.Name = "CreatedByLabel"
        Me.CreatedByLabel.Size = New System.Drawing.Size(133, 13)
        Me.CreatedByLabel.TabIndex = 3
        Me.CreatedByLabel.Text = "Created By: Bryan McClain"
        Me.CreatedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LifeColorPanel
        '
        Me.LifeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LifeColorPanel.Controls.Add(Me.LifeColorBtn)
        Me.LifeColorPanel.Controls.Add(Me.LifeColorRadioButton)
        Me.LifeColorPanel.Controls.Add(Me.LifeRandomRadioButton)
        Me.LifeColorPanel.Location = New System.Drawing.Point(17, 95)
        Me.LifeColorPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.LifeColorPanel.Name = "LifeColorPanel"
        Me.LifeColorPanel.Size = New System.Drawing.Size(228, 28)
        Me.LifeColorPanel.TabIndex = 1
        '
        'LifeColorBtn
        '
        Me.LifeColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeColorBtn.BackColor = System.Drawing.Color.White
        Me.LifeColorBtn.Location = New System.Drawing.Point(188, 3)
        Me.LifeColorBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LifeColorBtn.Name = "LifeColorBtn"
        Me.LifeColorBtn.Size = New System.Drawing.Size(21, 21)
        Me.LifeColorBtn.TabIndex = 3
        Me.LifeColorBtn.UseVisualStyleBackColor = False
        '
        'LifeColorRadioButton
        '
        Me.LifeColorRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeColorRadioButton.AutoSize = True
        Me.LifeColorRadioButton.Location = New System.Drawing.Point(97, 5)
        Me.LifeColorRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LifeColorRadioButton.Name = "LifeColorRadioButton"
        Me.LifeColorRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.LifeColorRadioButton.TabIndex = 2
        Me.LifeColorRadioButton.Text = "Specific Color"
        Me.LifeColorRadioButton.UseVisualStyleBackColor = True
        '
        'LifeRandomRadioButton
        '
        Me.LifeRandomRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LifeRandomRadioButton.AutoSize = True
        Me.LifeRandomRadioButton.Checked = True
        Me.LifeRandomRadioButton.Location = New System.Drawing.Point(17, 5)
        Me.LifeRandomRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LifeRandomRadioButton.Name = "LifeRandomRadioButton"
        Me.LifeRandomRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.LifeRandomRadioButton.TabIndex = 1
        Me.LifeRandomRadioButton.TabStop = True
        Me.LifeRandomRadioButton.Text = "Random"
        Me.LifeRandomRadioButton.UseVisualStyleBackColor = True
        '
        'LifeColorLabel
        '
        Me.LifeColorLabel.AutoSize = True
        Me.LifeColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LifeColorLabel.Location = New System.Drawing.Point(101, 78)
        Me.LifeColorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LifeColorLabel.Name = "LifeColorLabel"
        Me.LifeColorLabel.Size = New System.Drawing.Size(61, 13)
        Me.LifeColorLabel.TabIndex = 6
        Me.LifeColorLabel.Text = "Life Color"
        Me.LifeColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BackgroundColorLabel
        '
        Me.BackgroundColorLabel.AutoSize = True
        Me.BackgroundColorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundColorLabel.Location = New System.Drawing.Point(79, 155)
        Me.BackgroundColorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BackgroundColorLabel.Name = "BackgroundColorLabel"
        Me.BackgroundColorLabel.Size = New System.Drawing.Size(108, 13)
        Me.BackgroundColorLabel.TabIndex = 8
        Me.BackgroundColorLabel.Text = "Background Color"
        Me.BackgroundColorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BGColorPanel
        '
        Me.BGColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BGColorPanel.Controls.Add(Me.BGColorBtn)
        Me.BGColorPanel.Controls.Add(Me.BGColorRadioButton)
        Me.BGColorPanel.Controls.Add(Me.BGRandomRadioButton)
        Me.BGColorPanel.Location = New System.Drawing.Point(17, 172)
        Me.BGColorPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BGColorPanel.Name = "BGColorPanel"
        Me.BGColorPanel.Size = New System.Drawing.Size(228, 28)
        Me.BGColorPanel.TabIndex = 2
        '
        'BGColorBtn
        '
        Me.BGColorBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGColorBtn.BackColor = System.Drawing.Color.Black
        Me.BGColorBtn.Location = New System.Drawing.Point(188, 3)
        Me.BGColorBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BGColorBtn.Name = "BGColorBtn"
        Me.BGColorBtn.Size = New System.Drawing.Size(21, 21)
        Me.BGColorBtn.TabIndex = 3
        Me.BGColorBtn.UseVisualStyleBackColor = False
        '
        'BGColorRadioButton
        '
        Me.BGColorRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGColorRadioButton.AutoSize = True
        Me.BGColorRadioButton.Location = New System.Drawing.Point(97, 5)
        Me.BGColorRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BGColorRadioButton.Name = "BGColorRadioButton"
        Me.BGColorRadioButton.Size = New System.Drawing.Size(90, 17)
        Me.BGColorRadioButton.TabIndex = 2
        Me.BGColorRadioButton.Text = "Specific Color"
        Me.BGColorRadioButton.UseVisualStyleBackColor = True
        '
        'BGRandomRadioButton
        '
        Me.BGRandomRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BGRandomRadioButton.AutoSize = True
        Me.BGRandomRadioButton.Checked = True
        Me.BGRandomRadioButton.Location = New System.Drawing.Point(17, 5)
        Me.BGRandomRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BGRandomRadioButton.Name = "BGRandomRadioButton"
        Me.BGRandomRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.BGRandomRadioButton.TabIndex = 1
        Me.BGRandomRadioButton.TabStop = True
        Me.BGRandomRadioButton.Text = "Random"
        Me.BGRandomRadioButton.UseVisualStyleBackColor = True
        '
        'DelayLabel
        '
        Me.DelayLabel.AutoSize = True
        Me.DelayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelayLabel.Location = New System.Drawing.Point(73, 227)
        Me.DelayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DelayLabel.Name = "DelayLabel"
        Me.DelayLabel.Size = New System.Drawing.Size(127, 13)
        Me.DelayLabel.TabIndex = 9
        Me.DelayLabel.Text = "Pick New Rule Every"
        Me.DelayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DelayNumericUpDown
        '
        Me.DelayNumericUpDown.Location = New System.Drawing.Point(47, 248)
        Me.DelayNumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.DelayNumericUpDown.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DelayNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DelayNumericUpDown.Name = "DelayNumericUpDown"
        Me.DelayNumericUpDown.Size = New System.Drawing.Size(94, 20)
        Me.DelayNumericUpDown.TabIndex = 3
        Me.DelayNumericUpDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'SecLabel
        '
        Me.SecLabel.AutoSize = True
        Me.SecLabel.Location = New System.Drawing.Point(149, 250)
        Me.SecLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SecLabel.Name = "SecLabel"
        Me.SecLabel.Size = New System.Drawing.Size(64, 13)
        Me.SecLabel.TabIndex = 11
        Me.SecLabel.Text = "Generations"
        Me.SecLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewRuleButton
        '
        Me.NewRuleButton.Location = New System.Drawing.Point(277, 240)
        Me.NewRuleButton.Name = "NewRuleButton"
        Me.NewRuleButton.Size = New System.Drawing.Size(39, 23)
        Me.NewRuleButton.TabIndex = 5
        Me.NewRuleButton.Text = "&New"
        Me.NewRuleButton.UseVisualStyleBackColor = True
        '
        'DeleteRuleButton
        '
        Me.DeleteRuleButton.Enabled = False
        Me.DeleteRuleButton.Location = New System.Drawing.Point(375, 240)
        Me.DeleteRuleButton.Name = "DeleteRuleButton"
        Me.DeleteRuleButton.Size = New System.Drawing.Size(48, 23)
        Me.DeleteRuleButton.TabIndex = 7
        Me.DeleteRuleButton.Text = "&Delete"
        Me.DeleteRuleButton.UseVisualStyleBackColor = True
        '
        'EditRuleButton
        '
        Me.EditRuleButton.Enabled = False
        Me.EditRuleButton.Location = New System.Drawing.Point(326, 240)
        Me.EditRuleButton.Name = "EditRuleButton"
        Me.EditRuleButton.Size = New System.Drawing.Size(39, 23)
        Me.EditRuleButton.TabIndex = 6
        Me.EditRuleButton.Text = "&Edit"
        Me.EditRuleButton.UseVisualStyleBackColor = True
        '
        'ManageRulesLabel
        '
        Me.ManageRulesLabel.AutoSize = True
        Me.ManageRulesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageRulesLabel.Location = New System.Drawing.Point(305, 76)
        Me.ManageRulesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ManageRulesLabel.Name = "ManageRulesLabel"
        Me.ManageRulesLabel.Size = New System.Drawing.Size(84, 13)
        Me.ManageRulesLabel.TabIndex = 16
        Me.ManageRulesLabel.Text = "Custom Rules"
        Me.ManageRulesLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RuleCheckedListBox
        '
        Me.RuleCheckedListBox.FormattingEnabled = True
        Me.RuleCheckedListBox.Location = New System.Drawing.Point(277, 95)
        Me.RuleCheckedListBox.Name = "RuleCheckedListBox"
        Me.RuleCheckedListBox.Size = New System.Drawing.Size(147, 139)
        Me.RuleCheckedListBox.Sorted = True
        Me.RuleCheckedListBox.TabIndex = 4
        '
        'SettingsForm
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(449, 341)
        Me.Controls.Add(Me.RuleCheckedListBox)
        Me.Controls.Add(Me.ManageRulesLabel)
        Me.Controls.Add(Me.EditRuleButton)
        Me.Controls.Add(Me.DeleteRuleButton)
        Me.Controls.Add(Me.NewRuleButton)
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
        Me.MaximizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ScreenSaver Settings"
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
    Friend WithEvents NewRuleButton As System.Windows.Forms.Button
    Friend WithEvents DeleteRuleButton As System.Windows.Forms.Button
    Friend WithEvents EditRuleButton As System.Windows.Forms.Button
    Friend WithEvents ManageRulesLabel As System.Windows.Forms.Label
    Friend WithEvents RuleCheckedListBox As System.Windows.Forms.CheckedListBox
End Class
