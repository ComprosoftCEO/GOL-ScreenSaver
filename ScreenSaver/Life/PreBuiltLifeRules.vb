Imports Microsoft.Win32

''' <summary>
''' A bunch of pre-build rules for the game of life
''' </summary>
Module PreBuiltLifeRules
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

    ''' <summary>
    ''' Load the default life rules into the registry if no rules currently exist
    ''' </summary>
    Public Sub maybeCreateDefaultLifeRules(ByVal parentKey As RegistryKey)
        Dim rulesKey = parentKey.OpenSubKey("Rules")
        If rulesKey Is Nothing Then
            rulesKey = parentKey.CreateSubKey("Rules")

            Dim index As Integer = 0
            For Each rule As LifeRule In PRE_BUILT_RULES
                Dim subKey = rulesKey.CreateSubKey(index.ToString())
                Dim ruleEntry = New RegistryRuleEntry(rule)

                ruleEntry.saveToRegistry(subKey)
                subKey.SetValue(RULE_ENABLED_KEY, True)

                index += 1
            Next
        End If
    End Sub
End Module
