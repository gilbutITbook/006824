<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMaximDelete.aspx.cs" Inherits="DevDapper.FrmMaximDelete" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>삭제</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblId" runat="server"></asp:Label>
        번 글을 삭제하시겠습니까?
        <asp:Button ID="btnDelete" runat="server" Text="삭제" 
            OnClick="btnDelete_Click" />
        <hr />
        <asp:HyperLink ID="lnkList" runat="server" 
            NavigateUrl="~/FrmMaximList.aspx">리스트</asp:HyperLink>
    </div>
    </form>
</body>
</html>