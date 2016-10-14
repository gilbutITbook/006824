<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMemoSearch.aspx.cs" Inherits="DevADONET.FrmMemoSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>검색 패턴</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>데이터 검색</h3>
        <asp:DropDownList ID="lstSearchField" runat="server">
            <asp:ListItem Value="Name" Selected="True">이름</asp:ListItem>
            <asp:ListItem Value="Title" >메모</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtSearchQuery" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="검색"
            OnClick="btnSearch_Click" />
        <hr />
        <asp:GridView ID="ctlMemoSearchList" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
