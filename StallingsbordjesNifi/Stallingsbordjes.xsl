<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="html" indent="yes" media-type="text/html"/>

	<xsl:template match="planningen">
		<html>
			<body style='font-family: Helvetica Neue Std, Helvetica, Sans Serif; font-size: 11pt; line-height: 14pt'>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">01</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">02</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">03</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">04</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">05</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">06</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">07</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">08</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">09</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">10</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">11</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">12</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">13</xsl:with-param>
				</xsl:call-template>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">14</xsl:with-param>
				</xsl:call-template>
			</body>
		</html>
	</xsl:template>

	<xsl:template name="bordje">
		<xsl:param name="loodsnummer">99</xsl:param>
		<xsl:message>
			Start van het maken van bordje van loodsnummer '<xsl:value-of select="$loodsnummer"/>'.
		</xsl:message>
		<div style="background-color: lightgrey; display: grid; grid-template-columns: repeat(auto-fill, min-content); grid-template-rows: repeat(6, 1fr); grid-gap: 5px;">
			<xsl:for-each select="planning/Ligplaats[substring(.,1,2)=$loodsnummer]">
				<xsl:apply-templates select=".."/>
			</xsl:for-each>
		</div>
		<div style='font-weight: bold; text-align: center; margin-top: 5px; page-break-after: always; '>
			Loods <xsl:value-of select="$loodsnummer"/>
		</div>
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
				background-color: white; padding: 5px; border: none; grid-column-start: <xsl:value-of select="substring(Ligplaats,5,1)"/>; grid-column-end: <xsl:value-of select="substring(Ligplaats,5,1) + 1"/>; grid-row-start: <xsl:value-of select="substring(Ligplaats,4,1) * -1"/>;	grid-row-end: <xsl:value-of select="(substring(Ligplaats,4,1) * -1) -1"/>;
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