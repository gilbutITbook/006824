<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmDataList.aspx.cs" Inherits="DevDataControl.FrmDataList" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>DataList 컨트롤</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <asp:DataList ID="ctlMemoList" runat="server"
        DataSourceID="sdsMemoList" BorderWidth="1px" 
        RepeatColumns="3" RepeatDirection="Horizontal">
        <HeaderTemplate>
            <span>이름</span>
        </HeaderTemplate>
        <HeaderStyle Font-Bold="true" />
        <ItemTemplate>
            <%# Eval("Name") %>
        </ItemTemplate>
        <ItemStyle ForeColor="Green" />
        <AlternatingItemTemplate>
            <%# DataBinder.Eval(Container.DataItem, "Name") %>
        </AlternatingItemTemplate>
        <AlternatingItemStyle ForeColor="Blue" />
    </asp:DataList>
    <asp:SqlDataSource ID="sdsMemoList" runat="server"
        ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>"
        SelectCommand="Select * From Memos Order By Num Desc">
    </asp:SqlDataSource>
</div>
</form>
</body>
</html>
