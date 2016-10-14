<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmCalendar.aspx.cs" Inherits="DevStandardControl.FrmCalendar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>캘린더 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:Calendar ID="Calendar1" runat="server" 
        OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    <hr />
    <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" 
        BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px"  
        ShowGridLines="True" Width="220px">
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px">
        </DayHeaderStyle>
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC"></NextPrevStyle>
        <OtherMonthDayStyle ForeColor="#CC9966"></OtherMonthDayStyle>
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True"></SelectedDayStyle>
        <SelectorStyle BackColor="#FFCC66"></SelectorStyle>
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
            ForeColor="#FFFFCC"></TitleStyle>
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White"></TodayDayStyle>
    </asp:Calendar>
</div>
</form>
</body>
</html>