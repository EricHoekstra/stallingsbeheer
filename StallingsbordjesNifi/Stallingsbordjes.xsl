<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" indent="yes" media-type="text/html"/>
	<xsl:template match="planningen">
		<html>
			<body style='font-family: Helvetica Neue Std, Helvetica, Sans Serif; font-size: 11pt; line-height: 14pt'>
				<div>
					<xsl:for-each select="planning/Ligplaats[substring(.,1,2)='01']">
						<xsl:apply-templates select=".."/>
					</xsl:for-each>
				</div>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="planning">
		<xsl:element name="div">
			<!-- 
			De ligplaats voldoet aan onderstaande BNF. Daarvan wordt hieronder gebruik gemaakt 
			voor het positioneren in de CSS 3.0 Grid in de uitvoer.
				Ligplaats ::= <loodsnummer>-<rij><kolom>
				Loodsnummer ::= [0|1][0-9]
				Rij ::= [1-9]
				Kolom ::= [1-9]
			-->
			<xsl:attribute name="style">
				background-color: white; padding: 5px; border: none;
				grid-column-start: <xsl:value-of select="substring(Ligplaats,5,1)"/>;
				grid-column-end:   <xsl:value-of select="substring(Ligplaats,5,1) + 1"/>;
				grid-row-start:	   <xsl:value-of select="substring(Ligplaats,4,1) - 1"/>;
				grid-row-end:	   <xsl:value-of select="(substring(Ligplaats,4,1) + 1) * -1"/>;
			</xsl:attribute>
			<xsl:value-of select="Ligplaats"/>
			<br/>
			<xsl:value-of select="Boot"/>
			<br/>
			<xsl:value-of select="Bovendek"/>/ <xsl:value-of select="Onderwaterschip"/>
			<br/>
			<xsl:value-of select ="Lid"/>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>