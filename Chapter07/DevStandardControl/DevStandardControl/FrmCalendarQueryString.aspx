<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCalendarQueryString.aspx.cs" 
    Inherits="DevStandardControl.FrmCalendarQueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            넘겨온 값: <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" 
                OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </div>
    </form>
</body>
</html>
