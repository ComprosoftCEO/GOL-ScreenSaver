Public Class LifeRule
    Private _begin As ISet(Of Integer)
    Private _survive As ISet(Of Integer)
    Private _name As String

    Public Sub New(ByVal name As String, ByVal begin As IEnumerable(Of Integer), ByVal survive As IEnumerable(Of Integer))
        Me._name = name
        Me._begin = New SortedSet(Of Integer)(begin)
        Me._survive = New SortedSet(Of Integer)(survive)
    End Sub

    Public ReadOnly Property Name As String
        Get
            Return Me._name
        End Get
    End Property

    Public ReadOnly Property Begin As ISet(Of Integer)
        Get
            Return Me._begin
        End Get
    End Property

    Public ReadOnly Property Survive As ISet(Of Integer)
        Get
            Return Me._survive
        End Get
    End Property

    Public Function testBegin(ByVal neighbors As Integer) As Boolean
        Return Me._begin.Contains(neighbors)
    End Function

    Public Function testSurvive(ByVal neighbors As Integer) As Boolean
        Return Me._survive.Contains(neighbors)
    End Function

    ''' <summary>
    ''' Format a string for the rule. For example: B23/S3
    ''' </summary>
    Public Overrides Function toString() As String
        Dim result As String = Me.Name + " (B"
        For Each b In Me._begin
            result += b.ToString()
        Next
        result += "/S"
        For Each s In Me._survive
            result += s.ToString()
        Next
        result += ")"

        Return result
    End Function
End Class
