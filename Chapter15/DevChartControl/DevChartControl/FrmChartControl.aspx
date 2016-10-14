<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmChartControl.aspx.cs" 
    Inherits="DevChartControl.FrmChartControl" %>

<%@ Register Assembly=
"System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" 
Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ASP.NET Chart 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
<h3>선언적 방식</h3>
<asp:Chart ID="ctlChart1" runat="server">
    <Series>
        <asp:Series Name="Series1" ChartType="Column" YValuesPerPoint="2">
            <Points>
                <asp:DataPoint AxisLabel="국어" YValues="90,0" />
                <asp:DataPoint AxisLabel="영어" YValues="100,0" />
                <asp:DataPoint AxisLabel="수학" YValues="95,0" />
            </Points>
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </ChartAreas>
</asp:Chart>
<hr />
<h3>프로그래밍 방식</h3>
<asp:Chart ID="ctlChart2" runat="server">
    <Series>
        <asp:Series Name="Series1"></asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
    </ChartAreas>
</asp:Chart>
<hr />
<a href=
"http://weblogs.asp.net/scottgu/built-in-charting-controls-vs-2010-and-net-4-series">
http://weblogs.asp.net/scottgu/built-in-charting-controls-vs-2010-and-net-4-series
</a>
</div>
</form>
</body>
</html>
