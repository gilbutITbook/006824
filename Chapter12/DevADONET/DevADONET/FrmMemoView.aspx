<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="FrmMemoView.aspx.cs" Inherits="DevADONET.FrmMemoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>상세 보기 패턴</title>
</head>
<body>
<form id="form1" runat="server">
<div>
    <h3>상세 보기</h3>
    번호:
    <asp:Label ID="lblNum" runat="server"></asp:Label><br />
    이름:
    <asp:Label ID="lblName" runat="server"></asp:Label><br />
    이메일:
    <asp:Label ID="lblEmail" runat="server"></asp:Label><br />
    메모:
    <asp:Label ID="lblTitle" runat="server"></asp:Label><br />
    작성일:
    <asp:Label ID="lblPostDate" runat="server"></asp:Label><br />
    IP주소:
    <asp:Label ID="lblPostIP" runat="server"></asp:Label><br />
    <hr />
    <asp:HyperLink ID="lnkMemoModify" runat="server">수정</asp:HyperLink>
    <asp:HyperLink ID="lnkMemoDelete" runat="server">삭제</asp:HyperLink>
    <asp:HyperLink ID="lnkMemoList" runat="server" 
        NavigateUrl="~/FrmMemoList.aspx">리스트</asp:HyperLink>
</div>
</form>
</body>
</html>
