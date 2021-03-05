Imports System.Runtime.InteropServices
Imports Microsoft.Win32


Public Class ScreenSaverForm

#Region "DLL-Imports"
    <DllImport("user32.dll")>
    Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Shared Function GetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll")>
    Shared Function GetClientRect(ByVal hWnd As IntPtr, ByRef lpRect As Rectangle) As Boolean
    End Function
#End Region

    Private mouseLocation As Point = Nothing
    Private previewMode As Boolean = False


    Private life As Life
    Private allRules As New List(Of LifeRule) From {New LifeRule("Life", {3}, {2, 3})}
    Private rand As New Random()

    Private randomBG As Boolean = False
    Private randomFG As Boolean = True
    Private generation As Integer = 0
    Private delayGenerations As Integer = 1000

    Private Const MOUSE_THRESHHOLD = 5

    ''' <summary>
    ''' Construct a form for normal fullscreen mode
    ''' </summary>
    Public Sub New(ByVal Bounds As Rectangle)
        InitializeComponent()

        Me.life = New Life(Me.allRules(0),
                   Math.Ceiling(CType(Bounds.Width, Double) / life.CELL_WIDTH),
                   Math.Ceiling(CType(Bounds.Height, Double) / life.CELL_WIDTH))

        Me.SetBounds(Bounds.Left, Bounds.Top, Bounds.Width, Bounds.Height)
    End Sub

    ''' <summary>
    ''' Construct a form for preview mode
    ''' </summary>
    Public Sub New(ByVal previewWndHandle As IntPtr)
        InitializeComponent()

        ' Set the preview window as the parent of this window
        SetParent(Me.Handle, previewWndHandle)

        ' Make this a child window so it will close when the parent dialog closes
        ' GWL_STYLE = -16, WS_CHILD = 0x40000000
        SetWindowLong(Me.Handle, -16, New IntPtr(GetWindowLong(Me.Handle, -16) Or &H40000000))

        ' Place our window inside the parent
        Dim parentRect As Rectangle
        GetClientRect(previewWndHandle, parentRect)
        Me.Size = parentRect.Size
        Me.Location = New Point(0, 0)

        ' Settings specific for preview mode
        Me.previewMode = True
        RuleLabel.Visible = False
        GenerationLabel.Visible = False

        'Resize the grid
        Me.life = New Life(Me.allRules(0),
                           Math.Ceiling(CType(parentRect.Size.Width, Double)),
                            Math.Ceiling(CType(parentRect.Size.Height, Double)))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadSettings()
        Me.randomize()

        ' Make it fullscreen
        Cursor.Hide()
        Me.TopMost = True

        ' Optimize the repaint
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        ' Start the timer
        PaintTimer.Start()
    End Sub

    ''' <summary>
    ''' Load all of the settings from the registry
    ''' </summary>
    Private Sub LoadSettings()
        Dim key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)

        Me.randomBG = CType(key.GetValue(RANDOM_BG_KEY, False), Boolean)
        Me.randomFG = CType(key.GetValue(RANDOM_FG_KEY, True), Boolean)

        If Not randomBG Then
            Me.life.BgColor = Color.FromArgb(key.GetValue(BG_COLOR_KEY, &HFFFFFFFFF))
        End If

        If Not randomFG Then
            Me.life.FgColor = Color.FromArgb(key.GetValue(FG_COLOR_KEY, &H0))
        End If

        Me.delayGenerations = key.GetValue(DELAY_GENERATIONS_KEY, 1000)

        'Load all of the rules
        PreBuiltLifeRules.maybeCreateDefaultLifeRules(key)

        Dim rulesKey = key.CreateSubKey("Rules")
        For Each subkeyName In rulesKey.GetSubKeyNames()

            'Skip rules that aren't enabled
            Dim subkey = rulesKey.OpenSubKey(subkeyName)
            Dim enabled As Boolean = subkey.GetValue(RULE_ENABLED_KEY, True)
            If Not Enabled Then
                Continue For
            End If

            Dim rule = New RegistryRuleEntry(subkey)
            Me.allRules.Add(rule.intoRule())
        Next
    End Sub

#Region "Handle Hide Screen Saver"

    Private Sub ScreenSaverForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Not mouseLocation.IsEmpty Then
            If Math.Abs(mouseLocation.X - e.X) > MOUSE_THRESHHOLD Or Math.Abs(mouseLocation.Y - e.Y) > MOUSE_THRESHHOLD Then
                EndScreensaver()
            End If
        End If

        mouseLocation = e.Location
    End Sub

    Private Sub ScreenSaverForm_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        EndScreensaver()
    End Sub

    Private Sub ScreenSaverForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        EndScreensaver()
    End Sub

    Private Sub EndScreensaver()
        If Not previewMode Then
            Application.Exit()
        End If
    End Sub
#End Region




#Region "Handle Drawing Code"
    Private Sub ScreenSaverForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
        e.Graphics.PixelOffsetMode = Drawing2D.PixelOffsetMode.Half
        e.Graphics.DrawImage(life.Image, 0, 0, Me.Width, Me.Height)
    End Sub

    Private Sub PaintTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaintTimer.Tick
        Me.generation += 1
        If Me.generation > Me.delayGenerations Then
            Me.randomize()
        Else
            Me.life.nextGeneration()
            GenerationLabel.Text = "Generation: " + Me.generation.ToString()
        End If

        Me.Refresh()
    End Sub

    Private Sub randomize()
        Me.generation = 0
        GenerationLabel.Text = "Generation: " + Me.generation.ToString()

        Me.life.Rule = Me.allRules(rand.Next() Mod allRules.Count())
        Me.life.randomizeGrid()
        RuleLabel.Text = life.Rule.toString()

        If Me.randomBG Then
            Me.life.BgColor = pickRandomColor()
        End If
        If Me.randomFG Then
            Me.life.FgColor = pickRandomColor()
        End If
    End Sub

    Private Function pickRandomColor() As Color
        Dim rand As New Random
        Return Color.FromArgb(255, rand.Next() Mod 255, rand.Next() Mod 255, rand.Next() Mod 255)
    End Function
#End Region
End Class
