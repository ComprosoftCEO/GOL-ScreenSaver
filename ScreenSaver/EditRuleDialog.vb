Imports System.Windows.Forms

Public Class EditRuleDialog

    Public ReadOnly Property RuleEntry As RegistryRuleEntry
        Get
            Return New RegistryRuleEntry(RuleNameTextBox.Text, BeginRuleSetControl.Rule, SurviveRuleSetControl.Rule)
        End Get
    End Property

    Public Sub New(ByVal rule As RegistryRuleEntry)
        InitializeComponent()

        ' Load initial values
        RuleNameTextBox.Text = rule.Name
        BeginRuleSetControl.Rule = rule.Begin
        SurviveRuleSetControl.Rule = rule.Survive
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BeginRuleSetControl_ValueChanged(ByVal sender As System.Object)

    End Sub
    Private Sub SurviveRuleSetControl_ValueChanged(ByVal sender As System.Object)

    End Sub
End Class
