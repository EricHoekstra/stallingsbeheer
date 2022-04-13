Imports System.IO
Imports System.Collections
''' <summary>Representeert ieder CSV-bestand.</summary>
Public Class Bestand
    ''' <summary>
    ''' Scheidingsteken dat de kolommen in een CSV-regel scheidt. Nog niet geïmplementeerd.
    ''' </summary>
    Const SCHEIDINGSTEKEN As Char = ";"c
    ''' <summary>
    ''' De lijst met planningen die afgeleid kon worden uit de verzameling CSV-regels.
    ''' </summary>
    Public Planningen As New List(Of Planning)
    ''' <summary>
    ''' Regels waaruit geen planning kon worden afgeleidt. Deze regels zijn genegeerd. Het 
    ''' aantal elementen in de verzameling Planningen plus het aantal onverwerkte regels is
    ''' het totaal aantal regels dat is aangeboden aan de constructor.
    ''' </summary>
    Public OnverwerkteRegels As New List(Of String)
    ''' <summary>
    ''' Bepaalt de verzameling planningen uit de verzameling regels. Het aantal planningen moet 
    ''' gelijk zijn aan het aantal regels plus de excepties.
    ''' </summary>
    ''' <param name="regels">De regels uit een CSV-bestand.</param>
    Sub New(regels As String())
        For Each r As String In regels
            Try
                Me.Planningen.Add(New Planning(r))
            Catch ex As RegelException
                Me.OnverwerkteRegels.Add(r)
            End Try
        Next
        Return
    End Sub
End Class
''' <summary>
''' De relatie regel × loods × ligplaats × lid × boot. Deze relatie zou 'planning' genoemd kunnen
''' worden zoals die In e-Captain genoemd Is. In termen van het relationele model (Codd, 1970)
''' bestaan er transitieve afhankelijkheden, maar dat maakt voor deze toepassing niet uit, omdat
''' objecten niet gewijzigd worden.
''' </summary>
Public Class Planning
    Public Regel As String
    Public Loods As Loods
    Public Ligplaats As Ligplaats
    Public Lid As Lid
    Public Boot As Boot
    Sub New(regel As String)
        Me.Regel = regel
        Me.Loods = (New LoodsFabriek).Maak(regel)
        Me.Ligplaats = (New LigplaatsFabriek).Maak(regel, Me.Loods)
        Me.Lid = (New LidFabriek).Maak(regel)
        Me.Boot = (New BootFabriek).Maak(regel, Me.Lid)
    End Sub
End Class
Public Class Lid
    Public Naam As String
    Sub New() : End Sub
End Class
''' <summary>Representeert een van de loodsen van het verenigingsgebouw waarin kano's opgeborgen worden.</summary>
''' <exception cref="RegelException">Gooit een RegelExceptie als het loodsnummer niet uit de regel bepaald kan worden.</exception>
Public Class Loods
    Implements IEquatable(Of Loods)
    Public Nummer As Integer
    ''' <summary>Implementeert IEquatable.Equals zodat de Distinct Query operator twee loodsen kan vergelijken.</summary>
    ''' <param name="l">De loods die vergeleken moet worden.</param>
    ''' <returns>Waar als beide loodsen hetzelfde nummer dragen.</returns>
    ''' <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct?view=net-6.0#system-linq-enumerable-distinct-1(system-collections-generic-ienumerable((-0)))"/>
    Public Function Equals(l As Loods) As Boolean Implements IEquatable(Of Loods).Equals
        Return (Me.Nummer = l.Nummer)
    End Function
    ''' <summary>Als twee loodsen gelijk zijn, zie Equals(Loods) dan moeten ook de hashcodes gelijk zijn.</summary>
    ''' <returns>Het nummer van de loods als hashcode.</returns>
    Public Overrides Function GetHashCode() As Integer
        Return Me.Nummer
    End Function
End Class
Public Class Ligplaats
    Public Loods As Loods
    Public Rij As Integer
    Public Kolom As Integer
    Sub New(loods As Loods)
        Me.Loods = loods
    End Sub
End Class
Public Class Boot
    Public Lid As Lid
    Public Omschrijving As String
    Public Bovendek As String
    Public Onderwaterschip As String
    Sub New(lid As Lid)
        Me.Lid = lid
    End Sub
    Sub New(lid As Lid, regel As String)
        Me.Lid = lid
    End Sub
End Class
Public Class RegelException
    Inherits Exception
    Sub New(message As String)
        MyBase.New(message)
    End Sub
End Class
