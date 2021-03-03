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
        key.SetValue("randomRule", RandomRuleCheckBox.Checked)
    End Sub

    Private Sub LoadSettings()
        Dim key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)
        If key Is Nothing Then
            RandomRuleCheckBox.Checked = True
        Else
            RandomRuleCheckBox.Checked = CType(key.GetValue("randomRule"), Boolean)
        End If
    End Sub

End Class