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

            BGColorBtn.BackColor = Color.FromArgb(key.GetValue(BG_COLOR_KEY, &HFFFFFFFFF))
            LifeColorBtn.BackColor = Color.FromArgb(key.GetValue(FG_COLOR_KEY, &H0))
            DelayNumericUpDown.Value = key.GetValue(DELAY_GENERATIONS_KEY, 1000)
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
End Class