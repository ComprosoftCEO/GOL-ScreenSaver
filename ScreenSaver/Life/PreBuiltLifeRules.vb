Module PreBuiltLifeRules
    Private ReadOnly RAND As New Random()
    Private ReadOnly PRE_BUILT_RULES As LifeRule() = {
        New LifeRule("Amoeba", {3, 5, 7}, {1, 3, 5, 8}),
        New LifeRule("Anneal", {4, 6, 7, 8}, {3, 5, 6, 7, 8}),
        New LifeRule("Assimilation", {3, 4, 5}, {4, 5, 6}),
        New LifeRule("Coagulations", {3, 7, 8}, {2, 3, 5, 6, 7, 8}),
        New LifeRule("Day and Night", {3, 6, 7, 8}, {3, 4, 6, 7, 8}),
        New LifeRule("Diamoeba", {3, 5, 6, 7, 8}, {5, 6, 7, 8}),
        New LifeRule("Gnarl", {1}, {1}),
        New LifeRule("High Life", {3, 6}, {2, 3}),
        New LifeRule("Life Without Death", {3}, {0, 1, 2, 3, 4, 5, 6, 7, 8}),
        New LifeRule("Long Life", {5}, {3, 4, 5}),
        New LifeRule("Maze", {3}, {1, 2, 3, 4, 5}),
        New LifeRule("Morley", {3, 6, 8}, {2, 4, 5}),
        New LifeRule("Mystery", {3, 4, 5, 8}, {0, 5, 6, 7, 8}),
        New LifeRule("Pseudo-Life", {3, 5, 7}, {2, 3, 8}),
        New LifeRule("Replicator 1", {1, 3, 5, 7}, {1, 3, 5, 7}),
        New LifeRule("Replicator 2", {2, 5}, {4}),
        New LifeRule("Seeds", {2}, {}),
        New LifeRule("Stains", {3, 6, 7, 8}, {2, 3, 5, 6, 7, 8}),
        New LifeRule("Walled Cities", {4, 5, 6, 7, 8}, {2, 3, 4, 5}),
        New LifeRule("2x2", {3, 6}, {1, 2, 5}),
        New LifeRule("34", {3, 4}, {3, 4})
    }

    Public Function randomRule() As LifeRule
        Return New LifeRule("Life", {3}, {2, 3})
        'Return PRE_BUILT_RULES(RAND.Next() Mod PRE_BUILT_RULES.Length)
    End Function
End Module
