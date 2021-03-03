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

    Private mouseLocation As Point
    Private previewMode As Boolean = False

    Private Const MOUSE_THRESHHOLD = 5


    Public Sub New(ByVal Bounds As Rectangle)
        InitializeComponent()
        Me.SetBounds(Bounds.Left, Bounds.Top, Bounds.Width, Bounds.Height)
    End Sub

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

        Me.previewMode = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadSettings()

        Cursor.Hide()
        Me.TopMost = True
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

    Private Sub LoadSettings()
        Dim key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)
        If key Is Nothing OrElse CType(key.GetValue("randomRule"), Boolean) Then
            Me.BackColor = Color.Aqua
        Else
            Me.BackColor = Color.Coral
        End If
    End Sub

End Class
