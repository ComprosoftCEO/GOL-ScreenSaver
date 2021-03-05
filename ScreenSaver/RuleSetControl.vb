Public Class RuleSetControl


    Private Const MASK As Integer = (1 << 9) - 1

    ''' <summary>
    ''' Integer bitfield representing a game of life rule with up to 8 neighbors
    ''' </summary>
    Public Property Rule As Integer
        Get
            Dim value As Integer = 0
            setBit(value, 0, Chk0Neighbors.Checked)
            setBit(value, 1, Chk1Neighbors.Checked)
            setBit(value, 2, Chk2Neighbors.Checked)
            setBit(value, 3, Chk3Neighbors.Checked)
            setBit(value, 4, Chk4Neighbors.Checked)
            setBit(value, 5, Chk5Neighbors.Checked)
            setBit(value, 6, Chk6Neighbors.Checked)
            setBit(value, 7, Chk7Neighbors.Checked)
            setBit(value, 8, Chk8Neighbors.Checked)

            Return value
        End Get
        Set(ByVal value As Integer)
            Chk0Neighbors.Checked = getBit(value, 0)
            Chk1Neighbors.Checked = getBit(value, 1)
            Chk2Neighbors.Checked = getBit(value, 2)
            Chk3Neighbors.Checked = getBit(value, 3)
            Chk4Neighbors.Checked = getBit(value, 4)
            Chk5Neighbors.Checked = getBit(value, 5)
            Chk6Neighbors.Checked = getBit(value, 6)
            Chk7Neighbors.Checked = getBit(value, 7)
            Chk8Neighbors.Checked = getBit(value, 8)

            RaiseEvent ValueChanged(Me)
        End Set
    End Property

    Private Sub setBit(ByRef value As Integer, ByVal bit As Integer, ByVal bitSet As Boolean)
        If bitSet Then
            value = value Or (1 << bit)
        Else
            value = value And (Not (1 << bit))
        End If
    End Sub

    Private Function getBit(ByVal value As Integer, ByVal bit As Integer) As Boolean
        Return value And (1 << bit)
    End Function

    Private Sub ChkNeighbors_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk0Neighbors.CheckedChanged, Chk1Neighbors.CheckedChanged, Chk2Neighbors.CheckedChanged, Chk3Neighbors.CheckedChanged, Chk4Neighbors.CheckedChanged, Chk5Neighbors.CheckedChanged, Chk6Neighbors.CheckedChanged, Chk7Neighbors.CheckedChanged, Chk8Neighbors.CheckedChanged
        RaiseEvent ValueChanged(Me)
    End Sub

    Public Event ValueChanged(ByVal sender As System.Object)

End Class
