Module App
    ''' <summary>
    ''' ScreenSaver app entry point
    ''' </summary>
    <STAThread()> _
    Public Sub Main(ByVal args As String())
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.DoEvents()

        ' Handle cases where arguments are separated by colon.
        ' Examples: /c:1234567 or /P:1234567
        If args.Length > 0 Then

            Dim firstArgument As String = args(0).ToLower().Trim()
            Dim secondArgument As String = Nothing
            ParseArguments(args, firstArgument, secondArgument)

            If firstArgument = "/c" Then
                'Settings Form
                Application.Run(New SettingsForm())

            ElseIf firstArgument = "/p" Then
                'Preview Mode
                If secondArgument Is Nothing Then
                    MessageBox.Show("Sorry, but the expected window handle was not provided.",
                                    "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If

                Dim previewWndHandle = New IntPtr(Long.Parse(secondArgument))
                Application.Run(New ScreenSaverForm(previewWndHandle))

            ElseIf firstArgument = "/s" Then
                'Full-screen Mode
                ShowScreenSaver()
                Application.Run()

            Else
                'Undefined arguments
                MessageBox.Show("Sorry, but the command line argument """ + firstArgument + """ is not valid.",
                                "ScreenSaver", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            'No arguments, treat like /c
            Application.Run(New SettingsForm())
        End If

    End Sub

    ''' <summary>
    ''' Parse the command-line arguments
    ''' </summary>
    Private Sub ParseArguments(ByVal args As String(), ByRef firstArgument As String, ByRef secondArgument As String)
        If firstArgument.Length > 2 Then
            secondArgument = firstArgument.Substring(3).Trim()
            firstArgument = firstArgument.Substring(0, 2)
        ElseIf args.Length > 1 Then
            secondArgument = args(1)
        End If
    End Sub

    ''' <summary>
    ''' Show the screen saver form
    ''' </summary>
    Private Sub ShowScreenSaver()
        For Each screen As Screen In screen.AllScreens
            Dim screensaver As ScreenSaverForm = New ScreenSaverForm(screen.Bounds)
            screensaver.Show()
        Next
    End Sub
End Module
