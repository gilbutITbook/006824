<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMaximView.aspx.cs" Inherits="DevDapper.FrmMaximView" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>상세</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        번호: <asp:Label ID="lblId" runat="server"></asp:Label>         <br />
        이름: <asp:Label ID="lblName" runat="server"></asp:Label>       <br />
        명언: <asp:Label ID="lblContent" runat="server"></asp:Label>    <br />
        <hr />
        <asp:HyperLink ID="btnModify" runat="server">수정</asp:HyperLink>
        <asp:HyperLink ID="btnDelete" runat="server">삭제</asp:HyperLink>
        <asp:HyperLink ID="lnkList" runat="server" 
            NavigateUrl="~/FrmMaximList.aspx">리스트</asp:HyperLink>
    </div>
    </form>
</body>
</html>