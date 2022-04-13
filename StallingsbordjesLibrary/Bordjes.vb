Imports System.Text
Public Class Bordjes
    Public Bestand As Bestand
    Sub New(regels As String())
        Me.Bestand = New Bestand(regels)
    End Sub
    Public Function ToHtml() As String
        Dim planningen = Me.Bestand.Planningen
        Dim html As New StringBuilder
        html.AppendLine("<!DOCTYPE html>")
        html.AppendLine("<html><body style='font-family: Helvetica Neue Std, Helvetica, Sans Serif; font-size: 11pt; line-height: 14pt'>")
        ' Voor iedere loods in de verzameling loodsen.
        Dim loodsen = From p In planningen Select p.Ligplaats.Loods Distinct
        For Each l In loodsen
            html.AppendLine("<div style='background-color: lightgrey; display: grid; grid-template-columns: repeat(auto-fill, min-content); grid-template-rows: repeat(6, 1fr); grid-gap: 5px;'>")
            ' Voor iedere rij in een loods
            Dim rijen = From p In planningen
                        Where p.Ligplaats.Loods.Nummer = l.Nummer
                        Select p.Ligplaats.Rij Distinct
                        Order By Rij Descending
            For Each r In rijen
                ' Voor iedere planning van een rij
                Dim planningen_rij = From p In planningen
                                     Where p.Ligplaats.Loods.Nummer = l.Nummer And p.Ligplaats.Rij = r
                                     Select p.Ligplaats.Loods.Nummer, p.Ligplaats.Rij, p.Ligplaats.Kolom, p.Boot.Omschrijving, p.Boot.Bovendek, p.Boot.Onderwaterschip, p.Boot.Lid.Naam
                                     Distinct
                For Each p In planningen_rij
                    html.AppendLine($"<div style='background-color: white; padding: 5px; border: none; grid-column-start: {p.Kolom}; grid-column-end: {p.Kolom + 1}; grid-row-start: {p.Rij * -1}; grid-row-end: {(p.Rij + 1) * -1};'>")
                    html.AppendLine($"{p.Nummer}-{p.Rij}{p.Kolom}<br/>{p.Omschrijving}<br/>{p.Bovendek}{If(p.Bovendek = p.Onderwaterschip, "", ", " & p.Onderwaterschip)}<br/>{p.Naam}")
                    html.AppendLine("</div>")
                Next
            Next
            html.AppendLine("</div>")
            html.AppendLine($"<div style='font-weight: bold; text-align: center; padding-top: 5px; page-break-after: always; '>Loods {l.Nummer}</div>")
        Next
        html.AppendLine("</body></html>")
        Return html.ToString()
    End Function
End Class
