## Over dit project
Het project is een kennismaking met Visual Basic .NET. De software kan een CSV-bestand converteren naar een HTML-bestand. Het CSV-bestand is opgemaakt volgens een bepaalde definitie, zie hieronder. De HTML-uitvoer zijn de z.g. stallingsbordjes. Die hangen in de loods van Kanovereniging De Windhappers. Op zo'n bordje is de relatie tussen een ligplaats en een boot aangegeven. Ieder lid van de vereniging kan een ligplaats toegewezen krijgen.

### Opmaak van het CSV-invoerbestand
Een regel uit het CSV-bestand bestaat uit vijf strings gescheiden door punt-komma's:
1. een ligplaatsnummer;
2. naam van het lid;
3. omschrijving van de boot (merk en type);
4. kleur van het bovendek;
5. kleur van het onderwaterschip.

Bijvoorbeeld:
"11-54";"Eric Hoekstra";"Nelo Quattro Classic K1";"wit";"wit"

### Opmaak van het HTML-uitvoerbestand
Het uitvoerbestand bestaat uit een aantal tabellen opgemaakt met een CSS Grid. Iedere tabel wordt op één pagina's geprint. Pagina's moeten op A4 liggend afgedrukt worden. 

## Verantwoording van het ontwerp
### StallingsbordjesLibrary-project
Het voornaamste onderdeel van de oplossing is de .NET-bibliotheek Stallingsbordjes. Deze bevat allereerst een klassemodel met een klasse voor: het lid, de boot, de ligplaats, enz. Het tweede onderdeel, de fabriek, lost de relatie op tussen een regel in het CSV-invoerbestand en een object in het geheugen van het programma. Bijvoorbeeld  Bijvoorbeeld de LoodsFabriek legt de relatie tussen de eerste twee karakters van de regel uit het CSV-bestand en een Loods-object. Het derde en laatst onderdeel, Bordjes, neemt het genereren van de HTML voor zijn rekening. 

### StallingsbordjesWizard-project
Gegeven een programmabibliotheek kunnen voor verschillende uitvoeringen gekozen worden. Hier is gekozen voor een Windows Forms applicatie in de vorm van een wizard.

## Bekende problemen
* Alleen een punt-komma als scheidingsteken in het CSV-bestand.
* Een dubbele apostrof rond de strings in het CSV-bestand is verplicht.
* De kopregel van het CSV-bestand wordt niet (optioneel) genegeerd.
* De wizard kan mooier opgelost worden met een panelwaarop de _controls_ steeds wisselen. Gekozen is voor een oplossing van drie aparte formulieren die elkaar tonen/ verbergen.
* In het model is omwille van eenvoud afgezien van encapsulatie van eigenschappen. 
* Omdat de software sterk afhankelijk is van de structuur van het CSV-bestand moet nog een controle worden toegevoegd die de gebruiker waarschuwt als die structuur niet aan de verwachting voldoet.

## Starten
Start de wizard en kies het bestand Voorbeeld.csv uit dat project. 

## Auteur
Eric Hoekstra, 2022, geen copyrights.