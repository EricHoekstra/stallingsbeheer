<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns="http://www.w3.org/1999/xhtml">

	<!-- XHTML 1.1 document, zie https://www.w3.org/TR/xhtml11/ -->
	<xsl:output method="xml" indent="yes" media-type="text/html" encoding="utf-8" doctype-public="-//W3C//DTD XHTML 1.1//EN" doctype-system="http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd" omit-xml-declaration="yes" />

	<xsl:template match="planningen">
		<html>
			<body style='font-family: Helvetica Neue Std, Helvetica, Sans Serif; font-size: 11pt; line-height: 14pt'>
				<xsl:call-template name="bordje">
					<xsl:with-param name="loodsnummer">1</xsl:with-param>
				</xsl:call-template>
			</body>
		</html>
	</xsl:template>

	<xsl:template name="bordje">
		<xsl:param name="loodsnummer"/>
		<xsl:message>
			Start van het maken van bordje van loodsnummer '<xsl:value-of select="$loodsnummer"/>'.
		</xsl:message>
		<div style="background-color: lightgrey; display: grid; grid-template-columns: repeat(auto-fill, min-content); grid-template-rows: repeat(6, 1fr); grid-gap: 5px;">
			<xsl:for-each select="planning/Ligplaats[substring(.,1,2)=format-number($loodsnummer, '00')]">
				<xsl:apply-templates select=".."/>
			</xsl:for-each>
		</div>
		<div style='font-weight: bold; text-align: center; margin-top: 5px; page-break-after: always; '>
			Loods <xsl:value-of select="$loodsnummer"/>
		</div>
		<xsl:if test="$loodsnummer &lt; 14">
			<xsl:call-template name="bordje">
				<xsl:with-param name="loodsnummer">
					<xsl:value-of select="$loodsnummer + 1"/>
				</xsl:with-param>
			</xsl:call-template>
		</xsl:if>
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
				background-color: white; padding: 5px; border: none; grid-column-start: <xsl:value-of select="substring(Ligplaats,5,1)"/>; grid-column-end: <xsl:value-of select="substring(Ligplaats,5,1) + 1"/>; grid-row-start: <xsl:value-of select="substring(Ligplaats,4,1) * -1"/>; grid-row-end: <xsl:value-of select="(substring(Ligplaats,4,1) * -1) - 1"/>;
			</xsl:attribute>
			<xsl:value-of select="Ligplaats"/>
			<br/>
			<xsl:value-of select="Boot"/>
			<br/>
			<!-- Als de kleur van het bovendek en het onderwaterschip gelijk zijn, dan wordt slechts een van beiden afgedrukt. Om twee elementen (nodes) te vergelijken is een variabele nodig. -->
			<xsl:value-of select="Bovendek"/>
			<xsl:variable name="onderwaterschip" select="Onderwaterschip"/>
			<xsl:if test="not(Bovendek = $onderwaterschip)">
				/ <xsl:value-of select="Onderwaterschip"/>
			</xsl:if>
			<br/>
			<xsl:value-of select ="Lid"/>
		</xsl:element>
	</xsl:template>
</xsl:stylesheet>