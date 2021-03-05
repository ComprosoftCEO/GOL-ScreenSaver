Public Class Life

    Public Property Rule As LifeRule
    Private grid As Boolean(,)
    Private nextImage As Image

    Private _fgColor As Color = Color.White
    Private _bgColor As Color = Color.Black

    Public Const CELL_WIDTH As Integer = 10

    Public Sub New(ByVal rule As LifeRule, ByVal width As UInteger, ByVal height As UInteger)
        Me.Rule = rule

        Dim array(width - 1, height - 1) As Boolean
        Me.grid = array
        Me.randomizeGrid()
    End Sub

    Public Property Width As Integer
        Get
            Return Me.grid.GetLength(0)
        End Get

        Set(ByVal newWidth As Integer)
            ReDim Preserve Me.grid(newWidth - 1, Me.Height - 1)
        End Set
    End Property

    Public Property Height As Integer
        Get
            Return Me.grid.GetLength(1)
        End Get

        Set(ByVal newHeight As Integer)
            ReDim Preserve Me.grid(Me.Width - 1, newHeight - 1)
        End Set
    End Property

    Public Property FgColor As Color
        Get
            Return Me._fgColor
        End Get
        Set(ByVal value As Color)
            Me._fgColor = value
            Me.buildNextImage()
        End Set
    End Property

    Public Property BgColor As Color
        Get
            Return Me._bgColor
        End Get
        Set(ByVal value As Color)
            Me._bgColor = value
            Me.buildNextImage()
        End Set
    End Property

    Public ReadOnly Property Image
        Get
            Return Me.nextImage
        End Get
    End Property

    Public Sub randomizeGrid()
        Dim rand = New Random()
        For x = 0 To Me.Width - 1
            For y = 0 To Me.Height - 1
                Me.grid(x, y) = (rand.NextDouble() > 0.7)
            Next
        Next

        buildNextImage()
    End Sub

    Public Sub nextGeneration()
        Dim newGrid(Me.Width - 1, Me.Height - 1) As Boolean
        For x = 0 To Me.Width - 1
            For y = 0 To Me.Height - 1
                Dim neighbors = Me.countNeighbors(x, y)
                If Me.grid(x, y) Then
                    newGrid(x, y) = Me.Rule.testSurvive(neighbors)
                Else
                    newGrid(x, y) = Me.Rule.testBegin(neighbors)
                End If
            Next
        Next

        Me.grid = newGrid
        buildNextImage()
    End Sub

    Private Function countNeighbors(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim neighbors As Integer = 0

        If getCell(x - 1, y - 1) Then neighbors += 1
        If getCell(x - 1, y) Then neighbors += 1
        If getCell(x - 1, y + 1) Then neighbors += 1
        If getCell(x, y - 1) Then neighbors += 1
        If getCell(x, y + 1) Then neighbors += 1
        If getCell(x + 1, y - 1) Then neighbors += 1
        If getCell(x + 1, y) Then neighbors += 1
        If getCell(x + 1, y + 1) Then neighbors += 1

        Return neighbors
    End Function

    Private Function getCell(ByVal x As Integer, ByVal y As Integer) As Boolean
        If x < 0 Or x >= Me.Width Or y < 0 Or y >= Me.Height Then
            'Outside grid, so return false
            Return False
        Else
            Return Me.grid(x, y)
        End If
    End Function

    Private Sub buildNextImage()
        Dim image = New Bitmap(Me.Width * CELL_WIDTH, Me.Height * CELL_WIDTH)
        Dim g = Graphics.FromImage(image)

        Dim fgBrush = New SolidBrush(Me.FgColor)
        Dim bgBrush = New SolidBrush(Me.BgColor)

        ' Clear the grid
        g.FillRectangle(bgBrush, 0, 0, image.Width, image.Height)

        ' Draw the life cells
        For x = 0 To Me.Width - 1
            For y = 0 To Me.Height - 1
                If Me.grid(x, y) Then
                    g.FillRectangle(fgBrush, x * CELL_WIDTH, y * CELL_WIDTH, CELL_WIDTH, CELL_WIDTH)
                End If
            Next
        Next

        Me.nextImage = image
    End Sub

End Class
