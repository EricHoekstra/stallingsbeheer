Imports System
Imports System.IO
Imports System.Xml
Imports System.Xml.Xsl

Module Program
    Sub Main(args As String())

        ' De volgende structuur van de XML is een preconditie. Het aantal keren dat planning herhaalt
        ' wordt ligt tussen 0 en oneindig. Ieder planning element bevat de genoemde vijf subelementen,
        ' en niets anders meer.
        '
        ' <?xml version="1.0"?>
        ' <planningen>
        '     <planning>
        '         <Ligplaats>01-11</Ligplaats>
        '         <Lid>KV de Windhappers</Lid>
        '         <Boot>Rainbow Kayaks, Oasis Max 430</Boot>
        '         <Bovendek>gevlekt-oranje</Bovendek>
        '         <Onderwaterschip>geel</Onderwaterschip>
        '     </planning>
        '     <planning>
        '         <Ligplaats>02-12</Ligplaats>
        '         <Lid>KV de Windhappers</Lid>
        '         <Boot>Rainbow Kayaks, Oasis Max 430</Boot>
        '         <Bovendek>geel</Bovendek>
        '         <Onderwaterschip>geel</Onderwaterschip>
        '     </planning>
        ' </planningen>

        Dim csv As String() = File.ReadAllLines("S:\Windows10Workstation\MicrosoftDotNet\Stallingbeheer\StallingsbordjesXslt\Stallingsbordjes.csv", System.Text.Encoding.GetEncoding("ISO-8859-1"))
        Dim document As New XDocument(
            New XElement("planningen",
                csv.Select(Of XElement)(
                    Function(regel As String)
                        Return New XElement("planning",
                            New XElement("Ligplaats", regel.Replace("""", "").Split(";")(0)),
                            New XElement("Lid", regel.Replace("""", "").Split(";")(1)),
                            New XElement("Boot", regel.Replace("""", "").Split(";")(2)),
                            New XElement("Bovendek", regel.Replace("""", "").Split(";")(3)),
                            New XElement("Onderwaterschip", regel.Replace("""", "").Split(";")(4))
                    )
                    End Function
                )
            )
        )
        Using _
        s As XmlReader = XmlReader.Create("S:\Windows10Workstation\MicrosoftDotNet\Stallingbeheer\StallingsbordjesXslt\Stallingsbordjes.xsl"),
        w As XmlWriter = XmlWriter.Create("S:\Windows10Workstation\MicrosoftDotNet\Stallingbeheer\StallingsbordjesXslt\Stallingsbordjes.html")
            Dim t As New XslCompiledTransform()
            t.Load(s)
            t.Transform(document.CreateReader(), w)
        End Using
    End Sub
End Module
