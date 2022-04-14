Imports System
Imports System.IO
Imports Xunit
Imports Stallingsbordjes

Namespace LibraryTest
    Public Class Test
        <Fact>
        Sub TestAlwaysTrue()
            Assert.True(True)
        End Sub
        <Theory>
        <InlineData("""01-01"";""Verenigingslid1"";""Kanomerk1, Kanotype1"";""Bovendekkleur1"";""Onderwaterschipkleur1""")>
        Sub TestCsvOneLine(regel As String)
            Dim bestand As New Bestand(New String() {regel})
            Assert.Equal(bestand.Planningen(0).Regel, regel)
            Assert.True(regel.Contains(bestand.Planningen(0).Boot.Omschrijving))
            Assert.True(regel.Contains(bestand.Planningen(0).Boot.Bovendek))
            Assert.True(regel.Contains(bestand.Planningen(0).Boot.Onderwaterschip))
            Assert.True(regel.Contains(bestand.Planningen(0).Lid.Naam))
            Assert.True(regel.Contains(bestand.Planningen(0).Ligplaats.ToString()))
        End Sub
    End Class
End Namespace

