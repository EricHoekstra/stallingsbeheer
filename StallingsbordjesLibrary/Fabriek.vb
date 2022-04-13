Imports System.Text.RegularExpressions
''' <summary>
''' Een fabriek in deze oplossing is de relatie tussen een woord uit de regel en een object
''' uit het model. Bijvoorbeeld de LoodsFabriek legt de relatie tussen de eerste twee karakters
''' van de regel uit het CSV-bestand en een Loods-object.
''' </summary>
''' <remarks>Zie https://en.wikipedia.org/wiki/Factory_method_pattern.</remarks>
MustInherit Class Fabriek
        Protected Const SCHEIDINGSTEKEN = ";" ' TODO
        Protected Taal As Regex
    End Class
    Class LoodsFabriek
        Inherits Fabriek
        Sub New()
            Taal = New Regex("^""(\d\d)-\d\d(-\d)?"";[^;]*;[^;]*;[^;]*;[^;]*$")
        End Sub
        Function Maak(regel As String) As Object
            Dim loods As New Loods
            Dim woord As GroupCollection = Taal.Match(regel).Groups
            If woord.Count > 1 Then
                loods.Nummer = woord.Item(1).Value
            Else
                Throw New RegelException("Een loodsnummer kon niet worden bepaald uit '" & regel & "'.")
            End If
            Return loods
        End Function
    End Class
    Class LigplaatsFabriek
        Inherits Fabriek
        Sub New()
            Taal = New Regex("^""\d\d-(\d)(\d)(-\d)?"";[^;]*;[^;]*;[^;]*;[^;]*$")
        End Sub
        Function Maak(regel As String, loods As Loods) As Object
            Dim ligplaats As New Ligplaats(loods)
            Dim woord As GroupCollection = Taal.Match(regel).Groups
            If woord.Count > 2 Then
                ligplaats.Rij = woord.Item(1).Value
                ligplaats.Kolom = woord.Item(2).Value
            Else
                Throw New RegelException("Een ligplaats (vak) kon niet worden bepaald uit '" & regel & "'.")
            End If
            Return ligplaats
        End Function
    End Class
    Class LidFabriek
        Inherits Fabriek
        Sub New()
            Taal = New Regex("^[^;]*;""([^;]*)"";[^;]*;[^;]*;[^;]*$")
        End Sub
        Function Maak(regel As String) As Object
            Dim lid As New Lid
            Dim woord As GroupCollection = Taal.Match(regel).Groups
            If woord.Count > 1 Then
                lid.Naam = woord.Item(1).Value
            Else
                Throw New RegelException("Een lidnaam kon niet worden bepaald uit '" & regel & "'.")
            End If
            Return lid
        End Function
    End Class
    Class BootFabriek
        Inherits Fabriek
        Sub New()
            Taal = New Regex("^[^;]*;[^;]*;""([^;]*)"";""([^;]*)"";""([^;]*)""$")
        End Sub
        Function Maak(regel As String, lid As Lid) As Object
            Dim boot As New Boot(lid)
            Dim woord As GroupCollection = Taal.Match(regel).Groups
            If woord.Count > 3 Then
                boot.Omschrijving = woord.Item(1).Value
                boot.Bovendek = woord.Item(2).Value
                boot.Onderwaterschip = woord.Item(3).Value
            Else
                Throw New RegelException("De omschrijving en/of bovendek en/of onderwaterschap konden niet worden bepaald uit '" & regel & "'.")
            End If
            Return boot
        End Function
    End Class
