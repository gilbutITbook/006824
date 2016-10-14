<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmSqlDataSource.aspx.cs" 
    Inherits="DevDataControl.FrmSqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SqlDataSource 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:DropDownList ID="lstMemoName" runat="server" 
        DataSourceID="sdsMemoName" DataTextField="Name" DataValueField="Num">
    </asp:DropDownList>
    <asp:SqlDataSource ID="sdsMemoName" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>" 
        SelectCommand="SELECT [Num], [Name] FROM [Memos] ORDER BY [Num] DESC">
    </asp:SqlDataSource>
</div>
</form>
</body>
</html>
