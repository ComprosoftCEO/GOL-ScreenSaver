<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRuleDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.BeginRuleSetControl = New ScreenSaver.RuleSetControl()
        Me.BeginLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SurviveRuleSetControl = New ScreenSaver.RuleSetControl()
        Me.SurviveLbl = New System.Windows.Forms.Label()
        Me.RuleNameTextBox = New System.Windows.Forms.TextBox()
        Me.RuleNameLbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(41, 210)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(230, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(24, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 3
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(139, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 4
        Me.Cancel_Button.Text = "Cancel"
        '
        'BeginRuleSetControl
        '
        Me.BeginRuleSetControl.Location = New System.Drawing.Point(5, 5)
        Me.BeginRuleSetControl.Name = "BeginRuleSetControl"
        Me.BeginRuleSetControl.Rule = 0
        Me.BeginRuleSetControl.Size = New System.Drawing.Size(123, 86)
        Me.BeginRuleSetControl.TabIndex = 1
        '
        'BeginLbl
        '
        Me.BeginLbl.AutoSize = True
        Me.BeginLbl.Location = New System.Drawing.Point(62, 68)
        Me.BeginLbl.Name = "BeginLbl"
        Me.BeginLbl.Size = New System.Drawing.Size(34, 13)
        Me.BeginLbl.TabIndex = 3
        Me.BeginLbl.Text = "Begin"
        Me.BeginLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BeginRuleSetControl)
        Me.Panel1.Location = New System.Drawing.Point(12, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 96)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SurviveRuleSetControl)
        Me.Panel2.Location = New System.Drawing.Point(167, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 96)
        Me.Panel2.TabIndex = 2
        '
        'SurviveRuleSetControl
        '
        Me.SurviveRuleSetControl.Location = New System.Drawing.Point(5, 5)
        Me.SurviveRuleSetControl.Name = "SurviveRuleSetControl"
        Me.SurviveRuleSetControl.Rule = 0
        Me.SurviveRuleSetControl.Size = New System.Drawing.Size(123, 86)
        Me.SurviveRuleSetControl.TabIndex = 1
        '
        'SurviveLbl
        '
        Me.SurviveLbl.AutoSize = True
        Me.SurviveLbl.Location = New System.Drawing.Point(206, 68)
        Me.SurviveLbl.Name = "SurviveLbl"
        Me.SurviveLbl.Size = New System.Drawing.Size(43, 13)
        Me.SurviveLbl.TabIndex = 7
        Me.SurviveLbl.Text = "Survive"
        Me.SurviveLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RuleNameTextBox
        '
        Me.RuleNameTextBox.Location = New System.Drawing.Point(115, 24)
        Me.RuleNameTextBox.MaxLength = 32
        Me.RuleNameTextBox.Name = "RuleNameTextBox"
        Me.RuleNameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.RuleNameTextBox.TabIndex = 0
        '
        'RuleNameLbl
        '
        Me.RuleNameLbl.AutoSize = True
        Me.RuleNameLbl.Location = New System.Drawing.Point(41, 28)
        Me.RuleNameLbl.Name = "RuleNameLbl"
        Me.RuleNameLbl.Size = New System.Drawing.Size(63, 13)
        Me.RuleNameLbl.TabIndex = 9
        Me.RuleNameLbl.Text = "Rule Name:"
        '
        'EditRuleDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(312, 251)
        Me.Controls.Add(Me.RuleNameLbl)
        Me.Controls.Add(Me.RuleNameTextBox)
        Me.Controls.Add(Me.SurviveLbl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BeginLbl)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditRuleDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Rule"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents BeginRuleSetControl As ScreenSaver.RuleSetControl
    Friend WithEvents BeginLbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SurviveRuleSetControl As ScreenSaver.RuleSetControl
    Friend WithEvents SurviveLbl As System.Windows.Forms.Label
    Friend WithEvents RuleNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RuleNameLbl As System.Windows.Forms.Label

End Class
