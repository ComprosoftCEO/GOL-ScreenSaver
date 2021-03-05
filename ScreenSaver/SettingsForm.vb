Imports Microsoft.Win32

Public Class SettingsForm

    Public Sub New()
        InitializeComponent()
        LoadSettings()
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub SaveSettings()
        Dim key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)

        key.SetValue(RANDOM_BG_KEY, BGRandomRadioButton.Checked)
        key.SetValue(RANDOM_FG_KEY, LifeRandomRadioButton.Checked)
        key.SetValue(BG_COLOR_KEY, BGColorBtn.BackColor.ToArgb())
        key.SetValue(FG_COLOR_KEY, LifeColorBtn.BackColor.ToArgb())
        key.SetValue(DELAY_GENERATIONS_KEY, DelayNumericUpDown.Value)

        'Delete and re-save all rules
        key.DeleteSubKeyTree("Rules")

        Dim ruleIndex As Integer = 0
        Dim rulesKey = key.CreateSubKey("Rules")
        For Each rule As RegistryRuleEntry In RuleCheckedListBox.Items
            Dim subkey = rulesKey.CreateSubKey(ruleIndex.ToString())
            rule.saveToRegistry(subkey)
            subkey.SetValue(RULE_ENABLED_KEY, RuleCheckedListBox.GetItemChecked(ruleIndex))

            ruleIndex += 1
        Next
    End Sub

    Private Sub LoadSettings()
        Dim key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)
        If Not key Is Nothing Then
            Dim randomBg As Boolean = CType(key.GetValue(RANDOM_BG_KEY, False), Boolean)
            BGRandomRadioButton.Checked = randomBg
            BGColorRadioButton.Checked = Not randomBg

            Dim randomFg As Boolean = CType(key.GetValue(RANDOM_FG_KEY, True), Boolean)
            LifeRandomRadioButton.Checked = randomFg
            LifeColorRadioButton.Checked = Not randomFg

            BGColorBtn.BackColor = Color.FromArgb(key.GetValue(BG_COLOR_KEY, &HFF000000))
            LifeColorBtn.BackColor = Color.FromArgb(key.GetValue(FG_COLOR_KEY, &HFFFFFFFF))
            DelayNumericUpDown.Value = key.GetValue(DELAY_GENERATIONS_KEY, 1000)

            'Load all of the rules
            PreBuiltLifeRules.maybeCreateDefaultLifeRules(key)

            Dim rulesKey = key.CreateSubKey("Rules")
            Dim rulesList As New List(Of RegistryRuleEntry)
            For Each subkeyName In rulesKey.GetSubKeyNames()
                Dim subkey = rulesKey.OpenSubKey(subkeyName)
                Dim rule = New RegistryRuleEntry(subkey)
                Dim enabled As Boolean = subkey.GetValue(RULE_ENABLED_KEY, True)

                Dim newItem = RuleCheckedListBox.Items.Add(rule)
                RuleCheckedListBox.SetItemChecked(newItem, enabled)
            Next
        End If
    End Sub

    Private Sub LifeColorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LifeColorBtn.Click
        If ColorPickerDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            LifeColorBtn.BackColor = ColorPickerDialog.Color
            LifeColorRadioButton.Checked = True
        End If
    End Sub

    Private Sub BGColorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BGColorBtn.Click
        If ColorPickerDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            BGColorBtn.BackColor = ColorPickerDialog.Color
            BGColorRadioButton.Checked = True
        End If
    End Sub

    Private Sub NewRuleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRuleButton.Click
        Dim newRule = RuleCheckedListBox.Items.Add(New RegistryRuleEntry())
        RuleCheckedListBox.SetItemChecked(newRule, True)
        RuleCheckedListBox.SelectedIndex = newRule
    End Sub

    Private Sub RuleCheckedListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RuleCheckedListBox.SelectedIndexChanged
        Dim buttonsEnabled As Boolean = RuleCheckedListBox.SelectedIndex >= 0
        EditRuleButton.Enabled = buttonsEnabled
        DeleteRuleButton.Enabled = buttonsEnabled
    End Sub

    Private Sub EditRuleButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditRuleButton.Click
        Dim selectedRule As RegistryRuleEntry = RuleCheckedListBox.SelectedItem
        If selectedRule IsNot Nothing Then
            Dim dialog = New EditRuleDialog(selectedRule)
            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                RuleCheckedListBox.Items(RuleCheckedListBox.SelectedIndex) = dialog.RuleEntry

                'Force the list to re-sort
                RuleCheckedListBox.Sorted = False
                RuleCheckedListBox.Sorted = True
            End If
        End If
    End Sub

    Private Sub DeleteRuleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRuleButton.Click
        If RuleCheckedListBox.SelectedIndex >= 0 Then
            RuleCheckedListBox.Items.RemoveAt(RuleCheckedListBox.SelectedIndex)
        End If
    End Sub
End Class