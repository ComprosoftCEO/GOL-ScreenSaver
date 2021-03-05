Imports Microsoft.Win32

Public Class RegistryRuleEntry
    Implements IComparable(Of RegistryRuleEntry)

    Private _begin As Integer
    Private _survive As Integer

    'Bitfield mask for begin and survive
    Private Const MASK As Integer = (1 << 9) - 1

    Public Property Name As String

    ''' <summary>
    ''' Bitfield integer for number of neighbors requied for a cell to begin
    ''' </summary>
    Public Property Begin As Integer
        Get
            Return Me._begin
        End Get
        Set(ByVal value As Integer)
            Me._begin = value And MASK
        End Set
    End Property

    ''' <summary>
    ''' Bitfield integer for number of neighbors requied for a cell to survive
    ''' </summary>
    Public Property Survive As Integer
        Get
            Return Me._survive
        End Get
        Set(ByVal value As Integer)
            Me._survive = value And MASK
        End Set
    End Property

    Public Sub New(Optional ByVal name As String = "<<New Rule>>",
                   Optional ByVal begin As Integer = 0, Optional ByVal survive As Integer = 0)

        Me._Name = name
        Me._begin = begin
        Me._survive = survive
    End Sub

    Public Sub New(ByVal rule As LifeRule)
        Me._Name = rule.Name
        Me._begin = 0
        Me._survive = 0

        For i As Integer = 0 To 8
            setBegin(i, rule.testBegin(i))
        Next

        For i As Integer = 0 To 8
            setSurvive(i, rule.testSurvive(i))
        Next
    End Sub

    ''' <summary>
    ''' Load from a registry key
    ''' </summary>
    Public Sub New(ByVal key As RegistryKey)
        Me.Name = key.GetValue(RULE_NAME_KEY, "<<New Rule>>")
        Me._begin = key.GetValue(RULE_BEGIN_KEY, 0)
        Me._survive = key.GetValue(RULE_SURVIVE_KEY, 0)
    End Sub

    ''' <summary>
    ''' Write this to the registry
    ''' </summary>
    Public Sub saveToRegistry(ByVal key As RegistryKey)
        key.SetValue(RULE_NAME_KEY, Me.Name)
        key.SetValue(RULE_BEGIN_KEY, Me._begin)
        key.SetValue(RULE_SURVIVE_KEY, Me._survive)
    End Sub

    ''' <summary>
    ''' Convert into a life rule
    ''' </summary>
    Public Function intoRule() As LifeRule
        Return New LifeRule(Me.Name, bitfieldToSet(Me._begin), bitfieldToSet(Me._survive))
    End Function

    Private Function bitfieldToSet(ByVal bitfield As Integer) As IEnumerable(Of Integer)
        Dim result As New List(Of Integer)(9)
        For i = 0 To 8
            If bitfield And (1 << i) Then
                result.Add(i)
            End If
        Next

        Return result
    End Function

    Public Sub setBegin(ByVal neighbors As Integer, Optional ByVal allow As Boolean = True)
        If allow Then
            Me._begin = Me._begin Or (1 << neighbors)
        Else
            Me._begin = Me._begin And (Not (1 << neighbors))
        End If

        Me._begin = Me._begin And MASK
    End Sub

    Public Sub setSurvive(ByVal neighbors As Integer, Optional ByVal allow As Boolean = True)
        If allow Then
            Me._survive = Me._survive Or (1 << neighbors)
        Else
            Me._survive = Me._survive And (Not (1 << neighbors))
        End If

        Me._survive = Me._survive And MASK
    End Sub

    Public Function Clone() As RegistryRuleEntry
        Return DirectCast(Me.MemberwiseClone(), RegistryRuleEntry)
    End Function

    Public Overrides Function ToString() As String
        Return Me.Name
    End Function

    Public Function CompareTo(ByVal other As RegistryRuleEntry) As Integer _
      Implements IComparable(Of RegistryRuleEntry).CompareTo
        Return Me.Name.CompareTo(other.Name)
    End Function
End Class
