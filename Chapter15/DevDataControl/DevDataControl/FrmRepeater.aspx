<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="FrmRepeater.aspx.cs" Inherits="DevDataControl.FrmRepeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Repeater 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:Repeater ID="ctlMemoList" runat="server" 
        DataSourceID="sdsMemoList">
        <HeaderTemplate>
            <table border="0">
                <tr><td>제목</td></tr>
        </HeaderTemplate>
        <ItemTemplate>
                <tr><td><%# Eval("Title") %></td><tr>
        </ItemTemplate>  
        <AlternatingItemTemplate>
                <tr><td style="background-color:yellow;">
                    <%# Eval("Title") %></td></tr>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
                <tr><td style="height:1px;background-color:Red;"></td></tr>
        </SeparatorTemplate>
        <FooterTemplate>
                <tr><td>완료</td></tr>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <asp:SqlDataSource ID="sdsMemoList" runat="server" 
        ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>" 
        SelectCommand=
            "SELECT [Num], [Name], [Title] FROM [Memos] ORDER BY [Num] DESC">
    </asp:SqlDataSource>
</div>
</form>
</body>
</html>
