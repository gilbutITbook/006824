<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/Company">
<html>
<body>
<h1>회사소개</h1>
<table border="1" style="width:500px;">
	<tr>
		<td width="180">
			사업자명
		</td>
		<td>
			<xsl:value-of select="CompanyName"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td width="180">
			사업자번호 
		</td>
		<td>
			<xsl:value-of select="CompanyNumber"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td>
			소재지
		</td>
		<td>
			<xsl:value-of select="CompanyAddress"></xsl:value-of>
			<xsl:value-of select="CompanyAddressDetail"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td>
			전화번호
		</td>
		<td>
			<xsl:value-of select="Phone"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td>
			팩스번호
		</td>
		<td>
			<xsl:value-of select="Fax"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td>
			이메일
		</td>
		<td>
			<xsl:value-of select="Email"></xsl:value-of>
		</td>
	</tr>
	<tr>
		<td>
			통신 판매업무 책임자
		</td>
		<td>
			<xsl:value-of select="Operator"></xsl:value-of>
		</td>
	</tr>
</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>
